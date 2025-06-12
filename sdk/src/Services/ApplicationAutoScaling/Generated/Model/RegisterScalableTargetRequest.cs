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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterScalableTarget operation.
    /// Registers or updates a scalable target, which is the resource that you want to scale.
    /// 
    ///  
    /// <para>
    /// Scalable targets are uniquely identified by the combination of resource ID, scalable
    /// dimension, and namespace, which represents some capacity dimension of the underlying
    /// service.
    /// </para>
    ///  
    /// <para>
    /// When you register a new scalable target, you must specify values for the minimum and
    /// maximum capacity. If the specified resource is not active in the target service, this
    /// operation does not change the resource's current capacity. Otherwise, it changes the
    /// resource's current capacity to a value that is inside of this range.
    /// </para>
    ///  
    /// <para>
    /// If you add a scaling policy, current capacity is adjustable within the specified range
    /// when scaling starts. Application Auto Scaling scaling policies will not scale capacity
    /// to values that are outside of the minimum and maximum range.
    /// </para>
    ///  
    /// <para>
    /// After you register a scalable target, you do not need to register it again to use
    /// other Application Auto Scaling operations. To see which resources have been registered,
    /// use <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DescribeScalableTargets.html">DescribeScalableTargets</a>.
    /// You can also view the scaling policies for a service namespace by using <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DescribeScalableTargets.html">DescribeScalableTargets</a>.
    /// If you no longer need a scalable target, you can deregister it by using <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DeregisterScalableTarget.html">DeregisterScalableTarget</a>.
    /// </para>
    ///  
    /// <para>
    /// To update a scalable target, specify the parameters that you want to change. Include
    /// the parameters that identify the scalable target: resource ID, scalable dimension,
    /// and namespace. Any parameters that you don't specify are not changed by this update
    /// request. 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you call the <c>RegisterScalableTarget</c> API operation to create a scalable target,
    /// there might be a brief delay until the operation achieves <a href="https://en.wikipedia.org/wiki/Eventual_consistency">eventual
    /// consistency</a>. You might become aware of this brief delay if you get unexpected
    /// errors when performing sequential operations. The typical strategy is to retry the
    /// request, and some Amazon Web Services SDKs include automatic backoff and retry logic.
    /// </para>
    ///  
    /// <para>
    /// If you call the <c>RegisterScalableTarget</c> API operation to update an existing
    /// scalable target, Application Auto Scaling retrieves the current capacity of the resource.
    /// If it's below the minimum capacity or above the maximum capacity, Application Auto
    /// Scaling adjusts the capacity of the scalable target to place it within these bounds,
    /// even if you don't include the <c>MinCapacity</c> or <c>MaxCapacity</c> request parameters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RegisterScalableTargetRequest : AmazonApplicationAutoScalingRequest
    {
        private int? _maxCapacity;
        private int? _minCapacity;
        private string _resourceId;
        private string _roleARN;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;
        private SuspendedState _suspendedState;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum value that you plan to scale out to. When a scaling policy is in effect,
        /// Application Auto Scaling can scale out (expand) as needed to the maximum capacity
        /// limit in response to changing demand. This property is required when registering a
        /// new scalable target.
        /// </para>
        ///  
        /// <para>
        /// Although you can specify a large maximum capacity, note that service quotas might
        /// impose lower limits. Each service has its own default quotas for the maximum capacity
        /// of the resource. If you want to specify a higher limit, you can request an increase.
        /// For more information, consult the documentation for that service. For information
        /// about the default quotas for each service, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-service-information.html">Service
        /// endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum value that you plan to scale in to. When a scaling policy is in effect,
        /// Application Auto Scaling can scale in (contract) as needed to the minimum capacity
        /// limit in response to changing demand. This property is required when registering a
        /// new scalable target.
        /// </para>
        ///  
        /// <para>
        /// For the following resources, the minimum value allowed is 0.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AppStream 2.0 fleets
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Aurora DB clusters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECS services
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMR clusters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lambda provisioned concurrency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker endpoint variants
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker inference components
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker serverless endpoint provisioned concurrency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleets
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// custom resources
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It's strongly recommended that you specify a value greater than 0. A value greater
        /// than 0 means that data points are continuously reported to CloudWatch that scaling
        /// policies can use to scale on a metric like average CPU utilization.
        /// </para>
        ///  
        /// <para>
        /// For all other resources, the minimum allowed value depends on the type of resource
        /// that you are using. If you provide a value that is lower than what a resource can
        /// accept, an error occurs. In which case, the error message will provide the minimum
        /// value that the resource can accept.
        /// </para>
        /// </summary>
        public int? MinCapacity
        {
            get { return this._minCapacity; }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource that is associated with the scalable target. This string
        /// consists of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ECS service - The resource type is <c>service</c> and the unique identifier is the
        /// cluster name and service name. Example: <c>service/my-cluster/my-service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet - The resource type is <c>spot-fleet-request</c> and the unique identifier
        /// is the Spot Fleet request ID. Example: <c>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMR cluster - The resource type is <c>instancegroup</c> and the unique identifier
        /// is the cluster ID and instance group ID. Example: <c>instancegroup/j-2EEZNYKUA1NTV/ig-1791Y4E1L8YI0</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AppStream 2.0 fleet - The resource type is <c>fleet</c> and the unique identifier
        /// is the fleet name. Example: <c>fleet/sample-fleet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <c>table</c> and the unique identifier is the
        /// table name. Example: <c>table/my-table</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <c>index</c> and the unique
        /// identifier is the index name. Example: <c>table/my-table/index/my-table-index</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <c>cluster</c> and the unique identifier
        /// is the cluster name. Example: <c>cluster:my-db-cluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker endpoint variant - The resource type is <c>variant</c> and the unique identifier
        /// is the resource ID. Example: <c>endpoint/my-end-point/variant/KMeansClustering</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom resources are not supported with a resource type. This parameter must specify
        /// the <c>OutputValue</c> from the CloudFormation template stack used to access the resources.
        /// The unique identifier is defined by the service provider. More information is available
        /// in our <a href="https://github.com/aws/aws-auto-scaling-custom-resource">GitHub repository</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Comprehend document classification endpoint - The resource type and unique
        /// identifier are specified using the endpoint ARN. Example: <c>arn:aws:comprehend:us-west-2:123456789012:document-classifier-endpoint/EXAMPLE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Comprehend entity recognizer endpoint - The resource type and unique identifier
        /// are specified using the endpoint ARN. Example: <c>arn:aws:comprehend:us-west-2:123456789012:entity-recognizer-endpoint/EXAMPLE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lambda provisioned concurrency - The resource type is <c>function</c> and the unique
        /// identifier is the function name with a function version or alias name suffix that
        /// is not <c>$LATEST</c>. Example: <c>function:my-function:prod</c> or <c>function:my-function:1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Keyspaces table - The resource type is <c>table</c> and the unique identifier
        /// is the table name. Example: <c>keyspace/mykeyspace/table/mytable</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon MSK cluster - The resource type and unique identifier are specified using the
        /// cluster ARN. Example: <c>arn:aws:kafka:us-east-1:123456789012:cluster/demo-cluster-1/6357e0b2-0e6a-4b86-a0b4-70df934c2e31-5</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ElastiCache replication group - The resource type is <c>replication-group</c>
        /// and the unique identifier is the replication group name. Example: <c>replication-group/mycluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ElastiCache cache cluster - The resource type is <c>cache-cluster</c> and the
        /// unique identifier is the cache cluster name. Example: <c>cache-cluster/mycluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Neptune cluster - The resource type is <c>cluster</c> and the unique identifier is
        /// the cluster name. Example: <c>cluster:mycluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker serverless endpoint - The resource type is <c>variant</c> and the unique
        /// identifier is the resource ID. Example: <c>endpoint/my-end-point/variant/KMeansClustering</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker inference component - The resource type is <c>inference-component</c> and
        /// the unique identifier is the resource ID. Example: <c>inference-component/my-inference-component</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pool of WorkSpaces - The resource type is <c>workspacespool</c> and the unique identifier
        /// is the pool ID. Example: <c>workspacespool/wspool-123456</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// This parameter is required for services that do not support service-linked roles (such
        /// as Amazon EMR), and it must specify the ARN of an IAM role that allows Application
        /// Auto Scaling to modify the scalable target on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// If the service supports service-linked roles, Application Auto Scaling uses a service-linked
        /// role, which it creates if it does not yet exist. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/security_iam_service-with-iam.html">How
        /// Application Auto Scaling works with IAM</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension associated with the scalable target. This string consists of
        /// the service namespace, resource type, and scaling property.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ecs:service:DesiredCount</c> - The task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elasticmapreduce:instancegroup:InstanceCount</c> - The instance count of an EMR
        /// Instance Group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:spot-fleet-request:TargetCapacity</c> - The target capacity of a Spot Fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>appstream:fleet:DesiredCapacity</c> - The capacity of an AppStream 2.0 fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:table:ReadCapacityUnits</c> - The provisioned read capacity for a DynamoDB
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:table:WriteCapacityUnits</c> - The provisioned write capacity for a DynamoDB
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:index:ReadCapacityUnits</c> - The provisioned read capacity for a DynamoDB
        /// global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:index:WriteCapacityUnits</c> - The provisioned write capacity for a DynamoDB
        /// global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rds:cluster:ReadReplicaCount</c> - The count of Aurora Replicas in an Aurora DB
        /// cluster. Available for Aurora MySQL-compatible edition and Aurora PostgreSQL-compatible
        /// edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sagemaker:variant:DesiredInstanceCount</c> - The number of EC2 instances for a
        /// SageMaker model endpoint variant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-resource:ResourceType:Property</c> - The scalable dimension for a custom
        /// resource provided by your own application or service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>comprehend:document-classifier-endpoint:DesiredInferenceUnits</c> - The number
        /// of inference units for an Amazon Comprehend document classification endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>comprehend:entity-recognizer-endpoint:DesiredInferenceUnits</c> - The number of
        /// inference units for an Amazon Comprehend entity recognizer endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lambda:function:ProvisionedConcurrency</c> - The provisioned concurrency for a
        /// Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:table:ReadCapacityUnits</c> - The provisioned read capacity for an Amazon
        /// Keyspaces table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:table:WriteCapacityUnits</c> - The provisioned write capacity for an
        /// Amazon Keyspaces table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kafka:broker-storage:VolumeSize</c> - The provisioned volume size (in GiB) for
        /// brokers in an Amazon MSK cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elasticache:cache-cluster:Nodes</c> - The number of nodes for an Amazon ElastiCache
        /// cache cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elasticache:replication-group:NodeGroups</c> - The number of node groups for an
        /// Amazon ElastiCache replication group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elasticache:replication-group:Replicas</c> - The number of replicas per node group
        /// for an Amazon ElastiCache replication group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>neptune:cluster:ReadReplicaCount</c> - The count of read replicas in an Amazon
        /// Neptune DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sagemaker:variant:DesiredProvisionedConcurrency</c> - The provisioned concurrency
        /// for a SageMaker serverless endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sagemaker:inference-component:DesiredCopyCount</c> - The number of copies across
        /// an endpoint for a SageMaker inference component.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>workspaces:workspacespool:DesiredUserSessions</c> - The number of user sessions
        /// for the WorkSpaces in the pool.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalableDimension ScalableDimension
        {
            get { return this._scalableDimension; }
            set { this._scalableDimension = value; }
        }

        // Check to see if ScalableDimension property is set
        internal bool IsSetScalableDimension()
        {
            return this._scalableDimension != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the Amazon Web Services service that provides the resource. For a
        /// resource provided by your own application or service, use <c>custom-resource</c> instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceNamespace ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SuspendedState. 
        /// <para>
        /// An embedded object that contains attributes and attribute values that are used to
        /// suspend and resume automatic scaling. Setting the value of an attribute to <c>true</c>
        /// suspends the specified scaling activities. Setting it to <c>false</c> (default) resumes
        /// the specified scaling activities. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Suspension Outcomes</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>DynamicScalingInSuspended</c>, while a suspension is in effect, all scale-in
        /// activities that are triggered by a scaling policy are suspended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>DynamicScalingOutSuspended</c>, while a suspension is in effect, all scale-out
        /// activities that are triggered by a scaling policy are suspended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>ScheduledScalingSuspended</c>, while a suspension is in effect, all scaling
        /// activities that involve scheduled actions are suspended. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-suspend-resume-scaling.html">Suspend
        /// and resume scaling</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public SuspendedState SuspendedState
        {
            get { return this._suspendedState; }
            set { this._suspendedState = value; }
        }

        // Check to see if SuspendedState property is set
        internal bool IsSetSuspendedState()
        {
            return this._suspendedState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags to the scalable target. Use this parameter to tag the scalable
        /// target when it is created. To tag an existing scalable target, use the <a>TagResource</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Both the tag key and the tag value
        /// are required. You cannot have more than one tag on a scalable target with the same
        /// tag key.
        /// </para>
        ///  
        /// <para>
        /// Use tags to control access to a scalable target. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/resource-tagging-support.html">Tagging
        /// support for Application Auto Scaling</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}