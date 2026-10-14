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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the SearchProvisionedProducts operation. Gets information
    /// about the provisioned products that meet the specified criteria.
    /// </summary>
    public partial class SearchProvisionedProductsRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property AccessLevelFilter. 
        /// <para>
        /// The access level to use to obtain results. The default is <c>Account</c>.
        /// </para>
        /// </summary>
        public AccessLevelFilter AccessLevelFilter { get; set; }

        /// <summary>
        /// Checks to see if the AccessLevelFilter property is set.
        /// </summary>
        internal bool IsSetAccessLevelFilter() => this.AccessLevelFilter != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The search filters.
        /// </para>
        ///  
        /// <para>
        /// When the key is <c>SearchQuery</c>, the searchable fields are <c>arn</c>, <c>createdTime</c>,
        /// <c>id</c>, <c>lastRecordId</c>, <c>idempotencyToken</c>, <c>name</c>, <c>physicalId</c>,
        /// <c>productId</c>, <c>provisioningArtifactId</c>, <c>type</c>, <c>status</c>, <c>tags</c>,
        /// <c>userArn</c>, <c>userArnSession</c>, <c>lastProvisioningRecordId</c>, <c>lastSuccessfulProvisioningRecordId</c>,
        /// <c>productName</c>, and <c>provisioningArtifactName</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"SearchQuery":["status:AVAILABLE"]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Filters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The page token for the next set of results. To retrieve the first set of results,
        /// use null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2024)]
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The sort field. If no value is specified, the results are not sorted. The valid values
        /// are <c>arn</c>, <c>id</c>, <c>name</c>, and <c>lastRecordId</c>.
        /// </para>
        /// </summary>
        public string SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order. If no value is specified, the results are not sorted.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
