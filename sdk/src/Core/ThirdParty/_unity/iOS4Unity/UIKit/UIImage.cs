using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
    public class UIImage : NSObject
    {
        private const string SelectorName = "__onSaveToPhotoAlbum:";

        [DllImport("/System/Library/Frameworks/UIKit.framework/UIKit")]
        private static extern IntPtr UIImageJPEGRepresentation(IntPtr image, float compressionQuality);

        [DllImport("/System/Library/Frameworks/UIKit.framework/UIKit")]
        private static extern IntPtr UIImagePNGRepresentation(IntPtr image);

        [DllImport("/System/Library/Frameworks/UIKit.framework/UIKit")]
        private static extern void UIImageWriteToSavedPhotosAlbum(IntPtr image, IntPtr obj, IntPtr selector, IntPtr ctx);

        private static readonly IntPtr _classHandle;

        private class UIImageDispatcher : NSObject
        {
            private static readonly IntPtr _classHandle;

            static UIImageDispatcher()
            {
                _classHandle = ObjC.AllocateClassPair(ObjC.GetClass("NSObject"), "__UIImageDispatcher", 0);
            }

            public override IntPtr ClassHandle
            {
                get { return _classHandle; }
            }

            public UIImageDispatcher(Action<NSError> action)
            {
                Action = action;
            }

            public readonly Action<NSError> Action;
        }

        static UIImage()
        {
            _classHandle = ObjC.GetClass("UIImage");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal UIImage(IntPtr handle)
            : base(handle)
        {
        }

        public NSData AsJPEG(float compressionQuality = 1)
        {
            return Runtime.GetNSObject<NSData>(UIImageJPEGRepresentation(Handle, compressionQuality));
        }

        public NSData AsPNG()
        {
            return Runtime.GetNSObject<NSData>(UIImagePNGRepresentation(Handle));
        }

        public float CurrentScale
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("scale")); }
        }

        public static UIImage FromBundle(string name)
        {
            return Runtime.GetNSObject<UIImage>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("imageNamed:"), name));
        }

        public static UIImage FromFile(string filename)
        {
#if !XAMARIN
            filename = Path.Combine(UnityEngine.Application.streamingAssetsPath, filename);
#endif

            return Runtime.GetNSObject<UIImage>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("imageWithContentsOfFile:"), filename));
        }

        public static UIImage LoadFromData(NSData data)
        {
            return Runtime.GetNSObject<UIImage>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("imageWithData:"), data.Handle));
        }

        public static UIImage LoadFromData(NSData data, float scale)
        {
            return Runtime.GetNSObject<UIImage>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("imageWithData:scale:"), data.Handle, scale));
        }

        public CGSize Size
        {
            get { return new CGSize(ObjC.MessageSendCGSize(Handle, "size")); }
        }

        public void SaveToPhotosAlbum(Action<NSError> callback = null)
        {
            if (callback == null)
            {
                UIImageWriteToSavedPhotosAlbum(Handle, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                var dispatcher = new UIImageDispatcher(callback);
                Callbacks.Subscribe(dispatcher, SelectorName, (IntPtr obj, IntPtr e, IntPtr ctx) =>
                {
                    callback(e == IntPtr.Zero ? null : Runtime.GetNSObject<NSError>(e));
                    dispatcher.Dispose();
                });
                UIImageWriteToSavedPhotosAlbum(Handle, dispatcher.Handle, ObjC.GetSelector(SelectorName), IntPtr.Zero);
            }
        }
    }
}