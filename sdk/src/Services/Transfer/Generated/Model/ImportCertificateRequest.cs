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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ImportCertificate operation.
    /// Imports the signing and encryption certificates that you need to create local (AS2)
    /// profiles and partner profiles.
    /// 
    ///  
    /// <para>
    /// You can import both the certificate and its chain in the <c>Certificate</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// After importing a certificate, Transfer Family automatically creates a Amazon CloudWatch
    /// metric called <c>DaysUntilExpiry</c> that tracks the number of days until the certificate
    /// expires. The metric is based on the <c>InactiveDate</c> parameter and is published
    /// daily in the <c>AWS/Transfer</c> namespace.
    /// </para>
    ///  <important> 
    /// <para>
    /// It can take up to a full day after importing a certificate for Transfer Family to
    /// emit the <c>DaysUntilExpiry</c> metric to your account.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// If you use the <c>Certificate</c> parameter to upload both the certificate and its
    /// chain, don't use the <c>CertificateChain</c> parameter.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>CloudWatch monitoring</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>DaysUntilExpiry</c> metric includes the following specifications:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Units:</b> Count (days)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Dimensions:</b> <c>CertificateId</c> (always present), <c>Description</c> (if
    /// provided during certificate import)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Statistics:</b> Minimum, Maximum, Average
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Frequency:</b> Published daily
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ImportCertificateRequest : AmazonTransferRequest
    {
        private DateTime? _activeDate;
        private string _certificate;
        private string _certificateChain;
        private string _description;
        private DateTime? _inactiveDate;
        private string _privateKey;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private CertificateUsageType _usage;

        /// <summary>
        /// Gets and sets the property ActiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes active. If you do not
        /// specify a value, <c>ActiveDate</c> takes the same value as <c>NotBeforeDate</c>, which
        /// is specified by the CA. 
        /// </para>
        /// </summary>
        public DateTime? ActiveDate
        {
            get { return this._activeDate; }
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
        /// For the CLI, provide a file path for a certificate in URI format. For example, <c>--certificate
        /// file://encryption-cert.pem</c>. Alternatively, you can provide the raw content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the SDK, specify the raw content of a certificate file. For example, <c>--certificate
        /// "`cat encryption-cert.pem`"</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can provide both the certificate and its chain in this parameter, without needing
        /// to use the <c>CertificateChain</c> parameter. If you use this parameter for both the
        /// certificate and its chain, do not use the <c>CertificateChain</c> parameter.
        /// </para>
        ///  </note>
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
        /// An optional date that specifies when the certificate becomes inactive. If you do not
        /// specify a value, <c>InactiveDate</c> takes the same value as <c>NotAfterDate</c>,
        /// which is specified by the CA.
        /// </para>
        /// </summary>
        public DateTime? InactiveDate
        {
            get { return this._inactiveDate; }
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
        /// For the CLI, provide a file path for a private key in URI format. For example, <c>--private-key
        /// file://encryption-key.pem</c>. Alternatively, you can provide the raw content of the
        /// private key file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the SDK, specify the raw content of a private key file. For example, <c>--private-key
        /// "`cat encryption-key.pem`"</c> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Specifies how this certificate is used. It can be used in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SIGNING</c>: For signing AS2 messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTION</c>: For encrypting AS2 messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TLS</c>: For securing AS2 communications sent over HTTPS
        /// </para>
        ///  </li> </ul>
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