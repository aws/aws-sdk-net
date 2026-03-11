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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Batch
{

    /// <summary>
    /// Constants used for properties of type ArrayJobDependency.
    /// </summary>
    public class ArrayJobDependency : ConstantClass
    {

        /// <summary>
        /// Constant N_TO_N for ArrayJobDependency
        /// </summary>
        public static readonly ArrayJobDependency N_TO_N = new ArrayJobDependency("N_TO_N");
        /// <summary>
        /// Constant SEQUENTIAL for ArrayJobDependency
        /// </summary>
        public static readonly ArrayJobDependency SEQUENTIAL = new ArrayJobDependency("SEQUENTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArrayJobDependency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArrayJobDependency FindValue(string value)
        {
            return FindValue<ArrayJobDependency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArrayJobDependency(string value)
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
    /// Constants used for properties of type CEState.
    /// </summary>
    public class CEState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CEState
        /// </summary>
        public static readonly CEState DISABLED = new CEState("DISABLED");
        /// <summary>
        /// Constant ENABLED for CEState
        /// </summary>
        public static readonly CEState ENABLED = new CEState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CEState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CEState FindValue(string value)
        {
            return FindValue<CEState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CEState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CEStatus.
    /// </summary>
    public class CEStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for CEStatus
        /// </summary>
        public static readonly CEStatus CREATING = new CEStatus("CREATING");
        /// <summary>
        /// Constant DELETED for CEStatus
        /// </summary>
        public static readonly CEStatus DELETED = new CEStatus("DELETED");
        /// <summary>
        /// Constant DELETING for CEStatus
        /// </summary>
        public static readonly CEStatus DELETING = new CEStatus("DELETING");
        /// <summary>
        /// Constant INVALID for CEStatus
        /// </summary>
        public static readonly CEStatus INVALID = new CEStatus("INVALID");
        /// <summary>
        /// Constant UPDATING for CEStatus
        /// </summary>
        public static readonly CEStatus UPDATING = new CEStatus("UPDATING");
        /// <summary>
        /// Constant VALID for CEStatus
        /// </summary>
        public static readonly CEStatus VALID = new CEStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CEStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CEStatus FindValue(string value)
        {
            return FindValue<CEStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CEStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CEType.
    /// </summary>
    public class CEType : ConstantClass
    {

        /// <summary>
        /// Constant MANAGED for CEType
        /// </summary>
        public static readonly CEType MANAGED = new CEType("MANAGED");
        /// <summary>
        /// Constant UNMANAGED for CEType
        /// </summary>
        public static readonly CEType UNMANAGED = new CEType("UNMANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CEType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CEType FindValue(string value)
        {
            return FindValue<CEType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CEType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CRAllocationStrategy.
    /// </summary>
    public class CRAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant BEST_FIT for CRAllocationStrategy
        /// </summary>
        public static readonly CRAllocationStrategy BEST_FIT = new CRAllocationStrategy("BEST_FIT");
        /// <summary>
        /// Constant BEST_FIT_PROGRESSIVE for CRAllocationStrategy
        /// </summary>
        public static readonly CRAllocationStrategy BEST_FIT_PROGRESSIVE = new CRAllocationStrategy("BEST_FIT_PROGRESSIVE");
        /// <summary>
        /// Constant SPOT_CAPACITY_OPTIMIZED for CRAllocationStrategy
        /// </summary>
        public static readonly CRAllocationStrategy SPOT_CAPACITY_OPTIMIZED = new CRAllocationStrategy("SPOT_CAPACITY_OPTIMIZED");
        /// <summary>
        /// Constant SPOT_PRICE_CAPACITY_OPTIMIZED for CRAllocationStrategy
        /// </summary>
        public static readonly CRAllocationStrategy SPOT_PRICE_CAPACITY_OPTIMIZED = new CRAllocationStrategy("SPOT_PRICE_CAPACITY_OPTIMIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CRAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CRAllocationStrategy FindValue(string value)
        {
            return FindValue<CRAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CRAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CRType.
    /// </summary>
    public class CRType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for CRType
        /// </summary>
        public static readonly CRType EC2 = new CRType("EC2");
        /// <summary>
        /// Constant FARGATE for CRType
        /// </summary>
        public static readonly CRType FARGATE = new CRType("FARGATE");
        /// <summary>
        /// Constant FARGATE_SPOT for CRType
        /// </summary>
        public static readonly CRType FARGATE_SPOT = new CRType("FARGATE_SPOT");
        /// <summary>
        /// Constant SPOT for CRType
        /// </summary>
        public static readonly CRType SPOT = new CRType("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CRType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CRType FindValue(string value)
        {
            return FindValue<CRType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CRType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CRUpdateAllocationStrategy.
    /// </summary>
    public class CRUpdateAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant BEST_FIT_PROGRESSIVE for CRUpdateAllocationStrategy
        /// </summary>
        public static readonly CRUpdateAllocationStrategy BEST_FIT_PROGRESSIVE = new CRUpdateAllocationStrategy("BEST_FIT_PROGRESSIVE");
        /// <summary>
        /// Constant SPOT_CAPACITY_OPTIMIZED for CRUpdateAllocationStrategy
        /// </summary>
        public static readonly CRUpdateAllocationStrategy SPOT_CAPACITY_OPTIMIZED = new CRUpdateAllocationStrategy("SPOT_CAPACITY_OPTIMIZED");
        /// <summary>
        /// Constant SPOT_PRICE_CAPACITY_OPTIMIZED for CRUpdateAllocationStrategy
        /// </summary>
        public static readonly CRUpdateAllocationStrategy SPOT_PRICE_CAPACITY_OPTIMIZED = new CRUpdateAllocationStrategy("SPOT_PRICE_CAPACITY_OPTIMIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CRUpdateAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CRUpdateAllocationStrategy FindValue(string value)
        {
            return FindValue<CRUpdateAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CRUpdateAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceCgroupPermission.
    /// </summary>
    public class DeviceCgroupPermission : ConstantClass
    {

        /// <summary>
        /// Constant MKNOD for DeviceCgroupPermission
        /// </summary>
        public static readonly DeviceCgroupPermission MKNOD = new DeviceCgroupPermission("MKNOD");
        /// <summary>
        /// Constant READ for DeviceCgroupPermission
        /// </summary>
        public static readonly DeviceCgroupPermission READ = new DeviceCgroupPermission("READ");
        /// <summary>
        /// Constant WRITE for DeviceCgroupPermission
        /// </summary>
        public static readonly DeviceCgroupPermission WRITE = new DeviceCgroupPermission("WRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceCgroupPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceCgroupPermission FindValue(string value)
        {
            return FindValue<DeviceCgroupPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceCgroupPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EFSAuthorizationConfigIAM.
    /// </summary>
    public class EFSAuthorizationConfigIAM : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EFSAuthorizationConfigIAM
        /// </summary>
        public static readonly EFSAuthorizationConfigIAM DISABLED = new EFSAuthorizationConfigIAM("DISABLED");
        /// <summary>
        /// Constant ENABLED for EFSAuthorizationConfigIAM
        /// </summary>
        public static readonly EFSAuthorizationConfigIAM ENABLED = new EFSAuthorizationConfigIAM("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EFSAuthorizationConfigIAM(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EFSAuthorizationConfigIAM FindValue(string value)
        {
            return FindValue<EFSAuthorizationConfigIAM>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EFSAuthorizationConfigIAM(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EFSTransitEncryption.
    /// </summary>
    public class EFSTransitEncryption : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EFSTransitEncryption
        /// </summary>
        public static readonly EFSTransitEncryption DISABLED = new EFSTransitEncryption("DISABLED");
        /// <summary>
        /// Constant ENABLED for EFSTransitEncryption
        /// </summary>
        public static readonly EFSTransitEncryption ENABLED = new EFSTransitEncryption("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EFSTransitEncryption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EFSTransitEncryption FindValue(string value)
        {
            return FindValue<EFSTransitEncryption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EFSTransitEncryption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FirelensConfigurationType.
    /// </summary>
    public class FirelensConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant Fluentbit for FirelensConfigurationType
        /// </summary>
        public static readonly FirelensConfigurationType Fluentbit = new FirelensConfigurationType("fluentbit");
        /// <summary>
        /// Constant Fluentd for FirelensConfigurationType
        /// </summary>
        public static readonly FirelensConfigurationType Fluentd = new FirelensConfigurationType("fluentd");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirelensConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirelensConfigurationType FindValue(string value)
        {
            return FindValue<FirelensConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirelensConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobDefinitionType.
    /// </summary>
    public class JobDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant Container for JobDefinitionType
        /// </summary>
        public static readonly JobDefinitionType Container = new JobDefinitionType("container");
        /// <summary>
        /// Constant Multinode for JobDefinitionType
        /// </summary>
        public static readonly JobDefinitionType Multinode = new JobDefinitionType("multinode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobDefinitionType FindValue(string value)
        {
            return FindValue<JobDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobQueueType.
    /// </summary>
    public class JobQueueType : ConstantClass
    {

        /// <summary>
        /// Constant ECS for JobQueueType
        /// </summary>
        public static readonly JobQueueType ECS = new JobQueueType("ECS");
        /// <summary>
        /// Constant ECS_FARGATE for JobQueueType
        /// </summary>
        public static readonly JobQueueType ECS_FARGATE = new JobQueueType("ECS_FARGATE");
        /// <summary>
        /// Constant EKS for JobQueueType
        /// </summary>
        public static readonly JobQueueType EKS = new JobQueueType("EKS");
        /// <summary>
        /// Constant SAGEMAKER_TRAINING for JobQueueType
        /// </summary>
        public static readonly JobQueueType SAGEMAKER_TRAINING = new JobQueueType("SAGEMAKER_TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobQueueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobQueueType FindValue(string value)
        {
            return FindValue<JobQueueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobQueueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStateTimeLimitActionsAction.
    /// </summary>
    public class JobStateTimeLimitActionsAction : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for JobStateTimeLimitActionsAction
        /// </summary>
        public static readonly JobStateTimeLimitActionsAction CANCEL = new JobStateTimeLimitActionsAction("CANCEL");
        /// <summary>
        /// Constant TERMINATE for JobStateTimeLimitActionsAction
        /// </summary>
        public static readonly JobStateTimeLimitActionsAction TERMINATE = new JobStateTimeLimitActionsAction("TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStateTimeLimitActionsAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStateTimeLimitActionsAction FindValue(string value)
        {
            return FindValue<JobStateTimeLimitActionsAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStateTimeLimitActionsAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStateTimeLimitActionsState.
    /// </summary>
    public class JobStateTimeLimitActionsState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNABLE for JobStateTimeLimitActionsState
        /// </summary>
        public static readonly JobStateTimeLimitActionsState RUNNABLE = new JobStateTimeLimitActionsState("RUNNABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStateTimeLimitActionsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStateTimeLimitActionsState FindValue(string value)
        {
            return FindValue<JobStateTimeLimitActionsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStateTimeLimitActionsState(string value)
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
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for JobStatus
        /// </summary>
        public static readonly JobStatus PENDING = new JobStatus("PENDING");
        /// <summary>
        /// Constant RUNNABLE for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNABLE = new JobStatus("RUNNABLE");
        /// <summary>
        /// Constant RUNNING for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNING = new JobStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for JobStatus
        /// </summary>
        public static readonly JobStatus STARTING = new JobStatus("STARTING");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCEEDED for JobStatus
        /// </summary>
        public static readonly JobStatus SUCCEEDED = new JobStatus("SUCCEEDED");

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
    /// Constants used for properties of type JQState.
    /// </summary>
    public class JQState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for JQState
        /// </summary>
        public static readonly JQState DISABLED = new JQState("DISABLED");
        /// <summary>
        /// Constant ENABLED for JQState
        /// </summary>
        public static readonly JQState ENABLED = new JQState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JQState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JQState FindValue(string value)
        {
            return FindValue<JQState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JQState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JQStatus.
    /// </summary>
    public class JQStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for JQStatus
        /// </summary>
        public static readonly JQStatus CREATING = new JQStatus("CREATING");
        /// <summary>
        /// Constant DELETED for JQStatus
        /// </summary>
        public static readonly JQStatus DELETED = new JQStatus("DELETED");
        /// <summary>
        /// Constant DELETING for JQStatus
        /// </summary>
        public static readonly JQStatus DELETING = new JQStatus("DELETING");
        /// <summary>
        /// Constant INVALID for JQStatus
        /// </summary>
        public static readonly JQStatus INVALID = new JQStatus("INVALID");
        /// <summary>
        /// Constant UPDATING for JQStatus
        /// </summary>
        public static readonly JQStatus UPDATING = new JQStatus("UPDATING");
        /// <summary>
        /// Constant VALID for JQStatus
        /// </summary>
        public static readonly JQStatus VALID = new JQStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JQStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JQStatus FindValue(string value)
        {
            return FindValue<JQStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JQStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDriver.
    /// </summary>
    public class LogDriver : ConstantClass
    {

        /// <summary>
        /// Constant Awsfirelens for LogDriver
        /// </summary>
        public static readonly LogDriver Awsfirelens = new LogDriver("awsfirelens");
        /// <summary>
        /// Constant Awslogs for LogDriver
        /// </summary>
        public static readonly LogDriver Awslogs = new LogDriver("awslogs");
        /// <summary>
        /// Constant Fluentd for LogDriver
        /// </summary>
        public static readonly LogDriver Fluentd = new LogDriver("fluentd");
        /// <summary>
        /// Constant Gelf for LogDriver
        /// </summary>
        public static readonly LogDriver Gelf = new LogDriver("gelf");
        /// <summary>
        /// Constant Journald for LogDriver
        /// </summary>
        public static readonly LogDriver Journald = new LogDriver("journald");
        /// <summary>
        /// Constant JsonFile for LogDriver
        /// </summary>
        public static readonly LogDriver JsonFile = new LogDriver("json-file");
        /// <summary>
        /// Constant Splunk for LogDriver
        /// </summary>
        public static readonly LogDriver Splunk = new LogDriver("splunk");
        /// <summary>
        /// Constant Syslog for LogDriver
        /// </summary>
        public static readonly LogDriver Syslog = new LogDriver("syslog");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDriver(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDriver FindValue(string value)
        {
            return FindValue<LogDriver>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDriver(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrchestrationType.
    /// </summary>
    public class OrchestrationType : ConstantClass
    {

        /// <summary>
        /// Constant ECS for OrchestrationType
        /// </summary>
        public static readonly OrchestrationType ECS = new OrchestrationType("ECS");
        /// <summary>
        /// Constant EKS for OrchestrationType
        /// </summary>
        public static readonly OrchestrationType EKS = new OrchestrationType("EKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrchestrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrchestrationType FindValue(string value)
        {
            return FindValue<OrchestrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrchestrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformCapability.
    /// </summary>
    public class PlatformCapability : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for PlatformCapability
        /// </summary>
        public static readonly PlatformCapability EC2 = new PlatformCapability("EC2");
        /// <summary>
        /// Constant FARGATE for PlatformCapability
        /// </summary>
        public static readonly PlatformCapability FARGATE = new PlatformCapability("FARGATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformCapability FindValue(string value)
        {
            return FindValue<PlatformCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant GPU for ResourceType
        /// </summary>
        public static readonly ResourceType GPU = new ResourceType("GPU");
        /// <summary>
        /// Constant MEMORY for ResourceType
        /// </summary>
        public static readonly ResourceType MEMORY = new ResourceType("MEMORY");
        /// <summary>
        /// Constant VCPU for ResourceType
        /// </summary>
        public static readonly ResourceType VCPU = new ResourceType("VCPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetryAction.
    /// </summary>
    public class RetryAction : ConstantClass
    {

        /// <summary>
        /// Constant EXIT for RetryAction
        /// </summary>
        public static readonly RetryAction EXIT = new RetryAction("EXIT");
        /// <summary>
        /// Constant RETRY for RetryAction
        /// </summary>
        public static readonly RetryAction RETRY = new RetryAction("RETRY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetryAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetryAction FindValue(string value)
        {
            return FindValue<RetryAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetryAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceEnvironmentState.
    /// </summary>
    public class ServiceEnvironmentState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ServiceEnvironmentState
        /// </summary>
        public static readonly ServiceEnvironmentState DISABLED = new ServiceEnvironmentState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ServiceEnvironmentState
        /// </summary>
        public static readonly ServiceEnvironmentState ENABLED = new ServiceEnvironmentState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceEnvironmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceEnvironmentState FindValue(string value)
        {
            return FindValue<ServiceEnvironmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceEnvironmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceEnvironmentStatus.
    /// </summary>
    public class ServiceEnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for ServiceEnvironmentStatus
        /// </summary>
        public static readonly ServiceEnvironmentStatus CREATING = new ServiceEnvironmentStatus("CREATING");
        /// <summary>
        /// Constant DELETED for ServiceEnvironmentStatus
        /// </summary>
        public static readonly ServiceEnvironmentStatus DELETED = new ServiceEnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ServiceEnvironmentStatus
        /// </summary>
        public static readonly ServiceEnvironmentStatus DELETING = new ServiceEnvironmentStatus("DELETING");
        /// <summary>
        /// Constant INVALID for ServiceEnvironmentStatus
        /// </summary>
        public static readonly ServiceEnvironmentStatus INVALID = new ServiceEnvironmentStatus("INVALID");
        /// <summary>
        /// Constant UPDATING for ServiceEnvironmentStatus
        /// </summary>
        public static readonly ServiceEnvironmentStatus UPDATING = new ServiceEnvironmentStatus("UPDATING");
        /// <summary>
        /// Constant VALID for ServiceEnvironmentStatus
        /// </summary>
        public static readonly ServiceEnvironmentStatus VALID = new ServiceEnvironmentStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceEnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceEnvironmentStatus FindValue(string value)
        {
            return FindValue<ServiceEnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceEnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceEnvironmentType.
    /// </summary>
    public class ServiceEnvironmentType : ConstantClass
    {

        /// <summary>
        /// Constant SAGEMAKER_TRAINING for ServiceEnvironmentType
        /// </summary>
        public static readonly ServiceEnvironmentType SAGEMAKER_TRAINING = new ServiceEnvironmentType("SAGEMAKER_TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceEnvironmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceEnvironmentType FindValue(string value)
        {
            return FindValue<ServiceEnvironmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceEnvironmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceJobRetryAction.
    /// </summary>
    public class ServiceJobRetryAction : ConstantClass
    {

        /// <summary>
        /// Constant EXIT for ServiceJobRetryAction
        /// </summary>
        public static readonly ServiceJobRetryAction EXIT = new ServiceJobRetryAction("EXIT");
        /// <summary>
        /// Constant RETRY for ServiceJobRetryAction
        /// </summary>
        public static readonly ServiceJobRetryAction RETRY = new ServiceJobRetryAction("RETRY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceJobRetryAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceJobRetryAction FindValue(string value)
        {
            return FindValue<ServiceJobRetryAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceJobRetryAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceJobStatus.
    /// </summary>
    public class ServiceJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus FAILED = new ServiceJobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus PENDING = new ServiceJobStatus("PENDING");
        /// <summary>
        /// Constant RUNNABLE for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus RUNNABLE = new ServiceJobStatus("RUNNABLE");
        /// <summary>
        /// Constant RUNNING for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus RUNNING = new ServiceJobStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus SCHEDULED = new ServiceJobStatus("SCHEDULED");
        /// <summary>
        /// Constant STARTING for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus STARTING = new ServiceJobStatus("STARTING");
        /// <summary>
        /// Constant SUBMITTED for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus SUBMITTED = new ServiceJobStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCEEDED for ServiceJobStatus
        /// </summary>
        public static readonly ServiceJobStatus SUCCEEDED = new ServiceJobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceJobStatus FindValue(string value)
        {
            return FindValue<ServiceJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceJobType.
    /// </summary>
    public class ServiceJobType : ConstantClass
    {

        /// <summary>
        /// Constant SAGEMAKER_TRAINING for ServiceJobType
        /// </summary>
        public static readonly ServiceJobType SAGEMAKER_TRAINING = new ServiceJobType("SAGEMAKER_TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceJobType FindValue(string value)
        {
            return FindValue<ServiceJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceResourceIdName.
    /// </summary>
    public class ServiceResourceIdName : ConstantClass
    {

        /// <summary>
        /// Constant TrainingJobArn for ServiceResourceIdName
        /// </summary>
        public static readonly ServiceResourceIdName TrainingJobArn = new ServiceResourceIdName("TrainingJobArn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceResourceIdName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceResourceIdName FindValue(string value)
        {
            return FindValue<ServiceResourceIdName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceResourceIdName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserdataType.
    /// </summary>
    public class UserdataType : ConstantClass
    {

        /// <summary>
        /// Constant EKS_BOOTSTRAP_SH for UserdataType
        /// </summary>
        public static readonly UserdataType EKS_BOOTSTRAP_SH = new UserdataType("EKS_BOOTSTRAP_SH");
        /// <summary>
        /// Constant EKS_NODEADM for UserdataType
        /// </summary>
        public static readonly UserdataType EKS_NODEADM = new UserdataType("EKS_NODEADM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserdataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserdataType FindValue(string value)
        {
            return FindValue<UserdataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserdataType(string value)
        {
            return FindValue(value);
        }
    }

}