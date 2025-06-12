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
    /// This is the response object from the GetSigningProfile operation.
    /// </summary>
    public partial class GetSigningProfileResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private SigningPlatformOverrides _overrides;
        private string _platformDisplayName;
        private string _platformId;
        private string _profileName;
        private string _profileVersion;
        private string _profileVersionArn;
        private SigningProfileRevocationRecord _revocationRecord;
        private SignatureValidityPeriod _signatureValidityPeriod;
        private SigningMaterial _signingMaterial;
        private Dictionary<string, string> _signingParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private SigningProfileStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the signing profile.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of overrides applied by the target signing profile for signing operations.
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
        /// A human-readable name for the signing platform associated with the signing profile.
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
        /// The ID of the platform that is used by the target signing profile.
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
        /// The name of the target signing profile.
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
        /// The current version of the signing profile.
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
        /// Gets and sets the property ProfileVersionArn. 
        /// <para>
        /// The signing profile ARN, including the profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property RevocationRecord.
        /// </summary>
        public SigningProfileRevocationRecord RevocationRecord
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
        /// Gets and sets the property SignatureValidityPeriod.
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
        /// The ARN of the certificate that the target profile uses for signing operations.
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
        /// A map of key-value pairs for signing operations that is attached to the target signing
        /// profile.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the target signing profile.
        /// </para>
        /// </summary>
        public SigningProfileStatus Status
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
        /// Reason for the status of the target signing profile.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the signing profile.
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