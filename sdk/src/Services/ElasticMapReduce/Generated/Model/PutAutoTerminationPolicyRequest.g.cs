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
    /// Container for the parameters to the PutAutoTerminationPolicy operation. <note> <para>
    /// Auto-termination is supported in Amazon EMR releases 5.30.0 and 6.1.0 and later. For
    /// more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-auto-termination-policy.html">Using
    /// an auto-termination policy</a>. </para> </note> <para> Creates or updates an auto-termination
    /// policy for an Amazon EMR cluster. An auto-termination policy defines the amount of
    /// idle time in seconds after which a cluster automatically terminates. For alternative
    /// cluster termination options, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
    /// cluster termination</a>. </para>
    /// </summary>
    public partial class PutAutoTerminationPolicyRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property AutoTerminationPolicy. 
        /// <para>
        /// Specifies the auto-termination policy to attach to the cluster.
        /// </para>
        /// </summary>
        public AutoTerminationPolicy AutoTerminationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AutoTerminationPolicy property is set.
        /// </summary>
        internal bool IsSetAutoTerminationPolicy() => this.AutoTerminationPolicy != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// Specifies the ID of the Amazon EMR cluster to which the auto-termination policy will
        /// be attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;
    }
}
