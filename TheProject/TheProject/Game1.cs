using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheProject
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private MinsooHello helloWorld = new MinsooHello();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        //change
        protected override void Initialize()
        {
            SamHello sam = new();
            sam.PrintMessage();
            base.Initialize();

            LukeHello lukeHello = new();
            lukeHello.PrintMessage();


            YashHello yash = new YashHello();
            yash.PrintMessage();

            HelloBill bill = new HelloBill();
            bill.Print();

            helloWorld.Draw();


            base.Initialize();

            PavanHello pavan = new PavanHello();
            pavan.PrintMessage();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            
            



            base.Draw(gameTime);
        }
    }
}
