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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveFromGlobalCluster operation.
    /// Detaches an Amazon DocumentDB secondary cluster from a global cluster. The cluster
    /// becomes a standalone cluster with read-write capability instead of being read-only
    /// and receiving data from a primary in a different region. 
    /// 
    ///  <note> 
    /// <para>
    /// This action only applies to Amazon DocumentDB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RemoveFromGlobalClusterRequest : AmazonDocDBRequest
    {
        private string _dbClusterIdentifier;
        private string _globalClusterIdentifier;

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) identifying the cluster that was detached from the
        /// Amazon DocumentDB global cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DbClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DbClusterIdentifier property is set
        internal bool IsSetDbClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The cluster identifier to detach from the Amazon DocumentDB global cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

    }
}