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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeOrganizationConfiguration operation.
    /// </summary>
    public partial class DescribeOrganizationConfigurationResponse : AmazonWebServiceResponse
    {
        private bool? _autoEnable;
        private AutoEnableStandards _autoEnableStandards;
        private bool? _memberAccountLimitReached;
        private OrganizationConfiguration _organizationConfiguration;

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Whether to automatically enable Security Hub in new member accounts when they join
        /// the organization.
        /// </para>
        ///  
        /// <para>
        /// If set to <c>true</c>, then Security Hub is automatically enabled in new accounts.
        /// If set to <c>false</c>, then Security Hub isn't enabled in new accounts automatically.
        /// The default value is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>ConfigurationType</c> of your organization is set to <c>CENTRAL</c>, then
        /// this field is set to <c>false</c> and can't be changed in the home Region and linked
        /// Regions. However, in that case, the delegated administrator can create a configuration
        /// policy in which Security Hub is enabled and associate the policy with new organization
        /// accounts.
        /// </para>
        /// </summary>
        public bool? AutoEnable
        {
            get { return this._autoEnable; }
            set { this._autoEnable = value; }
        }

        // Check to see if AutoEnable property is set
        internal bool IsSetAutoEnable()
        {
            return this._autoEnable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoEnableStandards. 
        /// <para>
        /// Whether to automatically enable Security Hub <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards-enable-disable.html">default
        /// standards</a> in new member accounts when they join the organization.
        /// </para>
        ///  
        /// <para>
        /// If equal to <c>DEFAULT</c>, then Security Hub default standards are automatically
        /// enabled for new member accounts. If equal to <c>NONE</c>, then default standards are
        /// not automatically enabled for new member accounts. The default value of this parameter
        /// is equal to <c>DEFAULT</c>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>ConfigurationType</c> of your organization is set to <c>CENTRAL</c>, then
        /// this field is set to <c>NONE</c> and can't be changed in the home Region and linked
        /// Regions. However, in that case, the delegated administrator can create a configuration
        /// policy in which specific security standards are enabled and associate the policy with
        /// new organization accounts.
        /// </para>
        /// </summary>
        public AutoEnableStandards AutoEnableStandards
        {
            get { return this._autoEnableStandards; }
            set { this._autoEnableStandards = value; }
        }

        // Check to see if AutoEnableStandards property is set
        internal bool IsSetAutoEnableStandards()
        {
            return this._autoEnableStandards != null;
        }

        /// <summary>
        /// Gets and sets the property MemberAccountLimitReached. 
        /// <para>
        /// Whether the maximum number of allowed member accounts are already associated with
        /// the Security Hub administrator account.
        /// </para>
        /// </summary>
        public bool? MemberAccountLimitReached
        {
            get { return this._memberAccountLimitReached; }
            set { this._memberAccountLimitReached = value; }
        }

        // Check to see if MemberAccountLimitReached property is set
        internal bool IsSetMemberAccountLimitReached()
        {
            return this._memberAccountLimitReached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration.
        /// </summary>
        public OrganizationConfiguration OrganizationConfiguration
        {
            get { return this._organizationConfiguration; }
            set { this._organizationConfiguration = value; }
        }

        // Check to see if OrganizationConfiguration property is set
        internal bool IsSetOrganizationConfiguration()
        {
            return this._organizationConfiguration != null;
        }

    }
}