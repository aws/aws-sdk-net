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
    /// The configuration of the Oracle Key Vault (OKV) encryption key used for an Autonomous
    /// Database.
    /// </summary>
    public partial class OkvEncryptionKeyConfiguration
    {
        private string _certificateDirectoryName;
        private string _certificateId;
        private string _directoryName;
        private string _okvKmsKey;
        private string _okvUri;

        /// <summary>
        /// Gets and sets the property CertificateDirectoryName. 
        /// <para>
        /// The name of the directory that contains the Oracle Key Vault (OKV) certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CertificateDirectoryName
        {
            get { return this._certificateDirectoryName; }
            set { this._certificateDirectoryName = value; }
        }

        // Check to see if CertificateDirectoryName property is set
        internal bool IsSetCertificateDirectoryName()
        {
            return this._certificateDirectoryName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The identifier of the Oracle Key Vault (OKV) certificate.
        /// </para>
        /// </summary>
        public string CertificateId
        {
            get { return this._certificateId; }
            set { this._certificateId = value; }
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The name of the directory where the Oracle Key Vault (OKV) configuration is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryName
        {
            get { return this._directoryName; }
            set { this._directoryName = value; }
        }

        // Check to see if DirectoryName property is set
        internal bool IsSetDirectoryName()
        {
            return this._directoryName != null;
        }

        /// <summary>
        /// Gets and sets the property OkvKmsKey. 
        /// <para>
        /// The identifier of the Oracle Key Vault (OKV) key to use for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OkvKmsKey
        {
            get { return this._okvKmsKey; }
            set { this._okvKmsKey = value; }
        }

        // Check to see if OkvKmsKey property is set
        internal bool IsSetOkvKmsKey()
        {
            return this._okvKmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property OkvUri. 
        /// <para>
        /// The URI of the Oracle Key Vault (OKV) server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OkvUri
        {
            get { return this._okvUri; }
            set { this._okvUri = value; }
        }

        // Check to see if OkvUri property is set
        internal bool IsSetOkvUri()
        {
            return this._okvUri != null;
        }

    }
}