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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MigrationHubOrchestrator
{

    /// <summary>
    /// Constants used for properties of type DataType.
    /// </summary>
    public class DataType : ConstantClass
    {

        /// <summary>
        /// Constant INTEGER for DataType
        /// </summary>
        public static readonly DataType INTEGER = new DataType("INTEGER");
        /// <summary>
        /// Constant STRING for DataType
        /// </summary>
        public static readonly DataType STRING = new DataType("STRING");
        /// <summary>
        /// Constant STRINGLIST for DataType
        /// </summary>
        public static readonly DataType STRINGLIST = new DataType("STRINGLIST");
        /// <summary>
        /// Constant STRINGMAP for DataType
        /// </summary>
        public static readonly DataType STRINGMAP = new DataType("STRINGMAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataType FindValue(string value)
        {
            return FindValue<DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationWorkflowStatusEnum.
    /// </summary>
    public class MigrationWorkflowStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum COMPLETED = new MigrationWorkflowStatusEnum("COMPLETED");
        /// <summary>
        /// Constant CREATING for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum CREATING = new MigrationWorkflowStatusEnum("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum CREATION_FAILED = new MigrationWorkflowStatusEnum("CREATION_FAILED");
        /// <summary>
        /// Constant DELETED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum DELETED = new MigrationWorkflowStatusEnum("DELETED");
        /// <summary>
        /// Constant DELETING for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum DELETING = new MigrationWorkflowStatusEnum("DELETING");
        /// <summary>
        /// Constant DELETION_FAILED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum DELETION_FAILED = new MigrationWorkflowStatusEnum("DELETION_FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum IN_PROGRESS = new MigrationWorkflowStatusEnum("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum NOT_STARTED = new MigrationWorkflowStatusEnum("NOT_STARTED");
        /// <summary>
        /// Constant PAUSED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum PAUSED = new MigrationWorkflowStatusEnum("PAUSED");
        /// <summary>
        /// Constant PAUSING for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum PAUSING = new MigrationWorkflowStatusEnum("PAUSING");
        /// <summary>
        /// Constant PAUSING_FAILED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum PAUSING_FAILED = new MigrationWorkflowStatusEnum("PAUSING_FAILED");
        /// <summary>
        /// Constant STARTING for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum STARTING = new MigrationWorkflowStatusEnum("STARTING");
        /// <summary>
        /// Constant USER_ATTENTION_REQUIRED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum USER_ATTENTION_REQUIRED = new MigrationWorkflowStatusEnum("USER_ATTENTION_REQUIRED");
        /// <summary>
        /// Constant WORKFLOW_FAILED for MigrationWorkflowStatusEnum
        /// </summary>
        public static readonly MigrationWorkflowStatusEnum WORKFLOW_FAILED = new MigrationWorkflowStatusEnum("WORKFLOW_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationWorkflowStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationWorkflowStatusEnum FindValue(string value)
        {
            return FindValue<MigrationWorkflowStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationWorkflowStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Owner.
    /// </summary>
    public class Owner : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for Owner
        /// </summary>
        public static readonly Owner AWS_MANAGED = new Owner("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOM for Owner
        /// </summary>
        public static readonly Owner CUSTOM = new Owner("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Owner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Owner FindValue(string value)
        {
            return FindValue<Owner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Owner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PluginHealth.
    /// </summary>
    public class PluginHealth : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for PluginHealth
        /// </summary>
        public static readonly PluginHealth HEALTHY = new PluginHealth("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for PluginHealth
        /// </summary>
        public static readonly PluginHealth UNHEALTHY = new PluginHealth("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PluginHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PluginHealth FindValue(string value)
        {
            return FindValue<PluginHealth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PluginHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunEnvironment.
    /// </summary>
    public class RunEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant AWS for RunEnvironment
        /// </summary>
        public static readonly RunEnvironment AWS = new RunEnvironment("AWS");
        /// <summary>
        /// Constant ONPREMISE for RunEnvironment
        /// </summary>
        public static readonly RunEnvironment ONPREMISE = new RunEnvironment("ONPREMISE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunEnvironment FindValue(string value)
        {
            return FindValue<RunEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunEnvironment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepActionType.
    /// </summary>
    public class StepActionType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATED for StepActionType
        /// </summary>
        public static readonly StepActionType AUTOMATED = new StepActionType("AUTOMATED");
        /// <summary>
        /// Constant MANUAL for StepActionType
        /// </summary>
        public static readonly StepActionType MANUAL = new StepActionType("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepActionType FindValue(string value)
        {
            return FindValue<StepActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepGroupStatus.
    /// </summary>
    public class StepGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant AWAITING_DEPENDENCIES for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus AWAITING_DEPENDENCIES = new StepGroupStatus("AWAITING_DEPENDENCIES");
        /// <summary>
        /// Constant COMPLETED for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus COMPLETED = new StepGroupStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus FAILED = new StepGroupStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus IN_PROGRESS = new StepGroupStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PAUSED for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus PAUSED = new StepGroupStatus("PAUSED");
        /// <summary>
        /// Constant PAUSING for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus PAUSING = new StepGroupStatus("PAUSING");
        /// <summary>
        /// Constant READY for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus READY = new StepGroupStatus("READY");
        /// <summary>
        /// Constant USER_ATTENTION_REQUIRED for StepGroupStatus
        /// </summary>
        public static readonly StepGroupStatus USER_ATTENTION_REQUIRED = new StepGroupStatus("USER_ATTENTION_REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepGroupStatus FindValue(string value)
        {
            return FindValue<StepGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepStatus.
    /// </summary>
    public class StepStatus : ConstantClass
    {

        /// <summary>
        /// Constant AWAITING_DEPENDENCIES for StepStatus
        /// </summary>
        public static readonly StepStatus AWAITING_DEPENDENCIES = new StepStatus("AWAITING_DEPENDENCIES");
        /// <summary>
        /// Constant COMPLETED for StepStatus
        /// </summary>
        public static readonly StepStatus COMPLETED = new StepStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for StepStatus
        /// </summary>
        public static readonly StepStatus FAILED = new StepStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for StepStatus
        /// </summary>
        public static readonly StepStatus IN_PROGRESS = new StepStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PAUSED for StepStatus
        /// </summary>
        public static readonly StepStatus PAUSED = new StepStatus("PAUSED");
        /// <summary>
        /// Constant READY for StepStatus
        /// </summary>
        public static readonly StepStatus READY = new StepStatus("READY");
        /// <summary>
        /// Constant SKIPPED for StepStatus
        /// </summary>
        public static readonly StepStatus SKIPPED = new StepStatus("SKIPPED");
        /// <summary>
        /// Constant USER_ATTENTION_REQUIRED for StepStatus
        /// </summary>
        public static readonly StepStatus USER_ATTENTION_REQUIRED = new StepStatus("USER_ATTENTION_REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepStatus FindValue(string value)
        {
            return FindValue<StepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for TargetType
        /// </summary>
        public static readonly TargetType ALL = new TargetType("ALL");
        /// <summary>
        /// Constant NONE for TargetType
        /// </summary>
        public static readonly TargetType NONE = new TargetType("NONE");
        /// <summary>
        /// Constant SINGLE for TargetType
        /// </summary>
        public static readonly TargetType SINGLE = new TargetType("SINGLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateStatus.
    /// </summary>
    public class TemplateStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus CREATED = new TemplateStatus("CREATED");
        /// <summary>
        /// Constant CREATING for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus CREATING = new TemplateStatus("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus CREATION_FAILED = new TemplateStatus("CREATION_FAILED");
        /// <summary>
        /// Constant PENDING_CREATION for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus PENDING_CREATION = new TemplateStatus("PENDING_CREATION");
        /// <summary>
        /// Constant READY for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus READY = new TemplateStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateStatus FindValue(string value)
        {
            return FindValue<TemplateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateStatus(string value)
        {
            return FindValue(value);
        }
    }

}