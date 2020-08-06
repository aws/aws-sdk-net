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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PinpointEmail
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