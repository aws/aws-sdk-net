using System;

namespace ThirdParty.iOS4Unity
{
    public class ButtonEventArgs : EventArgs
    {
        public int Index;
    }

    public class NSErrorEventArgs : EventArgs
    {
        public NSError Error;
    }
}