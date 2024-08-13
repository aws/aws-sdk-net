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
    /// Contains information about a signing job.
    /// </summary>
    public partial class SigningJob
    {
        private DateTime? _createdAt;
        private bool? _isRevoked;
        private string _jobId;
        private string _jobInvoker;
        private string _jobOwner;
        private string _platformDisplayName;
        private string _platformId;
        private string _profileName;
        private string _profileVersion;
        private DateTime? _signatureExpiresAt;
        private SignedObject _signedObject;
        private SigningMaterial _signingMaterial;
        private Source _source;
        private SigningStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the signing job was created.
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
        /// Gets and sets the property IsRevoked. 
        /// <para>
        /// Indicates whether the signing job is revoked.
        /// </para>
        /// </summary>
        public bool? IsRevoked
        {
            get { return this._isRevoked; }
            set { this._isRevoked = value; }
        }

        // Check to see if IsRevoked property is set
        internal bool IsSetIsRevoked()
        {
            return this._isRevoked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the signing job.
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
        /// The AWS account ID of the job invoker.
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
        /// Gets and sets the property PlatformDisplayName. 
        /// <para>
        /// The name of a signing platform.
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
        /// The unique identifier for a signing platform.
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
        /// The name of the signing profile that created a signing job.
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
        /// The version of the signing profile that created a signing job.
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
        /// Gets and sets the property SignatureExpiresAt. 
        /// <para>
        /// The time when the signature of a signing job expires.
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
        /// A <c>SignedObject</c> structure that contains information about a signing job's signed
        /// code image.
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
        /// A <c>SigningMaterial</c> object that contains the Amazon Resource Name (ARN) of the
        /// certificate used for the signing job.
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
        /// Gets and sets the property Source. 
        /// <para>
        /// A <c>Source</c> that contains information about a signing job's code image source.
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
        /// The status of the signing job.
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

    }
}