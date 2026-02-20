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
 * Do not modify this file. This file is generated from the signer-data-2017-08-25.normal.json service model.
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
namespace Amazon.SignerData.Model
{
    /// <summary>
    /// Container for the parameters to the GetRevocationStatus operation.
    /// Retrieves the revocation status for a signed artifact by checking if the signing profile,
    /// job, or certificate has been revoked.
    /// </summary>
    public partial class GetRevocationStatusRequest : AmazonSignerDataRequest
    {
        private List<string> _certificateHashes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _jobArn;
        private string _platformId;
        private string _profileVersionArn;
        private DateTime? _signatureTimestamp;

        /// <summary>
        /// Gets and sets the property CertificateHashes. 
        /// <para>
        /// List of certificate hashes to check for revocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CertificateHashes
        {
            get { return this._certificateHashes; }
            set { this._certificateHashes = value; }
        }

        // Check to see if CertificateHashes property is set
        internal bool IsSetCertificateHashes()
        {
            return this._certificateHashes != null && (this._certificateHashes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the signing job that produced the signature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The platform identifier for the signing platform used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlatformId
        {
            get { return this._platformId; }
            set { this._platformId = value; }
        }

        // Check to see if PlatformId property is set
        internal bool IsSetPlatformId()
        {
            return this._platformId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileVersionArn. 
        /// <para>
        /// The ARN of the signing profile version used to sign the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProfileVersionArn
        {
            get { return this._profileVersionArn; }
            set { this._profileVersionArn = value; }
        }

        // Check to see if ProfileVersionArn property is set
        internal bool IsSetProfileVersionArn()
        {
            return this._profileVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureTimestamp. 
        /// <para>
        /// The timestamp when the artifact was signed, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime SignatureTimestamp
        {
            get { return this._signatureTimestamp.GetValueOrDefault(); }
            set { this._signatureTimestamp = value; }
        }

        // Check to see if SignatureTimestamp property is set
        internal bool IsSetSignatureTimestamp()
        {
            return this._signatureTimestamp.HasValue; 
        }

    }
}