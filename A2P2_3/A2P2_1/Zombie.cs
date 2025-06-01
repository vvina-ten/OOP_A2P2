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
        private float movespeed;

        private bool isalive; 

        private SpriteFont gamefont;
        private Vector2 position;

        public Zombie(int health, Texture2D zombietex, SpriteFont gamefont)
        {

            this.health = health;
            this.zombietex = zombietex;
            this.gamefont = gamefont;
            this.position = new Vector2(700,50);
            this.scale = 0.5f;
            this.movespeed = 2f;

            this.isalive = true;
        }

        public int GetHealth()
        {

            return this.health;

        }


        public void SetScale(float newScale)
        {

            this.scale = newScale;

        }

        public void TakeDamage(int damage) 
        {
          this.health -= damage;

            if (this.health <= 0)

            {
                this.health = 0;
                this.isalive = false;

            }

        }




        public void Update() 
        {
            if (isalive) 
            { 

                position.X -= movespeed;

                if (position.X < -130) 
                {
                 position.X = 800;
                }

            }

        
        }


        public void Draw(SpriteBatch spriteBatch)
        {

            if (isalive)
            {
                Rectangle destRect = new Rectangle
                 (
                    (int)position.X, (int)position.Y, 130, 180);
            

                spriteBatch.Draw(zombietex, destRect, Color.White);



                string healthbar = "Health: " + health.ToString();

                Vector2 position2 = new Vector2(position.X, position.Y - 20);

                spriteBatch.DrawString(gamefont, healthbar, position2, Color.Blue);

            }


        }







    }
}
