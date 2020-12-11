namespace WizardsOfAurthera
{
    public class CoordinateNumber
    {
        private float _x;
        
        public CoordinateNumber(float v)
        {
            this._x = v;
        }

        public int Value { get => (int)_x; }
        public float Get()
        {
            return _x;
        }
        public void Set(float x)
        {
            _x = x;
        }
    }
}