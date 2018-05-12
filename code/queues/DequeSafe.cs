using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Queues
{
    public class DequeSafe<T> : Deque<T>
    {
        #region Fields

        private object root = new Object();

        #endregion

        #region API

        public override void Prepend(T item)
        {
            lock(root)
            {
                base.Prepend(item);
            }
        }

        #endregion
    }
}