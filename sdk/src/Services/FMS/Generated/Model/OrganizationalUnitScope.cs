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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Defines the Organizations organizational units (OUs) that the specified Firewall Manager
    /// administrator can apply policies to. For more information about OUs in Organizations,
    /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_ous.html">Managing
    /// organizational units (OUs) </a> in the <i>Organizations User Guide</i>.
    /// </summary>
    public partial class OrganizationalUnitScope
    {
        private bool? _allOrganizationalUnitsEnabled;
        private bool? _excludeSpecifiedOrganizationalUnits;
        private List<string> _organizationalUnits = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllOrganizationalUnitsEnabled. 
        /// <para>
        /// A boolean value that indicates if the administrator can apply policies to all OUs
        /// within an organization. If true, the administrator can manage all OUs within the organization.
        /// You can either enable management of all OUs through this operation, or you can specify
        /// OUs to manage in <c>OrganizationalUnitScope$OrganizationalUnits</c>. You cannot specify
        /// both.
        /// </para>
        /// </summary>
        public bool? AllOrganizationalUnitsEnabled
        {
            get { return this._allOrganizationalUnitsEnabled; }
            set { this._allOrganizationalUnitsEnabled = value; }
        }

        // Check to see if AllOrganizationalUnitsEnabled property is set
        internal bool IsSetAllOrganizationalUnitsEnabled()
        {
            return this._allOrganizationalUnitsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeSpecifiedOrganizationalUnits. 
        /// <para>
        /// A boolean value that excludes the OUs in <c>OrganizationalUnitScope$OrganizationalUnits</c>
        /// from the administrator's scope. If true, the Firewall Manager administrator can apply
        /// policies to all OUs in the organization except for the OUs listed in <c>OrganizationalUnitScope$OrganizationalUnits</c>.
        /// You can either specify a list of OUs to exclude by <c>OrganizationalUnitScope$OrganizationalUnits</c>,
        /// or you can enable management of all OUs by <c>OrganizationalUnitScope$AllOrganizationalUnitsEnabled</c>.
        /// You cannot specify both.
        /// </para>
        /// </summary>
        public bool? ExcludeSpecifiedOrganizationalUnits
        {
            get { return this._excludeSpecifiedOrganizationalUnits; }
            set { this._excludeSpecifiedOrganizationalUnits = value; }
        }

        // Check to see if ExcludeSpecifiedOrganizationalUnits property is set
        internal bool IsSetExcludeSpecifiedOrganizationalUnits()
        {
            return this._excludeSpecifiedOrganizationalUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// The list of OUs within the organization that the specified Firewall Manager administrator
        /// either can or cannot apply policies to, based on the value of <c>OrganizationalUnitScope$ExcludeSpecifiedOrganizationalUnits</c>.
        /// If <c>OrganizationalUnitScope$ExcludeSpecifiedOrganizationalUnits</c> is set to <c>true</c>,
        /// then the Firewall Manager administrator can apply policies to all OUs in the organization
        /// except for the OUs in this list. If <c>OrganizationalUnitScope$ExcludeSpecifiedOrganizationalUnits</c>
        /// is set to <c>false</c>, then the Firewall Manager administrator can only apply policies
        /// to the OUs in this list.
        /// </para>
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