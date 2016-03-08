using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
    public class NSLocale : NSObject
    {
        private static readonly IntPtr _classHandle;

        static NSLocale()
        {
            _classHandle = ObjC.GetClass("NSLocale");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal NSLocale(IntPtr handle)
            : base(handle)
        {
        }

        public string AlternateQuotationBeginDelimiter
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleAlternateQuotationBeginDelimiterKey")); }
        }

        public string AlternateQuotationEndDelimiter
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleAlternateQuotationEndDelimiterKey")); }
        }

        public static NSLocale AutoUpdatingCurrentLocale
        {
            get { return Runtime.GetNSObject<NSLocale>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("autoupdatingCurrentLocale"))); }
        }

        public static string[] AvailableLocaleIdentifiers
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("availableLocaleIdentifiers"))); }
        }

        public string CollationIdentifier
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation,"NSLocaleCollationIdentifier")); }
        }

        public string CollatorIdentifier
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleCollatorIdentifier")); }
        }

        public static string[] CommonISOCurrencyCodes
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("commonISOCurrencyCodes"))); }
        }

        public string CountryCode
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleCountryCode")); }
        }

        public string CurrencyCode
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleCurrencyCode")); }
        }

        public string CurrencySymbol
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleCurrencySymbol")); }
        }

        public static NSLocale CurrentLocale
        {
            get
            {
                return Runtime.GetNSObject<NSLocale>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("currentLocale")));
            }
        }

        public static string CurrentLocaleDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSCurrentLocaleDidChangeNotification"); }
        }

        public string DecimalSeparator
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleDecimalSeparator")); }
        }

        public string GroupingSeparator
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleGroupingSeparator")); }
        }

        public string Identifier
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleIdentifier")); }
        }

        public static string[] ISOCountryCodes
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("ISOCountryCodes"))); }
        }

        public static string[] ISOCurrencyCodes
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("ISOCurrencyCodes"))); }
        }

        public static string[] ISOLanguageCodes
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("ISOLanguageCodes"))); }
        }

        public string LanguageCode
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleLanguageCode")); }
        }

        public string LocaleIdentifier
        {
            get { return ObjC.GetStringConstant(Handle, "localeIdentifier"); }
        }

        public string MeasurementSystem
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleMeasurementSystem")); }
        }

        public static string[] PreferredLanguages
        {
            get { return ObjC.FromNSArray(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("preferredLanguages"))); }
        }

        public string ScriptCode
        {
            get { return ObjectForKey(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleScriptCode")); }
        }

        public static NSLocale SystemLocale
        {
            get { return Runtime.GetNSObject<NSLocale>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("systemLocale"))); }
        }

        public bool UsesMetricSystem
        {
            get { return ObjectForKeyBool(ObjC.GetStringConstant(ObjC.Libraries.Foundation, "NSLocaleUsesMetricSystem")); }
        }

        private string ObjectForKey(string key)
        {
            return ObjC.FromNSString(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("objectForKey:"), ObjC.ToNSString(key)));
        }

        private bool ObjectForKeyBool(string key)
        {
            return ObjC.MessageSendBool(Handle, Selector.GetHandle("objectForKey:"), ObjC.ToNSString(key));
        }
    }
}