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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DatabaseMigrationService
{

    /// <summary>
    /// Constants used for properties of type AuthMechanismValue.
    /// </summary>
    public class AuthMechanismValue : ConstantClass
    {

        /// <summary>
        /// Constant Default for AuthMechanismValue
        /// </summary>
        public static readonly AuthMechanismValue Default = new AuthMechanismValue("default");
        /// <summary>
        /// Constant Mongodb_cr for AuthMechanismValue
        /// </summary>
        public static readonly AuthMechanismValue Mongodb_cr = new AuthMechanismValue("mongodb_cr");
        /// <summary>
        /// Constant Scram_sha_1 for AuthMechanismValue
        /// </summary>
        public static readonly AuthMechanismValue Scram_sha_1 = new AuthMechanismValue("scram_sha_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthMechanismValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthMechanismValue FindValue(string value)
        {
            return FindValue<AuthMechanismValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthMechanismValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthTypeValue.
    /// </summary>
    public class AuthTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant No for AuthTypeValue
        /// </summary>
        public static readonly AuthTypeValue No = new AuthTypeValue("no");
        /// <summary>
        /// Constant Password for AuthTypeValue
        /// </summary>
        public static readonly AuthTypeValue Password = new AuthTypeValue("password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthTypeValue FindValue(string value)
        {
            return FindValue<AuthTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CharLengthSemantics.
    /// </summary>
    public class CharLengthSemantics : ConstantClass
    {

        /// <summary>
        /// Constant Byte for CharLengthSemantics
        /// </summary>
        public static readonly CharLengthSemantics Byte = new CharLengthSemantics("byte");
        /// <summary>
        /// Constant Char for CharLengthSemantics
        /// </summary>
        public static readonly CharLengthSemantics Char = new CharLengthSemantics("char");
        /// <summary>
        /// Constant Default for CharLengthSemantics
        /// </summary>
        public static readonly CharLengthSemantics Default = new CharLengthSemantics("default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CharLengthSemantics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CharLengthSemantics FindValue(string value)
        {
            return FindValue<CharLengthSemantics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CharLengthSemantics(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionTypeValue.
    /// </summary>
    public class CompressionTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for CompressionTypeValue
        /// </summary>
        public static readonly CompressionTypeValue Gzip = new CompressionTypeValue("gzip");
        /// <summary>
        /// Constant None for CompressionTypeValue
        /// </summary>
        public static readonly CompressionTypeValue None = new CompressionTypeValue("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionTypeValue FindValue(string value)
        {
            return FindValue<CompressionTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataFormatValue.
    /// </summary>
    public class DataFormatValue : ConstantClass
    {

        /// <summary>
        /// Constant Csv for DataFormatValue
        /// </summary>
        public static readonly DataFormatValue Csv = new DataFormatValue("csv");
        /// <summary>
        /// Constant Parquet for DataFormatValue
        /// </summary>
        public static readonly DataFormatValue Parquet = new DataFormatValue("parquet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataFormatValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFormatValue FindValue(string value)
        {
            return FindValue<DataFormatValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFormatValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatePartitionDelimiterValue.
    /// </summary>
    public class DatePartitionDelimiterValue : ConstantClass
    {

        /// <summary>
        /// Constant DASH for DatePartitionDelimiterValue
        /// </summary>
        public static readonly DatePartitionDelimiterValue DASH = new DatePartitionDelimiterValue("DASH");
        /// <summary>
        /// Constant NONE for DatePartitionDelimiterValue
        /// </summary>
        public static readonly DatePartitionDelimiterValue NONE = new DatePartitionDelimiterValue("NONE");
        /// <summary>
        /// Constant SLASH for DatePartitionDelimiterValue
        /// </summary>
        public static readonly DatePartitionDelimiterValue SLASH = new DatePartitionDelimiterValue("SLASH");
        /// <summary>
        /// Constant UNDERSCORE for DatePartitionDelimiterValue
        /// </summary>
        public static readonly DatePartitionDelimiterValue UNDERSCORE = new DatePartitionDelimiterValue("UNDERSCORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatePartitionDelimiterValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatePartitionDelimiterValue FindValue(string value)
        {
            return FindValue<DatePartitionDelimiterValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatePartitionDelimiterValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatePartitionSequenceValue.
    /// </summary>
    public class DatePartitionSequenceValue : ConstantClass
    {

        /// <summary>
        /// Constant DDMMYYYY for DatePartitionSequenceValue
        /// </summary>
        public static readonly DatePartitionSequenceValue DDMMYYYY = new DatePartitionSequenceValue("DDMMYYYY");
        /// <summary>
        /// Constant MMYYYYDD for DatePartitionSequenceValue
        /// </summary>
        public static readonly DatePartitionSequenceValue MMYYYYDD = new DatePartitionSequenceValue("MMYYYYDD");
        /// <summary>
        /// Constant YYYYMM for DatePartitionSequenceValue
        /// </summary>
        public static readonly DatePartitionSequenceValue YYYYMM = new DatePartitionSequenceValue("YYYYMM");
        /// <summary>
        /// Constant YYYYMMDD for DatePartitionSequenceValue
        /// </summary>
        public static readonly DatePartitionSequenceValue YYYYMMDD = new DatePartitionSequenceValue("YYYYMMDD");
        /// <summary>
        /// Constant YYYYMMDDHH for DatePartitionSequenceValue
        /// </summary>
        public static readonly DatePartitionSequenceValue YYYYMMDDHH = new DatePartitionSequenceValue("YYYYMMDDHH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatePartitionSequenceValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatePartitionSequenceValue FindValue(string value)
        {
            return FindValue<DatePartitionSequenceValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatePartitionSequenceValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DmsSslModeValue.
    /// </summary>
    public class DmsSslModeValue : ConstantClass
    {

        /// <summary>
        /// Constant None for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue None = new DmsSslModeValue("none");
        /// <summary>
        /// Constant Require for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue Require = new DmsSslModeValue("require");
        /// <summary>
        /// Constant VerifyCa for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue VerifyCa = new DmsSslModeValue("verify-ca");
        /// <summary>
        /// Constant VerifyFull for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue VerifyFull = new DmsSslModeValue("verify-full");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DmsSslModeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DmsSslModeValue FindValue(string value)
        {
            return FindValue<DmsSslModeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DmsSslModeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncodingTypeValue.
    /// </summary>
    public class EncodingTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Plain for EncodingTypeValue
        /// </summary>
        public static readonly EncodingTypeValue Plain = new EncodingTypeValue("plain");
        /// <summary>
        /// Constant PlainDictionary for EncodingTypeValue
        /// </summary>
        public static readonly EncodingTypeValue PlainDictionary = new EncodingTypeValue("plain-dictionary");
        /// <summary>
        /// Constant RleDictionary for EncodingTypeValue
        /// </summary>
        public static readonly EncodingTypeValue RleDictionary = new EncodingTypeValue("rle-dictionary");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncodingTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingTypeValue FindValue(string value)
        {
            return FindValue<EncodingTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodingTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionModeValue.
    /// </summary>
    public class EncryptionModeValue : ConstantClass
    {

        /// <summary>
        /// Constant SseKms for EncryptionModeValue
        /// </summary>
        public static readonly EncryptionModeValue SseKms = new EncryptionModeValue("sse-kms");
        /// <summary>
        /// Constant SseS3 for EncryptionModeValue
        /// </summary>
        public static readonly EncryptionModeValue SseS3 = new EncryptionModeValue("sse-s3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionModeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionModeValue FindValue(string value)
        {
            return FindValue<EncryptionModeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionModeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageFormatValue.
    /// </summary>
    public class MessageFormatValue : ConstantClass
    {

        /// <summary>
        /// Constant Json for MessageFormatValue
        /// </summary>
        public static readonly MessageFormatValue Json = new MessageFormatValue("json");
        /// <summary>
        /// Constant JsonUnformatted for MessageFormatValue
        /// </summary>
        public static readonly MessageFormatValue JsonUnformatted = new MessageFormatValue("json-unformatted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageFormatValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageFormatValue FindValue(string value)
        {
            return FindValue<MessageFormatValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageFormatValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationTypeValue.
    /// </summary>
    public class MigrationTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Cdc for MigrationTypeValue
        /// </summary>
        public static readonly MigrationTypeValue Cdc = new MigrationTypeValue("cdc");
        /// <summary>
        /// Constant FullLoad for MigrationTypeValue
        /// </summary>
        public static readonly MigrationTypeValue FullLoad = new MigrationTypeValue("full-load");
        /// <summary>
        /// Constant FullLoadAndCdc for MigrationTypeValue
        /// </summary>
        public static readonly MigrationTypeValue FullLoadAndCdc = new MigrationTypeValue("full-load-and-cdc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationTypeValue FindValue(string value)
        {
            return FindValue<MigrationTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NestingLevelValue.
    /// </summary>
    public class NestingLevelValue : ConstantClass
    {

        /// <summary>
        /// Constant None for NestingLevelValue
        /// </summary>
        public static readonly NestingLevelValue None = new NestingLevelValue("none");
        /// <summary>
        /// Constant One for NestingLevelValue
        /// </summary>
        public static readonly NestingLevelValue One = new NestingLevelValue("one");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NestingLevelValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NestingLevelValue FindValue(string value)
        {
            return FindValue<NestingLevelValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NestingLevelValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParquetVersionValue.
    /// </summary>
    public class ParquetVersionValue : ConstantClass
    {

        /// <summary>
        /// Constant Parquet10 for ParquetVersionValue
        /// </summary>
        public static readonly ParquetVersionValue Parquet10 = new ParquetVersionValue("parquet-1-0");
        /// <summary>
        /// Constant Parquet20 for ParquetVersionValue
        /// </summary>
        public static readonly ParquetVersionValue Parquet20 = new ParquetVersionValue("parquet-2-0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParquetVersionValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParquetVersionValue FindValue(string value)
        {
            return FindValue<ParquetVersionValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParquetVersionValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RefreshSchemasStatusTypeValue.
    /// </summary>
    public class RefreshSchemasStatusTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Failed for RefreshSchemasStatusTypeValue
        /// </summary>
        public static readonly RefreshSchemasStatusTypeValue Failed = new RefreshSchemasStatusTypeValue("failed");
        /// <summary>
        /// Constant Refreshing for RefreshSchemasStatusTypeValue
        /// </summary>
        public static readonly RefreshSchemasStatusTypeValue Refreshing = new RefreshSchemasStatusTypeValue("refreshing");
        /// <summary>
        /// Constant Successful for RefreshSchemasStatusTypeValue
        /// </summary>
        public static readonly RefreshSchemasStatusTypeValue Successful = new RefreshSchemasStatusTypeValue("successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshSchemasStatusTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshSchemasStatusTypeValue FindValue(string value)
        {
            return FindValue<RefreshSchemasStatusTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshSchemasStatusTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReleaseStatusValues.
    /// </summary>
    public class ReleaseStatusValues : ConstantClass
    {

        /// <summary>
        /// Constant Beta for ReleaseStatusValues
        /// </summary>
        public static readonly ReleaseStatusValues Beta = new ReleaseStatusValues("beta");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReleaseStatusValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReleaseStatusValues FindValue(string value)
        {
            return FindValue<ReleaseStatusValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReleaseStatusValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReloadOptionValue.
    /// </summary>
    public class ReloadOptionValue : ConstantClass
    {

        /// <summary>
        /// Constant DataReload for ReloadOptionValue
        /// </summary>
        public static readonly ReloadOptionValue DataReload = new ReloadOptionValue("data-reload");
        /// <summary>
        /// Constant ValidateOnly for ReloadOptionValue
        /// </summary>
        public static readonly ReloadOptionValue ValidateOnly = new ReloadOptionValue("validate-only");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReloadOptionValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReloadOptionValue FindValue(string value)
        {
            return FindValue<ReloadOptionValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReloadOptionValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationEndpointTypeValue.
    /// </summary>
    public class ReplicationEndpointTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Source for ReplicationEndpointTypeValue
        /// </summary>
        public static readonly ReplicationEndpointTypeValue Source = new ReplicationEndpointTypeValue("source");
        /// <summary>
        /// Constant Target for ReplicationEndpointTypeValue
        /// </summary>
        public static readonly ReplicationEndpointTypeValue Target = new ReplicationEndpointTypeValue("target");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationEndpointTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationEndpointTypeValue FindValue(string value)
        {
            return FindValue<ReplicationEndpointTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationEndpointTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SafeguardPolicy.
    /// </summary>
    public class SafeguardPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ExclusiveAutomaticTruncation for SafeguardPolicy
        /// </summary>
        public static readonly SafeguardPolicy ExclusiveAutomaticTruncation = new SafeguardPolicy("exclusive-automatic-truncation");
        /// <summary>
        /// Constant RelyOnSqlServerReplicationAgent for SafeguardPolicy
        /// </summary>
        public static readonly SafeguardPolicy RelyOnSqlServerReplicationAgent = new SafeguardPolicy("rely-on-sql-server-replication-agent");
        /// <summary>
        /// Constant SharedAutomaticTruncation for SafeguardPolicy
        /// </summary>
        public static readonly SafeguardPolicy SharedAutomaticTruncation = new SafeguardPolicy("shared-automatic-truncation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SafeguardPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SafeguardPolicy FindValue(string value)
        {
            return FindValue<SafeguardPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SafeguardPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant ReplicationInstance for SourceType
        /// </summary>
        public static readonly SourceType ReplicationInstance = new SourceType("replication-instance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartReplicationTaskTypeValue.
    /// </summary>
    public class StartReplicationTaskTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant ReloadTarget for StartReplicationTaskTypeValue
        /// </summary>
        public static readonly StartReplicationTaskTypeValue ReloadTarget = new StartReplicationTaskTypeValue("reload-target");
        /// <summary>
        /// Constant ResumeProcessing for StartReplicationTaskTypeValue
        /// </summary>
        public static readonly StartReplicationTaskTypeValue ResumeProcessing = new StartReplicationTaskTypeValue("resume-processing");
        /// <summary>
        /// Constant StartReplication for StartReplicationTaskTypeValue
        /// </summary>
        public static readonly StartReplicationTaskTypeValue StartReplication = new StartReplicationTaskTypeValue("start-replication");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartReplicationTaskTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartReplicationTaskTypeValue FindValue(string value)
        {
            return FindValue<StartReplicationTaskTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartReplicationTaskTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDbType.
    /// </summary>
    public class TargetDbType : ConstantClass
    {

        /// <summary>
        /// Constant MultipleDatabases for TargetDbType
        /// </summary>
        public static readonly TargetDbType MultipleDatabases = new TargetDbType("multiple-databases");
        /// <summary>
        /// Constant SpecificDatabase for TargetDbType
        /// </summary>
        public static readonly TargetDbType SpecificDatabase = new TargetDbType("specific-database");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDbType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDbType FindValue(string value)
        {
            return FindValue<TargetDbType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDbType(string value)
        {
            return FindValue(value);
        }
    }

}