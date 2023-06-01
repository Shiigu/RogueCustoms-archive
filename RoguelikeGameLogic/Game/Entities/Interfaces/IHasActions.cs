﻿namespace RoguelikeGameEngine.Game.Entities.Interfaces
{
    public interface IHasActions
    {
        void PerformOnTurnStartActions();
        void RefreshCooldownsAndUpdateTurnLength();

    }
}
