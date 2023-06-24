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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// If query and calculation results are encrypted in Amazon S3, indicates the encryption
    /// option used (for example, <code>SSE_KMS</code> or <code>CSE_KMS</code>) and key information.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private EncryptionOption _encryptionOption;
        private string _kmsKey;

        /// <summary>
        /// Gets and sets the property EncryptionOption. 
        /// <para>
        /// Indicates whether Amazon S3 server-side encryption with Amazon S3-managed keys (<code>SSE_S3</code>),
        /// server-side encryption with KMS-managed keys (<code>SSE_KMS</code>), or client-side
        /// encryption with KMS-managed keys (<code>CSE_KMS</code>) is used.
        /// </para>
        ///  
        /// <para>
        /// If a query runs in a workgroup and the workgroup overrides client-side settings, then
        /// the workgroup's setting for encryption is used. It specifies whether query results
        /// must be encrypted, for all queries that run in this workgroup. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionOption EncryptionOption
        {
            get { return this._encryptionOption; }
            set { this._encryptionOption = value; }
        }

        // Check to see if EncryptionOption property is set
        internal bool IsSetEncryptionOption()
        {
            return this._encryptionOption != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// For <code>SSE_KMS</code> and <code>CSE_KMS</code>, this is the KMS key ARN or ID.
        /// </para>
        /// </summary>
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

    }
}