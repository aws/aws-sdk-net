using ThirdParty.iOS4Unity.Marshalers;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
    public static class ObjC
    {
        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "sel_registerName")]
        public static extern IntPtr GetSelector(string name);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "sel_getName")]
        public static extern string GetSelectorName(IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_getClass")]
        public static extern IntPtr GetClass(string name);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_allocateClassPair")]
        public static extern IntPtr AllocateClassPair(IntPtr superclass, string name, int extraBytes);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "class_addMethod")]
        public static extern bool AddMethod(IntPtr cls, IntPtr selector, Delegate imp, string types);

        //Note: return object instead of DateTime or we get an invalid IL exception
        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSDateReleaseMarshaler))] object arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, bool arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGSize arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGRect arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGPoint arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, int arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, float arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1, IntPtr arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1, int arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1, int arg2, IntPtr arg3);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.LPStr)] string arg3, IntPtr arg4);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, uint arg3, bool arg4);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, int arg1, bool arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, bool arg1, bool arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern void MessageSend(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [CLSCompliant(false)]
        public static extern uint MessageSendUInt(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern int MessageSendInt(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern int MessageSendInt(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern int MessageSendInt(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] object arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, CGRect arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, double arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, int arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, int arg1, bool arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, double arg1, int arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [CLSCompliant(false)]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, uint arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [CLSCompliant(false)]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [CLSCompliant(false)]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [CLSCompliant(false)]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, bool arg3);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1, IntPtr arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1, uint arg2, out IntPtr arg3);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, bool arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSDateReleaseMarshaler))] object arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] string arg1, bool arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern double MessageSendDouble(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern double MessageSendDouble(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.LPStr)] object arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern float MessageSendFloat(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern float MessageSendFloat(IntPtr receiver, IntPtr selector, float arg1);

        //HACK: return object instead of DateTime or we get an invalid IL exception
        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSDateMarshaler))]
        public static extern object MessageSendDate(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSDateMarshaler))]
        public static extern object MessageSendDate(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSDateReleaseMarshaler))] object arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSDateReleaseMarshaler))] object arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, int arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, double arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

        public static string MessageSendString(IntPtr receiver, IntPtr selector, string arg1)
        {
            return MessageSendString(receiver, selector, ToNSString(arg1));
        }

        public static string MessageSendString(IntPtr receiver, IntPtr selector, string arg1, string arg2, string arg3)
        {
            return MessageSendString(receiver, selector, ToNSString(arg1), ToNSString(arg2), ToNSString(arg3));
        }

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr MessageSendIntPtr_NSUrl(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSUrlMarshaler))] string arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        [CLSCompliant(false)]
        public static extern IntPtr MessageSendIntPtr_NSUrl(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSUrlMarshaler))] string arg1, uint arg2, out IntPtr arg3);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern bool MessageSendBool_NSUrl(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NSUrlMarshaler))] string arg1);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
        public static extern CGRect MessageSendCGRect(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
        [CLSCompliant(false)]
        public static extern CGPoint _MessageSendStretCGPoint(IntPtr receiver, IntPtr selector);

        [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
        [CLSCompliant(false)]
        public static extern CGSize _MessageSendStretCGSize(IntPtr receiver, IntPtr selector);

        public static CGSize MessageSendCGSize(IntPtr receiver, string selector)
        {
            var sel = new Selector(selector);
            return _MessageSendStretCGSize(receiver, sel.Handle);
        }

        public static CGPoint MessageSendCGPoint(IntPtr receiver, string selector)
        {
            var sel = new Selector(selector);
            return _MessageSendStretCGPoint(receiver, sel.Handle);
        }

        [DllImport("/usr/lib/libSystem.dylib")]
        private static extern IntPtr dlsym(IntPtr handle, string symbol);

        [DllImport("/usr/lib/libSystem.dylib")]
        private static extern IntPtr dlopen(string path, int mode);

        public static class Libraries
        {
            public static readonly IntPtr Foundation = dlopen("/System/Library/Frameworks/Foundation.framework/Foundation", 0);
            public static readonly IntPtr UIKit = dlopen("/System/Library/Frameworks/UIKit.framework/UIKit", 0);
        }

        public static string FromNSString(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return null;

            return Marshal.PtrToStringAuto(ObjC.MessageSendIntPtr(handle, Selector.UTF8StringHandle));
        }


        const string timeIntervalSinceReferenceDate = "timeIntervalSinceReferenceDate";
        internal static readonly global::ThirdParty.iOS4Unity.Selector TimeIntervalSinceReferenceDateSelector =
            new global::ThirdParty.iOS4Unity.Selector(timeIntervalSinceReferenceDate);

        public static DateTime FromNSDate(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return default(DateTime);

            double secondsSinceReferenceDate = ObjC.MessageSendDouble(handle, TimeIntervalSinceReferenceDateSelector.Handle);
            if (secondsSinceReferenceDate < -63113904000)
            {
                return DateTime.MinValue;
            }
            if (secondsSinceReferenceDate > 252423993599)
            {
                return DateTime.MaxValue;
            }
            return new DateTime((long)(secondsSinceReferenceDate * 10000000 + 6.3113904E+17), DateTimeKind.Utc);
        }

        const string absoluteString = "absoluteString";
        internal static readonly global::ThirdParty.iOS4Unity.Selector AbsoluteStringSelector =
            new global::ThirdParty.iOS4Unity.Selector(absoluteString);
        public static string FromNSUrl(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return null;

            return FromNSString(ObjC.MessageSendIntPtr(handle, AbsoluteStringSelector.Handle));
        }


        const string doubleValue = "doubleValue";
        internal static readonly global::ThirdParty.iOS4Unity.Selector DoubleValueSelector =
            new global::ThirdParty.iOS4Unity.Selector(doubleValue);

        public static double FromNSNumber(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return default(double);

            return ObjC.MessageSendDouble(handle, DoubleValueSelector.Handle);
        }

        const string count = "count";
        internal static readonly global::ThirdParty.iOS4Unity.Selector CountSelector =
            new global::ThirdParty.iOS4Unity.Selector(count);

        const string objectAtIndex = "objectAtIndex:";
        internal static readonly global::ThirdParty.iOS4Unity.Selector ObjectAtIndexSelector =
            new global::ThirdParty.iOS4Unity.Selector(objectAtIndex);

        public static string[] FromNSArray(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
            {
                return null;
            }

            uint count = ObjC.MessageSendUInt(handle, CountSelector.Handle);
            string[] array = new string[count];
            IntPtr obj;
            for (uint num = 0; num < count; num += 1)
            {
                obj = ObjC.MessageSendIntPtr(handle, ObjectAtIndexSelector.Handle, num);
                array[(int)num] = FromNSString(obj);
            }
            return array;
        }

        const string allObjects = "allObjects";
        internal static readonly global::ThirdParty.iOS4Unity.Selector AllObjectsSelector =
            new global::ThirdParty.iOS4Unity.Selector(allObjects);

        public static string[] FromNSSet(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
            {
                return null;
            }

            IntPtr array = ObjC.MessageSendIntPtr(handle, AllObjectsSelector.Handle);
            return FromNSArray(array);
        }

        public static T[] FromNSArray<T>(IntPtr handle) where T : NSObject
        {
            if (handle == IntPtr.Zero)
            {
                return null;
            }

            uint count = ObjC.MessageSendUInt(handle, CountSelector.Handle);
            T[] array = new T[count];
            IntPtr obj;
            for (uint num = 0; num < count; num += 1)
            {
                obj = ObjC.MessageSendIntPtr(handle, ObjectAtIndexSelector.Handle, num);
                array[(int)num] = Runtime.GetNSObject<T>(obj);
            }
            return array;
        }

        public static void ReleaseNSArrayItems(IntPtr handle)
        {
            uint count = ObjC.MessageSendUInt(handle, CountSelector.Handle);
            IntPtr obj;
            for (uint num = 0; num < count; num += 1)
            {
                obj = ObjC.MessageSendIntPtr(handle, ObjectAtIndexSelector.Handle, num);
                MessageSend(obj, Selector.ReleaseHandle);
            }
        }

        public static T[] FromNSSet<T>(IntPtr handle) where T : NSObject
        {
            if (handle == IntPtr.Zero)
            {
                return null;
            }

            IntPtr array = ObjC.MessageSendIntPtr(handle, AllObjectsSelector.Handle);
            return FromNSArray<T>(array);
        }

        public static string GetStringConstant(IntPtr handle, string symbol)
        {
            IntPtr intPtr = dlsym(handle, symbol);
            if (intPtr == IntPtr.Zero)
            {
                return null;
            }
            intPtr = Marshal.ReadIntPtr(intPtr);
            if (intPtr == IntPtr.Zero)
            {
                return null;
            }
            return FromNSString(intPtr);
        }

        public unsafe static float GetFloatConstant(IntPtr handle, string symbol)
        {
            IntPtr intPtr = dlsym(handle, symbol);
            if (intPtr == IntPtr.Zero)
            {
                return 0;
            }
            float* ptr = (float*)((void*)intPtr);
            return *ptr;
        }

        const string arrayWithObjects_count = "arrayWithObjects:count:";
        internal static readonly global::ThirdParty.iOS4Unity.Selector ArrayWithObjects_CountSelector =
            new global::ThirdParty.iOS4Unity.Selector(arrayWithObjects_count);

        public static IntPtr ToNSArray(IntPtr[] items)
        {
            IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)(items.Length * IntPtr.Size));
            for (int i = 0; i < items.Length; i++)
            {
                Marshal.WriteIntPtr(intPtr, i * IntPtr.Size, items[i]);
            }

            IntPtr array = ObjC.MessageSendIntPtr(ObjC.GetClass("NSArray"), ArrayWithObjects_CountSelector.Handle, intPtr, items.Length);
            Marshal.FreeHGlobal(intPtr);
            return array;
        }

        public static IntPtr ToNSArray(NSObject[] items)
        {
            return ToNSArray(items.Select(i => i.Handle).ToArray());
        }

        public static IntPtr ToNSArray(string[] items)
        {
            return ToNSArray(items.Select(s => ToNSString(s)).ToArray());
        }

        const string setWithArray = "setWithArray";
        internal static readonly global::ThirdParty.iOS4Unity.Selector SetWithArraySelector =
            new global::ThirdParty.iOS4Unity.Selector(setWithArray);

        public static IntPtr ToNSSet(IntPtr[] items)
        {
            IntPtr array = ToNSArray(items);
            return ObjC.MessageSendIntPtr(GetClass("NSSet"), SetWithArraySelector.Handle, array);
        }

        public static IntPtr ToNSSet(string[] items)
        {
            IntPtr[] strings = new IntPtr[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                strings[i] = ToNSString(items[i]);
            }

            IntPtr array = ToNSArray(strings);
            IntPtr set = ObjC.MessageSendIntPtr(GetClass("NSSet"), SetWithArraySelector.Handle, array);

            //Release everything
            for (int i = 0; i < strings.Length; i++)
            {
                ObjC.MessageSend(strings[i], Selector.ReleaseHandle);
            }

            return set;
        }

        const string initWithCharacters_length = "initWithCharacters:length:";
        internal static readonly global::ThirdParty.iOS4Unity.Selector InitWithCharacters_lengthSelector =
            new global::ThirdParty.iOS4Unity.Selector(initWithCharacters_length);

        public unsafe static IntPtr ToNSString(string str)
        {
            IntPtr handle = MessageSendIntPtr(GetClass("NSString"), Selector.AllocHandle);
            fixed (char* value = str + (IntPtr)(RuntimeHelpers.OffsetToStringData / 2))
            {
                handle = MessageSendIntPtr(handle, InitWithCharacters_lengthSelector.Handle, (IntPtr)((void*)value), str.Length);
                return handle;
            }
        }

        const string URLWithString = "URLWithString:";
        internal static readonly global::ThirdParty.iOS4Unity.Selector URLWithStringSelector =
            new global::ThirdParty.iOS4Unity.Selector(URLWithString);

        public static IntPtr ToNSUrl(string str)
        {
            //NOTE: NSURL is all caps
            return ObjC.MessageSendIntPtr(GetClass("NSURL"), URLWithStringSelector.Handle, str);
        }

        const string dateWithTimeIntervalSinceReferenceDate = "dateWithTimeIntervalSinceReferenceDate:";
        internal static readonly global::ThirdParty.iOS4Unity.Selector DateWithTimeIntervalSinceReferenceDateSelector =
            new global::ThirdParty.iOS4Unity.Selector(dateWithTimeIntervalSinceReferenceDate);


        public static IntPtr ToNSDate(DateTime date)
        {
            return ObjC.MessageSendIntPtr(GetClass("NSDate"), DateWithTimeIntervalSinceReferenceDateSelector.Handle, (double)((date.Ticks - 631139040000000000) / 10000000));
        }

        const string initWithDouble = "initWithDouble:";
        internal static readonly global::ThirdParty.iOS4Unity.Selector InitWithDoubleSelector =
            new global::ThirdParty.iOS4Unity.Selector(initWithDouble);

        public static IntPtr ToNSNumber(double value)
        {
            IntPtr handle = ObjC.MessageSendIntPtr(GetClass("NSDecimalNumber"), Selector.AllocHandle);
            return ObjC.MessageSendIntPtr(handle, InitWithDoubleSelector.Handle, value);
        }

        [DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
        public extern static void NSLog(IntPtr format, IntPtr args);

        public static void NSLog(string format, params object[] args)
        {
            var p1 = ToNSString("%@");
            var p2 = ToNSString(string.Format(format, args));
            NSLog(p1, p2);
        }
    }
}