﻿using RoguelikeGameEngine.Game.DungeonStructure;
using RoguelikeGameEngine.Game.Entities.Interfaces;
using RoguelikeGameEngine.Utils.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace RoguelikeGameEngine.Game.Entities
{
    public class Item : Entity, IHasActions
    {
        public bool CanBePickedUp { get; set; }
        public string Power { get; set; }
        public Character Owner { get; set; }
        private List<ActionWithEffects> OnItemSteppedActions { get; set; }
        public List<ActionWithEffects> OnItemUseActions { get; set; }

        public Item(EntityClass entityClass, Map map) : base(entityClass, map)
        {
            Power = entityClass.Power;
            CanBePickedUp = entityClass.CanBePickedUp;
            Owner = null;
            OnItemSteppedActions = new List<ActionWithEffects>();
            MapClassActions(entityClass.OnItemSteppedActions, OnItemSteppedActions);
            OnItemUseActions = new List<ActionWithEffects>();
            MapClassActions(entityClass.OnItemUseActions, OnItemUseActions);
        }

        public void Stepped(Entity stomper)
        {
            OnItemSteppedActions.ForEach(oisa => oisa.Do(this, stomper));
        }
        public void Used(Entity user)
        {
            OnItemUseActions.ForEach(oiua => oiua.Do(this, user));
        }

        public void RefreshCooldownsAndUpdateTurnLength()
        {
            OwnOnAttackActions?.Where(a => a.CooldownBetweenUses > 0 && a.CurrentCooldown > 0).ForEach(a => a.CurrentCooldown--);
            OwnOnAttackedActions?.Where(a => a.CooldownBetweenUses > 0 && a.CurrentCooldown > 0).ForEach(a => a.CurrentCooldown--);
            OwnOnTurnStartActions?.Where(a => a.CooldownBetweenUses > 0 && a.CurrentCooldown > 0).ForEach(a => a.CurrentCooldown--);
            OnItemSteppedActions?.Where(a => a.CooldownBetweenUses > 0 && a.CurrentCooldown > 0).ForEach(a => a.CurrentCooldown--);
            OnItemUseActions?.Where(a => a.CooldownBetweenUses > 0 && a.CurrentCooldown > 0).ForEach(a => a.CurrentCooldown--);
        }

        public void PerformOnTurnStartActions()
        {
            if(Owner != null)
                OwnOnTurnStartActions?.Where(a => a.CanBeUsedOn(Owner, Map)).ForEach(a => a.Do(this, Owner));
        }
    }
}
