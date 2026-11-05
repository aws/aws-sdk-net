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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the PutAutoScalingPolicy operation. Creates or updates
    /// an automatic scaling policy for a core instance group or task instance group in an
    /// Amazon EMR cluster. The automatic scaling policy defines how an instance group dynamically
    /// adds and terminates Amazon EC2 instances in response to the value of a CloudWatch
    /// metric.
    /// </summary>
    public partial class PutAutoScalingPolicyRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScalingPolicy. 
        /// <para>
        /// Specifies the definition of the automatic scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoScalingPolicy AutoScalingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingPolicy property is set.
        /// </summary>
        internal bool IsSetAutoScalingPolicy() => this.AutoScalingPolicy != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// Specifies the ID of a cluster. The instance group to which the automatic scaling policy
        /// is applied is within this cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// Specifies the ID of the instance group to which the automatic scaling policy is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupId property is set.
        /// </summary>
        internal bool IsSetInstanceGroupId() => this.InstanceGroupId != null;
    }
}
