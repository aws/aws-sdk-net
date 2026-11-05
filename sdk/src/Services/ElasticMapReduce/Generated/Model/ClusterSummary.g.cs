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
    /// The summary description of the cluster.
    /// </summary>
    public partial class ClusterSummary
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NormalizedInstanceHours. 
        /// <para>
        /// An approximation of the cost of the cluster, represented in m1.small/hours. This value
        /// is incremented one time for every hour an m1.small instance runs. Larger instances
        /// are weighted more, so an Amazon EC2 instance that is roughly four times more expensive
        /// would result in the normalized instance hours being incremented by four. This result
        /// is only an approximation and does not reflect the actual billing rate.
        /// </para>
        /// </summary>
        public int? NormalizedInstanceHours { get; set; }

        /// <summary>
        /// Checks to see if the NormalizedInstanceHours property is set.
        /// </summary>
        internal bool IsSetNormalizedInstanceHours() => this.NormalizedInstanceHours.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Outpost where the cluster is launched. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The details about the current status of the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
