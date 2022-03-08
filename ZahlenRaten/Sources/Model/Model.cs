namespace ZahlenRaten.Sources.Model
{
    public class Model
    {
        /// <summary>
        /// Ranom number, generated.
        /// </summary>
        public int RndNumber { get; set; } = 0;

        /// <summary>
        /// Input number of the user.
        /// </summary>
        public int InpNumber { get; set; } = 0;

        /// <summary>
        /// Guess counter.
        /// </summary>
        public int GuessCount { get; set; } = 0;

        /// <summary>
        /// Game started?
        /// </summary>
        public bool started { get; set; } = false;
    }
}
