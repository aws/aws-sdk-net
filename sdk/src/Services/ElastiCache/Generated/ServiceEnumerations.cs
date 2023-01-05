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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElastiCache
{

    /// <summary>
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant Iam for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType Iam = new AuthenticationType("iam");
        /// <summary>
        /// Constant NoPassword for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType NoPassword = new AuthenticationType("no-password");
        /// <summary>
        /// Constant Password for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType Password = new AuthenticationType("password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthTokenUpdateStatus.
    /// </summary>
    public class AuthTokenUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ROTATING for AuthTokenUpdateStatus
        /// </summary>
        public static readonly AuthTokenUpdateStatus ROTATING = new AuthTokenUpdateStatus("ROTATING");
        /// <summary>
        /// Constant SETTING for AuthTokenUpdateStatus
        /// </summary>
        public static readonly AuthTokenUpdateStatus SETTING = new AuthTokenUpdateStatus("SETTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthTokenUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthTokenUpdateStatus FindValue(string value)
        {
            return FindValue<AuthTokenUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthTokenUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthTokenUpdateStrategyType.
    /// </summary>
    public class AuthTokenUpdateStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for AuthTokenUpdateStrategyType
        /// </summary>
        public static readonly AuthTokenUpdateStrategyType DELETE = new AuthTokenUpdateStrategyType("DELETE");
        /// <summary>
        /// Constant ROTATE for AuthTokenUpdateStrategyType
        /// </summary>
        public static readonly AuthTokenUpdateStrategyType ROTATE = new AuthTokenUpdateStrategyType("ROTATE");
        /// <summary>
        /// Constant SET for AuthTokenUpdateStrategyType
        /// </summary>
        public static readonly AuthTokenUpdateStrategyType SET = new AuthTokenUpdateStrategyType("SET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthTokenUpdateStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthTokenUpdateStrategyType FindValue(string value)
        {
            return FindValue<AuthTokenUpdateStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthTokenUpdateStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomaticFailoverStatus.
    /// </summary>
    public class AutomaticFailoverStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Disabled = new AutomaticFailoverStatus("disabled");
        /// <summary>
        /// Constant Disabling for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Disabling = new AutomaticFailoverStatus("disabling");
        /// <summary>
        /// Constant Enabled for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Enabled = new AutomaticFailoverStatus("enabled");
        /// <summary>
        /// Constant Enabling for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Enabling = new AutomaticFailoverStatus("enabling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomaticFailoverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomaticFailoverStatus FindValue(string value)
        {
            return FindValue<AutomaticFailoverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomaticFailoverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AZMode.
    /// </summary>
    public class AZMode : ConstantClass
    {

        /// <summary>
        /// Constant CrossAz for AZMode
        /// </summary>
        public static readonly AZMode CrossAz = new AZMode("cross-az");
        /// <summary>
        /// Constant SingleAz for AZMode
        /// </summary>
        public static readonly AZMode SingleAz = new AZMode("single-az");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AZMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AZMode FindValue(string value)
        {
            return FindValue<AZMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AZMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant Immediate for ChangeType
        /// </summary>
        public static readonly ChangeType Immediate = new ChangeType("immediate");
        /// <summary>
        /// Constant RequiresReboot for ChangeType
        /// </summary>
        public static readonly ChangeType RequiresReboot = new ChangeType("requires-reboot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataTieringStatus.
    /// </summary>
    public class DataTieringStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for DataTieringStatus
        /// </summary>
        public static readonly DataTieringStatus Disabled = new DataTieringStatus("disabled");
        /// <summary>
        /// Constant Enabled for DataTieringStatus
        /// </summary>
        public static readonly DataTieringStatus Enabled = new DataTieringStatus("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataTieringStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataTieringStatus FindValue(string value)
        {
            return FindValue<DataTieringStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataTieringStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DestinationType.
    /// </summary>
    public class DestinationType : ConstantClass
    {

        /// <summary>
        /// Constant CloudwatchLogs for DestinationType
        /// </summary>
        public static readonly DestinationType CloudwatchLogs = new DestinationType("cloudwatch-logs");
        /// <summary>
        /// Constant KinesisFirehose for DestinationType
        /// </summary>
        public static readonly DestinationType KinesisFirehose = new DestinationType("kinesis-firehose");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationType FindValue(string value)
        {
            return FindValue<DestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputAuthenticationType.
    /// </summary>
    public class InputAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant Iam for InputAuthenticationType
        /// </summary>
        public static readonly InputAuthenticationType Iam = new InputAuthenticationType("iam");
        /// <summary>
        /// Constant NoPasswordRequired for InputAuthenticationType
        /// </summary>
        public static readonly InputAuthenticationType NoPasswordRequired = new InputAuthenticationType("no-password-required");
        /// <summary>
        /// Constant Password for InputAuthenticationType
        /// </summary>
        public static readonly InputAuthenticationType Password = new InputAuthenticationType("password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputAuthenticationType FindValue(string value)
        {
            return FindValue<InputAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpDiscovery.
    /// </summary>
    public class IpDiscovery : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for IpDiscovery
        /// </summary>
        public static readonly IpDiscovery Ipv4 = new IpDiscovery("ipv4");
        /// <summary>
        /// Constant Ipv6 for IpDiscovery
        /// </summary>
        public static readonly IpDiscovery Ipv6 = new IpDiscovery("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpDiscovery(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpDiscovery FindValue(string value)
        {
            return FindValue<IpDiscovery>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpDiscovery(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDeliveryConfigurationStatus.
    /// </summary>
    public class LogDeliveryConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for LogDeliveryConfigurationStatus
        /// </summary>
        public static readonly LogDeliveryConfigurationStatus Active = new LogDeliveryConfigurationStatus("active");
        /// <summary>
        /// Constant Disabling for LogDeliveryConfigurationStatus
        /// </summary>
        public static readonly LogDeliveryConfigurationStatus Disabling = new LogDeliveryConfigurationStatus("disabling");
        /// <summary>
        /// Constant Enabling for LogDeliveryConfigurationStatus
        /// </summary>
        public static readonly LogDeliveryConfigurationStatus Enabling = new LogDeliveryConfigurationStatus("enabling");
        /// <summary>
        /// Constant Error for LogDeliveryConfigurationStatus
        /// </summary>
        public static readonly LogDeliveryConfigurationStatus Error = new LogDeliveryConfigurationStatus("error");
        /// <summary>
        /// Constant Modifying for LogDeliveryConfigurationStatus
        /// </summary>
        public static readonly LogDeliveryConfigurationStatus Modifying = new LogDeliveryConfigurationStatus("modifying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDeliveryConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDeliveryConfigurationStatus FindValue(string value)
        {
            return FindValue<LogDeliveryConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDeliveryConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogFormat.
    /// </summary>
    public class LogFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for LogFormat
        /// </summary>
        public static readonly LogFormat Json = new LogFormat("json");
        /// <summary>
        /// Constant Text for LogFormat
        /// </summary>
        public static readonly LogFormat Text = new LogFormat("text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogFormat FindValue(string value)
        {
            return FindValue<LogFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant EngineLog for LogType
        /// </summary>
        public static readonly LogType EngineLog = new LogType("engine-log");
        /// <summary>
        /// Constant SlowLog for LogType
        /// </summary>
        public static readonly LogType SlowLog = new LogType("slow-log");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultiAZStatus.
    /// </summary>
    public class MultiAZStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for MultiAZStatus
        /// </summary>
        public static readonly MultiAZStatus Disabled = new MultiAZStatus("disabled");
        /// <summary>
        /// Constant Enabled for MultiAZStatus
        /// </summary>
        public static readonly MultiAZStatus Enabled = new MultiAZStatus("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultiAZStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultiAZStatus FindValue(string value)
        {
            return FindValue<MultiAZStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultiAZStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {

        /// <summary>
        /// Constant Dual_stack for NetworkType
        /// </summary>
        public static readonly NetworkType Dual_stack = new NetworkType("dual_stack");
        /// <summary>
        /// Constant Ipv4 for NetworkType
        /// </summary>
        public static readonly NetworkType Ipv4 = new NetworkType("ipv4");
        /// <summary>
        /// Constant Ipv6 for NetworkType
        /// </summary>
        public static readonly NetworkType Ipv6 = new NetworkType("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeUpdateInitiatedBy.
    /// </summary>
    public class NodeUpdateInitiatedBy : ConstantClass
    {

        /// <summary>
        /// Constant Customer for NodeUpdateInitiatedBy
        /// </summary>
        public static readonly NodeUpdateInitiatedBy Customer = new NodeUpdateInitiatedBy("customer");
        /// <summary>
        /// Constant System for NodeUpdateInitiatedBy
        /// </summary>
        public static readonly NodeUpdateInitiatedBy System = new NodeUpdateInitiatedBy("system");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeUpdateInitiatedBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeUpdateInitiatedBy FindValue(string value)
        {
            return FindValue<NodeUpdateInitiatedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeUpdateInitiatedBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeUpdateStatus.
    /// </summary>
    public class NodeUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for NodeUpdateStatus
        /// </summary>
        public static readonly NodeUpdateStatus Complete = new NodeUpdateStatus("complete");
        /// <summary>
        /// Constant InProgress for NodeUpdateStatus
        /// </summary>
        public static readonly NodeUpdateStatus InProgress = new NodeUpdateStatus("in-progress");
        /// <summary>
        /// Constant NotApplied for NodeUpdateStatus
        /// </summary>
        public static readonly NodeUpdateStatus NotApplied = new NodeUpdateStatus("not-applied");
        /// <summary>
        /// Constant Stopped for NodeUpdateStatus
        /// </summary>
        public static readonly NodeUpdateStatus Stopped = new NodeUpdateStatus("stopped");
        /// <summary>
        /// Constant Stopping for NodeUpdateStatus
        /// </summary>
        public static readonly NodeUpdateStatus Stopping = new NodeUpdateStatus("stopping");
        /// <summary>
        /// Constant WaitingToStart for NodeUpdateStatus
        /// </summary>
        public static readonly NodeUpdateStatus WaitingToStart = new NodeUpdateStatus("waiting-to-start");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeUpdateStatus FindValue(string value)
        {
            return FindValue<NodeUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutpostMode.
    /// </summary>
    public class OutpostMode : ConstantClass
    {

        /// <summary>
        /// Constant CrossOutpost for OutpostMode
        /// </summary>
        public static readonly OutpostMode CrossOutpost = new OutpostMode("cross-outpost");
        /// <summary>
        /// Constant SingleOutpost for OutpostMode
        /// </summary>
        public static readonly OutpostMode SingleOutpost = new OutpostMode("single-outpost");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutpostMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutpostMode FindValue(string value)
        {
            return FindValue<OutpostMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutpostMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PendingAutomaticFailoverStatus.
    /// </summary>
    public class PendingAutomaticFailoverStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for PendingAutomaticFailoverStatus
        /// </summary>
        public static readonly PendingAutomaticFailoverStatus Disabled = new PendingAutomaticFailoverStatus("disabled");
        /// <summary>
        /// Constant Enabled for PendingAutomaticFailoverStatus
        /// </summary>
        public static readonly PendingAutomaticFailoverStatus Enabled = new PendingAutomaticFailoverStatus("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PendingAutomaticFailoverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PendingAutomaticFailoverStatus FindValue(string value)
        {
            return FindValue<PendingAutomaticFailoverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PendingAutomaticFailoverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceUpdateSeverity.
    /// </summary>
    public class ServiceUpdateSeverity : ConstantClass
    {

        /// <summary>
        /// Constant Critical for ServiceUpdateSeverity
        /// </summary>
        public static readonly ServiceUpdateSeverity Critical = new ServiceUpdateSeverity("critical");
        /// <summary>
        /// Constant Important for ServiceUpdateSeverity
        /// </summary>
        public static readonly ServiceUpdateSeverity Important = new ServiceUpdateSeverity("important");
        /// <summary>
        /// Constant Low for ServiceUpdateSeverity
        /// </summary>
        public static readonly ServiceUpdateSeverity Low = new ServiceUpdateSeverity("low");
        /// <summary>
        /// Constant Medium for ServiceUpdateSeverity
        /// </summary>
        public static readonly ServiceUpdateSeverity Medium = new ServiceUpdateSeverity("medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceUpdateSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceUpdateSeverity FindValue(string value)
        {
            return FindValue<ServiceUpdateSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceUpdateSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceUpdateStatus.
    /// </summary>
    public class ServiceUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus Available = new ServiceUpdateStatus("available");
        /// <summary>
        /// Constant Cancelled for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus Cancelled = new ServiceUpdateStatus("cancelled");
        /// <summary>
        /// Constant Expired for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus Expired = new ServiceUpdateStatus("expired");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceUpdateStatus FindValue(string value)
        {
            return FindValue<ServiceUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceUpdateType.
    /// </summary>
    public class ServiceUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant SecurityUpdate for ServiceUpdateType
        /// </summary>
        public static readonly ServiceUpdateType SecurityUpdate = new ServiceUpdateType("security-update");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceUpdateType FindValue(string value)
        {
            return FindValue<ServiceUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceUpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlaMet.
    /// </summary>
    public class SlaMet : ConstantClass
    {

        /// <summary>
        /// Constant NA for SlaMet
        /// </summary>
        public static readonly SlaMet NA = new SlaMet("n/a");
        /// <summary>
        /// Constant No for SlaMet
        /// </summary>
        public static readonly SlaMet No = new SlaMet("no");
        /// <summary>
        /// Constant Yes for SlaMet
        /// </summary>
        public static readonly SlaMet Yes = new SlaMet("yes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlaMet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlaMet FindValue(string value)
        {
            return FindValue<SlaMet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlaMet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant CacheCluster for SourceType
        /// </summary>
        public static readonly SourceType CacheCluster = new SourceType("cache-cluster");
        /// <summary>
        /// Constant CacheParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType CacheParameterGroup = new SourceType("cache-parameter-group");
        /// <summary>
        /// Constant CacheSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType CacheSecurityGroup = new SourceType("cache-security-group");
        /// <summary>
        /// Constant CacheSubnetGroup for SourceType
        /// </summary>
        public static readonly SourceType CacheSubnetGroup = new SourceType("cache-subnet-group");
        /// <summary>
        /// Constant ReplicationGroup for SourceType
        /// </summary>
        public static readonly SourceType ReplicationGroup = new SourceType("replication-group");
        /// <summary>
        /// Constant User for SourceType
        /// </summary>
        public static readonly SourceType User = new SourceType("user");
        /// <summary>
        /// Constant UserGroup for SourceType
        /// </summary>
        public static readonly SourceType UserGroup = new SourceType("user-group");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitEncryptionMode.
    /// </summary>
    public class TransitEncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant Preferred for TransitEncryptionMode
        /// </summary>
        public static readonly TransitEncryptionMode Preferred = new TransitEncryptionMode("preferred");
        /// <summary>
        /// Constant Required for TransitEncryptionMode
        /// </summary>
        public static readonly TransitEncryptionMode Required = new TransitEncryptionMode("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitEncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitEncryptionMode FindValue(string value)
        {
            return FindValue<TransitEncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitEncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateActionStatus.
    /// </summary>
    public class UpdateActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus Complete = new UpdateActionStatus("complete");
        /// <summary>
        /// Constant InProgress for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus InProgress = new UpdateActionStatus("in-progress");
        /// <summary>
        /// Constant NotApplicable for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus NotApplicable = new UpdateActionStatus("not-applicable");
        /// <summary>
        /// Constant NotApplied for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus NotApplied = new UpdateActionStatus("not-applied");
        /// <summary>
        /// Constant Scheduled for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus Scheduled = new UpdateActionStatus("scheduled");
        /// <summary>
        /// Constant Scheduling for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus Scheduling = new UpdateActionStatus("scheduling");
        /// <summary>
        /// Constant Stopped for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus Stopped = new UpdateActionStatus("stopped");
        /// <summary>
        /// Constant Stopping for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus Stopping = new UpdateActionStatus("stopping");
        /// <summary>
        /// Constant WaitingToStart for UpdateActionStatus
        /// </summary>
        public static readonly UpdateActionStatus WaitingToStart = new UpdateActionStatus("waiting-to-start");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateActionStatus FindValue(string value)
        {
            return FindValue<UpdateActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateActionStatus(string value)
        {
            return FindValue(value);
        }
    }

}