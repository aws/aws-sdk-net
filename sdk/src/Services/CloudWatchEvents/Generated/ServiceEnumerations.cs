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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchEvents
{

    /// <summary>
    /// Constants used for properties of type ApiDestinationHttpMethod.
    /// </summary>
    public class ApiDestinationHttpMethod : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod DELETE = new ApiDestinationHttpMethod("DELETE");
        /// <summary>
        /// Constant GET for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod GET = new ApiDestinationHttpMethod("GET");
        /// <summary>
        /// Constant HEAD for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod HEAD = new ApiDestinationHttpMethod("HEAD");
        /// <summary>
        /// Constant OPTIONS for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod OPTIONS = new ApiDestinationHttpMethod("OPTIONS");
        /// <summary>
        /// Constant PATCH for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod PATCH = new ApiDestinationHttpMethod("PATCH");
        /// <summary>
        /// Constant POST for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod POST = new ApiDestinationHttpMethod("POST");
        /// <summary>
        /// Constant PUT for ApiDestinationHttpMethod
        /// </summary>
        public static readonly ApiDestinationHttpMethod PUT = new ApiDestinationHttpMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiDestinationHttpMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiDestinationHttpMethod FindValue(string value)
        {
            return FindValue<ApiDestinationHttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiDestinationHttpMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApiDestinationState.
    /// </summary>
    public class ApiDestinationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ApiDestinationState
        /// </summary>
        public static readonly ApiDestinationState ACTIVE = new ApiDestinationState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for ApiDestinationState
        /// </summary>
        public static readonly ApiDestinationState INACTIVE = new ApiDestinationState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiDestinationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiDestinationState FindValue(string value)
        {
            return FindValue<ApiDestinationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiDestinationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveState.
    /// </summary>
    public class ArchiveState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ArchiveState
        /// </summary>
        public static readonly ArchiveState CREATE_FAILED = new ArchiveState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for ArchiveState
        /// </summary>
        public static readonly ArchiveState CREATING = new ArchiveState("CREATING");
        /// <summary>
        /// Constant DISABLED for ArchiveState
        /// </summary>
        public static readonly ArchiveState DISABLED = new ArchiveState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ArchiveState
        /// </summary>
        public static readonly ArchiveState ENABLED = new ArchiveState("ENABLED");
        /// <summary>
        /// Constant UPDATE_FAILED for ArchiveState
        /// </summary>
        public static readonly ArchiveState UPDATE_FAILED = new ArchiveState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ArchiveState
        /// </summary>
        public static readonly ArchiveState UPDATING = new ArchiveState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveState FindValue(string value)
        {
            return FindValue<ArchiveState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssignPublicIp.
    /// </summary>
    public class AssignPublicIp : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AssignPublicIp
        /// </summary>
        public static readonly AssignPublicIp DISABLED = new AssignPublicIp("DISABLED");
        /// <summary>
        /// Constant ENABLED for AssignPublicIp
        /// </summary>
        public static readonly AssignPublicIp ENABLED = new AssignPublicIp("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssignPublicIp(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignPublicIp FindValue(string value)
        {
            return FindValue<AssignPublicIp>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignPublicIp(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionAuthorizationType.
    /// </summary>
    public class ConnectionAuthorizationType : ConstantClass
    {

        /// <summary>
        /// Constant API_KEY for ConnectionAuthorizationType
        /// </summary>
        public static readonly ConnectionAuthorizationType API_KEY = new ConnectionAuthorizationType("API_KEY");
        /// <summary>
        /// Constant BASIC for ConnectionAuthorizationType
        /// </summary>
        public static readonly ConnectionAuthorizationType BASIC = new ConnectionAuthorizationType("BASIC");
        /// <summary>
        /// Constant OAUTH_CLIENT_CREDENTIALS for ConnectionAuthorizationType
        /// </summary>
        public static readonly ConnectionAuthorizationType OAUTH_CLIENT_CREDENTIALS = new ConnectionAuthorizationType("OAUTH_CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionAuthorizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionAuthorizationType FindValue(string value)
        {
            return FindValue<ConnectionAuthorizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionAuthorizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionOAuthHttpMethod.
    /// </summary>
    public class ConnectionOAuthHttpMethod : ConstantClass
    {

        /// <summary>
        /// Constant GET for ConnectionOAuthHttpMethod
        /// </summary>
        public static readonly ConnectionOAuthHttpMethod GET = new ConnectionOAuthHttpMethod("GET");
        /// <summary>
        /// Constant POST for ConnectionOAuthHttpMethod
        /// </summary>
        public static readonly ConnectionOAuthHttpMethod POST = new ConnectionOAuthHttpMethod("POST");
        /// <summary>
        /// Constant PUT for ConnectionOAuthHttpMethod
        /// </summary>
        public static readonly ConnectionOAuthHttpMethod PUT = new ConnectionOAuthHttpMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionOAuthHttpMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionOAuthHttpMethod FindValue(string value)
        {
            return FindValue<ConnectionOAuthHttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionOAuthHttpMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionState.
    /// </summary>
    public class ConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZED for ConnectionState
        /// </summary>
        public static readonly ConnectionState AUTHORIZED = new ConnectionState("AUTHORIZED");
        /// <summary>
        /// Constant AUTHORIZING for ConnectionState
        /// </summary>
        public static readonly ConnectionState AUTHORIZING = new ConnectionState("AUTHORIZING");
        /// <summary>
        /// Constant CREATING for ConnectionState
        /// </summary>
        public static readonly ConnectionState CREATING = new ConnectionState("CREATING");
        /// <summary>
        /// Constant DEAUTHORIZED for ConnectionState
        /// </summary>
        public static readonly ConnectionState DEAUTHORIZED = new ConnectionState("DEAUTHORIZED");
        /// <summary>
        /// Constant DEAUTHORIZING for ConnectionState
        /// </summary>
        public static readonly ConnectionState DEAUTHORIZING = new ConnectionState("DEAUTHORIZING");
        /// <summary>
        /// Constant DELETING for ConnectionState
        /// </summary>
        public static readonly ConnectionState DELETING = new ConnectionState("DELETING");
        /// <summary>
        /// Constant UPDATING for ConnectionState
        /// </summary>
        public static readonly ConnectionState UPDATING = new ConnectionState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionState FindValue(string value)
        {
            return FindValue<ConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourceState.
    /// </summary>
    public class EventSourceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EventSourceState
        /// </summary>
        public static readonly EventSourceState ACTIVE = new EventSourceState("ACTIVE");
        /// <summary>
        /// Constant DELETED for EventSourceState
        /// </summary>
        public static readonly EventSourceState DELETED = new EventSourceState("DELETED");
        /// <summary>
        /// Constant PENDING for EventSourceState
        /// </summary>
        public static readonly EventSourceState PENDING = new EventSourceState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceState FindValue(string value)
        {
            return FindValue<EventSourceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchType.
    /// </summary>
    public class LaunchType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for LaunchType
        /// </summary>
        public static readonly LaunchType EC2 = new LaunchType("EC2");
        /// <summary>
        /// Constant EXTERNAL for LaunchType
        /// </summary>
        public static readonly LaunchType EXTERNAL = new LaunchType("EXTERNAL");
        /// <summary>
        /// Constant FARGATE for LaunchType
        /// </summary>
        public static readonly LaunchType FARGATE = new LaunchType("FARGATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchType FindValue(string value)
        {
            return FindValue<LaunchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementConstraintType.
    /// </summary>
    public class PlacementConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant DistinctInstance for PlacementConstraintType
        /// </summary>
        public static readonly PlacementConstraintType DistinctInstance = new PlacementConstraintType("distinctInstance");
        /// <summary>
        /// Constant MemberOf for PlacementConstraintType
        /// </summary>
        public static readonly PlacementConstraintType MemberOf = new PlacementConstraintType("memberOf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementConstraintType FindValue(string value)
        {
            return FindValue<PlacementConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementStrategyType.
    /// </summary>
    public class PlacementStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant Binpack for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Binpack = new PlacementStrategyType("binpack");
        /// <summary>
        /// Constant Random for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Random = new PlacementStrategyType("random");
        /// <summary>
        /// Constant Spread for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Spread = new PlacementStrategyType("spread");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementStrategyType FindValue(string value)
        {
            return FindValue<PlacementStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropagateTags.
    /// </summary>
    public class PropagateTags : ConstantClass
    {

        /// <summary>
        /// Constant TASK_DEFINITION for PropagateTags
        /// </summary>
        public static readonly PropagateTags TASK_DEFINITION = new PropagateTags("TASK_DEFINITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropagateTags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropagateTags FindValue(string value)
        {
            return FindValue<PropagateTags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropagateTags(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplayState.
    /// </summary>
    public class ReplayState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ReplayState
        /// </summary>
        public static readonly ReplayState CANCELLED = new ReplayState("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ReplayState
        /// </summary>
        public static readonly ReplayState CANCELLING = new ReplayState("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for ReplayState
        /// </summary>
        public static readonly ReplayState COMPLETED = new ReplayState("COMPLETED");
        /// <summary>
        /// Constant FAILED for ReplayState
        /// </summary>
        public static readonly ReplayState FAILED = new ReplayState("FAILED");
        /// <summary>
        /// Constant RUNNING for ReplayState
        /// </summary>
        public static readonly ReplayState RUNNING = new ReplayState("RUNNING");
        /// <summary>
        /// Constant STARTING for ReplayState
        /// </summary>
        public static readonly ReplayState STARTING = new ReplayState("STARTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplayState FindValue(string value)
        {
            return FindValue<ReplayState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplayState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleState.
    /// </summary>
    public class RuleState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RuleState
        /// </summary>
        public static readonly RuleState DISABLED = new RuleState("DISABLED");
        /// <summary>
        /// Constant ENABLED for RuleState
        /// </summary>
        public static readonly RuleState ENABLED = new RuleState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleState FindValue(string value)
        {
            return FindValue<RuleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleState(string value)
        {
            return FindValue(value);
        }
    }

}