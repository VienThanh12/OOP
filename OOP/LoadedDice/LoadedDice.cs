namespace LoadedDice
{
    public class LoadedDice : Dice
    {
        // field
        private int _fixedResult;

        // constructors (notice the use of "base" referring to the parent class)
        public LoadedDice() : base()
        {
            _fixedResult = 6;
        }

        public LoadedDice(int faces) : base(faces)
        {
            _fixedResult = faces;
        }

        public LoadedDice(int faces, int fixedResult) : base(faces)
        {
            _fixedResult = fixedResult;
        }

        // Throw method that overrrides the one from the base class
        public override void Throw()
        {
            Result = _fixedResult;
        }
    }
}

