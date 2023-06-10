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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the GetRevocationStatus operation.
    /// Retrieves the revocation status of one or more of the signing profile, signing job,
    /// and signing certificate.
    /// </summary>
    public partial class GetRevocationStatusRequest : AmazonSignerRequest
    {
        private List<string> _certificateHashes = new List<string>();
        private string _jobArn;
        private string _platformId;
        private string _profileVersionArn;
        private DateTime? _signatureTimestamp;

        /// <summary>
        /// Gets and sets the property CertificateHashes. 
        /// <para>
        /// A list of composite signed hashes that identify certificates.
        /// </para>
        ///  
        /// <para>
        /// A certificate identifier consists of a subject certificate TBS hash (signed by the
        /// parent CA) combined with a parent CA TBS hash (signed by the parent CA’s CA). Root
        /// certificates are defined as their own CA.
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
            return this._certificateHashes != null && this._certificateHashes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of a signing job.
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
        /// The ID of a signing platform. 
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
        /// The version of a signing profile.
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
        /// The timestamp of the signature that validates the profile or job.
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