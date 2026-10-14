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
    /// The configuration of the Oracle Key Vault (OKV) encryption key used for an Autonomous
    /// Database.
    /// </summary>
    public partial class OkvEncryptionKeyConfiguration
    {
        /// <summary>
        /// Gets and sets the property CertificateDirectoryName. 
        /// <para>
        /// The name of the directory that contains the Oracle Key Vault (OKV) certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CertificateDirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateDirectoryName property is set.
        /// </summary>
        internal bool IsSetCertificateDirectoryName() => this.CertificateDirectoryName != null;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The identifier of the Oracle Key Vault (OKV) certificate.
        /// </para>
        /// </summary>
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The name of the directory where the Oracle Key Vault (OKV) configuration is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryName property is set.
        /// </summary>
        internal bool IsSetDirectoryName() => this.DirectoryName != null;

        /// <summary>
        /// Gets and sets the property OkvKmsKey. 
        /// <para>
        /// The identifier of the Oracle Key Vault (OKV) key to use for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OkvKmsKey { get; set; }

        /// <summary>
        /// Checks to see if the OkvKmsKey property is set.
        /// </summary>
        internal bool IsSetOkvKmsKey() => this.OkvKmsKey != null;

        /// <summary>
        /// Gets and sets the property OkvUri. 
        /// <para>
        /// The URI of the Oracle Key Vault (OKV) server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OkvUri { get; set; }

        /// <summary>
        /// Checks to see if the OkvUri property is set.
        /// </summary>
        internal bool IsSetOkvUri() => this.OkvUri != null;
    }
}
