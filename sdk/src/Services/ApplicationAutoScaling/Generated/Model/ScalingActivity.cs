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
    /// Represents a scaling activity.
    /// </summary>
    public partial class ScalingActivity
    {
        private string _activityId;
        private string _cause;
        private string _description;
        private string _details;
        private DateTime? _endTime;
        private List<NotScaledReason> _notScaledReasons = AWSConfigs.InitializeCollections ? new List<NotScaledReason>() : null;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;
        private DateTime? _startTime;
        private ScalingActivityStatusCode _statusCode;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        /// The unique identifier of the scaling activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActivityId
        {
            get { return this._activityId; }
            set { this._activityId = value; }
        }

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this._activityId != null;
        }

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// A simple description of what caused the scaling activity to happen.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A simple description of what action the scaling activity intends to accomplish.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details about the scaling activity.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The Unix timestamp for when the scaling activity ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotScaledReasons. 
        /// <para>
        /// Machine-readable data that describes the reason for a not scaled activity. Only available
        /// when <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DescribeScalingActivities.html">DescribeScalingActivities</a>
        /// includes not scaled activities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NotScaledReason> NotScaledReasons
        {
            get { return this._notScaledReasons; }
            set { this._notScaledReasons = value; }
        }

        // Check to see if NotScaledReasons property is set
        internal bool IsSetNotScaledReasons()
        {
            return this._notScaledReasons != null && (this._notScaledReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource associated with the scaling activity. This string consists
        /// of the resource type and unique identifier.
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
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension. This string consists of the service namespace, resource type,
        /// and scaling property.
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
        /// The namespace of the Amazon Web Services service that provides the resource, or a
        /// <c>custom-resource</c>.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The Unix timestamp for when the scaling activity began.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Indicates the status of the scaling activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingActivityStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A simple message about the current status of the scaling activity.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}