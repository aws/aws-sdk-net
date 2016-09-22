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
    /// Container for the parameters to the CreateSnapshotCopyGrant operation.
    /// Creates a snapshot copy grant that permits Amazon Redshift to use a customer master
    /// key (CMK) from AWS Key Management Service (AWS KMS) to encrypt copied snapshots in
    /// a destination region.
    /// 
    ///  
    /// <para>
    ///  For more information about managing snapshot copy grants, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
    /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateSnapshotCopyGrantRequest : AmazonRedshiftRequest
    {
        private string _kmsKeyId;
        private string _snapshotCopyGrantName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The unique identifier of the customer master key (CMK) to which to grant Amazon Redshift
        /// permission. If no key is specified, the default key is used.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCopyGrantName. 
        /// <para>
        /// The name of the snapshot copy grant. This name must be unique in the region for the
        /// AWS account.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alphabetic characters must be lowercase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be unique for all clusters within an AWS account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SnapshotCopyGrantName
        {
            get { return this._snapshotCopyGrantName; }
            set { this._snapshotCopyGrantName = value; }
        }

        // Check to see if SnapshotCopyGrantName property is set
        internal bool IsSetSnapshotCopyGrantName()
        {
            return this._snapshotCopyGrantName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
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

    }
}