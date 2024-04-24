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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreFromSnapshot operation.
    /// Restores a directory using an existing directory snapshot.
    /// 
    ///  
    /// <para>
    /// When you restore a directory from a snapshot, any changes made to the directory after
    /// the snapshot date are overwritten.
    /// </para>
    ///  
    /// <para>
    /// This action returns as soon as the restore operation is initiated. You can monitor
    /// the progress of the restore operation by calling the <a>DescribeDirectories</a> operation
    /// with the directory identifier. When the <b>DirectoryDescription.Stage</b> value changes
    /// to <c>Active</c>, the restore operation is complete.
    /// </para>
    /// </summary>
    public partial class RestoreFromSnapshotRequest : AmazonDirectoryServiceRequest
    {
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The identifier of the snapshot to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}