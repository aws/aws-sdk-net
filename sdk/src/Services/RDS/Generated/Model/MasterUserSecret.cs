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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the secret managed by RDS in Amazon Web Services Secrets Manager for the
    /// master user password.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
    /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
    /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
    /// Guide.</i> 
    /// </para>
    /// </summary>
    public partial class MasterUserSecret
    {
        private string _kmsKeyId;
        private string _secretArn;
        private string _secretStatus;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier that is used to encrypt the secret.
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret.
        /// </para>
        /// </summary>
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretStatus. 
        /// <para>
        /// The status of the secret.
        /// </para>
        ///  
        /// <para>
        /// The possible status values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>creating</code> - The secret is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>active</code> - The secret is available for normal use and rotation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rotating</code> - The secret is being rotated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>impaired</code> - The secret can be used to access database credentials, but
        /// it can't be rotated. A secret might have this status if, for example, permissions
        /// are changed so that RDS can no longer access either the secret or the KMS key for
        /// the secret.
        /// </para>
        ///  
        /// <para>
        /// When a secret has this status, you can correct the condition that caused the status.
        /// Alternatively, modify the DB instance to turn off automatic management of database
        /// credentials, and then modify the DB instance again to turn on automatic management
        /// of database credentials.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SecretStatus
        {
            get { return this._secretStatus; }
            set { this._secretStatus = value; }
        }

        // Check to see if SecretStatus property is set
        internal bool IsSetSecretStatus()
        {
            return this._secretStatus != null;
        }

    }
}