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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBSnapshot operation.
    /// Deletes a DBSnapshot. If the snapshot is being copied, the copy operation is terminated.
    /// </summary>
    public partial class DeleteDBSnapshotRequest : AmazonRDSRequest
    {
        private string _dBSnapshotIdentifier;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDBSnapshotRequest() { }

        /// <summary>
        /// Instantiates DeleteDBSnapshotRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSnapshotIdentifier"> The DBSnapshot identifier.  Constraints: Must be the name of an existing DB snapshot in the <code>available</code> state.</param>
        public DeleteDBSnapshotRequest(string dbSnapshotIdentifier)
        {
            _dBSnapshotIdentifier = dbSnapshotIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        ///  The DBSnapshot identifier. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the name of an existing DB snapshot in the <code>available</code>
        /// state.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dBSnapshotIdentifier; }
            set { this._dBSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dBSnapshotIdentifier != null;
        }

    }
}