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
    /// Represents a scheduled action.
    /// </summary>
    public partial class ScheduledAction
    {
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ScalableTargetAction _scalableTargetAction;
        private string _schedule;
        private string _scheduledActionARN;
        private string _scheduledActionName;
        private ServiceNamespace _serviceNamespace;
        private DateTime? _startTime;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the scheduled action was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the action is scheduled to end, in UTC.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource associated with the scaling policy. This string consists
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
        /// Gets and sets the property ScalableTargetAction. 
        /// <para>
        /// The new minimum and maximum capacity. You can set both values or just one. At the
        /// scheduled time, if the current capacity is below the minimum capacity, Application
        /// Auto Scaling scales out to the minimum capacity. If the current capacity is above
        /// the maximum capacity, Application Auto Scaling scales in to the maximum capacity.
        /// </para>
        /// </summary>
        public ScalableTargetAction ScalableTargetAction
        {
            get { return this._scalableTargetAction; }
            set { this._scalableTargetAction = value; }
        }

        // Check to see if ScalableTargetAction property is set
        internal bool IsSetScalableTargetAction()
        {
            return this._scalableTargetAction != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for this action. The following formats are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// At expressions - "<c>at(<i>yyyy</i>-<i>mm</i>-<i>dd</i>T<i>hh</i>:<i>mm</i>:<i>ss</i>)</c>"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rate expressions - "<c>rate(<i>value</i> <i>unit</i>)</c>"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cron expressions - "<c>cron(<i>fields</i>)</c>"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At expressions are useful for one-time schedules. Cron expressions are useful for
        /// scheduled actions that run periodically at a specified date and time, and rate expressions
        /// are useful for scheduled actions that run at a regular interval.
        /// </para>
        ///  
        /// <para>
        /// At and cron expressions use Universal Coordinated Time (UTC) by default.
        /// </para>
        ///  
        /// <para>
        /// The cron format consists of six fields separated by white spaces: [Minutes] [Hours]
        /// [Day_of_Month] [Month] [Day_of_Week] [Year].
        /// </para>
        ///  
        /// <para>
        /// For rate expressions, <i>value</i> is a positive integer and <i>unit</i> is <c>minute</c>
        /// | <c>minutes</c> | <c>hour</c> | <c>hours</c> | <c>day</c> | <c>days</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/scheduled-scaling-using-cron-expressions.html">Schedule
        /// recurring scaling actions using cron expressions</a> in the <i>Application Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ScheduledActionARN
        {
            get { return this._scheduledActionARN; }
            set { this._scheduledActionARN = value; }
        }

        // Check to see if ScheduledActionARN property is set
        internal bool IsSetScheduledActionARN()
        {
            return this._scheduledActionARN != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ScheduledActionName
        {
            get { return this._scheduledActionName; }
            set { this._scheduledActionName = value; }
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this._scheduledActionName != null;
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
        /// The date and time that the action is scheduled to begin, in UTC.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone used when referring to the date and time of a scheduled action, when
        /// the scheduled action uses an at or cron expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}