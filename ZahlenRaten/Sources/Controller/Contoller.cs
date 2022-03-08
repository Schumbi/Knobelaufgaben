namespace ZahlenRaten.Sources.Controller
{
    using ZahlenRaten.Sources.Model;

    public class Contoller
    {
        private readonly Model _model;

        public Contoller(Model model)
        {
            _model = model;

            var rndGen = new Random();
            _model.RndNumber = rndGen.Next(0, 100);
        }

        public void Evaluate()
        {
            var guess = _model.InpNumber;
            var actual = _model.RndNumber;

            HideEqual = guess != actual;
            HideBigger = guess >= actual;
            HideSmaller = guess <= actual;

            _model.GuessCount += 1;

        }

        internal void Reset()
        {
            var rndGen = new Random();
            _model.RndNumber = rndGen.Next(0, 100);
            _model.GuessCount = 0;
            _model.started = true;
            _model.InpNumber = 0;

            HideBigger = true;
            HideEqual = true;
            HideSmaller = true;
        }

        public bool HideEqual { get; private set; } = true;

        public bool HideBigger { get; private set; } = true;

        public bool HideSmaller { get; private set; } = true;

        public bool HideNotStarted => _model.started;
    }
}
