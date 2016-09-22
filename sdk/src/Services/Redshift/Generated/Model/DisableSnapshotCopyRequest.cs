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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DisableSnapshotCopy operation.
    /// Disables the automatic copying of snapshots from one region to another region for
    /// a specified cluster.
    /// 
    ///  
    /// <para>
    /// If your cluster and its snapshots are encrypted using a customer master key (CMK)
    /// from AWS KMS, use <a>DeleteSnapshotCopyGrant</a> to delete the grant that grants Amazon
    /// Redshift permission to the CMK in the destination region. 
    /// </para>
    /// </summary>
    public partial class DisableSnapshotCopyRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the source cluster that you want to disable copying of snapshots
        /// to a destination region.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the valid name of an existing cluster that has cross-region snapshot
        /// copy enabled.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

    }
}