using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ThirdParty.iOS4Unity
{
    public class Selector
    {
        public static readonly IntPtr Init = Selector.GetHandle("init");
        public static readonly IntPtr InitWithCoder = Selector.GetHandle("initWithCoder:");
        public static readonly IntPtr InitWithName = Selector.GetHandle("initWithName:");
        public static readonly IntPtr InitWithFrame = Selector.GetHandle("initWithFrame:");

        static IntPtr MethodSignatureForSelector = Selector.GetHandle("methodSignatureForSelector:");
        static IntPtr FrameLength = Selector.GetHandle("frameLength");
        internal static IntPtr RetainCount = Selector.GetHandle("retainCount");
        internal const string Alloc = "alloc";
        internal const string Release = "release";
        internal const string Retain = "retain";
        internal const string Autorelease = "autorelease";
        internal const string DoesNotRecognizeSelector = "doesNotRecognizeSelector:";
        internal const string PerformSelectorOnMainThreadWithObjectWaitUntilDone = "performSelectorOnMainThread:withObject:waitUntilDone:";
        internal const string PerformSelectorWithObjectAfterDelay = "performSelector:withObject:afterDelay:";
        internal const string UTF8String = "UTF8String";


        internal static IntPtr AllocHandle = Selector.GetHandle(Alloc);
        internal static IntPtr ReleaseHandle = Selector.GetHandle(Release);
        internal static IntPtr RetainHandle = Selector.GetHandle(Retain);
        internal static IntPtr AutoreleaseHandle = Selector.GetHandle(Autorelease);
        internal static IntPtr DoesNotRecognizeSelectorHandle = Selector.GetHandle(DoesNotRecognizeSelector);
        internal static IntPtr PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle = Selector.GetHandle(PerformSelectorOnMainThreadWithObjectWaitUntilDone);
        internal static IntPtr PerformSelectorWithObjectAfterDelayHandle = Selector.GetHandle(PerformSelectorWithObjectAfterDelay);
        internal static IntPtr UTF8StringHandle = Selector.GetHandle(UTF8String);
        internal IntPtr handle;

        public Selector(IntPtr sel) :
            this(sel, true)
        {
        }

        internal Selector(IntPtr sel, bool check)
        {
            if (check && !sel_isMapped(sel))
                throw new ArgumentException("sel is not a selector handle.");

            this.handle = sel;
        }

        public Selector(string name, bool alloc)
        {
            handle = GetHandle(name);
        }

        public Selector(string name) : this(name, false) { }

        public IntPtr Handle
        {
            get { return handle; }
        }

        public string Name
        {
            get { return Marshal.PtrToStringAuto(sel_getName(handle)); }
        }

        public static Selector Register(IntPtr handle)
        {
            return new Selector(handle);
        }

        public static Selector FromHandle(IntPtr sel)
        {
            if (!sel_isMapped(sel))
                return null;
            return new Selector(sel, false);
        }

        [DllImport("/usr/lib/libobjc.dylib")]
        extern static IntPtr sel_getName(IntPtr sel);
        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "sel_registerName")]
        public extern static IntPtr GetHandle(string name);
        [DllImport("/usr/lib/libobjc.dylib")]
        extern static bool sel_isMapped(IntPtr sel);
    }
}
