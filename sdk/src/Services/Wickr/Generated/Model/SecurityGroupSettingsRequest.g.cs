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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Contains the security group configuration settings that can be specified when creating
    /// or updating a security group. This is a subset of SecurityGroupSettings containing
    /// only the modifiable federation and security settings.
    /// </summary>
    public partial class SecurityGroupSettingsRequest
    {
        /// <summary>
        /// Gets and sets the property EnableGuestFederation. 
        /// <para>
        /// Guest users let you work with people outside your organization that only have limited
        /// access to Wickr. Only valid when federationMode is set to Global.
        /// </para>
        /// </summary>
        public bool? EnableGuestFederation { get; set; }

        /// <summary>
        /// Checks to see if the EnableGuestFederation property is set.
        /// </summary>
        internal bool IsSetEnableGuestFederation() => this.EnableGuestFederation.HasValue;

        /// <summary>
        /// Gets and sets the property EnableRestrictedGlobalFederation. 
        /// <para>
        /// Enables restricted global federation to limit communication to specific permitted
        /// networks only. Requires globalFederation to be enabled.
        /// </para>
        /// </summary>
        public bool? EnableRestrictedGlobalFederation { get; set; }

        /// <summary>
        /// Checks to see if the EnableRestrictedGlobalFederation property is set.
        /// </summary>
        internal bool IsSetEnableRestrictedGlobalFederation() => this.EnableRestrictedGlobalFederation.HasValue;

        /// <summary>
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// The local federation mode. Values: 0 (none), 1 (federated - all networks), 2 (restricted
        /// - only permitted networks).
        /// </para>
        /// </summary>
        public int? FederationMode { get; set; }

        /// <summary>
        /// Checks to see if the FederationMode property is set.
        /// </summary>
        internal bool IsSetFederationMode() => this.FederationMode.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalFederation. 
        /// <para>
        /// Allow users to securely federate with all Amazon Web Services Wickr networks and Amazon
        /// Web Services Enterprise networks.
        /// </para>
        /// </summary>
        public bool? GlobalFederation { get; set; }

        /// <summary>
        /// Checks to see if the GlobalFederation property is set.
        /// </summary>
        internal bool IsSetGlobalFederation() => this.GlobalFederation.HasValue;

        /// <summary>
        /// Gets and sets the property LockoutThreshold. 
        /// <para>
        /// The number of failed password attempts before a user account is locked out.
        /// </para>
        /// </summary>
        public int? LockoutThreshold { get; set; }

        /// <summary>
        /// Checks to see if the LockoutThreshold property is set.
        /// </summary>
        internal bool IsSetLockoutThreshold() => this.LockoutThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property PermittedNetworks. 
        /// <para>
        /// A list of network IDs that are permitted for local federation when federation mode
        /// is set to restricted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PermittedNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PermittedNetworks property is set.
        /// </summary>
        internal bool IsSetPermittedNetworks() => this.PermittedNetworks != null && (this.PermittedNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermittedWickrAwsNetworks. 
        /// <para>
        /// A list of permitted Amazon Web Services Wickr networks for restricted global federation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WickrAwsNetworks> PermittedWickrAwsNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<WickrAwsNetworks>() : null;

        /// <summary>
        /// Checks to see if the PermittedWickrAwsNetworks property is set.
        /// </summary>
        internal bool IsSetPermittedWickrAwsNetworks() => this.PermittedWickrAwsNetworks != null && (this.PermittedWickrAwsNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermittedWickrEnterpriseNetworks. 
        /// <para>
        /// A list of permitted Wickr Enterprise networks for restricted global federation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PermittedWickrEnterpriseNetwork> PermittedWickrEnterpriseNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<PermittedWickrEnterpriseNetwork>() : null;

        /// <summary>
        /// Checks to see if the PermittedWickrEnterpriseNetworks property is set.
        /// </summary>
        internal bool IsSetPermittedWickrEnterpriseNetworks() => this.PermittedWickrEnterpriseNetworks != null && (this.PermittedWickrEnterpriseNetworks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
