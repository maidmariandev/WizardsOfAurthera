using System;
using System.Collections.Generic;

namespace WizardsOfAurthera
{
    public interface Piece : IDHolder
    {
        public void Rock(IReadOnlyCollection<Instance<Piece>> NearByPieces);
    }

    public class Mordor : Piece
    {
        public Mordor()
        {
            Id = Guid.NewGuid();
            X = new CoordinateNumber(0);
            Y = new CoordinateNumber(0);
        }

        public CoordinateNumber X { get; set; }
        public CoordinateNumber Y { get; set; }
        public string Location { get; set; }

        public Guid Id { get; set; }

        public void Rock(IReadOnlyCollection<Instance<Piece>> NearByPieces)
        {
            throw new NotImplementedException();
        }
    }
}