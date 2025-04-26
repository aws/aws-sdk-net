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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationAutoScaling
{

    /// <summary>
    /// Constants used for properties of type AdjustmentType.
    /// </summary>
    public class AdjustmentType : ConstantClass
    {

        /// <summary>
        /// Constant ChangeInCapacity for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType ChangeInCapacity = new AdjustmentType("ChangeInCapacity");
        /// <summary>
        /// Constant ExactCapacity for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType ExactCapacity = new AdjustmentType("ExactCapacity");
        /// <summary>
        /// Constant PercentChangeInCapacity for AdjustmentType
        /// </summary>
        public static readonly AdjustmentType PercentChangeInCapacity = new AdjustmentType("PercentChangeInCapacity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdjustmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdjustmentType FindValue(string value)
        {
            return FindValue<AdjustmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdjustmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricAggregationType.
    /// </summary>
    public class MetricAggregationType : ConstantClass
    {

        /// <summary>
        /// Constant Average for MetricAggregationType
        /// </summary>
        public static readonly MetricAggregationType Average = new MetricAggregationType("Average");
        /// <summary>
        /// Constant Maximum for MetricAggregationType
        /// </summary>
        public static readonly MetricAggregationType Maximum = new MetricAggregationType("Maximum");
        /// <summary>
        /// Constant Minimum for MetricAggregationType
        /// </summary>
        public static readonly MetricAggregationType Minimum = new MetricAggregationType("Minimum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricAggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricAggregationType FindValue(string value)
        {
            return FindValue<MetricAggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricAggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricStatistic.
    /// </summary>
    public class MetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Average = new MetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Maximum = new MetricStatistic("Maximum");
        /// <summary>
        /// Constant Minimum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Minimum = new MetricStatistic("Minimum");
        /// <summary>
        /// Constant SampleCount for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic SampleCount = new MetricStatistic("SampleCount");
        /// <summary>
        /// Constant Sum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Sum = new MetricStatistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricStatistic FindValue(string value)
        {
            return FindValue<MetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricType.
    /// </summary>
    public class MetricType : ConstantClass
    {

        /// <summary>
        /// Constant ALBRequestCountPerTarget for MetricType
        /// </summary>
        public static readonly MetricType ALBRequestCountPerTarget = new MetricType("ALBRequestCountPerTarget");
        /// <summary>
        /// Constant AppStreamAverageCapacityUtilization for MetricType
        /// </summary>
        public static readonly MetricType AppStreamAverageCapacityUtilization = new MetricType("AppStreamAverageCapacityUtilization");
        /// <summary>
        /// Constant CassandraReadCapacityUtilization for MetricType
        /// </summary>
        public static readonly MetricType CassandraReadCapacityUtilization = new MetricType("CassandraReadCapacityUtilization");
        /// <summary>
        /// Constant CassandraWriteCapacityUtilization for MetricType
        /// </summary>
        public static readonly MetricType CassandraWriteCapacityUtilization = new MetricType("CassandraWriteCapacityUtilization");
        /// <summary>
        /// Constant ComprehendInferenceUtilization for MetricType
        /// </summary>
        public static readonly MetricType ComprehendInferenceUtilization = new MetricType("ComprehendInferenceUtilization");
        /// <summary>
        /// Constant DynamoDBReadCapacityUtilization for MetricType
        /// </summary>
        public static readonly MetricType DynamoDBReadCapacityUtilization = new MetricType("DynamoDBReadCapacityUtilization");
        /// <summary>
        /// Constant DynamoDBWriteCapacityUtilization for MetricType
        /// </summary>
        public static readonly MetricType DynamoDBWriteCapacityUtilization = new MetricType("DynamoDBWriteCapacityUtilization");
        /// <summary>
        /// Constant EC2SpotFleetRequestAverageCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType EC2SpotFleetRequestAverageCPUUtilization = new MetricType("EC2SpotFleetRequestAverageCPUUtilization");
        /// <summary>
        /// Constant EC2SpotFleetRequestAverageNetworkIn for MetricType
        /// </summary>
        public static readonly MetricType EC2SpotFleetRequestAverageNetworkIn = new MetricType("EC2SpotFleetRequestAverageNetworkIn");
        /// <summary>
        /// Constant EC2SpotFleetRequestAverageNetworkOut for MetricType
        /// </summary>
        public static readonly MetricType EC2SpotFleetRequestAverageNetworkOut = new MetricType("EC2SpotFleetRequestAverageNetworkOut");
        /// <summary>
        /// Constant ECSServiceAverageCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType ECSServiceAverageCPUUtilization = new MetricType("ECSServiceAverageCPUUtilization");
        /// <summary>
        /// Constant ECSServiceAverageMemoryUtilization for MetricType
        /// </summary>
        public static readonly MetricType ECSServiceAverageMemoryUtilization = new MetricType("ECSServiceAverageMemoryUtilization");
        /// <summary>
        /// Constant ElastiCacheDatabaseCapacityUsageCountedForEvictPercentage for MetricType
        /// </summary>
        public static readonly MetricType ElastiCacheDatabaseCapacityUsageCountedForEvictPercentage = new MetricType("ElastiCacheDatabaseCapacityUsageCountedForEvictPercentage");
        /// <summary>
        /// Constant ElastiCacheDatabaseMemoryUsageCountedForEvictPercentage for MetricType
        /// </summary>
        public static readonly MetricType ElastiCacheDatabaseMemoryUsageCountedForEvictPercentage = new MetricType("ElastiCacheDatabaseMemoryUsageCountedForEvictPercentage");
        /// <summary>
        /// Constant ElastiCacheDatabaseMemoryUsagePercentage for MetricType
        /// </summary>
        public static readonly MetricType ElastiCacheDatabaseMemoryUsagePercentage = new MetricType("ElastiCacheDatabaseMemoryUsagePercentage");
        /// <summary>
        /// Constant ElastiCacheEngineCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType ElastiCacheEngineCPUUtilization = new MetricType("ElastiCacheEngineCPUUtilization");
        /// <summary>
        /// Constant ElastiCachePrimaryEngineCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType ElastiCachePrimaryEngineCPUUtilization = new MetricType("ElastiCachePrimaryEngineCPUUtilization");
        /// <summary>
        /// Constant ElastiCacheReplicaEngineCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType ElastiCacheReplicaEngineCPUUtilization = new MetricType("ElastiCacheReplicaEngineCPUUtilization");
        /// <summary>
        /// Constant KafkaBrokerStorageUtilization for MetricType
        /// </summary>
        public static readonly MetricType KafkaBrokerStorageUtilization = new MetricType("KafkaBrokerStorageUtilization");
        /// <summary>
        /// Constant LambdaProvisionedConcurrencyUtilization for MetricType
        /// </summary>
        public static readonly MetricType LambdaProvisionedConcurrencyUtilization = new MetricType("LambdaProvisionedConcurrencyUtilization");
        /// <summary>
        /// Constant NeptuneReaderAverageCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType NeptuneReaderAverageCPUUtilization = new MetricType("NeptuneReaderAverageCPUUtilization");
        /// <summary>
        /// Constant RDSReaderAverageCPUUtilization for MetricType
        /// </summary>
        public static readonly MetricType RDSReaderAverageCPUUtilization = new MetricType("RDSReaderAverageCPUUtilization");
        /// <summary>
        /// Constant RDSReaderAverageDatabaseConnections for MetricType
        /// </summary>
        public static readonly MetricType RDSReaderAverageDatabaseConnections = new MetricType("RDSReaderAverageDatabaseConnections");
        /// <summary>
        /// Constant SageMakerInferenceComponentConcurrentRequestsPerCopyHighResolution for MetricType
        /// </summary>
        public static readonly MetricType SageMakerInferenceComponentConcurrentRequestsPerCopyHighResolution = new MetricType("SageMakerInferenceComponentConcurrentRequestsPerCopyHighResolution");
        /// <summary>
        /// Constant SageMakerInferenceComponentInvocationsPerCopy for MetricType
        /// </summary>
        public static readonly MetricType SageMakerInferenceComponentInvocationsPerCopy = new MetricType("SageMakerInferenceComponentInvocationsPerCopy");
        /// <summary>
        /// Constant SageMakerVariantConcurrentRequestsPerModelHighResolution for MetricType
        /// </summary>
        public static readonly MetricType SageMakerVariantConcurrentRequestsPerModelHighResolution = new MetricType("SageMakerVariantConcurrentRequestsPerModelHighResolution");
        /// <summary>
        /// Constant SageMakerVariantInvocationsPerInstance for MetricType
        /// </summary>
        public static readonly MetricType SageMakerVariantInvocationsPerInstance = new MetricType("SageMakerVariantInvocationsPerInstance");
        /// <summary>
        /// Constant SageMakerVariantProvisionedConcurrencyUtilization for MetricType
        /// </summary>
        public static readonly MetricType SageMakerVariantProvisionedConcurrencyUtilization = new MetricType("SageMakerVariantProvisionedConcurrencyUtilization");
        /// <summary>
        /// Constant WorkSpacesAverageUserSessionsCapacityUtilization for MetricType
        /// </summary>
        public static readonly MetricType WorkSpacesAverageUserSessionsCapacityUtilization = new MetricType("WorkSpacesAverageUserSessionsCapacityUtilization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricType FindValue(string value)
        {
            return FindValue<MetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant PredictiveScaling for PolicyType
        /// </summary>
        public static readonly PolicyType PredictiveScaling = new PolicyType("PredictiveScaling");
        /// <summary>
        /// Constant StepScaling for PolicyType
        /// </summary>
        public static readonly PolicyType StepScaling = new PolicyType("StepScaling");
        /// <summary>
        /// Constant TargetTrackingScaling for PolicyType
        /// </summary>
        public static readonly PolicyType TargetTrackingScaling = new PolicyType("TargetTrackingScaling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PredictiveScalingMaxCapacityBreachBehavior.
    /// </summary>
    public class PredictiveScalingMaxCapacityBreachBehavior : ConstantClass
    {

        /// <summary>
        /// Constant HonorMaxCapacity for PredictiveScalingMaxCapacityBreachBehavior
        /// </summary>
        public static readonly PredictiveScalingMaxCapacityBreachBehavior HonorMaxCapacity = new PredictiveScalingMaxCapacityBreachBehavior("HonorMaxCapacity");
        /// <summary>
        /// Constant IncreaseMaxCapacity for PredictiveScalingMaxCapacityBreachBehavior
        /// </summary>
        public static readonly PredictiveScalingMaxCapacityBreachBehavior IncreaseMaxCapacity = new PredictiveScalingMaxCapacityBreachBehavior("IncreaseMaxCapacity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PredictiveScalingMaxCapacityBreachBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredictiveScalingMaxCapacityBreachBehavior FindValue(string value)
        {
            return FindValue<PredictiveScalingMaxCapacityBreachBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredictiveScalingMaxCapacityBreachBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PredictiveScalingMode.
    /// </summary>
    public class PredictiveScalingMode : ConstantClass
    {

        /// <summary>
        /// Constant ForecastAndScale for PredictiveScalingMode
        /// </summary>
        public static readonly PredictiveScalingMode ForecastAndScale = new PredictiveScalingMode("ForecastAndScale");
        /// <summary>
        /// Constant ForecastOnly for PredictiveScalingMode
        /// </summary>
        public static readonly PredictiveScalingMode ForecastOnly = new PredictiveScalingMode("ForecastOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PredictiveScalingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredictiveScalingMode FindValue(string value)
        {
            return FindValue<PredictiveScalingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredictiveScalingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalableDimension.
    /// </summary>
    public class ScalableDimension : ConstantClass
    {

        /// <summary>
        /// Constant AppstreamFleetDesiredCapacity for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension AppstreamFleetDesiredCapacity = new ScalableDimension("appstream:fleet:DesiredCapacity");
        /// <summary>
        /// Constant CassandraTableReadCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension CassandraTableReadCapacityUnits = new ScalableDimension("cassandra:table:ReadCapacityUnits");
        /// <summary>
        /// Constant CassandraTableWriteCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension CassandraTableWriteCapacityUnits = new ScalableDimension("cassandra:table:WriteCapacityUnits");
        /// <summary>
        /// Constant ComprehendDocumentClassifierEndpointDesiredInferenceUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ComprehendDocumentClassifierEndpointDesiredInferenceUnits = new ScalableDimension("comprehend:document-classifier-endpoint:DesiredInferenceUnits");
        /// <summary>
        /// Constant ComprehendEntityRecognizerEndpointDesiredInferenceUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ComprehendEntityRecognizerEndpointDesiredInferenceUnits = new ScalableDimension("comprehend:entity-recognizer-endpoint:DesiredInferenceUnits");
        /// <summary>
        /// Constant CustomResourceResourceTypeProperty for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension CustomResourceResourceTypeProperty = new ScalableDimension("custom-resource:ResourceType:Property");
        /// <summary>
        /// Constant DynamodbIndexReadCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbIndexReadCapacityUnits = new ScalableDimension("dynamodb:index:ReadCapacityUnits");
        /// <summary>
        /// Constant DynamodbIndexWriteCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbIndexWriteCapacityUnits = new ScalableDimension("dynamodb:index:WriteCapacityUnits");
        /// <summary>
        /// Constant DynamodbTableReadCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbTableReadCapacityUnits = new ScalableDimension("dynamodb:table:ReadCapacityUnits");
        /// <summary>
        /// Constant DynamodbTableWriteCapacityUnits for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension DynamodbTableWriteCapacityUnits = new ScalableDimension("dynamodb:table:WriteCapacityUnits");
        /// <summary>
        /// Constant Ec2SpotFleetRequestTargetCapacity for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension Ec2SpotFleetRequestTargetCapacity = new ScalableDimension("ec2:spot-fleet-request:TargetCapacity");
        /// <summary>
        /// Constant EcsServiceDesiredCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension EcsServiceDesiredCount = new ScalableDimension("ecs:service:DesiredCount");
        /// <summary>
        /// Constant ElasticacheCacheClusterNodes for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ElasticacheCacheClusterNodes = new ScalableDimension("elasticache:cache-cluster:Nodes");
        /// <summary>
        /// Constant ElasticacheReplicationGroupNodeGroups for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ElasticacheReplicationGroupNodeGroups = new ScalableDimension("elasticache:replication-group:NodeGroups");
        /// <summary>
        /// Constant ElasticacheReplicationGroupReplicas for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ElasticacheReplicationGroupReplicas = new ScalableDimension("elasticache:replication-group:Replicas");
        /// <summary>
        /// Constant ElasticmapreduceInstancegroupInstanceCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension ElasticmapreduceInstancegroupInstanceCount = new ScalableDimension("elasticmapreduce:instancegroup:InstanceCount");
        /// <summary>
        /// Constant KafkaBrokerStorageVolumeSize for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension KafkaBrokerStorageVolumeSize = new ScalableDimension("kafka:broker-storage:VolumeSize");
        /// <summary>
        /// Constant LambdaFunctionProvisionedConcurrency for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension LambdaFunctionProvisionedConcurrency = new ScalableDimension("lambda:function:ProvisionedConcurrency");
        /// <summary>
        /// Constant NeptuneClusterReadReplicaCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension NeptuneClusterReadReplicaCount = new ScalableDimension("neptune:cluster:ReadReplicaCount");
        /// <summary>
        /// Constant RdsClusterReadReplicaCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension RdsClusterReadReplicaCount = new ScalableDimension("rds:cluster:ReadReplicaCount");
        /// <summary>
        /// Constant SagemakerInferenceComponentDesiredCopyCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension SagemakerInferenceComponentDesiredCopyCount = new ScalableDimension("sagemaker:inference-component:DesiredCopyCount");
        /// <summary>
        /// Constant SagemakerVariantDesiredInstanceCount for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension SagemakerVariantDesiredInstanceCount = new ScalableDimension("sagemaker:variant:DesiredInstanceCount");
        /// <summary>
        /// Constant SagemakerVariantDesiredProvisionedConcurrency for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension SagemakerVariantDesiredProvisionedConcurrency = new ScalableDimension("sagemaker:variant:DesiredProvisionedConcurrency");
        /// <summary>
        /// Constant WorkspacesWorkspacespoolDesiredUserSessions for ScalableDimension
        /// </summary>
        public static readonly ScalableDimension WorkspacesWorkspacespoolDesiredUserSessions = new ScalableDimension("workspaces:workspacespool:DesiredUserSessions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalableDimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalableDimension FindValue(string value)
        {
            return FindValue<ScalableDimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalableDimension(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingActivityStatusCode.
    /// </summary>
    public class ScalingActivityStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Failed = new ScalingActivityStatusCode("Failed");
        /// <summary>
        /// Constant InProgress for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode InProgress = new ScalingActivityStatusCode("InProgress");
        /// <summary>
        /// Constant Overridden for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Overridden = new ScalingActivityStatusCode("Overridden");
        /// <summary>
        /// Constant Pending for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Pending = new ScalingActivityStatusCode("Pending");
        /// <summary>
        /// Constant Successful for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Successful = new ScalingActivityStatusCode("Successful");
        /// <summary>
        /// Constant Unfulfilled for ScalingActivityStatusCode
        /// </summary>
        public static readonly ScalingActivityStatusCode Unfulfilled = new ScalingActivityStatusCode("Unfulfilled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingActivityStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingActivityStatusCode FindValue(string value)
        {
            return FindValue<ScalingActivityStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingActivityStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNamespace.
    /// </summary>
    public class ServiceNamespace : ConstantClass
    {

        /// <summary>
        /// Constant Appstream for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Appstream = new ServiceNamespace("appstream");
        /// <summary>
        /// Constant Cassandra for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Cassandra = new ServiceNamespace("cassandra");
        /// <summary>
        /// Constant Comprehend for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Comprehend = new ServiceNamespace("comprehend");
        /// <summary>
        /// Constant CustomResource for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace CustomResource = new ServiceNamespace("custom-resource");
        /// <summary>
        /// Constant Dynamodb for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Dynamodb = new ServiceNamespace("dynamodb");
        /// <summary>
        /// Constant Ec2 for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Ec2 = new ServiceNamespace("ec2");
        /// <summary>
        /// Constant Ecs for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Ecs = new ServiceNamespace("ecs");
        /// <summary>
        /// Constant Elasticache for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Elasticache = new ServiceNamespace("elasticache");
        /// <summary>
        /// Constant Elasticmapreduce for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Elasticmapreduce = new ServiceNamespace("elasticmapreduce");
        /// <summary>
        /// Constant Kafka for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Kafka = new ServiceNamespace("kafka");
        /// <summary>
        /// Constant Lambda for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Lambda = new ServiceNamespace("lambda");
        /// <summary>
        /// Constant Neptune for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Neptune = new ServiceNamespace("neptune");
        /// <summary>
        /// Constant Rds for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Rds = new ServiceNamespace("rds");
        /// <summary>
        /// Constant Sagemaker for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Sagemaker = new ServiceNamespace("sagemaker");
        /// <summary>
        /// Constant Workspaces for ServiceNamespace
        /// </summary>
        public static readonly ServiceNamespace Workspaces = new ServiceNamespace("workspaces");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNamespace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNamespace FindValue(string value)
        {
            return FindValue<ServiceNamespace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNamespace(string value)
        {
            return FindValue(value);
        }
    }

}