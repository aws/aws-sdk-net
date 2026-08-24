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
    /// Constants used for properties of type ChannelDestinationType.
    /// </summary>
    public class ChannelDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant ICEBERG for ChannelDestinationType
        /// </summary>
        public static readonly ChannelDestinationType ICEBERG = new ChannelDestinationType("ICEBERG");
        /// <summary>
        /// Constant S3 for ChannelDestinationType
        /// </summary>
        public static readonly ChannelDestinationType S3 = new ChannelDestinationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelDestinationType FindValue(string value)
        {
            return FindValue<ChannelDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelStatus.
    /// </summary>
    public class ChannelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus ACTIVE = new ChannelStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATING = new ChannelStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus DELETING = new ChannelStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus FAILED = new ChannelStatus("FAILED");
        /// <summary>
        /// Constant SUSPENDED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus SUSPENDED = new ChannelStatus("SUSPENDED");
        /// <summary>
        /// Constant SUSPENDING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus SUSPENDING = new ChannelStatus("SUSPENDING");
        /// <summary>
        /// Constant UPDATING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus UPDATING = new ChannelStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelStatus FindValue(string value)
        {
            return FindValue<ChannelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelStatus(string value)
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
    /// Constants used for properties of type ConsumerGroupOffsetSyncMode.
    /// </summary>
    public class ConsumerGroupOffsetSyncMode : ConstantClass
    {

        /// <summary>
        /// Constant ENHANCED for ConsumerGroupOffsetSyncMode
        /// </summary>
        public static readonly ConsumerGroupOffsetSyncMode ENHANCED = new ConsumerGroupOffsetSyncMode("ENHANCED");
        /// <summary>
        /// Constant LEGACY for ConsumerGroupOffsetSyncMode
        /// </summary>
        public static readonly ConsumerGroupOffsetSyncMode LEGACY = new ConsumerGroupOffsetSyncMode("LEGACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConsumerGroupOffsetSyncMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConsumerGroupOffsetSyncMode FindValue(string value)
        {
            return FindValue<ConsumerGroupOffsetSyncMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConsumerGroupOffsetSyncMode(string value)
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
    /// Constants used for properties of type IcebergCompressionType.
    /// </summary>
    public class IcebergCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant SNAPPY for IcebergCompressionType
        /// </summary>
        public static readonly IcebergCompressionType SNAPPY = new IcebergCompressionType("SNAPPY");
        /// <summary>
        /// Constant ZSTD for IcebergCompressionType
        /// </summary>
        public static readonly IcebergCompressionType ZSTD = new IcebergCompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IcebergCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IcebergCompressionType FindValue(string value)
        {
            return FindValue<IcebergCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IcebergCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JwtSigningAlgorithm.
    /// </summary>
    public class JwtSigningAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant ES384 for JwtSigningAlgorithm
        /// </summary>
        public static readonly JwtSigningAlgorithm ES384 = new JwtSigningAlgorithm("ES384");
        /// <summary>
        /// Constant RS256 for JwtSigningAlgorithm
        /// </summary>
        public static readonly JwtSigningAlgorithm RS256 = new JwtSigningAlgorithm("RS256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JwtSigningAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JwtSigningAlgorithm FindValue(string value)
        {
            return FindValue<JwtSigningAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JwtSigningAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaClusterEncryptionInTransitType.
    /// </summary>
    public class KafkaClusterEncryptionInTransitType : ConstantClass
    {

        /// <summary>
        /// Constant TLS for KafkaClusterEncryptionInTransitType
        /// </summary>
        public static readonly KafkaClusterEncryptionInTransitType TLS = new KafkaClusterEncryptionInTransitType("TLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaClusterEncryptionInTransitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaClusterEncryptionInTransitType FindValue(string value)
        {
            return FindValue<KafkaClusterEncryptionInTransitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaClusterEncryptionInTransitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaClusterSaslScramMechanism.
    /// </summary>
    public class KafkaClusterSaslScramMechanism : ConstantClass
    {

        /// <summary>
        /// Constant SHA256 for KafkaClusterSaslScramMechanism
        /// </summary>
        public static readonly KafkaClusterSaslScramMechanism SHA256 = new KafkaClusterSaslScramMechanism("SHA256");
        /// <summary>
        /// Constant SHA512 for KafkaClusterSaslScramMechanism
        /// </summary>
        public static readonly KafkaClusterSaslScramMechanism SHA512 = new KafkaClusterSaslScramMechanism("SHA512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaClusterSaslScramMechanism(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaClusterSaslScramMechanism FindValue(string value)
        {
            return FindValue<KafkaClusterSaslScramMechanism>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaClusterSaslScramMechanism(string value)
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
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL for NetworkType
        /// </summary>
        public static readonly NetworkType DUAL = new NetworkType("DUAL");
        /// <summary>
        /// Constant IPV4 for NetworkType
        /// </summary>
        public static readonly NetworkType IPV4 = new NetworkType("IPV4");

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
    /// Constants used for properties of type PartitionStrategy.
    /// </summary>
    public class PartitionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant TIME_HOUR for PartitionStrategy
        /// </summary>
        public static readonly PartitionStrategy TIME_HOUR = new PartitionStrategy("TIME_HOUR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartitionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartitionStrategy FindValue(string value)
        {
            return FindValue<PartitionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartitionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RebalancingStatus.
    /// </summary>
    public class RebalancingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RebalancingStatus
        /// </summary>
        public static readonly RebalancingStatus ACTIVE = new RebalancingStatus("ACTIVE");
        /// <summary>
        /// Constant PAUSED for RebalancingStatus
        /// </summary>
        public static readonly RebalancingStatus PAUSED = new RebalancingStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RebalancingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RebalancingStatus FindValue(string value)
        {
            return FindValue<RebalancingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RebalancingStatus(string value)
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
    /// Constants used for properties of type S3CompressionType.
    /// </summary>
    public class S3CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for S3CompressionType
        /// </summary>
        public static readonly S3CompressionType GZIP = new S3CompressionType("GZIP");
        /// <summary>
        /// Constant NONE for S3CompressionType
        /// </summary>
        public static readonly S3CompressionType NONE = new S3CompressionType("NONE");
        /// <summary>
        /// Constant ZSTD for S3CompressionType
        /// </summary>
        public static readonly S3CompressionType ZSTD = new S3CompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3CompressionType FindValue(string value)
        {
            return FindValue<S3CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3StorageClass.
    /// </summary>
    public class S3StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant GLACIER_IR for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass GLACIER_IR = new S3StorageClass("GLACIER_IR");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass INTELLIGENT_TIERING = new S3StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant STANDARD for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass STANDARD = new S3StorageClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3StorageClass FindValue(string value)
        {
            return FindValue<S3StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3StorageClass(string value)
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
    /// Constants used for properties of type TokenEndpointAuthenticationMethod.
    /// </summary>
    public class TokenEndpointAuthenticationMethod : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for TokenEndpointAuthenticationMethod
        /// </summary>
        public static readonly TokenEndpointAuthenticationMethod BASIC = new TokenEndpointAuthenticationMethod("BASIC");
        /// <summary>
        /// Constant NONE for TokenEndpointAuthenticationMethod
        /// </summary>
        public static readonly TokenEndpointAuthenticationMethod NONE = new TokenEndpointAuthenticationMethod("NONE");
        /// <summary>
        /// Constant POST for TokenEndpointAuthenticationMethod
        /// </summary>
        public static readonly TokenEndpointAuthenticationMethod POST = new TokenEndpointAuthenticationMethod("POST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TokenEndpointAuthenticationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TokenEndpointAuthenticationMethod FindValue(string value)
        {
            return FindValue<TokenEndpointAuthenticationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TokenEndpointAuthenticationMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopicState.
    /// </summary>
    public class TopicState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TopicState
        /// </summary>
        public static readonly TopicState ACTIVE = new TopicState("ACTIVE");
        /// <summary>
        /// Constant CREATING for TopicState
        /// </summary>
        public static readonly TopicState CREATING = new TopicState("CREATING");
        /// <summary>
        /// Constant DELETING for TopicState
        /// </summary>
        public static readonly TopicState DELETING = new TopicState("DELETING");
        /// <summary>
        /// Constant UPDATING for TopicState
        /// </summary>
        public static readonly TopicState UPDATING = new TopicState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TopicState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopicState FindValue(string value)
        {
            return FindValue<TopicState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TopicState(string value)
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
    /// Constants used for properties of type ValueConverter.
    /// </summary>
    public class ValueConverter : ConstantClass
    {

        /// <summary>
        /// Constant BYTE_ARRAY for ValueConverter
        /// </summary>
        public static readonly ValueConverter BYTE_ARRAY = new ValueConverter("BYTE_ARRAY");
        /// <summary>
        /// Constant JSON for ValueConverter
        /// </summary>
        public static readonly ValueConverter JSON = new ValueConverter("JSON");
        /// <summary>
        /// Constant JSON_SCHEMA_GSR for ValueConverter
        /// </summary>
        public static readonly ValueConverter JSON_SCHEMA_GSR = new ValueConverter("JSON_SCHEMA_GSR");
        /// <summary>
        /// Constant STRING for ValueConverter
        /// </summary>
        public static readonly ValueConverter STRING = new ValueConverter("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValueConverter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValueConverter FindValue(string value)
        {
            return FindValue<ValueConverter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValueConverter(string value)
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