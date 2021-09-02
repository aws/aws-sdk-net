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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LexModelBuildingService
{

    /// <summary>
    /// Constants used for properties of type ChannelStatus.
    /// </summary>
    public class ChannelStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATED = new ChannelStatus("CREATED");
        /// <summary>
        /// Constant FAILED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus FAILED = new ChannelStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus IN_PROGRESS = new ChannelStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelStatus FindValue(string value)
        {
            return FindValue<ChannelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelType.
    /// </summary>
    public class ChannelType : ConstantClass
    {

        /// <summary>
        /// Constant Facebook for ChannelType
        /// </summary>
        public static readonly ChannelType Facebook = new ChannelType("Facebook");
        /// <summary>
        /// Constant Kik for ChannelType
        /// </summary>
        public static readonly ChannelType Kik = new ChannelType("Kik");
        /// <summary>
        /// Constant Slack for ChannelType
        /// </summary>
        public static readonly ChannelType Slack = new ChannelType("Slack");
        /// <summary>
        /// Constant TwilioSms for ChannelType
        /// </summary>
        public static readonly ChannelType TwilioSms = new ChannelType("Twilio-Sms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelType FindValue(string value)
        {
            return FindValue<ChannelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentType.
    /// </summary>
    public class ContentType : ConstantClass
    {

        /// <summary>
        /// Constant CustomPayload for ContentType
        /// </summary>
        public static readonly ContentType CustomPayload = new ContentType("CustomPayload");
        /// <summary>
        /// Constant PlainText for ContentType
        /// </summary>
        public static readonly ContentType PlainText = new ContentType("PlainText");
        /// <summary>
        /// Constant SSML for ContentType
        /// </summary>
        public static readonly ContentType SSML = new ContentType("SSML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentType FindValue(string value)
        {
            return FindValue<ContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Destination.
    /// </summary>
    public class Destination : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDWATCH_LOGS for Destination
        /// </summary>
        public static readonly Destination CLOUDWATCH_LOGS = new Destination("CLOUDWATCH_LOGS");
        /// <summary>
        /// Constant S3 for Destination
        /// </summary>
        public static readonly Destination S3 = new Destination("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Destination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Destination FindValue(string value)
        {
            return FindValue<Destination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Destination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportStatus.
    /// </summary>
    public class ExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ExportStatus
        /// </summary>
        public static readonly ExportStatus FAILED = new ExportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ExportStatus
        /// </summary>
        public static readonly ExportStatus IN_PROGRESS = new ExportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant READY for ExportStatus
        /// </summary>
        public static readonly ExportStatus READY = new ExportStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportStatus FindValue(string value)
        {
            return FindValue<ExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportType.
    /// </summary>
    public class ExportType : ConstantClass
    {

        /// <summary>
        /// Constant ALEXA_SKILLS_KIT for ExportType
        /// </summary>
        public static readonly ExportType ALEXA_SKILLS_KIT = new ExportType("ALEXA_SKILLS_KIT");
        /// <summary>
        /// Constant LEX for ExportType
        /// </summary>
        public static readonly ExportType LEX = new ExportType("LEX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportType FindValue(string value)
        {
            return FindValue<ExportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FulfillmentActivityType.
    /// </summary>
    public class FulfillmentActivityType : ConstantClass
    {

        /// <summary>
        /// Constant CodeHook for FulfillmentActivityType
        /// </summary>
        public static readonly FulfillmentActivityType CodeHook = new FulfillmentActivityType("CodeHook");
        /// <summary>
        /// Constant ReturnIntent for FulfillmentActivityType
        /// </summary>
        public static readonly FulfillmentActivityType ReturnIntent = new FulfillmentActivityType("ReturnIntent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FulfillmentActivityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FulfillmentActivityType FindValue(string value)
        {
            return FindValue<FulfillmentActivityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FulfillmentActivityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportStatus.
    /// </summary>
    public class ImportStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ImportStatus
        /// </summary>
        public static readonly ImportStatus COMPLETE = new ImportStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for ImportStatus
        /// </summary>
        public static readonly ImportStatus FAILED = new ImportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ImportStatus
        /// </summary>
        public static readonly ImportStatus IN_PROGRESS = new ImportStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportStatus FindValue(string value)
        {
            return FindValue<ImportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Locale.
    /// </summary>
    public class Locale : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for Locale
        /// </summary>
        public static readonly Locale DeDE = new Locale("de-DE");
        /// <summary>
        /// Constant EnAU for Locale
        /// </summary>
        public static readonly Locale EnAU = new Locale("en-AU");
        /// <summary>
        /// Constant EnGB for Locale
        /// </summary>
        public static readonly Locale EnGB = new Locale("en-GB");
        /// <summary>
        /// Constant EnIN for Locale
        /// </summary>
        public static readonly Locale EnIN = new Locale("en-IN");
        /// <summary>
        /// Constant EnUS for Locale
        /// </summary>
        public static readonly Locale EnUS = new Locale("en-US");
        /// <summary>
        /// Constant Es419 for Locale
        /// </summary>
        public static readonly Locale Es419 = new Locale("es-419");
        /// <summary>
        /// Constant EsES for Locale
        /// </summary>
        public static readonly Locale EsES = new Locale("es-ES");
        /// <summary>
        /// Constant EsUS for Locale
        /// </summary>
        public static readonly Locale EsUS = new Locale("es-US");
        /// <summary>
        /// Constant FrCA for Locale
        /// </summary>
        public static readonly Locale FrCA = new Locale("fr-CA");
        /// <summary>
        /// Constant FrFR for Locale
        /// </summary>
        public static readonly Locale FrFR = new Locale("fr-FR");
        /// <summary>
        /// Constant ItIT for Locale
        /// </summary>
        public static readonly Locale ItIT = new Locale("it-IT");
        /// <summary>
        /// Constant JaJP for Locale
        /// </summary>
        public static readonly Locale JaJP = new Locale("ja-JP");
        /// <summary>
        /// Constant KoKR for Locale
        /// </summary>
        public static readonly Locale KoKR = new Locale("ko-KR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Locale(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Locale FindValue(string value)
        {
            return FindValue<Locale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Locale(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for LogType
        /// </summary>
        public static readonly LogType AUDIO = new LogType("AUDIO");
        /// <summary>
        /// Constant TEXT for LogType
        /// </summary>
        public static readonly LogType TEXT = new LogType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MergeStrategy.
    /// </summary>
    public class MergeStrategy : ConstantClass
    {

        /// <summary>
        /// Constant FAIL_ON_CONFLICT for MergeStrategy
        /// </summary>
        public static readonly MergeStrategy FAIL_ON_CONFLICT = new MergeStrategy("FAIL_ON_CONFLICT");
        /// <summary>
        /// Constant OVERWRITE_LATEST for MergeStrategy
        /// </summary>
        public static readonly MergeStrategy OVERWRITE_LATEST = new MergeStrategy("OVERWRITE_LATEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MergeStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MergeStrategy FindValue(string value)
        {
            return FindValue<MergeStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MergeStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationAlertType.
    /// </summary>
    public class MigrationAlertType : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for MigrationAlertType
        /// </summary>
        public static readonly MigrationAlertType ERROR = new MigrationAlertType("ERROR");
        /// <summary>
        /// Constant WARN for MigrationAlertType
        /// </summary>
        public static readonly MigrationAlertType WARN = new MigrationAlertType("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationAlertType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationAlertType FindValue(string value)
        {
            return FindValue<MigrationAlertType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationAlertType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationSortAttribute.
    /// </summary>
    public class MigrationSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant MIGRATION_DATE_TIME for MigrationSortAttribute
        /// </summary>
        public static readonly MigrationSortAttribute MIGRATION_DATE_TIME = new MigrationSortAttribute("MIGRATION_DATE_TIME");
        /// <summary>
        /// Constant V1_BOT_NAME for MigrationSortAttribute
        /// </summary>
        public static readonly MigrationSortAttribute V1_BOT_NAME = new MigrationSortAttribute("V1_BOT_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationSortAttribute FindValue(string value)
        {
            return FindValue<MigrationSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationStatus.
    /// </summary>
    public class MigrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for MigrationStatus
        /// </summary>
        public static readonly MigrationStatus COMPLETED = new MigrationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for MigrationStatus
        /// </summary>
        public static readonly MigrationStatus FAILED = new MigrationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MigrationStatus
        /// </summary>
        public static readonly MigrationStatus IN_PROGRESS = new MigrationStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationStatus FindValue(string value)
        {
            return FindValue<MigrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationStrategy.
    /// </summary>
    public class MigrationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_NEW for MigrationStrategy
        /// </summary>
        public static readonly MigrationStrategy CREATE_NEW = new MigrationStrategy("CREATE_NEW");
        /// <summary>
        /// Constant UPDATE_EXISTING for MigrationStrategy
        /// </summary>
        public static readonly MigrationStrategy UPDATE_EXISTING = new MigrationStrategy("UPDATE_EXISTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationStrategy FindValue(string value)
        {
            return FindValue<MigrationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObfuscationSetting.
    /// </summary>
    public class ObfuscationSetting : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_OBFUSCATION for ObfuscationSetting
        /// </summary>
        public static readonly ObfuscationSetting DEFAULT_OBFUSCATION = new ObfuscationSetting("DEFAULT_OBFUSCATION");
        /// <summary>
        /// Constant NONE for ObfuscationSetting
        /// </summary>
        public static readonly ObfuscationSetting NONE = new ObfuscationSetting("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObfuscationSetting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObfuscationSetting FindValue(string value)
        {
            return FindValue<ObfuscationSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObfuscationSetting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessBehavior.
    /// </summary>
    public class ProcessBehavior : ConstantClass
    {

        /// <summary>
        /// Constant BUILD for ProcessBehavior
        /// </summary>
        public static readonly ProcessBehavior BUILD = new ProcessBehavior("BUILD");
        /// <summary>
        /// Constant SAVE for ProcessBehavior
        /// </summary>
        public static readonly ProcessBehavior SAVE = new ProcessBehavior("SAVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessBehavior FindValue(string value)
        {
            return FindValue<ProcessBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceType.
    /// </summary>
    public class ReferenceType : ConstantClass
    {

        /// <summary>
        /// Constant Bot for ReferenceType
        /// </summary>
        public static readonly ReferenceType Bot = new ReferenceType("Bot");
        /// <summary>
        /// Constant BotAlias for ReferenceType
        /// </summary>
        public static readonly ReferenceType BotAlias = new ReferenceType("BotAlias");
        /// <summary>
        /// Constant BotChannel for ReferenceType
        /// </summary>
        public static readonly ReferenceType BotChannel = new ReferenceType("BotChannel");
        /// <summary>
        /// Constant Intent for ReferenceType
        /// </summary>
        public static readonly ReferenceType Intent = new ReferenceType("Intent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceType FindValue(string value)
        {
            return FindValue<ReferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant BOT for ResourceType
        /// </summary>
        public static readonly ResourceType BOT = new ResourceType("BOT");
        /// <summary>
        /// Constant INTENT for ResourceType
        /// </summary>
        public static readonly ResourceType INTENT = new ResourceType("INTENT");
        /// <summary>
        /// Constant SLOT_TYPE for ResourceType
        /// </summary>
        public static readonly ResourceType SLOT_TYPE = new ResourceType("SLOT_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotConstraint.
    /// </summary>
    public class SlotConstraint : ConstantClass
    {

        /// <summary>
        /// Constant Optional for SlotConstraint
        /// </summary>
        public static readonly SlotConstraint Optional = new SlotConstraint("Optional");
        /// <summary>
        /// Constant Required for SlotConstraint
        /// </summary>
        public static readonly SlotConstraint Required = new SlotConstraint("Required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotConstraint FindValue(string value)
        {
            return FindValue<SlotConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotValueSelectionStrategy.
    /// </summary>
    public class SlotValueSelectionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ORIGINAL_VALUE for SlotValueSelectionStrategy
        /// </summary>
        public static readonly SlotValueSelectionStrategy ORIGINAL_VALUE = new SlotValueSelectionStrategy("ORIGINAL_VALUE");
        /// <summary>
        /// Constant TOP_RESOLUTION for SlotValueSelectionStrategy
        /// </summary>
        public static readonly SlotValueSelectionStrategy TOP_RESOLUTION = new SlotValueSelectionStrategy("TOP_RESOLUTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotValueSelectionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotValueSelectionStrategy FindValue(string value)
        {
            return FindValue<SlotValueSelectionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotValueSelectionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant BUILDING for Status
        /// </summary>
        public static readonly Status BUILDING = new Status("BUILDING");
        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant NOT_BUILT for Status
        /// </summary>
        public static readonly Status NOT_BUILT = new Status("NOT_BUILT");
        /// <summary>
        /// Constant READY for Status
        /// </summary>
        public static readonly Status READY = new Status("READY");
        /// <summary>
        /// Constant READY_BASIC_TESTING for Status
        /// </summary>
        public static readonly Status READY_BASIC_TESTING = new Status("READY_BASIC_TESTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Detected for StatusType
        /// </summary>
        public static readonly StatusType Detected = new StatusType("Detected");
        /// <summary>
        /// Constant Missed for StatusType
        /// </summary>
        public static readonly StatusType Missed = new StatusType("Missed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }

}