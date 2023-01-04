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

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScheduledAction operation.
    /// Creates or updates a scheduled action for an Application Auto Scaling scalable target.
    /// 
    /// 
    ///  
    /// <para>
    /// Each scalable target is identified by a service namespace, resource ID, and scalable
    /// dimension. A scheduled action applies to the scalable target identified by those three
    /// attributes. You cannot create a scheduled action until you have registered the resource
    /// as a scalable target.
    /// </para>
    ///  
    /// <para>
    /// When start and end times are specified with a recurring schedule using a cron expression
    /// or rates, they form the boundaries for when the recurring action starts and stops.
    /// </para>
    ///  
    /// <para>
    /// To update a scheduled action, specify the parameters that you want to change. If you
    /// don't specify start and end times, the old values are deleted.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scheduled-scaling.html">Scheduled
    /// scaling</a> in the <i>Application Auto Scaling User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If a scalable target is deregistered, the scalable target is no longer available to
    /// run scheduled actions. Any scheduled actions that were specified for the scalable
    /// target are deleted.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutScheduledActionRequest : AmazonApplicationAutoScalingRequest
    {
        private DateTime? _endTime;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ScalableTargetAction _scalableTargetAction;
        private string _schedule;
        private string _scheduledActionName;
        private ServiceNamespace _serviceNamespace;
        private DateTime? _startTime;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time for the recurring schedule to end, in UTC.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// The identifier of the resource associated with the scheduled action. This string consists
        /// of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ECS service - The resource type is <code>service</code> and the unique identifier
        /// is the cluster name and service name. Example: <code>service/default/sample-webapp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet - The resource type is <code>spot-fleet-request</code> and the unique identifier
        /// is the Spot Fleet request ID. Example: <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMR cluster - The resource type is <code>instancegroup</code> and the unique identifier
        /// is the cluster ID and instance group ID. Example: <code>instancegroup/j-2EEZNYKUA1NTV/ig-1791Y4E1L8YI0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AppStream 2.0 fleet - The resource type is <code>fleet</code> and the unique identifier
        /// is the fleet name. Example: <code>fleet/sample-fleet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <code>table</code> and the unique identifier
        /// is the table name. Example: <code>table/my-table</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <code>index</code> and the
        /// unique identifier is the index name. Example: <code>table/my-table/index/my-table-index</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <code>cluster</code> and the unique identifier
        /// is the cluster name. Example: <code>cluster:my-db-cluster</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SageMaker endpoint variant - The resource type is <code>variant</code> and the unique
        /// identifier is the resource ID. Example: <code>endpoint/my-end-point/variant/KMeansClustering</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom resources are not supported with a resource type. This parameter must specify
        /// the <code>OutputValue</code> from the CloudFormation template stack used to access
        /// the resources. The unique identifier is defined by the service provider. More information
        /// is available in our <a href="https://github.com/aws/aws-auto-scaling-custom-resource">GitHub
        /// repository</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Comprehend document classification endpoint - The resource type and unique
        /// identifier are specified using the endpoint ARN. Example: <code>arn:aws:comprehend:us-west-2:123456789012:document-classifier-endpoint/EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Comprehend entity recognizer endpoint - The resource type and unique identifier
        /// are specified using the endpoint ARN. Example: <code>arn:aws:comprehend:us-west-2:123456789012:entity-recognizer-endpoint/EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lambda provisioned concurrency - The resource type is <code>function</code> and the
        /// unique identifier is the function name with a function version or alias name suffix
        /// that is not <code>$LATEST</code>. Example: <code>function:my-function:prod</code>
        /// or <code>function:my-function:1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Keyspaces table - The resource type is <code>table</code> and the unique identifier
        /// is the table name. Example: <code>keyspace/mykeyspace/table/mytable</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon MSK cluster - The resource type and unique identifier are specified using the
        /// cluster ARN. Example: <code>arn:aws:kafka:us-east-1:123456789012:cluster/demo-cluster-1/6357e0b2-0e6a-4b86-a0b4-70df934c2e31-5</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ElastiCache replication group - The resource type is <code>replication-group</code>
        /// and the unique identifier is the replication group name. Example: <code>replication-group/mycluster</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Neptune cluster - The resource type is <code>cluster</code> and the unique identifier
        /// is the cluster name. Example: <code>cluster:mycluster</code>.
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
        ///  <code>ecs:service:DesiredCount</code> - The desired task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elasticmapreduce:instancegroup:InstanceCount</code> - The instance count of
        /// an EMR Instance Group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:spot-fleet-request:TargetCapacity</code> - The target capacity of a Spot
        /// Fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>appstream:fleet:DesiredCapacity</code> - The desired capacity of an AppStream
        /// 2.0 fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:table:ReadCapacityUnits</code> - The provisioned read capacity for
        /// a DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:table:WriteCapacityUnits</code> - The provisioned write capacity for
        /// a DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:index:ReadCapacityUnits</code> - The provisioned read capacity for
        /// a DynamoDB global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:index:WriteCapacityUnits</code> - The provisioned write capacity for
        /// a DynamoDB global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rds:cluster:ReadReplicaCount</code> - The count of Aurora Replicas in an Aurora
        /// DB cluster. Available for Aurora MySQL-compatible edition and Aurora PostgreSQL-compatible
        /// edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sagemaker:variant:DesiredInstanceCount</code> - The number of EC2 instances
        /// for a SageMaker model endpoint variant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-resource:ResourceType:Property</code> - The scalable dimension for a
        /// custom resource provided by your own application or service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>comprehend:document-classifier-endpoint:DesiredInferenceUnits</code> - The
        /// number of inference units for an Amazon Comprehend document classification endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>comprehend:entity-recognizer-endpoint:DesiredInferenceUnits</code> - The number
        /// of inference units for an Amazon Comprehend entity recognizer endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>lambda:function:ProvisionedConcurrency</code> - The provisioned concurrency
        /// for a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cassandra:table:ReadCapacityUnits</code> - The provisioned read capacity for
        /// an Amazon Keyspaces table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cassandra:table:WriteCapacityUnits</code> - The provisioned write capacity
        /// for an Amazon Keyspaces table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kafka:broker-storage:VolumeSize</code> - The provisioned volume size (in GiB)
        /// for brokers in an Amazon MSK cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elasticache:replication-group:NodeGroups</code> - The number of node groups
        /// for an Amazon ElastiCache replication group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elasticache:replication-group:Replicas</code> - The number of replicas per
        /// node group for an Amazon ElastiCache replication group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>neptune:cluster:ReadReplicaCount</code> - The count of read replicas in an
        /// Amazon Neptune DB cluster.
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
        /// At expressions - "<code>at(<i>yyyy</i>-<i>mm</i>-<i>dd</i>T<i>hh</i>:<i>mm</i>:<i>ss</i>)</code>"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rate expressions - "<code>rate(<i>value</i> <i>unit</i>)</code>"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cron expressions - "<code>cron(<i>fields</i>)</code>"
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
        /// For rate expressions, <i>value</i> is a positive integer and <i>unit</i> is <code>minute</code>
        /// | <code>minutes</code> | <code>hour</code> | <code>hours</code> | <code>day</code>
        /// | <code>days</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information and examples, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/examples-scheduled-actions.html">Example
        /// scheduled actions for Application Auto Scaling</a> in the <i>Application Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action. This name must be unique among all other scheduled
        /// actions on the specified scalable target. 
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
        /// The namespace of the Amazon Web Services service that provides the resource. For a
        /// resource provided by your own application or service, use <code>custom-resource</code>
        /// instead.
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
        /// The date and time for this scheduled action to start, in UTC.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// Specifies the time zone used when setting a scheduled action by using an at or cron
        /// expression. If a time zone is not provided, UTC is used by default.
        /// </para>
        ///  
        /// <para>
        /// Valid values are the canonical names of the IANA time zones supported by Joda-Time
        /// (such as <code>Etc/GMT+9</code> or <code>Pacific/Tahiti</code>). For more information,
        /// see <a href="https://www.joda.org/joda-time/timezones.html">https://www.joda.org/joda-time/timezones.html</a>.
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