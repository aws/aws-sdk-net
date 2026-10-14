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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AwsEncryptionKey. 
        /// <para>
        /// The configuration of the Amazon Web Services Key Management Service (KMS) encryption
        /// key.
        /// </para>
        /// </summary>
        public AwsEncryptionKeyConfiguration AwsEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the AwsEncryptionKey property is set.
        /// </summary>
        internal bool IsSetAwsEncryptionKey() => this.AwsEncryptionKey != null;

        /// <summary>
        /// Gets and sets the property OciEncryptionKey. 
        /// <para>
        /// The configuration of the Oracle Cloud Infrastructure (OCI) Vault encryption key.
        /// </para>
        /// </summary>
        public OciEncryptionKeyConfiguration OciEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the OciEncryptionKey property is set.
        /// </summary>
        internal bool IsSetOciEncryptionKey() => this.OciEncryptionKey != null;

        /// <summary>
        /// Gets and sets the property OkvEncryptionKey. 
        /// <para>
        /// The configuration of the Oracle Key Vault (OKV) encryption key.
        /// </para>
        /// </summary>
        public OkvEncryptionKeyConfiguration OkvEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the OkvEncryptionKey property is set.
        /// </summary>
        internal bool IsSetOkvEncryptionKey() => this.OkvEncryptionKey != null;
    }
}
