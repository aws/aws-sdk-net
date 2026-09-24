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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the GetRevocationStatus operation. Retrieves the revocation
    /// status of one or more of the signing profile, signing job, and signing certificate.
    /// </summary>
    public partial class GetRevocationStatusRequest : AmazonSignerRequest
    {
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
        ///  
        /// <para>
        /// The following example shows how to calculate a hash for this parameter using OpenSSL
        /// commands: 
        /// </para>
        ///  
        /// <para>
        ///  <c>openssl asn1parse -in childCert.pem -strparse 4 -out childCert.tbs</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>openssl sha384 &lt; childCert.tbs -binary > childCertTbsHash</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>openssl asn1parse -in parentCert.pem -strparse 4 -out parentCert.tbs</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>openssl sha384 &lt; parentCert.tbs -binary > parentCertTbsHash xxd -p childCertTbsHash
        /// > certificateHash.hex xxd -p parentCertTbsHash >> certificateHash.hex</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>cat certificateHash.hex | tr -d '\n'</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> CertificateHashes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CertificateHashes property is set.
        /// </summary>
        internal bool IsSetCertificateHashes() => this.CertificateHashes != null && (this.CertificateHashes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of a signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of a signing platform. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlatformId { get; set; }

        /// <summary>
        /// Checks to see if the PlatformId property is set.
        /// </summary>
        internal bool IsSetPlatformId() => this.PlatformId != null;

        /// <summary>
        /// Gets and sets the property ProfileVersionArn. 
        /// <para>
        /// The version of a signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ProfileVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersionArn property is set.
        /// </summary>
        internal bool IsSetProfileVersionArn() => this.ProfileVersionArn != null;

        /// <summary>
        /// Gets and sets the property SignatureTimestamp. 
        /// <para>
        /// The timestamp of the signature that validates the profile or job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SignatureTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SignatureTimestamp property is set.
        /// </summary>
        internal bool IsSetSignatureTimestamp() => this.SignatureTimestamp.HasValue;
    }
}
