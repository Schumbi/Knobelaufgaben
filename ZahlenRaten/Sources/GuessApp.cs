namespace ZahlenRaten
{
    using ZahlenRaten.Sources.Model;
    using ZahlenRaten.Sources.Controller;

    public class GuessApp
    {
        public GuessApp()
        {
            Model = new();
            Contoller = new(Model);
        }

        /// <summary>
        /// Reset App.
        /// </summary>
        public void Reset()
        {
            Contoller.Reset();
        }

        public void Start()
        {
            Model.started = true;
        }

        /// <summary>
        /// The model
        /// </summary>
        public Model Model { get; private set; }

        /// <summary>
        /// The controller
        /// </summary>
        public Contoller Contoller { get; private set; }

    }
}
