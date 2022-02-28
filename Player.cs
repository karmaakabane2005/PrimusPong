using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimusPong
{
    public enum Direction { 
    UP,
    DOWN,
    };
    class Player : DisplayableElement
    {
        private Rectangle _rect;
        public Rectangle Rect
        {
            get
            {
                return _rect;
            }
            set
            {
                _rect = value;
            }
        }
        private Texture2D _sprite;
        public Texture2D Sprite
        {
            get
            {
                return _sprite;
            }
            set
            {
                _sprite = value;
            }
        }
        private Vector2 _speed = new Vector2(5,5);
        private Vector2 _maxSpeed = new Vector2(10,10);
        public Vector2 Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        private Vector2 _deplacement;
        private Action _control;
        public Action Control
        {
            get
            {
                return _control;
            }
        }
        private Color _color = Color.White;
        private int _opacity = 1;
        public Player(Rectangle rectangle,Action control)
        {
            this.Rect = rectangle;
            this._control = control;
        }
        public void Load(ContentManager c)
        {
           Sprite = c.Load<Texture2D>("./TEST_VERSION/46");
        }

        public void Update(KeyboardState kbState, float dt,ref Scene scene)
        {
            if (scene == Scene.pause)
            {
                // naviguer dans le menu pause
            }
            if (Control.Quit.IsTriggered(kbState))
            {
                scene = Scene.quit;
            }
            if (Control.Pause.IsTriggered(kbState))
            {
                scene = Scene.pause;
            }
            if (Control.MoveUp.IsTriggered(kbState))
            {
                Move(Direction.UP,dt);
            }
            if (Control.MoveDown.IsTriggered(kbState))
            {
                Move(Direction.DOWN, dt);
            }

        }

        private void Move(Direction direction, float dt)
        {
            if(direction == Direction.UP)
            {
                    _deplacement.Y -= _speed.Y * dt;
            }
            if (direction == Direction.DOWN)
            {
                _deplacement.Y += _speed.Y * dt;
            }
            _rect.Location += _deplacement.ToPoint();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite, _rect, _color * _opacity);
        }
    }
}
