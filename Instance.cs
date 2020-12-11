using System;

namespace WizardsOfAurthera
{
    
    public interface IDHolder
    {
        CoordinateNumber X { get; set; }
        CoordinateNumber Y { get; set; }
        public string Location { get; set; }
        public Guid Id { get; }
    }
    public class Instance<T> where T : IDHolder
    {
        public Guid Id { get; }
        public Instance(T Item) : base()
        {
            Node = Item;
            Id = Guid.NewGuid(); 
      
        }
        public T Node { get; }
    }
}