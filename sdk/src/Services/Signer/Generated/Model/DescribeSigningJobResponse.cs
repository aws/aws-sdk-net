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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the DescribeSigningJob operation.
    /// </summary>
    public partial class DescribeSigningJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private string _jobId;
        private string _jobInvoker;
        private string _jobOwner;
        private SigningPlatformOverrides _overrides;
        private string _platformDisplayName;
        private string _platformId;
        private string _profileName;
        private string _profileVersion;
        private string _requestedBy;
        private SigningJobRevocationRecord _revocationRecord;
        private DateTime? _signatureExpiresAt;
        private SignedObject _signedObject;
        private SigningMaterial _signingMaterial;
        private Dictionary<string, string> _signingParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Source _source;
        private SigningStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Date and time that the signing job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date and time that the signing job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the signing job on output.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobInvoker. 
        /// <para>
        /// The IAM entity that initiated the signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string JobInvoker
        {
            get { return this._jobInvoker; }
            set { this._jobInvoker = value; }
        }

        // Check to see if JobInvoker property is set
        internal bool IsSetJobInvoker()
        {
            return this._jobInvoker != null;
        }

        /// <summary>
        /// Gets and sets the property JobOwner. 
        /// <para>
        /// The AWS account ID of the job owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string JobOwner
        {
            get { return this._jobOwner; }
            set { this._jobOwner = value; }
        }

        // Check to see if JobOwner property is set
        internal bool IsSetJobOwner()
        {
            return this._jobOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of any overrides that were applied to the signing operation.
        /// </para>
        /// </summary>
        public SigningPlatformOverrides Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformDisplayName. 
        /// <para>
        /// A human-readable name for the signing platform associated with the signing job.
        /// </para>
        /// </summary>
        public string PlatformDisplayName
        {
            get { return this._platformDisplayName; }
            set { this._platformDisplayName = value; }
        }

        // Check to see if PlatformDisplayName property is set
        internal bool IsSetPlatformDisplayName()
        {
            return this._platformDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The microcontroller platform to which your signed code image will be distributed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the profile that initiated the signing operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version of the signing profile used to initiate the signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string ProfileVersion
        {
            get { return this._profileVersion; }
            set { this._profileVersion = value; }
        }

        // Check to see if ProfileVersion property is set
        internal bool IsSetProfileVersion()
        {
            return this._profileVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The IAM principal that requested the signing job.
        /// </para>
        /// </summary>
        public string RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RevocationRecord. 
        /// <para>
        /// A revocation record if the signature generated by the signing job has been revoked.
        /// Contains a timestamp and the ID of the IAM entity that revoked the signature.
        /// </para>
        /// </summary>
        public SigningJobRevocationRecord RevocationRecord
        {
            get { return this._revocationRecord; }
            set { this._revocationRecord = value; }
        }

        // Check to see if RevocationRecord property is set
        internal bool IsSetRevocationRecord()
        {
            return this._revocationRecord != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureExpiresAt. 
        /// <para>
        /// Thr expiration timestamp for the signature generated by the signing job.
        /// </para>
        /// </summary>
        public DateTime? SignatureExpiresAt
        {
            get { return this._signatureExpiresAt; }
            set { this._signatureExpiresAt = value; }
        }

        // Check to see if SignatureExpiresAt property is set
        internal bool IsSetSignatureExpiresAt()
        {
            return this._signatureExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignedObject. 
        /// <para>
        /// Name of the S3 bucket where the signed code image is saved by AWS Signer.
        /// </para>
        /// </summary>
        public SignedObject SignedObject
        {
            get { return this._signedObject; }
            set { this._signedObject = value; }
        }

        // Check to see if SignedObject property is set
        internal bool IsSetSignedObject()
        {
            return this._signedObject != null;
        }

        /// <summary>
        /// Gets and sets the property SigningMaterial. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your code signing certificate.
        /// </para>
        /// </summary>
        public SigningMaterial SigningMaterial
        {
            get { return this._signingMaterial; }
            set { this._signingMaterial = value; }
        }

        // Check to see if SigningMaterial property is set
        internal bool IsSetSigningMaterial()
        {
            return this._signingMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property SigningParameters. 
        /// <para>
        /// Map of user-assigned key-value pairs used during signing. These values contain any
        /// information that you specified for use in your signing job. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SigningParameters
        {
            get { return this._signingParameters; }
            set { this._signingParameters = value; }
        }

        // Check to see if SigningParameters property is set
        internal bool IsSetSigningParameters()
        {
            return this._signingParameters != null && (this._signingParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The object that contains the name of your S3 bucket or your raw code.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the signing job.
        /// </para>
        /// </summary>
        public SigningStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// String value that contains the status reason.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}