﻿using System.Windows.Forms;

namespace RogueCustomsDungeonEditor
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RogueCustomsDungeonEditor.frmMain));
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new global::System.Windows.Forms.DataGridViewCellStyle();
            this.msMenu = (new global::System.Windows.Forms.MenuStrip());
            this.editorToolStripMenuItem = (new global::System.Windows.Forms.ToolStripMenuItem());
            this.exitToolStripMenuItem = (new global::System.Windows.Forms.ToolStripMenuItem());
            this.tsButtons = (new global::System.Windows.Forms.ToolStrip());
            this.tsbNewDungeon = (new global::System.Windows.Forms.ToolStripButton());
            this.tsbOpenDungeon = (new global::System.Windows.Forms.ToolStripButton());
            this.tsbSaveDungeon = (new global::System.Windows.Forms.ToolStripButton());
            this.tsbSaveDungeonAs = (new global::System.Windows.Forms.ToolStripButton());
            this.tssDungeonElement = (new global::System.Windows.Forms.ToolStripSeparator());
            this.tsbAddElement = (new global::System.Windows.Forms.ToolStripButton());
            this.tsbSaveElement = (new global::System.Windows.Forms.ToolStripButton());
            this.tsbSaveElementAs = (new global::System.Windows.Forms.ToolStripButton());
            this.tsbDeleteElement = (new global::System.Windows.Forms.ToolStripButton());
            this.tssElementValidate = (new global::System.Windows.Forms.ToolStripSeparator());
            this.tsbValidateDungeon = (new global::System.Windows.Forms.ToolStripButton());
            this.tvDungeonInfo = (new global::System.Windows.Forms.TreeView());
            this.tbTabs = (new global::System.Windows.Forms.TabControl());
            this.tpBasicInfo = (new global::System.Windows.Forms.TabPage());
            this.cmbDefaultLocale = (new global::System.Windows.Forms.ComboBox());
            this.label8 = (new global::System.Windows.Forms.Label());
            this.fklblEndingMessageLocale = (new global::System.Windows.Forms.Button());
            this.fklblWelcomeMessageLocale = (new global::System.Windows.Forms.Button());
            this.fklblAuthorLocale = (new global::System.Windows.Forms.Button());
            this.fklblDungeonNameLocale = (new global::System.Windows.Forms.Button());
            this.txtEndingMessage = (new global::System.Windows.Forms.TextBox());
            this.label4 = (new global::System.Windows.Forms.Label());
            this.txtWelcomeMessage = (new global::System.Windows.Forms.TextBox());
            this.label3 = (new global::System.Windows.Forms.Label());
            this.txtAuthor = (new global::System.Windows.Forms.TextBox());
            this.label2 = (new global::System.Windows.Forms.Label());
            this.txtDungeonName = (new global::System.Windows.Forms.TextBox());
            this.label1 = (new global::System.Windows.Forms.Label());
            this.tpLocales = (new global::System.Windows.Forms.TabPage());
            this.btnDeleteLocale = (new global::System.Windows.Forms.Button());
            this.btnAddLocale = (new global::System.Windows.Forms.Button());
            this.btnUpdateLocale = (new global::System.Windows.Forms.Button());
            this.fklblMissingLocale = (new global::System.Windows.Forms.Button());
            this.txtLocaleEntryValue = (new global::System.Windows.Forms.TextBox());
            this.label7 = (new global::System.Windows.Forms.Label());
            this.txtLocaleEntryKey = (new global::System.Windows.Forms.TextBox());
            this.label6 = (new global::System.Windows.Forms.Label());
            this.dgvLocales = (new global::System.Windows.Forms.DataGridView());
            this.cmKey = (new global::System.Windows.Forms.DataGridViewTextBoxColumn());
            this.cmValue = (new global::System.Windows.Forms.DataGridViewTextBoxColumn());
            this.tpTileSetInfos = (new global::System.Windows.Forms.TabPage());
            this.label151 = (new global::System.Windows.Forms.Label());
            this.csrEmpty = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label152 = (new global::System.Windows.Forms.Label());
            this.csrStairs = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label153 = (new global::System.Windows.Forms.Label());
            this.label154 = (new global::System.Windows.Forms.Label());
            this.csrFloor = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label148 = (new global::System.Windows.Forms.Label());
            this.csrHorizontalHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label149 = (new global::System.Windows.Forms.Label());
            this.csrBottomRightHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label150 = (new global::System.Windows.Forms.Label());
            this.csrBottomLeftHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label137 = (new global::System.Windows.Forms.Label());
            this.csrCentralHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label140 = (new global::System.Windows.Forms.Label());
            this.csrVerticalRightHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label141 = (new global::System.Windows.Forms.Label());
            this.csrVerticalLeftHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label142 = (new global::System.Windows.Forms.Label());
            this.csrHorizontalTopHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label143 = (new global::System.Windows.Forms.Label());
            this.csrHorizontalBottomHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label144 = (new global::System.Windows.Forms.Label());
            this.csrVerticalHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label145 = (new global::System.Windows.Forms.Label());
            this.csrTopRightHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label146 = (new global::System.Windows.Forms.Label());
            this.label147 = (new global::System.Windows.Forms.Label());
            this.csrTopLeftHallway = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label138 = (new global::System.Windows.Forms.Label());
            this.csrConnectorWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label134 = (new global::System.Windows.Forms.Label());
            this.csrHorizontalWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label135 = (new global::System.Windows.Forms.Label());
            this.csrBottomRightWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label136 = (new global::System.Windows.Forms.Label());
            this.csrBottomLeftWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label133 = (new global::System.Windows.Forms.Label());
            this.csrVerticalWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label132 = (new global::System.Windows.Forms.Label());
            this.csrTopRightWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.label131 = (new global::System.Windows.Forms.Label());
            this.label130 = (new global::System.Windows.Forms.Label());
            this.csrTopLeftWall = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.tpFloorInfos = (new global::System.Windows.Forms.TabPage());
            this.saeOnFloorStart = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.cmbTilesets = (new global::System.Windows.Forms.ComboBox());
            this.label155 = (new global::System.Windows.Forms.Label());
            this.nudRoomFusionOdds = (new global::System.Windows.Forms.NumericUpDown());
            this.label19 = (new global::System.Windows.Forms.Label());
            this.nudExtraRoomConnectionOdds = (new global::System.Windows.Forms.NumericUpDown());
            this.label18 = (new global::System.Windows.Forms.Label());
            this.nudMaxRoomConnections = (new global::System.Windows.Forms.NumericUpDown());
            this.label5 = (new global::System.Windows.Forms.Label());
            this.btnRemoveAlgorithm = (new global::System.Windows.Forms.Button());
            this.btnEditAlgorithm = (new global::System.Windows.Forms.Button());
            this.btnAddAlgorithm = (new global::System.Windows.Forms.Button());
            this.lvFloorAlgorithms = (new global::System.Windows.Forms.ListView());
            this.label17 = (new global::System.Windows.Forms.Label());
            this.label16 = (new global::System.Windows.Forms.Label());
            this.btnTrapGenerator = (new global::System.Windows.Forms.Button());
            this.label15 = (new global::System.Windows.Forms.Label());
            this.btnItemGenerator = (new global::System.Windows.Forms.Button());
            this.label14 = (new global::System.Windows.Forms.Label());
            this.btnNPCGenerator = (new global::System.Windows.Forms.Button());
            this.label13 = (new global::System.Windows.Forms.Label());
            this.nudHeight = (new global::System.Windows.Forms.NumericUpDown());
            this.nudWidth = (new global::System.Windows.Forms.NumericUpDown());
            this.label12 = (new global::System.Windows.Forms.Label());
            this.label11 = (new global::System.Windows.Forms.Label());
            this.fklblStairsReminder = (new global::System.Windows.Forms.Button());
            this.chkGenerateStairsOnStart = (new global::System.Windows.Forms.CheckBox());
            this.nudMaxFloorLevel = (new global::System.Windows.Forms.NumericUpDown());
            this.label10 = (new global::System.Windows.Forms.Label());
            this.nudMinFloorLevel = (new global::System.Windows.Forms.NumericUpDown());
            this.label9 = (new global::System.Windows.Forms.Label());
            this.tpFactionInfos = (new global::System.Windows.Forms.TabPage());
            this.lbEnemies = (new global::System.Windows.Forms.ListBox());
            this.label26 = (new global::System.Windows.Forms.Label());
            this.btnEnemiesToNeutrals = (new global::System.Windows.Forms.Button());
            this.btnEnemyToNeutral = (new global::System.Windows.Forms.Button());
            this.btnNeutralsToEnemies = (new global::System.Windows.Forms.Button());
            this.btnNeutralToEnemy = (new global::System.Windows.Forms.Button());
            this.lbNeutrals = (new global::System.Windows.Forms.ListBox());
            this.label25 = (new global::System.Windows.Forms.Label());
            this.btnNeutralsToAllies = (new global::System.Windows.Forms.Button());
            this.btnNeutralToAlly = (new global::System.Windows.Forms.Button());
            this.btnAlliesToNeutrals = (new global::System.Windows.Forms.Button());
            this.btnAllyToNeutral = (new global::System.Windows.Forms.Button());
            this.lbAllies = (new global::System.Windows.Forms.ListBox());
            this.label24 = (new global::System.Windows.Forms.Label());
            this.label23 = (new global::System.Windows.Forms.Label());
            this.fklblFactionDescriptionLocale = (new global::System.Windows.Forms.Button());
            this.txtFactionDescription = (new global::System.Windows.Forms.TextBox());
            this.label22 = (new global::System.Windows.Forms.Label());
            this.fklblFactionNameLocale = (new global::System.Windows.Forms.Button());
            this.txtFactionName = (new global::System.Windows.Forms.TextBox());
            this.label21 = (new global::System.Windows.Forms.Label());
            this.tpPlayerClass = (new global::System.Windows.Forms.TabPage());
            this.ssPlayer = (new global::RogueCustomsDungeonEditor.Controls.StatsSheet());
            this.sisPlayerStartingInventory = (new global::RogueCustomsDungeonEditor.Controls.StartingInventorySelector());
            this.saePlayerOnDeath = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saePlayerOnAttacked = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saePlayerOnTurnStart = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.maePlayerOnAttack = (new global::RogueCustomsDungeonEditor.Controls.MultiActionEditor());
            this.label58 = (new global::System.Windows.Forms.Label());
            this.cmbPlayerStartingArmor = (new global::System.Windows.Forms.ComboBox());
            this.label57 = (new global::System.Windows.Forms.Label());
            this.cmbPlayerStartingWeapon = (new global::System.Windows.Forms.ComboBox());
            this.label56 = (new global::System.Windows.Forms.Label());
            this.label54 = (new global::System.Windows.Forms.Label());
            this.nudPlayerInventorySize = (new global::System.Windows.Forms.NumericUpDown());
            this.label53 = (new global::System.Windows.Forms.Label());
            this.label30 = (new global::System.Windows.Forms.Label());
            this.chkPlayerStartsVisible = (new global::System.Windows.Forms.CheckBox());
            this.cmbPlayerFaction = (new global::System.Windows.Forms.ComboBox());
            this.label29 = (new global::System.Windows.Forms.Label());
            this.chkRequirePlayerPrompt = (new global::System.Windows.Forms.CheckBox());
            this.fklblPlayerClassDescriptionLocale = (new global::System.Windows.Forms.Button());
            this.txtPlayerClassDescription = (new global::System.Windows.Forms.TextBox());
            this.label28 = (new global::System.Windows.Forms.Label());
            this.fklblPlayerClassNameLocale = (new global::System.Windows.Forms.Button());
            this.txtPlayerClassName = (new global::System.Windows.Forms.TextBox());
            this.label27 = (new global::System.Windows.Forms.Label());
            this.crsPlayer = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.tpNPC = (new global::System.Windows.Forms.TabPage());
            this.maeNPCOnInteracted = (new global::RogueCustomsDungeonEditor.Controls.MultiActionEditor());
            this.saeNPCOnSpawn = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.ssNPC = (new global::RogueCustomsDungeonEditor.Controls.StatsSheet());
            this.sisNPCStartingInventory = (new global::RogueCustomsDungeonEditor.Controls.StartingInventorySelector());
            this.saeNPCOnDeath = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeNPCOnAttacked = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeNPCOnTurnStart = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.maeNPCOnAttack = (new global::RogueCustomsDungeonEditor.Controls.MultiActionEditor());
            this.nudNPCOddsToTargetSelf = (new global::System.Windows.Forms.NumericUpDown());
            this.label104 = (new global::System.Windows.Forms.Label());
            this.txtNPCExperiencePayout = (new global::System.Windows.Forms.TextBox());
            this.label103 = (new global::System.Windows.Forms.Label());
            this.chkNPCKnowsAllCharacterPositions = (new global::System.Windows.Forms.CheckBox());
            this.label67 = (new global::System.Windows.Forms.Label());
            this.cmbNPCStartingArmor = (new global::System.Windows.Forms.ComboBox());
            this.label70 = (new global::System.Windows.Forms.Label());
            this.cmbNPCStartingWeapon = (new global::System.Windows.Forms.ComboBox());
            this.label71 = (new global::System.Windows.Forms.Label());
            this.label73 = (new global::System.Windows.Forms.Label());
            this.nudNPCInventorySize = (new global::System.Windows.Forms.NumericUpDown());
            this.label74 = (new global::System.Windows.Forms.Label());
            this.label98 = (new global::System.Windows.Forms.Label());
            this.chkNPCStartsVisible = (new global::System.Windows.Forms.CheckBox());
            this.cmbNPCFaction = (new global::System.Windows.Forms.ComboBox());
            this.label99 = (new global::System.Windows.Forms.Label());
            this.fklblNPCDescriptionLocale = (new global::System.Windows.Forms.Button());
            this.txtNPCDescription = (new global::System.Windows.Forms.TextBox());
            this.label100 = (new global::System.Windows.Forms.Label());
            this.fklblNPCNameLocale = (new global::System.Windows.Forms.Button());
            this.txtNPCName = (new global::System.Windows.Forms.TextBox());
            this.label101 = (new global::System.Windows.Forms.Label());
            this.crsNPC = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.tpItem = (new global::System.Windows.Forms.TabPage());
            this.saeItemOnTurnStart = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeItemOnAttacked = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.maeItemOnAttack = (new global::RogueCustomsDungeonEditor.Controls.MultiActionEditor());
            this.saeItemOnUse = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeItemOnStepped = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.txtItemPower = (new global::System.Windows.Forms.TextBox());
            this.label108 = (new global::System.Windows.Forms.Label());
            this.chkItemCanBePickedUp = (new global::System.Windows.Forms.CheckBox());
            this.chkItemStartsVisible = (new global::System.Windows.Forms.CheckBox());
            this.cmbItemType = (new global::System.Windows.Forms.ComboBox());
            this.label107 = (new global::System.Windows.Forms.Label());
            this.label102 = (new global::System.Windows.Forms.Label());
            this.fklblItemDescriptionLocale = (new global::System.Windows.Forms.Button());
            this.txtItemDescription = (new global::System.Windows.Forms.TextBox());
            this.label105 = (new global::System.Windows.Forms.Label());
            this.fklblItemNameLocale = (new global::System.Windows.Forms.Button());
            this.txtItemName = (new global::System.Windows.Forms.TextBox());
            this.label106 = (new global::System.Windows.Forms.Label());
            this.crsItem = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.tpTrap = (new global::System.Windows.Forms.TabPage());
            this.saeTrapOnStepped = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.txtTrapPower = (new global::System.Windows.Forms.TextBox());
            this.label113 = (new global::System.Windows.Forms.Label());
            this.chkTrapStartsVisible = (new global::System.Windows.Forms.CheckBox());
            this.label116 = (new global::System.Windows.Forms.Label());
            this.fklblTrapDescriptionLocale = (new global::System.Windows.Forms.Button());
            this.txtTrapDescription = (new global::System.Windows.Forms.TextBox());
            this.label117 = (new global::System.Windows.Forms.Label());
            this.fklblTrapNameLocale = (new global::System.Windows.Forms.Button());
            this.txtTrapName = (new global::System.Windows.Forms.TextBox());
            this.label118 = (new global::System.Windows.Forms.Label());
            this.crsTrap = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.tpAlteredStatus = (new global::System.Windows.Forms.TabPage());
            this.saeAlteredStatusOnAttacked = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeAlteredStatusBeforeAttack = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeAlteredStatusOnRemove = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeAlteredStatusOnTurnStart = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.saeAlteredStatusOnApply = (new global::RogueCustomsDungeonEditor.Controls.SingleActionEditor());
            this.chkAlteredStatusCleansedOnCleanseActions = (new global::System.Windows.Forms.CheckBox());
            this.chkAlteredStatusCleanseOnFloorChange = (new global::System.Windows.Forms.CheckBox());
            this.chkAlteredStatusCanOverwrite = (new global::System.Windows.Forms.CheckBox());
            this.chkAlteredStatusCanStack = (new global::System.Windows.Forms.CheckBox());
            this.label111 = (new global::System.Windows.Forms.Label());
            this.fklblAlteredStatusDescriptionLocale = (new global::System.Windows.Forms.Button());
            this.txtAlteredStatusDescription = (new global::System.Windows.Forms.TextBox());
            this.label114 = (new global::System.Windows.Forms.Label());
            this.fklblAlteredStatusNameLocale = (new global::System.Windows.Forms.Button());
            this.txtAlteredStatusName = (new global::System.Windows.Forms.TextBox());
            this.label115 = (new global::System.Windows.Forms.Label());
            this.crsAlteredStatus = (new global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector());
            this.tpValidation = (new global::System.Windows.Forms.TabPage());
            this.tvValidationResults = (new global::System.Windows.Forms.TreeView());
            this.ofdDungeon = (new global::System.Windows.Forms.OpenFileDialog());
            this.sfdDungeon = (new global::System.Windows.Forms.SaveFileDialog());
            this.msMenu.SuspendLayout();
            this.tsButtons.SuspendLayout();
            this.tbTabs.SuspendLayout();
            this.tpBasicInfo.SuspendLayout();
            this.tpLocales.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvLocales)).BeginInit();
            this.tpTileSetInfos.SuspendLayout();
            this.tpFloorInfos.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudRoomFusionOdds)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudExtraRoomConnectionOdds)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudMaxRoomConnections)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudMaxFloorLevel)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudMinFloorLevel)).BeginInit();
            this.tpFactionInfos.SuspendLayout();
            this.tpPlayerClass.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudPlayerInventorySize)).BeginInit();
            this.tpNPC.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudNPCOddsToTargetSelf)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudNPCInventorySize)).BeginInit();
            this.tpItem.SuspendLayout();
            this.tpTrap.SuspendLayout();
            this.tpAlteredStatus.SuspendLayout();
            this.tpValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.editorToolStripMenuItem });
            this.msMenu.Location = (new global::System.Drawing.Point(0, 0));
            this.msMenu.Name = ("msMenu");
            this.msMenu.Size = (new global::System.Drawing.Size(967, 24));
            this.msMenu.TabIndex = (0);
            this.msMenu.Text = ("menuStrip1");
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.exitToolStripMenuItem });
            this.editorToolStripMenuItem.Name = ("editorToolStripMenuItem");
            this.editorToolStripMenuItem.Size = (new global::System.Drawing.Size(50, 20));
            this.editorToolStripMenuItem.Text = ("Editor");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = ("exitToolStripMenuItem");
            this.exitToolStripMenuItem.Size = (new global::System.Drawing.Size(93, 22));
            this.exitToolStripMenuItem.Text = ("Exit");
            this.exitToolStripMenuItem.Click += (this.exitToolStripMenuItem_Click);
            // 
            // tsButtons
            // 
            this.tsButtons.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.tsbNewDungeon, this.tsbOpenDungeon, this.tsbSaveDungeon, this.tsbSaveDungeonAs, this.tssDungeonElement, this.tsbAddElement, this.tsbSaveElement, this.tsbSaveElementAs, this.tsbDeleteElement, this.tssElementValidate, this.tsbValidateDungeon });
            this.tsButtons.Location = (new global::System.Drawing.Point(0, 24));
            this.tsButtons.Name = ("tsButtons");
            this.tsButtons.Size = (new global::System.Drawing.Size(967, 38));
            this.tsButtons.TabIndex = (1);
            this.tsButtons.Text = ("toolStrip1");
            // 
            // tsbNewDungeon
            // 
            this.tsbNewDungeon.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbNewDungeon.Image")));
            this.tsbNewDungeon.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbNewDungeon.Name = ("tsbNewDungeon");
            this.tsbNewDungeon.Size = (new global::System.Drawing.Size(87, 35));
            this.tsbNewDungeon.Text = ("New Dungeon");
            this.tsbNewDungeon.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbNewDungeon.ToolTipText = ("Create a new, empty Dungeon");
            this.tsbNewDungeon.Click += (this.tsbNewDungeon_Click);
            // 
            // tsbOpenDungeon
            // 
            this.tsbOpenDungeon.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbOpenDungeon.Image")));
            this.tsbOpenDungeon.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbOpenDungeon.Name = ("tsbOpenDungeon");
            this.tsbOpenDungeon.Size = (new global::System.Drawing.Size(92, 35));
            this.tsbOpenDungeon.Text = ("Open Dungeon");
            this.tsbOpenDungeon.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbOpenDungeon.ToolTipText = ("Edit an existing Dungeon");
            this.tsbOpenDungeon.Click += (this.tsbOpenDungeon_Click);
            // 
            // tsbSaveDungeon
            // 
            this.tsbSaveDungeon.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbSaveDungeon.Image")));
            this.tsbSaveDungeon.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbSaveDungeon.Name = ("tsbSaveDungeon");
            this.tsbSaveDungeon.Size = (new global::System.Drawing.Size(87, 35));
            this.tsbSaveDungeon.Text = ("Save Dungeon");
            this.tsbSaveDungeon.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbSaveDungeon.ToolTipText = ("Save Dungeon to a file");
            this.tsbSaveDungeon.Visible = (false);
            this.tsbSaveDungeon.Click += (this.tsbSaveDungeon_Click);
            // 
            // tsbSaveDungeonAs
            // 
            this.tsbSaveDungeonAs.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbSaveDungeonAs.Image")));
            this.tsbSaveDungeonAs.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbSaveDungeonAs.Name = ("tsbSaveDungeonAs");
            this.tsbSaveDungeonAs.Size = (new global::System.Drawing.Size(112, 35));
            this.tsbSaveDungeonAs.Text = ("Save Dungeon As...");
            this.tsbSaveDungeonAs.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbSaveDungeonAs.ToolTipText = ("Save the Dungeon to a file of your choosing");
            this.tsbSaveDungeonAs.Visible = (false);
            this.tsbSaveDungeonAs.Click += (this.tsbSaveDungeonAs_Click);
            // 
            // tssDungeonElement
            // 
            this.tssDungeonElement.Name = ("tssDungeonElement");
            this.tssDungeonElement.Size = (new global::System.Drawing.Size(6, 38));
            this.tssDungeonElement.Visible = (false);
            // 
            // tsbAddElement
            // 
            this.tsbAddElement.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbAddElement.Image")));
            this.tsbAddElement.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbAddElement.Name = ("tsbAddElement");
            this.tsbAddElement.Size = (new global::System.Drawing.Size(81, 35));
            this.tsbAddElement.Text = ("New Element");
            this.tsbAddElement.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbAddElement.ToolTipText = ("Add a new element of this category");
            this.tsbAddElement.Visible = (false);
            this.tsbAddElement.Click += (this.tsbAddElement_Click);
            // 
            // tsbSaveElement
            // 
            this.tsbSaveElement.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbSaveElement.Image")));
            this.tsbSaveElement.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbSaveElement.Name = ("tsbSaveElement");
            this.tsbSaveElement.Size = (new global::System.Drawing.Size(81, 35));
            this.tsbSaveElement.Text = ("Save Element");
            this.tsbSaveElement.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbSaveElement.ToolTipText = ("Save currently-opened Element");
            this.tsbSaveElement.Visible = (false);
            this.tsbSaveElement.Click += (this.tsbSaveElement_Click);
            // 
            // tsbSaveElementAs
            // 
            this.tsbSaveElementAs.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbSaveElementAs.Image")));
            this.tsbSaveElementAs.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbSaveElementAs.Name = ("tsbSaveElementAs");
            this.tsbSaveElementAs.Size = (new global::System.Drawing.Size(133, 35));
            this.tsbSaveElementAs.Text = ("Save As New Element...");
            this.tsbSaveElementAs.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbSaveElementAs.ToolTipText = ("Save currently-opened Element with another name");
            this.tsbSaveElementAs.Visible = (false);
            this.tsbSaveElementAs.Click += (this.tsbSaveElementAs_Click);
            // 
            // tsbDeleteElement
            // 
            this.tsbDeleteElement.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbDeleteElement.Image")));
            this.tsbDeleteElement.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbDeleteElement.Name = ("tsbDeleteElement");
            this.tsbDeleteElement.Size = (new global::System.Drawing.Size(90, 35));
            this.tsbDeleteElement.Text = ("Delete Element");
            this.tsbDeleteElement.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbDeleteElement.ToolTipText = ("Remove the currently open Element");
            this.tsbDeleteElement.Visible = (false);
            this.tsbDeleteElement.Click += (this.tsbDeleteElement_Click);
            // 
            // tssElementValidate
            // 
            this.tssElementValidate.Name = ("tssElementValidate");
            this.tssElementValidate.Size = (new global::System.Drawing.Size(6, 38));
            this.tssElementValidate.Visible = (false);
            // 
            // tsbValidateDungeon
            // 
            this.tsbValidateDungeon.Image = ((global::System.Drawing.Image)(resources.GetObject("tsbValidateDungeon.Image")));
            this.tsbValidateDungeon.ImageTransparentColor = (global::System.Drawing.Color.Magenta);
            this.tsbValidateDungeon.Name = ("tsbValidateDungeon");
            this.tsbValidateDungeon.Size = (new global::System.Drawing.Size(104, 35));
            this.tsbValidateDungeon.Text = ("Validate Dungeon");
            this.tsbValidateDungeon.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageAboveText);
            this.tsbValidateDungeon.ToolTipText = ("Run the Dungeon Validator to check if it won't crash Rogue Customs");
            this.tsbValidateDungeon.Visible = (false);
            this.tsbValidateDungeon.Click += (this.tsbValidateDungeon_Click);
            // 
            // tvDungeonInfo
            // 
            this.tvDungeonInfo.FullRowSelect = (true);
            this.tvDungeonInfo.HideSelection = (false);
            this.tvDungeonInfo.Location = (new global::System.Drawing.Point(0, 65));
            this.tvDungeonInfo.Name = ("tvDungeonInfo");
            this.tvDungeonInfo.Size = (new global::System.Drawing.Size(217, 384));
            this.tvDungeonInfo.TabIndex = (2);
            this.tvDungeonInfo.AfterSelect += (this.tvDungeonInfo_AfterSelect);
            // 
            // tbTabs
            // 
            this.tbTabs.Controls.Add(this.tpBasicInfo);
            this.tbTabs.Controls.Add(this.tpLocales);
            this.tbTabs.Controls.Add(this.tpTileSetInfos);
            this.tbTabs.Controls.Add(this.tpFloorInfos);
            this.tbTabs.Controls.Add(this.tpFactionInfos);
            this.tbTabs.Controls.Add(this.tpPlayerClass);
            this.tbTabs.Controls.Add(this.tpNPC);
            this.tbTabs.Controls.Add(this.tpItem);
            this.tbTabs.Controls.Add(this.tpTrap);
            this.tbTabs.Controls.Add(this.tpAlteredStatus);
            this.tbTabs.Controls.Add(this.tpValidation);
            this.tbTabs.Location = (new global::System.Drawing.Point(219, 65));
            this.tbTabs.Name = ("tbTabs");
            this.tbTabs.SelectedIndex = (0);
            this.tbTabs.Size = (new global::System.Drawing.Size(748, 384));
            this.tbTabs.TabIndex = (3);
            this.tbTabs.SelectedIndexChanged += (this.tbTabs_SelectedIndexChanged);
            // 
            // tpBasicInfo
            // 
            this.tpBasicInfo.Controls.Add(this.cmbDefaultLocale);
            this.tpBasicInfo.Controls.Add(this.label8);
            this.tpBasicInfo.Controls.Add(this.fklblEndingMessageLocale);
            this.tpBasicInfo.Controls.Add(this.fklblWelcomeMessageLocale);
            this.tpBasicInfo.Controls.Add(this.fklblAuthorLocale);
            this.tpBasicInfo.Controls.Add(this.fklblDungeonNameLocale);
            this.tpBasicInfo.Controls.Add(this.txtEndingMessage);
            this.tpBasicInfo.Controls.Add(this.label4);
            this.tpBasicInfo.Controls.Add(this.txtWelcomeMessage);
            this.tpBasicInfo.Controls.Add(this.label3);
            this.tpBasicInfo.Controls.Add(this.txtAuthor);
            this.tpBasicInfo.Controls.Add(this.label2);
            this.tpBasicInfo.Controls.Add(this.txtDungeonName);
            this.tpBasicInfo.Controls.Add(this.label1);
            this.tpBasicInfo.Location = (new global::System.Drawing.Point(4, 24));
            this.tpBasicInfo.Name = ("tpBasicInfo");
            this.tpBasicInfo.Padding = (new global::System.Windows.Forms.Padding(3));
            this.tpBasicInfo.Size = (new global::System.Drawing.Size(740, 356));
            this.tpBasicInfo.TabIndex = (0);
            this.tpBasicInfo.Text = ("Basic Information");
            this.tpBasicInfo.UseVisualStyleBackColor = (true);
            // 
            // cmbDefaultLocale
            // 
            this.cmbDefaultLocale.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbDefaultLocale.FormattingEnabled = (true);
            this.cmbDefaultLocale.Location = (new global::System.Drawing.Point(188, 228));
            this.cmbDefaultLocale.Name = ("cmbDefaultLocale");
            this.cmbDefaultLocale.Size = (new global::System.Drawing.Size(81, 23));
            this.cmbDefaultLocale.TabIndex = (17);
            this.cmbDefaultLocale.SelectedIndexChanged += (this.cmbDefaultLocale_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = (true);
            this.label8.Location = (new global::System.Drawing.Point(11, 223));
            this.label8.Name = ("label8");
            this.label8.Size = (new global::System.Drawing.Size(171, 30));
            this.label8.TabIndex = (16);
            this.label8.Text = ("If the game has a language this\r\ndungeon lacks, use this locale:");
            // 
            // fklblEndingMessageLocale
            // 
            this.fklblEndingMessageLocale.Enabled = (false);
            this.fklblEndingMessageLocale.FlatAppearance.BorderSize = (0);
            this.fklblEndingMessageLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblEndingMessageLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblEndingMessageLocale.Image")));
            this.fklblEndingMessageLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblEndingMessageLocale.Location = (new global::System.Drawing.Point(401, 304));
            this.fklblEndingMessageLocale.Name = ("fklblEndingMessageLocale");
            this.fklblEndingMessageLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblEndingMessageLocale.TabIndex = (15);
            this.fklblEndingMessageLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblEndingMessageLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblEndingMessageLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblEndingMessageLocale.UseVisualStyleBackColor = (true);
            this.fklblEndingMessageLocale.Visible = (false);
            // 
            // fklblWelcomeMessageLocale
            // 
            this.fklblWelcomeMessageLocale.Enabled = (false);
            this.fklblWelcomeMessageLocale.FlatAppearance.BorderSize = (0);
            this.fklblWelcomeMessageLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblWelcomeMessageLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblWelcomeMessageLocale.Image")));
            this.fklblWelcomeMessageLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblWelcomeMessageLocale.Location = (new global::System.Drawing.Point(403, 132));
            this.fklblWelcomeMessageLocale.Name = ("fklblWelcomeMessageLocale");
            this.fklblWelcomeMessageLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblWelcomeMessageLocale.TabIndex = (14);
            this.fklblWelcomeMessageLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblWelcomeMessageLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblWelcomeMessageLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblWelcomeMessageLocale.UseVisualStyleBackColor = (true);
            this.fklblWelcomeMessageLocale.Visible = (false);
            // 
            // fklblAuthorLocale
            // 
            this.fklblAuthorLocale.Enabled = (false);
            this.fklblAuthorLocale.FlatAppearance.BorderSize = (0);
            this.fklblAuthorLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblAuthorLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblAuthorLocale.Image")));
            this.fklblAuthorLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblAuthorLocale.Location = (new global::System.Drawing.Point(11, 168));
            this.fklblAuthorLocale.Name = ("fklblAuthorLocale");
            this.fklblAuthorLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblAuthorLocale.TabIndex = (13);
            this.fklblAuthorLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblAuthorLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblAuthorLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblAuthorLocale.UseVisualStyleBackColor = (true);
            this.fklblAuthorLocale.Visible = (false);
            // 
            // fklblDungeonNameLocale
            // 
            this.fklblDungeonNameLocale.Enabled = (false);
            this.fklblDungeonNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblDungeonNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblDungeonNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblDungeonNameLocale.Image")));
            this.fklblDungeonNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblDungeonNameLocale.Location = (new global::System.Drawing.Point(11, 55));
            this.fklblDungeonNameLocale.Name = ("fklblDungeonNameLocale");
            this.fklblDungeonNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblDungeonNameLocale.TabIndex = (12);
            this.fklblDungeonNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblDungeonNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblDungeonNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblDungeonNameLocale.UseVisualStyleBackColor = (true);
            this.fklblDungeonNameLocale.Visible = (false);
            // 
            // txtEndingMessage
            // 
            this.txtEndingMessage.Location = (new global::System.Drawing.Point(403, 195));
            this.txtEndingMessage.Multiline = (true);
            this.txtEndingMessage.Name = ("txtEndingMessage");
            this.txtEndingMessage.ScrollBars = (global::System.Windows.Forms.ScrollBars.Vertical);
            this.txtEndingMessage.Size = (new global::System.Drawing.Size(313, 103));
            this.txtEndingMessage.TabIndex = (7);
            this.txtEndingMessage.TextChanged += (this.txtEndingMessage_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = (true);
            this.label4.Location = (new global::System.Drawing.Point(403, 177));
            this.label4.Name = ("label4");
            this.label4.Size = (new global::System.Drawing.Size(93, 15));
            this.label4.TabIndex = (6);
            this.label4.Text = ("Ending Message");
            // 
            // txtWelcomeMessage
            // 
            this.txtWelcomeMessage.Location = (new global::System.Drawing.Point(403, 26));
            this.txtWelcomeMessage.Multiline = (true);
            this.txtWelcomeMessage.Name = ("txtWelcomeMessage");
            this.txtWelcomeMessage.ScrollBars = (global::System.Windows.Forms.ScrollBars.Vertical);
            this.txtWelcomeMessage.Size = (new global::System.Drawing.Size(313, 103));
            this.txtWelcomeMessage.TabIndex = (5);
            this.txtWelcomeMessage.TextChanged += (this.txtWelcomeMessage_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = (true);
            this.label3.Location = (new global::System.Drawing.Point(403, 8));
            this.label3.Name = ("label3");
            this.label3.Size = (new global::System.Drawing.Size(106, 15));
            this.label3.TabIndex = (4);
            this.label3.Text = ("Welcome Message");
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = (new global::System.Drawing.Point(11, 134));
            this.txtAuthor.Name = ("txtAuthor");
            this.txtAuthor.Size = (new global::System.Drawing.Size(359, 23));
            this.txtAuthor.TabIndex = (3);
            this.txtAuthor.TextChanged += (this.txtAuthor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = (true);
            this.label2.Location = (new global::System.Drawing.Point(11, 116));
            this.label2.Name = ("label2");
            this.label2.Size = (new global::System.Drawing.Size(44, 15));
            this.label2.TabIndex = (2);
            this.label2.Text = ("Author");
            // 
            // txtDungeonName
            // 
            this.txtDungeonName.Location = (new global::System.Drawing.Point(11, 26));
            this.txtDungeonName.Name = ("txtDungeonName");
            this.txtDungeonName.Size = (new global::System.Drawing.Size(359, 23));
            this.txtDungeonName.TabIndex = (1);
            this.txtDungeonName.TextChanged += (this.txtDungeonName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = (true);
            this.label1.Location = (new global::System.Drawing.Point(11, 8));
            this.label1.Name = ("label1");
            this.label1.Size = (new global::System.Drawing.Size(39, 15));
            this.label1.TabIndex = (0);
            this.label1.Text = ("Name");
            // 
            // tpLocales
            // 
            this.tpLocales.Controls.Add(this.btnDeleteLocale);
            this.tpLocales.Controls.Add(this.btnAddLocale);
            this.tpLocales.Controls.Add(this.btnUpdateLocale);
            this.tpLocales.Controls.Add(this.fklblMissingLocale);
            this.tpLocales.Controls.Add(this.txtLocaleEntryValue);
            this.tpLocales.Controls.Add(this.label7);
            this.tpLocales.Controls.Add(this.txtLocaleEntryKey);
            this.tpLocales.Controls.Add(this.label6);
            this.tpLocales.Controls.Add(this.dgvLocales);
            this.tpLocales.Location = (new global::System.Drawing.Point(4, 24));
            this.tpLocales.Name = ("tpLocales");
            this.tpLocales.Padding = (new global::System.Windows.Forms.Padding(3));
            this.tpLocales.Size = (new global::System.Drawing.Size(740, 356));
            this.tpLocales.TabIndex = (1);
            this.tpLocales.Text = ("Locale Entries");
            this.tpLocales.UseVisualStyleBackColor = (true);
            // 
            // btnDeleteLocale
            // 
            this.btnDeleteLocale.Enabled = (false);
            this.btnDeleteLocale.Location = (new global::System.Drawing.Point(401, 326));
            this.btnDeleteLocale.Name = ("btnDeleteLocale");
            this.btnDeleteLocale.Size = (new global::System.Drawing.Size(331, 23));
            this.btnDeleteLocale.TabIndex = (16);
            this.btnDeleteLocale.Text = ("Delete Locale Entry");
            this.btnDeleteLocale.UseVisualStyleBackColor = (true);
            this.btnDeleteLocale.Click += (this.btnDeleteLocale_Click);
            // 
            // btnAddLocale
            // 
            this.btnAddLocale.Enabled = (false);
            this.btnAddLocale.Location = (new global::System.Drawing.Point(569, 297));
            this.btnAddLocale.Name = ("btnAddLocale");
            this.btnAddLocale.Size = (new global::System.Drawing.Size(163, 23));
            this.btnAddLocale.TabIndex = (15);
            this.btnAddLocale.Text = ("Add New Locale Entry");
            this.btnAddLocale.UseVisualStyleBackColor = (true);
            this.btnAddLocale.Click += (this.btnAddLocale_Click);
            // 
            // btnUpdateLocale
            // 
            this.btnUpdateLocale.Enabled = (false);
            this.btnUpdateLocale.Location = (new global::System.Drawing.Point(401, 297));
            this.btnUpdateLocale.Name = ("btnUpdateLocale");
            this.btnUpdateLocale.Size = (new global::System.Drawing.Size(162, 23));
            this.btnUpdateLocale.TabIndex = (14);
            this.btnUpdateLocale.Text = ("Update Locale Entry");
            this.btnUpdateLocale.UseVisualStyleBackColor = (true);
            this.btnUpdateLocale.Click += (this.btnUpdateLocale_Click);
            // 
            // fklblMissingLocale
            // 
            this.fklblMissingLocale.Enabled = (false);
            this.fklblMissingLocale.FlatAppearance.BorderSize = (0);
            this.fklblMissingLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblMissingLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblMissingLocale.Image")));
            this.fklblMissingLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblMissingLocale.Location = (new global::System.Drawing.Point(403, 228));
            this.fklblMissingLocale.Name = ("fklblMissingLocale");
            this.fklblMissingLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblMissingLocale.TabIndex = (13);
            this.fklblMissingLocale.Text = ("(Missing locale warning)");
            this.fklblMissingLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblMissingLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblMissingLocale.UseVisualStyleBackColor = (true);
            this.fklblMissingLocale.Visible = (false);
            // 
            // txtLocaleEntryValue
            // 
            this.txtLocaleEntryValue.Enabled = (false);
            this.txtLocaleEntryValue.Location = (new global::System.Drawing.Point(401, 79));
            this.txtLocaleEntryValue.Multiline = (true);
            this.txtLocaleEntryValue.Name = ("txtLocaleEntryValue");
            this.txtLocaleEntryValue.ScrollBars = (global::System.Windows.Forms.ScrollBars.Vertical);
            this.txtLocaleEntryValue.Size = (new global::System.Drawing.Size(331, 143));
            this.txtLocaleEntryValue.TabIndex = (4);
            this.txtLocaleEntryValue.TextChanged += (this.txtLocaleEntryValue_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = (true);
            this.label7.Location = (new global::System.Drawing.Point(401, 61));
            this.label7.Name = ("label7");
            this.label7.Size = (new global::System.Drawing.Size(102, 15));
            this.label7.TabIndex = (3);
            this.label7.Text = ("Locale Entry Value");
            // 
            // txtLocaleEntryKey
            // 
            this.txtLocaleEntryKey.Enabled = (false);
            this.txtLocaleEntryKey.Location = (new global::System.Drawing.Point(401, 25));
            this.txtLocaleEntryKey.Name = ("txtLocaleEntryKey");
            this.txtLocaleEntryKey.Size = (new global::System.Drawing.Size(331, 23));
            this.txtLocaleEntryKey.TabIndex = (2);
            this.txtLocaleEntryKey.TextChanged += (this.txtLocaleEntryKey_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = (true);
            this.label6.Location = (new global::System.Drawing.Point(401, 7));
            this.label6.Name = ("label6");
            this.label6.Size = (new global::System.Drawing.Size(93, 15));
            this.label6.TabIndex = (1);
            this.label6.Text = ("Locale Entry Key");
            // 
            // dgvLocales
            // 
            this.dgvLocales.AllowUserToAddRows = (false);
            this.dgvLocales.AllowUserToDeleteRows = (false);
            this.dgvLocales.AllowUserToResizeColumns = (false);
            this.dgvLocales.AllowUserToResizeRows = (false);
            this.dgvLocales.ColumnHeadersHeightSizeMode = (global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize);
            this.dgvLocales.ColumnHeadersVisible = (false);
            this.dgvLocales.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.cmKey, this.cmValue });
            this.dgvLocales.Location = (new global::System.Drawing.Point(0, 0));
            this.dgvLocales.MultiSelect = (false);
            this.dgvLocales.Name = ("dgvLocales");
            this.dgvLocales.ReadOnly = (true);
            this.dgvLocales.RowHeadersVisible = (false);
            this.dgvLocales.RowTemplate.Height = (25);
            this.dgvLocales.ScrollBars = (global::System.Windows.Forms.ScrollBars.Vertical);
            this.dgvLocales.SelectionMode = (global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect);
            this.dgvLocales.Size = (new global::System.Drawing.Size(395, 356));
            this.dgvLocales.TabIndex = (0);
            this.dgvLocales.SelectionChanged += (this.dgvLocales_SelectionChanged);
            // 
            // cmKey
            // 
            dataGridViewCellStyle1.Font = (new global::System.Drawing.Font("Microsoft Sans Serif", 8.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.cmKey.DefaultCellStyle = (dataGridViewCellStyle1);
            this.cmKey.HeaderText = ("Key");
            this.cmKey.Name = ("cmKey");
            this.cmKey.ReadOnly = (true);
            // 
            // cmValue
            // 
            this.cmValue.HeaderText = ("Value");
            this.cmValue.Name = ("cmValue");
            this.cmValue.ReadOnly = (true);
            this.cmValue.Width = (300);
            // 
            // tpTileSetInfos
            // 
            this.tpTileSetInfos.AutoScroll = (true);
            this.tpTileSetInfos.Controls.Add(this.label151);
            this.tpTileSetInfos.Controls.Add(this.csrEmpty);
            this.tpTileSetInfos.Controls.Add(this.label152);
            this.tpTileSetInfos.Controls.Add(this.csrStairs);
            this.tpTileSetInfos.Controls.Add(this.label153);
            this.tpTileSetInfos.Controls.Add(this.label154);
            this.tpTileSetInfos.Controls.Add(this.csrFloor);
            this.tpTileSetInfos.Controls.Add(this.label148);
            this.tpTileSetInfos.Controls.Add(this.csrHorizontalHallway);
            this.tpTileSetInfos.Controls.Add(this.label149);
            this.tpTileSetInfos.Controls.Add(this.csrBottomRightHallway);
            this.tpTileSetInfos.Controls.Add(this.label150);
            this.tpTileSetInfos.Controls.Add(this.csrBottomLeftHallway);
            this.tpTileSetInfos.Controls.Add(this.label137);
            this.tpTileSetInfos.Controls.Add(this.csrCentralHallway);
            this.tpTileSetInfos.Controls.Add(this.label140);
            this.tpTileSetInfos.Controls.Add(this.csrVerticalRightHallway);
            this.tpTileSetInfos.Controls.Add(this.label141);
            this.tpTileSetInfos.Controls.Add(this.csrVerticalLeftHallway);
            this.tpTileSetInfos.Controls.Add(this.label142);
            this.tpTileSetInfos.Controls.Add(this.csrHorizontalTopHallway);
            this.tpTileSetInfos.Controls.Add(this.label143);
            this.tpTileSetInfos.Controls.Add(this.csrHorizontalBottomHallway);
            this.tpTileSetInfos.Controls.Add(this.label144);
            this.tpTileSetInfos.Controls.Add(this.csrVerticalHallway);
            this.tpTileSetInfos.Controls.Add(this.label145);
            this.tpTileSetInfos.Controls.Add(this.csrTopRightHallway);
            this.tpTileSetInfos.Controls.Add(this.label146);
            this.tpTileSetInfos.Controls.Add(this.label147);
            this.tpTileSetInfos.Controls.Add(this.csrTopLeftHallway);
            this.tpTileSetInfos.Controls.Add(this.label138);
            this.tpTileSetInfos.Controls.Add(this.csrConnectorWall);
            this.tpTileSetInfos.Controls.Add(this.label134);
            this.tpTileSetInfos.Controls.Add(this.csrHorizontalWall);
            this.tpTileSetInfos.Controls.Add(this.label135);
            this.tpTileSetInfos.Controls.Add(this.csrBottomRightWall);
            this.tpTileSetInfos.Controls.Add(this.label136);
            this.tpTileSetInfos.Controls.Add(this.csrBottomLeftWall);
            this.tpTileSetInfos.Controls.Add(this.label133);
            this.tpTileSetInfos.Controls.Add(this.csrVerticalWall);
            this.tpTileSetInfos.Controls.Add(this.label132);
            this.tpTileSetInfos.Controls.Add(this.csrTopRightWall);
            this.tpTileSetInfos.Controls.Add(this.label131);
            this.tpTileSetInfos.Controls.Add(this.label130);
            this.tpTileSetInfos.Controls.Add(this.csrTopLeftWall);
            this.tpTileSetInfos.Location = (new global::System.Drawing.Point(4, 24));
            this.tpTileSetInfos.Name = ("tpTileSetInfos");
            this.tpTileSetInfos.Size = (new global::System.Drawing.Size(740, 356));
            this.tpTileSetInfos.TabIndex = (10);
            this.tpTileSetInfos.Text = ("Tileset");
            this.tpTileSetInfos.UseVisualStyleBackColor = (true);
            // 
            // label151
            // 
            this.label151.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label151.Location = (new global::System.Drawing.Point(465, 1055));
            this.label151.Name = ("label151");
            this.label151.Size = (new global::System.Drawing.Size(211, 32));
            this.label151.TabIndex = (169);
            this.label151.Text = ("Empty (inaccessible)");
            this.label151.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrEmpty
            // 
            this.csrEmpty.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrEmpty.BackgroundColor")));
            this.csrEmpty.Character = ('\0');
            this.csrEmpty.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrEmpty.ForegroundColor")));
            this.csrEmpty.Location = (new global::System.Drawing.Point(465, 1090));
            this.csrEmpty.Name = ("csrEmpty");
            this.csrEmpty.Size = (new global::System.Drawing.Size(211, 83));
            this.csrEmpty.TabIndex = (170);
            this.csrEmpty.PropertyChanged += (this.csrEmpty_PropertyChanged);
            // 
            // label152
            // 
            this.label152.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label152.Location = (new global::System.Drawing.Point(248, 1055));
            this.label152.Name = ("label152");
            this.label152.Size = (new global::System.Drawing.Size(211, 32));
            this.label152.TabIndex = (167);
            this.label152.Text = ("Stairs");
            this.label152.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrStairs
            // 
            this.csrStairs.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrStairs.BackgroundColor")));
            this.csrStairs.Character = ('\0');
            this.csrStairs.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrStairs.ForegroundColor")));
            this.csrStairs.Location = (new global::System.Drawing.Point(248, 1090));
            this.csrStairs.Name = ("csrStairs");
            this.csrStairs.Size = (new global::System.Drawing.Size(211, 83));
            this.csrStairs.TabIndex = (168);
            this.csrStairs.PropertyChanged += (this.csrStairs_PropertyChanged);
            // 
            // label153
            // 
            this.label153.Font = (new global::System.Drawing.Font("Segoe UI", 18F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label153.Location = (new global::System.Drawing.Point(248, 1003));
            this.label153.Name = ("label153");
            this.label153.Size = (new global::System.Drawing.Size(211, 52));
            this.label153.TabIndex = (166);
            this.label153.Text = ("OTHERS");
            this.label153.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // label154
            // 
            this.label154.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label154.Location = (new global::System.Drawing.Point(31, 1055));
            this.label154.Name = ("label154");
            this.label154.Size = (new global::System.Drawing.Size(211, 32));
            this.label154.TabIndex = (164);
            this.label154.Text = ("Unoccupied Floor");
            this.label154.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrFloor
            // 
            this.csrFloor.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrFloor.BackgroundColor")));
            this.csrFloor.Character = ('\0');
            this.csrFloor.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrFloor.ForegroundColor")));
            this.csrFloor.Location = (new global::System.Drawing.Point(31, 1090));
            this.csrFloor.Name = ("csrFloor");
            this.csrFloor.Size = (new global::System.Drawing.Size(211, 83));
            this.csrFloor.TabIndex = (165);
            this.csrFloor.PropertyChanged += (this.csrFloor_PropertyChanged);
            // 
            // label148
            // 
            this.label148.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label148.Location = (new global::System.Drawing.Point(454, 611));
            this.label148.Name = ("label148");
            this.label148.Size = (new global::System.Drawing.Size(211, 32));
            this.label148.TabIndex = (162);
            this.label148.Text = ("Horizontal");
            this.label148.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrHorizontalHallway
            // 
            this.csrHorizontalHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalHallway.BackgroundColor")));
            this.csrHorizontalHallway.Character = ('\0');
            this.csrHorizontalHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalHallway.ForegroundColor")));
            this.csrHorizontalHallway.Location = (new global::System.Drawing.Point(454, 646));
            this.csrHorizontalHallway.Name = ("csrHorizontalHallway");
            this.csrHorizontalHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrHorizontalHallway.TabIndex = (163);
            this.csrHorizontalHallway.PropertyChanged += (this.csrHorizontalHallway_PropertyChanged);
            // 
            // label149
            // 
            this.label149.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label149.Location = (new global::System.Drawing.Point(237, 611));
            this.label149.Name = ("label149");
            this.label149.Size = (new global::System.Drawing.Size(211, 32));
            this.label149.TabIndex = (160);
            this.label149.Text = ("Bottom Right Corner");
            this.label149.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrBottomRightHallway
            // 
            this.csrBottomRightHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomRightHallway.BackgroundColor")));
            this.csrBottomRightHallway.Character = ('\0');
            this.csrBottomRightHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomRightHallway.ForegroundColor")));
            this.csrBottomRightHallway.Location = (new global::System.Drawing.Point(237, 646));
            this.csrBottomRightHallway.Name = ("csrBottomRightHallway");
            this.csrBottomRightHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrBottomRightHallway.TabIndex = (161);
            this.csrBottomRightHallway.PropertyChanged += (this.csrBottomRightHallway_PropertyChanged);
            // 
            // label150
            // 
            this.label150.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label150.Location = (new global::System.Drawing.Point(20, 611));
            this.label150.Name = ("label150");
            this.label150.Size = (new global::System.Drawing.Size(211, 32));
            this.label150.TabIndex = (158);
            this.label150.Text = ("Bottom Left Corner");
            this.label150.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrBottomLeftHallway
            // 
            this.csrBottomLeftHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomLeftHallway.BackgroundColor")));
            this.csrBottomLeftHallway.Character = ('\0');
            this.csrBottomLeftHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomLeftHallway.ForegroundColor")));
            this.csrBottomLeftHallway.Location = (new global::System.Drawing.Point(20, 646));
            this.csrBottomLeftHallway.Name = ("csrBottomLeftHallway");
            this.csrBottomLeftHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrBottomLeftHallway.TabIndex = (159);
            this.csrBottomLeftHallway.PropertyChanged += (this.csrBottomLeftHallway_PropertyChanged);
            // 
            // label137
            // 
            this.label137.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label137.Location = (new global::System.Drawing.Point(324, 862));
            this.label137.Name = ("label137");
            this.label137.Size = (new global::System.Drawing.Size(211, 32));
            this.label137.TabIndex = (156);
            this.label137.Text = ("Central");
            this.label137.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrCentralHallway
            // 
            this.csrCentralHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrCentralHallway.BackgroundColor")));
            this.csrCentralHallway.Character = ('\0');
            this.csrCentralHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrCentralHallway.ForegroundColor")));
            this.csrCentralHallway.Location = (new global::System.Drawing.Point(324, 897));
            this.csrCentralHallway.Name = ("csrCentralHallway");
            this.csrCentralHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrCentralHallway.TabIndex = (157);
            this.csrCentralHallway.PropertyChanged += (this.csrCentralHallway_PropertyChanged);
            // 
            // label140
            // 
            this.label140.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label140.Location = (new global::System.Drawing.Point(107, 862));
            this.label140.Name = ("label140");
            this.label140.Size = (new global::System.Drawing.Size(211, 32));
            this.label140.TabIndex = (154);
            this.label140.Text = ("Vertical-Right");
            this.label140.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrVerticalRightHallway
            // 
            this.csrVerticalRightHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalRightHallway.BackgroundColor")));
            this.csrVerticalRightHallway.Character = ('\0');
            this.csrVerticalRightHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalRightHallway.ForegroundColor")));
            this.csrVerticalRightHallway.Location = (new global::System.Drawing.Point(107, 897));
            this.csrVerticalRightHallway.Name = ("csrVerticalRightHallway");
            this.csrVerticalRightHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrVerticalRightHallway.TabIndex = (155);
            this.csrVerticalRightHallway.PropertyChanged += (this.csrVerticalRightHallway_PropertyChanged);
            // 
            // label141
            // 
            this.label141.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label141.Location = (new global::System.Drawing.Point(454, 741));
            this.label141.Name = ("label141");
            this.label141.Size = (new global::System.Drawing.Size(211, 32));
            this.label141.TabIndex = (152);
            this.label141.Text = ("Vertical-Left");
            this.label141.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrVerticalLeftHallway
            // 
            this.csrVerticalLeftHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalLeftHallway.BackgroundColor")));
            this.csrVerticalLeftHallway.Character = ('\0');
            this.csrVerticalLeftHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalLeftHallway.ForegroundColor")));
            this.csrVerticalLeftHallway.Location = (new global::System.Drawing.Point(454, 776));
            this.csrVerticalLeftHallway.Name = ("csrVerticalLeftHallway");
            this.csrVerticalLeftHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrVerticalLeftHallway.TabIndex = (153);
            this.csrVerticalLeftHallway.PropertyChanged += (this.csrVerticalLeftHallway_PropertyChanged);
            // 
            // label142
            // 
            this.label142.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label142.Location = (new global::System.Drawing.Point(237, 741));
            this.label142.Name = ("label142");
            this.label142.Size = (new global::System.Drawing.Size(211, 32));
            this.label142.TabIndex = (150);
            this.label142.Text = ("Horizontal-Top");
            this.label142.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrHorizontalTopHallway
            // 
            this.csrHorizontalTopHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalTopHallway.BackgroundColor")));
            this.csrHorizontalTopHallway.Character = ('\0');
            this.csrHorizontalTopHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalTopHallway.ForegroundColor")));
            this.csrHorizontalTopHallway.Location = (new global::System.Drawing.Point(237, 776));
            this.csrHorizontalTopHallway.Name = ("csrHorizontalTopHallway");
            this.csrHorizontalTopHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrHorizontalTopHallway.TabIndex = (151);
            this.csrHorizontalTopHallway.PropertyChanged += (this.csrHorizontalTopHallway_PropertyChanged);
            // 
            // label143
            // 
            this.label143.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label143.Location = (new global::System.Drawing.Point(20, 741));
            this.label143.Name = ("label143");
            this.label143.Size = (new global::System.Drawing.Size(211, 32));
            this.label143.TabIndex = (148);
            this.label143.Text = ("Horizontal-Bottom");
            this.label143.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrHorizontalBottomHallway
            // 
            this.csrHorizontalBottomHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalBottomHallway.BackgroundColor")));
            this.csrHorizontalBottomHallway.Character = ('\0');
            this.csrHorizontalBottomHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalBottomHallway.ForegroundColor")));
            this.csrHorizontalBottomHallway.Location = (new global::System.Drawing.Point(20, 776));
            this.csrHorizontalBottomHallway.Name = ("csrHorizontalBottomHallway");
            this.csrHorizontalBottomHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrHorizontalBottomHallway.TabIndex = (149);
            this.csrHorizontalBottomHallway.PropertyChanged += (this.csrHorizontalBottomHallway_PropertyChanged);
            // 
            // label144
            // 
            this.label144.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label144.Location = (new global::System.Drawing.Point(454, 490));
            this.label144.Name = ("label144");
            this.label144.Size = (new global::System.Drawing.Size(211, 32));
            this.label144.TabIndex = (146);
            this.label144.Text = ("Vertical");
            this.label144.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrVerticalHallway
            // 
            this.csrVerticalHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalHallway.BackgroundColor")));
            this.csrVerticalHallway.Character = ('\0');
            this.csrVerticalHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalHallway.ForegroundColor")));
            this.csrVerticalHallway.Location = (new global::System.Drawing.Point(454, 525));
            this.csrVerticalHallway.Name = ("csrVerticalHallway");
            this.csrVerticalHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrVerticalHallway.TabIndex = (147);
            this.csrVerticalHallway.PropertyChanged += (this.csrVerticalHallway_PropertyChanged);
            // 
            // label145
            // 
            this.label145.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label145.Location = (new global::System.Drawing.Point(237, 490));
            this.label145.Name = ("label145");
            this.label145.Size = (new global::System.Drawing.Size(211, 32));
            this.label145.TabIndex = (144);
            this.label145.Text = ("Top Right Corner");
            this.label145.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrTopRightHallway
            // 
            this.csrTopRightHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopRightHallway.BackgroundColor")));
            this.csrTopRightHallway.Character = ('\0');
            this.csrTopRightHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopRightHallway.ForegroundColor")));
            this.csrTopRightHallway.Location = (new global::System.Drawing.Point(237, 525));
            this.csrTopRightHallway.Name = ("csrTopRightHallway");
            this.csrTopRightHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrTopRightHallway.TabIndex = (145);
            this.csrTopRightHallway.PropertyChanged += (this.csrTopRightHallway_PropertyChanged);
            // 
            // label146
            // 
            this.label146.Font = (new global::System.Drawing.Font("Segoe UI", 18F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label146.Location = (new global::System.Drawing.Point(237, 438));
            this.label146.Name = ("label146");
            this.label146.Size = (new global::System.Drawing.Size(211, 52));
            this.label146.TabIndex = (143);
            this.label146.Text = ("HALLWAYS");
            this.label146.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // label147
            // 
            this.label147.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label147.Location = (new global::System.Drawing.Point(20, 490));
            this.label147.Name = ("label147");
            this.label147.Size = (new global::System.Drawing.Size(211, 32));
            this.label147.TabIndex = (141);
            this.label147.Text = ("Top Left Corner");
            this.label147.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrTopLeftHallway
            // 
            this.csrTopLeftHallway.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopLeftHallway.BackgroundColor")));
            this.csrTopLeftHallway.Character = ('\0');
            this.csrTopLeftHallway.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopLeftHallway.ForegroundColor")));
            this.csrTopLeftHallway.Location = (new global::System.Drawing.Point(20, 525));
            this.csrTopLeftHallway.Name = ("csrTopLeftHallway");
            this.csrTopLeftHallway.Size = (new global::System.Drawing.Size(211, 83));
            this.csrTopLeftHallway.TabIndex = (142);
            this.csrTopLeftHallway.PropertyChanged += (this.csrTopLeftHallway_PropertyChanged);
            // 
            // label138
            // 
            this.label138.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label138.Location = (new global::System.Drawing.Point(253, 304));
            this.label138.Name = ("label138");
            this.label138.Size = (new global::System.Drawing.Size(211, 32));
            this.label138.TabIndex = (139);
            this.label138.Text = ("Hallway Connector");
            this.label138.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrConnectorWall
            // 
            this.csrConnectorWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrConnectorWall.BackgroundColor")));
            this.csrConnectorWall.Character = ('\0');
            this.csrConnectorWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrConnectorWall.ForegroundColor")));
            this.csrConnectorWall.Location = (new global::System.Drawing.Point(253, 339));
            this.csrConnectorWall.Name = ("csrConnectorWall");
            this.csrConnectorWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrConnectorWall.TabIndex = (140);
            this.csrConnectorWall.PropertyChanged += (this.csrConnectorWall_PropertyChanged);
            // 
            // label134
            // 
            this.label134.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label134.Location = (new global::System.Drawing.Point(470, 183));
            this.label134.Name = ("label134");
            this.label134.Size = (new global::System.Drawing.Size(211, 32));
            this.label134.TabIndex = (135);
            this.label134.Text = ("Horizontal");
            this.label134.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrHorizontalWall
            // 
            this.csrHorizontalWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalWall.BackgroundColor")));
            this.csrHorizontalWall.Character = ('\0');
            this.csrHorizontalWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrHorizontalWall.ForegroundColor")));
            this.csrHorizontalWall.Location = (new global::System.Drawing.Point(470, 218));
            this.csrHorizontalWall.Name = ("csrHorizontalWall");
            this.csrHorizontalWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrHorizontalWall.TabIndex = (136);
            this.csrHorizontalWall.PropertyChanged += (this.csrHorizontalWall_PropertyChanged);
            // 
            // label135
            // 
            this.label135.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label135.Location = (new global::System.Drawing.Point(253, 183));
            this.label135.Name = ("label135");
            this.label135.Size = (new global::System.Drawing.Size(211, 32));
            this.label135.TabIndex = (133);
            this.label135.Text = ("Bottom Right Corner");
            this.label135.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrBottomRightWall
            // 
            this.csrBottomRightWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomRightWall.BackgroundColor")));
            this.csrBottomRightWall.Character = ('\0');
            this.csrBottomRightWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomRightWall.ForegroundColor")));
            this.csrBottomRightWall.Location = (new global::System.Drawing.Point(253, 218));
            this.csrBottomRightWall.Name = ("csrBottomRightWall");
            this.csrBottomRightWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrBottomRightWall.TabIndex = (134);
            this.csrBottomRightWall.PropertyChanged += (this.csrBottomRightWall_PropertyChanged);
            // 
            // label136
            // 
            this.label136.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label136.Location = (new global::System.Drawing.Point(36, 183));
            this.label136.Name = ("label136");
            this.label136.Size = (new global::System.Drawing.Size(211, 32));
            this.label136.TabIndex = (131);
            this.label136.Text = ("Bottom Left Corner");
            this.label136.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrBottomLeftWall
            // 
            this.csrBottomLeftWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomLeftWall.BackgroundColor")));
            this.csrBottomLeftWall.Character = ('\0');
            this.csrBottomLeftWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrBottomLeftWall.ForegroundColor")));
            this.csrBottomLeftWall.Location = (new global::System.Drawing.Point(36, 218));
            this.csrBottomLeftWall.Name = ("csrBottomLeftWall");
            this.csrBottomLeftWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrBottomLeftWall.TabIndex = (132);
            this.csrBottomLeftWall.PropertyChanged += (this.csrBottomLeftWall_PropertyChanged);
            // 
            // label133
            // 
            this.label133.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label133.Location = (new global::System.Drawing.Point(470, 62));
            this.label133.Name = ("label133");
            this.label133.Size = (new global::System.Drawing.Size(211, 32));
            this.label133.TabIndex = (129);
            this.label133.Text = ("Vertical");
            this.label133.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrVerticalWall
            // 
            this.csrVerticalWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalWall.BackgroundColor")));
            this.csrVerticalWall.Character = ('\0');
            this.csrVerticalWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrVerticalWall.ForegroundColor")));
            this.csrVerticalWall.Location = (new global::System.Drawing.Point(470, 97));
            this.csrVerticalWall.Name = ("csrVerticalWall");
            this.csrVerticalWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrVerticalWall.TabIndex = (130);
            this.csrVerticalWall.PropertyChanged += (this.csrVerticalWall_PropertyChanged);
            // 
            // label132
            // 
            this.label132.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label132.Location = (new global::System.Drawing.Point(253, 62));
            this.label132.Name = ("label132");
            this.label132.Size = (new global::System.Drawing.Size(211, 32));
            this.label132.TabIndex = (127);
            this.label132.Text = ("Top Right Corner");
            this.label132.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrTopRightWall
            // 
            this.csrTopRightWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopRightWall.BackgroundColor")));
            this.csrTopRightWall.Character = ('\0');
            this.csrTopRightWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopRightWall.ForegroundColor")));
            this.csrTopRightWall.Location = (new global::System.Drawing.Point(253, 97));
            this.csrTopRightWall.Name = ("csrTopRightWall");
            this.csrTopRightWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrTopRightWall.TabIndex = (128);
            this.csrTopRightWall.PropertyChanged += (this.csrTopRightWall_PropertyChanged);
            // 
            // label131
            // 
            this.label131.Font = (new global::System.Drawing.Font("Segoe UI", 18F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label131.Location = (new global::System.Drawing.Point(253, 10));
            this.label131.Name = ("label131");
            this.label131.Size = (new global::System.Drawing.Size(211, 52));
            this.label131.TabIndex = (126);
            this.label131.Text = ("WALLS");
            this.label131.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // label130
            // 
            this.label130.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label130.Location = (new global::System.Drawing.Point(36, 62));
            this.label130.Name = ("label130");
            this.label130.Size = (new global::System.Drawing.Size(211, 32));
            this.label130.TabIndex = (124);
            this.label130.Text = ("Top Left Corner");
            this.label130.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // csrTopLeftWall
            // 
            this.csrTopLeftWall.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopLeftWall.BackgroundColor")));
            this.csrTopLeftWall.Character = ('\0');
            this.csrTopLeftWall.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("csrTopLeftWall.ForegroundColor")));
            this.csrTopLeftWall.Location = (new global::System.Drawing.Point(36, 97));
            this.csrTopLeftWall.Name = ("csrTopLeftWall");
            this.csrTopLeftWall.Size = (new global::System.Drawing.Size(211, 83));
            this.csrTopLeftWall.TabIndex = (125);
            this.csrTopLeftWall.PropertyChanged += (this.csrTopLeftWall_PropertyChanged);
            // 
            // tpFloorInfos
            // 
            this.tpFloorInfos.AutoScroll = (true);
            this.tpFloorInfos.Controls.Add(this.saeOnFloorStart);
            this.tpFloorInfos.Controls.Add(this.cmbTilesets);
            this.tpFloorInfos.Controls.Add(this.label155);
            this.tpFloorInfos.Controls.Add(this.nudRoomFusionOdds);
            this.tpFloorInfos.Controls.Add(this.label19);
            this.tpFloorInfos.Controls.Add(this.nudExtraRoomConnectionOdds);
            this.tpFloorInfos.Controls.Add(this.label18);
            this.tpFloorInfos.Controls.Add(this.nudMaxRoomConnections);
            this.tpFloorInfos.Controls.Add(this.label5);
            this.tpFloorInfos.Controls.Add(this.btnRemoveAlgorithm);
            this.tpFloorInfos.Controls.Add(this.btnEditAlgorithm);
            this.tpFloorInfos.Controls.Add(this.btnAddAlgorithm);
            this.tpFloorInfos.Controls.Add(this.lvFloorAlgorithms);
            this.tpFloorInfos.Controls.Add(this.label17);
            this.tpFloorInfos.Controls.Add(this.label16);
            this.tpFloorInfos.Controls.Add(this.btnTrapGenerator);
            this.tpFloorInfos.Controls.Add(this.label15);
            this.tpFloorInfos.Controls.Add(this.btnItemGenerator);
            this.tpFloorInfos.Controls.Add(this.label14);
            this.tpFloorInfos.Controls.Add(this.btnNPCGenerator);
            this.tpFloorInfos.Controls.Add(this.label13);
            this.tpFloorInfos.Controls.Add(this.nudHeight);
            this.tpFloorInfos.Controls.Add(this.nudWidth);
            this.tpFloorInfos.Controls.Add(this.label12);
            this.tpFloorInfos.Controls.Add(this.label11);
            this.tpFloorInfos.Controls.Add(this.fklblStairsReminder);
            this.tpFloorInfos.Controls.Add(this.chkGenerateStairsOnStart);
            this.tpFloorInfos.Controls.Add(this.nudMaxFloorLevel);
            this.tpFloorInfos.Controls.Add(this.label10);
            this.tpFloorInfos.Controls.Add(this.nudMinFloorLevel);
            this.tpFloorInfos.Controls.Add(this.label9);
            this.tpFloorInfos.Location = (new global::System.Drawing.Point(4, 24));
            this.tpFloorInfos.Name = ("tpFloorInfos");
            this.tpFloorInfos.Size = (new global::System.Drawing.Size(740, 356));
            this.tpFloorInfos.TabIndex = (2);
            this.tpFloorInfos.Text = ("Floor Group");
            this.tpFloorInfos.UseVisualStyleBackColor = (true);
            // 
            // saeOnFloorStart
            // 
            this.saeOnFloorStart.Action = (null);
            this.saeOnFloorStart.ActionDescription = ("When the floor starts...");
            this.saeOnFloorStart.ActionTypeText = ("Floor Start");
            this.saeOnFloorStart.AlteredStatuses = (null);
            this.saeOnFloorStart.AutoSize = (true);
            this.saeOnFloorStart.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeOnFloorStart.ClassId = (null);
            this.saeOnFloorStart.Dungeon = (null);
            this.saeOnFloorStart.EffectParamData = (null);
            this.saeOnFloorStart.Location = (new global::System.Drawing.Point(370, 307));
            this.saeOnFloorStart.Name = ("saeOnFloorStart");
            this.saeOnFloorStart.PlaceholderActionName = ("FloorStart");
            this.saeOnFloorStart.RequiresActionName = (false);
            this.saeOnFloorStart.RequiresCondition = (false);
            this.saeOnFloorStart.RequiresDescription = (false);
            this.saeOnFloorStart.Size = (new global::System.Drawing.Size(260, 32));
            this.saeOnFloorStart.SourceDescription = ("The player");
            this.saeOnFloorStart.TabIndex = (40);
            this.saeOnFloorStart.TargetDescription = ("The player");
            this.saeOnFloorStart.ThisDescription = ("None (Don't use)");
            this.saeOnFloorStart.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeOnFloorStart.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // cmbTilesets
            // 
            this.cmbTilesets.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbTilesets.FormattingEnabled = (true);
            this.cmbTilesets.Location = (new global::System.Drawing.Point(167, 77));
            this.cmbTilesets.Name = ("cmbTilesets");
            this.cmbTilesets.Size = (new global::System.Drawing.Size(149, 23));
            this.cmbTilesets.TabIndex = (39);
            this.cmbTilesets.SelectedIndexChanged += (this.cmbTilesets_SelectedIndexChanged);
            // 
            // label155
            // 
            this.label155.AutoSize = (true);
            this.label155.Location = (new global::System.Drawing.Point(121, 80));
            this.label155.Name = ("label155");
            this.label155.Size = (new global::System.Drawing.Size(40, 15));
            this.label155.TabIndex = (38);
            this.label155.Text = ("Tileset");
            // 
            // nudRoomFusionOdds
            // 
            this.nudRoomFusionOdds.Location = (new global::System.Drawing.Point(518, 269));
            this.nudRoomFusionOdds.Name = ("nudRoomFusionOdds");
            this.nudRoomFusionOdds.Size = (new global::System.Drawing.Size(40, 23));
            this.nudRoomFusionOdds.TabIndex = (35);
            this.nudRoomFusionOdds.ValueChanged += (this.nudRoomFusionOdds_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = (true);
            this.label19.Location = (new global::System.Drawing.Point(369, 271));
            this.label19.Name = ("label19");
            this.label19.Size = (new global::System.Drawing.Size(285, 15));
            this.label19.TabIndex = (34);
            this.label19.Text = ("Two adjacent rooms have a               % chance to fuse");
            // 
            // nudExtraRoomConnectionOdds
            // 
            this.nudExtraRoomConnectionOdds.Location = (new global::System.Drawing.Point(470, 239));
            this.nudExtraRoomConnectionOdds.Name = ("nudExtraRoomConnectionOdds");
            this.nudExtraRoomConnectionOdds.Size = (new global::System.Drawing.Size(40, 23));
            this.nudExtraRoomConnectionOdds.TabIndex = (33);
            this.nudExtraRoomConnectionOdds.ValueChanged += (this.nudRoomConnectionOdds_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = (true);
            this.label18.Location = (new global::System.Drawing.Point(370, 242));
            this.label18.Name = ("label18");
            this.label18.Size = (new global::System.Drawing.Size(323, 15));
            this.label18.TabIndex = (32);
            this.label18.Text = ("(With a chance of               % of connecting more than once)");
            // 
            // nudMaxRoomConnections
            // 
            this.nudMaxRoomConnections.Location = (new global::System.Drawing.Point(619, 211));
            this.nudMaxRoomConnections.Maximum = (new global::System.Decimal(new global::System.Int32[] { 9, 0, 0, 0 }));
            this.nudMaxRoomConnections.Minimum = (new global::System.Decimal(new global::System.Int32[] { 1, 0, 0, 0 }));
            this.nudMaxRoomConnections.Name = ("nudMaxRoomConnections");
            this.nudMaxRoomConnections.Size = (new global::System.Drawing.Size(33, 23));
            this.nudMaxRoomConnections.TabIndex = (31);
            this.nudMaxRoomConnections.Value = (new global::System.Decimal(new global::System.Int32[] { 1, 0, 0, 0 }));
            this.nudMaxRoomConnections.ValueChanged += (this.nudMaxRoomConnections_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = (true);
            this.label5.Location = (new global::System.Drawing.Point(370, 213));
            this.label5.Name = ("label5");
            this.label5.Size = (new global::System.Drawing.Size(326, 15));
            this.label5.TabIndex = (30);
            this.label5.Text = ("Rooms can connect between each other up to             time(s)");
            // 
            // btnRemoveAlgorithm
            // 
            this.btnRemoveAlgorithm.Enabled = (false);
            this.btnRemoveAlgorithm.Location = (new global::System.Drawing.Point(586, 174));
            this.btnRemoveAlgorithm.Name = ("btnRemoveAlgorithm");
            this.btnRemoveAlgorithm.Size = (new global::System.Drawing.Size(75, 23));
            this.btnRemoveAlgorithm.TabIndex = (29);
            this.btnRemoveAlgorithm.Text = ("Remove");
            this.btnRemoveAlgorithm.UseVisualStyleBackColor = (true);
            this.btnRemoveAlgorithm.Click += (this.btnRemoveAlgorithm_Click);
            // 
            // btnEditAlgorithm
            // 
            this.btnEditAlgorithm.Enabled = (false);
            this.btnEditAlgorithm.Location = (new global::System.Drawing.Point(505, 174));
            this.btnEditAlgorithm.Name = ("btnEditAlgorithm");
            this.btnEditAlgorithm.Size = (new global::System.Drawing.Size(75, 23));
            this.btnEditAlgorithm.TabIndex = (28);
            this.btnEditAlgorithm.Text = ("Edit");
            this.btnEditAlgorithm.UseVisualStyleBackColor = (true);
            this.btnEditAlgorithm.Click += (this.btnEditAlgorithm_Click);
            // 
            // btnAddAlgorithm
            // 
            this.btnAddAlgorithm.Location = (new global::System.Drawing.Point(424, 174));
            this.btnAddAlgorithm.Name = ("btnAddAlgorithm");
            this.btnAddAlgorithm.Size = (new global::System.Drawing.Size(75, 23));
            this.btnAddAlgorithm.TabIndex = (27);
            this.btnAddAlgorithm.Text = ("New...");
            this.btnAddAlgorithm.UseVisualStyleBackColor = (true);
            this.btnAddAlgorithm.Click += (this.btnAddAlgorithm_Click);
            // 
            // lvFloorAlgorithms
            // 
            this.lvFloorAlgorithms.Location = (new global::System.Drawing.Point(370, 59));
            this.lvFloorAlgorithms.MultiSelect = (false);
            this.lvFloorAlgorithms.Name = ("lvFloorAlgorithms");
            this.lvFloorAlgorithms.Size = (new global::System.Drawing.Size(349, 109));
            this.lvFloorAlgorithms.TabIndex = (26);
            this.lvFloorAlgorithms.UseCompatibleStateImageBehavior = (false);
            this.lvFloorAlgorithms.SelectedIndexChanged += (this.lvFloorAlgorithms_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = (true);
            this.label17.Location = (new global::System.Drawing.Point(482, 40));
            this.label17.Name = ("label17");
            this.label17.Size = (new global::System.Drawing.Size(127, 15));
            this.label17.TabIndex = (25);
            this.label17.Text = ("Generation Algorithms");
            // 
            // label16
            // 
            this.label16.AutoSize = (true);
            this.label16.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label16.Location = (new global::System.Drawing.Point(477, 10));
            this.label16.Name = ("label16");
            this.label16.Size = (new global::System.Drawing.Size(138, 21));
            this.label16.TabIndex = (24);
            this.label16.Text = ("Floor Room Data");
            // 
            // btnTrapGenerator
            // 
            this.btnTrapGenerator.Location = (new global::System.Drawing.Point(179, 310));
            this.btnTrapGenerator.Name = ("btnTrapGenerator");
            this.btnTrapGenerator.Size = (new global::System.Drawing.Size(151, 23));
            this.btnTrapGenerator.TabIndex = (23);
            this.btnTrapGenerator.Text = ("Traps to be generated...");
            this.btnTrapGenerator.UseVisualStyleBackColor = (true);
            this.btnTrapGenerator.Click += (this.btnTrapGenerator_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = (true);
            this.label15.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label15.Location = (new global::System.Drawing.Point(190, 276));
            this.label15.Name = ("label15");
            this.label15.Size = (new global::System.Drawing.Size(126, 21));
            this.label15.TabIndex = (22);
            this.label15.Text = ("Floor Trap Data");
            // 
            // btnItemGenerator
            // 
            this.btnItemGenerator.Location = (new global::System.Drawing.Point(12, 310));
            this.btnItemGenerator.Name = ("btnItemGenerator");
            this.btnItemGenerator.Size = (new global::System.Drawing.Size(151, 23));
            this.btnItemGenerator.TabIndex = (21);
            this.btnItemGenerator.Text = ("Items to be generated...");
            this.btnItemGenerator.UseVisualStyleBackColor = (true);
            this.btnItemGenerator.Click += (this.btnItemGenerator_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = (true);
            this.label14.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label14.Location = (new global::System.Drawing.Point(23, 276));
            this.label14.Name = ("label14");
            this.label14.Size = (new global::System.Drawing.Size(128, 21));
            this.label14.TabIndex = (20);
            this.label14.Text = ("Floor Item Data");
            // 
            // btnNPCGenerator
            // 
            this.btnNPCGenerator.Location = (new global::System.Drawing.Point(97, 242));
            this.btnNPCGenerator.Name = ("btnNPCGenerator");
            this.btnNPCGenerator.Size = (new global::System.Drawing.Size(151, 23));
            this.btnNPCGenerator.TabIndex = (19);
            this.btnNPCGenerator.Text = ("NPCs to be generated...");
            this.btnNPCGenerator.UseVisualStyleBackColor = (true);
            this.btnNPCGenerator.Click += (this.btnNPCGenerator_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = (true);
            this.label13.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label13.Location = (new global::System.Drawing.Point(109, 208));
            this.label13.Name = ("label13");
            this.label13.Size = (new global::System.Drawing.Size(126, 21));
            this.label13.TabIndex = (18);
            this.label13.Text = ("Floor NPC Data");
            // 
            // nudHeight
            // 
            this.nudHeight.Location = (new global::System.Drawing.Point(54, 92));
            this.nudHeight.Name = ("nudHeight");
            this.nudHeight.Size = (new global::System.Drawing.Size(54, 23));
            this.nudHeight.TabIndex = (17);
            this.nudHeight.ValueChanged += (this.nudHeight_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = (new global::System.Drawing.Point(54, 59));
            this.nudWidth.Name = ("nudWidth");
            this.nudWidth.Size = (new global::System.Drawing.Size(54, 23));
            this.nudWidth.TabIndex = (16);
            this.nudWidth.ValueChanged += (this.nudWidth_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = (true);
            this.label12.Location = (new global::System.Drawing.Point(9, 94));
            this.label12.Name = ("label12");
            this.label12.Size = (new global::System.Drawing.Size(43, 15));
            this.label12.TabIndex = (15);
            this.label12.Text = ("Height");
            // 
            // label11
            // 
            this.label11.AutoSize = (true);
            this.label11.Location = (new global::System.Drawing.Point(9, 61));
            this.label11.Name = ("label11");
            this.label11.Size = (new global::System.Drawing.Size(39, 15));
            this.label11.TabIndex = (14);
            this.label11.Text = ("Width");
            // 
            // fklblStairsReminder
            // 
            this.fklblStairsReminder.Enabled = (false);
            this.fklblStairsReminder.FlatAppearance.BorderSize = (0);
            this.fklblStairsReminder.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblStairsReminder.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblStairsReminder.Image")));
            this.fklblStairsReminder.ImageAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblStairsReminder.Location = (new global::System.Drawing.Point(9, 159));
            this.fklblStairsReminder.Name = ("fklblStairsReminder");
            this.fklblStairsReminder.Size = (new global::System.Drawing.Size(287, 42));
            this.fklblStairsReminder.TabIndex = (13);
            this.fklblStairsReminder.Text = ("Remember to include an element that\r\ngenerates Stairs, or it would softlock the game.");
            this.fklblStairsReminder.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblStairsReminder.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblStairsReminder.UseVisualStyleBackColor = (true);
            this.fklblStairsReminder.Visible = (false);
            // 
            // chkGenerateStairsOnStart
            // 
            this.chkGenerateStairsOnStart.AutoSize = (true);
            this.chkGenerateStairsOnStart.Location = (new global::System.Drawing.Point(9, 134));
            this.chkGenerateStairsOnStart.Name = ("chkGenerateStairsOnStart");
            this.chkGenerateStairsOnStart.Size = (new global::System.Drawing.Size(214, 19));
            this.chkGenerateStairsOnStart.TabIndex = (4);
            this.chkGenerateStairsOnStart.Text = ("Place Stairs when Floor is generated");
            this.chkGenerateStairsOnStart.UseVisualStyleBackColor = (true);
            this.chkGenerateStairsOnStart.CheckedChanged += (this.chkGenerateStairsOnStart_CheckedChanged);
            // 
            // nudMaxFloorLevel
            // 
            this.nudMaxFloorLevel.Location = (new global::System.Drawing.Point(138, 10));
            this.nudMaxFloorLevel.Name = ("nudMaxFloorLevel");
            this.nudMaxFloorLevel.Size = (new global::System.Drawing.Size(33, 23));
            this.nudMaxFloorLevel.TabIndex = (3);
            this.nudMaxFloorLevel.ValueChanged += (this.nudMaxFloorLevel_ValueChanged);
            this.nudMaxFloorLevel.Leave += (this.nudMaxFloorLevel_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = (true);
            this.label10.Location = (new global::System.Drawing.Point(114, 12));
            this.label10.Name = ("label10");
            this.label10.Size = (new global::System.Drawing.Size(18, 15));
            this.label10.TabIndex = (2);
            this.label10.Text = ("to");
            // 
            // nudMinFloorLevel
            // 
            this.nudMinFloorLevel.Location = (new global::System.Drawing.Point(76, 10));
            this.nudMinFloorLevel.Name = ("nudMinFloorLevel");
            this.nudMinFloorLevel.Size = (new global::System.Drawing.Size(33, 23));
            this.nudMinFloorLevel.TabIndex = (1);
            this.nudMinFloorLevel.ValueChanged += (this.nudMinFloorLevel_ValueChanged);
            this.nudMinFloorLevel.Leave += (this.nudMinFloorLevel_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = (true);
            this.label9.Location = (new global::System.Drawing.Point(9, 12));
            this.label9.Name = ("label9");
            this.label9.Size = (new global::System.Drawing.Size(65, 15));
            this.label9.TabIndex = (0);
            this.label9.Text = ("From Level");
            // 
            // tpFactionInfos
            // 
            this.tpFactionInfos.Controls.Add(this.lbEnemies);
            this.tpFactionInfos.Controls.Add(this.label26);
            this.tpFactionInfos.Controls.Add(this.btnEnemiesToNeutrals);
            this.tpFactionInfos.Controls.Add(this.btnEnemyToNeutral);
            this.tpFactionInfos.Controls.Add(this.btnNeutralsToEnemies);
            this.tpFactionInfos.Controls.Add(this.btnNeutralToEnemy);
            this.tpFactionInfos.Controls.Add(this.lbNeutrals);
            this.tpFactionInfos.Controls.Add(this.label25);
            this.tpFactionInfos.Controls.Add(this.btnNeutralsToAllies);
            this.tpFactionInfos.Controls.Add(this.btnNeutralToAlly);
            this.tpFactionInfos.Controls.Add(this.btnAlliesToNeutrals);
            this.tpFactionInfos.Controls.Add(this.btnAllyToNeutral);
            this.tpFactionInfos.Controls.Add(this.lbAllies);
            this.tpFactionInfos.Controls.Add(this.label24);
            this.tpFactionInfos.Controls.Add(this.label23);
            this.tpFactionInfos.Controls.Add(this.fklblFactionDescriptionLocale);
            this.tpFactionInfos.Controls.Add(this.txtFactionDescription);
            this.tpFactionInfos.Controls.Add(this.label22);
            this.tpFactionInfos.Controls.Add(this.fklblFactionNameLocale);
            this.tpFactionInfos.Controls.Add(this.txtFactionName);
            this.tpFactionInfos.Controls.Add(this.label21);
            this.tpFactionInfos.Location = (new global::System.Drawing.Point(4, 24));
            this.tpFactionInfos.Name = ("tpFactionInfos");
            this.tpFactionInfos.Size = (new global::System.Drawing.Size(740, 356));
            this.tpFactionInfos.TabIndex = (3);
            this.tpFactionInfos.Text = ("Faction");
            this.tpFactionInfos.UseVisualStyleBackColor = (true);
            // 
            // lbEnemies
            // 
            this.lbEnemies.FormattingEnabled = (true);
            this.lbEnemies.ItemHeight = (15);
            this.lbEnemies.Location = (new global::System.Drawing.Point(450, 161));
            this.lbEnemies.Name = ("lbEnemies");
            this.lbEnemies.Size = (new global::System.Drawing.Size(111, 169));
            this.lbEnemies.TabIndex = (33);
            this.lbEnemies.SelectedIndexChanged += (this.lbEnemies_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = (true);
            this.label26.Font = (new global::System.Drawing.Font("Segoe UI", 9F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label26.Location = (new global::System.Drawing.Point(461, 143));
            this.label26.Name = ("label26");
            this.label26.Size = (new global::System.Drawing.Size(92, 15));
            this.label26.TabIndex = (32);
            this.label26.Text = ("Enemies With...");
            // 
            // btnEnemiesToNeutrals
            // 
            this.btnEnemiesToNeutrals.Enabled = (false);
            this.btnEnemiesToNeutrals.Location = (new global::System.Drawing.Point(407, 211));
            this.btnEnemiesToNeutrals.Name = ("btnEnemiesToNeutrals");
            this.btnEnemiesToNeutrals.Size = (new global::System.Drawing.Size(37, 23));
            this.btnEnemiesToNeutrals.TabIndex = (31);
            this.btnEnemiesToNeutrals.Text = ("<<");
            this.btnEnemiesToNeutrals.UseVisualStyleBackColor = (true);
            this.btnEnemiesToNeutrals.Click += (this.btnEnemiesToNeutrals_Click);
            // 
            // btnEnemyToNeutral
            // 
            this.btnEnemyToNeutral.Enabled = (false);
            this.btnEnemyToNeutral.Location = (new global::System.Drawing.Point(407, 182));
            this.btnEnemyToNeutral.Name = ("btnEnemyToNeutral");
            this.btnEnemyToNeutral.Size = (new global::System.Drawing.Size(37, 23));
            this.btnEnemyToNeutral.TabIndex = (30);
            this.btnEnemyToNeutral.Text = ("<");
            this.btnEnemyToNeutral.UseVisualStyleBackColor = (true);
            this.btnEnemyToNeutral.Click += (this.btnEnemyToNeutral_Click);
            // 
            // btnNeutralsToEnemies
            // 
            this.btnNeutralsToEnemies.Enabled = (false);
            this.btnNeutralsToEnemies.Location = (new global::System.Drawing.Point(407, 284));
            this.btnNeutralsToEnemies.Name = ("btnNeutralsToEnemies");
            this.btnNeutralsToEnemies.Size = (new global::System.Drawing.Size(37, 23));
            this.btnNeutralsToEnemies.TabIndex = (29);
            this.btnNeutralsToEnemies.Text = (">>");
            this.btnNeutralsToEnemies.UseVisualStyleBackColor = (true);
            this.btnNeutralsToEnemies.Click += (this.btnNeutralsToEnemies_Click);
            // 
            // btnNeutralToEnemy
            // 
            this.btnNeutralToEnemy.Enabled = (false);
            this.btnNeutralToEnemy.Location = (new global::System.Drawing.Point(407, 255));
            this.btnNeutralToEnemy.Name = ("btnNeutralToEnemy");
            this.btnNeutralToEnemy.Size = (new global::System.Drawing.Size(37, 23));
            this.btnNeutralToEnemy.TabIndex = (28);
            this.btnNeutralToEnemy.Text = (">");
            this.btnNeutralToEnemy.UseVisualStyleBackColor = (true);
            this.btnNeutralToEnemy.Click += (this.btnNeutralToEnemy_Click);
            // 
            // lbNeutrals
            // 
            this.lbNeutrals.FormattingEnabled = (true);
            this.lbNeutrals.ItemHeight = (15);
            this.lbNeutrals.Location = (new global::System.Drawing.Point(290, 161));
            this.lbNeutrals.Name = ("lbNeutrals");
            this.lbNeutrals.Size = (new global::System.Drawing.Size(111, 169));
            this.lbNeutrals.TabIndex = (27);
            this.lbNeutrals.SelectedIndexChanged += (this.lbNeutrals_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = (true);
            this.label25.Font = (new global::System.Drawing.Font("Segoe UI", 9F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label25.Location = (new global::System.Drawing.Point(303, 143));
            this.label25.Name = ("label25");
            this.label25.Size = (new global::System.Drawing.Size(88, 15));
            this.label25.TabIndex = (26);
            this.label25.Text = ("Neutral With...");
            // 
            // btnNeutralsToAllies
            // 
            this.btnNeutralsToAllies.Enabled = (false);
            this.btnNeutralsToAllies.Location = (new global::System.Drawing.Point(247, 211));
            this.btnNeutralsToAllies.Name = ("btnNeutralsToAllies");
            this.btnNeutralsToAllies.Size = (new global::System.Drawing.Size(37, 23));
            this.btnNeutralsToAllies.TabIndex = (25);
            this.btnNeutralsToAllies.Text = ("<<");
            this.btnNeutralsToAllies.UseVisualStyleBackColor = (true);
            this.btnNeutralsToAllies.Click += (this.btnNeutralsToAllies_Click);
            // 
            // btnNeutralToAlly
            // 
            this.btnNeutralToAlly.Enabled = (false);
            this.btnNeutralToAlly.Location = (new global::System.Drawing.Point(247, 182));
            this.btnNeutralToAlly.Name = ("btnNeutralToAlly");
            this.btnNeutralToAlly.Size = (new global::System.Drawing.Size(37, 23));
            this.btnNeutralToAlly.TabIndex = (24);
            this.btnNeutralToAlly.Text = ("<");
            this.btnNeutralToAlly.UseVisualStyleBackColor = (true);
            this.btnNeutralToAlly.Click += (this.btnNeutralToAlly_Click);
            // 
            // btnAlliesToNeutrals
            // 
            this.btnAlliesToNeutrals.Enabled = (false);
            this.btnAlliesToNeutrals.Location = (new global::System.Drawing.Point(247, 284));
            this.btnAlliesToNeutrals.Name = ("btnAlliesToNeutrals");
            this.btnAlliesToNeutrals.Size = (new global::System.Drawing.Size(37, 23));
            this.btnAlliesToNeutrals.TabIndex = (23);
            this.btnAlliesToNeutrals.Text = (">>");
            this.btnAlliesToNeutrals.UseVisualStyleBackColor = (true);
            this.btnAlliesToNeutrals.Click += (this.btnAlliesToNeutrals_Click);
            // 
            // btnAllyToNeutral
            // 
            this.btnAllyToNeutral.Enabled = (false);
            this.btnAllyToNeutral.Location = (new global::System.Drawing.Point(247, 255));
            this.btnAllyToNeutral.Name = ("btnAllyToNeutral");
            this.btnAllyToNeutral.Size = (new global::System.Drawing.Size(37, 23));
            this.btnAllyToNeutral.TabIndex = (22);
            this.btnAllyToNeutral.Text = (">");
            this.btnAllyToNeutral.UseVisualStyleBackColor = (true);
            this.btnAllyToNeutral.Click += (this.btnAllyToNeutral_Click);
            // 
            // lbAllies
            // 
            this.lbAllies.FormattingEnabled = (true);
            this.lbAllies.ItemHeight = (15);
            this.lbAllies.Location = (new global::System.Drawing.Point(130, 161));
            this.lbAllies.Name = ("lbAllies");
            this.lbAllies.Size = (new global::System.Drawing.Size(111, 169));
            this.lbAllies.TabIndex = (21);
            this.lbAllies.SelectedIndexChanged += (this.lbAllies_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = (true);
            this.label24.Font = (new global::System.Drawing.Font("Segoe UI", 9F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label24.Location = (new global::System.Drawing.Point(147, 143));
            this.label24.Name = ("label24");
            this.label24.Size = (new global::System.Drawing.Size(77, 15));
            this.label24.TabIndex = (20);
            this.label24.Text = ("Allied With...");
            // 
            // label23
            // 
            this.label23.AutoSize = (true);
            this.label23.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label23.Location = (new global::System.Drawing.Point(296, 109));
            this.label23.Name = ("label23");
            this.label23.Size = (new global::System.Drawing.Size(98, 21));
            this.label23.TabIndex = (19);
            this.label23.Text = ("Allegiances");
            // 
            // fklblFactionDescriptionLocale
            // 
            this.fklblFactionDescriptionLocale.Enabled = (false);
            this.fklblFactionDescriptionLocale.FlatAppearance.BorderSize = (0);
            this.fklblFactionDescriptionLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblFactionDescriptionLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblFactionDescriptionLocale.Image")));
            this.fklblFactionDescriptionLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblFactionDescriptionLocale.Location = (new global::System.Drawing.Point(375, 59));
            this.fklblFactionDescriptionLocale.Name = ("fklblFactionDescriptionLocale");
            this.fklblFactionDescriptionLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblFactionDescriptionLocale.TabIndex = (18);
            this.fklblFactionDescriptionLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblFactionDescriptionLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblFactionDescriptionLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblFactionDescriptionLocale.UseVisualStyleBackColor = (true);
            this.fklblFactionDescriptionLocale.Visible = (false);
            // 
            // txtFactionDescription
            // 
            this.txtFactionDescription.Location = (new global::System.Drawing.Point(375, 30));
            this.txtFactionDescription.Name = ("txtFactionDescription");
            this.txtFactionDescription.Size = (new global::System.Drawing.Size(359, 23));
            this.txtFactionDescription.TabIndex = (17);
            this.txtFactionDescription.TextChanged += (this.txtFactionDescription_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = (true);
            this.label22.Location = (new global::System.Drawing.Point(375, 12));
            this.label22.Name = ("label22");
            this.label22.Size = (new global::System.Drawing.Size(67, 15));
            this.label22.TabIndex = (16);
            this.label22.Text = ("Description");
            // 
            // fklblFactionNameLocale
            // 
            this.fklblFactionNameLocale.Enabled = (false);
            this.fklblFactionNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblFactionNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblFactionNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblFactionNameLocale.Image")));
            this.fklblFactionNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblFactionNameLocale.Location = (new global::System.Drawing.Point(13, 59));
            this.fklblFactionNameLocale.Name = ("fklblFactionNameLocale");
            this.fklblFactionNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblFactionNameLocale.TabIndex = (15);
            this.fklblFactionNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblFactionNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblFactionNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblFactionNameLocale.UseVisualStyleBackColor = (true);
            this.fklblFactionNameLocale.Visible = (false);
            // 
            // txtFactionName
            // 
            this.txtFactionName.Location = (new global::System.Drawing.Point(13, 30));
            this.txtFactionName.Name = ("txtFactionName");
            this.txtFactionName.Size = (new global::System.Drawing.Size(359, 23));
            this.txtFactionName.TabIndex = (14);
            this.txtFactionName.TextChanged += (this.txtFactionName_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = (true);
            this.label21.Location = (new global::System.Drawing.Point(13, 12));
            this.label21.Name = ("label21");
            this.label21.Size = (new global::System.Drawing.Size(39, 15));
            this.label21.TabIndex = (13);
            this.label21.Text = ("Name");
            // 
            // tpPlayerClass
            // 
            this.tpPlayerClass.AutoScroll = (true);
            this.tpPlayerClass.Controls.Add(this.ssPlayer);
            this.tpPlayerClass.Controls.Add(this.sisPlayerStartingInventory);
            this.tpPlayerClass.Controls.Add(this.saePlayerOnDeath);
            this.tpPlayerClass.Controls.Add(this.saePlayerOnAttacked);
            this.tpPlayerClass.Controls.Add(this.saePlayerOnTurnStart);
            this.tpPlayerClass.Controls.Add(this.maePlayerOnAttack);
            this.tpPlayerClass.Controls.Add(this.label58);
            this.tpPlayerClass.Controls.Add(this.cmbPlayerStartingArmor);
            this.tpPlayerClass.Controls.Add(this.label57);
            this.tpPlayerClass.Controls.Add(this.cmbPlayerStartingWeapon);
            this.tpPlayerClass.Controls.Add(this.label56);
            this.tpPlayerClass.Controls.Add(this.label54);
            this.tpPlayerClass.Controls.Add(this.nudPlayerInventorySize);
            this.tpPlayerClass.Controls.Add(this.label53);
            this.tpPlayerClass.Controls.Add(this.label30);
            this.tpPlayerClass.Controls.Add(this.chkPlayerStartsVisible);
            this.tpPlayerClass.Controls.Add(this.cmbPlayerFaction);
            this.tpPlayerClass.Controls.Add(this.label29);
            this.tpPlayerClass.Controls.Add(this.chkRequirePlayerPrompt);
            this.tpPlayerClass.Controls.Add(this.fklblPlayerClassDescriptionLocale);
            this.tpPlayerClass.Controls.Add(this.txtPlayerClassDescription);
            this.tpPlayerClass.Controls.Add(this.label28);
            this.tpPlayerClass.Controls.Add(this.fklblPlayerClassNameLocale);
            this.tpPlayerClass.Controls.Add(this.txtPlayerClassName);
            this.tpPlayerClass.Controls.Add(this.label27);
            this.tpPlayerClass.Controls.Add(this.crsPlayer);
            this.tpPlayerClass.Location = (new global::System.Drawing.Point(4, 24));
            this.tpPlayerClass.Name = ("tpPlayerClass");
            this.tpPlayerClass.Size = (new global::System.Drawing.Size(740, 356));
            this.tpPlayerClass.TabIndex = (4);
            this.tpPlayerClass.Text = ("Player Class");
            this.tpPlayerClass.UseVisualStyleBackColor = (true);
            // 
            // ssPlayer
            // 
            this.ssPlayer.AttackPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.AutoSize = (true);
            this.ssPlayer.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.ssPlayer.BaseAccuracy = (100);
            this.ssPlayer.BaseAttack = (0);
            this.ssPlayer.BaseDefense = (0);
            this.ssPlayer.BaseEvasion = (0);
            this.ssPlayer.BaseHP = (1);
            this.ssPlayer.BaseHPRegeneration = (new global::System.Decimal(new global::System.Int32[] { 1, 0, 0, 0 }));
            this.ssPlayer.BaseMovement = (1);
            this.ssPlayer.BaseMP = (0);
            this.ssPlayer.BaseMPRegeneration = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.BaseSightRangeDisplayNames = ((global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)(resources.GetObject("ssPlayer.BaseSightRangeDisplayNames")));
            this.ssPlayer.CanGainExperience = (false);
            this.ssPlayer.DefensePerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.ExperienceToLevelUpFormula = ("");
            this.ssPlayer.HPPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.HPRegenerationPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.Location = (new global::System.Drawing.Point(385, 94));
            this.ssPlayer.MaxLevel = (1);
            this.ssPlayer.MovementPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.MPPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.MPRegenerationPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssPlayer.Name = ("ssPlayer");
            this.ssPlayer.Size = (new global::System.Drawing.Size(331, 687));
            this.ssPlayer.TabIndex = (129);
            this.ssPlayer.UsesMP = (false);
            // 
            // sisPlayerStartingInventory
            // 
            this.sisPlayerStartingInventory.Inventory = ((global::System.Collections.Generic.List<global::System.String>)(resources.GetObject("sisPlayerStartingInventory.Inventory")));
            this.sisPlayerStartingInventory.InventorySize = (0);
            this.sisPlayerStartingInventory.Location = (new global::System.Drawing.Point(13, 396));
            this.sisPlayerStartingInventory.Name = ("sisPlayerStartingInventory");
            this.sisPlayerStartingInventory.SelectableItems = (null);
            this.sisPlayerStartingInventory.Size = (new global::System.Drawing.Size(293, 79));
            this.sisPlayerStartingInventory.TabIndex = (128);
            // 
            // saePlayerOnDeath
            // 
            this.saePlayerOnDeath.Action = (null);
            this.saePlayerOnDeath.ActionDescription = ("When they die...                   ");
            this.saePlayerOnDeath.ActionTypeText = ("On Death");
            this.saePlayerOnDeath.AlteredStatuses = (null);
            this.saePlayerOnDeath.AutoSize = (true);
            this.saePlayerOnDeath.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saePlayerOnDeath.ClassId = (null);
            this.saePlayerOnDeath.Dungeon = (null);
            this.saePlayerOnDeath.EffectParamData = (null);
            this.saePlayerOnDeath.Location = (new global::System.Drawing.Point(13, 686));
            this.saePlayerOnDeath.Name = ("saePlayerOnDeath");
            this.saePlayerOnDeath.PlaceholderActionName = ("Death");
            this.saePlayerOnDeath.RequiresActionName = (false);
            this.saePlayerOnDeath.RequiresCondition = (false);
            this.saePlayerOnDeath.RequiresDescription = (false);
            this.saePlayerOnDeath.Size = (new global::System.Drawing.Size(283, 32));
            this.saePlayerOnDeath.SourceDescription = ("The player");
            this.saePlayerOnDeath.TabIndex = (127);
            this.saePlayerOnDeath.TargetDescription = ("Whoever killed them (if any)");
            this.saePlayerOnDeath.ThisDescription = ("The player");
            this.saePlayerOnDeath.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saePlayerOnDeath.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saePlayerOnAttacked
            // 
            this.saePlayerOnAttacked.Action = (null);
            this.saePlayerOnAttacked.ActionDescription = ("When they get attacked...   ");
            this.saePlayerOnAttacked.ActionTypeText = ("Interacted");
            this.saePlayerOnAttacked.AlteredStatuses = (null);
            this.saePlayerOnAttacked.AutoSize = (true);
            this.saePlayerOnAttacked.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saePlayerOnAttacked.ClassId = (null);
            this.saePlayerOnAttacked.Dungeon = (null);
            this.saePlayerOnAttacked.EffectParamData = (null);
            this.saePlayerOnAttacked.Location = (new global::System.Drawing.Point(13, 648));
            this.saePlayerOnAttacked.Name = ("saePlayerOnAttacked");
            this.saePlayerOnAttacked.PlaceholderActionName = ("Interacted");
            this.saePlayerOnAttacked.RequiresActionName = (false);
            this.saePlayerOnAttacked.RequiresCondition = (false);
            this.saePlayerOnAttacked.RequiresDescription = (false);
            this.saePlayerOnAttacked.Size = (new global::System.Drawing.Size(284, 32));
            this.saePlayerOnAttacked.SourceDescription = ("The player");
            this.saePlayerOnAttacked.TabIndex = (126);
            this.saePlayerOnAttacked.TargetDescription = ("Whoever interacted with them");
            this.saePlayerOnAttacked.ThisDescription = ("The player");
            this.saePlayerOnAttacked.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saePlayerOnAttacked.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saePlayerOnTurnStart
            // 
            this.saePlayerOnTurnStart.Action = (null);
            this.saePlayerOnTurnStart.ActionDescription = ("When the next turn starts...");
            this.saePlayerOnTurnStart.ActionTypeText = ("Turn Start");
            this.saePlayerOnTurnStart.AlteredStatuses = (null);
            this.saePlayerOnTurnStart.AutoSize = (true);
            this.saePlayerOnTurnStart.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saePlayerOnTurnStart.ClassId = (null);
            this.saePlayerOnTurnStart.Dungeon = (null);
            this.saePlayerOnTurnStart.EffectParamData = (null);
            this.saePlayerOnTurnStart.Location = (new global::System.Drawing.Point(13, 510));
            this.saePlayerOnTurnStart.Name = ("saePlayerOnTurnStart");
            this.saePlayerOnTurnStart.PlaceholderActionName = ("TurnStart");
            this.saePlayerOnTurnStart.RequiresActionName = (false);
            this.saePlayerOnTurnStart.RequiresCondition = (false);
            this.saePlayerOnTurnStart.RequiresDescription = (false);
            this.saePlayerOnTurnStart.Size = (new global::System.Drawing.Size(283, 32));
            this.saePlayerOnTurnStart.SourceDescription = ("The player");
            this.saePlayerOnTurnStart.TabIndex = (125);
            this.saePlayerOnTurnStart.TargetDescription = ("The player");
            this.saePlayerOnTurnStart.ThisDescription = ("The player");
            this.saePlayerOnTurnStart.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saePlayerOnTurnStart.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // maePlayerOnAttack
            // 
            this.maePlayerOnAttack.ActionDescription = ("Can do the following to\r\ninteract with someone:");
            this.maePlayerOnAttack.Actions = ((global::System.Collections.Generic.List<global::RogueCustomsGameEngine.Utils.JsonImports.ActionWithEffectsInfo>)(resources.GetObject("maePlayerOnAttack.Actions")));
            this.maePlayerOnAttack.ActionTypeText = ("Interact");
            this.maePlayerOnAttack.AlteredStatuses = (null);
            this.maePlayerOnAttack.ClassId = (null);
            this.maePlayerOnAttack.Dungeon = (null);
            this.maePlayerOnAttack.EffectParamData = (null);
            this.maePlayerOnAttack.Location = (new global::System.Drawing.Point(13, 548));
            this.maePlayerOnAttack.Name = ("maePlayerOnAttack");
            this.maePlayerOnAttack.PlaceholderActionName = (null);
            this.maePlayerOnAttack.RequiresActionName = (true);
            this.maePlayerOnAttack.RequiresCondition = (true);
            this.maePlayerOnAttack.RequiresDescription = (true);
            this.maePlayerOnAttack.Size = (new global::System.Drawing.Size(368, 94));
            this.maePlayerOnAttack.SourceDescription = ("The player");
            this.maePlayerOnAttack.TabIndex = (124);
            this.maePlayerOnAttack.TargetDescription = ("Whoever they are targeting");
            this.maePlayerOnAttack.ThisDescription = ("The player");
            this.maePlayerOnAttack.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.MustEndTurn);
            this.maePlayerOnAttack.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.FullConditions);
            // 
            // label58
            // 
            this.label58.AutoSize = (true);
            this.label58.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label58.Location = (new global::System.Drawing.Point(141, 483));
            this.label58.Name = ("label58");
            this.label58.Size = (new global::System.Drawing.Size(67, 21));
            this.label58.TabIndex = (104);
            this.label58.Text = ("Actions");
            // 
            // cmbPlayerStartingArmor
            // 
            this.cmbPlayerStartingArmor.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbPlayerStartingArmor.FormattingEnabled = (true);
            this.cmbPlayerStartingArmor.Location = (new global::System.Drawing.Point(146, 331));
            this.cmbPlayerStartingArmor.Name = ("cmbPlayerStartingArmor");
            this.cmbPlayerStartingArmor.Size = (new global::System.Drawing.Size(158, 23));
            this.cmbPlayerStartingArmor.TabIndex = (81);
            this.cmbPlayerStartingArmor.SelectedIndexChanged += (this.cmbPlayerStartingArmor_SelectedIndexChanged);
            // 
            // label57
            // 
            this.label57.AutoSize = (true);
            this.label57.Location = (new global::System.Drawing.Point(13, 334));
            this.label57.Name = ("label57");
            this.label57.Size = (new global::System.Drawing.Size(131, 15));
            this.label57.TabIndex = (80);
            this.label57.Text = ("When unarmored, wear");
            // 
            // cmbPlayerStartingWeapon
            // 
            this.cmbPlayerStartingWeapon.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbPlayerStartingWeapon.FormattingEnabled = (true);
            this.cmbPlayerStartingWeapon.Location = (new global::System.Drawing.Point(139, 300));
            this.cmbPlayerStartingWeapon.Name = ("cmbPlayerStartingWeapon");
            this.cmbPlayerStartingWeapon.Size = (new global::System.Drawing.Size(165, 23));
            this.cmbPlayerStartingWeapon.TabIndex = (79);
            this.cmbPlayerStartingWeapon.SelectedIndexChanged += (this.cmbPlayerStartingWeapon_SelectedIndexChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = (true);
            this.label56.Location = (new global::System.Drawing.Point(13, 303));
            this.label56.Name = ("label56");
            this.label56.Size = (new global::System.Drawing.Size(123, 15));
            this.label56.TabIndex = (78);
            this.label56.Text = ("When unarmed, wield");
            // 
            // label54
            // 
            this.label54.AutoSize = (true);
            this.label54.Location = (new global::System.Drawing.Point(172, 364));
            this.label54.Name = ("label54");
            this.label54.Size = (new global::System.Drawing.Size(36, 15));
            this.label54.TabIndex = (72);
            this.label54.Text = ("items");
            // 
            // nudPlayerInventorySize
            // 
            this.nudPlayerInventorySize.Location = (new global::System.Drawing.Point(121, 359));
            this.nudPlayerInventorySize.Maximum = (new global::System.Decimal(new global::System.Int32[] { 999, 0, 0, 0 }));
            this.nudPlayerInventorySize.Name = ("nudPlayerInventorySize");
            this.nudPlayerInventorySize.Size = (new global::System.Drawing.Size(45, 23));
            this.nudPlayerInventorySize.TabIndex = (71);
            this.nudPlayerInventorySize.ValueChanged += (this.nudPlayerInventorySize_ValueChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = (true);
            this.label53.Location = (new global::System.Drawing.Point(13, 362));
            this.label53.Name = ("label53");
            this.label53.Size = (new global::System.Drawing.Size(109, 15));
            this.label53.TabIndex = (70);
            this.label53.Text = ("Inventory Capacity:");
            // 
            // label30
            // 
            this.label30.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label30.Location = (new global::System.Drawing.Point(370, 19));
            this.label30.Name = ("label30");
            this.label30.Size = (new global::System.Drawing.Size(131, 52));
            this.label30.TabIndex = (26);
            this.label30.Text = ("Appearance");
            this.label30.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // chkPlayerStartsVisible
            // 
            this.chkPlayerStartsVisible.AutoSize = (true);
            this.chkPlayerStartsVisible.Location = (new global::System.Drawing.Point(13, 272));
            this.chkPlayerStartsVisible.Name = ("chkPlayerStartsVisible");
            this.chkPlayerStartsVisible.Size = (new global::System.Drawing.Size(102, 19));
            this.chkPlayerStartsVisible.TabIndex = (25);
            this.chkPlayerStartsVisible.Text = ("Spawns visible");
            this.chkPlayerStartsVisible.UseVisualStyleBackColor = (true);
            this.chkPlayerStartsVisible.CheckedChanged += (this.chkPlayerStartsVisible_CheckedChanged);
            // 
            // cmbPlayerFaction
            // 
            this.cmbPlayerFaction.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbPlayerFaction.FormattingEnabled = (true);
            this.cmbPlayerFaction.Location = (new global::System.Drawing.Point(65, 241));
            this.cmbPlayerFaction.Name = ("cmbPlayerFaction");
            this.cmbPlayerFaction.Size = (new global::System.Drawing.Size(146, 23));
            this.cmbPlayerFaction.TabIndex = (24);
            this.cmbPlayerFaction.SelectedIndexChanged += (this.cmbPlayerFaction_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = (true);
            this.label29.Location = (new global::System.Drawing.Point(13, 244));
            this.label29.Name = ("label29");
            this.label29.Size = (new global::System.Drawing.Size(46, 15));
            this.label29.TabIndex = (23);
            this.label29.Text = ("Faction");
            // 
            // chkRequirePlayerPrompt
            // 
            this.chkRequirePlayerPrompt.AutoSize = (true);
            this.chkRequirePlayerPrompt.Location = (new global::System.Drawing.Point(13, 107));
            this.chkRequirePlayerPrompt.Name = ("chkRequirePlayerPrompt");
            this.chkRequirePlayerPrompt.Size = (new global::System.Drawing.Size(287, 19));
            this.chkRequirePlayerPrompt.TabIndex = (22);
            this.chkRequirePlayerPrompt.Text = ("Player will have to provide a name upon selection");
            this.chkRequirePlayerPrompt.UseVisualStyleBackColor = (true);
            this.chkRequirePlayerPrompt.CheckedChanged += (this.chkRequirePlayerPrompt_CheckedChanged);
            // 
            // fklblPlayerClassDescriptionLocale
            // 
            this.fklblPlayerClassDescriptionLocale.Enabled = (false);
            this.fklblPlayerClassDescriptionLocale.FlatAppearance.BorderSize = (0);
            this.fklblPlayerClassDescriptionLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblPlayerClassDescriptionLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblPlayerClassDescriptionLocale.Image")));
            this.fklblPlayerClassDescriptionLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblPlayerClassDescriptionLocale.Location = (new global::System.Drawing.Point(13, 185));
            this.fklblPlayerClassDescriptionLocale.Name = ("fklblPlayerClassDescriptionLocale");
            this.fklblPlayerClassDescriptionLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblPlayerClassDescriptionLocale.TabIndex = (21);
            this.fklblPlayerClassDescriptionLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblPlayerClassDescriptionLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblPlayerClassDescriptionLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblPlayerClassDescriptionLocale.UseVisualStyleBackColor = (true);
            this.fklblPlayerClassDescriptionLocale.Visible = (false);
            // 
            // txtPlayerClassDescription
            // 
            this.txtPlayerClassDescription.Location = (new global::System.Drawing.Point(13, 156));
            this.txtPlayerClassDescription.Name = ("txtPlayerClassDescription");
            this.txtPlayerClassDescription.Size = (new global::System.Drawing.Size(350, 23));
            this.txtPlayerClassDescription.TabIndex = (20);
            this.txtPlayerClassDescription.TextChanged += (this.txtPlayerClassDescription_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = (true);
            this.label28.Location = (new global::System.Drawing.Point(13, 138));
            this.label28.Name = ("label28");
            this.label28.Size = (new global::System.Drawing.Size(67, 15));
            this.label28.TabIndex = (19);
            this.label28.Text = ("Description");
            // 
            // fklblPlayerClassNameLocale
            // 
            this.fklblPlayerClassNameLocale.Enabled = (false);
            this.fklblPlayerClassNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblPlayerClassNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblPlayerClassNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblPlayerClassNameLocale.Image")));
            this.fklblPlayerClassNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblPlayerClassNameLocale.Location = (new global::System.Drawing.Point(13, 55));
            this.fklblPlayerClassNameLocale.Name = ("fklblPlayerClassNameLocale");
            this.fklblPlayerClassNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblPlayerClassNameLocale.TabIndex = (18);
            this.fklblPlayerClassNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblPlayerClassNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblPlayerClassNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblPlayerClassNameLocale.UseVisualStyleBackColor = (true);
            this.fklblPlayerClassNameLocale.Visible = (false);
            // 
            // txtPlayerClassName
            // 
            this.txtPlayerClassName.Location = (new global::System.Drawing.Point(13, 26));
            this.txtPlayerClassName.Name = ("txtPlayerClassName");
            this.txtPlayerClassName.Size = (new global::System.Drawing.Size(350, 23));
            this.txtPlayerClassName.TabIndex = (17);
            this.txtPlayerClassName.TextChanged += (this.txtPlayerClassName_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = (true);
            this.label27.Location = (new global::System.Drawing.Point(13, 8));
            this.label27.Name = ("label27");
            this.label27.Size = (new global::System.Drawing.Size(80, 15));
            this.label27.TabIndex = (16);
            this.label27.Text = ("Default Name");
            // 
            // crsPlayer
            // 
            this.crsPlayer.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsPlayer.BackgroundColor")));
            this.crsPlayer.Character = ('\0');
            this.crsPlayer.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsPlayer.ForegroundColor")));
            this.crsPlayer.Location = (new global::System.Drawing.Point(504, 8));
            this.crsPlayer.Name = ("crsPlayer");
            this.crsPlayer.Size = (new global::System.Drawing.Size(211, 83));
            this.crsPlayer.TabIndex = (123);
            this.crsPlayer.PropertyChanged += (this.crsPlayer_PropertyChanged);
            // 
            // tpNPC
            // 
            this.tpNPC.AutoScroll = (true);
            this.tpNPC.Controls.Add(this.maeNPCOnInteracted);
            this.tpNPC.Controls.Add(this.saeNPCOnSpawn);
            this.tpNPC.Controls.Add(this.ssNPC);
            this.tpNPC.Controls.Add(this.sisNPCStartingInventory);
            this.tpNPC.Controls.Add(this.saeNPCOnDeath);
            this.tpNPC.Controls.Add(this.saeNPCOnAttacked);
            this.tpNPC.Controls.Add(this.saeNPCOnTurnStart);
            this.tpNPC.Controls.Add(this.maeNPCOnAttack);
            this.tpNPC.Controls.Add(this.nudNPCOddsToTargetSelf);
            this.tpNPC.Controls.Add(this.label104);
            this.tpNPC.Controls.Add(this.txtNPCExperiencePayout);
            this.tpNPC.Controls.Add(this.label103);
            this.tpNPC.Controls.Add(this.chkNPCKnowsAllCharacterPositions);
            this.tpNPC.Controls.Add(this.label67);
            this.tpNPC.Controls.Add(this.cmbNPCStartingArmor);
            this.tpNPC.Controls.Add(this.label70);
            this.tpNPC.Controls.Add(this.cmbNPCStartingWeapon);
            this.tpNPC.Controls.Add(this.label71);
            this.tpNPC.Controls.Add(this.label73);
            this.tpNPC.Controls.Add(this.nudNPCInventorySize);
            this.tpNPC.Controls.Add(this.label74);
            this.tpNPC.Controls.Add(this.label98);
            this.tpNPC.Controls.Add(this.chkNPCStartsVisible);
            this.tpNPC.Controls.Add(this.cmbNPCFaction);
            this.tpNPC.Controls.Add(this.label99);
            this.tpNPC.Controls.Add(this.fklblNPCDescriptionLocale);
            this.tpNPC.Controls.Add(this.txtNPCDescription);
            this.tpNPC.Controls.Add(this.label100);
            this.tpNPC.Controls.Add(this.fklblNPCNameLocale);
            this.tpNPC.Controls.Add(this.txtNPCName);
            this.tpNPC.Controls.Add(this.label101);
            this.tpNPC.Controls.Add(this.crsNPC);
            this.tpNPC.Location = (new global::System.Drawing.Point(4, 24));
            this.tpNPC.Name = ("tpNPC");
            this.tpNPC.Size = (new global::System.Drawing.Size(740, 356));
            this.tpNPC.TabIndex = (5);
            this.tpNPC.Text = ("NPC");
            this.tpNPC.UseVisualStyleBackColor = (true);
            // 
            // maeNPCOnInteracted
            // 
            this.maeNPCOnInteracted.ActionDescription = ("Someone can interact with\r\nthem with the following:");
            this.maeNPCOnInteracted.Actions = ((global::System.Collections.Generic.List<global::RogueCustomsGameEngine.Utils.JsonImports.ActionWithEffectsInfo>)(resources.GetObject("maeNPCOnInteracted.Actions")));
            this.maeNPCOnInteracted.ActionTypeText = ("Interact");
            this.maeNPCOnInteracted.AlteredStatuses = (null);
            this.maeNPCOnInteracted.ClassId = (null);
            this.maeNPCOnInteracted.Dungeon = (null);
            this.maeNPCOnInteracted.EffectParamData = (null);
            this.maeNPCOnInteracted.Location = (new global::System.Drawing.Point(13, 726));
            this.maeNPCOnInteracted.Name = ("maeNPCOnInteracted");
            this.maeNPCOnInteracted.PlaceholderActionName = (null);
            this.maeNPCOnInteracted.RequiresActionName = (true);
            this.maeNPCOnInteracted.RequiresCondition = (true);
            this.maeNPCOnInteracted.RequiresDescription = (true);
            this.maeNPCOnInteracted.Size = (new global::System.Drawing.Size(368, 94));
            this.maeNPCOnInteracted.SourceDescription = ("Whoever is targeting them");
            this.maeNPCOnInteracted.TabIndex = (214);
            this.maeNPCOnInteracted.TargetDescription = ("The NPC");
            this.maeNPCOnInteracted.ThisDescription = ("The NPC");
            this.maeNPCOnInteracted.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.MayNotEndTurn);
            this.maeNPCOnInteracted.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.FullConditions);
            // 
            // saeNPCOnSpawn
            // 
            this.saeNPCOnSpawn.Action = (null);
            this.saeNPCOnSpawn.ActionDescription = ("When spawning...                ");
            this.saeNPCOnSpawn.ActionTypeText = ("Turn Start");
            this.saeNPCOnSpawn.AlteredStatuses = (null);
            this.saeNPCOnSpawn.AutoSize = (true);
            this.saeNPCOnSpawn.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeNPCOnSpawn.ClassId = (null);
            this.saeNPCOnSpawn.Dungeon = (null);
            this.saeNPCOnSpawn.EffectParamData = (null);
            this.saeNPCOnSpawn.Location = (new global::System.Drawing.Point(13, 550));
            this.saeNPCOnSpawn.Name = ("saeNPCOnSpawn");
            this.saeNPCOnSpawn.PlaceholderActionName = ("TurnStart");
            this.saeNPCOnSpawn.RequiresActionName = (false);
            this.saeNPCOnSpawn.RequiresCondition = (true);
            this.saeNPCOnSpawn.RequiresDescription = (false);
            this.saeNPCOnSpawn.Size = (new global::System.Drawing.Size(283, 32));
            this.saeNPCOnSpawn.SourceDescription = ("The NPC (won't become visible)");
            this.saeNPCOnSpawn.TabIndex = (213);
            this.saeNPCOnSpawn.TargetDescription = ("The NPC (won't become visible)");
            this.saeNPCOnSpawn.ThisDescription = ("The NPC (won't become visible)");
            this.saeNPCOnSpawn.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeNPCOnSpawn.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // ssNPC
            // 
            this.ssNPC.AttackPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.AutoSize = (true);
            this.ssNPC.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.ssNPC.BaseAccuracy = (100);
            this.ssNPC.BaseAttack = (0);
            this.ssNPC.BaseDefense = (0);
            this.ssNPC.BaseEvasion = (0);
            this.ssNPC.BaseHP = (1);
            this.ssNPC.BaseHPRegeneration = (new global::System.Decimal(new global::System.Int32[] { 1, 0, 0, 0 }));
            this.ssNPC.BaseMovement = (1);
            this.ssNPC.BaseMP = (0);
            this.ssNPC.BaseMPRegeneration = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.BaseSightRangeDisplayNames = ((global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)(resources.GetObject("ssNPC.BaseSightRangeDisplayNames")));
            this.ssNPC.CanGainExperience = (false);
            this.ssNPC.DefensePerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.ExperienceToLevelUpFormula = ("");
            this.ssNPC.HPPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.HPRegenerationPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.Location = (new global::System.Drawing.Point(385, 94));
            this.ssNPC.MaxLevel = (1);
            this.ssNPC.MovementPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.MPPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.MPRegenerationPerLevelUp = (new global::System.Decimal(new global::System.Int32[] { 0, 0, 0, 0 }));
            this.ssNPC.Name = ("ssNPC");
            this.ssNPC.Size = (new global::System.Drawing.Size(331, 687));
            this.ssNPC.TabIndex = (212);
            this.ssNPC.UsesMP = (false);
            // 
            // sisNPCStartingInventory
            // 
            this.sisNPCStartingInventory.Inventory = ((global::System.Collections.Generic.List<global::System.String>)(resources.GetObject("sisNPCStartingInventory.Inventory")));
            this.sisNPCStartingInventory.InventorySize = (0);
            this.sisNPCStartingInventory.Location = (new global::System.Drawing.Point(13, 432));
            this.sisNPCStartingInventory.Name = ("sisNPCStartingInventory");
            this.sisNPCStartingInventory.SelectableItems = (null);
            this.sisNPCStartingInventory.Size = (new global::System.Drawing.Size(293, 79));
            this.sisNPCStartingInventory.TabIndex = (129);
            // 
            // saeNPCOnDeath
            // 
            this.saeNPCOnDeath.Action = (null);
            this.saeNPCOnDeath.ActionDescription = ("When they die...                   ");
            this.saeNPCOnDeath.ActionTypeText = ("On Death");
            this.saeNPCOnDeath.AlteredStatuses = (null);
            this.saeNPCOnDeath.AutoSize = (true);
            this.saeNPCOnDeath.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeNPCOnDeath.ClassId = (null);
            this.saeNPCOnDeath.Dungeon = (null);
            this.saeNPCOnDeath.EffectParamData = (null);
            this.saeNPCOnDeath.Location = (new global::System.Drawing.Point(13, 866));
            this.saeNPCOnDeath.Name = ("saeNPCOnDeath");
            this.saeNPCOnDeath.PlaceholderActionName = ("Death");
            this.saeNPCOnDeath.RequiresActionName = (false);
            this.saeNPCOnDeath.RequiresCondition = (false);
            this.saeNPCOnDeath.RequiresDescription = (false);
            this.saeNPCOnDeath.Size = (new global::System.Drawing.Size(283, 32));
            this.saeNPCOnDeath.SourceDescription = ("The NPC");
            this.saeNPCOnDeath.TabIndex = (211);
            this.saeNPCOnDeath.TargetDescription = ("Whoever killed them (if any)");
            this.saeNPCOnDeath.ThisDescription = ("The NPC");
            this.saeNPCOnDeath.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeNPCOnDeath.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeNPCOnAttacked
            // 
            this.saeNPCOnAttacked.Action = (null);
            this.saeNPCOnAttacked.ActionDescription = ("When they get attacked...  ");
            this.saeNPCOnAttacked.ActionTypeText = ("Attacked");
            this.saeNPCOnAttacked.AlteredStatuses = (null);
            this.saeNPCOnAttacked.AutoSize = (true);
            this.saeNPCOnAttacked.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeNPCOnAttacked.ClassId = (null);
            this.saeNPCOnAttacked.Dungeon = (null);
            this.saeNPCOnAttacked.EffectParamData = (null);
            this.saeNPCOnAttacked.Location = (new global::System.Drawing.Point(13, 826));
            this.saeNPCOnAttacked.Name = ("saeNPCOnAttacked");
            this.saeNPCOnAttacked.PlaceholderActionName = ("Interacted");
            this.saeNPCOnAttacked.RequiresActionName = (false);
            this.saeNPCOnAttacked.RequiresCondition = (false);
            this.saeNPCOnAttacked.RequiresDescription = (false);
            this.saeNPCOnAttacked.Size = (new global::System.Drawing.Size(281, 32));
            this.saeNPCOnAttacked.SourceDescription = ("The NPC");
            this.saeNPCOnAttacked.TabIndex = (210);
            this.saeNPCOnAttacked.TargetDescription = ("Whoever interacted with them");
            this.saeNPCOnAttacked.ThisDescription = ("The NPC");
            this.saeNPCOnAttacked.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeNPCOnAttacked.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeNPCOnTurnStart
            // 
            this.saeNPCOnTurnStart.Action = (null);
            this.saeNPCOnTurnStart.ActionDescription = ("When the next turn starts...");
            this.saeNPCOnTurnStart.ActionTypeText = ("Turn Start");
            this.saeNPCOnTurnStart.AlteredStatuses = (null);
            this.saeNPCOnTurnStart.AutoSize = (true);
            this.saeNPCOnTurnStart.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeNPCOnTurnStart.ClassId = (null);
            this.saeNPCOnTurnStart.Dungeon = (null);
            this.saeNPCOnTurnStart.EffectParamData = (null);
            this.saeNPCOnTurnStart.Location = (new global::System.Drawing.Point(13, 588));
            this.saeNPCOnTurnStart.Name = ("saeNPCOnTurnStart");
            this.saeNPCOnTurnStart.PlaceholderActionName = ("TurnStart");
            this.saeNPCOnTurnStart.RequiresActionName = (false);
            this.saeNPCOnTurnStart.RequiresCondition = (false);
            this.saeNPCOnTurnStart.RequiresDescription = (false);
            this.saeNPCOnTurnStart.Size = (new global::System.Drawing.Size(283, 32));
            this.saeNPCOnTurnStart.SourceDescription = ("The NPC");
            this.saeNPCOnTurnStart.TabIndex = (209);
            this.saeNPCOnTurnStart.TargetDescription = ("The NPC");
            this.saeNPCOnTurnStart.ThisDescription = ("The NPC");
            this.saeNPCOnTurnStart.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeNPCOnTurnStart.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // maeNPCOnAttack
            // 
            this.maeNPCOnAttack.ActionDescription = ("Can do the following to\r\ninteract with someone:");
            this.maeNPCOnAttack.Actions = ((global::System.Collections.Generic.List<global::RogueCustomsGameEngine.Utils.JsonImports.ActionWithEffectsInfo>)(resources.GetObject("maeNPCOnAttack.Actions")));
            this.maeNPCOnAttack.ActionTypeText = ("Interact");
            this.maeNPCOnAttack.AlteredStatuses = (null);
            this.maeNPCOnAttack.ClassId = (null);
            this.maeNPCOnAttack.Dungeon = (null);
            this.maeNPCOnAttack.EffectParamData = (null);
            this.maeNPCOnAttack.Location = (new global::System.Drawing.Point(13, 626));
            this.maeNPCOnAttack.Name = ("maeNPCOnAttack");
            this.maeNPCOnAttack.PlaceholderActionName = (null);
            this.maeNPCOnAttack.RequiresActionName = (true);
            this.maeNPCOnAttack.RequiresCondition = (true);
            this.maeNPCOnAttack.RequiresDescription = (false);
            this.maeNPCOnAttack.Size = (new global::System.Drawing.Size(368, 94));
            this.maeNPCOnAttack.SourceDescription = ("The NPC");
            this.maeNPCOnAttack.TabIndex = (208);
            this.maeNPCOnAttack.TargetDescription = ("Whoever they are targeting");
            this.maeNPCOnAttack.ThisDescription = ("The NPC");
            this.maeNPCOnAttack.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.MustEndTurn);
            this.maeNPCOnAttack.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.FullConditions);
            // 
            // nudNPCOddsToTargetSelf
            // 
            this.nudNPCOddsToTargetSelf.Location = (new global::System.Drawing.Point(287, 903));
            this.nudNPCOddsToTargetSelf.Name = ("nudNPCOddsToTargetSelf");
            this.nudNPCOddsToTargetSelf.Size = (new global::System.Drawing.Size(41, 23));
            this.nudNPCOddsToTargetSelf.TabIndex = (195);
            this.nudNPCOddsToTargetSelf.ValueChanged += (this.nudNPCOddsToTargetSelf_ValueChanged);
            // 
            // label104
            // 
            this.label104.AutoSize = (true);
            this.label104.Location = (new global::System.Drawing.Point(13, 905));
            this.label104.Name = ("label104");
            this.label104.Size = (new global::System.Drawing.Size(334, 15));
            this.label104.TabIndex = (194);
            this.label104.Text = ("Odds for NPC to target themselves with an Action:                 %");
            // 
            // txtNPCExperiencePayout
            // 
            this.txtNPCExperiencePayout.Location = (new global::System.Drawing.Point(121, 297));
            this.txtNPCExperiencePayout.Name = ("txtNPCExperiencePayout");
            this.txtNPCExperiencePayout.Size = (new global::System.Drawing.Size(242, 23));
            this.txtNPCExperiencePayout.TabIndex = (192);
            this.txtNPCExperiencePayout.Enter += (this.txtNPCExperiencePayout_Enter);
            this.txtNPCExperiencePayout.Leave += (this.txtNPCExperiencePayout_Leave);
            // 
            // label103
            // 
            this.label103.AutoSize = (true);
            this.label103.Location = (new global::System.Drawing.Point(13, 300));
            this.label103.Name = ("label103");
            this.label103.Size = (new global::System.Drawing.Size(104, 15));
            this.label103.TabIndex = (191);
            this.label103.Text = ("Experience Payout");
            // 
            // chkNPCKnowsAllCharacterPositions
            // 
            this.chkNPCKnowsAllCharacterPositions.AutoSize = (true);
            this.chkNPCKnowsAllCharacterPositions.Location = (new global::System.Drawing.Point(13, 268));
            this.chkNPCKnowsAllCharacterPositions.Name = ("chkNPCKnowsAllCharacterPositions");
            this.chkNPCKnowsAllCharacterPositions.Size = (new global::System.Drawing.Size(361, 19));
            this.chkNPCKnowsAllCharacterPositions.TabIndex = (190);
            this.chkNPCKnowsAllCharacterPositions.Text = ("Knows the position of all living characters (even when not seen)");
            this.chkNPCKnowsAllCharacterPositions.UseVisualStyleBackColor = (true);
            this.chkNPCKnowsAllCharacterPositions.CheckedChanged += (this.chkNPCKnowsAllCharacterPositions_CheckedChanged);
            // 
            // label67
            // 
            this.label67.AutoSize = (true);
            this.label67.Font = (new global::System.Drawing.Font("Segoe UI", 12F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label67.Location = (new global::System.Drawing.Point(141, 514));
            this.label67.Name = ("label67");
            this.label67.Size = (new global::System.Drawing.Size(67, 21));
            this.label67.TabIndex = (182);
            this.label67.Text = ("Actions");
            // 
            // cmbNPCStartingArmor
            // 
            this.cmbNPCStartingArmor.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbNPCStartingArmor.FormattingEnabled = (true);
            this.cmbNPCStartingArmor.Location = (new global::System.Drawing.Point(146, 362));
            this.cmbNPCStartingArmor.Name = ("cmbNPCStartingArmor");
            this.cmbNPCStartingArmor.Size = (new global::System.Drawing.Size(158, 23));
            this.cmbNPCStartingArmor.TabIndex = (175);
            this.cmbNPCStartingArmor.SelectedIndexChanged += (this.cmbNPCStartingArmor_SelectedIndexChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = (true);
            this.label70.Location = (new global::System.Drawing.Point(13, 365));
            this.label70.Name = ("label70");
            this.label70.Size = (new global::System.Drawing.Size(131, 15));
            this.label70.TabIndex = (174);
            this.label70.Text = ("When unarmored, wear");
            // 
            // cmbNPCStartingWeapon
            // 
            this.cmbNPCStartingWeapon.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbNPCStartingWeapon.FormattingEnabled = (true);
            this.cmbNPCStartingWeapon.Location = (new global::System.Drawing.Point(139, 331));
            this.cmbNPCStartingWeapon.Name = ("cmbNPCStartingWeapon");
            this.cmbNPCStartingWeapon.Size = (new global::System.Drawing.Size(165, 23));
            this.cmbNPCStartingWeapon.TabIndex = (173);
            this.cmbNPCStartingWeapon.SelectedIndexChanged += (this.cmbNPCStartingWeapon_SelectedIndexChanged);
            // 
            // label71
            // 
            this.label71.AutoSize = (true);
            this.label71.Location = (new global::System.Drawing.Point(13, 334));
            this.label71.Name = ("label71");
            this.label71.Size = (new global::System.Drawing.Size(123, 15));
            this.label71.TabIndex = (172);
            this.label71.Text = ("When unarmed, wield");
            // 
            // label73
            // 
            this.label73.AutoSize = (true);
            this.label73.Location = (new global::System.Drawing.Point(172, 395));
            this.label73.Name = ("label73");
            this.label73.Size = (new global::System.Drawing.Size(36, 15));
            this.label73.TabIndex = (166);
            this.label73.Text = ("items");
            // 
            // nudNPCInventorySize
            // 
            this.nudNPCInventorySize.Location = (new global::System.Drawing.Point(121, 390));
            this.nudNPCInventorySize.Maximum = (new global::System.Decimal(new global::System.Int32[] { 999, 0, 0, 0 }));
            this.nudNPCInventorySize.Name = ("nudNPCInventorySize");
            this.nudNPCInventorySize.Size = (new global::System.Drawing.Size(45, 23));
            this.nudNPCInventorySize.TabIndex = (165);
            this.nudNPCInventorySize.ValueChanged += (this.nudNPCInventorySize_ValueChanged);
            // 
            // label74
            // 
            this.label74.AutoSize = (true);
            this.label74.Location = (new global::System.Drawing.Point(13, 393));
            this.label74.Name = ("label74");
            this.label74.Size = (new global::System.Drawing.Size(109, 15));
            this.label74.TabIndex = (164);
            this.label74.Text = ("Inventory Capacity:");
            // 
            // label98
            // 
            this.label98.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label98.Location = (new global::System.Drawing.Point(370, 19));
            this.label98.Name = ("label98");
            this.label98.Size = (new global::System.Drawing.Size(131, 52));
            this.label98.TabIndex = (122);
            this.label98.Text = ("Appearance");
            this.label98.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // chkNPCStartsVisible
            // 
            this.chkNPCStartsVisible.AutoSize = (true);
            this.chkNPCStartsVisible.Location = (new global::System.Drawing.Point(13, 240));
            this.chkNPCStartsVisible.Name = ("chkNPCStartsVisible");
            this.chkNPCStartsVisible.Size = (new global::System.Drawing.Size(102, 19));
            this.chkNPCStartsVisible.TabIndex = (121);
            this.chkNPCStartsVisible.Text = ("Spawns visible");
            this.chkNPCStartsVisible.UseVisualStyleBackColor = (true);
            this.chkNPCStartsVisible.CheckedChanged += (this.chkNPCStartsVisible_CheckedChanged);
            // 
            // cmbNPCFaction
            // 
            this.cmbNPCFaction.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbNPCFaction.FormattingEnabled = (true);
            this.cmbNPCFaction.Location = (new global::System.Drawing.Point(65, 209));
            this.cmbNPCFaction.Name = ("cmbNPCFaction");
            this.cmbNPCFaction.Size = (new global::System.Drawing.Size(146, 23));
            this.cmbNPCFaction.TabIndex = (120);
            this.cmbNPCFaction.SelectedIndexChanged += (this.cmbNPCFaction_SelectedIndexChanged);
            // 
            // label99
            // 
            this.label99.AutoSize = (true);
            this.label99.Location = (new global::System.Drawing.Point(13, 212));
            this.label99.Name = ("label99");
            this.label99.Size = (new global::System.Drawing.Size(46, 15));
            this.label99.TabIndex = (119);
            this.label99.Text = ("Faction");
            // 
            // fklblNPCDescriptionLocale
            // 
            this.fklblNPCDescriptionLocale.Enabled = (false);
            this.fklblNPCDescriptionLocale.FlatAppearance.BorderSize = (0);
            this.fklblNPCDescriptionLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblNPCDescriptionLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblNPCDescriptionLocale.Image")));
            this.fklblNPCDescriptionLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblNPCDescriptionLocale.Location = (new global::System.Drawing.Point(13, 153));
            this.fklblNPCDescriptionLocale.Name = ("fklblNPCDescriptionLocale");
            this.fklblNPCDescriptionLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblNPCDescriptionLocale.TabIndex = (117);
            this.fklblNPCDescriptionLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblNPCDescriptionLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblNPCDescriptionLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblNPCDescriptionLocale.UseVisualStyleBackColor = (true);
            this.fklblNPCDescriptionLocale.Visible = (false);
            // 
            // txtNPCDescription
            // 
            this.txtNPCDescription.Location = (new global::System.Drawing.Point(13, 124));
            this.txtNPCDescription.Name = ("txtNPCDescription");
            this.txtNPCDescription.Size = (new global::System.Drawing.Size(350, 23));
            this.txtNPCDescription.TabIndex = (116);
            this.txtNPCDescription.TextChanged += (this.txtNPCDescription_TextChanged);
            // 
            // label100
            // 
            this.label100.AutoSize = (true);
            this.label100.Location = (new global::System.Drawing.Point(13, 106));
            this.label100.Name = ("label100");
            this.label100.Size = (new global::System.Drawing.Size(67, 15));
            this.label100.TabIndex = (115);
            this.label100.Text = ("Description");
            // 
            // fklblNPCNameLocale
            // 
            this.fklblNPCNameLocale.Enabled = (false);
            this.fklblNPCNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblNPCNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblNPCNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblNPCNameLocale.Image")));
            this.fklblNPCNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblNPCNameLocale.Location = (new global::System.Drawing.Point(13, 55));
            this.fklblNPCNameLocale.Name = ("fklblNPCNameLocale");
            this.fklblNPCNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblNPCNameLocale.TabIndex = (114);
            this.fklblNPCNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblNPCNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblNPCNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblNPCNameLocale.UseVisualStyleBackColor = (true);
            this.fklblNPCNameLocale.Visible = (false);
            // 
            // txtNPCName
            // 
            this.txtNPCName.Location = (new global::System.Drawing.Point(13, 26));
            this.txtNPCName.Name = ("txtNPCName");
            this.txtNPCName.Size = (new global::System.Drawing.Size(350, 23));
            this.txtNPCName.TabIndex = (113);
            this.txtNPCName.TextChanged += (this.txtNPCName_TextChanged);
            // 
            // label101
            // 
            this.label101.AutoSize = (true);
            this.label101.Location = (new global::System.Drawing.Point(13, 8));
            this.label101.Name = ("label101");
            this.label101.Size = (new global::System.Drawing.Size(80, 15));
            this.label101.TabIndex = (112);
            this.label101.Text = ("Default Name");
            // 
            // crsNPC
            // 
            this.crsNPC.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsNPC.BackgroundColor")));
            this.crsNPC.Character = ('\0');
            this.crsNPC.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsNPC.ForegroundColor")));
            this.crsNPC.Location = (new global::System.Drawing.Point(504, 8));
            this.crsNPC.Name = ("crsNPC");
            this.crsNPC.Size = (new global::System.Drawing.Size(211, 83));
            this.crsNPC.TabIndex = (207);
            this.crsNPC.PropertyChanged += (this.crsNPC_PropertyChanged);
            // 
            // tpItem
            // 
            this.tpItem.Controls.Add(this.saeItemOnTurnStart);
            this.tpItem.Controls.Add(this.saeItemOnAttacked);
            this.tpItem.Controls.Add(this.maeItemOnAttack);
            this.tpItem.Controls.Add(this.saeItemOnUse);
            this.tpItem.Controls.Add(this.saeItemOnStepped);
            this.tpItem.Controls.Add(this.txtItemPower);
            this.tpItem.Controls.Add(this.label108);
            this.tpItem.Controls.Add(this.chkItemCanBePickedUp);
            this.tpItem.Controls.Add(this.chkItemStartsVisible);
            this.tpItem.Controls.Add(this.cmbItemType);
            this.tpItem.Controls.Add(this.label107);
            this.tpItem.Controls.Add(this.label102);
            this.tpItem.Controls.Add(this.fklblItemDescriptionLocale);
            this.tpItem.Controls.Add(this.txtItemDescription);
            this.tpItem.Controls.Add(this.label105);
            this.tpItem.Controls.Add(this.fklblItemNameLocale);
            this.tpItem.Controls.Add(this.txtItemName);
            this.tpItem.Controls.Add(this.label106);
            this.tpItem.Controls.Add(this.crsItem);
            this.tpItem.Location = (new global::System.Drawing.Point(4, 24));
            this.tpItem.Name = ("tpItem");
            this.tpItem.Size = (new global::System.Drawing.Size(740, 356));
            this.tpItem.TabIndex = (6);
            this.tpItem.Text = ("Item");
            this.tpItem.UseVisualStyleBackColor = (true);
            // 
            // saeItemOnTurnStart
            // 
            this.saeItemOnTurnStart.Action = (null);
            this.saeItemOnTurnStart.ActionDescription = ("When the Item's owner starts a new turn...");
            this.saeItemOnTurnStart.ActionTypeText = ("On Death");
            this.saeItemOnTurnStart.AlteredStatuses = (null);
            this.saeItemOnTurnStart.AutoSize = (true);
            this.saeItemOnTurnStart.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeItemOnTurnStart.ClassId = (null);
            this.saeItemOnTurnStart.Dungeon = (null);
            this.saeItemOnTurnStart.EffectParamData = (null);
            this.saeItemOnTurnStart.Location = (new global::System.Drawing.Point(367, 310));
            this.saeItemOnTurnStart.Name = ("saeItemOnTurnStart");
            this.saeItemOnTurnStart.PlaceholderActionName = ("Death");
            this.saeItemOnTurnStart.RequiresActionName = (false);
            this.saeItemOnTurnStart.RequiresCondition = (false);
            this.saeItemOnTurnStart.RequiresDescription = (false);
            this.saeItemOnTurnStart.Size = (new global::System.Drawing.Size(362, 32));
            this.saeItemOnTurnStart.SourceDescription = ("Whoever is equipping This");
            this.saeItemOnTurnStart.TabIndex = (225);
            this.saeItemOnTurnStart.TargetDescription = ("Whoever is equipping This");
            this.saeItemOnTurnStart.ThisDescription = ("The item");
            this.saeItemOnTurnStart.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeItemOnTurnStart.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeItemOnAttacked
            // 
            this.saeItemOnAttacked.Action = (null);
            this.saeItemOnAttacked.ActionDescription = ("When the Item's owner gets interacted...   ");
            this.saeItemOnAttacked.ActionTypeText = ("Interacted");
            this.saeItemOnAttacked.AlteredStatuses = (null);
            this.saeItemOnAttacked.AutoSize = (true);
            this.saeItemOnAttacked.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeItemOnAttacked.ClassId = (null);
            this.saeItemOnAttacked.Dungeon = (null);
            this.saeItemOnAttacked.EffectParamData = (null);
            this.saeItemOnAttacked.Location = (new global::System.Drawing.Point(367, 272));
            this.saeItemOnAttacked.Name = ("saeItemOnAttacked");
            this.saeItemOnAttacked.PlaceholderActionName = ("Interacted");
            this.saeItemOnAttacked.RequiresActionName = (false);
            this.saeItemOnAttacked.RequiresCondition = (false);
            this.saeItemOnAttacked.RequiresDescription = (false);
            this.saeItemOnAttacked.Size = (new global::System.Drawing.Size(362, 32));
            this.saeItemOnAttacked.SourceDescription = ("Whoever is equipping it");
            this.saeItemOnAttacked.TabIndex = (224);
            this.saeItemOnAttacked.TargetDescription = ("The owner's interactor");
            this.saeItemOnAttacked.ThisDescription = ("The item");
            this.saeItemOnAttacked.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeItemOnAttacked.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // maeItemOnAttack
            // 
            this.maeItemOnAttack.ActionDescription = ("The Item's owner can do the following to interact with someone:");
            this.maeItemOnAttack.Actions = ((global::System.Collections.Generic.List<global::RogueCustomsGameEngine.Utils.JsonImports.ActionWithEffectsInfo>)(resources.GetObject("maeItemOnAttack.Actions")));
            this.maeItemOnAttack.ActionTypeText = ("Interact");
            this.maeItemOnAttack.AlteredStatuses = (null);
            this.maeItemOnAttack.ClassId = (null);
            this.maeItemOnAttack.Dungeon = (null);
            this.maeItemOnAttack.EffectParamData = (null);
            this.maeItemOnAttack.Location = (new global::System.Drawing.Point(367, 172));
            this.maeItemOnAttack.Name = ("maeItemOnAttack");
            this.maeItemOnAttack.PlaceholderActionName = (null);
            this.maeItemOnAttack.RequiresActionName = (true);
            this.maeItemOnAttack.RequiresCondition = (true);
            this.maeItemOnAttack.RequiresDescription = (true);
            this.maeItemOnAttack.Size = (new global::System.Drawing.Size(368, 94));
            this.maeItemOnAttack.SourceDescription = (null);
            this.maeItemOnAttack.TabIndex = (223);
            this.maeItemOnAttack.TargetDescription = ("Whoever is being targeted");
            this.maeItemOnAttack.ThisDescription = ("The item");
            this.maeItemOnAttack.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.MustEndTurn);
            this.maeItemOnAttack.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.FullConditions);
            // 
            // saeItemOnUse
            // 
            this.saeItemOnUse.Action = (null);
            this.saeItemOnUse.ActionDescription = ("When someone uses it on     \r\nthemselves...");
            this.saeItemOnUse.ActionTypeText = ("Item Use");
            this.saeItemOnUse.AlteredStatuses = (null);
            this.saeItemOnUse.AutoSize = (true);
            this.saeItemOnUse.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeItemOnUse.ClassId = (null);
            this.saeItemOnUse.Dungeon = (null);
            this.saeItemOnUse.EffectParamData = (null);
            this.saeItemOnUse.Location = (new global::System.Drawing.Point(13, 316));
            this.saeItemOnUse.Name = ("saeItemOnUse");
            this.saeItemOnUse.PlaceholderActionName = ("ItemUse");
            this.saeItemOnUse.RequiresActionName = (false);
            this.saeItemOnUse.RequiresCondition = (true);
            this.saeItemOnUse.RequiresDescription = (false);
            this.saeItemOnUse.Size = (new global::System.Drawing.Size(292, 32));
            this.saeItemOnUse.SourceDescription = ("The item");
            this.saeItemOnUse.TabIndex = (222);
            this.saeItemOnUse.TargetDescription = ("Whoever is using it");
            this.saeItemOnUse.ThisDescription = ("The item");
            this.saeItemOnUse.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.MustEndTurn);
            this.saeItemOnUse.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeItemOnStepped
            // 
            this.saeItemOnStepped.Action = (null);
            this.saeItemOnStepped.ActionDescription = ("When someone steps on it...");
            this.saeItemOnStepped.ActionTypeText = ("Stepped");
            this.saeItemOnStepped.AlteredStatuses = (null);
            this.saeItemOnStepped.AutoSize = (true);
            this.saeItemOnStepped.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeItemOnStepped.ClassId = (null);
            this.saeItemOnStepped.Dungeon = (null);
            this.saeItemOnStepped.EffectParamData = (null);
            this.saeItemOnStepped.Location = (new global::System.Drawing.Point(15, 278));
            this.saeItemOnStepped.Name = ("saeItemOnStepped");
            this.saeItemOnStepped.PlaceholderActionName = ("Stepped");
            this.saeItemOnStepped.RequiresActionName = (false);
            this.saeItemOnStepped.RequiresCondition = (false);
            this.saeItemOnStepped.RequiresDescription = (false);
            this.saeItemOnStepped.Size = (new global::System.Drawing.Size(290, 32));
            this.saeItemOnStepped.SourceDescription = ("The item");
            this.saeItemOnStepped.TabIndex = (221);
            this.saeItemOnStepped.TargetDescription = ("Whoever stepped on it");
            this.saeItemOnStepped.ThisDescription = ("The item");
            this.saeItemOnStepped.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeItemOnStepped.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // txtItemPower
            // 
            this.txtItemPower.Location = (new global::System.Drawing.Point(86, 243));
            this.txtItemPower.Name = ("txtItemPower");
            this.txtItemPower.Size = (new global::System.Drawing.Size(150, 23));
            this.txtItemPower.TabIndex = (206);
            this.txtItemPower.Enter += (this.txtItemPower_Enter);
            this.txtItemPower.Leave += (this.txtItemPower_Leave);
            // 
            // label108
            // 
            this.label108.AutoSize = (true);
            this.label108.Location = (new global::System.Drawing.Point(13, 249));
            this.label108.Name = ("label108");
            this.label108.Size = (new global::System.Drawing.Size(67, 15));
            this.label108.TabIndex = (205);
            this.label108.Text = ("Item Power");
            // 
            // chkItemCanBePickedUp
            // 
            this.chkItemCanBePickedUp.AutoSize = (true);
            this.chkItemCanBePickedUp.Location = (new global::System.Drawing.Point(242, 245));
            this.chkItemCanBePickedUp.Name = ("chkItemCanBePickedUp");
            this.chkItemCanBePickedUp.Size = (new global::System.Drawing.Size(118, 19));
            this.chkItemCanBePickedUp.TabIndex = (204);
            this.chkItemCanBePickedUp.Text = ("Can be picked up");
            this.chkItemCanBePickedUp.UseVisualStyleBackColor = (true);
            this.chkItemCanBePickedUp.CheckedChanged += (this.chkItemCanBePickedUp_CheckedChanged);
            // 
            // chkItemStartsVisible
            // 
            this.chkItemStartsVisible.AutoSize = (true);
            this.chkItemStartsVisible.Location = (new global::System.Drawing.Point(242, 211));
            this.chkItemStartsVisible.Name = ("chkItemStartsVisible");
            this.chkItemStartsVisible.Size = (new global::System.Drawing.Size(102, 19));
            this.chkItemStartsVisible.TabIndex = (203);
            this.chkItemStartsVisible.Text = ("Spawns visible");
            this.chkItemStartsVisible.UseVisualStyleBackColor = (true);
            this.chkItemStartsVisible.CheckedChanged += (this.chkItemStartsVisible_CheckedChanged);
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cmbItemType.FormattingEnabled = (true);
            this.cmbItemType.Location = (new global::System.Drawing.Point(77, 209));
            this.cmbItemType.Name = ("cmbItemType");
            this.cmbItemType.Size = (new global::System.Drawing.Size(159, 23));
            this.cmbItemType.TabIndex = (202);
            this.cmbItemType.SelectedIndexChanged += (this.cmbItemType_SelectedIndexChanged);
            // 
            // label107
            // 
            this.label107.AutoSize = (true);
            this.label107.Location = (new global::System.Drawing.Point(13, 212));
            this.label107.Name = ("label107");
            this.label107.Size = (new global::System.Drawing.Size(58, 15));
            this.label107.TabIndex = (201);
            this.label107.Text = ("Item Type");
            // 
            // label102
            // 
            this.label102.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label102.Location = (new global::System.Drawing.Point(390, 20));
            this.label102.Name = ("label102");
            this.label102.Size = (new global::System.Drawing.Size(131, 52));
            this.label102.TabIndex = (196);
            this.label102.Text = ("Appearance");
            this.label102.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // fklblItemDescriptionLocale
            // 
            this.fklblItemDescriptionLocale.Enabled = (false);
            this.fklblItemDescriptionLocale.FlatAppearance.BorderSize = (0);
            this.fklblItemDescriptionLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblItemDescriptionLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblItemDescriptionLocale.Image")));
            this.fklblItemDescriptionLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblItemDescriptionLocale.Location = (new global::System.Drawing.Point(13, 153));
            this.fklblItemDescriptionLocale.Name = ("fklblItemDescriptionLocale");
            this.fklblItemDescriptionLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblItemDescriptionLocale.TabIndex = (195);
            this.fklblItemDescriptionLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblItemDescriptionLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblItemDescriptionLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblItemDescriptionLocale.UseVisualStyleBackColor = (true);
            this.fklblItemDescriptionLocale.Visible = (false);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = (new global::System.Drawing.Point(13, 124));
            this.txtItemDescription.Name = ("txtItemDescription");
            this.txtItemDescription.Size = (new global::System.Drawing.Size(350, 23));
            this.txtItemDescription.TabIndex = (194);
            this.txtItemDescription.TextChanged += (this.txtItemDescription_TextChanged);
            // 
            // label105
            // 
            this.label105.AutoSize = (true);
            this.label105.Location = (new global::System.Drawing.Point(13, 106));
            this.label105.Name = ("label105");
            this.label105.Size = (new global::System.Drawing.Size(67, 15));
            this.label105.TabIndex = (193);
            this.label105.Text = ("Description");
            // 
            // fklblItemNameLocale
            // 
            this.fklblItemNameLocale.Enabled = (false);
            this.fklblItemNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblItemNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblItemNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblItemNameLocale.Image")));
            this.fklblItemNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblItemNameLocale.Location = (new global::System.Drawing.Point(13, 55));
            this.fklblItemNameLocale.Name = ("fklblItemNameLocale");
            this.fklblItemNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblItemNameLocale.TabIndex = (192);
            this.fklblItemNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblItemNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblItemNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblItemNameLocale.UseVisualStyleBackColor = (true);
            this.fklblItemNameLocale.Visible = (false);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = (new global::System.Drawing.Point(13, 26));
            this.txtItemName.Name = ("txtItemName");
            this.txtItemName.Size = (new global::System.Drawing.Size(350, 23));
            this.txtItemName.TabIndex = (191);
            this.txtItemName.TextChanged += (this.txtItemName_TextChanged);
            // 
            // label106
            // 
            this.label106.AutoSize = (true);
            this.label106.Location = (new global::System.Drawing.Point(13, 8));
            this.label106.Name = ("label106");
            this.label106.Size = (new global::System.Drawing.Size(80, 15));
            this.label106.TabIndex = (190);
            this.label106.Text = ("Default Name");
            // 
            // crsItem
            // 
            this.crsItem.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsItem.BackgroundColor")));
            this.crsItem.Character = ('\0');
            this.crsItem.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsItem.ForegroundColor")));
            this.crsItem.Location = (new global::System.Drawing.Point(524, 9));
            this.crsItem.Name = ("crsItem");
            this.crsItem.Size = (new global::System.Drawing.Size(211, 83));
            this.crsItem.TabIndex = (220);
            this.crsItem.PropertyChanged += (this.crsItem_PropertyChanged);
            // 
            // tpTrap
            // 
            this.tpTrap.Controls.Add(this.saeTrapOnStepped);
            this.tpTrap.Controls.Add(this.txtTrapPower);
            this.tpTrap.Controls.Add(this.label113);
            this.tpTrap.Controls.Add(this.chkTrapStartsVisible);
            this.tpTrap.Controls.Add(this.label116);
            this.tpTrap.Controls.Add(this.fklblTrapDescriptionLocale);
            this.tpTrap.Controls.Add(this.txtTrapDescription);
            this.tpTrap.Controls.Add(this.label117);
            this.tpTrap.Controls.Add(this.fklblTrapNameLocale);
            this.tpTrap.Controls.Add(this.txtTrapName);
            this.tpTrap.Controls.Add(this.label118);
            this.tpTrap.Controls.Add(this.crsTrap);
            this.tpTrap.Location = (new global::System.Drawing.Point(4, 24));
            this.tpTrap.Name = ("tpTrap");
            this.tpTrap.Size = (new global::System.Drawing.Size(740, 356));
            this.tpTrap.TabIndex = (7);
            this.tpTrap.Text = ("Trap");
            this.tpTrap.UseVisualStyleBackColor = (true);
            // 
            // saeTrapOnStepped
            // 
            this.saeTrapOnStepped.Action = (null);
            this.saeTrapOnStepped.ActionDescription = ("When someone steps on it...");
            this.saeTrapOnStepped.ActionTypeText = ("Stepped");
            this.saeTrapOnStepped.AlteredStatuses = (null);
            this.saeTrapOnStepped.AutoSize = (true);
            this.saeTrapOnStepped.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeTrapOnStepped.ClassId = (null);
            this.saeTrapOnStepped.Dungeon = (null);
            this.saeTrapOnStepped.EffectParamData = (null);
            this.saeTrapOnStepped.Location = (new global::System.Drawing.Point(13, 272));
            this.saeTrapOnStepped.Name = ("saeTrapOnStepped");
            this.saeTrapOnStepped.PlaceholderActionName = ("Stepped");
            this.saeTrapOnStepped.RequiresActionName = (false);
            this.saeTrapOnStepped.RequiresCondition = (false);
            this.saeTrapOnStepped.RequiresDescription = (false);
            this.saeTrapOnStepped.Size = (new global::System.Drawing.Size(290, 32));
            this.saeTrapOnStepped.SourceDescription = ("The trap");
            this.saeTrapOnStepped.TabIndex = (240);
            this.saeTrapOnStepped.TargetDescription = ("Whoever steps on it");
            this.saeTrapOnStepped.ThisDescription = ("The trap");
            this.saeTrapOnStepped.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeTrapOnStepped.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // txtTrapPower
            // 
            this.txtTrapPower.Location = (new global::System.Drawing.Point(86, 209));
            this.txtTrapPower.Name = ("txtTrapPower");
            this.txtTrapPower.Size = (new global::System.Drawing.Size(150, 23));
            this.txtTrapPower.TabIndex = (236);
            this.txtTrapPower.Enter += (this.txtTrapPower_Enter);
            this.txtTrapPower.Leave += (this.txtTrapPower_Leave);
            // 
            // label113
            // 
            this.label113.AutoSize = (true);
            this.label113.Location = (new global::System.Drawing.Point(13, 215));
            this.label113.Name = ("label113");
            this.label113.Size = (new global::System.Drawing.Size(65, 15));
            this.label113.TabIndex = (235);
            this.label113.Text = ("Trap Power");
            // 
            // chkTrapStartsVisible
            // 
            this.chkTrapStartsVisible.AutoSize = (true);
            this.chkTrapStartsVisible.Location = (new global::System.Drawing.Point(13, 247));
            this.chkTrapStartsVisible.Name = ("chkTrapStartsVisible");
            this.chkTrapStartsVisible.Size = (new global::System.Drawing.Size(102, 19));
            this.chkTrapStartsVisible.TabIndex = (233);
            this.chkTrapStartsVisible.Text = ("Spawns visible");
            this.chkTrapStartsVisible.UseVisualStyleBackColor = (true);
            this.chkTrapStartsVisible.CheckedChanged += (this.chkTrapStartsVisible_CheckedChanged);
            // 
            // label116
            // 
            this.label116.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label116.Location = (new global::System.Drawing.Point(390, 20));
            this.label116.Name = ("label116");
            this.label116.Size = (new global::System.Drawing.Size(131, 52));
            this.label116.TabIndex = (226);
            this.label116.Text = ("Appearance");
            this.label116.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // fklblTrapDescriptionLocale
            // 
            this.fklblTrapDescriptionLocale.Enabled = (false);
            this.fklblTrapDescriptionLocale.FlatAppearance.BorderSize = (0);
            this.fklblTrapDescriptionLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblTrapDescriptionLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblTrapDescriptionLocale.Image")));
            this.fklblTrapDescriptionLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblTrapDescriptionLocale.Location = (new global::System.Drawing.Point(13, 153));
            this.fklblTrapDescriptionLocale.Name = ("fklblTrapDescriptionLocale");
            this.fklblTrapDescriptionLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblTrapDescriptionLocale.TabIndex = (225);
            this.fklblTrapDescriptionLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblTrapDescriptionLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblTrapDescriptionLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblTrapDescriptionLocale.UseVisualStyleBackColor = (true);
            this.fklblTrapDescriptionLocale.Visible = (false);
            // 
            // txtTrapDescription
            // 
            this.txtTrapDescription.Location = (new global::System.Drawing.Point(13, 124));
            this.txtTrapDescription.Name = ("txtTrapDescription");
            this.txtTrapDescription.Size = (new global::System.Drawing.Size(350, 23));
            this.txtTrapDescription.TabIndex = (224);
            this.txtTrapDescription.TextChanged += (this.txtTrapDescription_TextChanged);
            // 
            // label117
            // 
            this.label117.AutoSize = (true);
            this.label117.Location = (new global::System.Drawing.Point(13, 106));
            this.label117.Name = ("label117");
            this.label117.Size = (new global::System.Drawing.Size(67, 15));
            this.label117.TabIndex = (223);
            this.label117.Text = ("Description");
            // 
            // fklblTrapNameLocale
            // 
            this.fklblTrapNameLocale.Enabled = (false);
            this.fklblTrapNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblTrapNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblTrapNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblTrapNameLocale.Image")));
            this.fklblTrapNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblTrapNameLocale.Location = (new global::System.Drawing.Point(13, 55));
            this.fklblTrapNameLocale.Name = ("fklblTrapNameLocale");
            this.fklblTrapNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblTrapNameLocale.TabIndex = (222);
            this.fklblTrapNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblTrapNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblTrapNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblTrapNameLocale.UseVisualStyleBackColor = (true);
            this.fklblTrapNameLocale.Visible = (false);
            // 
            // txtTrapName
            // 
            this.txtTrapName.Location = (new global::System.Drawing.Point(13, 26));
            this.txtTrapName.Name = ("txtTrapName");
            this.txtTrapName.Size = (new global::System.Drawing.Size(350, 23));
            this.txtTrapName.TabIndex = (221);
            this.txtTrapName.TextChanged += (this.txtTrapName_TextChanged);
            // 
            // label118
            // 
            this.label118.AutoSize = (true);
            this.label118.Location = (new global::System.Drawing.Point(13, 8));
            this.label118.Name = ("label118");
            this.label118.Size = (new global::System.Drawing.Size(80, 15));
            this.label118.TabIndex = (220);
            this.label118.Text = ("Default Name");
            // 
            // crsTrap
            // 
            this.crsTrap.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsTrap.BackgroundColor")));
            this.crsTrap.Character = ('\0');
            this.crsTrap.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsTrap.ForegroundColor")));
            this.crsTrap.Location = (new global::System.Drawing.Point(524, 9));
            this.crsTrap.Name = ("crsTrap");
            this.crsTrap.Size = (new global::System.Drawing.Size(211, 83));
            this.crsTrap.TabIndex = (239);
            this.crsTrap.PropertyChanged += (this.crsTrap_PropertyChanged);
            // 
            // tpAlteredStatus
            // 
            this.tpAlteredStatus.Controls.Add(this.saeAlteredStatusOnAttacked);
            this.tpAlteredStatus.Controls.Add(this.saeAlteredStatusBeforeAttack);
            this.tpAlteredStatus.Controls.Add(this.saeAlteredStatusOnRemove);
            this.tpAlteredStatus.Controls.Add(this.saeAlteredStatusOnTurnStart);
            this.tpAlteredStatus.Controls.Add(this.saeAlteredStatusOnApply);
            this.tpAlteredStatus.Controls.Add(this.chkAlteredStatusCleansedOnCleanseActions);
            this.tpAlteredStatus.Controls.Add(this.chkAlteredStatusCleanseOnFloorChange);
            this.tpAlteredStatus.Controls.Add(this.chkAlteredStatusCanOverwrite);
            this.tpAlteredStatus.Controls.Add(this.chkAlteredStatusCanStack);
            this.tpAlteredStatus.Controls.Add(this.label111);
            this.tpAlteredStatus.Controls.Add(this.fklblAlteredStatusDescriptionLocale);
            this.tpAlteredStatus.Controls.Add(this.txtAlteredStatusDescription);
            this.tpAlteredStatus.Controls.Add(this.label114);
            this.tpAlteredStatus.Controls.Add(this.fklblAlteredStatusNameLocale);
            this.tpAlteredStatus.Controls.Add(this.txtAlteredStatusName);
            this.tpAlteredStatus.Controls.Add(this.label115);
            this.tpAlteredStatus.Controls.Add(this.crsAlteredStatus);
            this.tpAlteredStatus.Location = (new global::System.Drawing.Point(4, 24));
            this.tpAlteredStatus.Name = ("tpAlteredStatus");
            this.tpAlteredStatus.Size = (new global::System.Drawing.Size(740, 356));
            this.tpAlteredStatus.TabIndex = (8);
            this.tpAlteredStatus.Text = ("Altered Status");
            this.tpAlteredStatus.UseVisualStyleBackColor = (true);
            // 
            // saeAlteredStatusOnAttacked
            // 
            this.saeAlteredStatusOnAttacked.Action = (null);
            this.saeAlteredStatusOnAttacked.ActionDescription = ("When someone afflicted  \r\nby it is attacked...");
            this.saeAlteredStatusOnAttacked.ActionTypeText = ("On Statused Attacked");
            this.saeAlteredStatusOnAttacked.AlteredStatuses = (null);
            this.saeAlteredStatusOnAttacked.AutoSize = (true);
            this.saeAlteredStatusOnAttacked.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeAlteredStatusOnAttacked.ClassId = (null);
            this.saeAlteredStatusOnAttacked.Dungeon = (null);
            this.saeAlteredStatusOnAttacked.EffectParamData = (null);
            this.saeAlteredStatusOnAttacked.Location = (new global::System.Drawing.Point(391, 266));
            this.saeAlteredStatusOnAttacked.Name = ("saeAlteredStatusOnAttacked");
            this.saeAlteredStatusOnAttacked.PlaceholderActionName = ("OnAttacked");
            this.saeAlteredStatusOnAttacked.RequiresActionName = (false);
            this.saeAlteredStatusOnAttacked.RequiresCondition = (false);
            this.saeAlteredStatusOnAttacked.RequiresDescription = (false);
            this.saeAlteredStatusOnAttacked.Size = (new global::System.Drawing.Size(276, 32));
            this.saeAlteredStatusOnAttacked.SourceDescription = ("Whoever it's inflicting");
            this.saeAlteredStatusOnAttacked.TabIndex = (265);
            this.saeAlteredStatusOnAttacked.TargetDescription = ("Whoever attacked them");
            this.saeAlteredStatusOnAttacked.ThisDescription = ("The Altered Status");
            this.saeAlteredStatusOnAttacked.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeAlteredStatusOnAttacked.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeAlteredStatusBeforeAttack
            // 
            this.saeAlteredStatusBeforeAttack.Action = (null);
            this.saeAlteredStatusBeforeAttack.ActionDescription = ("When someone afflicted\r\nby it is about to attack...   ");
            this.saeAlteredStatusBeforeAttack.ActionTypeText = ("Before Statused Attack");
            this.saeAlteredStatusBeforeAttack.AlteredStatuses = (null);
            this.saeAlteredStatusBeforeAttack.AutoSize = (true);
            this.saeAlteredStatusBeforeAttack.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeAlteredStatusBeforeAttack.ClassId = (null);
            this.saeAlteredStatusBeforeAttack.Dungeon = (null);
            this.saeAlteredStatusBeforeAttack.EffectParamData = (null);
            this.saeAlteredStatusBeforeAttack.Location = (new global::System.Drawing.Point(391, 229));
            this.saeAlteredStatusBeforeAttack.Name = ("saeAlteredStatusBeforeAttack");
            this.saeAlteredStatusBeforeAttack.PlaceholderActionName = ("BeforeAttack");
            this.saeAlteredStatusBeforeAttack.RequiresActionName = (false);
            this.saeAlteredStatusBeforeAttack.RequiresCondition = (false);
            this.saeAlteredStatusBeforeAttack.RequiresDescription = (false);
            this.saeAlteredStatusBeforeAttack.Size = (new global::System.Drawing.Size(276, 32));
            this.saeAlteredStatusBeforeAttack.SourceDescription = ("Whoever it's inflicting");
            this.saeAlteredStatusBeforeAttack.TabIndex = (264);
            this.saeAlteredStatusBeforeAttack.TargetDescription = ("Whoever is being targeted");
            this.saeAlteredStatusBeforeAttack.ThisDescription = ("The Altered Status");
            this.saeAlteredStatusBeforeAttack.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeAlteredStatusBeforeAttack.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeAlteredStatusOnRemove
            // 
            this.saeAlteredStatusOnRemove.Action = (null);
            this.saeAlteredStatusOnRemove.ActionDescription = ("When someone gets this\r\nAltered Status removed... ");
            this.saeAlteredStatusOnRemove.ActionTypeText = ("On Status Remove");
            this.saeAlteredStatusOnRemove.AlteredStatuses = (null);
            this.saeAlteredStatusOnRemove.AutoSize = (true);
            this.saeAlteredStatusOnRemove.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeAlteredStatusOnRemove.ClassId = (null);
            this.saeAlteredStatusOnRemove.Dungeon = (null);
            this.saeAlteredStatusOnRemove.EffectParamData = (null);
            this.saeAlteredStatusOnRemove.Location = (new global::System.Drawing.Point(391, 153));
            this.saeAlteredStatusOnRemove.Name = ("saeAlteredStatusOnRemove");
            this.saeAlteredStatusOnRemove.PlaceholderActionName = ("OnRemove");
            this.saeAlteredStatusOnRemove.RequiresActionName = (false);
            this.saeAlteredStatusOnRemove.RequiresCondition = (false);
            this.saeAlteredStatusOnRemove.RequiresDescription = (false);
            this.saeAlteredStatusOnRemove.Size = (new global::System.Drawing.Size(276, 32));
            this.saeAlteredStatusOnRemove.SourceDescription = ("The Altered Status");
            this.saeAlteredStatusOnRemove.TabIndex = (263);
            this.saeAlteredStatusOnRemove.TargetDescription = ("Whoever it's targeting");
            this.saeAlteredStatusOnRemove.ThisDescription = ("The Altered Status");
            this.saeAlteredStatusOnRemove.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeAlteredStatusOnRemove.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeAlteredStatusOnTurnStart
            // 
            this.saeAlteredStatusOnTurnStart.Action = (null);
            this.saeAlteredStatusOnTurnStart.ActionDescription = ("When someone afflicted\r\nby it begins a new turn...  ");
            this.saeAlteredStatusOnTurnStart.ActionTypeText = ("Turn Start");
            this.saeAlteredStatusOnTurnStart.AlteredStatuses = (null);
            this.saeAlteredStatusOnTurnStart.AutoSize = (true);
            this.saeAlteredStatusOnTurnStart.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeAlteredStatusOnTurnStart.ClassId = (null);
            this.saeAlteredStatusOnTurnStart.Dungeon = (null);
            this.saeAlteredStatusOnTurnStart.EffectParamData = (null);
            this.saeAlteredStatusOnTurnStart.Location = (new global::System.Drawing.Point(391, 191));
            this.saeAlteredStatusOnTurnStart.Name = ("saeAlteredStatusOnTurnStart");
            this.saeAlteredStatusOnTurnStart.PlaceholderActionName = ("TurnStart");
            this.saeAlteredStatusOnTurnStart.RequiresActionName = (false);
            this.saeAlteredStatusOnTurnStart.RequiresCondition = (false);
            this.saeAlteredStatusOnTurnStart.RequiresDescription = (false);
            this.saeAlteredStatusOnTurnStart.Size = (new global::System.Drawing.Size(276, 32));
            this.saeAlteredStatusOnTurnStart.SourceDescription = ("The Altered Status");
            this.saeAlteredStatusOnTurnStart.TabIndex = (262);
            this.saeAlteredStatusOnTurnStart.TargetDescription = ("Whoever it's inflicting");
            this.saeAlteredStatusOnTurnStart.ThisDescription = ("The Altered Status");
            this.saeAlteredStatusOnTurnStart.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeAlteredStatusOnTurnStart.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // saeAlteredStatusOnApply
            // 
            this.saeAlteredStatusOnApply.Action = (null);
            this.saeAlteredStatusOnApply.ActionDescription = ("When someone gets this\r\nAltered Status inflicted...  ");
            this.saeAlteredStatusOnApply.ActionTypeText = ("On Status Apply");
            this.saeAlteredStatusOnApply.AlteredStatuses = (null);
            this.saeAlteredStatusOnApply.AutoSize = (true);
            this.saeAlteredStatusOnApply.AutoSizeMode = (global::System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.saeAlteredStatusOnApply.ClassId = (null);
            this.saeAlteredStatusOnApply.Dungeon = (null);
            this.saeAlteredStatusOnApply.EffectParamData = (null);
            this.saeAlteredStatusOnApply.Location = (new global::System.Drawing.Point(392, 115));
            this.saeAlteredStatusOnApply.Name = ("saeAlteredStatusOnApply");
            this.saeAlteredStatusOnApply.PlaceholderActionName = ("StatusApply");
            this.saeAlteredStatusOnApply.RequiresActionName = (false);
            this.saeAlteredStatusOnApply.RequiresCondition = (false);
            this.saeAlteredStatusOnApply.RequiresDescription = (false);
            this.saeAlteredStatusOnApply.Size = (new global::System.Drawing.Size(275, 32));
            this.saeAlteredStatusOnApply.SourceDescription = ("The Altered Status");
            this.saeAlteredStatusOnApply.TabIndex = (261);
            this.saeAlteredStatusOnApply.TargetDescription = ("Whoever it's targeting");
            this.saeAlteredStatusOnApply.ThisDescription = ("The Altered Status");
            this.saeAlteredStatusOnApply.TurnEndCriteria = (global::RogueCustomsDungeonEditor.HelperForms.TurnEndCriteria.CannotEndTurn);
            this.saeAlteredStatusOnApply.UsageCriteria = (global::RogueCustomsDungeonEditor.HelperForms.UsageCriteria.AnyTargetAnyTime);
            // 
            // chkAlteredStatusCleansedOnCleanseActions
            // 
            this.chkAlteredStatusCleansedOnCleanseActions.AutoSize = (true);
            this.chkAlteredStatusCleansedOnCleanseActions.Location = (new global::System.Drawing.Point(13, 291));
            this.chkAlteredStatusCleansedOnCleanseActions.Name = ("chkAlteredStatusCleansedOnCleanseActions");
            this.chkAlteredStatusCleansedOnCleanseActions.Size = (new global::System.Drawing.Size(247, 19));
            this.chkAlteredStatusCleansedOnCleanseActions.TabIndex = (257);
            this.chkAlteredStatusCleansedOnCleanseActions.Text = ("Can be removed by 'Cleanse' Action steps");
            this.chkAlteredStatusCleansedOnCleanseActions.UseVisualStyleBackColor = (true);
            this.chkAlteredStatusCleansedOnCleanseActions.CheckedChanged += (this.chkAlteredStatusCleansedOnCleanseActions_CheckedChanged);
            // 
            // chkAlteredStatusCleanseOnFloorChange
            // 
            this.chkAlteredStatusCleanseOnFloorChange.AutoSize = (true);
            this.chkAlteredStatusCleanseOnFloorChange.Location = (new global::System.Drawing.Point(13, 266));
            this.chkAlteredStatusCleanseOnFloorChange.Name = ("chkAlteredStatusCleanseOnFloorChange");
            this.chkAlteredStatusCleanseOnFloorChange.Size = (new global::System.Drawing.Size(330, 19));
            this.chkAlteredStatusCleanseOnFloorChange.TabIndex = (256);
            this.chkAlteredStatusCleanseOnFloorChange.Text = ("Is removed if the afflicted Character moves to a new Floor");
            this.chkAlteredStatusCleanseOnFloorChange.UseVisualStyleBackColor = (true);
            this.chkAlteredStatusCleanseOnFloorChange.CheckedChanged += (this.chkAlteredStatusCleanseOnFloorChange_CheckedChanged);
            // 
            // chkAlteredStatusCanOverwrite
            // 
            this.chkAlteredStatusCanOverwrite.AutoSize = (true);
            this.chkAlteredStatusCanOverwrite.Location = (new global::System.Drawing.Point(13, 241));
            this.chkAlteredStatusCanOverwrite.Name = ("chkAlteredStatusCanOverwrite");
            this.chkAlteredStatusCanOverwrite.Size = (new global::System.Drawing.Size(342, 19));
            this.chkAlteredStatusCanOverwrite.TabIndex = (255);
            this.chkAlteredStatusCanOverwrite.Text = ("Overwrites other Altered Statuses with the same Id if applied");
            this.chkAlteredStatusCanOverwrite.UseVisualStyleBackColor = (true);
            this.chkAlteredStatusCanOverwrite.CheckedChanged += (this.chkAlteredStatusCanOverwrite_CheckedChanged);
            // 
            // chkAlteredStatusCanStack
            // 
            this.chkAlteredStatusCanStack.AutoSize = (true);
            this.chkAlteredStatusCanStack.Location = (new global::System.Drawing.Point(13, 216));
            this.chkAlteredStatusCanStack.Name = ("chkAlteredStatusCanStack");
            this.chkAlteredStatusCanStack.Size = (new global::System.Drawing.Size(311, 19));
            this.chkAlteredStatusCanStack.TabIndex = (250);
            this.chkAlteredStatusCanStack.Text = ("Can stack with other Altered Statuses with the same Id");
            this.chkAlteredStatusCanStack.UseVisualStyleBackColor = (true);
            this.chkAlteredStatusCanStack.CheckedChanged += (this.chkAlteredStatusCanStack_CheckedChanged);
            // 
            // label111
            // 
            this.label111.Font = (new global::System.Drawing.Font("Segoe UI", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point));
            this.label111.Location = (new global::System.Drawing.Point(390, 20));
            this.label111.Name = ("label111");
            this.label111.Size = (new global::System.Drawing.Size(131, 52));
            this.label111.TabIndex = (245);
            this.label111.Text = ("Appearance");
            this.label111.TextAlign = (global::System.Drawing.ContentAlignment.MiddleCenter);
            // 
            // fklblAlteredStatusDescriptionLocale
            // 
            this.fklblAlteredStatusDescriptionLocale.Enabled = (false);
            this.fklblAlteredStatusDescriptionLocale.FlatAppearance.BorderSize = (0);
            this.fklblAlteredStatusDescriptionLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblAlteredStatusDescriptionLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblAlteredStatusDescriptionLocale.Image")));
            this.fklblAlteredStatusDescriptionLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblAlteredStatusDescriptionLocale.Location = (new global::System.Drawing.Point(13, 153));
            this.fklblAlteredStatusDescriptionLocale.Name = ("fklblAlteredStatusDescriptionLocale");
            this.fklblAlteredStatusDescriptionLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblAlteredStatusDescriptionLocale.TabIndex = (244);
            this.fklblAlteredStatusDescriptionLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblAlteredStatusDescriptionLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblAlteredStatusDescriptionLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblAlteredStatusDescriptionLocale.UseVisualStyleBackColor = (true);
            this.fklblAlteredStatusDescriptionLocale.Visible = (false);
            // 
            // txtAlteredStatusDescription
            // 
            this.txtAlteredStatusDescription.Location = (new global::System.Drawing.Point(13, 124));
            this.txtAlteredStatusDescription.Name = ("txtAlteredStatusDescription");
            this.txtAlteredStatusDescription.Size = (new global::System.Drawing.Size(350, 23));
            this.txtAlteredStatusDescription.TabIndex = (243);
            this.txtAlteredStatusDescription.TextChanged += (this.txtAlteredStatusDescription_TextChanged);
            // 
            // label114
            // 
            this.label114.AutoSize = (true);
            this.label114.Location = (new global::System.Drawing.Point(13, 106));
            this.label114.Name = ("label114");
            this.label114.Size = (new global::System.Drawing.Size(67, 15));
            this.label114.TabIndex = (242);
            this.label114.Text = ("Description");
            // 
            // fklblAlteredStatusNameLocale
            // 
            this.fklblAlteredStatusNameLocale.Enabled = (false);
            this.fklblAlteredStatusNameLocale.FlatAppearance.BorderSize = (0);
            this.fklblAlteredStatusNameLocale.FlatStyle = (global::System.Windows.Forms.FlatStyle.Flat);
            this.fklblAlteredStatusNameLocale.Image = ((global::System.Drawing.Image)(resources.GetObject("fklblAlteredStatusNameLocale.Image")));
            this.fklblAlteredStatusNameLocale.ImageAlign = (global::System.Drawing.ContentAlignment.TopLeft);
            this.fklblAlteredStatusNameLocale.Location = (new global::System.Drawing.Point(13, 55));
            this.fklblAlteredStatusNameLocale.Name = ("fklblAlteredStatusNameLocale");
            this.fklblAlteredStatusNameLocale.Size = (new global::System.Drawing.Size(331, 42));
            this.fklblAlteredStatusNameLocale.TabIndex = (241);
            this.fklblAlteredStatusNameLocale.Text = ("This value has been found as a Locale Entry key.\r\nIn-game, it will be replaced by the Locale Entry's value.");
            this.fklblAlteredStatusNameLocale.TextAlign = (global::System.Drawing.ContentAlignment.MiddleLeft);
            this.fklblAlteredStatusNameLocale.TextImageRelation = (global::System.Windows.Forms.TextImageRelation.ImageBeforeText);
            this.fklblAlteredStatusNameLocale.UseVisualStyleBackColor = (true);
            this.fklblAlteredStatusNameLocale.Visible = (false);
            // 
            // txtAlteredStatusName
            // 
            this.txtAlteredStatusName.Location = (new global::System.Drawing.Point(13, 26));
            this.txtAlteredStatusName.Name = ("txtAlteredStatusName");
            this.txtAlteredStatusName.Size = (new global::System.Drawing.Size(350, 23));
            this.txtAlteredStatusName.TabIndex = (240);
            this.txtAlteredStatusName.TextChanged += (this.txtAlteredStatusName_TextChanged);
            // 
            // label115
            // 
            this.label115.AutoSize = (true);
            this.label115.Location = (new global::System.Drawing.Point(13, 8));
            this.label115.Name = ("label115");
            this.label115.Size = (new global::System.Drawing.Size(80, 15));
            this.label115.TabIndex = (239);
            this.label115.Text = ("Default Name");
            // 
            // crsAlteredStatus
            // 
            this.crsAlteredStatus.BackgroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsAlteredStatus.BackgroundColor")));
            this.crsAlteredStatus.Character = ('\0');
            this.crsAlteredStatus.ForegroundColor = ((global::RogueCustomsGameEngine.Utils.Representation.GameColor)(resources.GetObject("crsAlteredStatus.ForegroundColor")));
            this.crsAlteredStatus.Location = (new global::System.Drawing.Point(524, 9));
            this.crsAlteredStatus.Name = ("crsAlteredStatus");
            this.crsAlteredStatus.Size = (new global::System.Drawing.Size(211, 83));
            this.crsAlteredStatus.TabIndex = (260);
            this.crsAlteredStatus.PropertyChanged += (this.crsAlteredStatus_PropertyChanged);
            // 
            // tpValidation
            // 
            this.tpValidation.Controls.Add(this.tvValidationResults);
            this.tpValidation.Location = (new global::System.Drawing.Point(4, 24));
            this.tpValidation.Name = ("tpValidation");
            this.tpValidation.Size = (new global::System.Drawing.Size(740, 356));
            this.tpValidation.TabIndex = (9);
            this.tpValidation.Text = ("Validation Results");
            this.tpValidation.UseVisualStyleBackColor = (true);
            // 
            // tvValidationResults
            // 
            this.tvValidationResults.Dock = (global::System.Windows.Forms.DockStyle.Fill);
            this.tvValidationResults.Location = (new global::System.Drawing.Point(0, 0));
            this.tvValidationResults.Name = ("tvValidationResults");
            this.tvValidationResults.Size = (new global::System.Drawing.Size(740, 356));
            this.tvValidationResults.TabIndex = (0);
            // 
            // ofdDungeon
            // 
            this.ofdDungeon.Filter = ("Dungeon JSON|*.json");
            this.ofdDungeon.Title = ("Select a Dungeon JSON file");
            // 
            // sfdDungeon
            // 
            this.sfdDungeon.Filter = ("Dungeon JSON|*.json");
            this.sfdDungeon.Title = ("Set a Dungeon JSON file name to save");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = (new global::System.Drawing.SizeF(7F, 15F));
            this.AutoScaleMode = (global::System.Windows.Forms.AutoScaleMode.Font);
            this.ClientSize = (new global::System.Drawing.Size(967, 450));
            this.Controls.Add(this.tbTabs);
            this.Controls.Add(this.tvDungeonInfo);
            this.Controls.Add(this.tsButtons);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = (global::System.Windows.Forms.FormBorderStyle.FixedSingle);
            this.Icon = ((global::System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = (this.msMenu);
            this.MaximizeBox = (false);
            this.Name = ("frmMain");
            this.StartPosition = (global::System.Windows.Forms.FormStartPosition.CenterScreen);
            this.Text = ("Rogue Customs Dungeon Editor");
            this.FormClosing += (this.frmMain_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsButtons.ResumeLayout(false);
            this.tsButtons.PerformLayout();
            this.tbTabs.ResumeLayout(false);
            this.tpBasicInfo.ResumeLayout(false);
            this.tpBasicInfo.PerformLayout();
            this.tpLocales.ResumeLayout(false);
            this.tpLocales.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvLocales)).EndInit();
            this.tpTileSetInfos.ResumeLayout(false);
            this.tpFloorInfos.ResumeLayout(false);
            this.tpFloorInfos.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudRoomFusionOdds)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudExtraRoomConnectionOdds)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudMaxRoomConnections)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudMaxFloorLevel)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudMinFloorLevel)).EndInit();
            this.tpFactionInfos.ResumeLayout(false);
            this.tpFactionInfos.PerformLayout();
            this.tpPlayerClass.ResumeLayout(false);
            this.tpPlayerClass.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudPlayerInventorySize)).EndInit();
            this.tpNPC.ResumeLayout(false);
            this.tpNPC.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudNPCOddsToTargetSelf)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.nudNPCInventorySize)).EndInit();
            this.tpItem.ResumeLayout(false);
            this.tpItem.PerformLayout();
            this.tpTrap.ResumeLayout(false);
            this.tpTrap.PerformLayout();
            this.tpAlteredStatus.ResumeLayout(false);
            this.tpAlteredStatus.PerformLayout();
            this.tpValidation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip msMenu;
        private ToolStripMenuItem editorToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip tsButtons;
        private ToolStripButton tsbNewDungeon;
        private ToolStripButton tsbOpenDungeon;
        private ToolStripButton tsbSaveDungeon;
        private ToolStripButton tsbSaveDungeonAs;
        private ToolStripSeparator tssDungeonElement;
        private ToolStripButton tsbValidateDungeon;
        private TreeView tvDungeonInfo;
        private TabControl tbTabs;
        private TabPage tpBasicInfo;
        private TabPage tpLocales;
        private TabPage tpFloorInfos;
        private TabPage tpFactionInfos;
        private TabPage tpPlayerClass;
        private TabPage tpNPC;
        private TabPage tpItem;
        private TabPage tpTrap;
        private TabPage tpAlteredStatus;
        private TabPage tpValidation;
        private OpenFileDialog ofdDungeon;
        private TextBox txtEndingMessage;
        private Label label4;
        private TextBox txtWelcomeMessage;
        private Label label3;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtDungeonName;
        private Label label1;
        private Button fklblEndingMessageLocale;
        private Button fklblWelcomeMessageLocale;
        private Button fklblAuthorLocale;
        private Button fklblDungeonNameLocale;
        private Button btnDeleteLocale;
        private Button btnAddLocale;
        private Button btnUpdateLocale;
        private Button fklblMissingLocale;
        private TextBox txtLocaleEntryValue;
        private Label label7;
        private TextBox txtLocaleEntryKey;
        private Label label6;
        private DataGridView dgvLocales;
        private DataGridViewTextBoxColumn cmKey;
        private DataGridViewTextBoxColumn cmValue;
        private ToolStripButton tsbAddElement;
        private ToolStripButton tsbSaveElement;
        private ToolStripButton tsbSaveElementAs;
        private ToolStripButton tsbDeleteElement;
        private ToolStripSeparator tssElementValidate;
        private ComboBox cmbDefaultLocale;
        private Label label8;
        private NumericUpDown nudMaxFloorLevel;
        private Label label10;
        private NumericUpDown nudMinFloorLevel;
        private Label label9;
        private Button fklblStairsReminder;
        private CheckBox chkGenerateStairsOnStart;
        private Button btnNPCGenerator;
        private Label label13;
        private NumericUpDown nudHeight;
        private NumericUpDown nudWidth;
        private Label label12;
        private Label label11;
        private Button btnItemGenerator;
        private Label label14;
        private Button btnTrapGenerator;
        private Label label15;
        private ListView lvFloorAlgorithms;
        private Label label17;
        private Label label16;
        private Button btnRemoveAlgorithm;
        private Button btnEditAlgorithm;
        private Button btnAddAlgorithm;
        private NumericUpDown nudRoomFusionOdds;
        private Label label19;
        private NumericUpDown nudExtraRoomConnectionOdds;
        private Label label18;
        private NumericUpDown nudMaxRoomConnections;
        private Label label5;
        private ListBox lbEnemies;
        private Label label26;
        private Button btnEnemiesToNeutrals;
        private Button btnEnemyToNeutral;
        private Button btnNeutralsToEnemies;
        private Button btnNeutralToEnemy;
        private ListBox lbNeutrals;
        private Label label25;
        private Button btnNeutralsToAllies;
        private Button btnNeutralToAlly;
        private Button btnAlliesToNeutrals;
        private Button btnAllyToNeutral;
        private ListBox lbAllies;
        private Label label24;
        private Label label23;
        private Button fklblFactionDescriptionLocale;
        private TextBox txtFactionDescription;
        private Label label22;
        private Button fklblFactionNameLocale;
        private TextBox txtFactionName;
        private Label label21;
        private Button fklblPlayerClassDescriptionLocale;
        private TextBox txtPlayerClassDescription;
        private Label label28;
        private Button fklblPlayerClassNameLocale;
        private TextBox txtPlayerClassName;
        private Label label27;
        private ComboBox cmbPlayerFaction;
        private Label label29;
        private CheckBox chkRequirePlayerPrompt;
        private CheckBox chkPlayerStartsVisible;
        private Label label30;
        private ComboBox cmbPlayerStartingArmor;
        private Label label57;
        private ComboBox cmbPlayerStartingWeapon;
        private Label label56;
        private Label label54;
        private NumericUpDown nudPlayerInventorySize;
        private Label label53;
        private Label label58;
        private global::System.Windows.Forms.TextBox txtNPCExperiencePayout;
        private global::System.Windows.Forms.Label label103;
        private global::System.Windows.Forms.CheckBox chkNPCKnowsAllCharacterPositions;
        private global::System.Windows.Forms.Label label67;
        private global::System.Windows.Forms.ComboBox cmbNPCStartingArmor;
        private global::System.Windows.Forms.Label label70;
        private global::System.Windows.Forms.ComboBox cmbNPCStartingWeapon;
        private global::System.Windows.Forms.Label label71;
        private global::System.Windows.Forms.Label label73;
        private global::System.Windows.Forms.NumericUpDown nudNPCInventorySize;
        private global::System.Windows.Forms.Label label74;
        private global::System.Windows.Forms.Label label98;
        private global::System.Windows.Forms.CheckBox chkNPCStartsVisible;
        private global::System.Windows.Forms.ComboBox cmbNPCFaction;
        private global::System.Windows.Forms.Label label99;
        private global::System.Windows.Forms.CheckBox chkAlteredStatusCleanseOnFloorChange;
        private global::System.Windows.Forms.Button fklblNPCNameLocale;
        private global::System.Windows.Forms.TextBox txtNPCDescription;
        private global::System.Windows.Forms.Label label100;
        private global::System.Windows.Forms.Button fklblNPCDescriptionLocale;
        private global::System.Windows.Forms.TextBox txtNPCName;
        private global::System.Windows.Forms.Label label101;
        private global::System.Windows.Forms.NumericUpDown nudNPCOddsToTargetSelf;
        private global::System.Windows.Forms.Label label104;
        private global::System.Windows.Forms.TextBox txtItemPower;
        private global::System.Windows.Forms.Label label108;
        private global::System.Windows.Forms.CheckBox chkItemCanBePickedUp;
        private global::System.Windows.Forms.CheckBox chkItemStartsVisible;
        private global::System.Windows.Forms.ComboBox cmbItemType;
        private global::System.Windows.Forms.Label label107;
        private global::System.Windows.Forms.Label label102;
        private global::System.Windows.Forms.Button fklblItemDescriptionLocale;
        private global::System.Windows.Forms.TextBox txtItemDescription;
        private global::System.Windows.Forms.Label label105;
        private global::System.Windows.Forms.Button fklblItemNameLocale;
        private global::System.Windows.Forms.TextBox txtItemName;
        private global::System.Windows.Forms.Label label106;
        private global::System.Windows.Forms.CheckBox chkTrapStartsVisible;
        private global::System.Windows.Forms.Label label116;
        private global::System.Windows.Forms.Button fklblTrapDescriptionLocale;
        private global::System.Windows.Forms.TextBox txtTrapDescription;
        private global::System.Windows.Forms.Label label117;
        private global::System.Windows.Forms.Button fklblTrapNameLocale;
        private global::System.Windows.Forms.TextBox txtTrapName;
        private global::System.Windows.Forms.Label label118;
        private global::System.Windows.Forms.TextBox txtTrapPower;
        private global::System.Windows.Forms.Label label113;
        private global::System.Windows.Forms.CheckBox chkAlteredStatusCanStack;
        private global::System.Windows.Forms.Label label111;
        private global::System.Windows.Forms.Button fklblAlteredStatusDescriptionLocale;
        private global::System.Windows.Forms.TextBox txtAlteredStatusDescription;
        private global::System.Windows.Forms.Label label114;
        private global::System.Windows.Forms.Button fklblAlteredStatusNameLocale;
        private global::System.Windows.Forms.TextBox txtAlteredStatusName;
        private global::System.Windows.Forms.Label label115;
        private global::System.Windows.Forms.CheckBox chkAlteredStatusCleansedOnCleanseActions;
        private global::System.Windows.Forms.CheckBox chkAlteredStatusCanOverwrite;
        private global::System.Windows.Forms.TreeView tvValidationResults;
        private global::System.Windows.Forms.SaveFileDialog sfdDungeon;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector crsPlayer;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector crsNPC;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector crsItem;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector crsTrap;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector crsAlteredStatus;
        private global::System.Windows.Forms.TabPage tpTileSetInfos;
        private global::System.Windows.Forms.Label label138;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrConnectorWall;
        private global::System.Windows.Forms.Label label134;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrHorizontalWall;
        private global::System.Windows.Forms.Label label135;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrBottomRightWall;
        private global::System.Windows.Forms.Label label136;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrBottomLeftWall;
        private global::System.Windows.Forms.Label label133;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrVerticalWall;
        private global::System.Windows.Forms.Label label132;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrTopRightWall;
        private global::System.Windows.Forms.Label label131;
        private global::System.Windows.Forms.Label label130;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrTopLeftWall;
        private global::System.Windows.Forms.Label label148;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrHorizontalHallway;
        private global::System.Windows.Forms.Label label149;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrBottomRightHallway;
        private global::System.Windows.Forms.Label label150;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrBottomLeftHallway;
        private global::System.Windows.Forms.Label label137;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrCentralHallway;
        private global::System.Windows.Forms.Label label140;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrVerticalRightHallway;
        private global::System.Windows.Forms.Label label141;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrVerticalLeftHallway;
        private global::System.Windows.Forms.Label label142;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrHorizontalTopHallway;
        private global::System.Windows.Forms.Label label143;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrHorizontalBottomHallway;
        private global::System.Windows.Forms.Label label144;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrVerticalHallway;
        private global::System.Windows.Forms.Label label145;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrTopRightHallway;
        private global::System.Windows.Forms.Label label146;
        private global::System.Windows.Forms.Label label147;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrTopLeftHallway;
        private global::System.Windows.Forms.Label label151;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrEmpty;
        private global::System.Windows.Forms.Label label152;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrStairs;
        private global::System.Windows.Forms.Label label153;
        private global::System.Windows.Forms.Label label154;
        private global::RogueCustomsDungeonEditor.Controls.ConsoleRepresentationSelector csrFloor;
        private global::System.Windows.Forms.ComboBox cmbTilesets;
        private global::System.Windows.Forms.Label label155;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeOnFloorStart;
        private global::RogueCustomsDungeonEditor.Controls.MultiActionEditor maePlayerOnAttack;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saePlayerOnAttacked;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saePlayerOnTurnStart;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saePlayerOnDeath;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeNPCOnDeath;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeNPCOnAttacked;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeNPCOnTurnStart;
        private global::RogueCustomsDungeonEditor.Controls.MultiActionEditor maeNPCOnAttack;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeItemOnUse;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeItemOnStepped;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeItemOnTurnStart;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeItemOnAttacked;
        private global::RogueCustomsDungeonEditor.Controls.MultiActionEditor maeItemOnAttack;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeTrapOnStepped;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeAlteredStatusOnTurnStart;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeAlteredStatusOnApply;
        private global::RogueCustomsDungeonEditor.Controls.StartingInventorySelector sisPlayerStartingInventory;
        private global::RogueCustomsDungeonEditor.Controls.StartingInventorySelector sisNPCStartingInventory;
        private global::RogueCustomsDungeonEditor.Controls.StatsSheet ssNPC;
        private global::RogueCustomsDungeonEditor.Controls.StatsSheet ssPlayer;
        private global::RogueCustomsDungeonEditor.Controls.MultiActionEditor maeNPCOnInteracted;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeNPCOnSpawn;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeAlteredStatusOnAttacked;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeAlteredStatusBeforeAttack;
        private global::RogueCustomsDungeonEditor.Controls.SingleActionEditor saeAlteredStatusOnRemove;
    }
}