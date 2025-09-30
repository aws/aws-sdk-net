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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ECS
{

    /// <summary>
    /// Constants used for properties of type AcceleratorManufacturer.
    /// </summary>
    public class AcceleratorManufacturer : ConstantClass
    {

        /// <summary>
        /// Constant AmazonWebServices for AcceleratorManufacturer
        /// </summary>
        public static readonly AcceleratorManufacturer AmazonWebServices = new AcceleratorManufacturer("amazon-web-services");
        /// <summary>
        /// Constant Amd for AcceleratorManufacturer
        /// </summary>
        public static readonly AcceleratorManufacturer Amd = new AcceleratorManufacturer("amd");
        /// <summary>
        /// Constant Habana for AcceleratorManufacturer
        /// </summary>
        public static readonly AcceleratorManufacturer Habana = new AcceleratorManufacturer("habana");
        /// <summary>
        /// Constant Nvidia for AcceleratorManufacturer
        /// </summary>
        public static readonly AcceleratorManufacturer Nvidia = new AcceleratorManufacturer("nvidia");
        /// <summary>
        /// Constant Xilinx for AcceleratorManufacturer
        /// </summary>
        public static readonly AcceleratorManufacturer Xilinx = new AcceleratorManufacturer("xilinx");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceleratorManufacturer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceleratorManufacturer FindValue(string value)
        {
            return FindValue<AcceleratorManufacturer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceleratorManufacturer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcceleratorName.
    /// </summary>
    public class AcceleratorName : ConstantClass
    {

        /// <summary>
        /// Constant A100 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName A100 = new AcceleratorName("a100");
        /// <summary>
        /// Constant A10g for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName A10g = new AcceleratorName("a10g");
        /// <summary>
        /// Constant H100 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName H100 = new AcceleratorName("h100");
        /// <summary>
        /// Constant Inferentia for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName Inferentia = new AcceleratorName("inferentia");
        /// <summary>
        /// Constant K520 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName K520 = new AcceleratorName("k520");
        /// <summary>
        /// Constant K80 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName K80 = new AcceleratorName("k80");
        /// <summary>
        /// Constant M60 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName M60 = new AcceleratorName("m60");
        /// <summary>
        /// Constant RadeonProV520 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName RadeonProV520 = new AcceleratorName("radeon-pro-v520");
        /// <summary>
        /// Constant T4 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName T4 = new AcceleratorName("t4");
        /// <summary>
        /// Constant T4g for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName T4g = new AcceleratorName("t4g");
        /// <summary>
        /// Constant V100 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName V100 = new AcceleratorName("v100");
        /// <summary>
        /// Constant Vu9p for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName Vu9p = new AcceleratorName("vu9p");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceleratorName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceleratorName FindValue(string value)
        {
            return FindValue<AcceleratorName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceleratorName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcceleratorType.
    /// </summary>
    public class AcceleratorType : ConstantClass
    {

        /// <summary>
        /// Constant Fpga for AcceleratorType
        /// </summary>
        public static readonly AcceleratorType Fpga = new AcceleratorType("fpga");
        /// <summary>
        /// Constant Gpu for AcceleratorType
        /// </summary>
        public static readonly AcceleratorType Gpu = new AcceleratorType("gpu");
        /// <summary>
        /// Constant Inference for AcceleratorType
        /// </summary>
        public static readonly AcceleratorType Inference = new AcceleratorType("inference");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceleratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceleratorType FindValue(string value)
        {
            return FindValue<AcceleratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceleratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentUpdateStatus.
    /// </summary>
    public class AgentUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus FAILED = new AgentUpdateStatus("FAILED");
        /// <summary>
        /// Constant PENDING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus PENDING = new AgentUpdateStatus("PENDING");
        /// <summary>
        /// Constant STAGED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus STAGED = new AgentUpdateStatus("STAGED");
        /// <summary>
        /// Constant STAGING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus STAGING = new AgentUpdateStatus("STAGING");
        /// <summary>
        /// Constant UPDATED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus UPDATED = new AgentUpdateStatus("UPDATED");
        /// <summary>
        /// Constant UPDATING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus UPDATING = new AgentUpdateStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentUpdateStatus FindValue(string value)
        {
            return FindValue<AgentUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationProtocol.
    /// </summary>
    public class ApplicationProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Grpc for ApplicationProtocol
        /// </summary>
        public static readonly ApplicationProtocol Grpc = new ApplicationProtocol("grpc");
        /// <summary>
        /// Constant Http for ApplicationProtocol
        /// </summary>
        public static readonly ApplicationProtocol Http = new ApplicationProtocol("http");
        /// <summary>
        /// Constant Http2 for ApplicationProtocol
        /// </summary>
        public static readonly ApplicationProtocol Http2 = new ApplicationProtocol("http2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationProtocol FindValue(string value)
        {
            return FindValue<ApplicationProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationProtocol(string value)
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
    /// Constants used for properties of type AvailabilityZoneRebalancing.
    /// </summary>
    public class AvailabilityZoneRebalancing : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AvailabilityZoneRebalancing
        /// </summary>
        public static readonly AvailabilityZoneRebalancing DISABLED = new AvailabilityZoneRebalancing("DISABLED");
        /// <summary>
        /// Constant ENABLED for AvailabilityZoneRebalancing
        /// </summary>
        public static readonly AvailabilityZoneRebalancing ENABLED = new AvailabilityZoneRebalancing("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailabilityZoneRebalancing(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityZoneRebalancing FindValue(string value)
        {
            return FindValue<AvailabilityZoneRebalancing>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailabilityZoneRebalancing(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BareMetal.
    /// </summary>
    public class BareMetal : ConstantClass
    {

        /// <summary>
        /// Constant Excluded for BareMetal
        /// </summary>
        public static readonly BareMetal Excluded = new BareMetal("excluded");
        /// <summary>
        /// Constant Included for BareMetal
        /// </summary>
        public static readonly BareMetal Included = new BareMetal("included");
        /// <summary>
        /// Constant Required for BareMetal
        /// </summary>
        public static readonly BareMetal Required = new BareMetal("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BareMetal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BareMetal FindValue(string value)
        {
            return FindValue<BareMetal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BareMetal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurstablePerformance.
    /// </summary>
    public class BurstablePerformance : ConstantClass
    {

        /// <summary>
        /// Constant Excluded for BurstablePerformance
        /// </summary>
        public static readonly BurstablePerformance Excluded = new BurstablePerformance("excluded");
        /// <summary>
        /// Constant Included for BurstablePerformance
        /// </summary>
        public static readonly BurstablePerformance Included = new BurstablePerformance("included");
        /// <summary>
        /// Constant Required for BurstablePerformance
        /// </summary>
        public static readonly BurstablePerformance Required = new BurstablePerformance("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurstablePerformance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurstablePerformance FindValue(string value)
        {
            return FindValue<BurstablePerformance>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurstablePerformance(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderField.
    /// </summary>
    public class CapacityProviderField : ConstantClass
    {

        /// <summary>
        /// Constant TAGS for CapacityProviderField
        /// </summary>
        public static readonly CapacityProviderField TAGS = new CapacityProviderField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderField FindValue(string value)
        {
            return FindValue<CapacityProviderField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderStatus.
    /// </summary>
    public class CapacityProviderStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CapacityProviderStatus
        /// </summary>
        public static readonly CapacityProviderStatus ACTIVE = new CapacityProviderStatus("ACTIVE");
        /// <summary>
        /// Constant DEPROVISIONING for CapacityProviderStatus
        /// </summary>
        public static readonly CapacityProviderStatus DEPROVISIONING = new CapacityProviderStatus("DEPROVISIONING");
        /// <summary>
        /// Constant INACTIVE for CapacityProviderStatus
        /// </summary>
        public static readonly CapacityProviderStatus INACTIVE = new CapacityProviderStatus("INACTIVE");
        /// <summary>
        /// Constant PROVISIONING for CapacityProviderStatus
        /// </summary>
        public static readonly CapacityProviderStatus PROVISIONING = new CapacityProviderStatus("PROVISIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderStatus FindValue(string value)
        {
            return FindValue<CapacityProviderStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderType.
    /// </summary>
    public class CapacityProviderType : ConstantClass
    {

        /// <summary>
        /// Constant EC2_AUTOSCALING for CapacityProviderType
        /// </summary>
        public static readonly CapacityProviderType EC2_AUTOSCALING = new CapacityProviderType("EC2_AUTOSCALING");
        /// <summary>
        /// Constant FARGATE for CapacityProviderType
        /// </summary>
        public static readonly CapacityProviderType FARGATE = new CapacityProviderType("FARGATE");
        /// <summary>
        /// Constant FARGATE_SPOT for CapacityProviderType
        /// </summary>
        public static readonly CapacityProviderType FARGATE_SPOT = new CapacityProviderType("FARGATE_SPOT");
        /// <summary>
        /// Constant MANAGED_INSTANCES for CapacityProviderType
        /// </summary>
        public static readonly CapacityProviderType MANAGED_INSTANCES = new CapacityProviderType("MANAGED_INSTANCES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderType FindValue(string value)
        {
            return FindValue<CapacityProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderUpdateStatus.
    /// </summary>
    public class CapacityProviderUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus CREATE_COMPLETE = new CapacityProviderUpdateStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus CREATE_FAILED = new CapacityProviderUpdateStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus CREATE_IN_PROGRESS = new CapacityProviderUpdateStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_COMPLETE for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus DELETE_COMPLETE = new CapacityProviderUpdateStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus DELETE_FAILED = new CapacityProviderUpdateStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus DELETE_IN_PROGRESS = new CapacityProviderUpdateStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus UPDATE_COMPLETE = new CapacityProviderUpdateStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus UPDATE_FAILED = new CapacityProviderUpdateStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for CapacityProviderUpdateStatus
        /// </summary>
        public static readonly CapacityProviderUpdateStatus UPDATE_IN_PROGRESS = new CapacityProviderUpdateStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderUpdateStatus FindValue(string value)
        {
            return FindValue<CapacityProviderUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterField.
    /// </summary>
    public class ClusterField : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENTS for ClusterField
        /// </summary>
        public static readonly ClusterField ATTACHMENTS = new ClusterField("ATTACHMENTS");
        /// <summary>
        /// Constant CONFIGURATIONS for ClusterField
        /// </summary>
        public static readonly ClusterField CONFIGURATIONS = new ClusterField("CONFIGURATIONS");
        /// <summary>
        /// Constant SETTINGS for ClusterField
        /// </summary>
        public static readonly ClusterField SETTINGS = new ClusterField("SETTINGS");
        /// <summary>
        /// Constant STATISTICS for ClusterField
        /// </summary>
        public static readonly ClusterField STATISTICS = new ClusterField("STATISTICS");
        /// <summary>
        /// Constant TAGS for ClusterField
        /// </summary>
        public static readonly ClusterField TAGS = new ClusterField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterField FindValue(string value)
        {
            return FindValue<ClusterField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterSettingName.
    /// </summary>
    public class ClusterSettingName : ConstantClass
    {

        /// <summary>
        /// Constant ContainerInsights for ClusterSettingName
        /// </summary>
        public static readonly ClusterSettingName ContainerInsights = new ClusterSettingName("containerInsights");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterSettingName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterSettingName FindValue(string value)
        {
            return FindValue<ClusterSettingName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterSettingName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Compatibility.
    /// </summary>
    public class Compatibility : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for Compatibility
        /// </summary>
        public static readonly Compatibility EC2 = new Compatibility("EC2");
        /// <summary>
        /// Constant EXTERNAL for Compatibility
        /// </summary>
        public static readonly Compatibility EXTERNAL = new Compatibility("EXTERNAL");
        /// <summary>
        /// Constant FARGATE for Compatibility
        /// </summary>
        public static readonly Compatibility FARGATE = new Compatibility("FARGATE");
        /// <summary>
        /// Constant MANAGED_INSTANCES for Compatibility
        /// </summary>
        public static readonly Compatibility MANAGED_INSTANCES = new Compatibility("MANAGED_INSTANCES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Compatibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Compatibility FindValue(string value)
        {
            return FindValue<Compatibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Compatibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Connectivity.
    /// </summary>
    public class Connectivity : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for Connectivity
        /// </summary>
        public static readonly Connectivity CONNECTED = new Connectivity("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for Connectivity
        /// </summary>
        public static readonly Connectivity DISCONNECTED = new Connectivity("DISCONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Connectivity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Connectivity FindValue(string value)
        {
            return FindValue<Connectivity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Connectivity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerCondition.
    /// </summary>
    public class ContainerCondition : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ContainerCondition
        /// </summary>
        public static readonly ContainerCondition COMPLETE = new ContainerCondition("COMPLETE");
        /// <summary>
        /// Constant HEALTHY for ContainerCondition
        /// </summary>
        public static readonly ContainerCondition HEALTHY = new ContainerCondition("HEALTHY");
        /// <summary>
        /// Constant START for ContainerCondition
        /// </summary>
        public static readonly ContainerCondition START = new ContainerCondition("START");
        /// <summary>
        /// Constant SUCCESS for ContainerCondition
        /// </summary>
        public static readonly ContainerCondition SUCCESS = new ContainerCondition("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerCondition FindValue(string value)
        {
            return FindValue<ContainerCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerInstanceField.
    /// </summary>
    public class ContainerInstanceField : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINER_INSTANCE_HEALTH for ContainerInstanceField
        /// </summary>
        public static readonly ContainerInstanceField CONTAINER_INSTANCE_HEALTH = new ContainerInstanceField("CONTAINER_INSTANCE_HEALTH");
        /// <summary>
        /// Constant TAGS for ContainerInstanceField
        /// </summary>
        public static readonly ContainerInstanceField TAGS = new ContainerInstanceField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerInstanceField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerInstanceField FindValue(string value)
        {
            return FindValue<ContainerInstanceField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerInstanceField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerInstanceStatus.
    /// </summary>
    public class ContainerInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ContainerInstanceStatus
        /// </summary>
        public static readonly ContainerInstanceStatus ACTIVE = new ContainerInstanceStatus("ACTIVE");
        /// <summary>
        /// Constant DEREGISTERING for ContainerInstanceStatus
        /// </summary>
        public static readonly ContainerInstanceStatus DEREGISTERING = new ContainerInstanceStatus("DEREGISTERING");
        /// <summary>
        /// Constant DRAINING for ContainerInstanceStatus
        /// </summary>
        public static readonly ContainerInstanceStatus DRAINING = new ContainerInstanceStatus("DRAINING");
        /// <summary>
        /// Constant REGISTERING for ContainerInstanceStatus
        /// </summary>
        public static readonly ContainerInstanceStatus REGISTERING = new ContainerInstanceStatus("REGISTERING");
        /// <summary>
        /// Constant REGISTRATION_FAILED for ContainerInstanceStatus
        /// </summary>
        public static readonly ContainerInstanceStatus REGISTRATION_FAILED = new ContainerInstanceStatus("REGISTRATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerInstanceStatus FindValue(string value)
        {
            return FindValue<ContainerInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CPUArchitecture.
    /// </summary>
    public class CPUArchitecture : ConstantClass
    {

        /// <summary>
        /// Constant ARM64 for CPUArchitecture
        /// </summary>
        public static readonly CPUArchitecture ARM64 = new CPUArchitecture("ARM64");
        /// <summary>
        /// Constant X86_64 for CPUArchitecture
        /// </summary>
        public static readonly CPUArchitecture X86_64 = new CPUArchitecture("X86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CPUArchitecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CPUArchitecture FindValue(string value)
        {
            return FindValue<CPUArchitecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CPUArchitecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CpuManufacturer.
    /// </summary>
    public class CpuManufacturer : ConstantClass
    {

        /// <summary>
        /// Constant AmazonWebServices for CpuManufacturer
        /// </summary>
        public static readonly CpuManufacturer AmazonWebServices = new CpuManufacturer("amazon-web-services");
        /// <summary>
        /// Constant Amd for CpuManufacturer
        /// </summary>
        public static readonly CpuManufacturer Amd = new CpuManufacturer("amd");
        /// <summary>
        /// Constant Intel for CpuManufacturer
        /// </summary>
        public static readonly CpuManufacturer Intel = new CpuManufacturer("intel");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CpuManufacturer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CpuManufacturer FindValue(string value)
        {
            return FindValue<CpuManufacturer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CpuManufacturer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentControllerType.
    /// </summary>
    public class DeploymentControllerType : ConstantClass
    {

        /// <summary>
        /// Constant CODE_DEPLOY for DeploymentControllerType
        /// </summary>
        public static readonly DeploymentControllerType CODE_DEPLOY = new DeploymentControllerType("CODE_DEPLOY");
        /// <summary>
        /// Constant ECS for DeploymentControllerType
        /// </summary>
        public static readonly DeploymentControllerType ECS = new DeploymentControllerType("ECS");
        /// <summary>
        /// Constant EXTERNAL for DeploymentControllerType
        /// </summary>
        public static readonly DeploymentControllerType EXTERNAL = new DeploymentControllerType("EXTERNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentControllerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentControllerType FindValue(string value)
        {
            return FindValue<DeploymentControllerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentControllerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentLifecycleHookStage.
    /// </summary>
    public class DeploymentLifecycleHookStage : ConstantClass
    {

        /// <summary>
        /// Constant POST_PRODUCTION_TRAFFIC_SHIFT for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage POST_PRODUCTION_TRAFFIC_SHIFT = new DeploymentLifecycleHookStage("POST_PRODUCTION_TRAFFIC_SHIFT");
        /// <summary>
        /// Constant POST_SCALE_UP for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage POST_SCALE_UP = new DeploymentLifecycleHookStage("POST_SCALE_UP");
        /// <summary>
        /// Constant POST_TEST_TRAFFIC_SHIFT for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage POST_TEST_TRAFFIC_SHIFT = new DeploymentLifecycleHookStage("POST_TEST_TRAFFIC_SHIFT");
        /// <summary>
        /// Constant PRE_SCALE_UP for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage PRE_SCALE_UP = new DeploymentLifecycleHookStage("PRE_SCALE_UP");
        /// <summary>
        /// Constant PRODUCTION_TRAFFIC_SHIFT for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage PRODUCTION_TRAFFIC_SHIFT = new DeploymentLifecycleHookStage("PRODUCTION_TRAFFIC_SHIFT");
        /// <summary>
        /// Constant RECONCILE_SERVICE for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage RECONCILE_SERVICE = new DeploymentLifecycleHookStage("RECONCILE_SERVICE");
        /// <summary>
        /// Constant TEST_TRAFFIC_SHIFT for DeploymentLifecycleHookStage
        /// </summary>
        public static readonly DeploymentLifecycleHookStage TEST_TRAFFIC_SHIFT = new DeploymentLifecycleHookStage("TEST_TRAFFIC_SHIFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentLifecycleHookStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentLifecycleHookStage FindValue(string value)
        {
            return FindValue<DeploymentLifecycleHookStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentLifecycleHookStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentRolloutState.
    /// </summary>
    public class DeploymentRolloutState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DeploymentRolloutState
        /// </summary>
        public static readonly DeploymentRolloutState COMPLETED = new DeploymentRolloutState("COMPLETED");
        /// <summary>
        /// Constant FAILED for DeploymentRolloutState
        /// </summary>
        public static readonly DeploymentRolloutState FAILED = new DeploymentRolloutState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentRolloutState
        /// </summary>
        public static readonly DeploymentRolloutState IN_PROGRESS = new DeploymentRolloutState("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentRolloutState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentRolloutState FindValue(string value)
        {
            return FindValue<DeploymentRolloutState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentRolloutState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStrategy.
    /// </summary>
    public class DeploymentStrategy : ConstantClass
    {

        /// <summary>
        /// Constant BLUE_GREEN for DeploymentStrategy
        /// </summary>
        public static readonly DeploymentStrategy BLUE_GREEN = new DeploymentStrategy("BLUE_GREEN");
        /// <summary>
        /// Constant ROLLING for DeploymentStrategy
        /// </summary>
        public static readonly DeploymentStrategy ROLLING = new DeploymentStrategy("ROLLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStrategy FindValue(string value)
        {
            return FindValue<DeploymentStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredStatus.
    /// </summary>
    public class DesiredStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus PENDING = new DesiredStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus RUNNING = new DesiredStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus STOPPED = new DesiredStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesiredStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredStatus FindValue(string value)
        {
            return FindValue<DesiredStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredStatus(string value)
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
        /// Constant Mknod for DeviceCgroupPermission
        /// </summary>
        public static readonly DeviceCgroupPermission Mknod = new DeviceCgroupPermission("mknod");
        /// <summary>
        /// Constant Read for DeviceCgroupPermission
        /// </summary>
        public static readonly DeviceCgroupPermission Read = new DeviceCgroupPermission("read");
        /// <summary>
        /// Constant Write for DeviceCgroupPermission
        /// </summary>
        public static readonly DeviceCgroupPermission Write = new DeviceCgroupPermission("write");

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
    /// Constants used for properties of type EBSResourceType.
    /// </summary>
    public class EBSResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Volume for EBSResourceType
        /// </summary>
        public static readonly EBSResourceType Volume = new EBSResourceType("volume");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EBSResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EBSResourceType FindValue(string value)
        {
            return FindValue<EBSResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EBSResourceType(string value)
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
    /// Constants used for properties of type EnvironmentFileType.
    /// </summary>
    public class EnvironmentFileType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for EnvironmentFileType
        /// </summary>
        public static readonly EnvironmentFileType S3 = new EnvironmentFileType("s3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentFileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentFileType FindValue(string value)
        {
            return FindValue<EnvironmentFileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentFileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecuteCommandLogging.
    /// </summary>
    public class ExecuteCommandLogging : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for ExecuteCommandLogging
        /// </summary>
        public static readonly ExecuteCommandLogging DEFAULT = new ExecuteCommandLogging("DEFAULT");
        /// <summary>
        /// Constant NONE for ExecuteCommandLogging
        /// </summary>
        public static readonly ExecuteCommandLogging NONE = new ExecuteCommandLogging("NONE");
        /// <summary>
        /// Constant OVERRIDE for ExecuteCommandLogging
        /// </summary>
        public static readonly ExecuteCommandLogging OVERRIDE = new ExecuteCommandLogging("OVERRIDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecuteCommandLogging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecuteCommandLogging FindValue(string value)
        {
            return FindValue<ExecuteCommandLogging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecuteCommandLogging(string value)
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
    /// Constants used for properties of type HealthStatus.
    /// </summary>
    public class HealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for HealthStatus
        /// </summary>
        public static readonly HealthStatus HEALTHY = new HealthStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for HealthStatus
        /// </summary>
        public static readonly HealthStatus UNHEALTHY = new HealthStatus("UNHEALTHY");
        /// <summary>
        /// Constant UNKNOWN for HealthStatus
        /// </summary>
        public static readonly HealthStatus UNKNOWN = new HealthStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthStatus FindValue(string value)
        {
            return FindValue<HealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceGeneration.
    /// </summary>
    public class InstanceGeneration : ConstantClass
    {

        /// <summary>
        /// Constant Current for InstanceGeneration
        /// </summary>
        public static readonly InstanceGeneration Current = new InstanceGeneration("current");
        /// <summary>
        /// Constant Previous for InstanceGeneration
        /// </summary>
        public static readonly InstanceGeneration Previous = new InstanceGeneration("previous");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceGeneration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceGeneration FindValue(string value)
        {
            return FindValue<InstanceGeneration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceGeneration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthCheckState.
    /// </summary>
    public class InstanceHealthCheckState : ConstantClass
    {

        /// <summary>
        /// Constant IMPAIRED for InstanceHealthCheckState
        /// </summary>
        public static readonly InstanceHealthCheckState IMPAIRED = new InstanceHealthCheckState("IMPAIRED");
        /// <summary>
        /// Constant INITIALIZING for InstanceHealthCheckState
        /// </summary>
        public static readonly InstanceHealthCheckState INITIALIZING = new InstanceHealthCheckState("INITIALIZING");
        /// <summary>
        /// Constant INSUFFICIENT_DATA for InstanceHealthCheckState
        /// </summary>
        public static readonly InstanceHealthCheckState INSUFFICIENT_DATA = new InstanceHealthCheckState("INSUFFICIENT_DATA");
        /// <summary>
        /// Constant OK for InstanceHealthCheckState
        /// </summary>
        public static readonly InstanceHealthCheckState OK = new InstanceHealthCheckState("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthCheckState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthCheckState FindValue(string value)
        {
            return FindValue<InstanceHealthCheckState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthCheckState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthCheckType.
    /// </summary>
    public class InstanceHealthCheckType : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINER_RUNTIME for InstanceHealthCheckType
        /// </summary>
        public static readonly InstanceHealthCheckType CONTAINER_RUNTIME = new InstanceHealthCheckType("CONTAINER_RUNTIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthCheckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthCheckType FindValue(string value)
        {
            return FindValue<InstanceHealthCheckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthCheckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpcMode.
    /// </summary>
    public class IpcMode : ConstantClass
    {

        /// <summary>
        /// Constant Host for IpcMode
        /// </summary>
        public static readonly IpcMode Host = new IpcMode("host");
        /// <summary>
        /// Constant None for IpcMode
        /// </summary>
        public static readonly IpcMode None = new IpcMode("none");
        /// <summary>
        /// Constant Task for IpcMode
        /// </summary>
        public static readonly IpcMode Task = new IpcMode("task");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpcMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpcMode FindValue(string value)
        {
            return FindValue<IpcMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpcMode(string value)
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
        /// Constant MANAGED_INSTANCES for LaunchType
        /// </summary>
        public static readonly LaunchType MANAGED_INSTANCES = new LaunchType("MANAGED_INSTANCES");

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
    /// Constants used for properties of type LocalStorage.
    /// </summary>
    public class LocalStorage : ConstantClass
    {

        /// <summary>
        /// Constant Excluded for LocalStorage
        /// </summary>
        public static readonly LocalStorage Excluded = new LocalStorage("excluded");
        /// <summary>
        /// Constant Included for LocalStorage
        /// </summary>
        public static readonly LocalStorage Included = new LocalStorage("included");
        /// <summary>
        /// Constant Required for LocalStorage
        /// </summary>
        public static readonly LocalStorage Required = new LocalStorage("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalStorage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalStorage FindValue(string value)
        {
            return FindValue<LocalStorage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalStorage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocalStorageType.
    /// </summary>
    public class LocalStorageType : ConstantClass
    {

        /// <summary>
        /// Constant Hdd for LocalStorageType
        /// </summary>
        public static readonly LocalStorageType Hdd = new LocalStorageType("hdd");
        /// <summary>
        /// Constant Ssd for LocalStorageType
        /// </summary>
        public static readonly LocalStorageType Ssd = new LocalStorageType("ssd");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalStorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalStorageType FindValue(string value)
        {
            return FindValue<LocalStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalStorageType(string value)
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
    /// Constants used for properties of type ManagedAgentName.
    /// </summary>
    public class ManagedAgentName : ConstantClass
    {

        /// <summary>
        /// Constant ExecuteCommandAgent for ManagedAgentName
        /// </summary>
        public static readonly ManagedAgentName ExecuteCommandAgent = new ManagedAgentName("ExecuteCommandAgent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedAgentName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedAgentName FindValue(string value)
        {
            return FindValue<ManagedAgentName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedAgentName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedDraining.
    /// </summary>
    public class ManagedDraining : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ManagedDraining
        /// </summary>
        public static readonly ManagedDraining DISABLED = new ManagedDraining("DISABLED");
        /// <summary>
        /// Constant ENABLED for ManagedDraining
        /// </summary>
        public static readonly ManagedDraining ENABLED = new ManagedDraining("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedDraining(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedDraining FindValue(string value)
        {
            return FindValue<ManagedDraining>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedDraining(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedInstancesMonitoringOptions.
    /// </summary>
    public class ManagedInstancesMonitoringOptions : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for ManagedInstancesMonitoringOptions
        /// </summary>
        public static readonly ManagedInstancesMonitoringOptions BASIC = new ManagedInstancesMonitoringOptions("BASIC");
        /// <summary>
        /// Constant DETAILED for ManagedInstancesMonitoringOptions
        /// </summary>
        public static readonly ManagedInstancesMonitoringOptions DETAILED = new ManagedInstancesMonitoringOptions("DETAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedInstancesMonitoringOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedInstancesMonitoringOptions FindValue(string value)
        {
            return FindValue<ManagedInstancesMonitoringOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedInstancesMonitoringOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedScalingStatus.
    /// </summary>
    public class ManagedScalingStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ManagedScalingStatus
        /// </summary>
        public static readonly ManagedScalingStatus DISABLED = new ManagedScalingStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ManagedScalingStatus
        /// </summary>
        public static readonly ManagedScalingStatus ENABLED = new ManagedScalingStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedScalingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedScalingStatus FindValue(string value)
        {
            return FindValue<ManagedScalingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedScalingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedTerminationProtection.
    /// </summary>
    public class ManagedTerminationProtection : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ManagedTerminationProtection
        /// </summary>
        public static readonly ManagedTerminationProtection DISABLED = new ManagedTerminationProtection("DISABLED");
        /// <summary>
        /// Constant ENABLED for ManagedTerminationProtection
        /// </summary>
        public static readonly ManagedTerminationProtection ENABLED = new ManagedTerminationProtection("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedTerminationProtection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedTerminationProtection FindValue(string value)
        {
            return FindValue<ManagedTerminationProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedTerminationProtection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkMode.
    /// </summary>
    public class NetworkMode : ConstantClass
    {

        /// <summary>
        /// Constant Awsvpc for NetworkMode
        /// </summary>
        public static readonly NetworkMode Awsvpc = new NetworkMode("awsvpc");
        /// <summary>
        /// Constant Bridge for NetworkMode
        /// </summary>
        public static readonly NetworkMode Bridge = new NetworkMode("bridge");
        /// <summary>
        /// Constant Host for NetworkMode
        /// </summary>
        public static readonly NetworkMode Host = new NetworkMode("host");
        /// <summary>
        /// Constant None for NetworkMode
        /// </summary>
        public static readonly NetworkMode None = new NetworkMode("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkMode FindValue(string value)
        {
            return FindValue<NetworkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OSFamily.
    /// </summary>
    public class OSFamily : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for OSFamily
        /// </summary>
        public static readonly OSFamily LINUX = new OSFamily("LINUX");
        /// <summary>
        /// Constant WINDOWS_SERVER_2004_CORE for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2004_CORE = new OSFamily("WINDOWS_SERVER_2004_CORE");
        /// <summary>
        /// Constant WINDOWS_SERVER_2016_FULL for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2016_FULL = new OSFamily("WINDOWS_SERVER_2016_FULL");
        /// <summary>
        /// Constant WINDOWS_SERVER_2019_CORE for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2019_CORE = new OSFamily("WINDOWS_SERVER_2019_CORE");
        /// <summary>
        /// Constant WINDOWS_SERVER_2019_FULL for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2019_FULL = new OSFamily("WINDOWS_SERVER_2019_FULL");
        /// <summary>
        /// Constant WINDOWS_SERVER_2022_CORE for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2022_CORE = new OSFamily("WINDOWS_SERVER_2022_CORE");
        /// <summary>
        /// Constant WINDOWS_SERVER_2022_FULL for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2022_FULL = new OSFamily("WINDOWS_SERVER_2022_FULL");
        /// <summary>
        /// Constant WINDOWS_SERVER_2025_CORE for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2025_CORE = new OSFamily("WINDOWS_SERVER_2025_CORE");
        /// <summary>
        /// Constant WINDOWS_SERVER_2025_FULL for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_2025_FULL = new OSFamily("WINDOWS_SERVER_2025_FULL");
        /// <summary>
        /// Constant WINDOWS_SERVER_20H2_CORE for OSFamily
        /// </summary>
        public static readonly OSFamily WINDOWS_SERVER_20H2_CORE = new OSFamily("WINDOWS_SERVER_20H2_CORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OSFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OSFamily FindValue(string value)
        {
            return FindValue<OSFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OSFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PidMode.
    /// </summary>
    public class PidMode : ConstantClass
    {

        /// <summary>
        /// Constant Host for PidMode
        /// </summary>
        public static readonly PidMode Host = new PidMode("host");
        /// <summary>
        /// Constant Task for PidMode
        /// </summary>
        public static readonly PidMode Task = new PidMode("task");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PidMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PidMode FindValue(string value)
        {
            return FindValue<PidMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PidMode(string value)
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
    /// Constants used for properties of type PlatformDeviceType.
    /// </summary>
    public class PlatformDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant GPU for PlatformDeviceType
        /// </summary>
        public static readonly PlatformDeviceType GPU = new PlatformDeviceType("GPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformDeviceType FindValue(string value)
        {
            return FindValue<PlatformDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformDeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropagateMITags.
    /// </summary>
    public class PropagateMITags : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_PROVIDER for PropagateMITags
        /// </summary>
        public static readonly PropagateMITags CAPACITY_PROVIDER = new PropagateMITags("CAPACITY_PROVIDER");
        /// <summary>
        /// Constant NONE for PropagateMITags
        /// </summary>
        public static readonly PropagateMITags NONE = new PropagateMITags("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropagateMITags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropagateMITags FindValue(string value)
        {
            return FindValue<PropagateMITags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropagateMITags(string value)
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
        /// Constant NONE for PropagateTags
        /// </summary>
        public static readonly PropagateTags NONE = new PropagateTags("NONE");
        /// <summary>
        /// Constant SERVICE for PropagateTags
        /// </summary>
        public static readonly PropagateTags SERVICE = new PropagateTags("SERVICE");
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
    /// Constants used for properties of type ProxyConfigurationType.
    /// </summary>
    public class ProxyConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant APPMESH for ProxyConfigurationType
        /// </summary>
        public static readonly ProxyConfigurationType APPMESH = new ProxyConfigurationType("APPMESH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProxyConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyConfigurationType FindValue(string value)
        {
            return FindValue<ProxyConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyConfigurationType(string value)
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
        /// Constant InferenceAccelerator for ResourceType
        /// </summary>
        public static readonly ResourceType InferenceAccelerator = new ResourceType("InferenceAccelerator");

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
    /// Constants used for properties of type ScaleUnit.
    /// </summary>
    public class ScaleUnit : ConstantClass
    {

        /// <summary>
        /// Constant PERCENT for ScaleUnit
        /// </summary>
        public static readonly ScaleUnit PERCENT = new ScaleUnit("PERCENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScaleUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScaleUnit FindValue(string value)
        {
            return FindValue<ScaleUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScaleUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchedulingStrategy.
    /// </summary>
    public class SchedulingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant DAEMON for SchedulingStrategy
        /// </summary>
        public static readonly SchedulingStrategy DAEMON = new SchedulingStrategy("DAEMON");
        /// <summary>
        /// Constant REPLICA for SchedulingStrategy
        /// </summary>
        public static readonly SchedulingStrategy REPLICA = new SchedulingStrategy("REPLICA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchedulingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchedulingStrategy FindValue(string value)
        {
            return FindValue<SchedulingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchedulingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scope.
    /// </summary>
    public class Scope : ConstantClass
    {

        /// <summary>
        /// Constant Shared for Scope
        /// </summary>
        public static readonly Scope Shared = new Scope("shared");
        /// <summary>
        /// Constant Task for Scope
        /// </summary>
        public static readonly Scope Task = new Scope("task");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scope FindValue(string value)
        {
            return FindValue<Scope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceDeploymentLifecycleStage.
    /// </summary>
    public class ServiceDeploymentLifecycleStage : ConstantClass
    {

        /// <summary>
        /// Constant BAKE_TIME for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage BAKE_TIME = new ServiceDeploymentLifecycleStage("BAKE_TIME");
        /// <summary>
        /// Constant CLEAN_UP for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage CLEAN_UP = new ServiceDeploymentLifecycleStage("CLEAN_UP");
        /// <summary>
        /// Constant POST_PRODUCTION_TRAFFIC_SHIFT for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage POST_PRODUCTION_TRAFFIC_SHIFT = new ServiceDeploymentLifecycleStage("POST_PRODUCTION_TRAFFIC_SHIFT");
        /// <summary>
        /// Constant POST_SCALE_UP for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage POST_SCALE_UP = new ServiceDeploymentLifecycleStage("POST_SCALE_UP");
        /// <summary>
        /// Constant POST_TEST_TRAFFIC_SHIFT for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage POST_TEST_TRAFFIC_SHIFT = new ServiceDeploymentLifecycleStage("POST_TEST_TRAFFIC_SHIFT");
        /// <summary>
        /// Constant PRE_SCALE_UP for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage PRE_SCALE_UP = new ServiceDeploymentLifecycleStage("PRE_SCALE_UP");
        /// <summary>
        /// Constant PRODUCTION_TRAFFIC_SHIFT for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage PRODUCTION_TRAFFIC_SHIFT = new ServiceDeploymentLifecycleStage("PRODUCTION_TRAFFIC_SHIFT");
        /// <summary>
        /// Constant RECONCILE_SERVICE for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage RECONCILE_SERVICE = new ServiceDeploymentLifecycleStage("RECONCILE_SERVICE");
        /// <summary>
        /// Constant SCALE_UP for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage SCALE_UP = new ServiceDeploymentLifecycleStage("SCALE_UP");
        /// <summary>
        /// Constant TEST_TRAFFIC_SHIFT for ServiceDeploymentLifecycleStage
        /// </summary>
        public static readonly ServiceDeploymentLifecycleStage TEST_TRAFFIC_SHIFT = new ServiceDeploymentLifecycleStage("TEST_TRAFFIC_SHIFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceDeploymentLifecycleStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceDeploymentLifecycleStage FindValue(string value)
        {
            return FindValue<ServiceDeploymentLifecycleStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceDeploymentLifecycleStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceDeploymentRollbackMonitorsStatus.
    /// </summary>
    public class ServiceDeploymentRollbackMonitorsStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ServiceDeploymentRollbackMonitorsStatus
        /// </summary>
        public static readonly ServiceDeploymentRollbackMonitorsStatus DISABLED = new ServiceDeploymentRollbackMonitorsStatus("DISABLED");
        /// <summary>
        /// Constant MONITORING for ServiceDeploymentRollbackMonitorsStatus
        /// </summary>
        public static readonly ServiceDeploymentRollbackMonitorsStatus MONITORING = new ServiceDeploymentRollbackMonitorsStatus("MONITORING");
        /// <summary>
        /// Constant MONITORING_COMPLETE for ServiceDeploymentRollbackMonitorsStatus
        /// </summary>
        public static readonly ServiceDeploymentRollbackMonitorsStatus MONITORING_COMPLETE = new ServiceDeploymentRollbackMonitorsStatus("MONITORING_COMPLETE");
        /// <summary>
        /// Constant TRIGGERED for ServiceDeploymentRollbackMonitorsStatus
        /// </summary>
        public static readonly ServiceDeploymentRollbackMonitorsStatus TRIGGERED = new ServiceDeploymentRollbackMonitorsStatus("TRIGGERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceDeploymentRollbackMonitorsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceDeploymentRollbackMonitorsStatus FindValue(string value)
        {
            return FindValue<ServiceDeploymentRollbackMonitorsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceDeploymentRollbackMonitorsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceDeploymentStatus.
    /// </summary>
    public class ServiceDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant IN_PROGRESS for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus IN_PROGRESS = new ServiceDeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus PENDING = new ServiceDeploymentStatus("PENDING");
        /// <summary>
        /// Constant ROLLBACK_FAILED for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus ROLLBACK_FAILED = new ServiceDeploymentStatus("ROLLBACK_FAILED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus ROLLBACK_IN_PROGRESS = new ServiceDeploymentStatus("ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant ROLLBACK_REQUESTED for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus ROLLBACK_REQUESTED = new ServiceDeploymentStatus("ROLLBACK_REQUESTED");
        /// <summary>
        /// Constant ROLLBACK_SUCCESSFUL for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus ROLLBACK_SUCCESSFUL = new ServiceDeploymentStatus("ROLLBACK_SUCCESSFUL");
        /// <summary>
        /// Constant STOP_REQUESTED for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus STOP_REQUESTED = new ServiceDeploymentStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant STOPPED for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus STOPPED = new ServiceDeploymentStatus("STOPPED");
        /// <summary>
        /// Constant SUCCESSFUL for ServiceDeploymentStatus
        /// </summary>
        public static readonly ServiceDeploymentStatus SUCCESSFUL = new ServiceDeploymentStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceDeploymentStatus FindValue(string value)
        {
            return FindValue<ServiceDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceField.
    /// </summary>
    public class ServiceField : ConstantClass
    {

        /// <summary>
        /// Constant TAGS for ServiceField
        /// </summary>
        public static readonly ServiceField TAGS = new ServiceField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceField FindValue(string value)
        {
            return FindValue<ServiceField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SettingName.
    /// </summary>
    public class SettingName : ConstantClass
    {

        /// <summary>
        /// Constant AwsvpcTrunking for SettingName
        /// </summary>
        public static readonly SettingName AwsvpcTrunking = new SettingName("awsvpcTrunking");
        /// <summary>
        /// Constant ContainerInsights for SettingName
        /// </summary>
        public static readonly SettingName ContainerInsights = new SettingName("containerInsights");
        /// <summary>
        /// Constant ContainerInstanceLongArnFormat for SettingName
        /// </summary>
        public static readonly SettingName ContainerInstanceLongArnFormat = new SettingName("containerInstanceLongArnFormat");
        /// <summary>
        /// Constant DefaultLogDriverMode for SettingName
        /// </summary>
        public static readonly SettingName DefaultLogDriverMode = new SettingName("defaultLogDriverMode");
        /// <summary>
        /// Constant FargateFIPSMode for SettingName
        /// </summary>
        public static readonly SettingName FargateFIPSMode = new SettingName("fargateFIPSMode");
        /// <summary>
        /// Constant FargateTaskRetirementWaitPeriod for SettingName
        /// </summary>
        public static readonly SettingName FargateTaskRetirementWaitPeriod = new SettingName("fargateTaskRetirementWaitPeriod");
        /// <summary>
        /// Constant GuardDutyActivate for SettingName
        /// </summary>
        public static readonly SettingName GuardDutyActivate = new SettingName("guardDutyActivate");
        /// <summary>
        /// Constant ServiceLongArnFormat for SettingName
        /// </summary>
        public static readonly SettingName ServiceLongArnFormat = new SettingName("serviceLongArnFormat");
        /// <summary>
        /// Constant TagResourceAuthorization for SettingName
        /// </summary>
        public static readonly SettingName TagResourceAuthorization = new SettingName("tagResourceAuthorization");
        /// <summary>
        /// Constant TaskLongArnFormat for SettingName
        /// </summary>
        public static readonly SettingName TaskLongArnFormat = new SettingName("taskLongArnFormat");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SettingName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettingName FindValue(string value)
        {
            return FindValue<SettingName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettingName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SettingType.
    /// </summary>
    public class SettingType : ConstantClass
    {

        /// <summary>
        /// Constant Aws_managed for SettingType
        /// </summary>
        public static readonly SettingType Aws_managed = new SettingType("aws_managed");
        /// <summary>
        /// Constant User for SettingType
        /// </summary>
        public static readonly SettingType User = new SettingType("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SettingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettingType FindValue(string value)
        {
            return FindValue<SettingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StabilityStatus.
    /// </summary>
    public class StabilityStatus : ConstantClass
    {

        /// <summary>
        /// Constant STABILIZING for StabilityStatus
        /// </summary>
        public static readonly StabilityStatus STABILIZING = new StabilityStatus("STABILIZING");
        /// <summary>
        /// Constant STEADY_STATE for StabilityStatus
        /// </summary>
        public static readonly StabilityStatus STEADY_STATE = new StabilityStatus("STEADY_STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StabilityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StabilityStatus FindValue(string value)
        {
            return FindValue<StabilityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StabilityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StopServiceDeploymentStopType.
    /// </summary>
    public class StopServiceDeploymentStopType : ConstantClass
    {

        /// <summary>
        /// Constant ABORT for StopServiceDeploymentStopType
        /// </summary>
        public static readonly StopServiceDeploymentStopType ABORT = new StopServiceDeploymentStopType("ABORT");
        /// <summary>
        /// Constant ROLLBACK for StopServiceDeploymentStopType
        /// </summary>
        public static readonly StopServiceDeploymentStopType ROLLBACK = new StopServiceDeploymentStopType("ROLLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopServiceDeploymentStopType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopServiceDeploymentStopType FindValue(string value)
        {
            return FindValue<StopServiceDeploymentStopType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopServiceDeploymentStopType(string value)
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
        /// Constant ContainerInstance for TargetType
        /// </summary>
        public static readonly TargetType ContainerInstance = new TargetType("container-instance");

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
    /// Constants used for properties of type TaskDefinitionFamilyStatus.
    /// </summary>
    public class TaskDefinitionFamilyStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskDefinitionFamilyStatus
        /// </summary>
        public static readonly TaskDefinitionFamilyStatus ACTIVE = new TaskDefinitionFamilyStatus("ACTIVE");
        /// <summary>
        /// Constant ALL for TaskDefinitionFamilyStatus
        /// </summary>
        public static readonly TaskDefinitionFamilyStatus ALL = new TaskDefinitionFamilyStatus("ALL");
        /// <summary>
        /// Constant INACTIVE for TaskDefinitionFamilyStatus
        /// </summary>
        public static readonly TaskDefinitionFamilyStatus INACTIVE = new TaskDefinitionFamilyStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionFamilyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionFamilyStatus FindValue(string value)
        {
            return FindValue<TaskDefinitionFamilyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionFamilyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionField.
    /// </summary>
    public class TaskDefinitionField : ConstantClass
    {

        /// <summary>
        /// Constant TAGS for TaskDefinitionField
        /// </summary>
        public static readonly TaskDefinitionField TAGS = new TaskDefinitionField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionField FindValue(string value)
        {
            return FindValue<TaskDefinitionField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionPlacementConstraintType.
    /// </summary>
    public class TaskDefinitionPlacementConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant MemberOf for TaskDefinitionPlacementConstraintType
        /// </summary>
        public static readonly TaskDefinitionPlacementConstraintType MemberOf = new TaskDefinitionPlacementConstraintType("memberOf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionPlacementConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionPlacementConstraintType FindValue(string value)
        {
            return FindValue<TaskDefinitionPlacementConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionPlacementConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionStatus.
    /// </summary>
    public class TaskDefinitionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus ACTIVE = new TaskDefinitionStatus("ACTIVE");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus DELETE_IN_PROGRESS = new TaskDefinitionStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant INACTIVE for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus INACTIVE = new TaskDefinitionStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionStatus FindValue(string value)
        {
            return FindValue<TaskDefinitionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskField.
    /// </summary>
    public class TaskField : ConstantClass
    {

        /// <summary>
        /// Constant TAGS for TaskField
        /// </summary>
        public static readonly TaskField TAGS = new TaskField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskField FindValue(string value)
        {
            return FindValue<TaskField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskFilesystemType.
    /// </summary>
    public class TaskFilesystemType : ConstantClass
    {

        /// <summary>
        /// Constant Ext3 for TaskFilesystemType
        /// </summary>
        public static readonly TaskFilesystemType Ext3 = new TaskFilesystemType("ext3");
        /// <summary>
        /// Constant Ext4 for TaskFilesystemType
        /// </summary>
        public static readonly TaskFilesystemType Ext4 = new TaskFilesystemType("ext4");
        /// <summary>
        /// Constant Ntfs for TaskFilesystemType
        /// </summary>
        public static readonly TaskFilesystemType Ntfs = new TaskFilesystemType("ntfs");
        /// <summary>
        /// Constant Xfs for TaskFilesystemType
        /// </summary>
        public static readonly TaskFilesystemType Xfs = new TaskFilesystemType("xfs");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskFilesystemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskFilesystemType FindValue(string value)
        {
            return FindValue<TaskFilesystemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskFilesystemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskSetField.
    /// </summary>
    public class TaskSetField : ConstantClass
    {

        /// <summary>
        /// Constant TAGS for TaskSetField
        /// </summary>
        public static readonly TaskSetField TAGS = new TaskSetField("TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskSetField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskSetField FindValue(string value)
        {
            return FindValue<TaskSetField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskSetField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStopCode.
    /// </summary>
    public class TaskStopCode : ConstantClass
    {

        /// <summary>
        /// Constant EssentialContainerExited for TaskStopCode
        /// </summary>
        public static readonly TaskStopCode EssentialContainerExited = new TaskStopCode("EssentialContainerExited");
        /// <summary>
        /// Constant ServiceSchedulerInitiated for TaskStopCode
        /// </summary>
        public static readonly TaskStopCode ServiceSchedulerInitiated = new TaskStopCode("ServiceSchedulerInitiated");
        /// <summary>
        /// Constant SpotInterruption for TaskStopCode
        /// </summary>
        public static readonly TaskStopCode SpotInterruption = new TaskStopCode("SpotInterruption");
        /// <summary>
        /// Constant TaskFailedToStart for TaskStopCode
        /// </summary>
        public static readonly TaskStopCode TaskFailedToStart = new TaskStopCode("TaskFailedToStart");
        /// <summary>
        /// Constant TerminationNotice for TaskStopCode
        /// </summary>
        public static readonly TaskStopCode TerminationNotice = new TaskStopCode("TerminationNotice");
        /// <summary>
        /// Constant UserInitiated for TaskStopCode
        /// </summary>
        public static readonly TaskStopCode UserInitiated = new TaskStopCode("UserInitiated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStopCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStopCode FindValue(string value)
        {
            return FindValue<TaskStopCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStopCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransportProtocol.
    /// </summary>
    public class TransportProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Tcp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Tcp = new TransportProtocol("tcp");
        /// <summary>
        /// Constant Udp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Udp = new TransportProtocol("udp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransportProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransportProtocol FindValue(string value)
        {
            return FindValue<TransportProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransportProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UlimitName.
    /// </summary>
    public class UlimitName : ConstantClass
    {

        /// <summary>
        /// Constant Core for UlimitName
        /// </summary>
        public static readonly UlimitName Core = new UlimitName("core");
        /// <summary>
        /// Constant Cpu for UlimitName
        /// </summary>
        public static readonly UlimitName Cpu = new UlimitName("cpu");
        /// <summary>
        /// Constant Data for UlimitName
        /// </summary>
        public static readonly UlimitName Data = new UlimitName("data");
        /// <summary>
        /// Constant Fsize for UlimitName
        /// </summary>
        public static readonly UlimitName Fsize = new UlimitName("fsize");
        /// <summary>
        /// Constant Locks for UlimitName
        /// </summary>
        public static readonly UlimitName Locks = new UlimitName("locks");
        /// <summary>
        /// Constant Memlock for UlimitName
        /// </summary>
        public static readonly UlimitName Memlock = new UlimitName("memlock");
        /// <summary>
        /// Constant Msgqueue for UlimitName
        /// </summary>
        public static readonly UlimitName Msgqueue = new UlimitName("msgqueue");
        /// <summary>
        /// Constant Nice for UlimitName
        /// </summary>
        public static readonly UlimitName Nice = new UlimitName("nice");
        /// <summary>
        /// Constant Nofile for UlimitName
        /// </summary>
        public static readonly UlimitName Nofile = new UlimitName("nofile");
        /// <summary>
        /// Constant Nproc for UlimitName
        /// </summary>
        public static readonly UlimitName Nproc = new UlimitName("nproc");
        /// <summary>
        /// Constant Rss for UlimitName
        /// </summary>
        public static readonly UlimitName Rss = new UlimitName("rss");
        /// <summary>
        /// Constant Rtprio for UlimitName
        /// </summary>
        public static readonly UlimitName Rtprio = new UlimitName("rtprio");
        /// <summary>
        /// Constant Rttime for UlimitName
        /// </summary>
        public static readonly UlimitName Rttime = new UlimitName("rttime");
        /// <summary>
        /// Constant Sigpending for UlimitName
        /// </summary>
        public static readonly UlimitName Sigpending = new UlimitName("sigpending");
        /// <summary>
        /// Constant Stack for UlimitName
        /// </summary>
        public static readonly UlimitName Stack = new UlimitName("stack");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UlimitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UlimitName FindValue(string value)
        {
            return FindValue<UlimitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UlimitName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VersionConsistency.
    /// </summary>
    public class VersionConsistency : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for VersionConsistency
        /// </summary>
        public static readonly VersionConsistency Disabled = new VersionConsistency("disabled");
        /// <summary>
        /// Constant Enabled for VersionConsistency
        /// </summary>
        public static readonly VersionConsistency Enabled = new VersionConsistency("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VersionConsistency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VersionConsistency FindValue(string value)
        {
            return FindValue<VersionConsistency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VersionConsistency(string value)
        {
            return FindValue(value);
        }
    }

}