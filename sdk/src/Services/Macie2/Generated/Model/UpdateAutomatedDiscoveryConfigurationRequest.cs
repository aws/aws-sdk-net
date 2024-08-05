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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutomatedDiscoveryConfiguration operation.
    /// Changes the configuration settings and status of automated sensitive data discovery
    /// for an organization or standalone account.
    /// </summary>
    public partial class UpdateAutomatedDiscoveryConfigurationRequest : AmazonMacie2Request
    {
        private AutoEnableMode _autoEnableOrganizationMembers;
        private AutomatedDiscoveryStatus _status;

        /// <summary>
        /// Gets and sets the property AutoEnableOrganizationMembers. 
        /// <para>
        /// Specifies whether to automatically enable automated sensitive data discovery for accounts
        /// in the organization. Valid values are: ALL (default), enable it for all existing accounts
        /// and new member accounts; NEW, enable it only for new member accounts; and, NONE, don't
        /// enable it for any accounts.
        /// </para>
        ///  
        /// <para>
        /// If you specify NEW or NONE, automated sensitive data discovery continues to be enabled
        /// for any existing accounts that it's currently enabled for. To enable or disable it
        /// for individual member accounts, specify NEW or NONE, and then enable or disable it
        /// for each account by using the BatchUpdateAutomatedDiscoveryAccounts operation.
        /// </para>
        /// </summary>
        public AutoEnableMode AutoEnableOrganizationMembers
        {
            get { return this._autoEnableOrganizationMembers; }
            set { this._autoEnableOrganizationMembers = value; }
        }

        // Check to see if AutoEnableOrganizationMembers property is set
        internal bool IsSetAutoEnableOrganizationMembers()
        {
            return this._autoEnableOrganizationMembers != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status of automated sensitive data discovery for the organization or account.
        /// Valid values are: ENABLED, start or resume all automated sensitive data discovery
        /// activities; and, DISABLED, stop performing all automated sensitive data discovery
        /// activities.
        /// </para>
        ///  
        /// <para>
        /// If you specify DISABLED for an administrator account, you also disable automated sensitive
        /// data discovery for all member accounts in the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedDiscoveryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}