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
    /// This is the response object from the GetSigningProfile operation.
    /// </summary>
    public partial class GetSigningProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the signing profile.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of overrides applied by the target signing profile for signing operations.
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
        /// A human-readable name for the signing platform associated with the signing profile.
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
        /// The ID of the platform that is used by the target signing profile.
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
        /// The name of the target signing profile.
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
        /// The current version of the signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ProfileVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersion property is set.
        /// </summary>
        internal bool IsSetProfileVersion() => this.ProfileVersion != null;

        /// <summary>
        /// Gets and sets the property ProfileVersionArn. 
        /// <para>
        /// The signing profile ARN, including the profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProfileVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersionArn property is set.
        /// </summary>
        internal bool IsSetProfileVersionArn() => this.ProfileVersionArn != null;

        /// <summary>
        /// Gets and sets the property RevocationRecord.
        /// </summary>
        public SigningProfileRevocationRecord RevocationRecord { get; set; }

        /// <summary>
        /// Checks to see if the RevocationRecord property is set.
        /// </summary>
        internal bool IsSetRevocationRecord() => this.RevocationRecord != null;

        /// <summary>
        /// Gets and sets the property SignatureValidityPeriod.
        /// </summary>
        public SignatureValidityPeriod SignatureValidityPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SignatureValidityPeriod property is set.
        /// </summary>
        internal bool IsSetSignatureValidityPeriod() => this.SignatureValidityPeriod != null;

        /// <summary>
        /// Gets and sets the property SigningMaterial. 
        /// <para>
        /// The ARN of the certificate that the target profile uses for signing operations.
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
        /// A map of key-value pairs for signing operations that is attached to the target signing
        /// profile.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the target signing profile.
        /// </para>
        /// </summary>
        public SigningProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Reason for the status of the target signing profile.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the signing profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
