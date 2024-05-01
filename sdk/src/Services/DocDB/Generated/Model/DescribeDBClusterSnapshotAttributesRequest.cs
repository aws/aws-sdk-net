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
    /// Container for the parameters to the DescribeDBClusterSnapshotAttributes operation.
    /// Returns a list of cluster snapshot attribute names and values for a manual DB cluster
    /// snapshot.
    /// 
    ///  
    /// <para>
    /// When you share snapshots with other Amazon Web Services accounts, <c>DescribeDBClusterSnapshotAttributes</c>
    /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
    /// accounts that are authorized to copy or restore the manual cluster snapshot. If <c>all</c>
    /// is included in the list of values for the <c>restore</c> attribute, then the manual
    /// cluster snapshot is public and can be copied or restored by all Amazon Web Services
    /// accounts.
    /// </para>
    /// </summary>
    public partial class DescribeDBClusterSnapshotAttributesRequest : AmazonDocDBRequest
    {
        private string _dbClusterSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier for the cluster snapshot to describe the attributes for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
        }

    }
}