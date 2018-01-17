/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Specifies the scaling configuration for a scalable resource.
    /// </summary>
    public partial class ScalingInstruction
    {
        private int? _maxCapacity;
        private int? _minCapacity;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;
        private List<TargetTrackingConfiguration> _targetTrackingConfigurations = new List<TargetTrackingConfiguration>();

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum value to scale to in response to a scale out event.
        /// </para>
        /// </summary>
        public int MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
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
        /// The minimum value to scale to in response to a scale in event.
        /// </para>
        /// </summary>
        public int MinCapacity
        {
            get { return this._minCapacity.GetValueOrDefault(); }
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
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto Scaling group - The resource type is <code>autoScalingGroup</code> and the unique
        /// identifier is the name of the Auto Scaling group. Example: <code>autoScalingGroup/my-asg</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECS service - The resource type is <code>service</code> and the unique identifier
        /// is the cluster name and service name. Example: <code>service/default/sample-webapp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot fleet request - The resource type is <code>spot-fleet-request</code> and the
        /// unique identifier is the Spot fleet request ID. Example: <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <code>table</code> and the unique identifier
        /// is the resource ID. Example: <code>table/my-table</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <code>index</code> and the
        /// unique identifier is the resource ID. Example: <code>table/my-table/index/my-table-index</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <code>cluster</code> and the unique identifier
        /// is the cluster name. Example: <code>cluster:my-db-cluster</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// The scalable dimension associated with the resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>autoscaling:autoScalingGroup:DesiredCapacity</code> - The desired capacity
        /// of an Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ecs:service:DesiredCount</code> - The desired task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:spot-fleet-request:TargetCapacity</code> - The target capacity of a Spot
        /// fleet request.
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
        /// DB cluster. Available for Aurora MySQL-compatible edition.
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
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TargetTrackingConfigurations. 
        /// <para>
        /// The target tracking scaling policies (up to 10).
        /// </para>
        /// </summary>
        public List<TargetTrackingConfiguration> TargetTrackingConfigurations
        {
            get { return this._targetTrackingConfigurations; }
            set { this._targetTrackingConfigurations = value; }
        }

        // Check to see if TargetTrackingConfigurations property is set
        internal bool IsSetTargetTrackingConfigurations()
        {
            return this._targetTrackingConfigurations != null && this._targetTrackingConfigurations.Count > 0; 
        }

    }
}