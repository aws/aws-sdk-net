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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Contains the security group configuration settings that can be specified when creating
    /// or updating a security group. This is a subset of SecurityGroupSettings containing
    /// only the modifiable federation and security settings.
    /// </summary>
    public partial class SecurityGroupSettingsRequest
    {
        private bool? _enableGuestFederation;
        private bool? _enableRestrictedGlobalFederation;
        private int? _federationMode;
        private bool? _globalFederation;
        private int? _lockoutThreshold;
        private List<string> _permittedNetworks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<WickrAwsNetworks> _permittedWickrAwsNetworks = AWSConfigs.InitializeCollections ? new List<WickrAwsNetworks>() : null;
        private List<PermittedWickrEnterpriseNetwork> _permittedWickrEnterpriseNetworks = AWSConfigs.InitializeCollections ? new List<PermittedWickrEnterpriseNetwork>() : null;

        /// <summary>
        /// Gets and sets the property EnableGuestFederation. 
        /// <para>
        /// Guest users let you work with people outside your organization that only have limited
        /// access to Wickr. Only valid when federationMode is set to Global.
        /// </para>
        /// </summary>
        public bool EnableGuestFederation
        {
            get { return this._enableGuestFederation.GetValueOrDefault(); }
            set { this._enableGuestFederation = value; }
        }

        // Check to see if EnableGuestFederation property is set
        internal bool IsSetEnableGuestFederation()
        {
            return this._enableGuestFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableRestrictedGlobalFederation. 
        /// <para>
        /// Enables restricted global federation to limit communication to specific permitted
        /// networks only. Requires globalFederation to be enabled.
        /// </para>
        /// </summary>
        public bool EnableRestrictedGlobalFederation
        {
            get { return this._enableRestrictedGlobalFederation.GetValueOrDefault(); }
            set { this._enableRestrictedGlobalFederation = value; }
        }

        // Check to see if EnableRestrictedGlobalFederation property is set
        internal bool IsSetEnableRestrictedGlobalFederation()
        {
            return this._enableRestrictedGlobalFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// The local federation mode. Values: 0 (none), 1 (federated - all networks), 2 (restricted
        /// - only permitted networks).
        /// </para>
        /// </summary>
        public int FederationMode
        {
            get { return this._federationMode.GetValueOrDefault(); }
            set { this._federationMode = value; }
        }

        // Check to see if FederationMode property is set
        internal bool IsSetFederationMode()
        {
            return this._federationMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalFederation. 
        /// <para>
        /// Allow users to securely federate with all Amazon Web Services Wickr networks and Amazon
        /// Web Services Enterprise networks.
        /// </para>
        /// </summary>
        public bool GlobalFederation
        {
            get { return this._globalFederation.GetValueOrDefault(); }
            set { this._globalFederation = value; }
        }

        // Check to see if GlobalFederation property is set
        internal bool IsSetGlobalFederation()
        {
            return this._globalFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockoutThreshold. 
        /// <para>
        /// The number of failed password attempts before a user account is locked out.
        /// </para>
        /// </summary>
        public int LockoutThreshold
        {
            get { return this._lockoutThreshold.GetValueOrDefault(); }
            set { this._lockoutThreshold = value; }
        }

        // Check to see if LockoutThreshold property is set
        internal bool IsSetLockoutThreshold()
        {
            return this._lockoutThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PermittedNetworks. 
        /// <para>
        /// A list of network IDs that are permitted for local federation when federation mode
        /// is set to restricted.
        /// </para>
        /// </summary>
        public List<string> PermittedNetworks
        {
            get { return this._permittedNetworks; }
            set { this._permittedNetworks = value; }
        }

        // Check to see if PermittedNetworks property is set
        internal bool IsSetPermittedNetworks()
        {
            return this._permittedNetworks != null && (this._permittedNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermittedWickrAwsNetworks. 
        /// <para>
        /// A list of permitted Amazon Web Services Wickr networks for restricted global federation.
        /// </para>
        /// </summary>
        public List<WickrAwsNetworks> PermittedWickrAwsNetworks
        {
            get { return this._permittedWickrAwsNetworks; }
            set { this._permittedWickrAwsNetworks = value; }
        }

        // Check to see if PermittedWickrAwsNetworks property is set
        internal bool IsSetPermittedWickrAwsNetworks()
        {
            return this._permittedWickrAwsNetworks != null && (this._permittedWickrAwsNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermittedWickrEnterpriseNetworks. 
        /// <para>
        /// A list of permitted Wickr Enterprise networks for restricted global federation.
        /// </para>
        /// </summary>
        public List<PermittedWickrEnterpriseNetwork> PermittedWickrEnterpriseNetworks
        {
            get { return this._permittedWickrEnterpriseNetworks; }
            set { this._permittedWickrEnterpriseNetworks = value; }
        }

        // Check to see if PermittedWickrEnterpriseNetworks property is set
        internal bool IsSetPermittedWickrEnterpriseNetworks()
        {
            return this._permittedWickrEnterpriseNetworks != null && (this._permittedWickrEnterpriseNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}