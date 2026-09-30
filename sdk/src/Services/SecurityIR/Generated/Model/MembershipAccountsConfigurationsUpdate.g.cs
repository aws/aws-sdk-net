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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// The <c>MembershipAccountsConfigurationsUpdate</c>structure represents the configuration
    /// updates for member accounts within an Amazon Web Services organization. 
    /// 
    ///  
    /// <para>
    /// This structure is used to modify existing account configurations and settings for
    /// members in the organization. When applying updates, ensure all required fields are
    /// properly specified to maintain account consistency. 
    /// </para>
    ///  
    /// <para>
    /// Key considerations when using this structure:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// All configuration changes are validated before being applied
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Updates are processed asynchronously in the background
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configuration changes may take several minutes to propagate across all affected accounts
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MembershipAccountsConfigurationsUpdate
    {
        /// <summary>
        /// Gets and sets the property CoverEntireOrganization. 
        /// <para>
        /// The <c>coverEntireOrganization</c> field is a boolean value that determines whether
        /// the membership configuration should be applied across the entire Amazon Web Services
        /// Organization. 
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, the configuration will be applied to all accounts within
        /// the organization. When set to <c>false</c>, the configuration will only apply to specifically
        /// designated accounts. 
        /// </para>
        /// </summary>
        public bool? CoverEntireOrganization { get; set; }

        /// <summary>
        /// Checks to see if the CoverEntireOrganization property is set.
        /// </summary>
        internal bool IsSetCoverEntireOrganization() => this.CoverEntireOrganization.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitsToAdd. 
        /// <para>
        /// A list of organizational unit IDs to add to the membership configuration. Each organizational
        /// unit ID must match the pattern <c>ou-[0-9a-z]{4,32}-[a-z0-9]{8,32}</c>. 
        /// </para>
        ///  
        /// <para>
        /// The list must contain between 1 and 5 organizational unit IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> OrganizationalUnitsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitsToAdd property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitsToAdd() => this.OrganizationalUnitsToAdd != null && (this.OrganizationalUnitsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationalUnitsToRemove. 
        /// <para>
        /// A list of organizational unit IDs to remove from the membership configuration. Each
        /// organizational unit ID must match the pattern <c>ou-[0-9a-z]{4,32}-[a-z0-9]{8,32}</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The list must contain between 1 and 5 organizational unit IDs per invocation of the
        /// API request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> OrganizationalUnitsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitsToRemove property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitsToRemove() => this.OrganizationalUnitsToRemove != null && (this.OrganizationalUnitsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
