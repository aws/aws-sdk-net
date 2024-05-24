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
    /// Defines the resources that the Firewall Manager administrator can manage. For more
    /// information about administrative scope, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-administrators.html">Managing
    /// Firewall Manager administrators</a> in the <i>Firewall Manager Developer Guide</i>.
    /// </summary>
    public partial class AdminScope
    {
        private AccountScope _accountScope;
        private OrganizationalUnitScope _organizationalUnitScope;
        private PolicyTypeScope _policyTypeScope;
        private RegionScope _regionScope;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// Defines the accounts that the specified Firewall Manager administrator can apply policies
        /// to.
        /// </para>
        /// </summary>
        public AccountScope AccountScope
        {
            get { return this._accountScope; }
            set { this._accountScope = value; }
        }

        // Check to see if AccountScope property is set
        internal bool IsSetAccountScope()
        {
            return this._accountScope != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitScope. 
        /// <para>
        /// Defines the Organizations organizational units that the specified Firewall Manager
        /// administrator can apply policies to. For more information about OUs in Organizations,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_ous.html">Managing
        /// organizational units (OUs) </a> in the <i>Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public OrganizationalUnitScope OrganizationalUnitScope
        {
            get { return this._organizationalUnitScope; }
            set { this._organizationalUnitScope = value; }
        }

        // Check to see if OrganizationalUnitScope property is set
        internal bool IsSetOrganizationalUnitScope()
        {
            return this._organizationalUnitScope != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTypeScope. 
        /// <para>
        /// Defines the Firewall Manager policy types that the specified Firewall Manager administrator
        /// can create and manage.
        /// </para>
        /// </summary>
        public PolicyTypeScope PolicyTypeScope
        {
            get { return this._policyTypeScope; }
            set { this._policyTypeScope = value; }
        }

        // Check to see if PolicyTypeScope property is set
        internal bool IsSetPolicyTypeScope()
        {
            return this._policyTypeScope != null;
        }

        /// <summary>
        /// Gets and sets the property RegionScope. 
        /// <para>
        /// Defines the Amazon Web Services Regions that the specified Firewall Manager administrator
        /// can perform actions in.
        /// </para>
        /// </summary>
        public RegionScope RegionScope
        {
            get { return this._regionScope; }
            set { this._regionScope = value; }
        }

        // Check to see if RegionScope property is set
        internal bool IsSetRegionScope()
        {
            return this._regionScope != null;
        }

    }
}