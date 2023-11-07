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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LaunchWizard
{

    /// <summary>
    /// Constants used for properties of type DeploymentFilterKey.
    /// </summary>
    public class DeploymentFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYMENT_STATUS for DeploymentFilterKey
        /// </summary>
        public static readonly DeploymentFilterKey DEPLOYMENT_STATUS = new DeploymentFilterKey("DEPLOYMENT_STATUS");
        /// <summary>
        /// Constant WORKLOAD_NAME for DeploymentFilterKey
        /// </summary>
        public static readonly DeploymentFilterKey WORKLOAD_NAME = new DeploymentFilterKey("WORKLOAD_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentFilterKey FindValue(string value)
        {
            return FindValue<DeploymentFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus COMPLETED = new DeploymentStatus("COMPLETED");
        /// <summary>
        /// Constant CREATING for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus CREATING = new DeploymentStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETE_FAILED = new DeploymentStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETE_IN_PROGRESS = new DeploymentStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_INITIATING for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETE_INITIATING = new DeploymentStatus("DELETE_INITIATING");
        /// <summary>
        /// Constant DELETED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETED = new DeploymentStatus("DELETED");
        /// <summary>
        /// Constant FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAILED = new DeploymentStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IN_PROGRESS = new DeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant VALIDATING for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus VALIDATING = new DeploymentStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
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
        /// Constant CANCELED for EventStatus
        /// </summary>
        public static readonly EventStatus CANCELED = new EventStatus("CANCELED");
        /// <summary>
        /// Constant CANCELING for EventStatus
        /// </summary>
        public static readonly EventStatus CANCELING = new EventStatus("CANCELING");
        /// <summary>
        /// Constant COMPLETED for EventStatus
        /// </summary>
        public static readonly EventStatus COMPLETED = new EventStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for EventStatus
        /// </summary>
        public static readonly EventStatus CREATED = new EventStatus("CREATED");
        /// <summary>
        /// Constant FAILED for EventStatus
        /// </summary>
        public static readonly EventStatus FAILED = new EventStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for EventStatus
        /// </summary>
        public static readonly EventStatus IN_PROGRESS = new EventStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for EventStatus
        /// </summary>
        public static readonly EventStatus PENDING = new EventStatus("PENDING");
        /// <summary>
        /// Constant TIMED_OUT for EventStatus
        /// </summary>
        public static readonly EventStatus TIMED_OUT = new EventStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventStatus(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type WorkloadDeploymentPatternStatus.
    /// </summary>
    public class WorkloadDeploymentPatternStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkloadDeploymentPatternStatus
        /// </summary>
        public static readonly WorkloadDeploymentPatternStatus ACTIVE = new WorkloadDeploymentPatternStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for WorkloadDeploymentPatternStatus
        /// </summary>
        public static readonly WorkloadDeploymentPatternStatus DELETED = new WorkloadDeploymentPatternStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for WorkloadDeploymentPatternStatus
        /// </summary>
        public static readonly WorkloadDeploymentPatternStatus DISABLED = new WorkloadDeploymentPatternStatus("DISABLED");
        /// <summary>
        /// Constant INACTIVE for WorkloadDeploymentPatternStatus
        /// </summary>
        public static readonly WorkloadDeploymentPatternStatus INACTIVE = new WorkloadDeploymentPatternStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadDeploymentPatternStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadDeploymentPatternStatus FindValue(string value)
        {
            return FindValue<WorkloadDeploymentPatternStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadDeploymentPatternStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadStatus.
    /// </summary>
    public class WorkloadStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkloadStatus
        /// </summary>
        public static readonly WorkloadStatus ACTIVE = new WorkloadStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for WorkloadStatus
        /// </summary>
        public static readonly WorkloadStatus DELETED = new WorkloadStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for WorkloadStatus
        /// </summary>
        public static readonly WorkloadStatus DISABLED = new WorkloadStatus("DISABLED");
        /// <summary>
        /// Constant INACTIVE for WorkloadStatus
        /// </summary>
        public static readonly WorkloadStatus INACTIVE = new WorkloadStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadStatus FindValue(string value)
        {
            return FindValue<WorkloadStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadStatus(string value)
        {
            return FindValue(value);
        }
    }

}