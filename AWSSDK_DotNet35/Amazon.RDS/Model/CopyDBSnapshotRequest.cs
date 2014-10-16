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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
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
    /// Container for the parameters to the CopyDBSnapshot operation.
    /// Copies the specified DBSnapshot. The source DBSnapshot must be in the "available"
    /// state.
    /// </summary>
    public partial class CopyDBSnapshotRequest : AmazonRDSRequest
    {
        private string _sourceDBSnapshotIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property SourceDBSnapshotIdentifier. 
        /// <para>
        ///  The identifier for the source DB snapshot. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must specify a valid system snapshot in the "available" state.</li> <li>If
        /// the source snapshot is in the same region as the copy, specify a valid DB snapshot
        /// identifier.</li> <li>If the source snapshot is in a different region than the copy,
        /// specify a valid DB snapshot ARN. For more information, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html">
        /// Copying a DB Snapshot</a>.</li> </ul> 
        /// <para>
        /// Example: <code>rds:mydb-2012-04-02-00-01</code>
        /// </para>
        ///  
        /// <para>
        /// Example: <code>arn:aws:rds:rr-regn-1:123456789012:snapshot:mysql-instance1-snapshot-20130805</code>
        /// </para>
        /// </summary>
        public string SourceDBSnapshotIdentifier
        {
            get { return this._sourceDBSnapshotIdentifier; }
            set { this._sourceDBSnapshotIdentifier = value; }
        }

        // Check to see if SourceDBSnapshotIdentifier property is set
        internal bool IsSetSourceDBSnapshotIdentifier()
        {
            return this._sourceDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetDBSnapshotIdentifier. 
        /// <para>
        ///  The identifier for the copied snapshot. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Cannot be null, empty, or blank</li> <li>Must contain from 1 to 255 alphanumeric
        /// characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens</li> </ul> 
        /// <para>
        /// Example: <code>my-db-snapshot</code>
        /// </para>
        /// </summary>
        public string TargetDBSnapshotIdentifier
        {
            get { return this._targetDBSnapshotIdentifier; }
            set { this._targetDBSnapshotIdentifier = value; }
        }

        // Check to see if TargetDBSnapshotIdentifier property is set
        internal bool IsSetTargetDBSnapshotIdentifier()
        {
            return this._targetDBSnapshotIdentifier != null;
        }

    }
}