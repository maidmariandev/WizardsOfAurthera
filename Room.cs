using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WizardsOfAurthera
{
    public class Room
    {
        public Room()
        {
            Instances = new ConcurrentBag<Instance<Piece>>();
        }
        public bool AddPiece(Instance<Piece> piece)
        {
            if (Instances.Any(A => A.Id == piece.Id)) return false;
            Instances.Add(piece);
            return true;
        }
        public ConcurrentBag<Instance<Piece>> Instances { get; set; }

    }
}
