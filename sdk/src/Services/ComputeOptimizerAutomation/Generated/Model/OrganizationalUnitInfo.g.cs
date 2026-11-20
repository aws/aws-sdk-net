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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Information about an organizational unit (OU) or the organization root, including
    /// whether an applicable organization enrollment configuration enables Automation for
    /// member accounts and the effective organization rule mode.
    /// </summary>
    public partial class OrganizationalUnitInfo
    {
        /// <summary>
        /// Gets and sets the property AutoEnrollMemberAccounts. 
        /// <para>
        /// Whether an applicable organization enrollment configuration enables Automation for
        /// eligible member accounts beneath the organizational unit (OU) or organization root.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>All</c> - An organization enrollment configuration applies and enables Automation
        /// for affected member accounts, including accounts that join later. This value applies
        /// to configurations with either <c>AnyAllowed</c> or <c>NoneAllowed</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>None</c> - No organization enrollment configuration applies, so Automation isn't
        /// enabled by an organization enrollment configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoEnrollMemberAccounts AutoEnrollMemberAccounts { get; set; }

        /// <summary>
        /// Checks to see if the AutoEnrollMemberAccounts property is set.
        /// </summary>
        internal bool IsSetAutoEnrollMemberAccounts() => this.AutoEnrollMemberAccounts != null;

        /// <summary>
        /// Gets and sets the property OrganizationRuleMode. 
        /// <para>
        /// The effective organization rule mode for the organizational unit or organization root.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationRuleMode OrganizationRuleMode { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRuleMode property is set.
        /// </summary>
        internal bool IsSetOrganizationRuleMode() => this.OrganizationRuleMode != null;

        /// <summary>
        /// Gets and sets the property OrganizationRuleModeSource. 
        /// <para>
        /// Information about the source of the effective organization rule mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationRuleModeSource OrganizationRuleModeSource { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRuleModeSource property is set.
        /// </summary>
        internal bool IsSetOrganizationRuleModeSource() => this.OrganizationRuleModeSource != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The ID of the organizational unit (OU) or organization root.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 68)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;
    }
}
