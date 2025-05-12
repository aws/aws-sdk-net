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
    /// Contains the details for an AS2 connector object. The connector object is used for
    /// AS2 outbound processes, to connect the Transfer Family customer with the trading partner.
    /// </summary>
    public partial class As2ConnectorConfig
    {
        private string _basicAuthSecretId;
        private CompressionEnum _compression;
        private EncryptionAlg _encryptionAlgorithm;
        private string _localProfileId;
        private MdnResponse _mdnResponse;
        private MdnSigningAlg _mdnSigningAlgorithm;
        private string _messageSubject;
        private string _partnerProfileId;
        private PreserveContentType _preserveContentType;
        private SigningAlg _signingAlgorithm;

        /// <summary>
        /// Gets and sets the property BasicAuthSecretId. 
        /// <para>
        /// Provides Basic authentication support to the AS2 Connectors API. To use Basic authentication,
        /// you must provide the name or Amazon Resource Name (ARN) of a secret in Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// The default value for this parameter is <c>null</c>, which indicates that Basic authentication
        /// is not enabled for the connector.
        /// </para>
        ///  
        /// <para>
        /// If the connector should use Basic authentication, the secret needs to be in the following
        /// format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "Username": "user-name", "Password": "user-password" }</c> 
        /// </para>
        ///  
        /// <para>
        /// Replace <c>user-name</c> and <c>user-password</c> with the credentials for the actual
        /// user that is being authenticated.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are storing these credentials in Secrets Manager, <i>not passing them directly</i>
        /// into this API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using the API, SDKs, or CloudFormation to configure your connector, then
        /// you must create the secret before you can enable Basic authentication. However, if
        /// you are using the Amazon Web Services management console, you can have the system
        /// create the secret for you.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you have previously enabled Basic authentication for a connector, you can disable
        /// it by using the <c>UpdateConnector</c> API call. For example, if you are using the
        /// CLI, you can run the following command to remove Basic authentication:
        /// </para>
        ///  
        /// <para>
        ///  <c>update-connector --connector-id my-connector-id --as2-config 'BasicAuthSecretId=""'</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string BasicAuthSecretId
        {
            get { return this._basicAuthSecretId; }
            set { this._basicAuthSecretId = value; }
        }

        // Check to see if BasicAuthSecretId property is set
        internal bool IsSetBasicAuthSecretId()
        {
            return this._basicAuthSecretId != null;
        }

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// Specifies whether the AS2 file is compressed.
        /// </para>
        /// </summary>
        public CompressionEnum Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }

        // Check to see if Compression property is set
        internal bool IsSetCompression()
        {
            return this._compression != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// The algorithm that is used to encrypt the file.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Do not use the <c>DES_EDE3_CBC</c> algorithm unless you must support a legacy client
        /// that requires it, as it is a weak encryption algorithm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only specify <c>NONE</c> if the URL for your connector uses HTTPS. Using HTTPS
        /// ensures that no traffic is sent in clear text.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionAlg EncryptionAlgorithm
        {
            get { return this._encryptionAlgorithm; }
            set { this._encryptionAlgorithm = value; }
        }

        // Check to see if EncryptionAlgorithm property is set
        internal bool IsSetEncryptionAlgorithm()
        {
            return this._encryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property LocalProfileId. 
        /// <para>
        /// A unique identifier for the AS2 local profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string LocalProfileId
        {
            get { return this._localProfileId; }
            set { this._localProfileId = value; }
        }

        // Check to see if LocalProfileId property is set
        internal bool IsSetLocalProfileId()
        {
            return this._localProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property MdnResponse. 
        /// <para>
        /// Used for outbound requests (from an Transfer Family connector to a partner AS2 server)
        /// to determine whether the partner response for transfers is synchronous or asynchronous.
        /// Specify either of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYNC</c>: The system expects a synchronous MDN response, confirming that the file
        /// was transferred successfully (or not).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Specifies that no MDN response is required.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MdnResponse MdnResponse
        {
            get { return this._mdnResponse; }
            set { this._mdnResponse = value; }
        }

        // Check to see if MdnResponse property is set
        internal bool IsSetMdnResponse()
        {
            return this._mdnResponse != null;
        }

        /// <summary>
        /// Gets and sets the property MdnSigningAlgorithm. 
        /// <para>
        /// The signing algorithm for the MDN response.
        /// </para>
        ///  <note> 
        /// <para>
        /// If set to DEFAULT (or not set at all), the value for <c>SigningAlgorithm</c> is used.
        /// </para>
        ///  </note>
        /// </summary>
        public MdnSigningAlg MdnSigningAlgorithm
        {
            get { return this._mdnSigningAlgorithm; }
            set { this._mdnSigningAlgorithm = value; }
        }

        // Check to see if MdnSigningAlgorithm property is set
        internal bool IsSetMdnSigningAlgorithm()
        {
            return this._mdnSigningAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property MessageSubject. 
        /// <para>
        /// Used as the <c>Subject</c> HTTP header attribute in AS2 messages that are being sent
        /// with the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string MessageSubject
        {
            get { return this._messageSubject; }
            set { this._messageSubject = value; }
        }

        // Check to see if MessageSubject property is set
        internal bool IsSetMessageSubject()
        {
            return this._messageSubject != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerProfileId. 
        /// <para>
        /// A unique identifier for the partner profile for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string PartnerProfileId
        {
            get { return this._partnerProfileId; }
            set { this._partnerProfileId = value; }
        }

        // Check to see if PartnerProfileId property is set
        internal bool IsSetPartnerProfileId()
        {
            return this._partnerProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveContentType. 
        /// <para>
        /// Allows you to use the Amazon S3 <c>Content-Type</c> that is associated with objects
        /// in S3 instead of having the content type mapped based on the file extension. This
        /// parameter is enabled by default when you create an AS2 connector from the console,
        /// but disabled by default when you create an AS2 connector by calling the API directly.
        /// </para>
        /// </summary>
        public PreserveContentType PreserveContentType
        {
            get { return this._preserveContentType; }
            set { this._preserveContentType = value; }
        }

        // Check to see if PreserveContentType property is set
        internal bool IsSetPreserveContentType()
        {
            return this._preserveContentType != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The algorithm that is used to sign the AS2 messages sent with the connector.
        /// </para>
        /// </summary>
        public SigningAlg SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

    }
}