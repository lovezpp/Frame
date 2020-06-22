using System;
using System.Collections.Generic;
using System.Text;

namespace YXH.Services.Services
{
    public class DisposeBase
    {
        private delegate void DisposeEventHandler();
        private event DisposeEventHandler DisposeEvent;

        public DisposeBase(params dynamic[] services)
        {
            foreach (var item in services)
            {
                DisposeEvent += ((IDisposable)item).Dispose;
            }
        }

        public void Dispose()
        {
            DisposeEvent?.Invoke();
        }
    }
}
