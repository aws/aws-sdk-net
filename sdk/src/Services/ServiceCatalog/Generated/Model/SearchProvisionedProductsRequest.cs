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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the SearchProvisionedProducts operation.
    /// Gets information about the provisioned products that meet the specified criteria.
    /// </summary>
    public partial class SearchProvisionedProductsRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private AccessLevelFilter _accessLevelFilter;
        private Dictionary<string, List<string>> _filters = new Dictionary<string, List<string>>();
        private int? _pageSize;
        private string _pageToken;
        private string _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property AccessLevelFilter. 
        /// <para>
        /// The access level to use to obtain results. The default is <code>User</code>.
        /// </para>
        /// </summary>
        public AccessLevelFilter AccessLevelFilter
        {
            get { return this._accessLevelFilter; }
            set { this._accessLevelFilter = value; }
        }

        // Check to see if AccessLevelFilter property is set
        internal bool IsSetAccessLevelFilter()
        {
            return this._accessLevelFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The search filters.
        /// </para>
        ///  
        /// <para>
        /// When the key is <code>SearchQuery</code>, the searchable fields are <code>arn</code>,
        /// <code>createdTime</code>, <code>id</code>, <code>lastRecordId</code>, <code>idempotencyToken</code>,
        /// <code>name</code>, <code>physicalId</code>, <code>productId</code>, <code>provisioningArtifact</code>,
        /// <code>type</code>, <code>status</code>, <code>tags</code>, <code>userArn</code>, <code>userArnSession</code>,
        /// <code>lastProvisioningRecordId</code>, <code>lastSuccessfulProvisioningRecordId</code>,
        /// <code>productName</code>, and <code>provisioningArtifactName</code>.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>"SearchQuery":["status:AVAILABLE"]</code> 
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The page token for the next set of results. To retrieve the first set of results,
        /// use null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The sort field. If no value is specified, the results are not sorted. The valid values
        /// are <code>arn</code>, <code>id</code>, <code>name</code>, and <code>lastRecordId</code>.
        /// </para>
        /// </summary>
        public string SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order. If no value is specified, the results are not sorted.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}