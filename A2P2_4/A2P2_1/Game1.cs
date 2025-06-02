using A2P2_1.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A2P2_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private Zombie _zombie;       //zombie obj


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            
            _zombie = new Zombie(3,Content.Load<Texture2D>("zombie"), Content.Load<SpriteFont>("gamefont"));
            // zombie can be kill by 3times
            
            _zombie.SetScale(1f);   // no scale
          
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here


            //press space health -1
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                _zombie.TakeDamage(1);
            }

            _zombie.Update();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.ForestGreen);

            // TODO: Add your drawing code here
            _spriteBatch .Begin();


            _zombie.Draw(_spriteBatch);


            _spriteBatch.End();


            base.Draw(gameTime);
        }


        
    }
}
