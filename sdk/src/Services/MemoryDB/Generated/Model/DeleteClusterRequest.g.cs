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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCluster operation. Deletes a cluster. It
    /// also deletes all associated nodes and node endpoints. <note> <para> <c>CreateSnapshot</c>
    /// permission is required to create a final snapshot. Without this permission, the API
    /// call will fail with an <c>Access Denied</c> exception. </para> </note>
    /// </summary>
    public partial class DeleteClusterRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to be deleted
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property FinalSnapshotName. 
        /// <para>
        /// The user-supplied name of a final cluster snapshot. This is the unique name that identifies
        /// the snapshot. MemoryDB creates the snapshot, and then deletes the cluster immediately
        /// afterward.
        /// </para>
        /// </summary>
        public string FinalSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the FinalSnapshotName property is set.
        /// </summary>
        internal bool IsSetFinalSnapshotName() => this.FinalSnapshotName != null;

        /// <summary>
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name of the multi-Region cluster to be deleted.
        /// </para>
        /// </summary>
        public string MultiRegionClusterName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionClusterName property is set.
        /// </summary>
        internal bool IsSetMultiRegionClusterName() => this.MultiRegionClusterName != null;
    }
}
