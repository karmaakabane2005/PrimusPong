using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PrimusPong
{
    public abstract class DisplayableElement
    {
        private int _opacity = 1;
        private bool _enabled = true;
        private Color _color = Color.White;
        private Rectangle _rectangle;
        private Texture2D _texture;

        public int Opacity { get => _opacity; set => _opacity = value; }
        public bool Enabled { get => _enabled; set => _enabled = value; }
        public Color Color { get => _color; set => _color = value; }
        public Rectangle Rectangle { get => _rectangle; set => _rectangle = value; }
        public Texture2D Texture { get => _texture; set => _texture = value; }

        public DisplayableElement(Rectangle rectangle, Color color, int opacity, bool enabled)
        {
            _rectangle = rectangle;
            _color = color;
            _opacity = opacity;
            _enabled = enabled;
        }

        public abstract void Load();
        public abstract void Update(float dt);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
