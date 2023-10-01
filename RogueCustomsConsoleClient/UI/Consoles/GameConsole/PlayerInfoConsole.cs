﻿using SadConsole;
using SadConsole.UI.Controls;
using RogueCustomsConsoleClient.EngineHandling;
using RogueCustomsConsoleClient.Helpers;
using RogueCustomsConsoleClient.UI.Consoles.Containers;
using RogueCustomsConsoleClient.UI.Consoles.GameConsole.GameWindows;
using SadRogue.Primitives;
using RogueCustomsConsoleClient.Resources.Localization;
using System;
using System.Linq;
using SadConsole.UI;

namespace RogueCustomsConsoleClient.UI.Consoles.GameConsole
{
    public class PlayerInfoConsole : GameSubConsole
    {
        private string DetailsButtonText;
        private ProgressBar HPBar;
        public Button DetailsButton;

        public PlayerInfoConsole(GameConsoleContainer parent) : base(parent, GameConsoleConstants.PlayerInfoCellWidth, GameConsoleConstants.PlayerInfoCellHeight)
        {
            Build();
        }

        public void Build()
        {
            base.Build();
            Font = Game.Instance.LoadFont("fonts/IBMCGA.font");
            RefreshOnlyOnStatusUpdate = true;
            DetailsButtonText = $" {LocalizationManager.GetString("DetailsButtonText")} ".ToAscii();
            DetailsButton = new Button(DetailsButtonText.Length, 1)
            {
                Position = new Point((Width - DetailsButtonText.Length) / 2, 38),
                Text = DetailsButtonText
            };
            DetailsButton.Click += DetailsButton_Click;

            HPBar = new ProgressBar(Width - 4, 1, HorizontalAlignment.Left)
            {
                Position = new Point(2, 10),
                DisplayTextAlignment = HorizontalAlignment.Center,
                DisplayTextColor = Color.White
            };

            var themeColors = new Colors();

            themeColors.Appearance_ControlDisabled.Foreground = Color.Red;
            themeColors.Appearance_ControlFocused.Foreground = Color.Red;
            themeColors.Appearance_ControlMouseDown.Foreground = Color.Red;
            themeColors.Appearance_ControlOver.Foreground = Color.Red;
            themeColors.Appearance_ControlNormal.Foreground = Color.Red;
            themeColors.Appearance_ControlSelected.Foreground = Color.Red;

            HPBar.SetThemeColors(themeColors);

            Controls.Add(HPBar);
            Controls.Add(DetailsButton);
        }

        private void DetailsButton_Click(object? sender, EventArgs e)
        {
            try
            {
                var playerInfo = BackendHandler.Instance.GetPlayerDetailInfo();
                ParentContainer.ActiveWindow = PlayerCharacterDetailWindow.Show(ParentContainer, playerInfo);
            }
            catch (Exception)
            {
                ParentContainer.ChangeConsoleContainerTo(ConsoleContainers.Message, ConsoleContainers.Main, LocalizationManager.GetString("ErrorMessageHeader"), LocalizationManager.GetString("ErrorText"));
            }
        }

        public override void Update(TimeSpan delta)
        {
            var dungeonStatus = ParentContainer.LatestDungeonStatus;
            if (dungeonStatus == null) return;

            var playerEntity = dungeonStatus.Entities.Find(e => e.IsPlayer);

            if (playerEntity != null)
            {
                this.Clear();

                var square = new Rectangle(0, 0, Width, Height);
                var title = $" {LocalizationManager.GetString("PlayerInfoConsoleTitle")} ";

                this.DrawBox(square, ShapeParameters.CreateBorder(new ColoredGlyph(Color.Violet, Color.Black, 178)));
                this.Print((square.Width - title.Length) / 2, 0, title, true);

                this.Print((square.Width - playerEntity.Name.Length) / 2, 2, playerEntity.Name.ToAscii());

                var levelString = LocalizationManager.GetString("PlayerLevelText").Format(new { CurrentLevel = playerEntity.Level });

                this.Print((square.Width - levelString.Length) / 2, 4, levelString, true);
                this.SetGlyph((square.Width - 1) / 2, 6, new ColoredGlyph(playerEntity.ConsoleRepresentation.ForegroundColor.ToSadRogueColor(), playerEntity.ConsoleRepresentation.BackgroundColor.ToSadRogueColor(), playerEntity.ConsoleRepresentation.Character.ToGlyph()));

                this.Print((square.Width - playerEntity.HPStatName.Length) / 2, 9, playerEntity.HPStatName, true);
                HPBar.DisplayText = $"{playerEntity.HP}/{playerEntity.MaxHP}";
                HPBar.Progress = (float)playerEntity.HP / playerEntity.MaxHP;
                this.Print(2, 13, LocalizationManager.GetString("PlayerInfoWeaponHeader"), true);

                this.SetGlyph(2, 14, new ColoredGlyph(playerEntity.Weapon.ConsoleRepresentation.ForegroundColor.ToSadRogueColor(), playerEntity.Weapon.ConsoleRepresentation.BackgroundColor.ToSadRogueColor(), playerEntity.Weapon.ConsoleRepresentation.Character.ToGlyph()));
                this.Print(3, 14, $" - {playerEntity.Weapon.Name}", true);
                this.Print(2, 16, $"{playerEntity.DamageStatName}:", true);
                this.Print(2, 17, playerEntity.Damage, true);
                this.Print(2, 20, LocalizationManager.GetString("PlayerInfoArmorHeader"), true);
                this.SetGlyph(2, 21, new ColoredGlyph(playerEntity.Armor.ConsoleRepresentation.ForegroundColor.ToSadRogueColor(), playerEntity.Armor.ConsoleRepresentation.BackgroundColor.ToSadRogueColor(), playerEntity.Armor.ConsoleRepresentation.Character.ToGlyph()));
                this.Print(3, 21, $" - {playerEntity.Armor.Name}", true);
                this.Print(2, 23, $"{playerEntity.MitigationStatName}:", true);
                this.Print(2, 24, playerEntity.Mitigation, true);
                this.Print(2, 26, $"{playerEntity.MovementStatName}: {playerEntity.Movement}", true);
                this.Print(2, 28, LocalizationManager.GetString("PlayerInfoStatusesHeader"), true);
                if(dungeonStatus.AlteredStatuses.Any())
                {
                    const int statusBaseColumnIndex = 2;
                    const int statusBaseRowIndex = 30;
                    const int statusesPerRow = 9;
                    foreach (var als in dungeonStatus.AlteredStatuses)
                    {
                        var index = dungeonStatus.AlteredStatuses.IndexOf(als);
                        if (statusBaseRowIndex + (int)(index / statusesPerRow) == DetailsButton.Position.Y - 2)
                        {
                            this.Print(2, statusBaseRowIndex + (int)(index / statusesPerRow), LocalizationManager.GetString("PlayerInfoTooManyStatusesText"), true);
                            break;
                        }
                        this.Print(statusBaseColumnIndex + (index % statusesPerRow), statusBaseRowIndex + (int)(index / statusesPerRow), als.ConsoleRepresentation.Character.ToString().ToAscii(), als.ConsoleRepresentation.ForegroundColor.ToSadRogueColor(), als.ConsoleRepresentation.BackgroundColor.ToSadRogueColor());
                    }
                }
                else
                {
                    this.Print(4, 29, LocalizationManager.GetString("PlayerNoStatusesText"), true);
                }
            }
            base.Update(delta);
        }
    }
}
