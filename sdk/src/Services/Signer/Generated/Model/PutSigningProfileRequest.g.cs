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
    /// Container for the parameters to the PutSigningProfile operation. Creates a signing
    /// profile. A signing profile is a code-signing template that can be used to carry out
    /// a pre-defined signing job.
    /// </summary>
    public partial class PutSigningProfileRequest : AmazonSignerRequest
    {
        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A subfield of <c>platform</c>. This specifies any different configuration options
        /// that you want to apply to the chosen platform (such as a different <c>hash-algorithm</c>
        /// or <c>signing-algorithm</c>).
        /// </para>
        /// </summary>
        public SigningPlatformOverrides Overrides { get; set; }

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null;

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of the signing platform to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlatformId { get; set; }

        /// <summary>
        /// Checks to see if the PlatformId property is set.
        /// </summary>
        internal bool IsSetPlatformId() => this.PlatformId != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the signing profile to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property SignatureValidityPeriod. 
        /// <para>
        /// The default validity period override for any signature generated using this signing
        /// profile. If unspecified, the default is 135 months.
        /// </para>
        /// </summary>
        public SignatureValidityPeriod SignatureValidityPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SignatureValidityPeriod property is set.
        /// </summary>
        internal bool IsSetSignatureValidityPeriod() => this.SignatureValidityPeriod != null;

        /// <summary>
        /// Gets and sets the property SigningMaterial. 
        /// <para>
        /// The AWS Certificate Manager certificate that will be used to sign code with the new
        /// signing profile.
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
        /// Map of key-value pairs for signing. These can include any information that you want
        /// to use during signing.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be associated with the signing profile that is being created.
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
