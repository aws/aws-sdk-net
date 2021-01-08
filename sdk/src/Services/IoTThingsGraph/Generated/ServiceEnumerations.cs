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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTThingsGraph
{

    /// <summary>
    /// Constants used for properties of type DefinitionLanguage.
    /// </summary>
    public class DefinitionLanguage : ConstantClass
    {

        /// <summary>
        /// Constant GRAPHQL for DefinitionLanguage
        /// </summary>
        public static readonly DefinitionLanguage GRAPHQL = new DefinitionLanguage("GRAPHQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefinitionLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefinitionLanguage FindValue(string value)
        {
            return FindValue<DefinitionLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefinitionLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentTarget.
    /// </summary>
    public class DeploymentTarget : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD for DeploymentTarget
        /// </summary>
        public static readonly DeploymentTarget CLOUD = new DeploymentTarget("CLOUD");
        /// <summary>
        /// Constant GREENGRASS for DeploymentTarget
        /// </summary>
        public static readonly DeploymentTarget GREENGRASS = new DeploymentTarget("GREENGRASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentTarget(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentTarget FindValue(string value)
        {
            return FindValue<DeploymentTarget>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentTarget(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityFilterName.
    /// </summary>
    public class EntityFilterName : ConstantClass
    {

        /// <summary>
        /// Constant NAME for EntityFilterName
        /// </summary>
        public static readonly EntityFilterName NAME = new EntityFilterName("NAME");
        /// <summary>
        /// Constant NAMESPACE for EntityFilterName
        /// </summary>
        public static readonly EntityFilterName NAMESPACE = new EntityFilterName("NAMESPACE");
        /// <summary>
        /// Constant REFERENCED_ENTITY_ID for EntityFilterName
        /// </summary>
        public static readonly EntityFilterName REFERENCED_ENTITY_ID = new EntityFilterName("REFERENCED_ENTITY_ID");
        /// <summary>
        /// Constant SEMANTIC_TYPE_PATH for EntityFilterName
        /// </summary>
        public static readonly EntityFilterName SEMANTIC_TYPE_PATH = new EntityFilterName("SEMANTIC_TYPE_PATH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityFilterName FindValue(string value)
        {
            return FindValue<EntityFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant ACTION for EntityType
        /// </summary>
        public static readonly EntityType ACTION = new EntityType("ACTION");
        /// <summary>
        /// Constant CAPABILITY for EntityType
        /// </summary>
        public static readonly EntityType CAPABILITY = new EntityType("CAPABILITY");
        /// <summary>
        /// Constant DEVICE for EntityType
        /// </summary>
        public static readonly EntityType DEVICE = new EntityType("DEVICE");
        /// <summary>
        /// Constant DEVICE_MODEL for EntityType
        /// </summary>
        public static readonly EntityType DEVICE_MODEL = new EntityType("DEVICE_MODEL");
        /// <summary>
        /// Constant ENUM for EntityType
        /// </summary>
        public static readonly EntityType ENUM = new EntityType("ENUM");
        /// <summary>
        /// Constant EVENT for EntityType
        /// </summary>
        public static readonly EntityType EVENT = new EntityType("EVENT");
        /// <summary>
        /// Constant MAPPING for EntityType
        /// </summary>
        public static readonly EntityType MAPPING = new EntityType("MAPPING");
        /// <summary>
        /// Constant PROPERTY for EntityType
        /// </summary>
        public static readonly EntityType PROPERTY = new EntityType("PROPERTY");
        /// <summary>
        /// Constant SERVICE for EntityType
        /// </summary>
        public static readonly EntityType SERVICE = new EntityType("SERVICE");
        /// <summary>
        /// Constant STATE for EntityType
        /// </summary>
        public static readonly EntityType STATE = new EntityType("STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowExecutionEventType.
    /// </summary>
    public class FlowExecutionEventType : ConstantClass
    {

        /// <summary>
        /// Constant ACKNOWLEDGE_TASK_MESSAGE for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType ACKNOWLEDGE_TASK_MESSAGE = new FlowExecutionEventType("ACKNOWLEDGE_TASK_MESSAGE");
        /// <summary>
        /// Constant ACTIVITY_FAILED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType ACTIVITY_FAILED = new FlowExecutionEventType("ACTIVITY_FAILED");
        /// <summary>
        /// Constant ACTIVITY_SCHEDULED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType ACTIVITY_SCHEDULED = new FlowExecutionEventType("ACTIVITY_SCHEDULED");
        /// <summary>
        /// Constant ACTIVITY_STARTED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType ACTIVITY_STARTED = new FlowExecutionEventType("ACTIVITY_STARTED");
        /// <summary>
        /// Constant ACTIVITY_SUCCEEDED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType ACTIVITY_SUCCEEDED = new FlowExecutionEventType("ACTIVITY_SUCCEEDED");
        /// <summary>
        /// Constant EXECUTION_ABORTED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType EXECUTION_ABORTED = new FlowExecutionEventType("EXECUTION_ABORTED");
        /// <summary>
        /// Constant EXECUTION_FAILED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType EXECUTION_FAILED = new FlowExecutionEventType("EXECUTION_FAILED");
        /// <summary>
        /// Constant EXECUTION_STARTED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType EXECUTION_STARTED = new FlowExecutionEventType("EXECUTION_STARTED");
        /// <summary>
        /// Constant EXECUTION_SUCCEEDED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType EXECUTION_SUCCEEDED = new FlowExecutionEventType("EXECUTION_SUCCEEDED");
        /// <summary>
        /// Constant SCHEDULE_NEXT_READY_STEPS_TASK for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType SCHEDULE_NEXT_READY_STEPS_TASK = new FlowExecutionEventType("SCHEDULE_NEXT_READY_STEPS_TASK");
        /// <summary>
        /// Constant START_FLOW_EXECUTION_TASK for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType START_FLOW_EXECUTION_TASK = new FlowExecutionEventType("START_FLOW_EXECUTION_TASK");
        /// <summary>
        /// Constant STEP_FAILED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType STEP_FAILED = new FlowExecutionEventType("STEP_FAILED");
        /// <summary>
        /// Constant STEP_STARTED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType STEP_STARTED = new FlowExecutionEventType("STEP_STARTED");
        /// <summary>
        /// Constant STEP_SUCCEEDED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType STEP_SUCCEEDED = new FlowExecutionEventType("STEP_SUCCEEDED");
        /// <summary>
        /// Constant THING_ACTION_TASK for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType THING_ACTION_TASK = new FlowExecutionEventType("THING_ACTION_TASK");
        /// <summary>
        /// Constant THING_ACTION_TASK_FAILED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType THING_ACTION_TASK_FAILED = new FlowExecutionEventType("THING_ACTION_TASK_FAILED");
        /// <summary>
        /// Constant THING_ACTION_TASK_SUCCEEDED for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType THING_ACTION_TASK_SUCCEEDED = new FlowExecutionEventType("THING_ACTION_TASK_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowExecutionEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowExecutionEventType FindValue(string value)
        {
            return FindValue<FlowExecutionEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowExecutionEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowExecutionStatus.
    /// </summary>
    public class FlowExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus ABORTED = new FlowExecutionStatus("ABORTED");
        /// <summary>
        /// Constant FAILED for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus FAILED = new FlowExecutionStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus RUNNING = new FlowExecutionStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus SUCCEEDED = new FlowExecutionStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowExecutionStatus FindValue(string value)
        {
            return FindValue<FlowExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowTemplateFilterName.
    /// </summary>
    public class FlowTemplateFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DEVICE_MODEL_ID for FlowTemplateFilterName
        /// </summary>
        public static readonly FlowTemplateFilterName DEVICE_MODEL_ID = new FlowTemplateFilterName("DEVICE_MODEL_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowTemplateFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowTemplateFilterName FindValue(string value)
        {
            return FindValue<FlowTemplateFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowTemplateFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceDeletionStatus.
    /// </summary>
    public class NamespaceDeletionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for NamespaceDeletionStatus
        /// </summary>
        public static readonly NamespaceDeletionStatus FAILED = new NamespaceDeletionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for NamespaceDeletionStatus
        /// </summary>
        public static readonly NamespaceDeletionStatus IN_PROGRESS = new NamespaceDeletionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for NamespaceDeletionStatus
        /// </summary>
        public static readonly NamespaceDeletionStatus SUCCEEDED = new NamespaceDeletionStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceDeletionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceDeletionStatus FindValue(string value)
        {
            return FindValue<NamespaceDeletionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceDeletionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceDeletionStatusErrorCodes.
    /// </summary>
    public class NamespaceDeletionStatusErrorCodes : ConstantClass
    {

        /// <summary>
        /// Constant VALIDATION_FAILED for NamespaceDeletionStatusErrorCodes
        /// </summary>
        public static readonly NamespaceDeletionStatusErrorCodes VALIDATION_FAILED = new NamespaceDeletionStatusErrorCodes("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceDeletionStatusErrorCodes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceDeletionStatusErrorCodes FindValue(string value)
        {
            return FindValue<NamespaceDeletionStatusErrorCodes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceDeletionStatusErrorCodes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SystemInstanceDeploymentStatus.
    /// </summary>
    public class SystemInstanceDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant BOOTSTRAP for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus BOOTSTRAP = new SystemInstanceDeploymentStatus("BOOTSTRAP");
        /// <summary>
        /// Constant DELETED_IN_TARGET for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus DELETED_IN_TARGET = new SystemInstanceDeploymentStatus("DELETED_IN_TARGET");
        /// <summary>
        /// Constant DEPLOY_IN_PROGRESS for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus DEPLOY_IN_PROGRESS = new SystemInstanceDeploymentStatus("DEPLOY_IN_PROGRESS");
        /// <summary>
        /// Constant DEPLOYED_IN_TARGET for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus DEPLOYED_IN_TARGET = new SystemInstanceDeploymentStatus("DEPLOYED_IN_TARGET");
        /// <summary>
        /// Constant FAILED for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus FAILED = new SystemInstanceDeploymentStatus("FAILED");
        /// <summary>
        /// Constant NOT_DEPLOYED for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus NOT_DEPLOYED = new SystemInstanceDeploymentStatus("NOT_DEPLOYED");
        /// <summary>
        /// Constant PENDING_DELETE for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus PENDING_DELETE = new SystemInstanceDeploymentStatus("PENDING_DELETE");
        /// <summary>
        /// Constant UNDEPLOY_IN_PROGRESS for SystemInstanceDeploymentStatus
        /// </summary>
        public static readonly SystemInstanceDeploymentStatus UNDEPLOY_IN_PROGRESS = new SystemInstanceDeploymentStatus("UNDEPLOY_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SystemInstanceDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemInstanceDeploymentStatus FindValue(string value)
        {
            return FindValue<SystemInstanceDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemInstanceDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SystemInstanceFilterName.
    /// </summary>
    public class SystemInstanceFilterName : ConstantClass
    {

        /// <summary>
        /// Constant GREENGRASS_GROUP_NAME for SystemInstanceFilterName
        /// </summary>
        public static readonly SystemInstanceFilterName GREENGRASS_GROUP_NAME = new SystemInstanceFilterName("GREENGRASS_GROUP_NAME");
        /// <summary>
        /// Constant STATUS for SystemInstanceFilterName
        /// </summary>
        public static readonly SystemInstanceFilterName STATUS = new SystemInstanceFilterName("STATUS");
        /// <summary>
        /// Constant SYSTEM_TEMPLATE_ID for SystemInstanceFilterName
        /// </summary>
        public static readonly SystemInstanceFilterName SYSTEM_TEMPLATE_ID = new SystemInstanceFilterName("SYSTEM_TEMPLATE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SystemInstanceFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemInstanceFilterName FindValue(string value)
        {
            return FindValue<SystemInstanceFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemInstanceFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SystemTemplateFilterName.
    /// </summary>
    public class SystemTemplateFilterName : ConstantClass
    {

        /// <summary>
        /// Constant FLOW_TEMPLATE_ID for SystemTemplateFilterName
        /// </summary>
        public static readonly SystemTemplateFilterName FLOW_TEMPLATE_ID = new SystemTemplateFilterName("FLOW_TEMPLATE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SystemTemplateFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemTemplateFilterName FindValue(string value)
        {
            return FindValue<SystemTemplateFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemTemplateFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadStatus.
    /// </summary>
    public class UploadStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for UploadStatus
        /// </summary>
        public static readonly UploadStatus FAILED = new UploadStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for UploadStatus
        /// </summary>
        public static readonly UploadStatus IN_PROGRESS = new UploadStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for UploadStatus
        /// </summary>
        public static readonly UploadStatus SUCCEEDED = new UploadStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadStatus FindValue(string value)
        {
            return FindValue<UploadStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadStatus(string value)
        {
            return FindValue(value);
        }
    }

}