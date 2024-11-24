using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Project2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<GameObject> _gameObjects;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.IsFullScreen = true;
        }

        protected override void Initialize()
        {
            _gameObjects = new List<GameObject>();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _gameObjects.Add(new GameObject(new Vector2(500, 840), Content.Load<Texture2D>("wraith")));
            _gameObjects.Add(new GameObject(new Vector2(0, 400), Content.Load<Texture2D>("scout")));
            _gameObjects.Add(new MovingObject(new Vector2(2, 2), Content.Load<Texture2D>("carrier"), new Vector2(2, 0)));
            _gameObjects.Add(new MovingObject(new Vector2(1650, 2), Content.Load<Texture2D>("phoenix"), new Vector2(2, 5)));
            _gameObjects.Add(new ControlledObject(new Vector2(500, 500), Content.Load<Texture2D>("cruiser"), new Vector2(5, 10)));
        }

        protected override void Update(GameTime gameTime)
        { 
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            foreach (GameObject obj in _gameObjects)
                obj.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            foreach(GameObject obj in _gameObjects)
                obj.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

