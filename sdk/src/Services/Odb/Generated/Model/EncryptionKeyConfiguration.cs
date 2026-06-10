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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration of the encryption key used for an Autonomous Database. This is a
    /// union, so only one of the following members can be specified.
    /// </summary>
    public partial class EncryptionKeyConfiguration
    {
        private AwsEncryptionKeyConfiguration _awsEncryptionKey;
        private OciEncryptionKeyConfiguration _ociEncryptionKey;
        private OkvEncryptionKeyConfiguration _okvEncryptionKey;

        /// <summary>
        /// Gets and sets the property AwsEncryptionKey. 
        /// <para>
        /// The configuration of the Amazon Web Services Key Management Service (KMS) encryption
        /// key.
        /// </para>
        /// </summary>
        public AwsEncryptionKeyConfiguration AwsEncryptionKey
        {
            get { return this._awsEncryptionKey; }
            set { this._awsEncryptionKey = value; }
        }

        // Check to see if AwsEncryptionKey property is set
        internal bool IsSetAwsEncryptionKey()
        {
            return this._awsEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property OciEncryptionKey. 
        /// <para>
        /// The configuration of the Oracle Cloud Infrastructure (OCI) Vault encryption key.
        /// </para>
        /// </summary>
        public OciEncryptionKeyConfiguration OciEncryptionKey
        {
            get { return this._ociEncryptionKey; }
            set { this._ociEncryptionKey = value; }
        }

        // Check to see if OciEncryptionKey property is set
        internal bool IsSetOciEncryptionKey()
        {
            return this._ociEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property OkvEncryptionKey. 
        /// <para>
        /// The configuration of the Oracle Key Vault (OKV) encryption key.
        /// </para>
        /// </summary>
        public OkvEncryptionKeyConfiguration OkvEncryptionKey
        {
            get { return this._okvEncryptionKey; }
            set { this._okvEncryptionKey = value; }
        }

        // Check to see if OkvEncryptionKey property is set
        internal bool IsSetOkvEncryptionKey()
        {
            return this._okvEncryptionKey != null;
        }

    }
}