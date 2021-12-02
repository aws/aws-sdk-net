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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Shield
{

    /// <summary>
    /// Constants used for properties of type ApplicationLayerAutomaticResponseStatus.
    /// </summary>
    public class ApplicationLayerAutomaticResponseStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ApplicationLayerAutomaticResponseStatus
        /// </summary>
        public static readonly ApplicationLayerAutomaticResponseStatus DISABLED = new ApplicationLayerAutomaticResponseStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ApplicationLayerAutomaticResponseStatus
        /// </summary>
        public static readonly ApplicationLayerAutomaticResponseStatus ENABLED = new ApplicationLayerAutomaticResponseStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationLayerAutomaticResponseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationLayerAutomaticResponseStatus FindValue(string value)
        {
            return FindValue<ApplicationLayerAutomaticResponseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationLayerAutomaticResponseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttackLayer.
    /// </summary>
    public class AttackLayer : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for AttackLayer
        /// </summary>
        public static readonly AttackLayer APPLICATION = new AttackLayer("APPLICATION");
        /// <summary>
        /// Constant NETWORK for AttackLayer
        /// </summary>
        public static readonly AttackLayer NETWORK = new AttackLayer("NETWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttackLayer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttackLayer FindValue(string value)
        {
            return FindValue<AttackLayer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttackLayer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttackPropertyIdentifier.
    /// </summary>
    public class AttackPropertyIdentifier : ConstantClass
    {

        /// <summary>
        /// Constant DESTINATION_URL for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier DESTINATION_URL = new AttackPropertyIdentifier("DESTINATION_URL");
        /// <summary>
        /// Constant REFERRER for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier REFERRER = new AttackPropertyIdentifier("REFERRER");
        /// <summary>
        /// Constant SOURCE_ASN for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_ASN = new AttackPropertyIdentifier("SOURCE_ASN");
        /// <summary>
        /// Constant SOURCE_COUNTRY for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_COUNTRY = new AttackPropertyIdentifier("SOURCE_COUNTRY");
        /// <summary>
        /// Constant SOURCE_IP_ADDRESS for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_IP_ADDRESS = new AttackPropertyIdentifier("SOURCE_IP_ADDRESS");
        /// <summary>
        /// Constant SOURCE_USER_AGENT for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_USER_AGENT = new AttackPropertyIdentifier("SOURCE_USER_AGENT");
        /// <summary>
        /// Constant WORDPRESS_PINGBACK_REFLECTOR for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier WORDPRESS_PINGBACK_REFLECTOR = new AttackPropertyIdentifier("WORDPRESS_PINGBACK_REFLECTOR");
        /// <summary>
        /// Constant WORDPRESS_PINGBACK_SOURCE for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier WORDPRESS_PINGBACK_SOURCE = new AttackPropertyIdentifier("WORDPRESS_PINGBACK_SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttackPropertyIdentifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttackPropertyIdentifier FindValue(string value)
        {
            return FindValue<AttackPropertyIdentifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttackPropertyIdentifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoRenew.
    /// </summary>
    public class AutoRenew : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutoRenew
        /// </summary>
        public static readonly AutoRenew DISABLED = new AutoRenew("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutoRenew
        /// </summary>
        public static readonly AutoRenew ENABLED = new AutoRenew("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoRenew(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoRenew FindValue(string value)
        {
            return FindValue<AutoRenew>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoRenew(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProactiveEngagementStatus.
    /// </summary>
    public class ProactiveEngagementStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ProactiveEngagementStatus
        /// </summary>
        public static readonly ProactiveEngagementStatus DISABLED = new ProactiveEngagementStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ProactiveEngagementStatus
        /// </summary>
        public static readonly ProactiveEngagementStatus ENABLED = new ProactiveEngagementStatus("ENABLED");
        /// <summary>
        /// Constant PENDING for ProactiveEngagementStatus
        /// </summary>
        public static readonly ProactiveEngagementStatus PENDING = new ProactiveEngagementStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProactiveEngagementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProactiveEngagementStatus FindValue(string value)
        {
            return FindValue<ProactiveEngagementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProactiveEngagementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedResourceType.
    /// </summary>
    public class ProtectedResourceType : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION_LOAD_BALANCER for ProtectedResourceType
        /// </summary>
        public static readonly ProtectedResourceType APPLICATION_LOAD_BALANCER = new ProtectedResourceType("APPLICATION_LOAD_BALANCER");
        /// <summary>
        /// Constant CLASSIC_LOAD_BALANCER for ProtectedResourceType
        /// </summary>
        public static readonly ProtectedResourceType CLASSIC_LOAD_BALANCER = new ProtectedResourceType("CLASSIC_LOAD_BALANCER");
        /// <summary>
        /// Constant CLOUDFRONT_DISTRIBUTION for ProtectedResourceType
        /// </summary>
        public static readonly ProtectedResourceType CLOUDFRONT_DISTRIBUTION = new ProtectedResourceType("CLOUDFRONT_DISTRIBUTION");
        /// <summary>
        /// Constant ELASTIC_IP_ALLOCATION for ProtectedResourceType
        /// </summary>
        public static readonly ProtectedResourceType ELASTIC_IP_ALLOCATION = new ProtectedResourceType("ELASTIC_IP_ALLOCATION");
        /// <summary>
        /// Constant GLOBAL_ACCELERATOR for ProtectedResourceType
        /// </summary>
        public static readonly ProtectedResourceType GLOBAL_ACCELERATOR = new ProtectedResourceType("GLOBAL_ACCELERATOR");
        /// <summary>
        /// Constant ROUTE_53_HOSTED_ZONE for ProtectedResourceType
        /// </summary>
        public static readonly ProtectedResourceType ROUTE_53_HOSTED_ZONE = new ProtectedResourceType("ROUTE_53_HOSTED_ZONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedResourceType FindValue(string value)
        {
            return FindValue<ProtectedResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectionGroupAggregation.
    /// </summary>
    public class ProtectionGroupAggregation : ConstantClass
    {

        /// <summary>
        /// Constant MAX for ProtectionGroupAggregation
        /// </summary>
        public static readonly ProtectionGroupAggregation MAX = new ProtectionGroupAggregation("MAX");
        /// <summary>
        /// Constant MEAN for ProtectionGroupAggregation
        /// </summary>
        public static readonly ProtectionGroupAggregation MEAN = new ProtectionGroupAggregation("MEAN");
        /// <summary>
        /// Constant SUM for ProtectionGroupAggregation
        /// </summary>
        public static readonly ProtectionGroupAggregation SUM = new ProtectionGroupAggregation("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectionGroupAggregation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectionGroupAggregation FindValue(string value)
        {
            return FindValue<ProtectionGroupAggregation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectionGroupAggregation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectionGroupPattern.
    /// </summary>
    public class ProtectionGroupPattern : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ProtectionGroupPattern
        /// </summary>
        public static readonly ProtectionGroupPattern ALL = new ProtectionGroupPattern("ALL");
        /// <summary>
        /// Constant ARBITRARY for ProtectionGroupPattern
        /// </summary>
        public static readonly ProtectionGroupPattern ARBITRARY = new ProtectionGroupPattern("ARBITRARY");
        /// <summary>
        /// Constant BY_RESOURCE_TYPE for ProtectionGroupPattern
        /// </summary>
        public static readonly ProtectionGroupPattern BY_RESOURCE_TYPE = new ProtectionGroupPattern("BY_RESOURCE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectionGroupPattern(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectionGroupPattern FindValue(string value)
        {
            return FindValue<ProtectionGroupPattern>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectionGroupPattern(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubResourceType.
    /// </summary>
    public class SubResourceType : ConstantClass
    {

        /// <summary>
        /// Constant IP for SubResourceType
        /// </summary>
        public static readonly SubResourceType IP = new SubResourceType("IP");
        /// <summary>
        /// Constant URL for SubResourceType
        /// </summary>
        public static readonly SubResourceType URL = new SubResourceType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubResourceType FindValue(string value)
        {
            return FindValue<SubResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionState.
    /// </summary>
    public class SubscriptionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SubscriptionState
        /// </summary>
        public static readonly SubscriptionState ACTIVE = new SubscriptionState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for SubscriptionState
        /// </summary>
        public static readonly SubscriptionState INACTIVE = new SubscriptionState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionState FindValue(string value)
        {
            return FindValue<SubscriptionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant BITS for Unit
        /// </summary>
        public static readonly Unit BITS = new Unit("BITS");
        /// <summary>
        /// Constant BYTES for Unit
        /// </summary>
        public static readonly Unit BYTES = new Unit("BYTES");
        /// <summary>
        /// Constant PACKETS for Unit
        /// </summary>
        public static readonly Unit PACKETS = new Unit("PACKETS");
        /// <summary>
        /// Constant REQUESTS for Unit
        /// </summary>
        public static readonly Unit REQUESTS = new Unit("REQUESTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
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
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");

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

}