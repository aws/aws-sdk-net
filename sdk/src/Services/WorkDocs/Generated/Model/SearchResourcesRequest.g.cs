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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the SearchResources operation. Searches metadata and
    /// the content of folders, documents, document versions, and comments.
    /// </summary>
    public partial class SearchResourcesRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalResponseFields. 
        /// <para>
        /// A list of attributes to include in the response. Used to request fields that are not
        /// normally returned in a standard response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalResponseFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalResponseFields property is set.
        /// </summary>
        internal bool IsSetAdditionalResponseFields() => this.AdditionalResponseFields != null && (this.AdditionalResponseFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// WorkDocs authentication token. Not required when using Amazon Web Services administrator
        /// credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters results based on entity metadata.
        /// </para>
        /// </summary>
        public Filters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Max results count per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Order by results in one or more categories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<SearchSortResult> OrderBy { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchSortResult>() : null;

        /// <summary>
        /// Checks to see if the OrderBy property is set.
        /// </summary>
        internal bool IsSetOrderBy() => this.OrderBy != null && (this.OrderBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// Filters based on the resource owner OrgId. This is a mandatory parameter when using
        /// Admin SigV4 credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property QueryScopes. 
        /// <para>
        /// Filter based on the text field type. A Folder has only a name and no content. A Comment
        /// has only content and no name. A Document or Document Version has a name and content
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> QueryScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryScopes property is set.
        /// </summary>
        internal bool IsSetQueryScopes() => this.QueryScopes != null && (this.QueryScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The String to search for. Searches across different text fields based on request parameters.
        /// Use double quotes around the query string for exact phrase matches.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 512)]
        public string QueryText { get; set; }

        /// <summary>
        /// Checks to see if the QueryText property is set.
        /// </summary>
        internal bool IsSetQueryText() => this.QueryText != null;
    }
}
