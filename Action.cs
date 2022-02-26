using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace PrimusPong
{
    class Action
    {
        private Input _moveUp = new Input(InputType.moveUp,Keys.W);
        private Input _moveDown = new Input(InputType.moveDown,Keys.S);
        private Input _confirm = new Input(InputType.confirm,Keys.Enter);
        private Input _cancel = new Input(InputType.moveUp,Keys.Escape);
        private Input _quit = new Input(InputType.moveUp,Keys.Q);
        private Input _pause = new Input(InputType.pause,Keys.Escape);

        internal Input MoveUp { get => _moveUp; set => _moveUp = value; }
        internal Input MoveDown { get => _moveDown; set => _moveDown = value; }
        internal Input Confirm { get => _confirm; set => _confirm = value; }
        internal Input Cancel { get => _cancel; set => _cancel = value; }
        internal Input Quit { get => _quit; set => _quit = value; }
        internal Input Pause { get => _pause; set => _pause = value; }
    }
}
