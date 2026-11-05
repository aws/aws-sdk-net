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

namespace Amazon.AccountAccessRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the ListRoles operation. Returns the roles that you
    /// are entitled to access within a tenant. The results are paginated. Use a returned
    /// role with <c>GetRoleCredentials</c> to obtain temporary credentials.
    /// </summary>
    public partial class ListRolesRequest : AmazonAccountAccessRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of roles to return in a single response. If more roles are available
        /// than the specified value, the response includes a <c>nextToken</c> value that you
        /// can use to retrieve the next page of results. If you don't specify a value, the service
        /// uses a default page size.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous <c>ListRoles</c> response. Use it to retrieve
        /// the next page of results. Omit this parameter on the first call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The identifier of the tenant whose roles you want to list. A tenant ID begins with
        /// <c>aa-</c> and is 3 to 24 characters long. It can contain lowercase letters, numbers,
        /// and hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 24)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;
    }
}
