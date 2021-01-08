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