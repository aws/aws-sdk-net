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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveFromGlobalCluster operation. Detaches an
    /// Aurora secondary cluster from an Aurora global database cluster. The cluster becomes
    /// a standalone cluster with read-write capability instead of being read-only and receiving
    /// data from a primary cluster in a different Region. <note> <para> This operation only
    /// applies to Aurora DB clusters. </para> </note>
    /// </summary>
    public partial class RemoveFromGlobalClusterRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) identifying the cluster that was detached from the
        /// Aurora global database cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DbClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDbClusterIdentifier() => this.DbClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The cluster identifier to detach from the Aurora global database cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;
    }
}
