using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    public interface ISprite
    { 
        public void Update() { }
        public void Draw(SpriteBatch sprite, Vector2 vec);
    }
}
