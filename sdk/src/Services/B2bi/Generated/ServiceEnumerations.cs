/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.B2bi
{

    /// <summary>
    /// Constants used for properties of type CapabilityDirection.
    /// </summary>
    public class CapabilityDirection : ConstantClass
    {

        /// <summary>
        /// Constant INBOUND for CapabilityDirection
        /// </summary>
        public static readonly CapabilityDirection INBOUND = new CapabilityDirection("INBOUND");
        /// <summary>
        /// Constant OUTBOUND for CapabilityDirection
        /// </summary>
        public static readonly CapabilityDirection OUTBOUND = new CapabilityDirection("OUTBOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapabilityDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapabilityDirection FindValue(string value)
        {
            return FindValue<CapabilityDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapabilityDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapabilityType.
    /// </summary>
    public class CapabilityType : ConstantClass
    {

        /// <summary>
        /// Constant Edi for CapabilityType
        /// </summary>
        public static readonly CapabilityType Edi = new CapabilityType("edi");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapabilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapabilityType FindValue(string value)
        {
            return FindValue<CapabilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapabilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversionSourceFormat.
    /// </summary>
    public class ConversionSourceFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for ConversionSourceFormat
        /// </summary>
        public static readonly ConversionSourceFormat JSON = new ConversionSourceFormat("JSON");
        /// <summary>
        /// Constant XML for ConversionSourceFormat
        /// </summary>
        public static readonly ConversionSourceFormat XML = new ConversionSourceFormat("XML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversionSourceFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversionSourceFormat FindValue(string value)
        {
            return FindValue<ConversionSourceFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversionSourceFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversionTargetFormat.
    /// </summary>
    public class ConversionTargetFormat : ConstantClass
    {

        /// <summary>
        /// Constant X12 for ConversionTargetFormat
        /// </summary>
        public static readonly ConversionTargetFormat X12 = new ConversionTargetFormat("X12");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversionTargetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversionTargetFormat FindValue(string value)
        {
            return FindValue<ConversionTargetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversionTargetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElementRequirement.
    /// </summary>
    public class ElementRequirement : ConstantClass
    {

        /// <summary>
        /// Constant MANDATORY for ElementRequirement
        /// </summary>
        public static readonly ElementRequirement MANDATORY = new ElementRequirement("MANDATORY");
        /// <summary>
        /// Constant OPTIONAL for ElementRequirement
        /// </summary>
        public static readonly ElementRequirement OPTIONAL = new ElementRequirement("OPTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElementRequirement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElementRequirement FindValue(string value)
        {
            return FindValue<ElementRequirement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElementRequirement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileFormat.
    /// </summary>
    public class FileFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for FileFormat
        /// </summary>
        public static readonly FileFormat JSON = new FileFormat("JSON");
        /// <summary>
        /// Constant NOT_USED for FileFormat
        /// </summary>
        public static readonly FileFormat NOT_USED = new FileFormat("NOT_USED");
        /// <summary>
        /// Constant XML for FileFormat
        /// </summary>
        public static readonly FileFormat XML = new FileFormat("XML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileFormat FindValue(string value)
        {
            return FindValue<FileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FromFormat.
    /// </summary>
    public class FromFormat : ConstantClass
    {

        /// <summary>
        /// Constant X12 for FromFormat
        /// </summary>
        public static readonly FromFormat X12 = new FromFormat("X12");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FromFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FromFormat FindValue(string value)
        {
            return FindValue<FromFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FromFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineTerminator.
    /// </summary>
    public class LineTerminator : ConstantClass
    {

        /// <summary>
        /// Constant CR for LineTerminator
        /// </summary>
        public static readonly LineTerminator CR = new LineTerminator("CR");
        /// <summary>
        /// Constant CRLF for LineTerminator
        /// </summary>
        public static readonly LineTerminator CRLF = new LineTerminator("CRLF");
        /// <summary>
        /// Constant LF for LineTerminator
        /// </summary>
        public static readonly LineTerminator LF = new LineTerminator("LF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineTerminator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineTerminator FindValue(string value)
        {
            return FindValue<LineTerminator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineTerminator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Logging.
    /// </summary>
    public class Logging : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Logging
        /// </summary>
        public static readonly Logging DISABLED = new Logging("DISABLED");
        /// <summary>
        /// Constant ENABLED for Logging
        /// </summary>
        public static readonly Logging ENABLED = new Logging("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Logging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Logging FindValue(string value)
        {
            return FindValue<Logging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Logging(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MappingTemplateLanguage.
    /// </summary>
    public class MappingTemplateLanguage : ConstantClass
    {

        /// <summary>
        /// Constant JSONATA for MappingTemplateLanguage
        /// </summary>
        public static readonly MappingTemplateLanguage JSONATA = new MappingTemplateLanguage("JSONATA");
        /// <summary>
        /// Constant XSLT for MappingTemplateLanguage
        /// </summary>
        public static readonly MappingTemplateLanguage XSLT = new MappingTemplateLanguage("XSLT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MappingTemplateLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MappingTemplateLanguage FindValue(string value)
        {
            return FindValue<MappingTemplateLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MappingTemplateLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MappingType.
    /// </summary>
    public class MappingType : ConstantClass
    {

        /// <summary>
        /// Constant JSONATA for MappingType
        /// </summary>
        public static readonly MappingType JSONATA = new MappingType("JSONATA");
        /// <summary>
        /// Constant XSLT for MappingType
        /// </summary>
        public static readonly MappingType XSLT = new MappingType("XSLT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MappingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MappingType FindValue(string value)
        {
            return FindValue<MappingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MappingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ToFormat.
    /// </summary>
    public class ToFormat : ConstantClass
    {

        /// <summary>
        /// Constant X12 for ToFormat
        /// </summary>
        public static readonly ToFormat X12 = new ToFormat("X12");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToFormat FindValue(string value)
        {
            return FindValue<ToFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformerJobStatus.
    /// </summary>
    public class TransformerJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for TransformerJobStatus
        /// </summary>
        public static readonly TransformerJobStatus Failed = new TransformerJobStatus("failed");
        /// <summary>
        /// Constant Running for TransformerJobStatus
        /// </summary>
        public static readonly TransformerJobStatus Running = new TransformerJobStatus("running");
        /// <summary>
        /// Constant Succeeded for TransformerJobStatus
        /// </summary>
        public static readonly TransformerJobStatus Succeeded = new TransformerJobStatus("succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformerJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformerJobStatus FindValue(string value)
        {
            return FindValue<TransformerJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformerJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformerStatus.
    /// </summary>
    public class TransformerStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for TransformerStatus
        /// </summary>
        public static readonly TransformerStatus Active = new TransformerStatus("active");
        /// <summary>
        /// Constant Inactive for TransformerStatus
        /// </summary>
        public static readonly TransformerStatus Inactive = new TransformerStatus("inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformerStatus FindValue(string value)
        {
            return FindValue<TransformerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WrapFormat.
    /// </summary>
    public class WrapFormat : ConstantClass
    {

        /// <summary>
        /// Constant LINE_LENGTH for WrapFormat
        /// </summary>
        public static readonly WrapFormat LINE_LENGTH = new WrapFormat("LINE_LENGTH");
        /// <summary>
        /// Constant ONE_LINE for WrapFormat
        /// </summary>
        public static readonly WrapFormat ONE_LINE = new WrapFormat("ONE_LINE");
        /// <summary>
        /// Constant SEGMENT for WrapFormat
        /// </summary>
        public static readonly WrapFormat SEGMENT = new WrapFormat("SEGMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WrapFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WrapFormat FindValue(string value)
        {
            return FindValue<WrapFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WrapFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12FunctionalAcknowledgment.
    /// </summary>
    public class X12FunctionalAcknowledgment : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOT_GENERATE for X12FunctionalAcknowledgment
        /// </summary>
        public static readonly X12FunctionalAcknowledgment DO_NOT_GENERATE = new X12FunctionalAcknowledgment("DO_NOT_GENERATE");
        /// <summary>
        /// Constant GENERATE_ALL_SEGMENTS for X12FunctionalAcknowledgment
        /// </summary>
        public static readonly X12FunctionalAcknowledgment GENERATE_ALL_SEGMENTS = new X12FunctionalAcknowledgment("GENERATE_ALL_SEGMENTS");
        /// <summary>
        /// Constant GENERATE_WITHOUT_TRANSACTION_SET_RESPONSE_LOOP for X12FunctionalAcknowledgment
        /// </summary>
        public static readonly X12FunctionalAcknowledgment GENERATE_WITHOUT_TRANSACTION_SET_RESPONSE_LOOP = new X12FunctionalAcknowledgment("GENERATE_WITHOUT_TRANSACTION_SET_RESPONSE_LOOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12FunctionalAcknowledgment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12FunctionalAcknowledgment FindValue(string value)
        {
            return FindValue<X12FunctionalAcknowledgment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12FunctionalAcknowledgment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12GS05TimeFormat.
    /// </summary>
    public class X12GS05TimeFormat : ConstantClass
    {

        /// <summary>
        /// Constant HHMM for X12GS05TimeFormat
        /// </summary>
        public static readonly X12GS05TimeFormat HHMM = new X12GS05TimeFormat("HHMM");
        /// <summary>
        /// Constant HHMMSS for X12GS05TimeFormat
        /// </summary>
        public static readonly X12GS05TimeFormat HHMMSS = new X12GS05TimeFormat("HHMMSS");
        /// <summary>
        /// Constant HHMMSSDD for X12GS05TimeFormat
        /// </summary>
        public static readonly X12GS05TimeFormat HHMMSSDD = new X12GS05TimeFormat("HHMMSSDD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12GS05TimeFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12GS05TimeFormat FindValue(string value)
        {
            return FindValue<X12GS05TimeFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12GS05TimeFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12SplitBy.
    /// </summary>
    public class X12SplitBy : ConstantClass
    {

        /// <summary>
        /// Constant NONE for X12SplitBy
        /// </summary>
        public static readonly X12SplitBy NONE = new X12SplitBy("NONE");
        /// <summary>
        /// Constant TRANSACTION for X12SplitBy
        /// </summary>
        public static readonly X12SplitBy TRANSACTION = new X12SplitBy("TRANSACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12SplitBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12SplitBy FindValue(string value)
        {
            return FindValue<X12SplitBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12SplitBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12TechnicalAcknowledgment.
    /// </summary>
    public class X12TechnicalAcknowledgment : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOT_GENERATE for X12TechnicalAcknowledgment
        /// </summary>
        public static readonly X12TechnicalAcknowledgment DO_NOT_GENERATE = new X12TechnicalAcknowledgment("DO_NOT_GENERATE");
        /// <summary>
        /// Constant GENERATE_ALL_SEGMENTS for X12TechnicalAcknowledgment
        /// </summary>
        public static readonly X12TechnicalAcknowledgment GENERATE_ALL_SEGMENTS = new X12TechnicalAcknowledgment("GENERATE_ALL_SEGMENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12TechnicalAcknowledgment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12TechnicalAcknowledgment FindValue(string value)
        {
            return FindValue<X12TechnicalAcknowledgment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12TechnicalAcknowledgment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12TransactionSet.
    /// </summary>
    public class X12TransactionSet : ConstantClass
    {

        /// <summary>
        /// Constant X12_100 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_100 = new X12TransactionSet("X12_100");
        /// <summary>
        /// Constant X12_101 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_101 = new X12TransactionSet("X12_101");
        /// <summary>
        /// Constant X12_102 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_102 = new X12TransactionSet("X12_102");
        /// <summary>
        /// Constant X12_103 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_103 = new X12TransactionSet("X12_103");
        /// <summary>
        /// Constant X12_104 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_104 = new X12TransactionSet("X12_104");
        /// <summary>
        /// Constant X12_105 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_105 = new X12TransactionSet("X12_105");
        /// <summary>
        /// Constant X12_106 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_106 = new X12TransactionSet("X12_106");
        /// <summary>
        /// Constant X12_107 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_107 = new X12TransactionSet("X12_107");
        /// <summary>
        /// Constant X12_108 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_108 = new X12TransactionSet("X12_108");
        /// <summary>
        /// Constant X12_109 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_109 = new X12TransactionSet("X12_109");
        /// <summary>
        /// Constant X12_110 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_110 = new X12TransactionSet("X12_110");
        /// <summary>
        /// Constant X12_111 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_111 = new X12TransactionSet("X12_111");
        /// <summary>
        /// Constant X12_112 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_112 = new X12TransactionSet("X12_112");
        /// <summary>
        /// Constant X12_113 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_113 = new X12TransactionSet("X12_113");
        /// <summary>
        /// Constant X12_120 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_120 = new X12TransactionSet("X12_120");
        /// <summary>
        /// Constant X12_121 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_121 = new X12TransactionSet("X12_121");
        /// <summary>
        /// Constant X12_124 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_124 = new X12TransactionSet("X12_124");
        /// <summary>
        /// Constant X12_125 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_125 = new X12TransactionSet("X12_125");
        /// <summary>
        /// Constant X12_126 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_126 = new X12TransactionSet("X12_126");
        /// <summary>
        /// Constant X12_127 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_127 = new X12TransactionSet("X12_127");
        /// <summary>
        /// Constant X12_128 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_128 = new X12TransactionSet("X12_128");
        /// <summary>
        /// Constant X12_129 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_129 = new X12TransactionSet("X12_129");
        /// <summary>
        /// Constant X12_130 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_130 = new X12TransactionSet("X12_130");
        /// <summary>
        /// Constant X12_131 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_131 = new X12TransactionSet("X12_131");
        /// <summary>
        /// Constant X12_132 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_132 = new X12TransactionSet("X12_132");
        /// <summary>
        /// Constant X12_133 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_133 = new X12TransactionSet("X12_133");
        /// <summary>
        /// Constant X12_135 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_135 = new X12TransactionSet("X12_135");
        /// <summary>
        /// Constant X12_138 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_138 = new X12TransactionSet("X12_138");
        /// <summary>
        /// Constant X12_139 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_139 = new X12TransactionSet("X12_139");
        /// <summary>
        /// Constant X12_140 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_140 = new X12TransactionSet("X12_140");
        /// <summary>
        /// Constant X12_141 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_141 = new X12TransactionSet("X12_141");
        /// <summary>
        /// Constant X12_142 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_142 = new X12TransactionSet("X12_142");
        /// <summary>
        /// Constant X12_143 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_143 = new X12TransactionSet("X12_143");
        /// <summary>
        /// Constant X12_144 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_144 = new X12TransactionSet("X12_144");
        /// <summary>
        /// Constant X12_146 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_146 = new X12TransactionSet("X12_146");
        /// <summary>
        /// Constant X12_147 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_147 = new X12TransactionSet("X12_147");
        /// <summary>
        /// Constant X12_148 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_148 = new X12TransactionSet("X12_148");
        /// <summary>
        /// Constant X12_149 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_149 = new X12TransactionSet("X12_149");
        /// <summary>
        /// Constant X12_150 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_150 = new X12TransactionSet("X12_150");
        /// <summary>
        /// Constant X12_151 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_151 = new X12TransactionSet("X12_151");
        /// <summary>
        /// Constant X12_152 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_152 = new X12TransactionSet("X12_152");
        /// <summary>
        /// Constant X12_153 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_153 = new X12TransactionSet("X12_153");
        /// <summary>
        /// Constant X12_154 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_154 = new X12TransactionSet("X12_154");
        /// <summary>
        /// Constant X12_155 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_155 = new X12TransactionSet("X12_155");
        /// <summary>
        /// Constant X12_157 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_157 = new X12TransactionSet("X12_157");
        /// <summary>
        /// Constant X12_158 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_158 = new X12TransactionSet("X12_158");
        /// <summary>
        /// Constant X12_159 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_159 = new X12TransactionSet("X12_159");
        /// <summary>
        /// Constant X12_160 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_160 = new X12TransactionSet("X12_160");
        /// <summary>
        /// Constant X12_161 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_161 = new X12TransactionSet("X12_161");
        /// <summary>
        /// Constant X12_163 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_163 = new X12TransactionSet("X12_163");
        /// <summary>
        /// Constant X12_170 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_170 = new X12TransactionSet("X12_170");
        /// <summary>
        /// Constant X12_175 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_175 = new X12TransactionSet("X12_175");
        /// <summary>
        /// Constant X12_176 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_176 = new X12TransactionSet("X12_176");
        /// <summary>
        /// Constant X12_179 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_179 = new X12TransactionSet("X12_179");
        /// <summary>
        /// Constant X12_180 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_180 = new X12TransactionSet("X12_180");
        /// <summary>
        /// Constant X12_185 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_185 = new X12TransactionSet("X12_185");
        /// <summary>
        /// Constant X12_186 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_186 = new X12TransactionSet("X12_186");
        /// <summary>
        /// Constant X12_187 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_187 = new X12TransactionSet("X12_187");
        /// <summary>
        /// Constant X12_188 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_188 = new X12TransactionSet("X12_188");
        /// <summary>
        /// Constant X12_189 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_189 = new X12TransactionSet("X12_189");
        /// <summary>
        /// Constant X12_190 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_190 = new X12TransactionSet("X12_190");
        /// <summary>
        /// Constant X12_191 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_191 = new X12TransactionSet("X12_191");
        /// <summary>
        /// Constant X12_194 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_194 = new X12TransactionSet("X12_194");
        /// <summary>
        /// Constant X12_195 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_195 = new X12TransactionSet("X12_195");
        /// <summary>
        /// Constant X12_196 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_196 = new X12TransactionSet("X12_196");
        /// <summary>
        /// Constant X12_197 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_197 = new X12TransactionSet("X12_197");
        /// <summary>
        /// Constant X12_198 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_198 = new X12TransactionSet("X12_198");
        /// <summary>
        /// Constant X12_199 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_199 = new X12TransactionSet("X12_199");
        /// <summary>
        /// Constant X12_200 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_200 = new X12TransactionSet("X12_200");
        /// <summary>
        /// Constant X12_201 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_201 = new X12TransactionSet("X12_201");
        /// <summary>
        /// Constant X12_202 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_202 = new X12TransactionSet("X12_202");
        /// <summary>
        /// Constant X12_203 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_203 = new X12TransactionSet("X12_203");
        /// <summary>
        /// Constant X12_204 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_204 = new X12TransactionSet("X12_204");
        /// <summary>
        /// Constant X12_205 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_205 = new X12TransactionSet("X12_205");
        /// <summary>
        /// Constant X12_206 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_206 = new X12TransactionSet("X12_206");
        /// <summary>
        /// Constant X12_210 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_210 = new X12TransactionSet("X12_210");
        /// <summary>
        /// Constant X12_211 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_211 = new X12TransactionSet("X12_211");
        /// <summary>
        /// Constant X12_212 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_212 = new X12TransactionSet("X12_212");
        /// <summary>
        /// Constant X12_213 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_213 = new X12TransactionSet("X12_213");
        /// <summary>
        /// Constant X12_214 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_214 = new X12TransactionSet("X12_214");
        /// <summary>
        /// Constant X12_215 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_215 = new X12TransactionSet("X12_215");
        /// <summary>
        /// Constant X12_216 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_216 = new X12TransactionSet("X12_216");
        /// <summary>
        /// Constant X12_217 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_217 = new X12TransactionSet("X12_217");
        /// <summary>
        /// Constant X12_218 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_218 = new X12TransactionSet("X12_218");
        /// <summary>
        /// Constant X12_219 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_219 = new X12TransactionSet("X12_219");
        /// <summary>
        /// Constant X12_220 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_220 = new X12TransactionSet("X12_220");
        /// <summary>
        /// Constant X12_222 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_222 = new X12TransactionSet("X12_222");
        /// <summary>
        /// Constant X12_223 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_223 = new X12TransactionSet("X12_223");
        /// <summary>
        /// Constant X12_224 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_224 = new X12TransactionSet("X12_224");
        /// <summary>
        /// Constant X12_225 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_225 = new X12TransactionSet("X12_225");
        /// <summary>
        /// Constant X12_227 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_227 = new X12TransactionSet("X12_227");
        /// <summary>
        /// Constant X12_228 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_228 = new X12TransactionSet("X12_228");
        /// <summary>
        /// Constant X12_240 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_240 = new X12TransactionSet("X12_240");
        /// <summary>
        /// Constant X12_242 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_242 = new X12TransactionSet("X12_242");
        /// <summary>
        /// Constant X12_244 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_244 = new X12TransactionSet("X12_244");
        /// <summary>
        /// Constant X12_245 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_245 = new X12TransactionSet("X12_245");
        /// <summary>
        /// Constant X12_248 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_248 = new X12TransactionSet("X12_248");
        /// <summary>
        /// Constant X12_249 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_249 = new X12TransactionSet("X12_249");
        /// <summary>
        /// Constant X12_250 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_250 = new X12TransactionSet("X12_250");
        /// <summary>
        /// Constant X12_251 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_251 = new X12TransactionSet("X12_251");
        /// <summary>
        /// Constant X12_252 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_252 = new X12TransactionSet("X12_252");
        /// <summary>
        /// Constant X12_255 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_255 = new X12TransactionSet("X12_255");
        /// <summary>
        /// Constant X12_256 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_256 = new X12TransactionSet("X12_256");
        /// <summary>
        /// Constant X12_259 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_259 = new X12TransactionSet("X12_259");
        /// <summary>
        /// Constant X12_260 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_260 = new X12TransactionSet("X12_260");
        /// <summary>
        /// Constant X12_261 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_261 = new X12TransactionSet("X12_261");
        /// <summary>
        /// Constant X12_262 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_262 = new X12TransactionSet("X12_262");
        /// <summary>
        /// Constant X12_263 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_263 = new X12TransactionSet("X12_263");
        /// <summary>
        /// Constant X12_264 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_264 = new X12TransactionSet("X12_264");
        /// <summary>
        /// Constant X12_265 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_265 = new X12TransactionSet("X12_265");
        /// <summary>
        /// Constant X12_266 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_266 = new X12TransactionSet("X12_266");
        /// <summary>
        /// Constant X12_267 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_267 = new X12TransactionSet("X12_267");
        /// <summary>
        /// Constant X12_268 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_268 = new X12TransactionSet("X12_268");
        /// <summary>
        /// Constant X12_269 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_269 = new X12TransactionSet("X12_269");
        /// <summary>
        /// Constant X12_270 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_270 = new X12TransactionSet("X12_270");
        /// <summary>
        /// Constant X12_270_X279 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_270_X279 = new X12TransactionSet("X12_270_X279");
        /// <summary>
        /// Constant X12_271 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_271 = new X12TransactionSet("X12_271");
        /// <summary>
        /// Constant X12_271_X279 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_271_X279 = new X12TransactionSet("X12_271_X279");
        /// <summary>
        /// Constant X12_272 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_272 = new X12TransactionSet("X12_272");
        /// <summary>
        /// Constant X12_273 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_273 = new X12TransactionSet("X12_273");
        /// <summary>
        /// Constant X12_274 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_274 = new X12TransactionSet("X12_274");
        /// <summary>
        /// Constant X12_275 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_275 = new X12TransactionSet("X12_275");
        /// <summary>
        /// Constant X12_275_X210 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_275_X210 = new X12TransactionSet("X12_275_X210");
        /// <summary>
        /// Constant X12_275_X211 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_275_X211 = new X12TransactionSet("X12_275_X211");
        /// <summary>
        /// Constant X12_276 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_276 = new X12TransactionSet("X12_276");
        /// <summary>
        /// Constant X12_276_X212 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_276_X212 = new X12TransactionSet("X12_276_X212");
        /// <summary>
        /// Constant X12_277 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_277 = new X12TransactionSet("X12_277");
        /// <summary>
        /// Constant X12_277_X212 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_277_X212 = new X12TransactionSet("X12_277_X212");
        /// <summary>
        /// Constant X12_277_X214 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_277_X214 = new X12TransactionSet("X12_277_X214");
        /// <summary>
        /// Constant X12_277_X364 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_277_X364 = new X12TransactionSet("X12_277_X364");
        /// <summary>
        /// Constant X12_278 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_278 = new X12TransactionSet("X12_278");
        /// <summary>
        /// Constant X12_278_X217 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_278_X217 = new X12TransactionSet("X12_278_X217");
        /// <summary>
        /// Constant X12_280 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_280 = new X12TransactionSet("X12_280");
        /// <summary>
        /// Constant X12_283 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_283 = new X12TransactionSet("X12_283");
        /// <summary>
        /// Constant X12_284 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_284 = new X12TransactionSet("X12_284");
        /// <summary>
        /// Constant X12_285 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_285 = new X12TransactionSet("X12_285");
        /// <summary>
        /// Constant X12_286 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_286 = new X12TransactionSet("X12_286");
        /// <summary>
        /// Constant X12_288 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_288 = new X12TransactionSet("X12_288");
        /// <summary>
        /// Constant X12_290 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_290 = new X12TransactionSet("X12_290");
        /// <summary>
        /// Constant X12_300 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_300 = new X12TransactionSet("X12_300");
        /// <summary>
        /// Constant X12_301 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_301 = new X12TransactionSet("X12_301");
        /// <summary>
        /// Constant X12_303 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_303 = new X12TransactionSet("X12_303");
        /// <summary>
        /// Constant X12_304 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_304 = new X12TransactionSet("X12_304");
        /// <summary>
        /// Constant X12_309 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_309 = new X12TransactionSet("X12_309");
        /// <summary>
        /// Constant X12_310 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_310 = new X12TransactionSet("X12_310");
        /// <summary>
        /// Constant X12_311 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_311 = new X12TransactionSet("X12_311");
        /// <summary>
        /// Constant X12_312 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_312 = new X12TransactionSet("X12_312");
        /// <summary>
        /// Constant X12_313 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_313 = new X12TransactionSet("X12_313");
        /// <summary>
        /// Constant X12_315 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_315 = new X12TransactionSet("X12_315");
        /// <summary>
        /// Constant X12_317 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_317 = new X12TransactionSet("X12_317");
        /// <summary>
        /// Constant X12_319 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_319 = new X12TransactionSet("X12_319");
        /// <summary>
        /// Constant X12_322 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_322 = new X12TransactionSet("X12_322");
        /// <summary>
        /// Constant X12_323 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_323 = new X12TransactionSet("X12_323");
        /// <summary>
        /// Constant X12_324 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_324 = new X12TransactionSet("X12_324");
        /// <summary>
        /// Constant X12_325 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_325 = new X12TransactionSet("X12_325");
        /// <summary>
        /// Constant X12_326 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_326 = new X12TransactionSet("X12_326");
        /// <summary>
        /// Constant X12_350 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_350 = new X12TransactionSet("X12_350");
        /// <summary>
        /// Constant X12_352 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_352 = new X12TransactionSet("X12_352");
        /// <summary>
        /// Constant X12_353 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_353 = new X12TransactionSet("X12_353");
        /// <summary>
        /// Constant X12_354 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_354 = new X12TransactionSet("X12_354");
        /// <summary>
        /// Constant X12_355 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_355 = new X12TransactionSet("X12_355");
        /// <summary>
        /// Constant X12_356 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_356 = new X12TransactionSet("X12_356");
        /// <summary>
        /// Constant X12_357 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_357 = new X12TransactionSet("X12_357");
        /// <summary>
        /// Constant X12_358 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_358 = new X12TransactionSet("X12_358");
        /// <summary>
        /// Constant X12_361 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_361 = new X12TransactionSet("X12_361");
        /// <summary>
        /// Constant X12_362 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_362 = new X12TransactionSet("X12_362");
        /// <summary>
        /// Constant X12_404 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_404 = new X12TransactionSet("X12_404");
        /// <summary>
        /// Constant X12_410 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_410 = new X12TransactionSet("X12_410");
        /// <summary>
        /// Constant X12_412 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_412 = new X12TransactionSet("X12_412");
        /// <summary>
        /// Constant X12_414 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_414 = new X12TransactionSet("X12_414");
        /// <summary>
        /// Constant X12_417 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_417 = new X12TransactionSet("X12_417");
        /// <summary>
        /// Constant X12_418 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_418 = new X12TransactionSet("X12_418");
        /// <summary>
        /// Constant X12_419 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_419 = new X12TransactionSet("X12_419");
        /// <summary>
        /// Constant X12_420 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_420 = new X12TransactionSet("X12_420");
        /// <summary>
        /// Constant X12_421 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_421 = new X12TransactionSet("X12_421");
        /// <summary>
        /// Constant X12_422 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_422 = new X12TransactionSet("X12_422");
        /// <summary>
        /// Constant X12_423 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_423 = new X12TransactionSet("X12_423");
        /// <summary>
        /// Constant X12_424 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_424 = new X12TransactionSet("X12_424");
        /// <summary>
        /// Constant X12_425 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_425 = new X12TransactionSet("X12_425");
        /// <summary>
        /// Constant X12_426 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_426 = new X12TransactionSet("X12_426");
        /// <summary>
        /// Constant X12_429 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_429 = new X12TransactionSet("X12_429");
        /// <summary>
        /// Constant X12_431 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_431 = new X12TransactionSet("X12_431");
        /// <summary>
        /// Constant X12_432 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_432 = new X12TransactionSet("X12_432");
        /// <summary>
        /// Constant X12_433 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_433 = new X12TransactionSet("X12_433");
        /// <summary>
        /// Constant X12_434 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_434 = new X12TransactionSet("X12_434");
        /// <summary>
        /// Constant X12_435 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_435 = new X12TransactionSet("X12_435");
        /// <summary>
        /// Constant X12_436 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_436 = new X12TransactionSet("X12_436");
        /// <summary>
        /// Constant X12_437 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_437 = new X12TransactionSet("X12_437");
        /// <summary>
        /// Constant X12_440 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_440 = new X12TransactionSet("X12_440");
        /// <summary>
        /// Constant X12_451 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_451 = new X12TransactionSet("X12_451");
        /// <summary>
        /// Constant X12_452 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_452 = new X12TransactionSet("X12_452");
        /// <summary>
        /// Constant X12_453 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_453 = new X12TransactionSet("X12_453");
        /// <summary>
        /// Constant X12_455 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_455 = new X12TransactionSet("X12_455");
        /// <summary>
        /// Constant X12_456 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_456 = new X12TransactionSet("X12_456");
        /// <summary>
        /// Constant X12_460 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_460 = new X12TransactionSet("X12_460");
        /// <summary>
        /// Constant X12_463 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_463 = new X12TransactionSet("X12_463");
        /// <summary>
        /// Constant X12_466 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_466 = new X12TransactionSet("X12_466");
        /// <summary>
        /// Constant X12_468 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_468 = new X12TransactionSet("X12_468");
        /// <summary>
        /// Constant X12_470 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_470 = new X12TransactionSet("X12_470");
        /// <summary>
        /// Constant X12_475 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_475 = new X12TransactionSet("X12_475");
        /// <summary>
        /// Constant X12_485 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_485 = new X12TransactionSet("X12_485");
        /// <summary>
        /// Constant X12_486 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_486 = new X12TransactionSet("X12_486");
        /// <summary>
        /// Constant X12_490 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_490 = new X12TransactionSet("X12_490");
        /// <summary>
        /// Constant X12_492 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_492 = new X12TransactionSet("X12_492");
        /// <summary>
        /// Constant X12_494 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_494 = new X12TransactionSet("X12_494");
        /// <summary>
        /// Constant X12_500 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_500 = new X12TransactionSet("X12_500");
        /// <summary>
        /// Constant X12_501 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_501 = new X12TransactionSet("X12_501");
        /// <summary>
        /// Constant X12_503 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_503 = new X12TransactionSet("X12_503");
        /// <summary>
        /// Constant X12_504 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_504 = new X12TransactionSet("X12_504");
        /// <summary>
        /// Constant X12_511 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_511 = new X12TransactionSet("X12_511");
        /// <summary>
        /// Constant X12_517 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_517 = new X12TransactionSet("X12_517");
        /// <summary>
        /// Constant X12_521 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_521 = new X12TransactionSet("X12_521");
        /// <summary>
        /// Constant X12_527 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_527 = new X12TransactionSet("X12_527");
        /// <summary>
        /// Constant X12_536 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_536 = new X12TransactionSet("X12_536");
        /// <summary>
        /// Constant X12_540 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_540 = new X12TransactionSet("X12_540");
        /// <summary>
        /// Constant X12_561 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_561 = new X12TransactionSet("X12_561");
        /// <summary>
        /// Constant X12_567 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_567 = new X12TransactionSet("X12_567");
        /// <summary>
        /// Constant X12_568 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_568 = new X12TransactionSet("X12_568");
        /// <summary>
        /// Constant X12_601 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_601 = new X12TransactionSet("X12_601");
        /// <summary>
        /// Constant X12_602 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_602 = new X12TransactionSet("X12_602");
        /// <summary>
        /// Constant X12_620 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_620 = new X12TransactionSet("X12_620");
        /// <summary>
        /// Constant X12_625 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_625 = new X12TransactionSet("X12_625");
        /// <summary>
        /// Constant X12_650 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_650 = new X12TransactionSet("X12_650");
        /// <summary>
        /// Constant X12_715 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_715 = new X12TransactionSet("X12_715");
        /// <summary>
        /// Constant X12_753 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_753 = new X12TransactionSet("X12_753");
        /// <summary>
        /// Constant X12_754 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_754 = new X12TransactionSet("X12_754");
        /// <summary>
        /// Constant X12_805 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_805 = new X12TransactionSet("X12_805");
        /// <summary>
        /// Constant X12_806 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_806 = new X12TransactionSet("X12_806");
        /// <summary>
        /// Constant X12_810 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_810 = new X12TransactionSet("X12_810");
        /// <summary>
        /// Constant X12_811 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_811 = new X12TransactionSet("X12_811");
        /// <summary>
        /// Constant X12_812 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_812 = new X12TransactionSet("X12_812");
        /// <summary>
        /// Constant X12_813 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_813 = new X12TransactionSet("X12_813");
        /// <summary>
        /// Constant X12_814 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_814 = new X12TransactionSet("X12_814");
        /// <summary>
        /// Constant X12_815 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_815 = new X12TransactionSet("X12_815");
        /// <summary>
        /// Constant X12_816 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_816 = new X12TransactionSet("X12_816");
        /// <summary>
        /// Constant X12_818 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_818 = new X12TransactionSet("X12_818");
        /// <summary>
        /// Constant X12_819 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_819 = new X12TransactionSet("X12_819");
        /// <summary>
        /// Constant X12_820 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_820 = new X12TransactionSet("X12_820");
        /// <summary>
        /// Constant X12_820_X218 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_820_X218 = new X12TransactionSet("X12_820_X218");
        /// <summary>
        /// Constant X12_820_X306 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_820_X306 = new X12TransactionSet("X12_820_X306");
        /// <summary>
        /// Constant X12_821 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_821 = new X12TransactionSet("X12_821");
        /// <summary>
        /// Constant X12_822 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_822 = new X12TransactionSet("X12_822");
        /// <summary>
        /// Constant X12_823 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_823 = new X12TransactionSet("X12_823");
        /// <summary>
        /// Constant X12_824 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_824 = new X12TransactionSet("X12_824");
        /// <summary>
        /// Constant X12_824_X186 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_824_X186 = new X12TransactionSet("X12_824_X186");
        /// <summary>
        /// Constant X12_826 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_826 = new X12TransactionSet("X12_826");
        /// <summary>
        /// Constant X12_827 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_827 = new X12TransactionSet("X12_827");
        /// <summary>
        /// Constant X12_828 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_828 = new X12TransactionSet("X12_828");
        /// <summary>
        /// Constant X12_829 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_829 = new X12TransactionSet("X12_829");
        /// <summary>
        /// Constant X12_830 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_830 = new X12TransactionSet("X12_830");
        /// <summary>
        /// Constant X12_831 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_831 = new X12TransactionSet("X12_831");
        /// <summary>
        /// Constant X12_832 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_832 = new X12TransactionSet("X12_832");
        /// <summary>
        /// Constant X12_833 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_833 = new X12TransactionSet("X12_833");
        /// <summary>
        /// Constant X12_834 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_834 = new X12TransactionSet("X12_834");
        /// <summary>
        /// Constant X12_834_X220 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_834_X220 = new X12TransactionSet("X12_834_X220");
        /// <summary>
        /// Constant X12_834_X307 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_834_X307 = new X12TransactionSet("X12_834_X307");
        /// <summary>
        /// Constant X12_834_X318 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_834_X318 = new X12TransactionSet("X12_834_X318");
        /// <summary>
        /// Constant X12_835 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_835 = new X12TransactionSet("X12_835");
        /// <summary>
        /// Constant X12_835_X221 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_835_X221 = new X12TransactionSet("X12_835_X221");
        /// <summary>
        /// Constant X12_836 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_836 = new X12TransactionSet("X12_836");
        /// <summary>
        /// Constant X12_837 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837 = new X12TransactionSet("X12_837");
        /// <summary>
        /// Constant X12_837_X222 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837_X222 = new X12TransactionSet("X12_837_X222");
        /// <summary>
        /// Constant X12_837_X223 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837_X223 = new X12TransactionSet("X12_837_X223");
        /// <summary>
        /// Constant X12_837_X224 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837_X224 = new X12TransactionSet("X12_837_X224");
        /// <summary>
        /// Constant X12_837_X291 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837_X291 = new X12TransactionSet("X12_837_X291");
        /// <summary>
        /// Constant X12_837_X292 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837_X292 = new X12TransactionSet("X12_837_X292");
        /// <summary>
        /// Constant X12_837_X298 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_837_X298 = new X12TransactionSet("X12_837_X298");
        /// <summary>
        /// Constant X12_838 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_838 = new X12TransactionSet("X12_838");
        /// <summary>
        /// Constant X12_839 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_839 = new X12TransactionSet("X12_839");
        /// <summary>
        /// Constant X12_840 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_840 = new X12TransactionSet("X12_840");
        /// <summary>
        /// Constant X12_841 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_841 = new X12TransactionSet("X12_841");
        /// <summary>
        /// Constant X12_842 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_842 = new X12TransactionSet("X12_842");
        /// <summary>
        /// Constant X12_843 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_843 = new X12TransactionSet("X12_843");
        /// <summary>
        /// Constant X12_844 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_844 = new X12TransactionSet("X12_844");
        /// <summary>
        /// Constant X12_845 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_845 = new X12TransactionSet("X12_845");
        /// <summary>
        /// Constant X12_846 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_846 = new X12TransactionSet("X12_846");
        /// <summary>
        /// Constant X12_847 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_847 = new X12TransactionSet("X12_847");
        /// <summary>
        /// Constant X12_848 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_848 = new X12TransactionSet("X12_848");
        /// <summary>
        /// Constant X12_849 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_849 = new X12TransactionSet("X12_849");
        /// <summary>
        /// Constant X12_850 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_850 = new X12TransactionSet("X12_850");
        /// <summary>
        /// Constant X12_851 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_851 = new X12TransactionSet("X12_851");
        /// <summary>
        /// Constant X12_852 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_852 = new X12TransactionSet("X12_852");
        /// <summary>
        /// Constant X12_853 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_853 = new X12TransactionSet("X12_853");
        /// <summary>
        /// Constant X12_854 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_854 = new X12TransactionSet("X12_854");
        /// <summary>
        /// Constant X12_855 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_855 = new X12TransactionSet("X12_855");
        /// <summary>
        /// Constant X12_856 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_856 = new X12TransactionSet("X12_856");
        /// <summary>
        /// Constant X12_857 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_857 = new X12TransactionSet("X12_857");
        /// <summary>
        /// Constant X12_858 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_858 = new X12TransactionSet("X12_858");
        /// <summary>
        /// Constant X12_859 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_859 = new X12TransactionSet("X12_859");
        /// <summary>
        /// Constant X12_860 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_860 = new X12TransactionSet("X12_860");
        /// <summary>
        /// Constant X12_861 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_861 = new X12TransactionSet("X12_861");
        /// <summary>
        /// Constant X12_862 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_862 = new X12TransactionSet("X12_862");
        /// <summary>
        /// Constant X12_863 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_863 = new X12TransactionSet("X12_863");
        /// <summary>
        /// Constant X12_864 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_864 = new X12TransactionSet("X12_864");
        /// <summary>
        /// Constant X12_865 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_865 = new X12TransactionSet("X12_865");
        /// <summary>
        /// Constant X12_866 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_866 = new X12TransactionSet("X12_866");
        /// <summary>
        /// Constant X12_867 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_867 = new X12TransactionSet("X12_867");
        /// <summary>
        /// Constant X12_868 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_868 = new X12TransactionSet("X12_868");
        /// <summary>
        /// Constant X12_869 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_869 = new X12TransactionSet("X12_869");
        /// <summary>
        /// Constant X12_870 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_870 = new X12TransactionSet("X12_870");
        /// <summary>
        /// Constant X12_871 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_871 = new X12TransactionSet("X12_871");
        /// <summary>
        /// Constant X12_872 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_872 = new X12TransactionSet("X12_872");
        /// <summary>
        /// Constant X12_873 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_873 = new X12TransactionSet("X12_873");
        /// <summary>
        /// Constant X12_874 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_874 = new X12TransactionSet("X12_874");
        /// <summary>
        /// Constant X12_875 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_875 = new X12TransactionSet("X12_875");
        /// <summary>
        /// Constant X12_876 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_876 = new X12TransactionSet("X12_876");
        /// <summary>
        /// Constant X12_877 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_877 = new X12TransactionSet("X12_877");
        /// <summary>
        /// Constant X12_878 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_878 = new X12TransactionSet("X12_878");
        /// <summary>
        /// Constant X12_879 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_879 = new X12TransactionSet("X12_879");
        /// <summary>
        /// Constant X12_880 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_880 = new X12TransactionSet("X12_880");
        /// <summary>
        /// Constant X12_881 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_881 = new X12TransactionSet("X12_881");
        /// <summary>
        /// Constant X12_882 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_882 = new X12TransactionSet("X12_882");
        /// <summary>
        /// Constant X12_883 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_883 = new X12TransactionSet("X12_883");
        /// <summary>
        /// Constant X12_884 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_884 = new X12TransactionSet("X12_884");
        /// <summary>
        /// Constant X12_885 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_885 = new X12TransactionSet("X12_885");
        /// <summary>
        /// Constant X12_886 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_886 = new X12TransactionSet("X12_886");
        /// <summary>
        /// Constant X12_887 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_887 = new X12TransactionSet("X12_887");
        /// <summary>
        /// Constant X12_888 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_888 = new X12TransactionSet("X12_888");
        /// <summary>
        /// Constant X12_889 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_889 = new X12TransactionSet("X12_889");
        /// <summary>
        /// Constant X12_891 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_891 = new X12TransactionSet("X12_891");
        /// <summary>
        /// Constant X12_893 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_893 = new X12TransactionSet("X12_893");
        /// <summary>
        /// Constant X12_894 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_894 = new X12TransactionSet("X12_894");
        /// <summary>
        /// Constant X12_895 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_895 = new X12TransactionSet("X12_895");
        /// <summary>
        /// Constant X12_896 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_896 = new X12TransactionSet("X12_896");
        /// <summary>
        /// Constant X12_920 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_920 = new X12TransactionSet("X12_920");
        /// <summary>
        /// Constant X12_924 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_924 = new X12TransactionSet("X12_924");
        /// <summary>
        /// Constant X12_925 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_925 = new X12TransactionSet("X12_925");
        /// <summary>
        /// Constant X12_926 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_926 = new X12TransactionSet("X12_926");
        /// <summary>
        /// Constant X12_928 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_928 = new X12TransactionSet("X12_928");
        /// <summary>
        /// Constant X12_940 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_940 = new X12TransactionSet("X12_940");
        /// <summary>
        /// Constant X12_943 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_943 = new X12TransactionSet("X12_943");
        /// <summary>
        /// Constant X12_944 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_944 = new X12TransactionSet("X12_944");
        /// <summary>
        /// Constant X12_945 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_945 = new X12TransactionSet("X12_945");
        /// <summary>
        /// Constant X12_947 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_947 = new X12TransactionSet("X12_947");
        /// <summary>
        /// Constant X12_980 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_980 = new X12TransactionSet("X12_980");
        /// <summary>
        /// Constant X12_990 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_990 = new X12TransactionSet("X12_990");
        /// <summary>
        /// Constant X12_993 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_993 = new X12TransactionSet("X12_993");
        /// <summary>
        /// Constant X12_996 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_996 = new X12TransactionSet("X12_996");
        /// <summary>
        /// Constant X12_997 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_997 = new X12TransactionSet("X12_997");
        /// <summary>
        /// Constant X12_998 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_998 = new X12TransactionSet("X12_998");
        /// <summary>
        /// Constant X12_999 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_999 = new X12TransactionSet("X12_999");
        /// <summary>
        /// Constant X12_999_X231 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_999_X231 = new X12TransactionSet("X12_999_X231");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12TransactionSet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12TransactionSet FindValue(string value)
        {
            return FindValue<X12TransactionSet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12TransactionSet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12Version.
    /// </summary>
    public class X12Version : ConstantClass
    {

        /// <summary>
        /// Constant VERSION_4010 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_4010 = new X12Version("VERSION_4010");
        /// <summary>
        /// Constant VERSION_4030 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_4030 = new X12Version("VERSION_4030");
        /// <summary>
        /// Constant VERSION_4050 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_4050 = new X12Version("VERSION_4050");
        /// <summary>
        /// Constant VERSION_4060 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_4060 = new X12Version("VERSION_4060");
        /// <summary>
        /// Constant VERSION_5010 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_5010 = new X12Version("VERSION_5010");
        /// <summary>
        /// Constant VERSION_5010_HIPAA for X12Version
        /// </summary>
        public static readonly X12Version VERSION_5010_HIPAA = new X12Version("VERSION_5010_HIPAA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12Version(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12Version FindValue(string value)
        {
            return FindValue<X12Version>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12Version(string value)
        {
            return FindValue(value);
        }
    }

}