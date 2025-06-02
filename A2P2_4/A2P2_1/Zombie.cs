using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A2P2_1.Content
{
    public class Zombie
    {

        private Texture2D zombietex;    //zombie mage

        private int health;             // health value
        private int damage;            //damage value

        private float scale;            //scale size
        private float movespeed;        //speed value

        private bool isalive;           //zombie alive status

        private SpriteFont gamefont;    // game font
        private Vector2 position;       //zombie position

        public Zombie(int health, Texture2D zombietex, SpriteFont gamefont)
        {

            this.health = health;
            this.zombietex = zombietex;
            this.gamefont = gamefont;
            this.position = new Vector2(700,50);    //initial position
            this.scale = 0.5f;
            this.movespeed = 2f;

            this.isalive = true;
        }                              //argument constructor 



        // accessor mathod
        public int GetHealth()
        {

            return this.health;         //get health

        }

        public float GetMovespeed()
        {

            return this.movespeed;      //get speed

        }

        public bool GetIsalive()
        {

            return this.isalive;         //get alive status

        }

        public float GetScale()
        {

            return this.scale;         //get alive status

        }


        //mutator method
        public void SetScale(float newScale)
        {

            this.scale = newScale;          //set scale size

        }

        


        public void TakeDamage(int damage) 
        {
          this.health -= damage;

            if (this.health <= 0)

            {
                this.health = 0;
                this.isalive = false;           //if zombie die  remove zombie

            }

        }


        //helper method

        public void Update() 
        {
            if (isalive)                  //only alive zombie can move
            { 

                position.X -= movespeed;

                if (position.X < -130)      //total image out of the screen
                {
                 position.X = 800;          //restart from right
                }

            }

        
        }


        public void Draw(SpriteBatch spriteBatch) 
        {

            if (isalive)                            //only alive zombie has healthbar
            {
                Rectangle destRect = new Rectangle
                 (
                    (int)position.X, (int)position.Y, 130, 180);   //display zombie's health position
            

                spriteBatch.Draw(zombietex, destRect, Color.White);   //zombie'simage



                string healthbar = "Health: " + health.ToString();      //health text

                Vector2 position2 = new Vector2(position.X, position.Y - 20);  // position

                spriteBatch.DrawString(gamefont, healthbar, position2, Color.Blue);   // health text style

            }


        }







    }
}
