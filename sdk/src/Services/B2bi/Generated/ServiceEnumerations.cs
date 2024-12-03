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
    /// Constants used for properties of type X12TransactionSet.
    /// </summary>
    public class X12TransactionSet : ConstantClass
    {

        /// <summary>
        /// Constant X12_110 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_110 = new X12TransactionSet("X12_110");
        /// <summary>
        /// Constant X12_180 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_180 = new X12TransactionSet("X12_180");
        /// <summary>
        /// Constant X12_204 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_204 = new X12TransactionSet("X12_204");
        /// <summary>
        /// Constant X12_210 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_210 = new X12TransactionSet("X12_210");
        /// <summary>
        /// Constant X12_211 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_211 = new X12TransactionSet("X12_211");
        /// <summary>
        /// Constant X12_214 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_214 = new X12TransactionSet("X12_214");
        /// <summary>
        /// Constant X12_215 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_215 = new X12TransactionSet("X12_215");
        /// <summary>
        /// Constant X12_259 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_259 = new X12TransactionSet("X12_259");
        /// <summary>
        /// Constant X12_260 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_260 = new X12TransactionSet("X12_260");
        /// <summary>
        /// Constant X12_266 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_266 = new X12TransactionSet("X12_266");
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
        /// Constant X12_310 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_310 = new X12TransactionSet("X12_310");
        /// <summary>
        /// Constant X12_315 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_315 = new X12TransactionSet("X12_315");
        /// <summary>
        /// Constant X12_322 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_322 = new X12TransactionSet("X12_322");
        /// <summary>
        /// Constant X12_404 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_404 = new X12TransactionSet("X12_404");
        /// <summary>
        /// Constant X12_410 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_410 = new X12TransactionSet("X12_410");
        /// <summary>
        /// Constant X12_417 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_417 = new X12TransactionSet("X12_417");
        /// <summary>
        /// Constant X12_421 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_421 = new X12TransactionSet("X12_421");
        /// <summary>
        /// Constant X12_426 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_426 = new X12TransactionSet("X12_426");
        /// <summary>
        /// Constant X12_810 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_810 = new X12TransactionSet("X12_810");
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
        /// Constant X12_824 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_824 = new X12TransactionSet("X12_824");
        /// <summary>
        /// Constant X12_824_X186 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_824_X186 = new X12TransactionSet("X12_824_X186");
        /// <summary>
        /// Constant X12_830 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_830 = new X12TransactionSet("X12_830");
        /// <summary>
        /// Constant X12_832 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_832 = new X12TransactionSet("X12_832");
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
        /// Constant X12_844 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_844 = new X12TransactionSet("X12_844");
        /// <summary>
        /// Constant X12_846 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_846 = new X12TransactionSet("X12_846");
        /// <summary>
        /// Constant X12_849 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_849 = new X12TransactionSet("X12_849");
        /// <summary>
        /// Constant X12_850 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_850 = new X12TransactionSet("X12_850");
        /// <summary>
        /// Constant X12_852 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_852 = new X12TransactionSet("X12_852");
        /// <summary>
        /// Constant X12_855 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_855 = new X12TransactionSet("X12_855");
        /// <summary>
        /// Constant X12_856 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_856 = new X12TransactionSet("X12_856");
        /// <summary>
        /// Constant X12_860 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_860 = new X12TransactionSet("X12_860");
        /// <summary>
        /// Constant X12_861 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_861 = new X12TransactionSet("X12_861");
        /// <summary>
        /// Constant X12_864 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_864 = new X12TransactionSet("X12_864");
        /// <summary>
        /// Constant X12_865 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_865 = new X12TransactionSet("X12_865");
        /// <summary>
        /// Constant X12_869 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_869 = new X12TransactionSet("X12_869");
        /// <summary>
        /// Constant X12_870 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_870 = new X12TransactionSet("X12_870");
        /// <summary>
        /// Constant X12_940 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_940 = new X12TransactionSet("X12_940");
        /// <summary>
        /// Constant X12_945 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_945 = new X12TransactionSet("X12_945");
        /// <summary>
        /// Constant X12_990 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_990 = new X12TransactionSet("X12_990");
        /// <summary>
        /// Constant X12_997 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_997 = new X12TransactionSet("X12_997");
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