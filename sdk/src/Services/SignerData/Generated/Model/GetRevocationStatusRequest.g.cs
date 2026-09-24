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

namespace Amazon.SignerData.Model
{
    /// <summary>
    /// Container for the parameters to the GetRevocationStatus operation. Retrieves the revocation
    /// status for a signed artifact by checking if the signing profile, job, or certificate
    /// has been revoked.
    /// </summary>
    public partial class GetRevocationStatusRequest : AmazonSignerDataRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateHashes. 
        /// <para>
        /// List of certificate hashes to check for revocation.
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
        /// The ARN of the signing job that produced the signature.
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
        /// The platform identifier for the signing platform used.
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
        /// The ARN of the signing profile version used to sign the artifact.
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
        /// The timestamp when the artifact was signed, in ISO 8601 format.
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
