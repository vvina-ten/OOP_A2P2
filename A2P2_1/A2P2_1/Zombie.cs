using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A2P2_1.Content
{
    public class Zombie
    {

        private Texture2D zombietex;

        private int health;
        private int damage;

        private float scale;

        private SpriteFont gamefont;
        private Vector2 position;

        public Zombie(int health, Texture2D zombietex, SpriteFont gamefont)
        {

            this.health = health;
            this.zombietex = zombietex;
            this.gamefont = gamefont;
            this.position = new Vector2(100,50);
            this.scale = 0.5f;

        }

        public int GetHealth()
        {

            return this.health;

        }


        public void SetScale(float newScale)
        {

            this.scale = newScale;

        }
   


        public void Draw(SpriteBatch spriteBatch)
        {
           
            Rectangle destRect = new Rectangle
             (
                (int)position.X,(int)position.Y,50,50);


            string healthbar = "Health: " + health.ToString();

            Vector2 position2 = new Vector2(position.X, position.Y - 20);

            spriteBatch.DrawString(gamefont, healthbar, position2, Color.Blue);

        }







    }
}
