using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
    public class NSData : NSObject
    {
        private static readonly IntPtr _classHandle;

        static NSData()
        {
            _classHandle = ObjC.GetClass("NSData");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        private class UnmanagedMemoryStreamWithRef : UnmanagedMemoryStream
        {
#pragma warning disable 414
            private NSData _data;
#pragma warning restore 414

            public unsafe UnmanagedMemoryStreamWithRef(NSData source)
                : base((byte*)((void*)source.Bytes), (long)((ulong)source.Length))
            {
                _data = source;
            }

            protected override void Dispose(bool disposing)
            {
                _data = null;

                base.Dispose(disposing);
            }
        }

        internal NSData(IntPtr handle)
            : base(handle)
        {
        }

        public unsafe static NSData FromArray(byte[] buffer)
        {
            if (buffer.Length == 0)
            {
                return NSData.FromBytes(IntPtr.Zero, 0);
            }
            fixed (void* ptr = &buffer[0])
            {
                return NSData.FromBytes((IntPtr)ptr, (uint)buffer.Length);
            }
        }

        public static NSData FromBytes(IntPtr bytes, uint size)
        {
            return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dataWithBytes:length:"), bytes, size));
        }

        public static NSData FromData(NSData source)
        {
            return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dataWithData:"), source.Handle));
        }

        public static NSData FromBytesNoCopy(IntPtr bytes, uint size)
        {
            return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dataWithBytesNoCopy:length:"), bytes, size));
        }

        public static NSData FromBytesNoCopy(IntPtr bytes, uint size, bool freeWhenDone)
        {
            return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dataWithBytesNoCopy:length:freeWhenDone:"), bytes, size, freeWhenDone));
        }

        public static NSData FromFile(string path, NSDataReadingOptions mask, out NSError error)
        {
#if !XAMARIN
            path = Path.Combine(UnityEngine.Application.streamingAssetsPath, path);
#endif

            IntPtr errorHandle;
            var data = Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dataWithContentsOfFile:options:error:"), path, (uint)mask, out errorHandle));
            error = errorHandle == IntPtr.Zero ? null : Runtime.GetNSObject<NSError>(errorHandle);
            return data;
        }

        public static NSData FromFile(string path)
        {
#if !XAMARIN
            path = Path.Combine(UnityEngine.Application.streamingAssetsPath, path);
#endif

            return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dataWithContentsOfFile:"), path));
        }

        public static NSData FromUrl(string url)
        {
            return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr_NSUrl(_classHandle,Selector.GetHandle( "dataWithContentsOfURL:"), url));
        }

        public static NSData FromUrl(string url, NSDataReadingOptions mask, out NSError error)
        {
            IntPtr errorHandle;
            var data = Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr_NSUrl(_classHandle, Selector.GetHandle("dataWithContentsOfURL:options:error:"), url, (uint)mask, out errorHandle));
            error = errorHandle == IntPtr.Zero ? null : Runtime.GetNSObject<NSError>(errorHandle);
            return data;
        }

        public IntPtr Bytes
        {
            get { return ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("bytes")); }
        }

        public uint Length
        {
            get { return ObjC.MessageSendUInt(Handle, Selector.GetHandle("length")); }
            set { throw new NotImplementedException("Not available on NSData, only available on NSMutableData"); }
        }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || (long)index > (long)((ulong)this.Length))
                {
                    throw new ArgumentException("idx");
                }
                return Marshal.ReadByte(new IntPtr(Bytes.ToInt64() + (long)index));
            }
            set
            {
                throw new NotImplementedException("NSData arrays can not be modified, use an NSMutableData instead");
            }
        }

        public bool Save(string path, bool atomically = true)
        {
            return ObjC.MessageSendBool(Handle, Selector.GetHandle("writeToFile:atomically:"), path, atomically);
        }

        public Stream AsStream()
        {
            //TODO: if we ever implement NSMutableData
            //if (this is NSMutableData)
            //{
            //    return new NSData.UnmanagedMemoryStreamWithMutableRef(this);
            //}
            return new NSData.UnmanagedMemoryStreamWithRef(this);
        }

        public byte[] ToArray()
        {
            byte[] array = new byte[this.Length];
            Marshal.Copy(Bytes, array, 0, array.Length);
            return array;
        }
    }

    [Flags]
    [CLSCompliant(false)]
    public enum NSDataReadingOptions : uint
    {
        Mapped = 1,
        Uncached = 2,
        Coordinated = 4,
        MappedAlways = 8
    }
}