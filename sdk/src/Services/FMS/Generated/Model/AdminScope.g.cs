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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Defines the resources that the Firewall Manager administrator can manage. For more
    /// information about administrative scope, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-administrators.html">Managing
    /// Firewall Manager administrators</a> in the <i>Firewall Manager Developer Guide</i>.
    /// </summary>
    public partial class AdminScope
    {
        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// Defines the accounts that the specified Firewall Manager administrator can apply policies
        /// to.
        /// </para>
        /// </summary>
        public AccountScope AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitScope. 
        /// <para>
        /// Defines the Organizations organizational units that the specified Firewall Manager
        /// administrator can apply policies to. For more information about OUs in Organizations,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_ous.html">Managing
        /// organizational units (OUs) </a> in the <i>Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public OrganizationalUnitScope OrganizationalUnitScope { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitScope property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitScope() => this.OrganizationalUnitScope != null;

        /// <summary>
        /// Gets and sets the property PolicyTypeScope. 
        /// <para>
        /// Defines the Firewall Manager policy types that the specified Firewall Manager administrator
        /// can create and manage.
        /// </para>
        /// </summary>
        public PolicyTypeScope PolicyTypeScope { get; set; }

        /// <summary>
        /// Checks to see if the PolicyTypeScope property is set.
        /// </summary>
        internal bool IsSetPolicyTypeScope() => this.PolicyTypeScope != null;

        /// <summary>
        /// Gets and sets the property RegionScope. 
        /// <para>
        /// Defines the Amazon Web Services Regions that the specified Firewall Manager administrator
        /// can perform actions in.
        /// </para>
        /// </summary>
        public RegionScope RegionScope { get; set; }

        /// <summary>
        /// Checks to see if the RegionScope property is set.
        /// </summary>
        internal bool IsSetRegionScope() => this.RegionScope != null;
    }
}
