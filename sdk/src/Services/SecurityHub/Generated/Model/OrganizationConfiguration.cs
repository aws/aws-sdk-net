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
    /// Provides information about the way an organization is configured in Security Hub.
    /// </summary>
    public partial class OrganizationConfiguration
    {
        private OrganizationConfigurationConfigurationType _configurationType;
        private OrganizationConfigurationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        ///  Indicates whether the organization uses local or central configuration. 
        /// </para>
        ///  
        /// <para>
        /// If you use local configuration, the Security Hub delegated administrator can set <c>AutoEnable</c>
        /// to <c>true</c> and <c>AutoEnableStandards</c> to <c>DEFAULT</c>. This automatically
        /// enables Security Hub and default security standards in new organization accounts.
        /// These new account settings must be set separately in each Amazon Web Services Region,
        /// and settings may be different in each Region. 
        /// </para>
        ///  
        /// <para>
        ///  If you use central configuration, the delegated administrator can create configuration
        /// policies. Configuration policies can be used to configure Security Hub, security standards,
        /// and security controls in multiple accounts and Regions. If you want new organization
        /// accounts to use a specific configuration, you can create a configuration policy and
        /// associate it with the root or specific organizational units (OUs). New accounts will
        /// inherit the policy from the root or their assigned OU. 
        /// </para>
        /// </summary>
        public OrganizationConfigurationConfigurationType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Describes whether central configuration could be enabled as the <c>ConfigurationType</c>
        /// for the organization. If your <c>ConfigurationType</c> is local configuration, then
        /// the value of <c>Status</c> is always <c>ENABLED</c>. 
        /// </para>
        /// </summary>
        public OrganizationConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  Provides an explanation if the value of <c>Status</c> is equal to <c>FAILED</c> when
        /// <c>ConfigurationType</c> is equal to <c>CENTRAL</c>. 
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}