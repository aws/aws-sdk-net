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
    /// This is the response object from the GetAdminScope operation.
    /// </summary>
    public partial class GetAdminScopeResponse : AmazonWebServiceResponse
    {
        private AdminScope _adminScope;
        private OrganizationStatus _status;

        /// <summary>
        /// Gets and sets the property AdminScope. 
        /// <para>
        /// Contains details about the administrative scope of the requested account.
        /// </para>
        /// </summary>
        public AdminScope AdminScope
        {
            get { return this._adminScope; }
            set { this._adminScope = value; }
        }

        // Check to see if AdminScope property is set
        internal bool IsSetAdminScope()
        {
            return this._adminScope != null;
        }

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
        public OrganizationStatus Status
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