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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the SearchTypes operation. Searches for types in Amazon
    /// DataZone. <para> Prerequisites: </para> <ul> <li> <para> The --domain-identifier must
    /// refer to an existing Amazon DataZone domain. </para> </li> <li> <para> --search-scope
    /// must be one of the valid values including: ASSET_TYPE, GLOSSARY_TERM_TYPE, DATA_PRODUCT_TYPE.
    /// </para> </li> <li> <para> The --managed flag must be present without a value. </para>
    /// </li> <li> <para> The user must have permissions for form or asset types in the domain.
    /// </para> </li> <li> <para> If using --filters, ensure that the JSON is valid. </para>
    /// </li> <li> <para> Filters contain correct structure (attribute, value, operator).
    /// </para> </li> </ul>
    /// </summary>
    public partial class SearchTypesRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which to invoke the <c>SearchTypes</c>
        /// action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters for the <c>SearchTypes</c> action.
        /// </para>
        /// </summary>
        public FilterClause Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Managed. 
        /// <para>
        /// Specifies whether the search is managed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Managed { get; set; }

        /// <summary>
        /// Checks to see if the Managed property is set.
        /// </summary>
        internal bool IsSetManaged() => this.Managed.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call to <c>SearchTypes</c>. When
        /// the number of results to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>SearchTypes</c> to list the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of results is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of results, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>SearchTypes</c>
        /// to list the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchIn. 
        /// <para>
        /// The details of the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<SearchInItem> SearchIn { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchInItem>() : null;

        /// <summary>
        /// Checks to see if the SearchIn property is set.
        /// </summary>
        internal bool IsSetSearchIn() => this.SearchIn != null && (this.SearchIn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// Specifies the scope of the search for types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TypesSearchScope SearchScope { get; set; }

        /// <summary>
        /// Checks to see if the SearchScope property is set.
        /// </summary>
        internal bool IsSetSearchScope() => this.SearchScope != null;

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// Specifies the text for which to search.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SearchText { get; set; }

        /// <summary>
        /// Checks to see if the SearchText property is set.
        /// </summary>
        internal bool IsSetSearchText() => this.SearchText != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The specifies the way to sort the <c>SearchTypes</c> results.
        /// </para>
        /// </summary>
        public SearchSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
