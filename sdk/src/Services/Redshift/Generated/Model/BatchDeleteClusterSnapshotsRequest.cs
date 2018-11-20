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
    /// Container for the parameters to the BatchDeleteClusterSnapshots operation.
    /// Deletes a set of cluster snapshots.
    /// </summary>
    public partial class BatchDeleteClusterSnapshotsRequest : AmazonRedshiftRequest
    {
        private List<DeleteClusterSnapshotMessage> _identifiers = new List<DeleteClusterSnapshotMessage>();

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// A list of identifiers for the snapshots that you want to delete.
        /// </para>
        /// </summary>
        public List<DeleteClusterSnapshotMessage> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && this._identifiers.Count > 0; 
        }

    }
}