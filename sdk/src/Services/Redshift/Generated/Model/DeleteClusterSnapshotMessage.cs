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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeleteClusterSnapshotMessage
    {
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;

        /// <summary>
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster the snapshot was created from. This parameter
        /// is required if your IAM user has a policy containing a snapshot resource element that
        /// specifies anything other than * for the cluster name.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the name of valid cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotClusterIdentifier
        {
            get { return this._snapshotClusterIdentifier; }
            set { this._snapshotClusterIdentifier = value; }
        }

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this._snapshotClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The unique identifier of the manual snapshot to be deleted.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the name of an existing snapshot that is in the <code>available</code>,
        /// <code>failed</code>, or <code>cancelled</code> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

    }
}