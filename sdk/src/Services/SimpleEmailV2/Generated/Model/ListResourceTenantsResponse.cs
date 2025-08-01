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
    /// Information about tenants associated with a specific resource.
    /// </summary>
    public partial class ListResourceTenantsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceTenantMetadata> _resourceTenants = AWSConfigs.InitializeCollections ? new List<ResourceTenantMetadata>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional tenants to list. To view additional
        /// tenants, issue another request to <c>ListResourceTenants</c>, and pass this token
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
        /// Gets and sets the property ResourceTenants. 
        /// <para>
        /// An array that contains information about each tenant associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceTenantMetadata> ResourceTenants
        {
            get { return this._resourceTenants; }
            set { this._resourceTenants = value; }
        }

        // Check to see if ResourceTenants property is set
        internal bool IsSetResourceTenants()
        {
            return this._resourceTenants != null && (this._resourceTenants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}