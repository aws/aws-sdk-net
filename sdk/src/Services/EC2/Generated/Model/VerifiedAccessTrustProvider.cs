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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Verified Access trust provider.
    /// </summary>
    public partial class VerifiedAccessTrustProvider
    {
        private string _creationTime;
        private string _description;
        private DeviceOptions _deviceOptions;
        private DeviceTrustProviderType _deviceTrustProviderType;
        private string _lastUpdatedTime;
        private OidcOptions _oidcOptions;
        private string _policyReferenceName;
        private List<Tag> _tags = new List<Tag>();
        private TrustProviderType _trustProviderType;
        private UserTrustProviderType _userTrustProviderType;
        private string _verifiedAccessTrustProviderId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access trust provider.
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
        /// The options for device-identity type trust provider.
        /// </para>
        /// </summary>
        public DeviceOptions DeviceOptions
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
        /// The type of device-based trust provider.
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The OpenID Connect details for an <code>oidc</code>-type, user-identity based trust
        /// provider.
        /// </para>
        /// </summary>
        public OidcOptions OidcOptions
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of Verified Access trust provider.
        /// </para>
        /// </summary>
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
        /// The type of user-based trust provider.
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

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access trust provider.
        /// </para>
        /// </summary>
        public string VerifiedAccessTrustProviderId
        {
            get { return this._verifiedAccessTrustProviderId; }
            set { this._verifiedAccessTrustProviderId = value; }
        }

        // Check to see if VerifiedAccessTrustProviderId property is set
        internal bool IsSetVerifiedAccessTrustProviderId()
        {
            return this._verifiedAccessTrustProviderId != null;
        }

    }
}