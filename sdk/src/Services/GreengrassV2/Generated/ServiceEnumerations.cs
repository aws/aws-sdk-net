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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GreengrassV2
{

    /// <summary>
    /// Constants used for properties of type CloudComponentState.
    /// </summary>
    public class CloudComponentState : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYABLE for CloudComponentState
        /// </summary>
        public static readonly CloudComponentState DEPLOYABLE = new CloudComponentState("DEPLOYABLE");
        /// <summary>
        /// Constant DEPRECATED for CloudComponentState
        /// </summary>
        public static readonly CloudComponentState DEPRECATED = new CloudComponentState("DEPRECATED");
        /// <summary>
        /// Constant FAILED for CloudComponentState
        /// </summary>
        public static readonly CloudComponentState FAILED = new CloudComponentState("FAILED");
        /// <summary>
        /// Constant INITIATED for CloudComponentState
        /// </summary>
        public static readonly CloudComponentState INITIATED = new CloudComponentState("INITIATED");
        /// <summary>
        /// Constant REQUESTED for CloudComponentState
        /// </summary>
        public static readonly CloudComponentState REQUESTED = new CloudComponentState("REQUESTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudComponentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudComponentState FindValue(string value)
        {
            return FindValue<CloudComponentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudComponentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentDependencyType.
    /// </summary>
    public class ComponentDependencyType : ConstantClass
    {

        /// <summary>
        /// Constant HARD for ComponentDependencyType
        /// </summary>
        public static readonly ComponentDependencyType HARD = new ComponentDependencyType("HARD");
        /// <summary>
        /// Constant SOFT for ComponentDependencyType
        /// </summary>
        public static readonly ComponentDependencyType SOFT = new ComponentDependencyType("SOFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentDependencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentDependencyType FindValue(string value)
        {
            return FindValue<ComponentDependencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentDependencyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentVisibilityScope.
    /// </summary>
    public class ComponentVisibilityScope : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for ComponentVisibilityScope
        /// </summary>
        public static readonly ComponentVisibilityScope PRIVATE = new ComponentVisibilityScope("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for ComponentVisibilityScope
        /// </summary>
        public static readonly ComponentVisibilityScope PUBLIC = new ComponentVisibilityScope("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentVisibilityScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentVisibilityScope FindValue(string value)
        {
            return FindValue<ComponentVisibilityScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentVisibilityScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoreDeviceStatus.
    /// </summary>
    public class CoreDeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for CoreDeviceStatus
        /// </summary>
        public static readonly CoreDeviceStatus HEALTHY = new CoreDeviceStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for CoreDeviceStatus
        /// </summary>
        public static readonly CoreDeviceStatus UNHEALTHY = new CoreDeviceStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoreDeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoreDeviceStatus FindValue(string value)
        {
            return FindValue<CoreDeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoreDeviceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentComponentUpdatePolicyAction.
    /// </summary>
    public class DeploymentComponentUpdatePolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant NOTIFY_COMPONENTS for DeploymentComponentUpdatePolicyAction
        /// </summary>
        public static readonly DeploymentComponentUpdatePolicyAction NOTIFY_COMPONENTS = new DeploymentComponentUpdatePolicyAction("NOTIFY_COMPONENTS");
        /// <summary>
        /// Constant SKIP_NOTIFY_COMPONENTS for DeploymentComponentUpdatePolicyAction
        /// </summary>
        public static readonly DeploymentComponentUpdatePolicyAction SKIP_NOTIFY_COMPONENTS = new DeploymentComponentUpdatePolicyAction("SKIP_NOTIFY_COMPONENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentComponentUpdatePolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentComponentUpdatePolicyAction FindValue(string value)
        {
            return FindValue<DeploymentComponentUpdatePolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentComponentUpdatePolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentFailureHandlingPolicy.
    /// </summary>
    public class DeploymentFailureHandlingPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOTHING for DeploymentFailureHandlingPolicy
        /// </summary>
        public static readonly DeploymentFailureHandlingPolicy DO_NOTHING = new DeploymentFailureHandlingPolicy("DO_NOTHING");
        /// <summary>
        /// Constant ROLLBACK for DeploymentFailureHandlingPolicy
        /// </summary>
        public static readonly DeploymentFailureHandlingPolicy ROLLBACK = new DeploymentFailureHandlingPolicy("ROLLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentFailureHandlingPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentFailureHandlingPolicy FindValue(string value)
        {
            return FindValue<DeploymentFailureHandlingPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentFailureHandlingPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentHistoryFilter.
    /// </summary>
    public class DeploymentHistoryFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for DeploymentHistoryFilter
        /// </summary>
        public static readonly DeploymentHistoryFilter ALL = new DeploymentHistoryFilter("ALL");
        /// <summary>
        /// Constant LATEST_ONLY for DeploymentHistoryFilter
        /// </summary>
        public static readonly DeploymentHistoryFilter LATEST_ONLY = new DeploymentHistoryFilter("LATEST_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentHistoryFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentHistoryFilter FindValue(string value)
        {
            return FindValue<DeploymentHistoryFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentHistoryFilter(string value)
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
        /// Constant ACTIVE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus ACTIVE = new DeploymentStatus("ACTIVE");
        /// <summary>
        /// Constant CANCELED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus CANCELED = new DeploymentStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus COMPLETED = new DeploymentStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAILED = new DeploymentStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus INACTIVE = new DeploymentStatus("INACTIVE");

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
    /// Constants used for properties of type EffectiveDeploymentExecutionStatus.
    /// </summary>
    public class EffectiveDeploymentExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus CANCELED = new EffectiveDeploymentExecutionStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus COMPLETED = new EffectiveDeploymentExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus FAILED = new EffectiveDeploymentExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus IN_PROGRESS = new EffectiveDeploymentExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus QUEUED = new EffectiveDeploymentExecutionStatus("QUEUED");
        /// <summary>
        /// Constant REJECTED for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus REJECTED = new EffectiveDeploymentExecutionStatus("REJECTED");
        /// <summary>
        /// Constant SUCCEEDED for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus SUCCEEDED = new EffectiveDeploymentExecutionStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for EffectiveDeploymentExecutionStatus
        /// </summary>
        public static readonly EffectiveDeploymentExecutionStatus TIMED_OUT = new EffectiveDeploymentExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EffectiveDeploymentExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EffectiveDeploymentExecutionStatus FindValue(string value)
        {
            return FindValue<EffectiveDeploymentExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EffectiveDeploymentExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstalledComponentLifecycleState.
    /// </summary>
    public class InstalledComponentLifecycleState : ConstantClass
    {

        /// <summary>
        /// Constant BROKEN for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState BROKEN = new InstalledComponentLifecycleState("BROKEN");
        /// <summary>
        /// Constant ERRORED for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState ERRORED = new InstalledComponentLifecycleState("ERRORED");
        /// <summary>
        /// Constant FINISHED for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState FINISHED = new InstalledComponentLifecycleState("FINISHED");
        /// <summary>
        /// Constant INSTALLED for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState INSTALLED = new InstalledComponentLifecycleState("INSTALLED");
        /// <summary>
        /// Constant NEW for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState NEW = new InstalledComponentLifecycleState("NEW");
        /// <summary>
        /// Constant RUNNING for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState RUNNING = new InstalledComponentLifecycleState("RUNNING");
        /// <summary>
        /// Constant STARTING for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState STARTING = new InstalledComponentLifecycleState("STARTING");
        /// <summary>
        /// Constant STOPPING for InstalledComponentLifecycleState
        /// </summary>
        public static readonly InstalledComponentLifecycleState STOPPING = new InstalledComponentLifecycleState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstalledComponentLifecycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstalledComponentLifecycleState FindValue(string value)
        {
            return FindValue<InstalledComponentLifecycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstalledComponentLifecycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstalledComponentTopologyFilter.
    /// </summary>
    public class InstalledComponentTopologyFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for InstalledComponentTopologyFilter
        /// </summary>
        public static readonly InstalledComponentTopologyFilter ALL = new InstalledComponentTopologyFilter("ALL");
        /// <summary>
        /// Constant ROOT for InstalledComponentTopologyFilter
        /// </summary>
        public static readonly InstalledComponentTopologyFilter ROOT = new InstalledComponentTopologyFilter("ROOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstalledComponentTopologyFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstalledComponentTopologyFilter FindValue(string value)
        {
            return FindValue<InstalledComponentTopologyFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstalledComponentTopologyFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IoTJobAbortAction.
    /// </summary>
    public class IoTJobAbortAction : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for IoTJobAbortAction
        /// </summary>
        public static readonly IoTJobAbortAction CANCEL = new IoTJobAbortAction("CANCEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IoTJobAbortAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IoTJobAbortAction FindValue(string value)
        {
            return FindValue<IoTJobAbortAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IoTJobAbortAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IoTJobExecutionFailureType.
    /// </summary>
    public class IoTJobExecutionFailureType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for IoTJobExecutionFailureType
        /// </summary>
        public static readonly IoTJobExecutionFailureType ALL = new IoTJobExecutionFailureType("ALL");
        /// <summary>
        /// Constant FAILED for IoTJobExecutionFailureType
        /// </summary>
        public static readonly IoTJobExecutionFailureType FAILED = new IoTJobExecutionFailureType("FAILED");
        /// <summary>
        /// Constant REJECTED for IoTJobExecutionFailureType
        /// </summary>
        public static readonly IoTJobExecutionFailureType REJECTED = new IoTJobExecutionFailureType("REJECTED");
        /// <summary>
        /// Constant TIMED_OUT for IoTJobExecutionFailureType
        /// </summary>
        public static readonly IoTJobExecutionFailureType TIMED_OUT = new IoTJobExecutionFailureType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IoTJobExecutionFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IoTJobExecutionFailureType FindValue(string value)
        {
            return FindValue<IoTJobExecutionFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IoTJobExecutionFailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaEventSourceType.
    /// </summary>
    public class LambdaEventSourceType : ConstantClass
    {

        /// <summary>
        /// Constant IOT_CORE for LambdaEventSourceType
        /// </summary>
        public static readonly LambdaEventSourceType IOT_CORE = new LambdaEventSourceType("IOT_CORE");
        /// <summary>
        /// Constant PUB_SUB for LambdaEventSourceType
        /// </summary>
        public static readonly LambdaEventSourceType PUB_SUB = new LambdaEventSourceType("PUB_SUB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaEventSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaEventSourceType FindValue(string value)
        {
            return FindValue<LambdaEventSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaEventSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFilesystemPermission.
    /// </summary>
    public class LambdaFilesystemPermission : ConstantClass
    {

        /// <summary>
        /// Constant Ro for LambdaFilesystemPermission
        /// </summary>
        public static readonly LambdaFilesystemPermission Ro = new LambdaFilesystemPermission("ro");
        /// <summary>
        /// Constant Rw for LambdaFilesystemPermission
        /// </summary>
        public static readonly LambdaFilesystemPermission Rw = new LambdaFilesystemPermission("rw");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFilesystemPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFilesystemPermission FindValue(string value)
        {
            return FindValue<LambdaFilesystemPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFilesystemPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaInputPayloadEncodingType.
    /// </summary>
    public class LambdaInputPayloadEncodingType : ConstantClass
    {

        /// <summary>
        /// Constant Binary for LambdaInputPayloadEncodingType
        /// </summary>
        public static readonly LambdaInputPayloadEncodingType Binary = new LambdaInputPayloadEncodingType("binary");
        /// <summary>
        /// Constant Json for LambdaInputPayloadEncodingType
        /// </summary>
        public static readonly LambdaInputPayloadEncodingType Json = new LambdaInputPayloadEncodingType("json");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaInputPayloadEncodingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaInputPayloadEncodingType FindValue(string value)
        {
            return FindValue<LambdaInputPayloadEncodingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaInputPayloadEncodingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaIsolationMode.
    /// </summary>
    public class LambdaIsolationMode : ConstantClass
    {

        /// <summary>
        /// Constant GreengrassContainer for LambdaIsolationMode
        /// </summary>
        public static readonly LambdaIsolationMode GreengrassContainer = new LambdaIsolationMode("GreengrassContainer");
        /// <summary>
        /// Constant NoContainer for LambdaIsolationMode
        /// </summary>
        public static readonly LambdaIsolationMode NoContainer = new LambdaIsolationMode("NoContainer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaIsolationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaIsolationMode FindValue(string value)
        {
            return FindValue<LambdaIsolationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaIsolationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecipeOutputFormat.
    /// </summary>
    public class RecipeOutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for RecipeOutputFormat
        /// </summary>
        public static readonly RecipeOutputFormat JSON = new RecipeOutputFormat("JSON");
        /// <summary>
        /// Constant YAML for RecipeOutputFormat
        /// </summary>
        public static readonly RecipeOutputFormat YAML = new RecipeOutputFormat("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecipeOutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecipeOutputFormat FindValue(string value)
        {
            return FindValue<RecipeOutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecipeOutputFormat(string value)
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
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
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
    /// Constants used for properties of type VendorGuidance.
    /// </summary>
    public class VendorGuidance : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance ACTIVE = new VendorGuidance("ACTIVE");
        /// <summary>
        /// Constant DELETED for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance DELETED = new VendorGuidance("DELETED");
        /// <summary>
        /// Constant DISCONTINUED for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance DISCONTINUED = new VendorGuidance("DISCONTINUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VendorGuidance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VendorGuidance FindValue(string value)
        {
            return FindValue<VendorGuidance>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VendorGuidance(string value)
        {
            return FindValue(value);
        }
    }

}