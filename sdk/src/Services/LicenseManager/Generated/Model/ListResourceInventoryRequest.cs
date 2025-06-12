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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceInventory operation.
    /// Lists resources managed using Systems Manager inventory.
    /// </summary>
    public partial class ListResourceInventoryRequest : AmazonLicenseManagerRequest
    {
        private List<InventoryFilter> _filters = AWSConfigs.InitializeCollections ? new List<InventoryFilter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to scope the results. The following filters and logical operators are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account_id</c> - The ID of the Amazon Web Services account that owns the resource.
        /// Logical operators are <c>EQUALS</c> | <c>NOT_EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application_name</c> - The name of the application. Logical operators are <c>EQUALS</c>
        /// | <c>BEGINS_WITH</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>license_included</c> - The type of license included. Logical operators are <c>EQUALS</c>
        /// | <c>NOT_EQUALS</c>. Possible values are <c>sql-server-enterprise</c> | <c>sql-server-standard</c>
        /// | <c>sql-server-web</c> | <c>windows-server-datacenter</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>platform</c> - The platform of the resource. Logical operators are <c>EQUALS</c>
        /// | <c>BEGINS_WITH</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource_id</c> - The ID of the resource. Logical operators are <c>EQUALS</c>
        /// | <c>NOT_EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The key/value combination of a tag assigned to the resource.
        /// Logical operators are <c>EQUALS</c> (single account) or <c>EQUALS</c> | <c>NOT_EQUALS</c>
        /// (cross account).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InventoryFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
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

    }
}