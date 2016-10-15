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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSnapshot operation.
    /// Deletes an existing snapshot. When you receive a successful response from this operation,
    /// ElastiCache immediately begins deleting the snapshot; you cannot cancel or revert
    /// this operation.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is valid for Redis only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteSnapshotRequest : AmazonElastiCacheRequest
    {
        private string _snapshotName;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot to be deleted.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

    }
}