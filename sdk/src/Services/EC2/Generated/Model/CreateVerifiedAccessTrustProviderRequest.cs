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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVerifiedAccessTrustProvider operation.
    /// A trust provider is a third-party entity that creates, maintains, and manages identity
    /// information for users and devices. When an application request is made, the identity
    /// information sent by the trust provider is evaluated by Verified Access before allowing
    /// or denying the application request.
    /// </summary>
    public partial class CreateVerifiedAccessTrustProviderRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private CreateVerifiedAccessTrustProviderDeviceOptions _deviceOptions;
        private DeviceTrustProviderType _deviceTrustProviderType;
        private CreateVerifiedAccessTrustProviderOidcOptions _oidcOptions;
        private string _policyReferenceName;
        private VerifiedAccessSseSpecificationRequest _sseSpecification;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private TrustProviderType _trustProviderType;
        private UserTrustProviderType _userTrustProviderType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Verified Access trust provider.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceOptions. 
        /// <para>
        /// The options for a device-based trust provider. This parameter is required when the
        /// provider type is <c>device</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessTrustProviderDeviceOptions DeviceOptions
        {
            get { return this._deviceOptions; }
            set { this._deviceOptions = value; }
        }

        // Check to see if DeviceOptions property is set
        internal bool IsSetDeviceOptions()
        {
            return this._deviceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTrustProviderType. 
        /// <para>
        /// The type of device-based trust provider. This parameter is required when the provider
        /// type is <c>device</c>.
        /// </para>
        /// </summary>
        public DeviceTrustProviderType DeviceTrustProviderType
        {
            get { return this._deviceTrustProviderType; }
            set { this._deviceTrustProviderType = value; }
        }

        // Check to see if DeviceTrustProviderType property is set
        internal bool IsSetDeviceTrustProviderType()
        {
            return this._deviceTrustProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The options for a OpenID Connect-compatible user-identity trust provider. This parameter
        /// is required when the provider type is <c>user</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessTrustProviderOidcOptions OidcOptions
        {
            get { return this._oidcOptions; }
            set { this._oidcOptions = value; }
        }

        // Check to see if OidcOptions property is set
        internal bool IsSetOidcOptions()
        {
            return this._oidcOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyReferenceName. 
        /// <para>
        /// The identifier to be used when working with policy rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyReferenceName
        {
            get { return this._policyReferenceName; }
            set { this._policyReferenceName = value; }
        }

        // Check to see if PolicyReferenceName property is set
        internal bool IsSetPolicyReferenceName()
        {
            return this._policyReferenceName != null;
        }

        /// <summary>
        /// Gets and sets the property SseSpecification. 
        /// <para>
        /// The options for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationRequest SseSpecification
        {
            get { return this._sseSpecification; }
            set { this._sseSpecification = value; }
        }

        // Check to see if SseSpecification property is set
        internal bool IsSetSseSpecification()
        {
            return this._sseSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Verified Access trust provider.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of trust provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrustProviderType TrustProviderType
        {
            get { return this._trustProviderType; }
            set { this._trustProviderType = value; }
        }

        // Check to see if TrustProviderType property is set
        internal bool IsSetTrustProviderType()
        {
            return this._trustProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property UserTrustProviderType. 
        /// <para>
        /// The type of user-based trust provider. This parameter is required when the provider
        /// type is <c>user</c>.
        /// </para>
        /// </summary>
        public UserTrustProviderType UserTrustProviderType
        {
            get { return this._userTrustProviderType; }
            set { this._userTrustProviderType = value; }
        }

        // Check to see if UserTrustProviderType property is set
        internal bool IsSetUserTrustProviderType()
        {
            return this._userTrustProviderType != null;
        }

    }
}