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

namespace Amazon.APIPortal
{
    /// <summary>
    /// Constants used for properties of type ApiSelectionMode.
    /// </summary>
    public class ApiSelectionMode : ConstantClass
    {
        /// <summary>
        /// Constant CUSTOM for ApiSelectionMode
        /// </summary>
        public static readonly ApiSelectionMode CUSTOM = new ApiSelectionMode("CUSTOM");

        /// <summary>
        /// Constant RULE_BASED for ApiSelectionMode
        /// </summary>
        public static readonly ApiSelectionMode RULE_BASED = new ApiSelectionMode("RULE_BASED");

        /// <summary>
        /// Constructs a custom ApiSelectionMode for a value not among the defined constants.
        /// </summary>
        public ApiSelectionMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiSelectionMode FindValue(string value)
        {
            return FindValue<ApiSelectionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiSelectionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Classification.
    /// </summary>
    public class Classification : ConstantClass
    {
        /// <summary>
        /// Constant MANAGED for Classification
        /// </summary>
        public static readonly Classification MANAGED = new Classification("MANAGED");

        /// <summary>
        /// Constant MANAGED_ORPHANED for Classification
        /// </summary>
        public static readonly Classification MANAGED_ORPHANED = new Classification("MANAGED_ORPHANED");

        /// <summary>
        /// Constant MANAGED_ZOMBIE for Classification
        /// </summary>
        public static readonly Classification MANAGED_ZOMBIE = new Classification("MANAGED_ZOMBIE");

        /// <summary>
        /// Constant SHADOW for Classification
        /// </summary>
        public static readonly Classification SHADOW = new Classification("SHADOW");

        /// <summary>
        /// Constructs a custom Classification for a value not among the defined constants.
        /// </summary>
        public Classification(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Classification FindValue(string value)
        {
            return FindValue<Classification>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Classification(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Confidence.
    /// </summary>
    public class Confidence : ConstantClass
    {
        /// <summary>
        /// Constant HIGH for Confidence
        /// </summary>
        public static readonly Confidence HIGH = new Confidence("HIGH");

        /// <summary>
        /// Constant LOW for Confidence
        /// </summary>
        public static readonly Confidence LOW = new Confidence("LOW");

        /// <summary>
        /// Constant MEDIUM for Confidence
        /// </summary>
        public static readonly Confidence MEDIUM = new Confidence("MEDIUM");

        /// <summary>
        /// Constructs a custom Confidence for a value not among the defined constants.
        /// </summary>
        public Confidence(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Confidence FindValue(string value)
        {
            return FindValue<Confidence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Confidence(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DesiredPublishStatus.
    /// </summary>
    public class DesiredPublishStatus : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for DesiredPublishStatus
        /// </summary>
        public static readonly DesiredPublishStatus DISABLED = new DesiredPublishStatus("DISABLED");

        /// <summary>
        /// Constant PUBLISHED for DesiredPublishStatus
        /// </summary>
        public static readonly DesiredPublishStatus PUBLISHED = new DesiredPublishStatus("PUBLISHED");

        /// <summary>
        /// Constructs a custom DesiredPublishStatus for a value not among the defined constants.
        /// </summary>
        public DesiredPublishStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredPublishStatus FindValue(string value)
        {
            return FindValue<DesiredPublishStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredPublishStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DiscoveryConfigurationStatus.
    /// </summary>
    public class DiscoveryConfigurationStatus : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for DiscoveryConfigurationStatus
        /// </summary>
        public static readonly DiscoveryConfigurationStatus DISABLED = new DiscoveryConfigurationStatus("DISABLED");

        /// <summary>
        /// Constant ENABLED for DiscoveryConfigurationStatus
        /// </summary>
        public static readonly DiscoveryConfigurationStatus ENABLED = new DiscoveryConfigurationStatus("ENABLED");

        /// <summary>
        /// Constant UPDATING for DiscoveryConfigurationStatus
        /// </summary>
        public static readonly DiscoveryConfigurationStatus UPDATING = new DiscoveryConfigurationStatus("UPDATING");

        /// <summary>
        /// Constructs a custom DiscoveryConfigurationStatus for a value not among the defined constants.
        /// </summary>
        public DiscoveryConfigurationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryConfigurationStatus FindValue(string value)
        {
            return FindValue<DiscoveryConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DiscoveryFailureReason.
    /// </summary>
    public class DiscoveryFailureReason : ConstantClass
    {
        /// <summary>
        /// Constant ACCESS_DENIED for DiscoveryFailureReason
        /// </summary>
        public static readonly DiscoveryFailureReason ACCESS_DENIED = new DiscoveryFailureReason("ACCESS_DENIED");

        /// <summary>
        /// Constant DEPENDENCY_ERROR for DiscoveryFailureReason
        /// </summary>
        public static readonly DiscoveryFailureReason DEPENDENCY_ERROR = new DiscoveryFailureReason("DEPENDENCY_ERROR");

        /// <summary>
        /// Constant INTERNAL_ERROR for DiscoveryFailureReason
        /// </summary>
        public static readonly DiscoveryFailureReason INTERNAL_ERROR = new DiscoveryFailureReason("INTERNAL_ERROR");

        /// <summary>
        /// Constant INVALID_CONFIGURATION for DiscoveryFailureReason
        /// </summary>
        public static readonly DiscoveryFailureReason INVALID_CONFIGURATION = new DiscoveryFailureReason("INVALID_CONFIGURATION");

        /// <summary>
        /// Constant THROTTLED for DiscoveryFailureReason
        /// </summary>
        public static readonly DiscoveryFailureReason THROTTLED = new DiscoveryFailureReason("THROTTLED");

        /// <summary>
        /// Constructs a custom DiscoveryFailureReason for a value not among the defined constants.
        /// </summary>
        public DiscoveryFailureReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryFailureReason FindValue(string value)
        {
            return FindValue<DiscoveryFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryFailureReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DiscoveryFeature.
    /// </summary>
    public class DiscoveryFeature : ConstantClass
    {
        /// <summary>
        /// Constant AI_DISCOVERY for DiscoveryFeature
        /// </summary>
        public static readonly DiscoveryFeature AI_DISCOVERY = new DiscoveryFeature("AI_DISCOVERY");

        /// <summary>
        /// Constructs a custom DiscoveryFeature for a value not among the defined constants.
        /// </summary>
        public DiscoveryFeature(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryFeature FindValue(string value)
        {
            return FindValue<DiscoveryFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryFeature(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DiscoverySource.
    /// </summary>
    public class DiscoverySource : ConstantClass
    {
        /// <summary>
        /// Constant API_GATEWAY for DiscoverySource
        /// </summary>
        public static readonly DiscoverySource API_GATEWAY = new DiscoverySource("API_GATEWAY");

        /// <summary>
        /// Constant CLOUDFRONT for DiscoverySource
        /// </summary>
        public static readonly DiscoverySource CLOUDFRONT = new DiscoverySource("CLOUDFRONT");

        /// <summary>
        /// Constant ELB for DiscoverySource
        /// </summary>
        public static readonly DiscoverySource ELB = new DiscoverySource("ELB");

        /// <summary>
        /// Constructs a custom DiscoverySource for a value not among the defined constants.
        /// </summary>
        public DiscoverySource(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoverySource FindValue(string value)
        {
            return FindValue<DiscoverySource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoverySource(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DiscoveryStatusValue.
    /// </summary>
    public class DiscoveryStatusValue : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for DiscoveryStatusValue
        /// </summary>
        public static readonly DiscoveryStatusValue FAILED = new DiscoveryStatusValue("FAILED");

        /// <summary>
        /// Constant PROVISIONING for DiscoveryStatusValue
        /// </summary>
        public static readonly DiscoveryStatusValue PROVISIONING = new DiscoveryStatusValue("PROVISIONING");

        /// <summary>
        /// Constant RUNNING for DiscoveryStatusValue
        /// </summary>
        public static readonly DiscoveryStatusValue RUNNING = new DiscoveryStatusValue("RUNNING");

        /// <summary>
        /// Constant STOPPED for DiscoveryStatusValue
        /// </summary>
        public static readonly DiscoveryStatusValue STOPPED = new DiscoveryStatusValue("STOPPED");

        /// <summary>
        /// Constructs a custom DiscoveryStatusValue for a value not among the defined constants.
        /// </summary>
        public DiscoveryStatusValue(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryStatusValue FindValue(string value)
        {
            return FindValue<DiscoveryStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryStatusValue(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EventStatus.
    /// </summary>
    public class EventStatus : ConstantClass
    {
        /// <summary>
        /// Constant EVENT_ENDED for EventStatus
        /// </summary>
        public static readonly EventStatus EVENT_ENDED = new EventStatus("EVENT_ENDED");

        /// <summary>
        /// Constant EVENT_IN_PROGRESS for EventStatus
        /// </summary>
        public static readonly EventStatus EVENT_IN_PROGRESS = new EventStatus("EVENT_IN_PROGRESS");

        /// <summary>
        /// Constant EVENT_STARTED for EventStatus
        /// </summary>
        public static readonly EventStatus EVENT_STARTED = new EventStatus("EVENT_STARTED");

        /// <summary>
        /// Constructs a custom EventStatus for a value not among the defined constants.
        /// </summary>
        public EventStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventStatus FindValue(string value)
        {
            return FindValue<EventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventStatus(string value)
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
        /// Constant WAF_API_SECURITY for EventType
        /// </summary>
        public static readonly EventType WAF_API_SECURITY = new EventType("WAF_API_SECURITY");

        /// <summary>
        /// Constructs a custom EventType for a value not among the defined constants.
        /// </summary>
        public EventType(string value) : base(value) { }

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
    /// Constants used for properties of type FailedItemErrorCode.
    /// </summary>
    public class FailedItemErrorCode : ConstantClass
    {
        /// <summary>
        /// Constant INTERNAL_ERROR for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode INTERNAL_ERROR = new FailedItemErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// Constant MANAGED_API_NOT_FOUND for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode MANAGED_API_NOT_FOUND = new FailedItemErrorCode("MANAGED_API_NOT_FOUND");

        /// <summary>
        /// Constructs a custom FailedItemErrorCode for a value not among the defined constants.
        /// </summary>
        public FailedItemErrorCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailedItemErrorCode FindValue(string value)
        {
            return FindValue<FailedItemErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailedItemErrorCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingReason.
    /// </summary>
    public class FindingReason : ConstantClass
    {
        /// <summary>
        /// Constant API_KEY_NOT_CONFIGURED for FindingReason
        /// </summary>
        public static readonly FindingReason API_KEY_NOT_CONFIGURED = new FindingReason("API_KEY_NOT_CONFIGURED");

        /// <summary>
        /// Constant AUTHENTICATION_NOT_CONFIGURED for FindingReason
        /// </summary>
        public static readonly FindingReason AUTHENTICATION_NOT_CONFIGURED = new FindingReason("AUTHENTICATION_NOT_CONFIGURED");

        /// <summary>
        /// Constant DISTRIBUTION_ACCESS_LOGGING_NOT_ENABLED for FindingReason
        /// </summary>
        public static readonly FindingReason DISTRIBUTION_ACCESS_LOGGING_NOT_ENABLED = new FindingReason("DISTRIBUTION_ACCESS_LOGGING_NOT_ENABLED");

        /// <summary>
        /// Constant DISTRIBUTION_SERVES_PLAINTEXT_HTTP for FindingReason
        /// </summary>
        public static readonly FindingReason DISTRIBUTION_SERVES_PLAINTEXT_HTTP = new FindingReason("DISTRIBUTION_SERVES_PLAINTEXT_HTTP");

        /// <summary>
        /// Constant DISTRIBUTION_TLS_BELOW_1_2 for FindingReason
        /// </summary>
        public static readonly FindingReason DISTRIBUTION_TLS_BELOW_1_2 = new FindingReason("DISTRIBUTION_TLS_BELOW_1_2");

        /// <summary>
        /// Constant DISTRIBUTION_WAF_NOT_ASSOCIATED for FindingReason
        /// </summary>
        public static readonly FindingReason DISTRIBUTION_WAF_NOT_ASSOCIATED = new FindingReason("DISTRIBUTION_WAF_NOT_ASSOCIATED");

        /// <summary>
        /// Constant GEO_RESTRICTION_NOT_CONFIGURED for FindingReason
        /// </summary>
        public static readonly FindingReason GEO_RESTRICTION_NOT_CONFIGURED = new FindingReason("GEO_RESTRICTION_NOT_CONFIGURED");

        /// <summary>
        /// Constant LISTENER_TLS_BELOW_1_2 for FindingReason
        /// </summary>
        public static readonly FindingReason LISTENER_TLS_BELOW_1_2 = new FindingReason("LISTENER_TLS_BELOW_1_2");

        /// <summary>
        /// Constant LOAD_BALANCER_WAF_NOT_ASSOCIATED for FindingReason
        /// </summary>
        public static readonly FindingReason LOAD_BALANCER_WAF_NOT_ASSOCIATED = new FindingReason("LOAD_BALANCER_WAF_NOT_ASSOCIATED");

        /// <summary>
        /// Constant PRIVATE_API_RESOURCE_POLICY_MISSING for FindingReason
        /// </summary>
        public static readonly FindingReason PRIVATE_API_RESOURCE_POLICY_MISSING = new FindingReason("PRIVATE_API_RESOURCE_POLICY_MISSING");

        /// <summary>
        /// Constant REQUEST_VALIDATION_NOT_ENABLED for FindingReason
        /// </summary>
        public static readonly FindingReason REQUEST_VALIDATION_NOT_ENABLED = new FindingReason("REQUEST_VALIDATION_NOT_ENABLED");

        /// <summary>
        /// Constant RESPONSE_CACHING_NOT_ENABLED for FindingReason
        /// </summary>
        public static readonly FindingReason RESPONSE_CACHING_NOT_ENABLED = new FindingReason("RESPONSE_CACHING_NOT_ENABLED");

        /// <summary>
        /// Constant REST_API_TLS_BELOW_1_2 for FindingReason
        /// </summary>
        public static readonly FindingReason REST_API_TLS_BELOW_1_2 = new FindingReason("REST_API_TLS_BELOW_1_2");

        /// <summary>
        /// Constant STAGE_ACCESS_LOGGING_NOT_ENABLED for FindingReason
        /// </summary>
        public static readonly FindingReason STAGE_ACCESS_LOGGING_NOT_ENABLED = new FindingReason("STAGE_ACCESS_LOGGING_NOT_ENABLED");

        /// <summary>
        /// Constant STAGE_WAF_NOT_ASSOCIATED for FindingReason
        /// </summary>
        public static readonly FindingReason STAGE_WAF_NOT_ASSOCIATED = new FindingReason("STAGE_WAF_NOT_ASSOCIATED");

        /// <summary>
        /// Constant THROTTLING_BURST_LIMIT_NOT_SET for FindingReason
        /// </summary>
        public static readonly FindingReason THROTTLING_BURST_LIMIT_NOT_SET = new FindingReason("THROTTLING_BURST_LIMIT_NOT_SET");

        /// <summary>
        /// Constant THROTTLING_NOT_ENABLED for FindingReason
        /// </summary>
        public static readonly FindingReason THROTTLING_NOT_ENABLED = new FindingReason("THROTTLING_NOT_ENABLED");

        /// <summary>
        /// Constant THROTTLING_RATE_LIMIT_NOT_SET for FindingReason
        /// </summary>
        public static readonly FindingReason THROTTLING_RATE_LIMIT_NOT_SET = new FindingReason("THROTTLING_RATE_LIMIT_NOT_SET");

        /// <summary>
        /// Constant UNKNOWN for FindingReason
        /// </summary>
        public static readonly FindingReason UNKNOWN = new FindingReason("UNKNOWN");

        /// <summary>
        /// Constructs a custom FindingReason for a value not among the defined constants.
        /// </summary>
        public FindingReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingReason FindValue(string value)
        {
            return FindValue<FindingReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FineGrainedAccessControl.
    /// </summary>
    public class FineGrainedAccessControl : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for FineGrainedAccessControl
        /// </summary>
        public static readonly FineGrainedAccessControl DISABLED = new FineGrainedAccessControl("DISABLED");

        /// <summary>
        /// Constant ENABLED for FineGrainedAccessControl
        /// </summary>
        public static readonly FineGrainedAccessControl ENABLED = new FineGrainedAccessControl("ENABLED");

        /// <summary>
        /// Constructs a custom FineGrainedAccessControl for a value not among the defined constants.
        /// </summary>
        public FineGrainedAccessControl(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FineGrainedAccessControl FindValue(string value)
        {
            return FindValue<FineGrainedAccessControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FineGrainedAccessControl(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HttpMethod.
    /// </summary>
    public class HttpMethod : ConstantClass
    {
        /// <summary>
        /// Constant ANY for HttpMethod
        /// </summary>
        public static readonly HttpMethod ANY = new HttpMethod("ANY");

        /// <summary>
        /// Constant DELETE for HttpMethod
        /// </summary>
        public static readonly HttpMethod DELETE = new HttpMethod("DELETE");

        /// <summary>
        /// Constant GET for HttpMethod
        /// </summary>
        public static readonly HttpMethod GET = new HttpMethod("GET");

        /// <summary>
        /// Constant HEAD for HttpMethod
        /// </summary>
        public static readonly HttpMethod HEAD = new HttpMethod("HEAD");

        /// <summary>
        /// Constant OPTIONS for HttpMethod
        /// </summary>
        public static readonly HttpMethod OPTIONS = new HttpMethod("OPTIONS");

        /// <summary>
        /// Constant PATCH for HttpMethod
        /// </summary>
        public static readonly HttpMethod PATCH = new HttpMethod("PATCH");

        /// <summary>
        /// Constant POST for HttpMethod
        /// </summary>
        public static readonly HttpMethod POST = new HttpMethod("POST");

        /// <summary>
        /// Constant PUT for HttpMethod
        /// </summary>
        public static readonly HttpMethod PUT = new HttpMethod("PUT");

        /// <summary>
        /// Constructs a custom HttpMethod for a value not among the defined constants.
        /// </summary>
        public HttpMethod(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpMethod FindValue(string value)
        {
            return FindValue<HttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpMethod(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ManagedBy.
    /// </summary>
    public class ManagedBy : ConstantClass
    {
        /// <summary>
        /// Constant ORGANIZATION for ManagedBy
        /// </summary>
        public static readonly ManagedBy ORGANIZATION = new ManagedBy("ORGANIZATION");

        /// <summary>
        /// Constant SELF for ManagedBy
        /// </summary>
        public static readonly ManagedBy SELF = new ManagedBy("SELF");

        /// <summary>
        /// Constructs a custom ManagedBy for a value not among the defined constants.
        /// </summary>
        public ManagedBy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedBy FindValue(string value)
        {
            return FindValue<ManagedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedBy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PortalStatusExceptionType.
    /// </summary>
    public class PortalStatusExceptionType : ConstantClass
    {
        /// <summary>
        /// Constant CLOUDFRONT_DOMAIN_IN_USE for PortalStatusExceptionType
        /// </summary>
        public static readonly PortalStatusExceptionType CLOUDFRONT_DOMAIN_IN_USE = new PortalStatusExceptionType("CLOUDFRONT_DOMAIN_IN_USE");

        /// <summary>
        /// Constant INTERNAL_FAILURE for PortalStatusExceptionType
        /// </summary>
        public static readonly PortalStatusExceptionType INTERNAL_FAILURE = new PortalStatusExceptionType("INTERNAL_FAILURE");

        /// <summary>
        /// Constant MISSING_CLOUDFRONT_PERMISSIONS for PortalStatusExceptionType
        /// </summary>
        public static readonly PortalStatusExceptionType MISSING_CLOUDFRONT_PERMISSIONS = new PortalStatusExceptionType("MISSING_CLOUDFRONT_PERMISSIONS");

        /// <summary>
        /// Constant UNSHARED_PRODUCT_EXCEPTION for PortalStatusExceptionType
        /// </summary>
        public static readonly PortalStatusExceptionType UNSHARED_PRODUCT_EXCEPTION = new PortalStatusExceptionType("UNSHARED_PRODUCT_EXCEPTION");

        /// <summary>
        /// Constructs a custom PortalStatusExceptionType for a value not among the defined constants.
        /// </summary>
        public PortalStatusExceptionType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortalStatusExceptionType FindValue(string value)
        {
            return FindValue<PortalStatusExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortalStatusExceptionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PostureStatus.
    /// </summary>
    public class PostureStatus : ConstantClass
    {
        /// <summary>
        /// Constant FALSE for PostureStatus
        /// </summary>
        public static readonly PostureStatus FALSE = new PostureStatus("FALSE");

        /// <summary>
        /// Constant INSUFFICIENT_DATA for PostureStatus
        /// </summary>
        public static readonly PostureStatus INSUFFICIENT_DATA = new PostureStatus("INSUFFICIENT_DATA");

        /// <summary>
        /// Constant NOT_APPLICABLE for PostureStatus
        /// </summary>
        public static readonly PostureStatus NOT_APPLICABLE = new PostureStatus("NOT_APPLICABLE");

        /// <summary>
        /// Constant TRUE for PostureStatus
        /// </summary>
        public static readonly PostureStatus TRUE = new PostureStatus("TRUE");

        /// <summary>
        /// Constructs a custom PostureStatus for a value not among the defined constants.
        /// </summary>
        public PostureStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostureStatus FindValue(string value)
        {
            return FindValue<PostureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostureStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PreviewStatus.
    /// </summary>
    public class PreviewStatus : ConstantClass
    {
        /// <summary>
        /// Constant PREVIEW_FAILED for PreviewStatus
        /// </summary>
        public static readonly PreviewStatus PREVIEW_FAILED = new PreviewStatus("PREVIEW_FAILED");

        /// <summary>
        /// Constant PREVIEW_IN_PROGRESS for PreviewStatus
        /// </summary>
        public static readonly PreviewStatus PREVIEW_IN_PROGRESS = new PreviewStatus("PREVIEW_IN_PROGRESS");

        /// <summary>
        /// Constant PREVIEW_READY for PreviewStatus
        /// </summary>
        public static readonly PreviewStatus PREVIEW_READY = new PreviewStatus("PREVIEW_READY");

        /// <summary>
        /// Constructs a custom PreviewStatus for a value not among the defined constants.
        /// </summary>
        public PreviewStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreviewStatus FindValue(string value)
        {
            return FindValue<PreviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreviewStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProductApiPageStatusExceptionType.
    /// </summary>
    public class ProductApiPageStatusExceptionType : ConstantClass
    {
        /// <summary>
        /// Constant INTERNAL_FAILURE for ProductApiPageStatusExceptionType
        /// </summary>
        public static readonly ProductApiPageStatusExceptionType INTERNAL_FAILURE = new ProductApiPageStatusExceptionType("INTERNAL_FAILURE");

        /// <summary>
        /// Constant MEMBER_LEFT_ORG for ProductApiPageStatusExceptionType
        /// </summary>
        public static readonly ProductApiPageStatusExceptionType MEMBER_LEFT_ORG = new ProductApiPageStatusExceptionType("MEMBER_LEFT_ORG");

        /// <summary>
        /// Constant RESOURCE_DELETED for ProductApiPageStatusExceptionType
        /// </summary>
        public static readonly ProductApiPageStatusExceptionType RESOURCE_DELETED = new ProductApiPageStatusExceptionType("RESOURCE_DELETED");

        /// <summary>
        /// Constructs a custom ProductApiPageStatusExceptionType for a value not among the defined constants.
        /// </summary>
        public ProductApiPageStatusExceptionType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductApiPageStatusExceptionType FindValue(string value)
        {
            return FindValue<ProductApiPageStatusExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductApiPageStatusExceptionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProductFailureReason.
    /// </summary>
    public class ProductFailureReason : ConstantClass
    {
        /// <summary>
        /// Constant API_PAGE_ATTACHED for ProductFailureReason
        /// </summary>
        public static readonly ProductFailureReason API_PAGE_ATTACHED = new ProductFailureReason("API_PAGE_ATTACHED");

        /// <summary>
        /// Constant EVALUATION_ERROR for ProductFailureReason
        /// </summary>
        public static readonly ProductFailureReason EVALUATION_ERROR = new ProductFailureReason("EVALUATION_ERROR");

        /// <summary>
        /// Constructs a custom ProductFailureReason for a value not among the defined constants.
        /// </summary>
        public ProductFailureReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductFailureReason FindValue(string value)
        {
            return FindValue<ProductFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductFailureReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProductStatus.
    /// </summary>
    public class ProductStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for ProductStatus
        /// </summary>
        public static readonly ProductStatus ACTIVE = new ProductStatus("ACTIVE");

        /// <summary>
        /// Constant FAILED for ProductStatus
        /// </summary>
        public static readonly ProductStatus FAILED = new ProductStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for ProductStatus
        /// </summary>
        public static readonly ProductStatus IN_PROGRESS = new ProductStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom ProductStatus for a value not among the defined constants.
        /// </summary>
        public ProductStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductStatus FindValue(string value)
        {
            return FindValue<ProductStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PublishStatus.
    /// </summary>
    public class PublishStatus : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for PublishStatus
        /// </summary>
        public static readonly PublishStatus DISABLED = new PublishStatus("DISABLED");

        /// <summary>
        /// Constant DISABLE_FAILED for PublishStatus
        /// </summary>
        public static readonly PublishStatus DISABLE_FAILED = new PublishStatus("DISABLE_FAILED");

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for PublishStatus
        /// </summary>
        public static readonly PublishStatus DISABLE_IN_PROGRESS = new PublishStatus("DISABLE_IN_PROGRESS");

        /// <summary>
        /// Constant PUBLISHED for PublishStatus
        /// </summary>
        public static readonly PublishStatus PUBLISHED = new PublishStatus("PUBLISHED");

        /// <summary>
        /// Constant PUBLISH_FAILED for PublishStatus
        /// </summary>
        public static readonly PublishStatus PUBLISH_FAILED = new PublishStatus("PUBLISH_FAILED");

        /// <summary>
        /// Constant PUBLISH_IN_PROGRESS for PublishStatus
        /// </summary>
        public static readonly PublishStatus PUBLISH_IN_PROGRESS = new PublishStatus("PUBLISH_IN_PROGRESS");

        /// <summary>
        /// Constructs a custom PublishStatus for a value not among the defined constants.
        /// </summary>
        public PublishStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublishStatus FindValue(string value)
        {
            return FindValue<PublishStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublishStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResourceOwner.
    /// </summary>
    public class ResourceOwner : ConstantClass
    {
        /// <summary>
        /// Constant ALL for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner ALL = new ResourceOwner("ALL");

        /// <summary>
        /// Constant OTHER_ACCOUNTS for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner OTHER_ACCOUNTS = new ResourceOwner("OTHER_ACCOUNTS");

        /// <summary>
        /// Constant SELF for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner SELF = new ResourceOwner("SELF");

        /// <summary>
        /// Constructs a custom ResourceOwner for a value not among the defined constants.
        /// </summary>
        public ResourceOwner(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceOwner FindValue(string value)
        {
            return FindValue<ResourceOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceOwner(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RuleFilterKey.
    /// </summary>
    public class RuleFilterKey : ConstantClass
    {
        /// <summary>
        /// Constant ACCOUNT for RuleFilterKey
        /// </summary>
        public static readonly RuleFilterKey ACCOUNT = new RuleFilterKey("ACCOUNT");

        /// <summary>
        /// Constant HOST for RuleFilterKey
        /// </summary>
        public static readonly RuleFilterKey HOST = new RuleFilterKey("HOST");

        /// <summary>
        /// Constant METHOD for RuleFilterKey
        /// </summary>
        public static readonly RuleFilterKey METHOD = new RuleFilterKey("METHOD");

        /// <summary>
        /// Constant PATH for RuleFilterKey
        /// </summary>
        public static readonly RuleFilterKey PATH = new RuleFilterKey("PATH");

        /// <summary>
        /// Constant PORT for RuleFilterKey
        /// </summary>
        public static readonly RuleFilterKey PORT = new RuleFilterKey("PORT");

        /// <summary>
        /// Constant RESOURCE_ARN for RuleFilterKey
        /// </summary>
        public static readonly RuleFilterKey RESOURCE_ARN = new RuleFilterKey("RESOURCE_ARN");

        /// <summary>
        /// Constructs a custom RuleFilterKey for a value not among the defined constants.
        /// </summary>
        public RuleFilterKey(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleFilterKey FindValue(string value)
        {
            return FindValue<RuleFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleFilterKey(string value)
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
        /// Constant AVAILABLE for Status
        /// </summary>
        public static readonly Status AVAILABLE = new Status("AVAILABLE");

        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom Status for a value not among the defined constants.
        /// </summary>
        public Status(string value) : base(value) { }

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
    /// Constants used for properties of type TryItState.
    /// </summary>
    public class TryItState : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for TryItState
        /// </summary>
        public static readonly TryItState DISABLED = new TryItState("DISABLED");

        /// <summary>
        /// Constant ENABLED for TryItState
        /// </summary>
        public static readonly TryItState ENABLED = new TryItState("ENABLED");

        /// <summary>
        /// Constructs a custom TryItState for a value not among the defined constants.
        /// </summary>
        public TryItState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TryItState FindValue(string value)
        {
            return FindValue<TryItState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TryItState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Visibility.
    /// </summary>
    public class Visibility : ConstantClass
    {
        /// <summary>
        /// Constant PRIVATE for Visibility
        /// </summary>
        public static readonly Visibility PRIVATE = new Visibility("PRIVATE");

        /// <summary>
        /// Constant PUBLIC for Visibility
        /// </summary>
        public static readonly Visibility PUBLIC = new Visibility("PUBLIC");

        /// <summary>
        /// Constructs a custom Visibility for a value not among the defined constants.
        /// </summary>
        public Visibility(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Visibility FindValue(string value)
        {
            return FindValue<Visibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Visibility(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type WafStatus.
    /// </summary>
    public class WafStatus : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for WafStatus
        /// </summary>
        public static readonly WafStatus DISABLED = new WafStatus("DISABLED");

        /// <summary>
        /// Constant ENABLED for WafStatus
        /// </summary>
        public static readonly WafStatus ENABLED = new WafStatus("ENABLED");

        /// <summary>
        /// Constructs a custom WafStatus for a value not among the defined constants.
        /// </summary>
        public WafStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WafStatus FindValue(string value)
        {
            return FindValue<WafStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WafStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Workload.
    /// </summary>
    public class Workload : ConstantClass
    {
        /// <summary>
        /// Constant A2A for Workload
        /// </summary>
        public static readonly Workload A2A = new Workload("A2A");

        /// <summary>
        /// Constant LLM for Workload
        /// </summary>
        public static readonly Workload LLM = new Workload("LLM");

        /// <summary>
        /// Constant MCP for Workload
        /// </summary>
        public static readonly Workload MCP = new Workload("MCP");

        /// <summary>
        /// Constructs a custom Workload for a value not among the defined constants.
        /// </summary>
        public Workload(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Workload FindValue(string value)
        {
            return FindValue<Workload>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Workload(string value)
        {
            return FindValue(value);
        }
    }
}
