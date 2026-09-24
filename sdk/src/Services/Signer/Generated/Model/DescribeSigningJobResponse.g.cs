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
    /// This is the response object from the DescribeSigningJob operation.
    /// </summary>
    public partial class DescribeSigningJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Date and time that the signing job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date and time that the signing job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the signing job on output.
        /// </para>
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobInvoker. 
        /// <para>
        /// The IAM entity that initiated the signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string JobInvoker { get; set; }

        /// <summary>
        /// Checks to see if the JobInvoker property is set.
        /// </summary>
        internal bool IsSetJobInvoker() => this.JobInvoker != null;

        /// <summary>
        /// Gets and sets the property JobOwner. 
        /// <para>
        /// The AWS account ID of the job owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string JobOwner { get; set; }

        /// <summary>
        /// Checks to see if the JobOwner property is set.
        /// </summary>
        internal bool IsSetJobOwner() => this.JobOwner != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of any overrides that were applied to the signing operation.
        /// </para>
        /// </summary>
        public SigningPlatformOverrides Overrides { get; set; }

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null;

        /// <summary>
        /// Gets and sets the property PlatformDisplayName. 
        /// <para>
        /// A human-readable name for the signing platform associated with the signing job.
        /// </para>
        /// </summary>
        public string PlatformDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformDisplayName property is set.
        /// </summary>
        internal bool IsSetPlatformDisplayName() => this.PlatformDisplayName != null;

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The microcontroller platform to which your signed code image will be distributed.
        /// </para>
        /// </summary>
        public string PlatformId { get; set; }

        /// <summary>
        /// Checks to see if the PlatformId property is set.
        /// </summary>
        internal bool IsSetPlatformId() => this.PlatformId != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the profile that initiated the signing operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version of the signing profile used to initiate the signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ProfileVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersion property is set.
        /// </summary>
        internal bool IsSetProfileVersion() => this.ProfileVersion != null;

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The IAM principal that requested the signing job.
        /// </para>
        /// </summary>
        public string RequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the RequestedBy property is set.
        /// </summary>
        internal bool IsSetRequestedBy() => this.RequestedBy != null;

        /// <summary>
        /// Gets and sets the property RevocationRecord. 
        /// <para>
        /// A revocation record if the signature generated by the signing job has been revoked.
        /// Contains a timestamp and the ID of the IAM entity that revoked the signature.
        /// </para>
        /// </summary>
        public SigningJobRevocationRecord RevocationRecord { get; set; }

        /// <summary>
        /// Checks to see if the RevocationRecord property is set.
        /// </summary>
        internal bool IsSetRevocationRecord() => this.RevocationRecord != null;

        /// <summary>
        /// Gets and sets the property SignatureExpiresAt. 
        /// <para>
        /// Thr expiration timestamp for the signature generated by the signing job.
        /// </para>
        /// </summary>
        public DateTime? SignatureExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the SignatureExpiresAt property is set.
        /// </summary>
        internal bool IsSetSignatureExpiresAt() => this.SignatureExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property SignedObject. 
        /// <para>
        /// Name of the S3 bucket where the signed code image is saved by AWS Signer.
        /// </para>
        /// </summary>
        public SignedObject SignedObject { get; set; }

        /// <summary>
        /// Checks to see if the SignedObject property is set.
        /// </summary>
        internal bool IsSetSignedObject() => this.SignedObject != null;

        /// <summary>
        /// Gets and sets the property SigningMaterial. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your code signing certificate.
        /// </para>
        /// </summary>
        public SigningMaterial SigningMaterial { get; set; }

        /// <summary>
        /// Checks to see if the SigningMaterial property is set.
        /// </summary>
        internal bool IsSetSigningMaterial() => this.SigningMaterial != null;

        /// <summary>
        /// Gets and sets the property SigningParameters. 
        /// <para>
        /// Map of user-assigned key-value pairs used during signing. These values contain any
        /// information that you specified for use in your signing job. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SigningParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SigningParameters property is set.
        /// </summary>
        internal bool IsSetSigningParameters() => this.SigningParameters != null && (this.SigningParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The object that contains the name of your S3 bucket or your raw code.
        /// </para>
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the signing job.
        /// </para>
        /// </summary>
        public SigningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// String value that contains the status reason.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
