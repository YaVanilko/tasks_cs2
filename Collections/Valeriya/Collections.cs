﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Valeriya
{
    class Collections : ICollections
    {
        public int SortPotatoes(List<IPotatoe> potatoeBag, out List<IPotatoe> goodPotatoes, out List<IPotatoe> badPotatoes)
        {
            throw new NotImplementedException();
        }

        public List<IOutData> ProcessData(IReadOnlyList<IInData> inputData)
        {
            throw new NotImplementedException();
        }

        public LinkedList<int> CreateOrderedList(IReadOnlyList<int> input)
        {
            throw new NotImplementedException();
        }


        public IReadOnlyDictionary<char, IList<string>> OrganizeByFirstCharacter(IEnumerable<string> text)
        {
            throw new NotImplementedException();
        }
    }
}