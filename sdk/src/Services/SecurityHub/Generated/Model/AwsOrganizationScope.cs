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
    /// Specifies an Organizations scope. Data from the specified organization or organizational
    /// unit is included in the response.
    /// 
    ///  
    /// <para>
    /// To scope to a specific organizational unit, provide <c>OrganizationalUnitId</c>. You
    /// can optionally include <c>OrganizationId</c>. If you omit <c>OrganizationId</c>, Security
    /// Hub uses the caller's organization ID. To scope to the delegated administrator's entire
    /// organization, provide only <c>OrganizationId</c>.
    /// </para>
    ///  
    /// <para>
    /// The organization ID and organizational unit must belong to the delegated administrator's
    /// own organization. Each request must use one scoping approach: either scope to the
    /// entire organization by providing an <c>AwsOrganizationScope</c> entry with only <c>OrganizationId</c>,
    /// or scope to specific organizational units by providing <c>AwsOrganizationScope</c>
    /// entries with <c>OrganizationalUnitId</c>. You can't combine both approaches in the
    /// same request.
    /// </para>
    /// </summary>
    public partial class AwsOrganizationScope
    {
        private string _organizationalUnitId;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier (ID) of the organizational unit (OU) (for example, <c>ou-ab12-cd345678</c>).
        /// The OU must exist within the delegated administrator's own organization. When specified,
        /// the results include only data from accounts in this OU.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The unique identifier (ID) of the organization (for example, <c>o-abcd1234567890</c>).
        /// The organization must be the delegated administrator's own organization. If you omit
        /// this value and provide <c>OrganizationalUnitId</c>, Security Hub uses the caller's
        /// organization ID.
        /// </para>
        /// </summary>
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}