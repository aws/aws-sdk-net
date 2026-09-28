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
    /// Contains information about a signing job.
    /// </summary>
    public partial class SigningJob
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the signing job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IsRevoked. 
        /// <para>
        /// Indicates whether the signing job is revoked.
        /// </para>
        /// </summary>
        public bool? IsRevoked { get; set; }

        /// <summary>
        /// Checks to see if the IsRevoked property is set.
        /// </summary>
        internal bool IsSetIsRevoked() => this.IsRevoked.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the signing job.
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
        /// The AWS account ID of the job invoker.
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
        /// Gets and sets the property PlatformDisplayName. 
        /// <para>
        /// The name of a signing platform.
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
        /// The unique identifier for a signing platform.
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
        /// The name of the signing profile that created a signing job.
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
        /// The version of the signing profile that created a signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ProfileVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersion property is set.
        /// </summary>
        internal bool IsSetProfileVersion() => this.ProfileVersion != null;

        /// <summary>
        /// Gets and sets the property SignatureExpiresAt. 
        /// <para>
        /// The time when the signature of a signing job expires.
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
        /// A <c>SignedObject</c> structure that contains information about a signing job's signed
        /// code image.
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
        /// A <c>SigningMaterial</c> object that contains the Amazon Resource Name (ARN) of the
        /// certificate used for the signing job.
        /// </para>
        /// </summary>
        public SigningMaterial SigningMaterial { get; set; }

        /// <summary>
        /// Checks to see if the SigningMaterial property is set.
        /// </summary>
        internal bool IsSetSigningMaterial() => this.SigningMaterial != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// A <c>Source</c> that contains information about a signing job's code image source.
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
        /// The status of the signing job.
        /// </para>
        /// </summary>
        public SigningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
