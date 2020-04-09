using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcretAggregate : Aggreate
    {
        private ArrayList itens = new ArrayList();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            {
                return itens.Count;
            }
        }

        public object this[int index]
        {
            get { return itens[index]; }
            set { itens.Insert(index, value); }
        }
    }
}
