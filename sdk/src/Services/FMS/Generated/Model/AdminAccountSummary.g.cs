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
    /// Contains high level information about the Firewall Manager administrator account.
    /// </summary>
    public partial class AdminAccountSummary
    {
        /// <summary>
        /// Gets and sets the property AdminAccount. 
        /// <para>
        /// The Amazon Web Services account ID of the Firewall Manager administrator's account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AdminAccount { get; set; }

        /// <summary>
        /// Checks to see if the AdminAccount property is set.
        /// </summary>
        internal bool IsSetAdminAccount() => this.AdminAccount != null;

        /// <summary>
        /// Gets and sets the property DefaultAdmin. 
        /// <para>
        /// A boolean value that indicates if the administrator is the default administrator.
        /// If true, then this is the default administrator account. The default administrator
        /// can manage third-party firewalls and has full administrative scope. There is only
        /// one default administrator account per organization. For information about Firewall
        /// Manager default administrator accounts, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-administrators.html">Managing
        /// Firewall Manager administrators</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? DefaultAdmin { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAdmin property is set.
        /// </summary>
        internal bool IsSetDefaultAdmin() => this.DefaultAdmin.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the request to onboard a member account as an Firewall Manager
        /// administrator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ONBOARDING</c> - The account is onboarding to Firewall Manager as an administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONBOARDING_COMPLETE</c> - Firewall Manager The account is onboarded to Firewall
        /// Manager as an administrator, and can perform actions on the resources defined in their
        /// <a>AdminScope</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OFFBOARDING</c> - The account is being removed as an Firewall Manager administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OFFBOARDING_COMPLETE</c> - The account has been removed as an Firewall Manager
        /// administrator.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OrganizationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
