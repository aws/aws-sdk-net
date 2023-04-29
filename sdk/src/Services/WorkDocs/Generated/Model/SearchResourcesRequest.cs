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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the SearchResources operation.
    /// Searches metadata and the content of folders, documents, document versions, and comments.
    /// </summary>
    public partial class SearchResourcesRequest : AmazonWorkDocsRequest
    {
        private List<string> _additionalResponseFields = new List<string>();
        private string _authenticationToken;
        private Filters _filters;
        private int? _limit;
        private string _marker;
        private List<SearchSortResult> _orderBy = new List<SearchSortResult>();
        private string _organizationId;
        private List<string> _queryScopes = new List<string>();
        private string _queryText;

        /// <summary>
        /// Gets and sets the property AdditionalResponseFields. 
        /// <para>
        /// A list of attributes to include in the response. Used to request fields that are not
        /// normally returned in a standard response.
        /// </para>
        /// </summary>
        public List<string> AdditionalResponseFields
        {
            get { return this._additionalResponseFields; }
            set { this._additionalResponseFields = value; }
        }

        // Check to see if AdditionalResponseFields property is set
        internal bool IsSetAdditionalResponseFields()
        {
            return this._additionalResponseFields != null && this._additionalResponseFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters results based on entity metadata.
        /// </para>
        /// </summary>
        public Filters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Max results count per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Order by results in one or more categories.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<SearchSortResult> OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null && this._orderBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// Filters based on the resource owner OrgId. This is a mandatory parameter when using
        /// Admin SigV4 credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property QueryScopes. 
        /// <para>
        /// Filter based on the text field type. A Folder has only a name and no content. A Comment
        /// has only content and no name. A Document or Document Version has a name and content
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> QueryScopes
        {
            get { return this._queryScopes; }
            set { this._queryScopes = value; }
        }

        // Check to see if QueryScopes property is set
        internal bool IsSetQueryScopes()
        {
            return this._queryScopes != null && this._queryScopes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The String to search for. Searches across different text fields based on request parameters.
        /// Use double quotes around the query string for exact phrase matches.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=512)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

    }
}