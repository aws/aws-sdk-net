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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimpleEmailV2
{

    /// <summary>
    /// Constants used for properties of type BehaviorOnMxFailure.
    /// </summary>
    public class BehaviorOnMxFailure : ConstantClass
    {

        /// <summary>
        /// Constant REJECT_MESSAGE for BehaviorOnMxFailure
        /// </summary>
        public static readonly BehaviorOnMxFailure REJECT_MESSAGE = new BehaviorOnMxFailure("REJECT_MESSAGE");
        /// <summary>
        /// Constant USE_DEFAULT_VALUE for BehaviorOnMxFailure
        /// </summary>
        public static readonly BehaviorOnMxFailure USE_DEFAULT_VALUE = new BehaviorOnMxFailure("USE_DEFAULT_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BehaviorOnMxFailure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BehaviorOnMxFailure FindValue(string value)
        {
            return FindValue<BehaviorOnMxFailure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BehaviorOnMxFailure(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BulkEmailStatus.
    /// </summary>
    public class BulkEmailStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_DAILY_QUOTA_EXCEEDED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus ACCOUNT_DAILY_QUOTA_EXCEEDED = new BulkEmailStatus("ACCOUNT_DAILY_QUOTA_EXCEEDED");
        /// <summary>
        /// Constant ACCOUNT_SENDING_PAUSED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus ACCOUNT_SENDING_PAUSED = new BulkEmailStatus("ACCOUNT_SENDING_PAUSED");
        /// <summary>
        /// Constant ACCOUNT_SUSPENDED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus ACCOUNT_SUSPENDED = new BulkEmailStatus("ACCOUNT_SUSPENDED");
        /// <summary>
        /// Constant ACCOUNT_THROTTLED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus ACCOUNT_THROTTLED = new BulkEmailStatus("ACCOUNT_THROTTLED");
        /// <summary>
        /// Constant CONFIGURATION_SET_NOT_FOUND for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus CONFIGURATION_SET_NOT_FOUND = new BulkEmailStatus("CONFIGURATION_SET_NOT_FOUND");
        /// <summary>
        /// Constant CONFIGURATION_SET_SENDING_PAUSED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus CONFIGURATION_SET_SENDING_PAUSED = new BulkEmailStatus("CONFIGURATION_SET_SENDING_PAUSED");
        /// <summary>
        /// Constant FAILED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus FAILED = new BulkEmailStatus("FAILED");
        /// <summary>
        /// Constant INVALID_PARAMETER for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus INVALID_PARAMETER = new BulkEmailStatus("INVALID_PARAMETER");
        /// <summary>
        /// Constant INVALID_SENDING_POOL_NAME for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus INVALID_SENDING_POOL_NAME = new BulkEmailStatus("INVALID_SENDING_POOL_NAME");
        /// <summary>
        /// Constant MAIL_FROM_DOMAIN_NOT_VERIFIED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus MAIL_FROM_DOMAIN_NOT_VERIFIED = new BulkEmailStatus("MAIL_FROM_DOMAIN_NOT_VERIFIED");
        /// <summary>
        /// Constant MESSAGE_REJECTED for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus MESSAGE_REJECTED = new BulkEmailStatus("MESSAGE_REJECTED");
        /// <summary>
        /// Constant SUCCESS for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus SUCCESS = new BulkEmailStatus("SUCCESS");
        /// <summary>
        /// Constant TEMPLATE_NOT_FOUND for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus TEMPLATE_NOT_FOUND = new BulkEmailStatus("TEMPLATE_NOT_FOUND");
        /// <summary>
        /// Constant TRANSIENT_FAILURE for BulkEmailStatus
        /// </summary>
        public static readonly BulkEmailStatus TRANSIENT_FAILURE = new BulkEmailStatus("TRANSIENT_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BulkEmailStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BulkEmailStatus FindValue(string value)
        {
            return FindValue<BulkEmailStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BulkEmailStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactLanguage.
    /// </summary>
    public class ContactLanguage : ConstantClass
    {

        /// <summary>
        /// Constant EN for ContactLanguage
        /// </summary>
        public static readonly ContactLanguage EN = new ContactLanguage("EN");
        /// <summary>
        /// Constant JA for ContactLanguage
        /// </summary>
        public static readonly ContactLanguage JA = new ContactLanguage("JA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactLanguage FindValue(string value)
        {
            return FindValue<ContactLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactListImportAction.
    /// </summary>
    public class ContactListImportAction : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for ContactListImportAction
        /// </summary>
        public static readonly ContactListImportAction DELETE = new ContactListImportAction("DELETE");
        /// <summary>
        /// Constant PUT for ContactListImportAction
        /// </summary>
        public static readonly ContactListImportAction PUT = new ContactListImportAction("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactListImportAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactListImportAction FindValue(string value)
        {
            return FindValue<ContactListImportAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactListImportAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataFormat.
    /// </summary>
    public class DataFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for DataFormat
        /// </summary>
        public static readonly DataFormat CSV = new DataFormat("CSV");
        /// <summary>
        /// Constant JSON for DataFormat
        /// </summary>
        public static readonly DataFormat JSON = new DataFormat("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFormat FindValue(string value)
        {
            return FindValue<DataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliverabilityDashboardAccountStatus.
    /// </summary>
    public class DeliverabilityDashboardAccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DeliverabilityDashboardAccountStatus
        /// </summary>
        public static readonly DeliverabilityDashboardAccountStatus ACTIVE = new DeliverabilityDashboardAccountStatus("ACTIVE");
        /// <summary>
        /// Constant DISABLED for DeliverabilityDashboardAccountStatus
        /// </summary>
        public static readonly DeliverabilityDashboardAccountStatus DISABLED = new DeliverabilityDashboardAccountStatus("DISABLED");
        /// <summary>
        /// Constant PENDING_EXPIRATION for DeliverabilityDashboardAccountStatus
        /// </summary>
        public static readonly DeliverabilityDashboardAccountStatus PENDING_EXPIRATION = new DeliverabilityDashboardAccountStatus("PENDING_EXPIRATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliverabilityDashboardAccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliverabilityDashboardAccountStatus FindValue(string value)
        {
            return FindValue<DeliverabilityDashboardAccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliverabilityDashboardAccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliverabilityTestStatus.
    /// </summary>
    public class DeliverabilityTestStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DeliverabilityTestStatus
        /// </summary>
        public static readonly DeliverabilityTestStatus COMPLETED = new DeliverabilityTestStatus("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for DeliverabilityTestStatus
        /// </summary>
        public static readonly DeliverabilityTestStatus IN_PROGRESS = new DeliverabilityTestStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliverabilityTestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliverabilityTestStatus FindValue(string value)
        {
            return FindValue<DeliverabilityTestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliverabilityTestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionValueSource.
    /// </summary>
    public class DimensionValueSource : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL_HEADER for DimensionValueSource
        /// </summary>
        public static readonly DimensionValueSource EMAIL_HEADER = new DimensionValueSource("EMAIL_HEADER");
        /// <summary>
        /// Constant LINK_TAG for DimensionValueSource
        /// </summary>
        public static readonly DimensionValueSource LINK_TAG = new DimensionValueSource("LINK_TAG");
        /// <summary>
        /// Constant MESSAGE_TAG for DimensionValueSource
        /// </summary>
        public static readonly DimensionValueSource MESSAGE_TAG = new DimensionValueSource("MESSAGE_TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionValueSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionValueSource FindValue(string value)
        {
            return FindValue<DimensionValueSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionValueSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DkimSigningAttributesOrigin.
    /// </summary>
    public class DkimSigningAttributesOrigin : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SES for DkimSigningAttributesOrigin
        /// </summary>
        public static readonly DkimSigningAttributesOrigin AWS_SES = new DkimSigningAttributesOrigin("AWS_SES");
        /// <summary>
        /// Constant EXTERNAL for DkimSigningAttributesOrigin
        /// </summary>
        public static readonly DkimSigningAttributesOrigin EXTERNAL = new DkimSigningAttributesOrigin("EXTERNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DkimSigningAttributesOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DkimSigningAttributesOrigin FindValue(string value)
        {
            return FindValue<DkimSigningAttributesOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DkimSigningAttributesOrigin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DkimSigningKeyLength.
    /// </summary>
    public class DkimSigningKeyLength : ConstantClass
    {

        /// <summary>
        /// Constant RSA_1024_BIT for DkimSigningKeyLength
        /// </summary>
        public static readonly DkimSigningKeyLength RSA_1024_BIT = new DkimSigningKeyLength("RSA_1024_BIT");
        /// <summary>
        /// Constant RSA_2048_BIT for DkimSigningKeyLength
        /// </summary>
        public static readonly DkimSigningKeyLength RSA_2048_BIT = new DkimSigningKeyLength("RSA_2048_BIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DkimSigningKeyLength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DkimSigningKeyLength FindValue(string value)
        {
            return FindValue<DkimSigningKeyLength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DkimSigningKeyLength(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DkimStatus.
    /// </summary>
    public class DkimStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DkimStatus
        /// </summary>
        public static readonly DkimStatus FAILED = new DkimStatus("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for DkimStatus
        /// </summary>
        public static readonly DkimStatus NOT_STARTED = new DkimStatus("NOT_STARTED");
        /// <summary>
        /// Constant PENDING for DkimStatus
        /// </summary>
        public static readonly DkimStatus PENDING = new DkimStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for DkimStatus
        /// </summary>
        public static readonly DkimStatus SUCCESS = new DkimStatus("SUCCESS");
        /// <summary>
        /// Constant TEMPORARY_FAILURE for DkimStatus
        /// </summary>
        public static readonly DkimStatus TEMPORARY_FAILURE = new DkimStatus("TEMPORARY_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DkimStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DkimStatus FindValue(string value)
        {
            return FindValue<DkimStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DkimStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant BOUNCE for EventType
        /// </summary>
        public static readonly EventType BOUNCE = new EventType("BOUNCE");
        /// <summary>
        /// Constant CLICK for EventType
        /// </summary>
        public static readonly EventType CLICK = new EventType("CLICK");
        /// <summary>
        /// Constant COMPLAINT for EventType
        /// </summary>
        public static readonly EventType COMPLAINT = new EventType("COMPLAINT");
        /// <summary>
        /// Constant DELIVERY for EventType
        /// </summary>
        public static readonly EventType DELIVERY = new EventType("DELIVERY");
        /// <summary>
        /// Constant DELIVERY_DELAY for EventType
        /// </summary>
        public static readonly EventType DELIVERY_DELAY = new EventType("DELIVERY_DELAY");
        /// <summary>
        /// Constant OPEN for EventType
        /// </summary>
        public static readonly EventType OPEN = new EventType("OPEN");
        /// <summary>
        /// Constant REJECT for EventType
        /// </summary>
        public static readonly EventType REJECT = new EventType("REJECT");
        /// <summary>
        /// Constant RENDERING_FAILURE for EventType
        /// </summary>
        public static readonly EventType RENDERING_FAILURE = new EventType("RENDERING_FAILURE");
        /// <summary>
        /// Constant SEND for EventType
        /// </summary>
        public static readonly EventType SEND = new EventType("SEND");
        /// <summary>
        /// Constant SUBSCRIPTION for EventType
        /// </summary>
        public static readonly EventType SUBSCRIPTION = new EventType("SUBSCRIPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureStatus.
    /// </summary>
    public class FeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus DISABLED = new FeatureStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus ENABLED = new FeatureStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureStatus FindValue(string value)
        {
            return FindValue<FeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureStatus(string value)
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
        /// Constant DOMAIN for IdentityType
        /// </summary>
        public static readonly IdentityType DOMAIN = new IdentityType("DOMAIN");
        /// <summary>
        /// Constant EMAIL_ADDRESS for IdentityType
        /// </summary>
        public static readonly IdentityType EMAIL_ADDRESS = new IdentityType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant MANAGED_DOMAIN for IdentityType
        /// </summary>
        public static readonly IdentityType MANAGED_DOMAIN = new IdentityType("MANAGED_DOMAIN");

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
    /// Constants used for properties of type ImportDestinationType.
    /// </summary>
    public class ImportDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant CONTACT_LIST for ImportDestinationType
        /// </summary>
        public static readonly ImportDestinationType CONTACT_LIST = new ImportDestinationType("CONTACT_LIST");
        /// <summary>
        /// Constant SUPPRESSION_LIST for ImportDestinationType
        /// </summary>
        public static readonly ImportDestinationType SUPPRESSION_LIST = new ImportDestinationType("SUPPRESSION_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportDestinationType FindValue(string value)
        {
            return FindValue<ImportDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportDestinationType(string value)
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
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for JobStatus
        /// </summary>
        public static readonly JobStatus CREATED = new JobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for JobStatus
        /// </summary>
        public static readonly JobStatus PROCESSING = new JobStatus("PROCESSING");

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
    /// Constants used for properties of type ListRecommendationsFilterKey.
    /// </summary>
    public class ListRecommendationsFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant IMPACT for ListRecommendationsFilterKey
        /// </summary>
        public static readonly ListRecommendationsFilterKey IMPACT = new ListRecommendationsFilterKey("IMPACT");
        /// <summary>
        /// Constant RESOURCE_ARN for ListRecommendationsFilterKey
        /// </summary>
        public static readonly ListRecommendationsFilterKey RESOURCE_ARN = new ListRecommendationsFilterKey("RESOURCE_ARN");
        /// <summary>
        /// Constant STATUS for ListRecommendationsFilterKey
        /// </summary>
        public static readonly ListRecommendationsFilterKey STATUS = new ListRecommendationsFilterKey("STATUS");
        /// <summary>
        /// Constant TYPE for ListRecommendationsFilterKey
        /// </summary>
        public static readonly ListRecommendationsFilterKey TYPE = new ListRecommendationsFilterKey("TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListRecommendationsFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListRecommendationsFilterKey FindValue(string value)
        {
            return FindValue<ListRecommendationsFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListRecommendationsFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MailFromDomainStatus.
    /// </summary>
    public class MailFromDomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for MailFromDomainStatus
        /// </summary>
        public static readonly MailFromDomainStatus FAILED = new MailFromDomainStatus("FAILED");
        /// <summary>
        /// Constant PENDING for MailFromDomainStatus
        /// </summary>
        public static readonly MailFromDomainStatus PENDING = new MailFromDomainStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for MailFromDomainStatus
        /// </summary>
        public static readonly MailFromDomainStatus SUCCESS = new MailFromDomainStatus("SUCCESS");
        /// <summary>
        /// Constant TEMPORARY_FAILURE for MailFromDomainStatus
        /// </summary>
        public static readonly MailFromDomainStatus TEMPORARY_FAILURE = new MailFromDomainStatus("TEMPORARY_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MailFromDomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MailFromDomainStatus FindValue(string value)
        {
            return FindValue<MailFromDomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MailFromDomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MailType.
    /// </summary>
    public class MailType : ConstantClass
    {

        /// <summary>
        /// Constant MARKETING for MailType
        /// </summary>
        public static readonly MailType MARKETING = new MailType("MARKETING");
        /// <summary>
        /// Constant TRANSACTIONAL for MailType
        /// </summary>
        public static readonly MailType TRANSACTIONAL = new MailType("TRANSACTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MailType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MailType FindValue(string value)
        {
            return FindValue<MailType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MailType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Metric.
    /// </summary>
    public class Metric : ConstantClass
    {

        /// <summary>
        /// Constant CLICK for Metric
        /// </summary>
        public static readonly Metric CLICK = new Metric("CLICK");
        /// <summary>
        /// Constant COMPLAINT for Metric
        /// </summary>
        public static readonly Metric COMPLAINT = new Metric("COMPLAINT");
        /// <summary>
        /// Constant DELIVERY for Metric
        /// </summary>
        public static readonly Metric DELIVERY = new Metric("DELIVERY");
        /// <summary>
        /// Constant DELIVERY_CLICK for Metric
        /// </summary>
        public static readonly Metric DELIVERY_CLICK = new Metric("DELIVERY_CLICK");
        /// <summary>
        /// Constant DELIVERY_COMPLAINT for Metric
        /// </summary>
        public static readonly Metric DELIVERY_COMPLAINT = new Metric("DELIVERY_COMPLAINT");
        /// <summary>
        /// Constant DELIVERY_OPEN for Metric
        /// </summary>
        public static readonly Metric DELIVERY_OPEN = new Metric("DELIVERY_OPEN");
        /// <summary>
        /// Constant OPEN for Metric
        /// </summary>
        public static readonly Metric OPEN = new Metric("OPEN");
        /// <summary>
        /// Constant PERMANENT_BOUNCE for Metric
        /// </summary>
        public static readonly Metric PERMANENT_BOUNCE = new Metric("PERMANENT_BOUNCE");
        /// <summary>
        /// Constant SEND for Metric
        /// </summary>
        public static readonly Metric SEND = new Metric("SEND");
        /// <summary>
        /// Constant TRANSIENT_BOUNCE for Metric
        /// </summary>
        public static readonly Metric TRANSIENT_BOUNCE = new Metric("TRANSIENT_BOUNCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Metric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Metric FindValue(string value)
        {
            return FindValue<Metric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Metric(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricDimensionName.
    /// </summary>
    public class MetricDimensionName : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_SET for MetricDimensionName
        /// </summary>
        public static readonly MetricDimensionName CONFIGURATION_SET = new MetricDimensionName("CONFIGURATION_SET");
        /// <summary>
        /// Constant EMAIL_IDENTITY for MetricDimensionName
        /// </summary>
        public static readonly MetricDimensionName EMAIL_IDENTITY = new MetricDimensionName("EMAIL_IDENTITY");
        /// <summary>
        /// Constant ISP for MetricDimensionName
        /// </summary>
        public static readonly MetricDimensionName ISP = new MetricDimensionName("ISP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricDimensionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricDimensionName FindValue(string value)
        {
            return FindValue<MetricDimensionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricDimensionName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricNamespace.
    /// </summary>
    public class MetricNamespace : ConstantClass
    {

        /// <summary>
        /// Constant VDM for MetricNamespace
        /// </summary>
        public static readonly MetricNamespace VDM = new MetricNamespace("VDM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricNamespace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricNamespace FindValue(string value)
        {
            return FindValue<MetricNamespace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricNamespace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryErrorCode.
    /// </summary>
    public class QueryErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for QueryErrorCode
        /// </summary>
        public static readonly QueryErrorCode ACCESS_DENIED = new QueryErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_FAILURE for QueryErrorCode
        /// </summary>
        public static readonly QueryErrorCode INTERNAL_FAILURE = new QueryErrorCode("INTERNAL_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryErrorCode FindValue(string value)
        {
            return FindValue<QueryErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationImpact.
    /// </summary>
    public class RecommendationImpact : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for RecommendationImpact
        /// </summary>
        public static readonly RecommendationImpact HIGH = new RecommendationImpact("HIGH");
        /// <summary>
        /// Constant LOW for RecommendationImpact
        /// </summary>
        public static readonly RecommendationImpact LOW = new RecommendationImpact("LOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationImpact(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationImpact FindValue(string value)
        {
            return FindValue<RecommendationImpact>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationImpact(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationStatus.
    /// </summary>
    public class RecommendationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FIXED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus FIXED = new RecommendationStatus("FIXED");
        /// <summary>
        /// Constant OPEN for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus OPEN = new RecommendationStatus("OPEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationStatus FindValue(string value)
        {
            return FindValue<RecommendationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationType.
    /// </summary>
    public class RecommendationType : ConstantClass
    {

        /// <summary>
        /// Constant BIMI for RecommendationType
        /// </summary>
        public static readonly RecommendationType BIMI = new RecommendationType("BIMI");
        /// <summary>
        /// Constant DKIM for RecommendationType
        /// </summary>
        public static readonly RecommendationType DKIM = new RecommendationType("DKIM");
        /// <summary>
        /// Constant DMARC for RecommendationType
        /// </summary>
        public static readonly RecommendationType DMARC = new RecommendationType("DMARC");
        /// <summary>
        /// Constant SPF for RecommendationType
        /// </summary>
        public static readonly RecommendationType SPF = new RecommendationType("SPF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationType FindValue(string value)
        {
            return FindValue<RecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewStatus.
    /// </summary>
    public class ReviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant DENIED for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus DENIED = new ReviewStatus("DENIED");
        /// <summary>
        /// Constant FAILED for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus FAILED = new ReviewStatus("FAILED");
        /// <summary>
        /// Constant GRANTED for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus GRANTED = new ReviewStatus("GRANTED");
        /// <summary>
        /// Constant PENDING for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus PENDING = new ReviewStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewStatus FindValue(string value)
        {
            return FindValue<ReviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingMode.
    /// </summary>
    public class ScalingMode : ConstantClass
    {

        /// <summary>
        /// Constant MANAGED for ScalingMode
        /// </summary>
        public static readonly ScalingMode MANAGED = new ScalingMode("MANAGED");
        /// <summary>
        /// Constant STANDARD for ScalingMode
        /// </summary>
        public static readonly ScalingMode STANDARD = new ScalingMode("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingMode FindValue(string value)
        {
            return FindValue<ScalingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant OPT_IN for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus OPT_IN = new SubscriptionStatus("OPT_IN");
        /// <summary>
        /// Constant OPT_OUT for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus OPT_OUT = new SubscriptionStatus("OPT_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuppressionListImportAction.
    /// </summary>
    public class SuppressionListImportAction : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for SuppressionListImportAction
        /// </summary>
        public static readonly SuppressionListImportAction DELETE = new SuppressionListImportAction("DELETE");
        /// <summary>
        /// Constant PUT for SuppressionListImportAction
        /// </summary>
        public static readonly SuppressionListImportAction PUT = new SuppressionListImportAction("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuppressionListImportAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuppressionListImportAction FindValue(string value)
        {
            return FindValue<SuppressionListImportAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuppressionListImportAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuppressionListReason.
    /// </summary>
    public class SuppressionListReason : ConstantClass
    {

        /// <summary>
        /// Constant BOUNCE for SuppressionListReason
        /// </summary>
        public static readonly SuppressionListReason BOUNCE = new SuppressionListReason("BOUNCE");
        /// <summary>
        /// Constant COMPLAINT for SuppressionListReason
        /// </summary>
        public static readonly SuppressionListReason COMPLAINT = new SuppressionListReason("COMPLAINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuppressionListReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuppressionListReason FindValue(string value)
        {
            return FindValue<SuppressionListReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuppressionListReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TlsPolicy.
    /// </summary>
    public class TlsPolicy : ConstantClass
    {

        /// <summary>
        /// Constant OPTIONAL for TlsPolicy
        /// </summary>
        public static readonly TlsPolicy OPTIONAL = new TlsPolicy("OPTIONAL");
        /// <summary>
        /// Constant REQUIRE for TlsPolicy
        /// </summary>
        public static readonly TlsPolicy REQUIRE = new TlsPolicy("REQUIRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TlsPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TlsPolicy FindValue(string value)
        {
            return FindValue<TlsPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TlsPolicy(string value)
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
        /// Constant FAILED for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus FAILED = new VerificationStatus("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus NOT_STARTED = new VerificationStatus("NOT_STARTED");
        /// <summary>
        /// Constant PENDING for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus PENDING = new VerificationStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus SUCCESS = new VerificationStatus("SUCCESS");
        /// <summary>
        /// Constant TEMPORARY_FAILURE for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus TEMPORARY_FAILURE = new VerificationStatus("TEMPORARY_FAILURE");

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
    /// Constants used for properties of type WarmupStatus.
    /// </summary>
    public class WarmupStatus : ConstantClass
    {

        /// <summary>
        /// Constant DONE for WarmupStatus
        /// </summary>
        public static readonly WarmupStatus DONE = new WarmupStatus("DONE");
        /// <summary>
        /// Constant IN_PROGRESS for WarmupStatus
        /// </summary>
        public static readonly WarmupStatus IN_PROGRESS = new WarmupStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WarmupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WarmupStatus FindValue(string value)
        {
            return FindValue<WarmupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WarmupStatus(string value)
        {
            return FindValue(value);
        }
    }

}