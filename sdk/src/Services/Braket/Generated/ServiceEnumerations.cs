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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Braket
{

    /// <summary>
    /// Constants used for properties of type AssociationType.
    /// </summary>
    public class AssociationType : ConstantClass
    {

        /// <summary>
        /// Constant RESERVATION_TIME_WINDOW_ARN for AssociationType
        /// </summary>
        public static readonly AssociationType RESERVATION_TIME_WINDOW_ARN = new AssociationType("RESERVATION_TIME_WINDOW_ARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationType FindValue(string value)
        {
            return FindValue<AssociationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CancellationStatus.
    /// </summary>
    public class CancellationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for CancellationStatus
        /// </summary>
        public static readonly CancellationStatus CANCELLED = new CancellationStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for CancellationStatus
        /// </summary>
        public static readonly CancellationStatus CANCELLING = new CancellationStatus("CANCELLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancellationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancellationStatus FindValue(string value)
        {
            return FindValue<CancellationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancellationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionType.
    /// </summary>
    public class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for CompressionType
        /// </summary>
        public static readonly CompressionType GZIP = new CompressionType("GZIP");
        /// <summary>
        /// Constant NONE for CompressionType
        /// </summary>
        public static readonly CompressionType NONE = new CompressionType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceStatus.
    /// </summary>
    public class DeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus OFFLINE = new DeviceStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus ONLINE = new DeviceStatus("ONLINE");
        /// <summary>
        /// Constant RETIRED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus RETIRED = new DeviceStatus("RETIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceStatus FindValue(string value)
        {
            return FindValue<DeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceType.
    /// </summary>
    public class DeviceType : ConstantClass
    {

        /// <summary>
        /// Constant QPU for DeviceType
        /// </summary>
        public static readonly DeviceType QPU = new DeviceType("QPU");
        /// <summary>
        /// Constant SIMULATOR for DeviceType
        /// </summary>
        public static readonly DeviceType SIMULATOR = new DeviceType("SIMULATOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceType FindValue(string value)
        {
            return FindValue<DeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HybridJobAdditionalAttributeName.
    /// </summary>
    public class HybridJobAdditionalAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant QueueInfo for HybridJobAdditionalAttributeName
        /// </summary>
        public static readonly HybridJobAdditionalAttributeName QueueInfo = new HybridJobAdditionalAttributeName("QueueInfo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HybridJobAdditionalAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HybridJobAdditionalAttributeName FindValue(string value)
        {
            return FindValue<HybridJobAdditionalAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HybridJobAdditionalAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC42xlarge = new InstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC44xlarge = new InstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC48xlarge = new InstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC4Xlarge = new InstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC518xlarge = new InstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC52xlarge = new InstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC54xlarge = new InstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC59xlarge = new InstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5n18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n18xlarge = new InstanceType("ml.c5n.18xlarge");
        /// <summary>
        /// Constant MlC5n2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n2xlarge = new InstanceType("ml.c5n.2xlarge");
        /// <summary>
        /// Constant MlC5n4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n4xlarge = new InstanceType("ml.c5n.4xlarge");
        /// <summary>
        /// Constant MlC5n9xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n9xlarge = new InstanceType("ml.c5n.9xlarge");
        /// <summary>
        /// Constant MlC5nXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5nXlarge = new InstanceType("ml.c5n.xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5Xlarge = new InstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn12xlarge = new InstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn16xlarge = new InstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn2xlarge = new InstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn4xlarge = new InstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn8xlarge = new InstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dnXlarge = new InstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM410xlarge = new InstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM416xlarge = new InstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM42xlarge = new InstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM44xlarge = new InstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM4Xlarge = new InstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM512xlarge = new InstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM524xlarge = new InstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM52xlarge = new InstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM54xlarge = new InstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5Large = new InstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5Xlarge = new InstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP216xlarge = new InstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP28xlarge = new InstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP2Xlarge = new InstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP316xlarge = new InstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP32xlarge = new InstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP38xlarge = new InstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP3dn24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP3dn24xlarge = new InstanceType("ml.p3dn.24xlarge");
        /// <summary>
        /// Constant MlP4d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP4d24xlarge = new InstanceType("ml.p4d.24xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobEventType.
    /// </summary>
    public class JobEventType : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for JobEventType
        /// </summary>
        public static readonly JobEventType CANCELLED = new JobEventType("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for JobEventType
        /// </summary>
        public static readonly JobEventType COMPLETED = new JobEventType("COMPLETED");
        /// <summary>
        /// Constant DEPRIORITIZED_DUE_TO_INACTIVITY for JobEventType
        /// </summary>
        public static readonly JobEventType DEPRIORITIZED_DUE_TO_INACTIVITY = new JobEventType("DEPRIORITIZED_DUE_TO_INACTIVITY");
        /// <summary>
        /// Constant DOWNLOADING_DATA for JobEventType
        /// </summary>
        public static readonly JobEventType DOWNLOADING_DATA = new JobEventType("DOWNLOADING_DATA");
        /// <summary>
        /// Constant FAILED for JobEventType
        /// </summary>
        public static readonly JobEventType FAILED = new JobEventType("FAILED");
        /// <summary>
        /// Constant MAX_RUNTIME_EXCEEDED for JobEventType
        /// </summary>
        public static readonly JobEventType MAX_RUNTIME_EXCEEDED = new JobEventType("MAX_RUNTIME_EXCEEDED");
        /// <summary>
        /// Constant QUEUED_FOR_EXECUTION for JobEventType
        /// </summary>
        public static readonly JobEventType QUEUED_FOR_EXECUTION = new JobEventType("QUEUED_FOR_EXECUTION");
        /// <summary>
        /// Constant RUNNING for JobEventType
        /// </summary>
        public static readonly JobEventType RUNNING = new JobEventType("RUNNING");
        /// <summary>
        /// Constant STARTING_INSTANCE for JobEventType
        /// </summary>
        public static readonly JobEventType STARTING_INSTANCE = new JobEventType("STARTING_INSTANCE");
        /// <summary>
        /// Constant UPLOADING_RESULTS for JobEventType
        /// </summary>
        public static readonly JobEventType UPLOADING_RESULTS = new JobEventType("UPLOADING_RESULTS");
        /// <summary>
        /// Constant WAITING_FOR_PRIORITY for JobEventType
        /// </summary>
        public static readonly JobEventType WAITING_FOR_PRIORITY = new JobEventType("WAITING_FOR_PRIORITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobEventType FindValue(string value)
        {
            return FindValue<JobEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobPrimaryStatus.
    /// </summary>
    public class JobPrimaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for JobPrimaryStatus
        /// </summary>
        public static readonly JobPrimaryStatus CANCELLED = new JobPrimaryStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for JobPrimaryStatus
        /// </summary>
        public static readonly JobPrimaryStatus CANCELLING = new JobPrimaryStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for JobPrimaryStatus
        /// </summary>
        public static readonly JobPrimaryStatus COMPLETED = new JobPrimaryStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobPrimaryStatus
        /// </summary>
        public static readonly JobPrimaryStatus FAILED = new JobPrimaryStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for JobPrimaryStatus
        /// </summary>
        public static readonly JobPrimaryStatus QUEUED = new JobPrimaryStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for JobPrimaryStatus
        /// </summary>
        public static readonly JobPrimaryStatus RUNNING = new JobPrimaryStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobPrimaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobPrimaryStatus FindValue(string value)
        {
            return FindValue<JobPrimaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobPrimaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuantumTaskAdditionalAttributeName.
    /// </summary>
    public class QuantumTaskAdditionalAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant QueueInfo for QuantumTaskAdditionalAttributeName
        /// </summary>
        public static readonly QuantumTaskAdditionalAttributeName QueueInfo = new QuantumTaskAdditionalAttributeName("QueueInfo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuantumTaskAdditionalAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuantumTaskAdditionalAttributeName FindValue(string value)
        {
            return FindValue<QuantumTaskAdditionalAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuantumTaskAdditionalAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuantumTaskStatus.
    /// </summary>
    public class QuantumTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus CANCELLED = new QuantumTaskStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus CANCELLING = new QuantumTaskStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus COMPLETED = new QuantumTaskStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus CREATED = new QuantumTaskStatus("CREATED");
        /// <summary>
        /// Constant FAILED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus FAILED = new QuantumTaskStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus QUEUED = new QuantumTaskStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus RUNNING = new QuantumTaskStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuantumTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuantumTaskStatus FindValue(string value)
        {
            return FindValue<QuantumTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuantumTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueName.
    /// </summary>
    public class QueueName : ConstantClass
    {

        /// <summary>
        /// Constant JOBS_QUEUE for QueueName
        /// </summary>
        public static readonly QueueName JOBS_QUEUE = new QueueName("JOBS_QUEUE");
        /// <summary>
        /// Constant QUANTUM_TASKS_QUEUE for QueueName
        /// </summary>
        public static readonly QueueName QUANTUM_TASKS_QUEUE = new QueueName("QUANTUM_TASKS_QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueName FindValue(string value)
        {
            return FindValue<QueueName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueuePriority.
    /// </summary>
    public class QueuePriority : ConstantClass
    {

        /// <summary>
        /// Constant Normal for QueuePriority
        /// </summary>
        public static readonly QueuePriority Normal = new QueuePriority("Normal");
        /// <summary>
        /// Constant Priority for QueuePriority
        /// </summary>
        public static readonly QueuePriority Priority = new QueuePriority("Priority");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueuePriority(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueuePriority FindValue(string value)
        {
            return FindValue<QueuePriority>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueuePriority(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchJobsFilterOperator.
    /// </summary>
    public class SearchJobsFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator BETWEEN = new SearchJobsFilterOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator CONTAINS = new SearchJobsFilterOperator("CONTAINS");
        /// <summary>
        /// Constant EQUAL for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator EQUAL = new SearchJobsFilterOperator("EQUAL");
        /// <summary>
        /// Constant GT for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator GT = new SearchJobsFilterOperator("GT");
        /// <summary>
        /// Constant GTE for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator GTE = new SearchJobsFilterOperator("GTE");
        /// <summary>
        /// Constant LT for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator LT = new SearchJobsFilterOperator("LT");
        /// <summary>
        /// Constant LTE for SearchJobsFilterOperator
        /// </summary>
        public static readonly SearchJobsFilterOperator LTE = new SearchJobsFilterOperator("LTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchJobsFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchJobsFilterOperator FindValue(string value)
        {
            return FindValue<SearchJobsFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchJobsFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchQuantumTasksFilterOperator.
    /// </summary>
    public class SearchQuantumTasksFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator BETWEEN = new SearchQuantumTasksFilterOperator("BETWEEN");
        /// <summary>
        /// Constant EQUAL for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator EQUAL = new SearchQuantumTasksFilterOperator("EQUAL");
        /// <summary>
        /// Constant GT for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator GT = new SearchQuantumTasksFilterOperator("GT");
        /// <summary>
        /// Constant GTE for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator GTE = new SearchQuantumTasksFilterOperator("GTE");
        /// <summary>
        /// Constant LT for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator LT = new SearchQuantumTasksFilterOperator("LT");
        /// <summary>
        /// Constant LTE for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator LTE = new SearchQuantumTasksFilterOperator("LTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchQuantumTasksFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchQuantumTasksFilterOperator FindValue(string value)
        {
            return FindValue<SearchQuantumTasksFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchQuantumTasksFilterOperator(string value)
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
        /// Constant ProgramSetValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ProgramSetValidationFailed = new ValidationExceptionReason("ProgramSetValidationFailed");

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