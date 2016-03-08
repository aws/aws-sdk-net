using System;

namespace ThirdParty.iOS4Unity
{
    public class NSTimeZone : NSObject
    {
        private static readonly IntPtr _classHandle;

        static NSTimeZone()
        {
            _classHandle = ObjC.GetClass("NSTimeZone");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public NSTimeZone()
        {
            ObjC.MessageSendIntPtr(Handle, Selector.Init);
        }

        public NSTimeZone(string name)
        {
            Handle = ObjC.MessageSendIntPtr(Handle, Selector.InitWithName, name);
        }

        internal NSTimeZone(IntPtr handle)
            : base(handle)
        {
        }

        public string Abbreviation(DateTime date)
        {
            return ObjC.MessageSendString(Handle, Selector.GetHandle("abbreviationForDate:"), date);
        }

        public virtual string Abbreviation()
        {
            return ObjC.MessageSendString(Handle, Selector.GetHandle("abbreviation"));
        }

//        public double DaylightSavingTimeOffset(DateTime date)
//        {
//            return ObjC.MessageSendDouble(Handle, "daylightSavingTimeOffsetForDate:", date);
//        }

        public static NSTimeZone FromAbbreviation(string abbreviation)
        {
            return Runtime.GetNSObject<NSTimeZone>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("timeZoneWithAbbreviation:"), abbreviation));
        }

        public static NSTimeZone FromName(string name, NSData data)
        {
            return Runtime.GetNSObject<NSTimeZone>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("timeZoneWithName:data:"), name, data.Handle));
        }

        public static NSTimeZone FromName(string name)
        {
            return Runtime.GetNSObject<NSTimeZone>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("timeZoneWithName:"), name));
        }

        //NOTE: This crashes we can add later
//        public bool IsDaylightSavingsTime(DateTime date)
//        {
//            return ObjC.MessageSendBool(Handle, "isDaylightSavingTimeForDate:", date);
//        }

        public static string[] KnownTimeZoneNames
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("knownTimeZoneNames"))); }
        }

//        public DateTime NextDaylightSavingTimeTransitionAfter(DateTime date)
//        {
//            return (DateTime)ObjC.MessageSendDate(Handle, "nextDaylightSavingTimeTransitionAfterDate:", date);
//        }

        public static void ResetSystemTimeZone()
        {
            ObjC.MessageSend(_classHandle, Selector.GetHandle("resetSystemTimeZone"));
        }

        public int SecondsFromGMT(DateTime date)
        {
            return ObjC.MessageSendInt(Handle, Selector.GetHandle("secondsFromGMTForDate:"), date);
        }

        public static NSDictionary Abbreviations
        {
            get { return Runtime.GetNSObject<NSDictionary>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("abbreviationDictionary"))); }
        }

        public NSData Data
        {
            get { return Runtime.GetNSObject<NSData>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("data"))); }
        }

        public static string DataVersion
        {
            get { return ObjC.MessageSendString(_classHandle, Selector.GetHandle("timeZoneDataVersion")); }
        }

        public static NSTimeZone DefaultTimeZone
        {
            get { return Runtime.GetNSObject<NSTimeZone>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("defaultTimeZone"))); }
            set { ObjC.MessageSend(_classHandle, Selector.GetHandle("setDefaultTimeZone:"), value); }
        }

        public int GetSecondsFromGMT
        {
            get { return ObjC.MessageSendInt(Handle, Selector.GetHandle("secondsFromGMT")); }
        }

        public static NSTimeZone LocalTimeZone
        {
            get { return Runtime.GetNSObject<NSTimeZone>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("localTimeZone"))); }
        }

        public string Name
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("name")); }
        }

        public static NSTimeZone SystemTimeZone
        {
            get { return Runtime.GetNSObject<NSTimeZone>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("systemTimeZone"))); }
        }
    }
}