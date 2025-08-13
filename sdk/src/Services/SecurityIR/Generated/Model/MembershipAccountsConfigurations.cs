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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
    /// The <c>MembershipAccountsConfigurations</c> structure defines the configuration settings
    /// for managing membership accounts withinAmazon Web Services. 
    /// 
    ///  
    /// <para>
    /// This structure contains settings that determine how member accounts are configured
    /// and managed within your organization, including: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Account configuration preferences
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Membership validation rules
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Account access settings
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use this structure to define and maintain standardized configurations across
    /// multiple member accounts in your organization. 
    /// </para>
    /// </summary>
    public partial class MembershipAccountsConfigurations
    {
        private bool? _coverEntireOrganization;
        private List<string> _organizationalUnits = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CoverEntireOrganization. 
        /// <para>
        /// The <c>coverEntireOrganization</c> field is a boolean value that determines whether
        /// the membership configuration applies to all accounts within an Amazon Web Services
        /// Organization. 
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, the configuration will be applied across all accounts in
        /// the organization. When set to <c>false</c>, the configuration will only apply to specifically
        /// designated accounts under the AWS Organizational Units specificied. 
        /// </para>
        /// </summary>
        public bool? CoverEntireOrganization
        {
            get { return this._coverEntireOrganization; }
            set { this._coverEntireOrganization = value; }
        }

        // Check to see if CoverEntireOrganization property is set
        internal bool IsSetCoverEntireOrganization()
        {
            return this._coverEntireOrganization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// A list of organizational unit IDs that follow the pattern <c>ou-[0-9a-z]{4,32}-[a-z0-9]{8,32}</c>.
        /// These IDs represent the organizational units within an Amazon Web Services Organizations
        /// structure that are covered by the membership. 
        /// </para>
        ///  
        /// <para>
        /// Each organizational unit ID in the list must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Begin with the prefix 'ou-'
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain between 4 and 32 alphanumeric characters in the first segment
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain between 8 and 32 alphanumeric characters in the second segment
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationalUnits
        {
            get { return this._organizationalUnits; }
            set { this._organizationalUnits = value; }
        }

        // Check to see if OrganizationalUnits property is set
        internal bool IsSetOrganizationalUnits()
        {
            return this._organizationalUnits != null && (this._organizationalUnits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}