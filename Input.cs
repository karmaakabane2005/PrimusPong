using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace PrimusPong
{
    public enum InputType
    {
        confirm,
        cancel,
        escape,
        moveUp,
        moveDown,
        pause,
    }
    class Input
    {
        private InputType _type;
        private Keys _key;
        private Buttons _button;
        private bool _enabled = true;
        // Possibilité de séléctionner un bouton pas sur le controlleur !
        public InputType Type { get => _type; set => _type = value; }
        public Keys Key { get => _key; set => _key = value; }
        public Buttons Button { get => _button; set => _button = value; }
        public bool Enabled { get => _enabled; set => _enabled = value; }

        public Input(InputType type, Keys key, Buttons button)
        {
            Type = type;
            Key = key;
            Button = button;
        }
        public Input(InputType type, Keys key)
        {
            Type = type;
            Key = key;
            Button = 0;
        }
         public bool IsTriggered(KeyboardState kState)
        {
            if (kState.IsKeyDown(Key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsTriggered(GamePadState gpState)
        {
            if (gpState.IsButtonDown(Button))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
