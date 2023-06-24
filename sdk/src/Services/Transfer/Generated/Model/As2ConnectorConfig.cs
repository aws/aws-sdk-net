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
    /// Contains the details for a connector object. The connector object is used for AS2
    /// outbound processes, to connect the Transfer Family customer with the trading partner.
    /// </summary>
    public partial class As2ConnectorConfig
    {
        private CompressionEnum _compression;
        private EncryptionAlg _encryptionAlgorithm;
        private string _localProfileId;
        private MdnResponse _mdnResponse;
        private MdnSigningAlg _mdnSigningAlgorithm;
        private string _messageSubject;
        private string _partnerProfileId;
        private SigningAlg _signingAlgorithm;

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
        ///  <note> 
        /// <para>
        /// You can only specify <code>NONE</code> if the URL for your connector uses HTTPS. This
        /// ensures that no traffic is sent in clear text.
        /// </para>
        ///  </note>
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
        /// Used for outbound requests (from an Transfer Family server to a partner AS2 server)
        /// to determine whether the partner response for transfers is synchronous or asynchronous.
        /// Specify either of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SYNC</code>: The system expects a synchronous MDN response, confirming that
        /// the file was transferred successfully (or not).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NONE</code>: Specifies that no MDN response is required.
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
        /// If set to DEFAULT (or not set at all), the value for <code>SigningAlgorithm</code>
        /// is used.
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
        /// Used as the <code>Subject</code> HTTP header attribute in AS2 messages that are being
        /// sent with the connector.
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