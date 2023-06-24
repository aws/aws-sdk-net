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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for an Amazon RDS DB snapshot. You can propose
    /// a configuration for a new Amazon RDS DB snapshot or an Amazon RDS DB snapshot that
    /// you own by specifying the <code>RdsDbSnapshotAttributeValue</code> and optional KMS
    /// encryption key. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_ModifyDBSnapshotAttribute.html">ModifyDBSnapshotAttribute</a>.
    /// </summary>
    public partial class RdsDbSnapshotConfiguration
    {
        private Dictionary<string, RdsDbSnapshotAttributeValue> _attributes = new Dictionary<string, RdsDbSnapshotAttributeValue>();
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The names and values of manual DB snapshot attributes. Manual DB snapshot attributes
        /// are used to authorize other Amazon Web Services accounts to restore a manual DB snapshot.
        /// The only valid value for <code>attributeName</code> for the attribute map is restore.
        /// </para>
        /// </summary>
        public Dictionary<string, RdsDbSnapshotAttributeValue> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier for an encrypted Amazon RDS DB snapshot. The KMS key identifier
        /// is the key ARN, key ID, alias ARN, or alias name for the KMS key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the configuration is for an existing Amazon RDS DB snapshot and you do not specify
        /// the <code>kmsKeyId</code>, or you specify an empty string, then the access preview
        /// uses the existing <code>kmsKeyId</code> of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the access preview is for a new resource and you do not specify the specify the
        /// <code>kmsKeyId</code>, then the access preview considers the snapshot as unencrypted.
        /// </para>
        ///  </li> </ul>
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

    }
}