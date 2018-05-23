namespace JakubSturc.CSharp7DeepDive.Examples
{    
    public class Example
    {
        private string _name;

        // available in C# 6.0
        public int Getter => 42;                    
        public void Method() => _name = _name.ToUpperInvariant();
        // new in C# 7.0
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public char this[int i] => _name[i];
        public Example(string name) => _name = name;
        ~Example() => _name = null;
    }
}
