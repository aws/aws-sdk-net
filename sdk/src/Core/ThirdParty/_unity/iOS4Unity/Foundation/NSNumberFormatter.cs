using System;

namespace ThirdParty.iOS4Unity
{
    public class NSNumberFormatter : NSObject
    {
        private static readonly IntPtr _classHandle;

        static NSNumberFormatter()
        {
            _classHandle = ObjC.GetClass("NSNumberFormatter");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public NSNumberFormatter()
        {
        }

        internal NSNumberFormatter(IntPtr handle)
            : base(handle)
        {
        }

        public NSNumberFormatterBehavior FormatterBehavior
        {
            get { return (NSNumberFormatterBehavior)(ObjC.MessageSendInt(Handle, Selector.GetHandle("formatterBehavior"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setFormatterBehavior:"), (int)value); }
        }

        public bool AllowsFloats
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("allowsFloats")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setAllowsFloats:"), value); }
        }

        public string CurrencyCode
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("currencyCode")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setCurrencyCode:"), value); }
        }

        public string CurrencyDecimalSeparator
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("currencyDecimalSeparator")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setCurrencyDecimalSeparator:"), value); }
        }

        public string CurrencyGroupingSeparator
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("currencyGroupingSeparator")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setCurrencyGroupingSeparator:"), value); }
        }

        public string CurrencySymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("currencySymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setCurrencySymbol:"), value); }
        }

        public string DecimalSeparator
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("decimalSeparator")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setDecimalSeparator:"), value); }
        }

        public static NSNumberFormatterBehavior DefaultFormatterBehavior
        {
            get { return (NSNumberFormatterBehavior)(ObjC.MessageSendInt(_classHandle, Selector.GetHandle("defaultFormatterBehavior"))); }
            set { ObjC.MessageSend(_classHandle, Selector.GetHandle("setDefaultFormatterBehavior:"), (int)value); }
        }

        public string ExponentSymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("exponentSymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setExponentSymbol:"), value); }
        }

        [CLSCompliant(false)]
        public uint FormatWidth
        {
            get { return (uint)ObjC.MessageSendUInt(Handle, Selector.GetHandle("formatWidth")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setFormatWidth:"), value); }
        }

        public bool GeneratesDecimalNumbers
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("generatesDecimalNumbers")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setGeneratesDecimalNumbers:"), value); }
        }

        public string GroupingSeparator
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("groupingSeparator")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setGroupingSeparator:"), value); }
        }

        public uint GroupingSize
        {
            get { return (uint)ObjC.MessageSendUInt(Handle, Selector.GetHandle("groupingSize")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setGroupingSize:"), value); }
        }

        public string InternationalCurrencySymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("internationalCurrencySymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setInternationalCurrencySymbol:"), value); }
        }

        public bool Lenient
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isLenient")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setLenient:"), value); }
        }

        public NSLocale Locale
        {
            get { return Runtime.GetNSObject<NSLocale>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("locale"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setLocale:"), value.Handle); }
        }

        public int MaximumFractionDigits
        {
            get { return ObjC.MessageSendInt(Handle, Selector.GetHandle("maximumFractionDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMaximumFractionDigits:"), value); }
        }

        public int MaximumIntegerDigits
        {
            get { return ObjC.MessageSendInt(Handle, Selector.GetHandle("maximumIntegerDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMaximumIntegerDigits:"), value); }
        }

        public uint MaximumSignificantDigits
        {
            get { return (uint)ObjC.MessageSendUInt(Handle, Selector.GetHandle("maximumSignificantDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMaximumSignificantDigits:"), value); }
        }

        public int MinimumFractionDigits
        {
            get { return ObjC.MessageSendInt(Handle, Selector.GetHandle("minimumFractionDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMinimumFractionDigits:"), value); }
        }

        public int MinimumIntegerDigits
        {
            get { return ObjC.MessageSendInt(Handle, Selector.GetHandle("minimumIntegerDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMinimumIntegerDigits:"), value); }
        }

        public uint MinimumSignificantDigits
        {
            get { return (uint)ObjC.MessageSendUInt(Handle, Selector.GetHandle("minimumSignificantDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMinimumSignificantDigits:"), value); }
        }

        public string MinusSign
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("minusSign")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setMinusSign:"), value); }
        }

        public string NegativeFormat
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("negativeFormat")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNegativeFormat:"), value); }
        }

        public string NegativeInfinitySymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("negativeInfinitySymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNegativeInfinitySymbol:"), value); }
        }

        public string NegativePrefix
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("negativePrefix")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNegativePrefix:"), value); }
        }

        public string NegativeSuffix
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("negativeSuffix")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNegativeSuffix:"), value); }
        }

        public string NilSymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("nilSymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNilSymbol:"), value); }
        }

        public string NotANumberSymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("notANumberSymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNotANumberSymbol:"), value); }
        }

        public NSNumberFormatterStyle NumberStyle
        {
            get { return (NSNumberFormatterStyle)(ObjC.MessageSendInt(Handle, Selector.GetHandle("numberStyle"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setNumberStyle:"), (int)value); }
        }

        public string PaddingCharacter
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("paddingCharacter")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPaddingCharacter:"), value); }
        }

        public NSNumberFormatterPadPosition PaddingPosition
        {
            get { return (NSNumberFormatterPadPosition)ObjC.MessageSendInt(Handle, Selector.GetHandle("paddingPosition")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPaddingPosition:"), (int)value); }
        }

        public bool PartialStringValidationEnabled
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isPartialStringValidationEnabled")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPartialStringValidationEnabled:"), value); }
        }

        public string PercentSymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("percentSymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPercentSymbol:"), value); }
        }

        public string PerMillSymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("perMillSymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPerMillSymbol:"), value); }
        }

        public string PlusSign
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("plusSign")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPlusSign:"), value); }
        }

        public string PositiveFormat
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("positiveFormat")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPositiveFormat:"), value); }
        }

        public string PositiveInfinitySymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("positiveInfinitySymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPositiveInfinitySymbol:"), value); }
        }

        public string PositivePrefix
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("positivePrefix")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPositivePrefix:"), value); }
        }

        public string PositiveSuffix
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("positiveSuffix")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPositiveSuffix:"), value); }
        }

        public NSNumberFormatterRoundingMode RoundingMode
        {
            get { return (NSNumberFormatterRoundingMode)ObjC.MessageSendInt(Handle, Selector.GetHandle("roundingMode")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setRoundingMode:"), (int)value); }
        }

        public uint SecondaryGroupingSize
        {
            get { return (uint)ObjC.MessageSendUInt(Handle, Selector.GetHandle("secondaryGroupingSize")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setSecondaryGroupingSize:"), value); }
        }

        public bool UsesGroupingSeparator
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("usesGroupingSeparator")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setUsesGroupingSeparator:"), value); }
        }

        public bool UsesSignificantDigits
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("usesSignificantDigits")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setUsesSignificantDigits:"), value); }
        }

        public string ZeroSymbol
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("zeroSymbol")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setZeroSymbol:"), value); }
        }

        public double NumberFromString(string text)
        {
            return ObjC.FromNSNumber(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("numberFromString:"), text));
        }

        public string StringFromNumber(double number)
        {
            IntPtr handle = ObjC.ToNSNumber(number);
            string text = ObjC.MessageSendString(Handle, Selector.GetHandle("stringFromNumber:"), handle);
            ObjC.MessageSend(handle, Selector.ReleaseHandle);
            return text;
        }

        public static string LocalizedStringFromNumber(double number, NSNumberFormatterStyle style)
        {
            IntPtr handle = ObjC.ToNSNumber(number);
            string text = ObjC.MessageSendString(_classHandle, Selector.GetHandle("localizedStringFromNumber:numberStyle:"), handle, (int)style);
            ObjC.MessageSend(handle, Selector.ReleaseHandle);
            return text;
        }
    }

    public enum NSNumberFormatterBehavior
    {
        Default,
        Version_10_0 = 1000,
        Version_10_4 = 1040
    }

    public enum NSNumberFormatterStyle
    {
        None,
        Decimal,
        Currency,
        Percent,
        Scientific,
        SpellOut
    }

    public enum NSNumberFormatterPadPosition
    {
        BeforePrefix,
        AfterPrefix,
        BeforeSuffix,
        AfterSuffix
    }

    public enum NSNumberFormatterRoundingMode
    {
        Ceiling,
        Floor,
        Down,
        Up,
        HalfEven,
        HalfDown,
        HalfUp
    }
}