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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EndUserMessaging
{

    /// <summary>
    /// Constants used for properties of type BrandProfileAttributeType.
    /// </summary>
    public class BrandProfileAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT for BrandProfileAttributeType
        /// </summary>
        public static readonly BrandProfileAttributeType DOCUMENT = new BrandProfileAttributeType("DOCUMENT");
        /// <summary>
        /// Constant IMAGE for BrandProfileAttributeType
        /// </summary>
        public static readonly BrandProfileAttributeType IMAGE = new BrandProfileAttributeType("IMAGE");
        /// <summary>
        /// Constant TEXT for BrandProfileAttributeType
        /// </summary>
        public static readonly BrandProfileAttributeType TEXT = new BrandProfileAttributeType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrandProfileAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrandProfileAttributeType FindValue(string value)
        {
            return FindValue<BrandProfileAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrandProfileAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeType.
    /// </summary>
    public class CodeType : ConstantClass
    {

        /// <summary>
        /// Constant ALPHA for CodeType
        /// </summary>
        public static readonly CodeType ALPHA = new CodeType("ALPHA");
        /// <summary>
        /// Constant ALPHANUMERIC for CodeType
        /// </summary>
        public static readonly CodeType ALPHANUMERIC = new CodeType("ALPHANUMERIC");
        /// <summary>
        /// Constant NUMERIC for CodeType
        /// </summary>
        public static readonly CodeType NUMERIC = new CodeType("NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeType FindValue(string value)
        {
            return FindValue<CodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobResourceType.
    /// </summary>
    public class JobResourceType : ConstantClass
    {

        /// <summary>
        /// Constant BRAND_PROFILE for JobResourceType
        /// </summary>
        public static readonly JobResourceType BRAND_PROFILE = new JobResourceType("BRAND_PROFILE");
        /// <summary>
        /// Constant REGISTRATION for JobResourceType
        /// </summary>
        public static readonly JobResourceType REGISTRATION = new JobResourceType("REGISTRATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobResourceType FindValue(string value)
        {
            return FindValue<JobResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for JobStatus
        /// </summary>
        public static readonly JobStatus PROCESSING = new JobStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCESS for JobStatus
        /// </summary>
        public static readonly JobStatus SUCCESS = new JobStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotifyChannel.
    /// </summary>
    public class NotifyChannel : ConstantClass
    {

        /// <summary>
        /// Constant TEXT for NotifyChannel
        /// </summary>
        public static readonly NotifyChannel TEXT = new NotifyChannel("TEXT");
        /// <summary>
        /// Constant VOICE for NotifyChannel
        /// </summary>
        public static readonly NotifyChannel VOICE = new NotifyChannel("VOICE");
        /// <summary>
        /// Constant WHATSAPP for NotifyChannel
        /// </summary>
        public static readonly NotifyChannel WHATSAPP = new NotifyChannel("WHATSAPP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotifyChannel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotifyChannel FindValue(string value)
        {
            return FindValue<NotifyChannel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotifyChannel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnAttributeConflict.
    /// </summary>
    public class OnAttributeConflict : ConstantClass
    {

        /// <summary>
        /// Constant PRESERVE for OnAttributeConflict
        /// </summary>
        public static readonly OnAttributeConflict PRESERVE = new OnAttributeConflict("PRESERVE");
        /// <summary>
        /// Constant REPLACE for OnAttributeConflict
        /// </summary>
        public static readonly OnAttributeConflict REPLACE = new OnAttributeConflict("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnAttributeConflict(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnAttributeConflict FindValue(string value)
        {
            return FindValue<OnAttributeConflict>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnAttributeConflict(string value)
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
        /// Constant ACTIVE for Status
        /// </summary>
        public static readonly Status ACTIVE = new Status("ACTIVE");
        /// <summary>
        /// Constant BLOCKED for Status
        /// </summary>
        public static readonly Status BLOCKED = new Status("BLOCKED");
        /// <summary>
        /// Constant CANCELLED for Status
        /// </summary>
        public static readonly Status CANCELLED = new Status("CANCELLED");
        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant PAUSED for Status
        /// </summary>
        public static readonly Status PAUSED = new Status("PAUSED");

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
    /// Constants used for properties of type VerificationStatus.
    /// </summary>
    public class VerificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant INVALID for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus INVALID = new VerificationStatus("INVALID");
        /// <summary>
        /// Constant VALID for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus VALID = new VerificationStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationStatus FindValue(string value)
        {
            return FindValue<VerificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceMessageBodyTextType.
    /// </summary>
    public class VoiceMessageBodyTextType : ConstantClass
    {

        /// <summary>
        /// Constant SSML for VoiceMessageBodyTextType
        /// </summary>
        public static readonly VoiceMessageBodyTextType SSML = new VoiceMessageBodyTextType("SSML");
        /// <summary>
        /// Constant TEXT for VoiceMessageBodyTextType
        /// </summary>
        public static readonly VoiceMessageBodyTextType TEXT = new VoiceMessageBodyTextType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceMessageBodyTextType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceMessageBodyTextType FindValue(string value)
        {
            return FindValue<VoiceMessageBodyTextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceMessageBodyTextType(string value)
        {
            return FindValue(value);
        }
    }

}