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
 * Do not modify this file. This file is generated from the account-access-2018-05-10.normal.json service model.
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
namespace Amazon.AccountAccess.Model
{
    /// <summary>
    /// Specifies filter criteria for listing entitlements.
    /// </summary>
    public partial class EntitlementFilter
    {
        private PrincipalRoleEntitlementFilter _principalRole;

        /// <summary>
        /// Gets and sets the property PrincipalRole. 
        /// <para>
        /// The principal-to-role filter criteria for narrowing entitlement results.
        /// </para>
        /// </summary>
        public PrincipalRoleEntitlementFilter PrincipalRole
        {
            get { return this._principalRole; }
            set { this._principalRole = value; }
        }

        // Check to see if PrincipalRole property is set
        internal bool IsSetPrincipalRole()
        {
            return this._principalRole != null;
        }

    }
}