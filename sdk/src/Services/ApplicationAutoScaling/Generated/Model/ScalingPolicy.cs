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
    /// Represents a scaling policy to use with Application Auto Scaling.
    /// 
    ///  
    /// <para>
    /// For more information about configuring scaling policies for a specific service, see
    /// <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/getting-started.html">Getting
    /// started with Application Auto Scaling</a> in the <i>Application Auto Scaling User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class ScalingPolicy
    {
        private List<Alarm> _alarms = new List<Alarm>();
        private DateTime? _creationTime;
        private string _policyARN;
        private string _policyName;
        private PolicyType _policyType;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;
        private StepScalingPolicyConfiguration _stepScalingPolicyConfiguration;
        private TargetTrackingScalingPolicyConfiguration _targetTrackingScalingPolicyConfiguration;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms associated with the scaling policy.
        /// </para>
        /// </summary>
        public List<Alarm> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && this._alarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The Unix timestamp for when the scaling policy was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string PolicyARN
        {
            get { return this._policyARN; }
            set { this._policyARN = value; }
        }

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this._policyARN != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The scaling policy type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource associated with the scaling policy. This string consists
        /// of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ECS service - The resource type is <code>service</code> and the unique identifier
        /// is the cluster name and service name. Example: <code>service/default/sample-webapp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet request - The resource type is <code>spot-fleet-request</code> and the
        /// unique identifier is the Spot Fleet request ID. Example: <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
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
        /// Amazon SageMaker endpoint variant - The resource type is <code>variant</code> and
        /// the unique identifier is the resource ID. Example: <code>endpoint/my-end-point/variant/KMeansClustering</code>.
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
        ///  <code>ec2:spot-fleet-request:TargetCapacity</code> - The target capacity of a Spot
        /// Fleet request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elasticmapreduce:instancegroup:InstanceCount</code> - The instance count of
        /// an EMR Instance Group.
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
        /// for an Amazon SageMaker model endpoint variant.
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
        /// The namespace of the AWS service that provides the resource, or a <code>custom-resource</code>.
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
        /// Gets and sets the property StepScalingPolicyConfiguration. 
        /// <para>
        /// A step scaling policy.
        /// </para>
        /// </summary>
        public StepScalingPolicyConfiguration StepScalingPolicyConfiguration
        {
            get { return this._stepScalingPolicyConfiguration; }
            set { this._stepScalingPolicyConfiguration = value; }
        }

        // Check to see if StepScalingPolicyConfiguration property is set
        internal bool IsSetStepScalingPolicyConfiguration()
        {
            return this._stepScalingPolicyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTrackingScalingPolicyConfiguration. 
        /// <para>
        /// A target tracking scaling policy.
        /// </para>
        /// </summary>
        public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration
        {
            get { return this._targetTrackingScalingPolicyConfiguration; }
            set { this._targetTrackingScalingPolicyConfiguration = value; }
        }

        // Check to see if TargetTrackingScalingPolicyConfiguration property is set
        internal bool IsSetTargetTrackingScalingPolicyConfiguration()
        {
            return this._targetTrackingScalingPolicyConfiguration != null;
        }

    }
}