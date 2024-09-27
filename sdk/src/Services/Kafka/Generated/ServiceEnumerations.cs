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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Kafka
{

    /// <summary>
    /// Constants used for properties of type BrokerAZDistribution.
    /// </summary>
    public class BrokerAZDistribution : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for BrokerAZDistribution
        /// </summary>
        public static readonly BrokerAZDistribution DEFAULT = new BrokerAZDistribution("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrokerAZDistribution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrokerAZDistribution FindValue(string value)
        {
            return FindValue<BrokerAZDistribution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrokerAZDistribution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientBroker.
    /// </summary>
    public class ClientBroker : ConstantClass
    {

        /// <summary>
        /// Constant PLAINTEXT for ClientBroker
        /// </summary>
        public static readonly ClientBroker PLAINTEXT = new ClientBroker("PLAINTEXT");
        /// <summary>
        /// Constant TLS for ClientBroker
        /// </summary>
        public static readonly ClientBroker TLS = new ClientBroker("TLS");
        /// <summary>
        /// Constant TLS_PLAINTEXT for ClientBroker
        /// </summary>
        public static readonly ClientBroker TLS_PLAINTEXT = new ClientBroker("TLS_PLAINTEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientBroker(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientBroker FindValue(string value)
        {
            return FindValue<ClientBroker>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientBroker(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterState.
    /// </summary>
    public class ClusterState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterState
        /// </summary>
        public static readonly ClusterState ACTIVE = new ClusterState("ACTIVE");
        /// <summary>
        /// Constant CREATING for ClusterState
        /// </summary>
        public static readonly ClusterState CREATING = new ClusterState("CREATING");
        /// <summary>
        /// Constant DELETING for ClusterState
        /// </summary>
        public static readonly ClusterState DELETING = new ClusterState("DELETING");
        /// <summary>
        /// Constant FAILED for ClusterState
        /// </summary>
        public static readonly ClusterState FAILED = new ClusterState("FAILED");
        /// <summary>
        /// Constant HEALING for ClusterState
        /// </summary>
        public static readonly ClusterState HEALING = new ClusterState("HEALING");
        /// <summary>
        /// Constant MAINTENANCE for ClusterState
        /// </summary>
        public static readonly ClusterState MAINTENANCE = new ClusterState("MAINTENANCE");
        /// <summary>
        /// Constant REBOOTING_BROKER for ClusterState
        /// </summary>
        public static readonly ClusterState REBOOTING_BROKER = new ClusterState("REBOOTING_BROKER");
        /// <summary>
        /// Constant UPDATING for ClusterState
        /// </summary>
        public static readonly ClusterState UPDATING = new ClusterState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterState FindValue(string value)
        {
            return FindValue<ClusterState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterType.
    /// </summary>
    public class ClusterType : ConstantClass
    {

        /// <summary>
        /// Constant PROVISIONED for ClusterType
        /// </summary>
        public static readonly ClusterType PROVISIONED = new ClusterType("PROVISIONED");
        /// <summary>
        /// Constant SERVERLESS for ClusterType
        /// </summary>
        public static readonly ClusterType SERVERLESS = new ClusterType("SERVERLESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterType FindValue(string value)
        {
            return FindValue<ClusterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationState.
    /// </summary>
    public class ConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState ACTIVE = new ConfigurationState("ACTIVE");
        /// <summary>
        /// Constant DELETE_FAILED for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState DELETE_FAILED = new ConfigurationState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState DELETING = new ConfigurationState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationState FindValue(string value)
        {
            return FindValue<ConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerActionStatus.
    /// </summary>
    public class CustomerActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_RECOMMENDED for CustomerActionStatus
        /// </summary>
        public static readonly CustomerActionStatus ACTION_RECOMMENDED = new CustomerActionStatus("ACTION_RECOMMENDED");
        /// <summary>
        /// Constant CRITICAL_ACTION_REQUIRED for CustomerActionStatus
        /// </summary>
        public static readonly CustomerActionStatus CRITICAL_ACTION_REQUIRED = new CustomerActionStatus("CRITICAL_ACTION_REQUIRED");
        /// <summary>
        /// Constant NONE for CustomerActionStatus
        /// </summary>
        public static readonly CustomerActionStatus NONE = new CustomerActionStatus("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerActionStatus FindValue(string value)
        {
            return FindValue<CustomerActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnhancedMonitoring.
    /// </summary>
    public class EnhancedMonitoring : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for EnhancedMonitoring
        /// </summary>
        public static readonly EnhancedMonitoring DEFAULT = new EnhancedMonitoring("DEFAULT");
        /// <summary>
        /// Constant PER_BROKER for EnhancedMonitoring
        /// </summary>
        public static readonly EnhancedMonitoring PER_BROKER = new EnhancedMonitoring("PER_BROKER");
        /// <summary>
        /// Constant PER_TOPIC_PER_BROKER for EnhancedMonitoring
        /// </summary>
        public static readonly EnhancedMonitoring PER_TOPIC_PER_BROKER = new EnhancedMonitoring("PER_TOPIC_PER_BROKER");
        /// <summary>
        /// Constant PER_TOPIC_PER_PARTITION for EnhancedMonitoring
        /// </summary>
        public static readonly EnhancedMonitoring PER_TOPIC_PER_PARTITION = new EnhancedMonitoring("PER_TOPIC_PER_PARTITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnhancedMonitoring(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnhancedMonitoring FindValue(string value)
        {
            return FindValue<EnhancedMonitoring>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnhancedMonitoring(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaVersionStatus.
    /// </summary>
    public class KafkaVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for KafkaVersionStatus
        /// </summary>
        public static readonly KafkaVersionStatus ACTIVE = new KafkaVersionStatus("ACTIVE");
        /// <summary>
        /// Constant DEPRECATED for KafkaVersionStatus
        /// </summary>
        public static readonly KafkaVersionStatus DEPRECATED = new KafkaVersionStatus("DEPRECATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaVersionStatus FindValue(string value)
        {
            return FindValue<KafkaVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeType.
    /// </summary>
    public class NodeType : ConstantClass
    {

        /// <summary>
        /// Constant BROKER for NodeType
        /// </summary>
        public static readonly NodeType BROKER = new NodeType("BROKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeType FindValue(string value)
        {
            return FindValue<NodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationStartingPositionType.
    /// </summary>
    public class ReplicationStartingPositionType : ConstantClass
    {

        /// <summary>
        /// Constant EARLIEST for ReplicationStartingPositionType
        /// </summary>
        public static readonly ReplicationStartingPositionType EARLIEST = new ReplicationStartingPositionType("EARLIEST");
        /// <summary>
        /// Constant LATEST for ReplicationStartingPositionType
        /// </summary>
        public static readonly ReplicationStartingPositionType LATEST = new ReplicationStartingPositionType("LATEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationStartingPositionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationStartingPositionType FindValue(string value)
        {
            return FindValue<ReplicationStartingPositionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationStartingPositionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationTopicNameConfigurationType.
    /// </summary>
    public class ReplicationTopicNameConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant IDENTICAL for ReplicationTopicNameConfigurationType
        /// </summary>
        public static readonly ReplicationTopicNameConfigurationType IDENTICAL = new ReplicationTopicNameConfigurationType("IDENTICAL");
        /// <summary>
        /// Constant PREFIXED_WITH_SOURCE_CLUSTER_ALIAS for ReplicationTopicNameConfigurationType
        /// </summary>
        public static readonly ReplicationTopicNameConfigurationType PREFIXED_WITH_SOURCE_CLUSTER_ALIAS = new ReplicationTopicNameConfigurationType("PREFIXED_WITH_SOURCE_CLUSTER_ALIAS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationTopicNameConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationTopicNameConfigurationType FindValue(string value)
        {
            return FindValue<ReplicationTopicNameConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationTopicNameConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicatorState.
    /// </summary>
    public class ReplicatorState : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for ReplicatorState
        /// </summary>
        public static readonly ReplicatorState CREATING = new ReplicatorState("CREATING");
        /// <summary>
        /// Constant DELETING for ReplicatorState
        /// </summary>
        public static readonly ReplicatorState DELETING = new ReplicatorState("DELETING");
        /// <summary>
        /// Constant FAILED for ReplicatorState
        /// </summary>
        public static readonly ReplicatorState FAILED = new ReplicatorState("FAILED");
        /// <summary>
        /// Constant RUNNING for ReplicatorState
        /// </summary>
        public static readonly ReplicatorState RUNNING = new ReplicatorState("RUNNING");
        /// <summary>
        /// Constant UPDATING for ReplicatorState
        /// </summary>
        public static readonly ReplicatorState UPDATING = new ReplicatorState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicatorState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicatorState FindValue(string value)
        {
            return FindValue<ReplicatorState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicatorState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageMode.
    /// </summary>
    public class StorageMode : ConstantClass
    {

        /// <summary>
        /// Constant LOCAL for StorageMode
        /// </summary>
        public static readonly StorageMode LOCAL = new StorageMode("LOCAL");
        /// <summary>
        /// Constant TIERED for StorageMode
        /// </summary>
        public static readonly StorageMode TIERED = new StorageMode("TIERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageMode FindValue(string value)
        {
            return FindValue<StorageMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetCompressionType.
    /// </summary>
    public class TargetCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for TargetCompressionType
        /// </summary>
        public static readonly TargetCompressionType GZIP = new TargetCompressionType("GZIP");
        /// <summary>
        /// Constant LZ4 for TargetCompressionType
        /// </summary>
        public static readonly TargetCompressionType LZ4 = new TargetCompressionType("LZ4");
        /// <summary>
        /// Constant NONE for TargetCompressionType
        /// </summary>
        public static readonly TargetCompressionType NONE = new TargetCompressionType("NONE");
        /// <summary>
        /// Constant SNAPPY for TargetCompressionType
        /// </summary>
        public static readonly TargetCompressionType SNAPPY = new TargetCompressionType("SNAPPY");
        /// <summary>
        /// Constant ZSTD for TargetCompressionType
        /// </summary>
        public static readonly TargetCompressionType ZSTD = new TargetCompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetCompressionType FindValue(string value)
        {
            return FindValue<TargetCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserIdentityType.
    /// </summary>
    public class UserIdentityType : ConstantClass
    {

        /// <summary>
        /// Constant AWSACCOUNT for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AWSACCOUNT = new UserIdentityType("AWSACCOUNT");
        /// <summary>
        /// Constant AWSSERVICE for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AWSSERVICE = new UserIdentityType("AWSSERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserIdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserIdentityType FindValue(string value)
        {
            return FindValue<UserIdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserIdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcConnectionState.
    /// </summary>
    public class VpcConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState AVAILABLE = new VpcConnectionState("AVAILABLE");
        /// <summary>
        /// Constant CREATING for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState CREATING = new VpcConnectionState("CREATING");
        /// <summary>
        /// Constant DEACTIVATING for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState DEACTIVATING = new VpcConnectionState("DEACTIVATING");
        /// <summary>
        /// Constant DELETING for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState DELETING = new VpcConnectionState("DELETING");
        /// <summary>
        /// Constant FAILED for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState FAILED = new VpcConnectionState("FAILED");
        /// <summary>
        /// Constant INACTIVE for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState INACTIVE = new VpcConnectionState("INACTIVE");
        /// <summary>
        /// Constant REJECTED for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState REJECTED = new VpcConnectionState("REJECTED");
        /// <summary>
        /// Constant REJECTING for VpcConnectionState
        /// </summary>
        public static readonly VpcConnectionState REJECTING = new VpcConnectionState("REJECTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcConnectionState FindValue(string value)
        {
            return FindValue<VpcConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcConnectionState(string value)
        {
            return FindValue(value);
        }
    }

}