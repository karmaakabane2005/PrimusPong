using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace PrimusPong
{
    class Ball
    {
        /*
          Texture2D rect = new Texture2D(graphics.GraphicsDevice, 80, 30);

        Color[] data = new Color[80*30];
        for(int i=0; i < data.Length; i++) data[i] = Color.Chocolate;
         rect.SetData(data);

         Vector2 coor = new Vector2(10, 20);
         spriteBatch.Draw(rect, coor, Color.White);
         
         https://www.youtube.com/watch?v=hVjQK0Ko-l8
        https://www.youtube.com/watch?v=X03Ht69HRec 
         http://jeffreythompson.org/collision-detection/circle-rect.php
        
         */

        private Rectangle _rect;
        private Vector2 _speed = new Vector2(5,5);
        private Vector2 _deplacement = new Vector2(1,1);
        private Texture2D _sprite;
        private Color _color = Color.YellowGreen;
        private int _opacity = 1;

        public Rectangle Rect { get => _rect; set => _rect = value; }
        public Vector2 Speed { get => _speed; set => _speed = value; }
        public Texture2D Sprite { get => _sprite; set => _sprite = value; }
        public Color Color { get => _color; set => _color = value; }
        public int Opacity { get => _opacity; set => _opacity = value; }
        public Ball()
        {
            _rect = new Rectangle(100, 100, 50, 50);
        }

        public void Load(ContentManager c)
        {
            _sprite = c.Load<Texture2D>("./TEST_VERSION/46");
        }
        public void Update(float dt, ref Scene scene)
        {
            if(scene == Scene.pause)
            {
                _opacity = 0;
            }
            if (scene == Scene.game)
            {
            Move();
            }
        }
        private void Move()
        {
            _rect.Location += _deplacement.ToPoint();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite, _rect, _color * _opacity);
        }
    }
}
