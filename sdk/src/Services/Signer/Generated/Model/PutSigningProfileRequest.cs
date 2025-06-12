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
    /// Container for the parameters to the PutSigningProfile operation.
    /// Creates a signing profile. A signing profile is a code-signing template that can be
    /// used to carry out a pre-defined signing job.
    /// </summary>
    public partial class PutSigningProfileRequest : AmazonSignerRequest
    {
        private SigningPlatformOverrides _overrides;
        private string _platformId;
        private string _profileName;
        private SignatureValidityPeriod _signatureValidityPeriod;
        private SigningMaterial _signingMaterial;
        private Dictionary<string, string> _signingParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A subfield of <c>platform</c>. This specifies any different configuration options
        /// that you want to apply to the chosen platform (such as a different <c>hash-algorithm</c>
        /// or <c>signing-algorithm</c>).
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
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of the signing platform to be created.
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
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the signing profile to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
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
        /// Gets and sets the property SignatureValidityPeriod. 
        /// <para>
        /// The default validity period override for any signature generated using this signing
        /// profile. If unspecified, the default is 135 months.
        /// </para>
        /// </summary>
        public SignatureValidityPeriod SignatureValidityPeriod
        {
            get { return this._signatureValidityPeriod; }
            set { this._signatureValidityPeriod = value; }
        }

        // Check to see if SignatureValidityPeriod property is set
        internal bool IsSetSignatureValidityPeriod()
        {
            return this._signatureValidityPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property SigningMaterial. 
        /// <para>
        /// The AWS Certificate Manager certificate that will be used to sign code with the new
        /// signing profile.
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
        /// Map of key-value pairs for signing. These can include any information that you want
        /// to use during signing.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be associated with the signing profile that is being created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}