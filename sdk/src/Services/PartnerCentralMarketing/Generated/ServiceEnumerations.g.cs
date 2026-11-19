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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.PartnerCentralMarketing
{
    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {
        /// <summary>
        /// Constant INCOMPATIBLE_BENEFIT_AWS_PARTNER_STATE for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason INCOMPATIBLE_BENEFIT_AWS_PARTNER_STATE = new AccessDeniedExceptionReason("INCOMPATIBLE_BENEFIT_AWS_PARTNER_STATE");

        /// <summary>
        /// Constructs a custom AccessDeniedExceptionReason for a value not among the defined constants.
        /// </summary>
        public AccessDeniedExceptionReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AssetLanguage.
    /// </summary>
    public class AssetLanguage : ConstantClass
    {
        /// <summary>
        /// Constant Ar for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Ar = new AssetLanguage("ar");

        /// <summary>
        /// Constant De for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage De = new AssetLanguage("de");

        /// <summary>
        /// Constant En for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage En = new AssetLanguage("en");

        /// <summary>
        /// Constant Es for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Es = new AssetLanguage("es");

        /// <summary>
        /// Constant Es419 for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Es419 = new AssetLanguage("es-419");

        /// <summary>
        /// Constant Fr for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Fr = new AssetLanguage("fr");

        /// <summary>
        /// Constant Id for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Id = new AssetLanguage("id");

        /// <summary>
        /// Constant It for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage It = new AssetLanguage("it");

        /// <summary>
        /// Constant Ja for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Ja = new AssetLanguage("ja");

        /// <summary>
        /// Constant Ko for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Ko = new AssetLanguage("ko");

        /// <summary>
        /// Constant PtBR for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage PtBR = new AssetLanguage("pt-BR");

        /// <summary>
        /// Constant Tr for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage Tr = new AssetLanguage("tr");

        /// <summary>
        /// Constant ZhHans for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage ZhHans = new AssetLanguage("zh-Hans");

        /// <summary>
        /// Constant ZhHant for AssetLanguage
        /// </summary>
        public static readonly AssetLanguage ZhHant = new AssetLanguage("zh-Hant");

        /// <summary>
        /// Constructs a custom AssetLanguage for a value not among the defined constants.
        /// </summary>
        public AssetLanguage(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetLanguage FindValue(string value)
        {
            return FindValue<AssetLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetLanguage(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AttemptStatus.
    /// </summary>
    public class AttemptStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for AttemptStatus
        /// </summary>
        public static readonly AttemptStatus FAILED = new AttemptStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for AttemptStatus
        /// </summary>
        public static readonly AttemptStatus IN_PROGRESS = new AttemptStatus("IN_PROGRESS");

        /// <summary>
        /// Constant SUCCEEDED for AttemptStatus
        /// </summary>
        public static readonly AttemptStatus SUCCEEDED = new AttemptStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom AttemptStatus for a value not among the defined constants.
        /// </summary>
        public AttemptStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttemptStatus FindValue(string value)
        {
            return FindValue<AttemptStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttemptStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetActivationStatus.
    /// </summary>
    public class CampaignAssetActivationStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for CampaignAssetActivationStatus
        /// </summary>
        public static readonly CampaignAssetActivationStatus FAILED = new CampaignAssetActivationStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for CampaignAssetActivationStatus
        /// </summary>
        public static readonly CampaignAssetActivationStatus IN_PROGRESS = new CampaignAssetActivationStatus("IN_PROGRESS");

        /// <summary>
        /// Constant SUCCEEDED for CampaignAssetActivationStatus
        /// </summary>
        public static readonly CampaignAssetActivationStatus SUCCEEDED = new CampaignAssetActivationStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom CampaignAssetActivationStatus for a value not among the defined constants.
        /// </summary>
        public CampaignAssetActivationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetActivationStatus FindValue(string value)
        {
            return FindValue<CampaignAssetActivationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetActivationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetActivationTaskStatus.
    /// </summary>
    public class CampaignAssetActivationTaskStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for CampaignAssetActivationTaskStatus
        /// </summary>
        public static readonly CampaignAssetActivationTaskStatus FAILED = new CampaignAssetActivationTaskStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for CampaignAssetActivationTaskStatus
        /// </summary>
        public static readonly CampaignAssetActivationTaskStatus IN_PROGRESS = new CampaignAssetActivationTaskStatus("IN_PROGRESS");

        /// <summary>
        /// Constant PARTIAL_FAILURE for CampaignAssetActivationTaskStatus
        /// </summary>
        public static readonly CampaignAssetActivationTaskStatus PARTIAL_FAILURE = new CampaignAssetActivationTaskStatus("PARTIAL_FAILURE");

        /// <summary>
        /// Constant SUCCEEDED for CampaignAssetActivationTaskStatus
        /// </summary>
        public static readonly CampaignAssetActivationTaskStatus SUCCEEDED = new CampaignAssetActivationTaskStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom CampaignAssetActivationTaskStatus for a value not among the defined constants.
        /// </summary>
        public CampaignAssetActivationTaskStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetActivationTaskStatus FindValue(string value)
        {
            return FindValue<CampaignAssetActivationTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetActivationTaskStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetCategory.
    /// </summary>
    public class CampaignAssetCategory : ConstantClass
    {
        /// <summary>
        /// Constant BANNER_AD for CampaignAssetCategory
        /// </summary>
        public static readonly CampaignAssetCategory BANNER_AD = new CampaignAssetCategory("BANNER_AD");

        /// <summary>
        /// Constant DOCUMENT for CampaignAssetCategory
        /// </summary>
        public static readonly CampaignAssetCategory DOCUMENT = new CampaignAssetCategory("DOCUMENT");

        /// <summary>
        /// Constant EMAIL for CampaignAssetCategory
        /// </summary>
        public static readonly CampaignAssetCategory EMAIL = new CampaignAssetCategory("EMAIL");

        /// <summary>
        /// Constant LANDING_PAGE for CampaignAssetCategory
        /// </summary>
        public static readonly CampaignAssetCategory LANDING_PAGE = new CampaignAssetCategory("LANDING_PAGE");

        /// <summary>
        /// Constant SOCIAL_POST for CampaignAssetCategory
        /// </summary>
        public static readonly CampaignAssetCategory SOCIAL_POST = new CampaignAssetCategory("SOCIAL_POST");

        /// <summary>
        /// Constructs a custom CampaignAssetCategory for a value not among the defined constants.
        /// </summary>
        public CampaignAssetCategory(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetCategory FindValue(string value)
        {
            return FindValue<CampaignAssetCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetCategory(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetExportFailureCode.
    /// </summary>
    public class CampaignAssetExportFailureCode : ConstantClass
    {
        /// <summary>
        /// Constant EXPORT_TIMEOUT for CampaignAssetExportFailureCode
        /// </summary>
        public static readonly CampaignAssetExportFailureCode EXPORT_TIMEOUT = new CampaignAssetExportFailureCode("EXPORT_TIMEOUT");

        /// <summary>
        /// Constant EXPORT_TOO_LARGE for CampaignAssetExportFailureCode
        /// </summary>
        public static readonly CampaignAssetExportFailureCode EXPORT_TOO_LARGE = new CampaignAssetExportFailureCode("EXPORT_TOO_LARGE");

        /// <summary>
        /// Constant INTERNAL_ERROR for CampaignAssetExportFailureCode
        /// </summary>
        public static readonly CampaignAssetExportFailureCode INTERNAL_ERROR = new CampaignAssetExportFailureCode("INTERNAL_ERROR");

        /// <summary>
        /// Constant PACKAGING_ERROR for CampaignAssetExportFailureCode
        /// </summary>
        public static readonly CampaignAssetExportFailureCode PACKAGING_ERROR = new CampaignAssetExportFailureCode("PACKAGING_ERROR");

        /// <summary>
        /// Constant SOURCE_OBJECT_MISSING for CampaignAssetExportFailureCode
        /// </summary>
        public static readonly CampaignAssetExportFailureCode SOURCE_OBJECT_MISSING = new CampaignAssetExportFailureCode("SOURCE_OBJECT_MISSING");

        /// <summary>
        /// Constructs a custom CampaignAssetExportFailureCode for a value not among the defined constants.
        /// </summary>
        public CampaignAssetExportFailureCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetExportFailureCode FindValue(string value)
        {
            return FindValue<CampaignAssetExportFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetExportFailureCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetExportTaskStatus.
    /// </summary>
    public class CampaignAssetExportTaskStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for CampaignAssetExportTaskStatus
        /// </summary>
        public static readonly CampaignAssetExportTaskStatus COMPLETED = new CampaignAssetExportTaskStatus("COMPLETED");

        /// <summary>
        /// Constant FAILED for CampaignAssetExportTaskStatus
        /// </summary>
        public static readonly CampaignAssetExportTaskStatus FAILED = new CampaignAssetExportTaskStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for CampaignAssetExportTaskStatus
        /// </summary>
        public static readonly CampaignAssetExportTaskStatus IN_PROGRESS = new CampaignAssetExportTaskStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom CampaignAssetExportTaskStatus for a value not among the defined constants.
        /// </summary>
        public CampaignAssetExportTaskStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetExportTaskStatus FindValue(string value)
        {
            return FindValue<CampaignAssetExportTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetExportTaskStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetState.
    /// </summary>
    public class CampaignAssetState : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for CampaignAssetState
        /// </summary>
        public static readonly CampaignAssetState ACTIVE = new CampaignAssetState("ACTIVE");

        /// <summary>
        /// Constant INACTIVE for CampaignAssetState
        /// </summary>
        public static readonly CampaignAssetState INACTIVE = new CampaignAssetState("INACTIVE");

        /// <summary>
        /// Constructs a custom CampaignAssetState for a value not among the defined constants.
        /// </summary>
        public CampaignAssetState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetState FindValue(string value)
        {
            return FindValue<CampaignAssetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetStateReason.
    /// </summary>
    public class CampaignAssetStateReason : ConstantClass
    {
        /// <summary>
        /// Constant ASSET_ALREADY_ACTIVE for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ASSET_ALREADY_ACTIVE = new CampaignAssetStateReason("ASSET_ALREADY_ACTIVE");

        /// <summary>
        /// Constant ASSET_CONTENT_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ASSET_CONTENT_MISSING = new CampaignAssetStateReason("ASSET_CONTENT_MISSING");

        /// <summary>
        /// Constant ASSET_NOT_ACTIVATABLE for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ASSET_NOT_ACTIVATABLE = new CampaignAssetStateReason("ASSET_NOT_ACTIVATABLE");

        /// <summary>
        /// Constant ASSET_NOT_FOUND for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ASSET_NOT_FOUND = new CampaignAssetStateReason("ASSET_NOT_FOUND");

        /// <summary>
        /// Constant ASSET_NOT_STARTABLE for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ASSET_NOT_STARTABLE = new CampaignAssetStateReason("ASSET_NOT_STARTABLE");

        /// <summary>
        /// Constant ASSET_START_IN_PROGRESS for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ASSET_START_IN_PROGRESS = new CampaignAssetStateReason("ASSET_START_IN_PROGRESS");

        /// <summary>
        /// Constant CONTACT_OPT_IN_REQUIRED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason CONTACT_OPT_IN_REQUIRED = new CampaignAssetStateReason("CONTACT_OPT_IN_REQUIRED");

        /// <summary>
        /// Constant CONTENT_REJECTED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason CONTENT_REJECTED = new CampaignAssetStateReason("CONTENT_REJECTED");

        /// <summary>
        /// Constant DELIVERY_FAILED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason DELIVERY_FAILED = new CampaignAssetStateReason("DELIVERY_FAILED");

        /// <summary>
        /// Constant END_ON_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason END_ON_MISSING = new CampaignAssetStateReason("END_ON_MISSING");

        /// <summary>
        /// Constant ENGAGEMENT_GROUPS_UNAVAILABLE for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason ENGAGEMENT_GROUPS_UNAVAILABLE = new CampaignAssetStateReason("ENGAGEMENT_GROUPS_UNAVAILABLE");

        /// <summary>
        /// Constant INTERNAL_ERROR for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason INTERNAL_ERROR = new CampaignAssetStateReason("INTERNAL_ERROR");

        /// <summary>
        /// Constant MAILING_CREDITS_EXHAUSTED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason MAILING_CREDITS_EXHAUSTED = new CampaignAssetStateReason("MAILING_CREDITS_EXHAUSTED");

        /// <summary>
        /// Constant MAILING_CREDITS_INSUFFICIENT for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason MAILING_CREDITS_INSUFFICIENT = new CampaignAssetStateReason("MAILING_CREDITS_INSUFFICIENT");

        /// <summary>
        /// Constant PARTNER_ADDRESS_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PARTNER_ADDRESS_MISSING = new CampaignAssetStateReason("PARTNER_ADDRESS_MISSING");

        /// <summary>
        /// Constant PARTNER_IMAGE_REJECTED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PARTNER_IMAGE_REJECTED = new CampaignAssetStateReason("PARTNER_IMAGE_REJECTED");

        /// <summary>
        /// Constant PARTNER_NOT_PROVISIONED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PARTNER_NOT_PROVISIONED = new CampaignAssetStateReason("PARTNER_NOT_PROVISIONED");

        /// <summary>
        /// Constant PARTNER_PROFILE_FIELD_DOES_NOT_FIT for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PARTNER_PROFILE_FIELD_DOES_NOT_FIT = new CampaignAssetStateReason("PARTNER_PROFILE_FIELD_DOES_NOT_FIT");

        /// <summary>
        /// Constant PARTNER_PROFILE_FIELD_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PARTNER_PROFILE_FIELD_MISSING = new CampaignAssetStateReason("PARTNER_PROFILE_FIELD_MISSING");

        /// <summary>
        /// Constant PREREQUISITE_ASSET_NOT_ACTIVE for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PREREQUISITE_ASSET_NOT_ACTIVE = new CampaignAssetStateReason("PREREQUISITE_ASSET_NOT_ACTIVE");

        /// <summary>
        /// Constant PRIVACY_POLICY_URL_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason PRIVACY_POLICY_URL_MISSING = new CampaignAssetStateReason("PRIVACY_POLICY_URL_MISSING");

        /// <summary>
        /// Constant RECIPIENT_LIMIT_EXCEEDED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason RECIPIENT_LIMIT_EXCEEDED = new CampaignAssetStateReason("RECIPIENT_LIMIT_EXCEEDED");

        /// <summary>
        /// Constant RECIPIENT_LIST_EMPTY for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason RECIPIENT_LIST_EMPTY = new CampaignAssetStateReason("RECIPIENT_LIST_EMPTY");

        /// <summary>
        /// Constant RECIPIENT_LIST_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason RECIPIENT_LIST_MISSING = new CampaignAssetStateReason("RECIPIENT_LIST_MISSING");

        /// <summary>
        /// Constant REQUIRED_FIELD_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason REQUIRED_FIELD_MISSING = new CampaignAssetStateReason("REQUIRED_FIELD_MISSING");

        /// <summary>
        /// Constant SENDER_EMAIL_INVALID for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SENDER_EMAIL_INVALID = new CampaignAssetStateReason("SENDER_EMAIL_INVALID");

        /// <summary>
        /// Constant SENDER_EMAIL_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SENDER_EMAIL_MISSING = new CampaignAssetStateReason("SENDER_EMAIL_MISSING");

        /// <summary>
        /// Constant SENDER_NOT_APPROVED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SENDER_NOT_APPROVED = new CampaignAssetStateReason("SENDER_NOT_APPROVED");

        /// <summary>
        /// Constant SEND_MODE_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SEND_MODE_MISSING = new CampaignAssetStateReason("SEND_MODE_MISSING");

        /// <summary>
        /// Constant SEND_WINDOW_TOO_SOON for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SEND_WINDOW_TOO_SOON = new CampaignAssetStateReason("SEND_WINDOW_TOO_SOON");

        /// <summary>
        /// Constant SOCIAL_CONNECTION_EXPIRED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SOCIAL_CONNECTION_EXPIRED = new CampaignAssetStateReason("SOCIAL_CONNECTION_EXPIRED");

        /// <summary>
        /// Constant SOCIAL_CONNECTION_MISSING for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SOCIAL_CONNECTION_MISSING = new CampaignAssetStateReason("SOCIAL_CONNECTION_MISSING");

        /// <summary>
        /// Constant SOCIAL_CONNECTION_NOT_CHOSEN for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SOCIAL_CONNECTION_NOT_CHOSEN = new CampaignAssetStateReason("SOCIAL_CONNECTION_NOT_CHOSEN");

        /// <summary>
        /// Constant SOCIAL_CONNECTION_PAGE_REQUIRED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason SOCIAL_CONNECTION_PAGE_REQUIRED = new CampaignAssetStateReason("SOCIAL_CONNECTION_PAGE_REQUIRED");

        /// <summary>
        /// Constant TEMPLATE_CHANGED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason TEMPLATE_CHANGED = new CampaignAssetStateReason("TEMPLATE_CHANGED");

        /// <summary>
        /// Constant URL_NOT_ALLOWED for CampaignAssetStateReason
        /// </summary>
        public static readonly CampaignAssetStateReason URL_NOT_ALLOWED = new CampaignAssetStateReason("URL_NOT_ALLOWED");

        /// <summary>
        /// Constructs a custom CampaignAssetStateReason for a value not among the defined constants.
        /// </summary>
        public CampaignAssetStateReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetStateReason FindValue(string value)
        {
            return FindValue<CampaignAssetStateReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetStateReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignAssetTemplateType.
    /// </summary>
    public class CampaignAssetTemplateType : ConstantClass
    {
        /// <summary>
        /// Constant BANNER_AD for CampaignAssetTemplateType
        /// </summary>
        public static readonly CampaignAssetTemplateType BANNER_AD = new CampaignAssetTemplateType("BANNER_AD");

        /// <summary>
        /// Constant DOCUMENT for CampaignAssetTemplateType
        /// </summary>
        public static readonly CampaignAssetTemplateType DOCUMENT = new CampaignAssetTemplateType("DOCUMENT");

        /// <summary>
        /// Constant EMAIL for CampaignAssetTemplateType
        /// </summary>
        public static readonly CampaignAssetTemplateType EMAIL = new CampaignAssetTemplateType("EMAIL");

        /// <summary>
        /// Constant LANDING_PAGE for CampaignAssetTemplateType
        /// </summary>
        public static readonly CampaignAssetTemplateType LANDING_PAGE = new CampaignAssetTemplateType("LANDING_PAGE");

        /// <summary>
        /// Constant SOCIAL_POST for CampaignAssetTemplateType
        /// </summary>
        public static readonly CampaignAssetTemplateType SOCIAL_POST = new CampaignAssetTemplateType("SOCIAL_POST");

        /// <summary>
        /// Constructs a custom CampaignAssetTemplateType for a value not among the defined constants.
        /// </summary>
        public CampaignAssetTemplateType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignAssetTemplateType FindValue(string value)
        {
            return FindValue<CampaignAssetTemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignAssetTemplateType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignSetting.
    /// </summary>
    public class CampaignSetting : ConstantClass
    {
        /// <summary>
        /// Constant EMAIL_TARGET for CampaignSetting
        /// </summary>
        public static readonly CampaignSetting EMAIL_TARGET = new CampaignSetting("EMAIL_TARGET");

        /// <summary>
        /// Constant END_ON for CampaignSetting
        /// </summary>
        public static readonly CampaignSetting END_ON = new CampaignSetting("END_ON");

        /// <summary>
        /// Constant PARTNER_ADDRESS for CampaignSetting
        /// </summary>
        public static readonly CampaignSetting PARTNER_ADDRESS = new CampaignSetting("PARTNER_ADDRESS");

        /// <summary>
        /// Constant PARTNER_BADGE for CampaignSetting
        /// </summary>
        public static readonly CampaignSetting PARTNER_BADGE = new CampaignSetting("PARTNER_BADGE");

        /// <summary>
        /// Constant PRIVACY_POLICY_URL for CampaignSetting
        /// </summary>
        public static readonly CampaignSetting PRIVACY_POLICY_URL = new CampaignSetting("PRIVACY_POLICY_URL");

        /// <summary>
        /// Constant SENDER_EMAIL for CampaignSetting
        /// </summary>
        public static readonly CampaignSetting SENDER_EMAIL = new CampaignSetting("SENDER_EMAIL");

        /// <summary>
        /// Constructs a custom CampaignSetting for a value not among the defined constants.
        /// </summary>
        public CampaignSetting(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignSetting FindValue(string value)
        {
            return FindValue<CampaignSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignSetting(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignSortName.
    /// </summary>
    public class CampaignSortName : ConstantClass
    {
        /// <summary>
        /// Constant CREATED_AT for CampaignSortName
        /// </summary>
        public static readonly CampaignSortName CREATED_AT = new CampaignSortName("CREATED_AT");

        /// <summary>
        /// Constant NAME for CampaignSortName
        /// </summary>
        public static readonly CampaignSortName NAME = new CampaignSortName("NAME");

        /// <summary>
        /// Constant START_ON for CampaignSortName
        /// </summary>
        public static readonly CampaignSortName START_ON = new CampaignSortName("START_ON");

        /// <summary>
        /// Constant STATE for CampaignSortName
        /// </summary>
        public static readonly CampaignSortName STATE = new CampaignSortName("STATE");

        /// <summary>
        /// Constructs a custom CampaignSortName for a value not among the defined constants.
        /// </summary>
        public CampaignSortName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignSortName FindValue(string value)
        {
            return FindValue<CampaignSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignSortName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignState.
    /// </summary>
    public class CampaignState : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for CampaignState
        /// </summary>
        public static readonly CampaignState ACTIVE = new CampaignState("ACTIVE");

        /// <summary>
        /// Constant COMPLETED for CampaignState
        /// </summary>
        public static readonly CampaignState COMPLETED = new CampaignState("COMPLETED");

        /// <summary>
        /// Constant DRAFT for CampaignState
        /// </summary>
        public static readonly CampaignState DRAFT = new CampaignState("DRAFT");

        /// <summary>
        /// Constructs a custom CampaignState for a value not among the defined constants.
        /// </summary>
        public CampaignState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignState FindValue(string value)
        {
            return FindValue<CampaignState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CampaignTemplateCollection.
    /// </summary>
    public class CampaignTemplateCollection : ConstantClass
    {
        /// <summary>
        /// Constant BUILD_WITH_AI for CampaignTemplateCollection
        /// </summary>
        public static readonly CampaignTemplateCollection BUILD_WITH_AI = new CampaignTemplateCollection("BUILD_WITH_AI");

        /// <summary>
        /// Constant GENERAL for CampaignTemplateCollection
        /// </summary>
        public static readonly CampaignTemplateCollection GENERAL = new CampaignTemplateCollection("GENERAL");

        /// <summary>
        /// Constructs a custom CampaignTemplateCollection for a value not among the defined constants.
        /// </summary>
        public CampaignTemplateCollection(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignTemplateCollection FindValue(string value)
        {
            return FindValue<CampaignTemplateCollection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignTemplateCollection(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Catalog.
    /// </summary>
    public class Catalog : ConstantClass
    {
        /// <summary>
        /// Constant AWS for Catalog
        /// </summary>
        public static readonly Catalog AWS = new Catalog("AWS");

        /// <summary>
        /// Constant Sandbox for Catalog
        /// </summary>
        public static readonly Catalog Sandbox = new Catalog("Sandbox");

        /// <summary>
        /// Constructs a custom Catalog for a value not among the defined constants.
        /// </summary>
        public Catalog(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Catalog FindValue(string value)
        {
            return FindValue<Catalog>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Catalog(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CompanySize.
    /// </summary>
    public class CompanySize : ConstantClass
    {
        /// <summary>
        /// Constant ENTERPRISE for CompanySize
        /// </summary>
        public static readonly CompanySize ENTERPRISE = new CompanySize("ENTERPRISE");

        /// <summary>
        /// Constant GLOBAL_ENTERPRISE for CompanySize
        /// </summary>
        public static readonly CompanySize GLOBAL_ENTERPRISE = new CompanySize("GLOBAL_ENTERPRISE");

        /// <summary>
        /// Constant MID_MARKET for CompanySize
        /// </summary>
        public static readonly CompanySize MID_MARKET = new CompanySize("MID_MARKET");

        /// <summary>
        /// Constant SMALL_BUSINESS for CompanySize
        /// </summary>
        public static readonly CompanySize SMALL_BUSINESS = new CompanySize("SMALL_BUSINESS");

        /// <summary>
        /// Constant STARTUP for CompanySize
        /// </summary>
        public static readonly CompanySize STARTUP = new CompanySize("STARTUP");

        /// <summary>
        /// Constructs a custom CompanySize for a value not among the defined constants.
        /// </summary>
        public CompanySize(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompanySize FindValue(string value)
        {
            return FindValue<CompanySize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompanySize(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CustomerSegment.
    /// </summary>
    public class CustomerSegment : ConstantClass
    {
        /// <summary>
        /// Constant ENTERPRISE for CustomerSegment
        /// </summary>
        public static readonly CustomerSegment ENTERPRISE = new CustomerSegment("ENTERPRISE");

        /// <summary>
        /// Constant ISV for CustomerSegment
        /// </summary>
        public static readonly CustomerSegment ISV = new CustomerSegment("ISV");

        /// <summary>
        /// Constant PUBLIC_SECTOR for CustomerSegment
        /// </summary>
        public static readonly CustomerSegment PUBLIC_SECTOR = new CustomerSegment("PUBLIC_SECTOR");

        /// <summary>
        /// Constant SMB for CustomerSegment
        /// </summary>
        public static readonly CustomerSegment SMB = new CustomerSegment("SMB");

        /// <summary>
        /// Constructs a custom CustomerSegment for a value not among the defined constants.
        /// </summary>
        public CustomerSegment(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerSegment FindValue(string value)
        {
            return FindValue<CustomerSegment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerSegment(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeliveryStatus.
    /// </summary>
    public class DeliveryStatus : ConstantClass
    {
        /// <summary>
        /// Constant DELIVERED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus DELIVERED = new DeliveryStatus("DELIVERED");

        /// <summary>
        /// Constant FAILED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus FAILED = new DeliveryStatus("FAILED");

        /// <summary>
        /// Constant PENDING for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus PENDING = new DeliveryStatus("PENDING");

        /// <summary>
        /// Constructs a custom DeliveryStatus for a value not among the defined constants.
        /// </summary>
        public DeliveryStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStatus FindValue(string value)
        {
            return FindValue<DeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStatus(string value)
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
        /// Constant DOCX for FileFormat
        /// </summary>
        public static readonly FileFormat DOCX = new FileFormat("DOCX");

        /// <summary>
        /// Constant HTML for FileFormat
        /// </summary>
        public static readonly FileFormat HTML = new FileFormat("HTML");

        /// <summary>
        /// Constant IMAGE for FileFormat
        /// </summary>
        public static readonly FileFormat IMAGE = new FileFormat("IMAGE");

        /// <summary>
        /// Constant PDF for FileFormat
        /// </summary>
        public static readonly FileFormat PDF = new FileFormat("PDF");

        /// <summary>
        /// Constant PPTX for FileFormat
        /// </summary>
        public static readonly FileFormat PPTX = new FileFormat("PPTX");

        /// <summary>
        /// Constructs a custom FileFormat for a value not among the defined constants.
        /// </summary>
        public FileFormat(string value) : base(value) { }

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
    /// Constants used for properties of type ImageFormat.
    /// </summary>
    public class ImageFormat : ConstantClass
    {
        /// <summary>
        /// Constant JPEG for ImageFormat
        /// </summary>
        public static readonly ImageFormat JPEG = new ImageFormat("JPEG");

        /// <summary>
        /// Constant PNG for ImageFormat
        /// </summary>
        public static readonly ImageFormat PNG = new ImageFormat("PNG");

        /// <summary>
        /// Constructs a custom ImageFormat for a value not among the defined constants.
        /// </summary>
        public ImageFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFormat FindValue(string value)
        {
            return FindValue<ImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Industry.
    /// </summary>
    public class Industry : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMOTIVE for Industry
        /// </summary>
        public static readonly Industry AUTOMOTIVE = new Industry("AUTOMOTIVE");

        /// <summary>
        /// Constant EDUCATION for Industry
        /// </summary>
        public static readonly Industry EDUCATION = new Industry("EDUCATION");

        /// <summary>
        /// Constant ENERGY for Industry
        /// </summary>
        public static readonly Industry ENERGY = new Industry("ENERGY");

        /// <summary>
        /// Constant FINANCIAL_SERVICES for Industry
        /// </summary>
        public static readonly Industry FINANCIAL_SERVICES = new Industry("FINANCIAL_SERVICES");

        /// <summary>
        /// Constant GOVERNMENT for Industry
        /// </summary>
        public static readonly Industry GOVERNMENT = new Industry("GOVERNMENT");

        /// <summary>
        /// Constant HEALTHCARE for Industry
        /// </summary>
        public static readonly Industry HEALTHCARE = new Industry("HEALTHCARE");

        /// <summary>
        /// Constant INSURANCE for Industry
        /// </summary>
        public static readonly Industry INSURANCE = new Industry("INSURANCE");

        /// <summary>
        /// Constant MANUFACTURING for Industry
        /// </summary>
        public static readonly Industry MANUFACTURING = new Industry("MANUFACTURING");

        /// <summary>
        /// Constant MEDIA_ENTERTAINMENT for Industry
        /// </summary>
        public static readonly Industry MEDIA_ENTERTAINMENT = new Industry("MEDIA_ENTERTAINMENT");

        /// <summary>
        /// Constant OTHER for Industry
        /// </summary>
        public static readonly Industry OTHER = new Industry("OTHER");

        /// <summary>
        /// Constant RETAIL for Industry
        /// </summary>
        public static readonly Industry RETAIL = new Industry("RETAIL");

        /// <summary>
        /// Constant TELECOMMUNICATIONS for Industry
        /// </summary>
        public static readonly Industry TELECOMMUNICATIONS = new Industry("TELECOMMUNICATIONS");

        /// <summary>
        /// Constructs a custom Industry for a value not among the defined constants.
        /// </summary>
        public Industry(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Industry FindValue(string value)
        {
            return FindValue<Industry>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Industry(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LayoutFormat.
    /// </summary>
    public class LayoutFormat : ConstantClass
    {
        /// <summary>
        /// Constant HTML for LayoutFormat
        /// </summary>
        public static readonly LayoutFormat HTML = new LayoutFormat("HTML");

        /// <summary>
        /// Constant IMAGE for LayoutFormat
        /// </summary>
        public static readonly LayoutFormat IMAGE = new LayoutFormat("IMAGE");

        /// <summary>
        /// Constant PDF for LayoutFormat
        /// </summary>
        public static readonly LayoutFormat PDF = new LayoutFormat("PDF");

        /// <summary>
        /// Constructs a custom LayoutFormat for a value not among the defined constants.
        /// </summary>
        public LayoutFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayoutFormat FindValue(string value)
        {
            return FindValue<LayoutFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayoutFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LayoutPageType.
    /// </summary>
    public class LayoutPageType : ConstantClass
    {
        /// <summary>
        /// Constant CONFIRMATION for LayoutPageType
        /// </summary>
        public static readonly LayoutPageType CONFIRMATION = new LayoutPageType("CONFIRMATION");

        /// <summary>
        /// Constant FORM for LayoutPageType
        /// </summary>
        public static readonly LayoutPageType FORM = new LayoutPageType("FORM");

        /// <summary>
        /// Constructs a custom LayoutPageType for a value not among the defined constants.
        /// </summary>
        public LayoutPageType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayoutPageType FindValue(string value)
        {
            return FindValue<LayoutPageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayoutPageType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PartnerProfileField.
    /// </summary>
    public class PartnerProfileField : ConstantClass
    {
        /// <summary>
        /// Constant COPYRIGHT_AND_DETAILS for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField COPYRIGHT_AND_DETAILS = new PartnerProfileField("COPYRIGHT_AND_DETAILS");

        /// <summary>
        /// Constant COPYRIGHT_LINE for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField COPYRIGHT_LINE = new PartnerProfileField("COPYRIGHT_LINE");

        /// <summary>
        /// Constant COPYRIGHT_YEAR_LINE for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField COPYRIGHT_YEAR_LINE = new PartnerProfileField("COPYRIGHT_YEAR_LINE");

        /// <summary>
        /// Constant DISPLAY_NAME for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField DISPLAY_NAME = new PartnerProfileField("DISPLAY_NAME");

        /// <summary>
        /// Constant LOGO for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField LOGO = new PartnerProfileField("LOGO");

        /// <summary>
        /// Constant PARTNER_DETAILS for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField PARTNER_DETAILS = new PartnerProfileField("PARTNER_DETAILS");

        /// <summary>
        /// Constant WEBSITE_DOMAIN for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField WEBSITE_DOMAIN = new PartnerProfileField("WEBSITE_DOMAIN");

        /// <summary>
        /// Constant WEBSITE_URL for PartnerProfileField
        /// </summary>
        public static readonly PartnerProfileField WEBSITE_URL = new PartnerProfileField("WEBSITE_URL");

        /// <summary>
        /// Constructs a custom PartnerProfileField for a value not among the defined constants.
        /// </summary>
        public PartnerProfileField(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartnerProfileField FindValue(string value)
        {
            return FindValue<PartnerProfileField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartnerProfileField(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Platform.
    /// </summary>
    public class Platform : ConstantClass
    {
        /// <summary>
        /// Constant FACEBOOK for Platform
        /// </summary>
        public static readonly Platform FACEBOOK = new Platform("FACEBOOK");

        /// <summary>
        /// Constant LINKEDIN for Platform
        /// </summary>
        public static readonly Platform LINKEDIN = new Platform("LINKEDIN");

        /// <summary>
        /// Constant X for Platform
        /// </summary>
        public static readonly Platform X = new Platform("X");

        /// <summary>
        /// Constructs a custom Platform for a value not among the defined constants.
        /// </summary>
        public Platform(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Platform FindValue(string value)
        {
            return FindValue<Platform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Platform(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ScanStatus.
    /// </summary>
    public class ScanStatus : ConstantClass
    {
        /// <summary>
        /// Constant CLEAN for ScanStatus
        /// </summary>
        public static readonly ScanStatus CLEAN = new ScanStatus("CLEAN");

        /// <summary>
        /// Constant PENDING for ScanStatus
        /// </summary>
        public static readonly ScanStatus PENDING = new ScanStatus("PENDING");

        /// <summary>
        /// Constant REJECTED for ScanStatus
        /// </summary>
        public static readonly ScanStatus REJECTED = new ScanStatus("REJECTED");

        /// <summary>
        /// Constructs a custom ScanStatus for a value not among the defined constants.
        /// </summary>
        public ScanStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanStatus FindValue(string value)
        {
            return FindValue<ScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SendMode.
    /// </summary>
    public class SendMode : ConstantClass
    {
        /// <summary>
        /// Constant ON_ACTIVATION for SendMode
        /// </summary>
        public static readonly SendMode ON_ACTIVATION = new SendMode("ON_ACTIVATION");

        /// <summary>
        /// Constant SCHEDULED for SendMode
        /// </summary>
        public static readonly SendMode SCHEDULED = new SendMode("SCHEDULED");

        /// <summary>
        /// Constructs a custom SendMode for a value not among the defined constants.
        /// </summary>
        public SendMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SendMode FindValue(string value)
        {
            return FindValue<SendMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SendMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SocialConnectionStatus.
    /// </summary>
    public class SocialConnectionStatus : ConstantClass
    {
        /// <summary>
        /// Constant AUTHORIZED for SocialConnectionStatus
        /// </summary>
        public static readonly SocialConnectionStatus AUTHORIZED = new SocialConnectionStatus("AUTHORIZED");

        /// <summary>
        /// Constant EXPIRED for SocialConnectionStatus
        /// </summary>
        public static readonly SocialConnectionStatus EXPIRED = new SocialConnectionStatus("EXPIRED");

        /// <summary>
        /// Constant PAGE_REQUIRED for SocialConnectionStatus
        /// </summary>
        public static readonly SocialConnectionStatus PAGE_REQUIRED = new SocialConnectionStatus("PAGE_REQUIRED");

        /// <summary>
        /// Constructs a custom SocialConnectionStatus for a value not among the defined constants.
        /// </summary>
        public SocialConnectionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SocialConnectionStatus FindValue(string value)
        {
            return FindValue<SocialConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SocialConnectionStatus(string value)
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
        /// Constructs a custom SortOrder for a value not among the defined constants.
        /// </summary>
        public SortOrder(string value) : base(value) { }

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
    /// Constants used for properties of type TemplateFieldSection.
    /// </summary>
    public class TemplateFieldSection : ConstantClass
    {
        /// <summary>
        /// Constant BODY for TemplateFieldSection
        /// </summary>
        public static readonly TemplateFieldSection BODY = new TemplateFieldSection("BODY");

        /// <summary>
        /// Constant FOOTER for TemplateFieldSection
        /// </summary>
        public static readonly TemplateFieldSection FOOTER = new TemplateFieldSection("FOOTER");

        /// <summary>
        /// Constant HEADER for TemplateFieldSection
        /// </summary>
        public static readonly TemplateFieldSection HEADER = new TemplateFieldSection("HEADER");

        /// <summary>
        /// Constructs a custom TemplateFieldSection for a value not among the defined constants.
        /// </summary>
        public TemplateFieldSection(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateFieldSection FindValue(string value)
        {
            return FindValue<TemplateFieldSection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateFieldSection(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Theme.
    /// </summary>
    public class Theme : ConstantClass
    {
        /// <summary>
        /// Constant AI for Theme
        /// </summary>
        public static readonly Theme AI = new Theme("AI");

        /// <summary>
        /// Constant AWS_MARKETPLACE for Theme
        /// </summary>
        public static readonly Theme AWS_MARKETPLACE = new Theme("AWS_MARKETPLACE");

        /// <summary>
        /// Constant AWS_TRAINING_CERTIFICATION for Theme
        /// </summary>
        public static readonly Theme AWS_TRAINING_CERTIFICATION = new Theme("AWS_TRAINING_CERTIFICATION");

        /// <summary>
        /// Constant CONNECT for Theme
        /// </summary>
        public static readonly Theme CONNECT = new Theme("CONNECT");

        /// <summary>
        /// Constant DATA_ANALYTICS for Theme
        /// </summary>
        public static readonly Theme DATA_ANALYTICS = new Theme("DATA_ANALYTICS");

        /// <summary>
        /// Constant EVENTS for Theme
        /// </summary>
        public static readonly Theme EVENTS = new Theme("EVENTS");

        /// <summary>
        /// Constant MIGRATION_MODERNIZATION for Theme
        /// </summary>
        public static readonly Theme MIGRATION_MODERNIZATION = new Theme("MIGRATION_MODERNIZATION");

        /// <summary>
        /// Constant SECURITY for Theme
        /// </summary>
        public static readonly Theme SECURITY = new Theme("SECURITY");

        /// <summary>
        /// Constructs a custom Theme for a value not among the defined constants.
        /// </summary>
        public Theme(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Theme FindValue(string value)
        {
            return FindValue<Theme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Theme(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ValidationExceptionFieldCode.
    /// </summary>
    public class ValidationExceptionFieldCode : ConstantClass
    {
        /// <summary>
        /// Constant COPY_SOURCE_INVALID for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode COPY_SOURCE_INVALID = new ValidationExceptionFieldCode("COPY_SOURCE_INVALID");

        /// <summary>
        /// Constant DISALLOWED_HTML_TAG for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode DISALLOWED_HTML_TAG = new ValidationExceptionFieldCode("DISALLOWED_HTML_TAG");

        /// <summary>
        /// Constant EMAIL_COLUMN_MISSING for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode EMAIL_COLUMN_MISSING = new ValidationExceptionFieldCode("EMAIL_COLUMN_MISSING");

        /// <summary>
        /// Constant FIELD_FROM_PARTNER_PROFILE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode FIELD_FROM_PARTNER_PROFILE = new ValidationExceptionFieldCode("FIELD_FROM_PARTNER_PROFILE");

        /// <summary>
        /// Constant FIELD_SET_ON_CAMPAIGN for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode FIELD_SET_ON_CAMPAIGN = new ValidationExceptionFieldCode("FIELD_SET_ON_CAMPAIGN");

        /// <summary>
        /// Constant FILE_REFERENCE_INVALID for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode FILE_REFERENCE_INVALID = new ValidationExceptionFieldCode("FILE_REFERENCE_INVALID");

        /// <summary>
        /// Constant FILE_REFERENCE_NOT_OWNED for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode FILE_REFERENCE_NOT_OWNED = new ValidationExceptionFieldCode("FILE_REFERENCE_NOT_OWNED");

        /// <summary>
        /// Constant FILE_TOO_LARGE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode FILE_TOO_LARGE = new ValidationExceptionFieldCode("FILE_TOO_LARGE");

        /// <summary>
        /// Constant IMAGE_ASPECT_RATIO_MISMATCH for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode IMAGE_ASPECT_RATIO_MISMATCH = new ValidationExceptionFieldCode("IMAGE_ASPECT_RATIO_MISMATCH");

        /// <summary>
        /// Constant IMAGE_FORMAT_NOT_ALLOWED for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode IMAGE_FORMAT_NOT_ALLOWED = new ValidationExceptionFieldCode("IMAGE_FORMAT_NOT_ALLOWED");

        /// <summary>
        /// Constant IMAGE_FORMAT_NOT_SUPPORTED for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode IMAGE_FORMAT_NOT_SUPPORTED = new ValidationExceptionFieldCode("IMAGE_FORMAT_NOT_SUPPORTED");

        /// <summary>
        /// Constant IMAGE_TOO_LARGE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode IMAGE_TOO_LARGE = new ValidationExceptionFieldCode("IMAGE_TOO_LARGE");

        /// <summary>
        /// Constant INVALID_VALUE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode INVALID_VALUE = new ValidationExceptionFieldCode("INVALID_VALUE");

        /// <summary>
        /// Constant NOT_SUPPORTED_FOR_CATEGORY for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode NOT_SUPPORTED_FOR_CATEGORY = new ValidationExceptionFieldCode("NOT_SUPPORTED_FOR_CATEGORY");

        /// <summary>
        /// Constant PARTNER_BADGE_NOT_ELIGIBLE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode PARTNER_BADGE_NOT_ELIGIBLE = new ValidationExceptionFieldCode("PARTNER_BADGE_NOT_ELIGIBLE");

        /// <summary>
        /// Constant PATTERN_MISMATCH for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode PATTERN_MISMATCH = new ValidationExceptionFieldCode("PATTERN_MISMATCH");

        /// <summary>
        /// Constant RECIPIENT_LIST_EMPTY for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode RECIPIENT_LIST_EMPTY = new ValidationExceptionFieldCode("RECIPIENT_LIST_EMPTY");

        /// <summary>
        /// Constant RECIPIENT_LIST_NOT_UTF8 for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode RECIPIENT_LIST_NOT_UTF8 = new ValidationExceptionFieldCode("RECIPIENT_LIST_NOT_UTF8");

        /// <summary>
        /// Constant RECIPIENT_LIST_TOO_LARGE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode RECIPIENT_LIST_TOO_LARGE = new ValidationExceptionFieldCode("RECIPIENT_LIST_TOO_LARGE");

        /// <summary>
        /// Constant SCAN_REJECTED for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode SCAN_REJECTED = new ValidationExceptionFieldCode("SCAN_REJECTED");

        /// <summary>
        /// Constant SENDER_DOMAIN_DKIM_MISSING for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode SENDER_DOMAIN_DKIM_MISSING = new ValidationExceptionFieldCode("SENDER_DOMAIN_DKIM_MISSING");

        /// <summary>
        /// Constant SENDER_DOMAIN_DMARC_MISSING for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode SENDER_DOMAIN_DMARC_MISSING = new ValidationExceptionFieldCode("SENDER_DOMAIN_DMARC_MISSING");

        /// <summary>
        /// Constant SENDER_DOMAIN_NOT_ALLIANCE_LEAD for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode SENDER_DOMAIN_NOT_ALLIANCE_LEAD = new ValidationExceptionFieldCode("SENDER_DOMAIN_NOT_ALLIANCE_LEAD");

        /// <summary>
        /// Constant UNKNOWN_FIELD for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode UNKNOWN_FIELD = new ValidationExceptionFieldCode("UNKNOWN_FIELD");

        /// <summary>
        /// Constant VALUE_TOO_LONG for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode VALUE_TOO_LONG = new ValidationExceptionFieldCode("VALUE_TOO_LONG");

        /// <summary>
        /// Constant VALUE_TOO_SHORT for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode VALUE_TOO_SHORT = new ValidationExceptionFieldCode("VALUE_TOO_SHORT");

        /// <summary>
        /// Constant WRONG_VALUE_TYPE for ValidationExceptionFieldCode
        /// </summary>
        public static readonly ValidationExceptionFieldCode WRONG_VALUE_TYPE = new ValidationExceptionFieldCode("WRONG_VALUE_TYPE");

        /// <summary>
        /// Constructs a custom ValidationExceptionFieldCode for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionFieldCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionFieldCode FindValue(string value)
        {
            return FindValue<ValidationExceptionFieldCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionFieldCode(string value)
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
        /// Constant CAMPAIGN_INCOMPLETE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CAMPAIGN_INCOMPLETE = new ValidationExceptionReason("CAMPAIGN_INCOMPLETE");

        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");

        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");

        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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
}
