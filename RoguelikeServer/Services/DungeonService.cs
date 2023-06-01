﻿using Microsoft.Extensions.Caching.Memory;
using RoguelikeGameEngine.Management;
using RoguelikeGameEngine.Utils.InputsAndOutputs;

namespace Roguelike.Services
{
    public class DungeonService
    {
        private readonly IMemoryCache Cache;
        private readonly DungeonManager DungeonManager;

        public DungeonService(IMemoryCache cache)
        {
            Cache = cache;
            if (!Cache.TryGetValue("DungeonManager", out DungeonManager))
            {
                DungeonManager = new DungeonManager();
                Cache.Set("DungeonManager", DungeonManager);
            }
        }
        public List<DungeonListDto> GetPickableDungeonList()
        {
            return DungeonManager.GetPickableDungeonList();
        }

        public int CreateDungeon(string dungeonName)
        {
            return DungeonManager.CreateDungeon(dungeonName);
        }

        public DungeonDto GetDungeonStatus(int dungeonId)
        {
            return DungeonManager.GetDungeonStatus(dungeonId);
        }
        public string GetDungeonWelcomeMessage(int dungeonId)
        {
            return DungeonManager.GetDungeonWelcomeMessage(dungeonId);
        }
        public string GetDungeonEndingMessage(int dungeonId)
        {
            return DungeonManager.GetDungeonEndingMessage(dungeonId);
        }

        public void MovePlayer(int dungeonId, CoordinateInput input)
        {
            DungeonManager.MovePlayer(dungeonId, input);
        }

        public void PlayerSkipTurn(int dungeonId)
        {
            DungeonManager.PlayerSkipTurn(dungeonId);
        }

        public void PlayerUseItemInFloor(int dungeonId)
        {
            DungeonManager.PlayerUseItemInFloor(dungeonId);
        }

        public void PlayerPickUpItemInFloor(int dungeonId)
        {
            DungeonManager.PlayerPickUpItemInFloor(dungeonId);
        }

        public void PlayerUseItemFromInventory(int dungeonId, int itemId)
        {
            DungeonManager.PlayerUseItemFromInventory(dungeonId, itemId);
        }

        public void PlayerDropItemFromInventory(int dungeonId, int itemId)
        {
            DungeonManager.PlayerDropItemFromInventory(dungeonId, itemId);
        }

        public void PlayerSwapFloorItemWithInventoryItem(int dungeonId, int itemId)
        {
            DungeonManager.PlayerSwapFloorItemWithInventoryItem(dungeonId, itemId);
        }

        public PlayerInfoDto GetPlayerDetailInfo(int dungeonId)
        {
            return DungeonManager.GetPlayerDetailInfo(dungeonId);
        }

        public InventoryDto GetPlayerInventory(int dungeonId)
        {
            return DungeonManager.GetPlayerInventory(dungeonId);
        }

        public List<ActionItemDto> GetPlayerAttackActions(int dungeonId, int x, int y)
        {
            return DungeonManager.GetPlayerAttackActions(dungeonId, x, y);
        }

        public void PlayerAttackTargetWith(int dungeonId, AttackInput input)
        {
            DungeonManager.PlayerAttackTargetWith(dungeonId, input);
        }

        public void PlayerTakeStairs(int dungeonId)
        {
            DungeonManager.PlayerTakeStairs(dungeonId);
        }
    }
}
