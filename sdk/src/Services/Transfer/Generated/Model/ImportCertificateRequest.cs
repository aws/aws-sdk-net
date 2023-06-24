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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ImportCertificate operation.
    /// Imports the signing and encryption certificates that you need to create local (AS2)
    /// profiles and partner profiles.
    /// </summary>
    public partial class ImportCertificateRequest : AmazonTransferRequest
    {
        private DateTime? _activeDate;
        private string _certificate;
        private string _certificateChain;
        private string _description;
        private DateTime? _inactiveDate;
        private string _privateKey;
        private List<Tag> _tags = new List<Tag>();
        private CertificateUsageType _usage;

        /// <summary>
        /// Gets and sets the property ActiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes active.
        /// </para>
        /// </summary>
        public DateTime ActiveDate
        {
            get { return this._activeDate.GetValueOrDefault(); }
            set { this._activeDate = value; }
        }

        // Check to see if ActiveDate property is set
        internal bool IsSetActiveDate()
        {
            return this._activeDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Certificate. <ul> <li> 
        /// <para>
        /// For the CLI, provide a file path for a certificate in URI format. For example, <code>--certificate
        /// file://encryption-cert.pem</code>. Alternatively, you can provide the raw content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the SDK, specify the raw content of a certificate file. For example, <code>--certificate
        /// "`cat encryption-cert.pem`"</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=16384)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// An optional list of certificates that make up the chain for the certificate that's
        /// being imported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2097152)]
        public string CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short description that helps identify the certificate. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InactiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes inactive.
        /// </para>
        /// </summary>
        public DateTime InactiveDate
        {
            get { return this._inactiveDate.GetValueOrDefault(); }
            set { this._inactiveDate = value; }
        }

        // Check to see if InactiveDate property is set
        internal bool IsSetInactiveDate()
        {
            return this._inactiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. <ul> <li> 
        /// <para>
        /// For the CLI, provide a file path for a private key in URI format.For example, <code>--private-key
        /// file://encryption-key.pem</code>. Alternatively, you can provide the raw content of
        /// the private key file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the SDK, specify the raw content of a private key file. For example, <code>--private-key
        /// "`cat encryption-key.pem`"</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=16384)]
        public string PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Usage. 
        /// <para>
        /// Specifies whether this certificate is used for signing or encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateUsageType Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}