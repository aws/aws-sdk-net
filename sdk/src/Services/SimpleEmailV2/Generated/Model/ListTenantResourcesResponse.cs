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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about resources associated with a specific tenant.
    /// </summary>
    public partial class ListTenantResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TenantResource> _tenantResources = AWSConfigs.InitializeCollections ? new List<TenantResource>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional resources to list. To view additional
        /// resources, issue another request to <c>ListTenantResources</c>, and pass this token
        /// in the <c>NextToken</c> parameter.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TenantResources. 
        /// <para>
        /// An array that contains information about each resource associated with the tenant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TenantResource> TenantResources
        {
            get { return this._tenantResources; }
            set { this._tenantResources = value; }
        }

        // Check to see if TenantResources property is set
        internal bool IsSetTenantResources()
        {
            return this._tenantResources != null && (this._tenantResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}