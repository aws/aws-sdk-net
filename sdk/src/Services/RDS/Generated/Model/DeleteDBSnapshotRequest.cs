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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the DeleteDBSnapshot operation.
    /// Deletes a DB snapshot. If the snapshot is being copied, the copy operation is terminated.
    /// 
    ///  <note> 
    /// <para>
    /// The DB snapshot must be in the <c>available</c> state to be deleted.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDBSnapshotRequest : AmazonRDSRequest
    {
        private string _dbSnapshotIdentifier;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDBSnapshotRequest() { }

        /// <summary>
        /// Instantiates DeleteDBSnapshotRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSnapshotIdentifier">The DB snapshot identifier. Constraints: Must be the name of an existing DB snapshot in the <c>available</c> state.</param>
        public DeleteDBSnapshotRequest(string dbSnapshotIdentifier)
        {
            _dbSnapshotIdentifier = dbSnapshotIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The DB snapshot identifier.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the name of an existing DB snapshot in the <c>available</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

    }
}