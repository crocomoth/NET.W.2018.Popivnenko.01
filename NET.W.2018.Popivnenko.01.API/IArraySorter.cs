﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.API
{
    public interface IArraySorter
    {
        void QuickSort<T>(T[] array) where T: IComparable;

        void MergeSort<T>(T[] array) where T: IComparable;
    }
}
