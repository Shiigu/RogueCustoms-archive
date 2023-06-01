﻿using RoguelikeGameEngine.Utils.Representation;

namespace RoguelikeGameEngine.Utils.InputsAndOutputs
{
    public class MessageBoxDto
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonCaption { get; set; }
        public GameColor WindowColor { get; set; }
    }
}
