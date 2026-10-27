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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Represents a scalable resource.
    /// </summary>
    public partial class ScalingPlanResource
    {
        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto Scaling group - The resource type is <c>autoScalingGroup</c> and the unique identifier
        /// is the name of the Auto Scaling group. Example: <c>autoScalingGroup/my-asg</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECS service - The resource type is <c>service</c> and the unique identifier is the
        /// cluster name and service name. Example: <c>service/default/sample-webapp</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet request - The resource type is <c>spot-fleet-request</c> and the unique
        /// identifier is the Spot Fleet request ID. Example: <c>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <c>table</c> and the unique identifier is the
        /// resource ID. Example: <c>table/my-table</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <c>index</c> and the unique
        /// identifier is the resource ID. Example: <c>table/my-table/index/my-table-index</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <c>cluster</c> and the unique identifier
        /// is the cluster name. Example: <c>cluster:my-db-cluster</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension for the resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>autoscaling:autoScalingGroup:DesiredCapacity</c> - The desired capacity of an
        /// Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecs:service:DesiredCount</c> - The desired task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:spot-fleet-request:TargetCapacity</c> - The target capacity of a Spot Fleet
        /// request.
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
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalableDimension ScalableDimension { get; set; }

        /// <summary>
        /// Checks to see if the ScalableDimension property is set.
        /// </summary>
        internal bool IsSetScalableDimension() => this.ScalableDimension != null;

        /// <summary>
        /// Gets and sets the property ScalingPlanName. 
        /// <para>
        /// The name of the scaling plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ScalingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanName property is set.
        /// </summary>
        internal bool IsSetScalingPlanName() => this.ScalingPlanName != null;

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number of the scaling plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ScalingPlanVersion { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanVersion property is set.
        /// </summary>
        internal bool IsSetScalingPlanVersion() => this.ScalingPlanVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingPolicies. 
        /// <para>
        /// The scaling policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScalingPolicy> ScalingPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<ScalingPolicy>() : null;

        /// <summary>
        /// Checks to see if the ScalingPolicies property is set.
        /// </summary>
        internal bool IsSetScalingPolicies() => this.ScalingPolicies != null && (this.ScalingPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScalingStatusCode. 
        /// <para>
        /// The scaling status of the resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c> - The scaling configuration is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Inactive</c> - The scaling configuration is not active because the scaling plan
        /// is being created or the scaling configuration could not be applied. Check the status
        /// message for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartiallyActive</c> - The scaling configuration is partially active because the
        /// scaling plan is being created or deleted or the scaling configuration could not be
        /// fully applied. Check the status message for more information.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalingStatusCode ScalingStatusCode { get; set; }

        /// <summary>
        /// Checks to see if the ScalingStatusCode property is set.
        /// </summary>
        internal bool IsSetScalingStatusCode() => this.ScalingStatusCode != null;

        /// <summary>
        /// Gets and sets the property ScalingStatusMessage. 
        /// <para>
        /// A simple message about the current scaling status of the resource.
        /// </para>
        /// </summary>
        public string ScalingStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the ScalingStatusMessage property is set.
        /// </summary>
        internal bool IsSetScalingStatusMessage() => this.ScalingStatusMessage != null;

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceNamespace ServiceNamespace { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNamespace property is set.
        /// </summary>
        internal bool IsSetServiceNamespace() => this.ServiceNamespace != null;
    }
}
