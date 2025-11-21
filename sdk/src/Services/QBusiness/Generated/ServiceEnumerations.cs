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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QBusiness
{

    /// <summary>
    /// Constants used for properties of type ActionPayloadFieldType.
    /// </summary>
    public class ActionPayloadFieldType : ConstantClass
    {

        /// <summary>
        /// Constant ARRAY for ActionPayloadFieldType
        /// </summary>
        public static readonly ActionPayloadFieldType ARRAY = new ActionPayloadFieldType("ARRAY");
        /// <summary>
        /// Constant BOOLEAN for ActionPayloadFieldType
        /// </summary>
        public static readonly ActionPayloadFieldType BOOLEAN = new ActionPayloadFieldType("BOOLEAN");
        /// <summary>
        /// Constant NUMBER for ActionPayloadFieldType
        /// </summary>
        public static readonly ActionPayloadFieldType NUMBER = new ActionPayloadFieldType("NUMBER");
        /// <summary>
        /// Constant STRING for ActionPayloadFieldType
        /// </summary>
        public static readonly ActionPayloadFieldType STRING = new ActionPayloadFieldType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionPayloadFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionPayloadFieldType FindValue(string value)
        {
            return FindValue<ActionPayloadFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionPayloadFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type APISchemaType.
    /// </summary>
    public class APISchemaType : ConstantClass
    {

        /// <summary>
        /// Constant OPEN_API_V3 for APISchemaType
        /// </summary>
        public static readonly APISchemaType OPEN_API_V3 = new APISchemaType("OPEN_API_V3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public APISchemaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static APISchemaType FindValue(string value)
        {
            return FindValue<APISchemaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator APISchemaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus ACTIVE = new ApplicationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus CREATING = new ApplicationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DELETING = new ApplicationStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus FAILED = new ApplicationStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus UPDATING = new ApplicationStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentsControlMode.
    /// </summary>
    public class AttachmentsControlMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AttachmentsControlMode
        /// </summary>
        public static readonly AttachmentsControlMode DISABLED = new AttachmentsControlMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for AttachmentsControlMode
        /// </summary>
        public static readonly AttachmentsControlMode ENABLED = new AttachmentsControlMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentsControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentsControlMode FindValue(string value)
        {
            return FindValue<AttachmentsControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentsControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentStatus.
    /// </summary>
    public class AttachmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus FAILED = new AttachmentStatus("FAILED");
        /// <summary>
        /// Constant SUCCESS for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus SUCCESS = new AttachmentStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentStatus FindValue(string value)
        {
            return FindValue<AttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributeType.
    /// </summary>
    public class AttributeType : ConstantClass
    {

        /// <summary>
        /// Constant DATE for AttributeType
        /// </summary>
        public static readonly AttributeType DATE = new AttributeType("DATE");
        /// <summary>
        /// Constant NUMBER for AttributeType
        /// </summary>
        public static readonly AttributeType NUMBER = new AttributeType("NUMBER");
        /// <summary>
        /// Constant STRING for AttributeType
        /// </summary>
        public static readonly AttributeType STRING = new AttributeType("STRING");
        /// <summary>
        /// Constant STRING_LIST for AttributeType
        /// </summary>
        public static readonly AttributeType STRING_LIST = new AttributeType("STRING_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeType FindValue(string value)
        {
            return FindValue<AttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributeValueOperator.
    /// </summary>
    public class AttributeValueOperator : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for AttributeValueOperator
        /// </summary>
        public static readonly AttributeValueOperator DELETE = new AttributeValueOperator("DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeValueOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeValueOperator FindValue(string value)
        {
            return FindValue<AttributeValueOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeValueOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioExtractionStatus.
    /// </summary>
    public class AudioExtractionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AudioExtractionStatus
        /// </summary>
        public static readonly AudioExtractionStatus DISABLED = new AudioExtractionStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AudioExtractionStatus
        /// </summary>
        public static readonly AudioExtractionStatus ENABLED = new AudioExtractionStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioExtractionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioExtractionStatus FindValue(string value)
        {
            return FindValue<AudioExtractionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioExtractionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioExtractionType.
    /// </summary>
    public class AudioExtractionType : ConstantClass
    {

        /// <summary>
        /// Constant SUMMARY for AudioExtractionType
        /// </summary>
        public static readonly AudioExtractionType SUMMARY = new AudioExtractionType("SUMMARY");
        /// <summary>
        /// Constant TRANSCRIPT for AudioExtractionType
        /// </summary>
        public static readonly AudioExtractionType TRANSCRIPT = new AudioExtractionType("TRANSCRIPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioExtractionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioExtractionType FindValue(string value)
        {
            return FindValue<AudioExtractionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioExtractionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoSubscriptionStatus.
    /// </summary>
    public class AutoSubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutoSubscriptionStatus
        /// </summary>
        public static readonly AutoSubscriptionStatus DISABLED = new AutoSubscriptionStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutoSubscriptionStatus
        /// </summary>
        public static readonly AutoSubscriptionStatus ENABLED = new AutoSubscriptionStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoSubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoSubscriptionStatus FindValue(string value)
        {
            return FindValue<AutoSubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoSubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrowserExtension.
    /// </summary>
    public class BrowserExtension : ConstantClass
    {

        /// <summary>
        /// Constant CHROME for BrowserExtension
        /// </summary>
        public static readonly BrowserExtension CHROME = new BrowserExtension("CHROME");
        /// <summary>
        /// Constant FIREFOX for BrowserExtension
        /// </summary>
        public static readonly BrowserExtension FIREFOX = new BrowserExtension("FIREFOX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserExtension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserExtension FindValue(string value)
        {
            return FindValue<BrowserExtension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserExtension(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChatMode.
    /// </summary>
    public class ChatMode : ConstantClass
    {

        /// <summary>
        /// Constant CREATOR_MODE for ChatMode
        /// </summary>
        public static readonly ChatMode CREATOR_MODE = new ChatMode("CREATOR_MODE");
        /// <summary>
        /// Constant PLUGIN_MODE for ChatMode
        /// </summary>
        public static readonly ChatMode PLUGIN_MODE = new ChatMode("PLUGIN_MODE");
        /// <summary>
        /// Constant RETRIEVAL_MODE for ChatMode
        /// </summary>
        public static readonly ChatMode RETRIEVAL_MODE = new ChatMode("RETRIEVAL_MODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChatMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChatMode FindValue(string value)
        {
            return FindValue<ChatMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChatMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChatResponseConfigurationStatus.
    /// </summary>
    public class ChatResponseConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ChatResponseConfigurationStatus
        /// </summary>
        public static readonly ChatResponseConfigurationStatus ACTIVE = new ChatResponseConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ChatResponseConfigurationStatus
        /// </summary>
        public static readonly ChatResponseConfigurationStatus CREATING = new ChatResponseConfigurationStatus("CREATING");
        /// <summary>
        /// Constant FAILED for ChatResponseConfigurationStatus
        /// </summary>
        public static readonly ChatResponseConfigurationStatus FAILED = new ChatResponseConfigurationStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ChatResponseConfigurationStatus
        /// </summary>
        public static readonly ChatResponseConfigurationStatus UPDATING = new ChatResponseConfigurationStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChatResponseConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChatResponseConfigurationStatus FindValue(string value)
        {
            return FindValue<ChatResponseConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChatResponseConfigurationStatus(string value)
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
        /// Constant CSV for ContentType
        /// </summary>
        public static readonly ContentType CSV = new ContentType("CSV");
        /// <summary>
        /// Constant HTML for ContentType
        /// </summary>
        public static readonly ContentType HTML = new ContentType("HTML");
        /// <summary>
        /// Constant JSON for ContentType
        /// </summary>
        public static readonly ContentType JSON = new ContentType("JSON");
        /// <summary>
        /// Constant MD for ContentType
        /// </summary>
        public static readonly ContentType MD = new ContentType("MD");
        /// <summary>
        /// Constant MS_EXCEL for ContentType
        /// </summary>
        public static readonly ContentType MS_EXCEL = new ContentType("MS_EXCEL");
        /// <summary>
        /// Constant MS_WORD for ContentType
        /// </summary>
        public static readonly ContentType MS_WORD = new ContentType("MS_WORD");
        /// <summary>
        /// Constant PDF for ContentType
        /// </summary>
        public static readonly ContentType PDF = new ContentType("PDF");
        /// <summary>
        /// Constant PLAIN_TEXT for ContentType
        /// </summary>
        public static readonly ContentType PLAIN_TEXT = new ContentType("PLAIN_TEXT");
        /// <summary>
        /// Constant PPT for ContentType
        /// </summary>
        public static readonly ContentType PPT = new ContentType("PPT");
        /// <summary>
        /// Constant RTF for ContentType
        /// </summary>
        public static readonly ContentType RTF = new ContentType("RTF");
        /// <summary>
        /// Constant XML for ContentType
        /// </summary>
        public static readonly ContentType XML = new ContentType("XML");
        /// <summary>
        /// Constant XSLT for ContentType
        /// </summary>
        public static readonly ContentType XSLT = new ContentType("XSLT");

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
    /// Constants used for properties of type CreatorModeControl.
    /// </summary>
    public class CreatorModeControl : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CreatorModeControl
        /// </summary>
        public static readonly CreatorModeControl DISABLED = new CreatorModeControl("DISABLED");
        /// <summary>
        /// Constant ENABLED for CreatorModeControl
        /// </summary>
        public static readonly CreatorModeControl ENABLED = new CreatorModeControl("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreatorModeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreatorModeControl FindValue(string value)
        {
            return FindValue<CreatorModeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreatorModeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAccessorAuthenticationType.
    /// </summary>
    public class DataAccessorAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM_IDC_AUTH_CODE for DataAccessorAuthenticationType
        /// </summary>
        public static readonly DataAccessorAuthenticationType AWS_IAM_IDC_AUTH_CODE = new DataAccessorAuthenticationType("AWS_IAM_IDC_AUTH_CODE");
        /// <summary>
        /// Constant AWS_IAM_IDC_TTI for DataAccessorAuthenticationType
        /// </summary>
        public static readonly DataAccessorAuthenticationType AWS_IAM_IDC_TTI = new DataAccessorAuthenticationType("AWS_IAM_IDC_TTI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAccessorAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAccessorAuthenticationType FindValue(string value)
        {
            return FindValue<DataAccessorAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAccessorAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus ACTIVE = new DataSourceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus CREATING = new DataSourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DELETING = new DataSourceStatus("DELETING");
        /// <summary>
        /// Constant FAILED for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED = new DataSourceStatus("FAILED");
        /// <summary>
        /// Constant PENDING_CREATION for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus PENDING_CREATION = new DataSourceStatus("PENDING_CREATION");
        /// <summary>
        /// Constant UPDATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus UPDATING = new DataSourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceStatus FindValue(string value)
        {
            return FindValue<DataSourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceSyncJobStatus.
    /// </summary>
    public class DataSourceSyncJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus ABORTED = new DataSourceSyncJobStatus("ABORTED");
        /// <summary>
        /// Constant FAILED for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus FAILED = new DataSourceSyncJobStatus("FAILED");
        /// <summary>
        /// Constant INCOMPLETE for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus INCOMPLETE = new DataSourceSyncJobStatus("INCOMPLETE");
        /// <summary>
        /// Constant STOPPING for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus STOPPING = new DataSourceSyncJobStatus("STOPPING");
        /// <summary>
        /// Constant SUCCEEDED for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus SUCCEEDED = new DataSourceSyncJobStatus("SUCCEEDED");
        /// <summary>
        /// Constant SYNCING for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus SYNCING = new DataSourceSyncJobStatus("SYNCING");
        /// <summary>
        /// Constant SYNCING_INDEXING for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus SYNCING_INDEXING = new DataSourceSyncJobStatus("SYNCING_INDEXING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceSyncJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceSyncJobStatus FindValue(string value)
        {
            return FindValue<DataSourceSyncJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceSyncJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentAttributeBoostingLevel.
    /// </summary>
    public class DocumentAttributeBoostingLevel : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel HIGH = new DocumentAttributeBoostingLevel("HIGH");
        /// <summary>
        /// Constant LOW for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel LOW = new DocumentAttributeBoostingLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel MEDIUM = new DocumentAttributeBoostingLevel("MEDIUM");
        /// <summary>
        /// Constant NONE for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel NONE = new DocumentAttributeBoostingLevel("NONE");
        /// <summary>
        /// Constant ONE for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel ONE = new DocumentAttributeBoostingLevel("ONE");
        /// <summary>
        /// Constant TWO for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel TWO = new DocumentAttributeBoostingLevel("TWO");
        /// <summary>
        /// Constant VERY_HIGH for DocumentAttributeBoostingLevel
        /// </summary>
        public static readonly DocumentAttributeBoostingLevel VERY_HIGH = new DocumentAttributeBoostingLevel("VERY_HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentAttributeBoostingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentAttributeBoostingLevel FindValue(string value)
        {
            return FindValue<DocumentAttributeBoostingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentAttributeBoostingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentContentOperator.
    /// </summary>
    public class DocumentContentOperator : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for DocumentContentOperator
        /// </summary>
        public static readonly DocumentContentOperator DELETE = new DocumentContentOperator("DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentContentOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentContentOperator FindValue(string value)
        {
            return FindValue<DocumentContentOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentContentOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentEnrichmentConditionOperator.
    /// </summary>
    public class DocumentEnrichmentConditionOperator : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator BEGINS_WITH = new DocumentEnrichmentConditionOperator("BEGINS_WITH");
        /// <summary>
        /// Constant CONTAINS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator CONTAINS = new DocumentEnrichmentConditionOperator("CONTAINS");
        /// <summary>
        /// Constant EQUALS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator EQUALS = new DocumentEnrichmentConditionOperator("EQUALS");
        /// <summary>
        /// Constant EXISTS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator EXISTS = new DocumentEnrichmentConditionOperator("EXISTS");
        /// <summary>
        /// Constant GREATER_THAN for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator GREATER_THAN = new DocumentEnrichmentConditionOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUALS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator GREATER_THAN_OR_EQUALS = new DocumentEnrichmentConditionOperator("GREATER_THAN_OR_EQUALS");
        /// <summary>
        /// Constant LESS_THAN for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator LESS_THAN = new DocumentEnrichmentConditionOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUALS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator LESS_THAN_OR_EQUALS = new DocumentEnrichmentConditionOperator("LESS_THAN_OR_EQUALS");
        /// <summary>
        /// Constant NOT_CONTAINS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator NOT_CONTAINS = new DocumentEnrichmentConditionOperator("NOT_CONTAINS");
        /// <summary>
        /// Constant NOT_EQUALS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator NOT_EQUALS = new DocumentEnrichmentConditionOperator("NOT_EQUALS");
        /// <summary>
        /// Constant NOT_EXISTS for DocumentEnrichmentConditionOperator
        /// </summary>
        public static readonly DocumentEnrichmentConditionOperator NOT_EXISTS = new DocumentEnrichmentConditionOperator("NOT_EXISTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentEnrichmentConditionOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentEnrichmentConditionOperator FindValue(string value)
        {
            return FindValue<DocumentEnrichmentConditionOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentEnrichmentConditionOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentStatus.
    /// </summary>
    public class DocumentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus DELETED = new DocumentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus DELETING = new DocumentStatus("DELETING");
        /// <summary>
        /// Constant DOCUMENT_FAILED_TO_INDEX for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus DOCUMENT_FAILED_TO_INDEX = new DocumentStatus("DOCUMENT_FAILED_TO_INDEX");
        /// <summary>
        /// Constant FAILED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus FAILED = new DocumentStatus("FAILED");
        /// <summary>
        /// Constant INDEXED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus INDEXED = new DocumentStatus("INDEXED");
        /// <summary>
        /// Constant PROCESSING for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus PROCESSING = new DocumentStatus("PROCESSING");
        /// <summary>
        /// Constant RECEIVED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus RECEIVED = new DocumentStatus("RECEIVED");
        /// <summary>
        /// Constant UPDATED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus UPDATED = new DocumentStatus("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentStatus FindValue(string value)
        {
            return FindValue<DocumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant InternalError for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalError = new ErrorCode("InternalError");
        /// <summary>
        /// Constant InvalidRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidRequest = new ErrorCode("InvalidRequest");
        /// <summary>
        /// Constant ResourceInactive for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceInactive = new ErrorCode("ResourceInactive");
        /// <summary>
        /// Constant ResourceNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceNotFound = new ErrorCode("ResourceNotFound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupStatus.
    /// </summary>
    public class GroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for GroupStatus
        /// </summary>
        public static readonly GroupStatus DELETED = new GroupStatus("DELETED");
        /// <summary>
        /// Constant DELETING for GroupStatus
        /// </summary>
        public static readonly GroupStatus DELETING = new GroupStatus("DELETING");
        /// <summary>
        /// Constant FAILED for GroupStatus
        /// </summary>
        public static readonly GroupStatus FAILED = new GroupStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for GroupStatus
        /// </summary>
        public static readonly GroupStatus PROCESSING = new GroupStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCEEDED for GroupStatus
        /// </summary>
        public static readonly GroupStatus SUCCEEDED = new GroupStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupStatus FindValue(string value)
        {
            return FindValue<GroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HallucinationReductionControl.
    /// </summary>
    public class HallucinationReductionControl : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for HallucinationReductionControl
        /// </summary>
        public static readonly HallucinationReductionControl DISABLED = new HallucinationReductionControl("DISABLED");
        /// <summary>
        /// Constant ENABLED for HallucinationReductionControl
        /// </summary>
        public static readonly HallucinationReductionControl ENABLED = new HallucinationReductionControl("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HallucinationReductionControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HallucinationReductionControl FindValue(string value)
        {
            return FindValue<HallucinationReductionControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HallucinationReductionControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMOUS for IdentityType
        /// </summary>
        public static readonly IdentityType ANONYMOUS = new IdentityType("ANONYMOUS");
        /// <summary>
        /// Constant AWS_IAM_IDC for IdentityType
        /// </summary>
        public static readonly IdentityType AWS_IAM_IDC = new IdentityType("AWS_IAM_IDC");
        /// <summary>
        /// Constant AWS_IAM_IDP_OIDC for IdentityType
        /// </summary>
        public static readonly IdentityType AWS_IAM_IDP_OIDC = new IdentityType("AWS_IAM_IDP_OIDC");
        /// <summary>
        /// Constant AWS_IAM_IDP_SAML for IdentityType
        /// </summary>
        public static readonly IdentityType AWS_IAM_IDP_SAML = new IdentityType("AWS_IAM_IDP_SAML");
        /// <summary>
        /// Constant AWS_QUICKSIGHT_IDP for IdentityType
        /// </summary>
        public static readonly IdentityType AWS_QUICKSIGHT_IDP = new IdentityType("AWS_QUICKSIGHT_IDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageExtractionStatus.
    /// </summary>
    public class ImageExtractionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ImageExtractionStatus
        /// </summary>
        public static readonly ImageExtractionStatus DISABLED = new ImageExtractionStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ImageExtractionStatus
        /// </summary>
        public static readonly ImageExtractionStatus ENABLED = new ImageExtractionStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageExtractionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageExtractionStatus FindValue(string value)
        {
            return FindValue<ImageExtractionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageExtractionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexStatus.
    /// </summary>
    public class IndexStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IndexStatus
        /// </summary>
        public static readonly IndexStatus ACTIVE = new IndexStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for IndexStatus
        /// </summary>
        public static readonly IndexStatus CREATING = new IndexStatus("CREATING");
        /// <summary>
        /// Constant DELETING for IndexStatus
        /// </summary>
        public static readonly IndexStatus DELETING = new IndexStatus("DELETING");
        /// <summary>
        /// Constant FAILED for IndexStatus
        /// </summary>
        public static readonly IndexStatus FAILED = new IndexStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for IndexStatus
        /// </summary>
        public static readonly IndexStatus UPDATING = new IndexStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexStatus FindValue(string value)
        {
            return FindValue<IndexStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexType.
    /// </summary>
    public class IndexType : ConstantClass
    {

        /// <summary>
        /// Constant ENTERPRISE for IndexType
        /// </summary>
        public static readonly IndexType ENTERPRISE = new IndexType("ENTERPRISE");
        /// <summary>
        /// Constant STARTER for IndexType
        /// </summary>
        public static readonly IndexType STARTER = new IndexType("STARTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexType FindValue(string value)
        {
            return FindValue<IndexType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberRelation.
    /// </summary>
    public class MemberRelation : ConstantClass
    {

        /// <summary>
        /// Constant AND for MemberRelation
        /// </summary>
        public static readonly MemberRelation AND = new MemberRelation("AND");
        /// <summary>
        /// Constant OR for MemberRelation
        /// </summary>
        public static readonly MemberRelation OR = new MemberRelation("OR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberRelation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberRelation FindValue(string value)
        {
            return FindValue<MemberRelation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberRelation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipType.
    /// </summary>
    public class MembershipType : ConstantClass
    {

        /// <summary>
        /// Constant DATASOURCE for MembershipType
        /// </summary>
        public static readonly MembershipType DATASOURCE = new MembershipType("DATASOURCE");
        /// <summary>
        /// Constant INDEX for MembershipType
        /// </summary>
        public static readonly MembershipType INDEX = new MembershipType("INDEX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipType FindValue(string value)
        {
            return FindValue<MembershipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant SYSTEM for MessageType
        /// </summary>
        public static readonly MessageType SYSTEM = new MessageType("SYSTEM");
        /// <summary>
        /// Constant USER for MessageType
        /// </summary>
        public static readonly MessageType USER = new MessageType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageUsefulness.
    /// </summary>
    public class MessageUsefulness : ConstantClass
    {

        /// <summary>
        /// Constant NOT_USEFUL for MessageUsefulness
        /// </summary>
        public static readonly MessageUsefulness NOT_USEFUL = new MessageUsefulness("NOT_USEFUL");
        /// <summary>
        /// Constant USEFUL for MessageUsefulness
        /// </summary>
        public static readonly MessageUsefulness USEFUL = new MessageUsefulness("USEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageUsefulness(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageUsefulness FindValue(string value)
        {
            return FindValue<MessageUsefulness>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageUsefulness(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageUsefulnessReason.
    /// </summary>
    public class MessageUsefulnessReason : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason COMPLETE = new MessageUsefulnessReason("COMPLETE");
        /// <summary>
        /// Constant FACTUALLY_CORRECT for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason FACTUALLY_CORRECT = new MessageUsefulnessReason("FACTUALLY_CORRECT");
        /// <summary>
        /// Constant HARMFUL_OR_UNSAFE for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason HARMFUL_OR_UNSAFE = new MessageUsefulnessReason("HARMFUL_OR_UNSAFE");
        /// <summary>
        /// Constant HELPFUL for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason HELPFUL = new MessageUsefulnessReason("HELPFUL");
        /// <summary>
        /// Constant INCORRECT_OR_MISSING_SOURCES for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason INCORRECT_OR_MISSING_SOURCES = new MessageUsefulnessReason("INCORRECT_OR_MISSING_SOURCES");
        /// <summary>
        /// Constant NOT_BASED_ON_DOCUMENTS for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason NOT_BASED_ON_DOCUMENTS = new MessageUsefulnessReason("NOT_BASED_ON_DOCUMENTS");
        /// <summary>
        /// Constant NOT_COMPLETE for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason NOT_COMPLETE = new MessageUsefulnessReason("NOT_COMPLETE");
        /// <summary>
        /// Constant NOT_CONCISE for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason NOT_CONCISE = new MessageUsefulnessReason("NOT_CONCISE");
        /// <summary>
        /// Constant NOT_FACTUALLY_CORRECT for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason NOT_FACTUALLY_CORRECT = new MessageUsefulnessReason("NOT_FACTUALLY_CORRECT");
        /// <summary>
        /// Constant NOT_HELPFUL for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason NOT_HELPFUL = new MessageUsefulnessReason("NOT_HELPFUL");
        /// <summary>
        /// Constant OTHER for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason OTHER = new MessageUsefulnessReason("OTHER");
        /// <summary>
        /// Constant RELEVANT_SOURCES for MessageUsefulnessReason
        /// </summary>
        public static readonly MessageUsefulnessReason RELEVANT_SOURCES = new MessageUsefulnessReason("RELEVANT_SOURCES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageUsefulnessReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageUsefulnessReason FindValue(string value)
        {
            return FindValue<MessageUsefulnessReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageUsefulnessReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberAttributeBoostingType.
    /// </summary>
    public class NumberAttributeBoostingType : ConstantClass
    {

        /// <summary>
        /// Constant PRIORITIZE_LARGER_VALUES for NumberAttributeBoostingType
        /// </summary>
        public static readonly NumberAttributeBoostingType PRIORITIZE_LARGER_VALUES = new NumberAttributeBoostingType("PRIORITIZE_LARGER_VALUES");
        /// <summary>
        /// Constant PRIORITIZE_SMALLER_VALUES for NumberAttributeBoostingType
        /// </summary>
        public static readonly NumberAttributeBoostingType PRIORITIZE_SMALLER_VALUES = new NumberAttributeBoostingType("PRIORITIZE_SMALLER_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberAttributeBoostingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberAttributeBoostingType FindValue(string value)
        {
            return FindValue<NumberAttributeBoostingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberAttributeBoostingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrchestrationControl.
    /// </summary>
    public class OrchestrationControl : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OrchestrationControl
        /// </summary>
        public static readonly OrchestrationControl DISABLED = new OrchestrationControl("DISABLED");
        /// <summary>
        /// Constant ENABLED for OrchestrationControl
        /// </summary>
        public static readonly OrchestrationControl ENABLED = new OrchestrationControl("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrchestrationControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrchestrationControl FindValue(string value)
        {
            return FindValue<OrchestrationControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrchestrationControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant EXTRACTED for OutputFormat
        /// </summary>
        public static readonly OutputFormat EXTRACTED = new OutputFormat("EXTRACTED");
        /// <summary>
        /// Constant RAW for OutputFormat
        /// </summary>
        public static readonly OutputFormat RAW = new OutputFormat("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputFormat FindValue(string value)
        {
            return FindValue<OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionConditionOperator.
    /// </summary>
    public class PermissionConditionOperator : ConstantClass
    {

        /// <summary>
        /// Constant StringEquals for PermissionConditionOperator
        /// </summary>
        public static readonly PermissionConditionOperator StringEquals = new PermissionConditionOperator("StringEquals");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionConditionOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionConditionOperator FindValue(string value)
        {
            return FindValue<PermissionConditionOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionConditionOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PersonalizationControlMode.
    /// </summary>
    public class PersonalizationControlMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PersonalizationControlMode
        /// </summary>
        public static readonly PersonalizationControlMode DISABLED = new PersonalizationControlMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for PersonalizationControlMode
        /// </summary>
        public static readonly PersonalizationControlMode ENABLED = new PersonalizationControlMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PersonalizationControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PersonalizationControlMode FindValue(string value)
        {
            return FindValue<PersonalizationControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PersonalizationControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PluginBuildStatus.
    /// </summary>
    public class PluginBuildStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus CREATE_FAILED = new PluginBuildStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus CREATE_IN_PROGRESS = new PluginBuildStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus DELETE_FAILED = new PluginBuildStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus DELETE_IN_PROGRESS = new PluginBuildStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant READY for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus READY = new PluginBuildStatus("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus UPDATE_FAILED = new PluginBuildStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for PluginBuildStatus
        /// </summary>
        public static readonly PluginBuildStatus UPDATE_IN_PROGRESS = new PluginBuildStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PluginBuildStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PluginBuildStatus FindValue(string value)
        {
            return FindValue<PluginBuildStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PluginBuildStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PluginState.
    /// </summary>
    public class PluginState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PluginState
        /// </summary>
        public static readonly PluginState DISABLED = new PluginState("DISABLED");
        /// <summary>
        /// Constant ENABLED for PluginState
        /// </summary>
        public static readonly PluginState ENABLED = new PluginState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PluginState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PluginState FindValue(string value)
        {
            return FindValue<PluginState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PluginState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PluginType.
    /// </summary>
    public class PluginType : ConstantClass
    {

        /// <summary>
        /// Constant ASANA for PluginType
        /// </summary>
        public static readonly PluginType ASANA = new PluginType("ASANA");
        /// <summary>
        /// Constant ATLASSIAN_CONFLUENCE for PluginType
        /// </summary>
        public static readonly PluginType ATLASSIAN_CONFLUENCE = new PluginType("ATLASSIAN_CONFLUENCE");
        /// <summary>
        /// Constant CUSTOM for PluginType
        /// </summary>
        public static readonly PluginType CUSTOM = new PluginType("CUSTOM");
        /// <summary>
        /// Constant GOOGLE_CALENDAR for PluginType
        /// </summary>
        public static readonly PluginType GOOGLE_CALENDAR = new PluginType("GOOGLE_CALENDAR");
        /// <summary>
        /// Constant JIRA for PluginType
        /// </summary>
        public static readonly PluginType JIRA = new PluginType("JIRA");
        /// <summary>
        /// Constant JIRA_CLOUD for PluginType
        /// </summary>
        public static readonly PluginType JIRA_CLOUD = new PluginType("JIRA_CLOUD");
        /// <summary>
        /// Constant MICROSOFT_EXCHANGE for PluginType
        /// </summary>
        public static readonly PluginType MICROSOFT_EXCHANGE = new PluginType("MICROSOFT_EXCHANGE");
        /// <summary>
        /// Constant MICROSOFT_TEAMS for PluginType
        /// </summary>
        public static readonly PluginType MICROSOFT_TEAMS = new PluginType("MICROSOFT_TEAMS");
        /// <summary>
        /// Constant PAGERDUTY_ADVANCE for PluginType
        /// </summary>
        public static readonly PluginType PAGERDUTY_ADVANCE = new PluginType("PAGERDUTY_ADVANCE");
        /// <summary>
        /// Constant QUICKSIGHT for PluginType
        /// </summary>
        public static readonly PluginType QUICKSIGHT = new PluginType("QUICKSIGHT");
        /// <summary>
        /// Constant SALESFORCE for PluginType
        /// </summary>
        public static readonly PluginType SALESFORCE = new PluginType("SALESFORCE");
        /// <summary>
        /// Constant SALESFORCE_CRM for PluginType
        /// </summary>
        public static readonly PluginType SALESFORCE_CRM = new PluginType("SALESFORCE_CRM");
        /// <summary>
        /// Constant SERVICE_NOW for PluginType
        /// </summary>
        public static readonly PluginType SERVICE_NOW = new PluginType("SERVICE_NOW");
        /// <summary>
        /// Constant SERVICENOW_NOW_PLATFORM for PluginType
        /// </summary>
        public static readonly PluginType SERVICENOW_NOW_PLATFORM = new PluginType("SERVICENOW_NOW_PLATFORM");
        /// <summary>
        /// Constant SMARTSHEET for PluginType
        /// </summary>
        public static readonly PluginType SMARTSHEET = new PluginType("SMARTSHEET");
        /// <summary>
        /// Constant ZENDESK for PluginType
        /// </summary>
        public static readonly PluginType ZENDESK = new PluginType("ZENDESK");
        /// <summary>
        /// Constant ZENDESK_SUITE for PluginType
        /// </summary>
        public static readonly PluginType ZENDESK_SUITE = new PluginType("ZENDESK_SUITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PluginType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PluginType FindValue(string value)
        {
            return FindValue<PluginType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PluginType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PluginTypeCategory.
    /// </summary>
    public class PluginTypeCategory : ConstantClass
    {

        /// <summary>
        /// Constant Communication for PluginTypeCategory
        /// </summary>
        public static readonly PluginTypeCategory Communication = new PluginTypeCategory("Communication");
        /// <summary>
        /// Constant CustomerRelationshipManagementCRM for PluginTypeCategory
        /// </summary>
        public static readonly PluginTypeCategory CustomerRelationshipManagementCRM = new PluginTypeCategory("Customer relationship management (CRM)");
        /// <summary>
        /// Constant Productivity for PluginTypeCategory
        /// </summary>
        public static readonly PluginTypeCategory Productivity = new PluginTypeCategory("Productivity");
        /// <summary>
        /// Constant ProjectManagement for PluginTypeCategory
        /// </summary>
        public static readonly PluginTypeCategory ProjectManagement = new PluginTypeCategory("Project management");
        /// <summary>
        /// Constant TicketingAndIncidentManagement for PluginTypeCategory
        /// </summary>
        public static readonly PluginTypeCategory TicketingAndIncidentManagement = new PluginTypeCategory("Ticketing and incident management");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PluginTypeCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PluginTypeCategory FindValue(string value)
        {
            return FindValue<PluginTypeCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PluginTypeCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QAppsControlMode.
    /// </summary>
    public class QAppsControlMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for QAppsControlMode
        /// </summary>
        public static readonly QAppsControlMode DISABLED = new QAppsControlMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for QAppsControlMode
        /// </summary>
        public static readonly QAppsControlMode ENABLED = new QAppsControlMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QAppsControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QAppsControlMode FindValue(string value)
        {
            return FindValue<QAppsControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QAppsControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadAccessType.
    /// </summary>
    public class ReadAccessType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for ReadAccessType
        /// </summary>
        public static readonly ReadAccessType ALLOW = new ReadAccessType("ALLOW");
        /// <summary>
        /// Constant DENY for ReadAccessType
        /// </summary>
        public static readonly ReadAccessType DENY = new ReadAccessType("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadAccessType FindValue(string value)
        {
            return FindValue<ReadAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseConfigurationType.
    /// </summary>
    public class ResponseConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ResponseConfigurationType
        /// </summary>
        public static readonly ResponseConfigurationType ALL = new ResponseConfigurationType("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseConfigurationType FindValue(string value)
        {
            return FindValue<ResponseConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseScope.
    /// </summary>
    public class ResponseScope : ConstantClass
    {

        /// <summary>
        /// Constant ENTERPRISE_CONTENT_ONLY for ResponseScope
        /// </summary>
        public static readonly ResponseScope ENTERPRISE_CONTENT_ONLY = new ResponseScope("ENTERPRISE_CONTENT_ONLY");
        /// <summary>
        /// Constant EXTENDED_KNOWLEDGE_ENABLED for ResponseScope
        /// </summary>
        public static readonly ResponseScope EXTENDED_KNOWLEDGE_ENABLED = new ResponseScope("EXTENDED_KNOWLEDGE_ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseScope FindValue(string value)
        {
            return FindValue<ResponseScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrieverStatus.
    /// </summary>
    public class RetrieverStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RetrieverStatus
        /// </summary>
        public static readonly RetrieverStatus ACTIVE = new RetrieverStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for RetrieverStatus
        /// </summary>
        public static readonly RetrieverStatus CREATING = new RetrieverStatus("CREATING");
        /// <summary>
        /// Constant FAILED for RetrieverStatus
        /// </summary>
        public static readonly RetrieverStatus FAILED = new RetrieverStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrieverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrieverStatus FindValue(string value)
        {
            return FindValue<RetrieverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrieverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrieverType.
    /// </summary>
    public class RetrieverType : ConstantClass
    {

        /// <summary>
        /// Constant KENDRA_INDEX for RetrieverType
        /// </summary>
        public static readonly RetrieverType KENDRA_INDEX = new RetrieverType("KENDRA_INDEX");
        /// <summary>
        /// Constant NATIVE_INDEX for RetrieverType
        /// </summary>
        public static readonly RetrieverType NATIVE_INDEX = new RetrieverType("NATIVE_INDEX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrieverType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrieverType FindValue(string value)
        {
            return FindValue<RetrieverType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrieverType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant CONTENT_BLOCKER_RULE for RuleType
        /// </summary>
        public static readonly RuleType CONTENT_BLOCKER_RULE = new RuleType("CONTENT_BLOCKER_RULE");
        /// <summary>
        /// Constant CONTENT_RETRIEVAL_RULE for RuleType
        /// </summary>
        public static readonly RuleType CONTENT_RETRIEVAL_RULE = new RuleType("CONTENT_RETRIEVAL_RULE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScoreConfidence.
    /// </summary>
    public class ScoreConfidence : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence HIGH = new ScoreConfidence("HIGH");
        /// <summary>
        /// Constant LOW for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence LOW = new ScoreConfidence("LOW");
        /// <summary>
        /// Constant MEDIUM for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence MEDIUM = new ScoreConfidence("MEDIUM");
        /// <summary>
        /// Constant NOT_AVAILABLE for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence NOT_AVAILABLE = new ScoreConfidence("NOT_AVAILABLE");
        /// <summary>
        /// Constant VERY_HIGH for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence VERY_HIGH = new ScoreConfidence("VERY_HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScoreConfidence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScoreConfidence FindValue(string value)
        {
            return FindValue<ScoreConfidence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScoreConfidence(string value)
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
        /// Constant DISABLED for Status
        /// </summary>
        public static readonly Status DISABLED = new Status("DISABLED");
        /// <summary>
        /// Constant ENABLED for Status
        /// </summary>
        public static readonly Status ENABLED = new Status("ENABLED");

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
    /// Constants used for properties of type StringAttributeValueBoostingLevel.
    /// </summary>
    public class StringAttributeValueBoostingLevel : ConstantClass
    {

        /// <summary>
        /// Constant FIVE for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel FIVE = new StringAttributeValueBoostingLevel("FIVE");
        /// <summary>
        /// Constant FOUR for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel FOUR = new StringAttributeValueBoostingLevel("FOUR");
        /// <summary>
        /// Constant HIGH for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel HIGH = new StringAttributeValueBoostingLevel("HIGH");
        /// <summary>
        /// Constant LOW for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel LOW = new StringAttributeValueBoostingLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel MEDIUM = new StringAttributeValueBoostingLevel("MEDIUM");
        /// <summary>
        /// Constant ONE for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel ONE = new StringAttributeValueBoostingLevel("ONE");
        /// <summary>
        /// Constant THREE for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel THREE = new StringAttributeValueBoostingLevel("THREE");
        /// <summary>
        /// Constant TWO for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel TWO = new StringAttributeValueBoostingLevel("TWO");
        /// <summary>
        /// Constant VERY_HIGH for StringAttributeValueBoostingLevel
        /// </summary>
        public static readonly StringAttributeValueBoostingLevel VERY_HIGH = new StringAttributeValueBoostingLevel("VERY_HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringAttributeValueBoostingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringAttributeValueBoostingLevel FindValue(string value)
        {
            return FindValue<StringAttributeValueBoostingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringAttributeValueBoostingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionType.
    /// </summary>
    public class SubscriptionType : ConstantClass
    {

        /// <summary>
        /// Constant Q_BUSINESS for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType Q_BUSINESS = new SubscriptionType("Q_BUSINESS");
        /// <summary>
        /// Constant Q_LITE for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType Q_LITE = new SubscriptionType("Q_LITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionType FindValue(string value)
        {
            return FindValue<SubscriptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SystemMessageType.
    /// </summary>
    public class SystemMessageType : ConstantClass
    {

        /// <summary>
        /// Constant GROUNDED_RESPONSE for SystemMessageType
        /// </summary>
        public static readonly SystemMessageType GROUNDED_RESPONSE = new SystemMessageType("GROUNDED_RESPONSE");
        /// <summary>
        /// Constant RESPONSE for SystemMessageType
        /// </summary>
        public static readonly SystemMessageType RESPONSE = new SystemMessageType("RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SystemMessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemMessageType FindValue(string value)
        {
            return FindValue<SystemMessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemMessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoExtractionStatus.
    /// </summary>
    public class VideoExtractionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for VideoExtractionStatus
        /// </summary>
        public static readonly VideoExtractionStatus DISABLED = new VideoExtractionStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for VideoExtractionStatus
        /// </summary>
        public static readonly VideoExtractionStatus ENABLED = new VideoExtractionStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoExtractionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoExtractionStatus FindValue(string value)
        {
            return FindValue<VideoExtractionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoExtractionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoExtractionType.
    /// </summary>
    public class VideoExtractionType : ConstantClass
    {

        /// <summary>
        /// Constant SUMMARY for VideoExtractionType
        /// </summary>
        public static readonly VideoExtractionType SUMMARY = new VideoExtractionType("SUMMARY");
        /// <summary>
        /// Constant TRANSCRIPT for VideoExtractionType
        /// </summary>
        public static readonly VideoExtractionType TRANSCRIPT = new VideoExtractionType("TRANSCRIPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoExtractionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoExtractionType FindValue(string value)
        {
            return FindValue<VideoExtractionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoExtractionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebExperienceSamplePromptsControlMode.
    /// </summary>
    public class WebExperienceSamplePromptsControlMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WebExperienceSamplePromptsControlMode
        /// </summary>
        public static readonly WebExperienceSamplePromptsControlMode DISABLED = new WebExperienceSamplePromptsControlMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for WebExperienceSamplePromptsControlMode
        /// </summary>
        public static readonly WebExperienceSamplePromptsControlMode ENABLED = new WebExperienceSamplePromptsControlMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebExperienceSamplePromptsControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebExperienceSamplePromptsControlMode FindValue(string value)
        {
            return FindValue<WebExperienceSamplePromptsControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebExperienceSamplePromptsControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebExperienceStatus.
    /// </summary>
    public class WebExperienceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WebExperienceStatus
        /// </summary>
        public static readonly WebExperienceStatus ACTIVE = new WebExperienceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for WebExperienceStatus
        /// </summary>
        public static readonly WebExperienceStatus CREATING = new WebExperienceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for WebExperienceStatus
        /// </summary>
        public static readonly WebExperienceStatus DELETING = new WebExperienceStatus("DELETING");
        /// <summary>
        /// Constant FAILED for WebExperienceStatus
        /// </summary>
        public static readonly WebExperienceStatus FAILED = new WebExperienceStatus("FAILED");
        /// <summary>
        /// Constant PENDING_AUTH_CONFIG for WebExperienceStatus
        /// </summary>
        public static readonly WebExperienceStatus PENDING_AUTH_CONFIG = new WebExperienceStatus("PENDING_AUTH_CONFIG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebExperienceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebExperienceStatus FindValue(string value)
        {
            return FindValue<WebExperienceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebExperienceStatus(string value)
        {
            return FindValue(value);
        }
    }

}