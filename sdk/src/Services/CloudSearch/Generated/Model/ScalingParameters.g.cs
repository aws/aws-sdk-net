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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The desired instance type and desired number of replicas of each index partition.
    /// </summary>
    public partial class ScalingParameters
    {
        /// <summary>
        /// Gets and sets the property DesiredInstanceType. 
        /// <para>
        /// The instance type that you want to preconfigure for your domain. For example, <c>search.m1.small</c>.
        /// </para>
        /// </summary>
        public PartitionInstanceType DesiredInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DesiredInstanceType property is set.
        /// </summary>
        internal bool IsSetDesiredInstanceType() => this.DesiredInstanceType != null;

        /// <summary>
        /// Gets and sets the property DesiredPartitionCount. 
        /// <para>
        /// The number of partitions you want to preconfigure for your domain. Only valid when
        /// you select <c>m2.2xlarge</c> as the desired instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DesiredPartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredPartitionCount property is set.
        /// </summary>
        internal bool IsSetDesiredPartitionCount() => this.DesiredPartitionCount.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredReplicationCount. 
        /// <para>
        /// The number of replicas you want to preconfigure for each index partition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DesiredReplicationCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredReplicationCount property is set.
        /// </summary>
        internal bool IsSetDesiredReplicationCount() => this.DesiredReplicationCount.HasValue;
    }
}
