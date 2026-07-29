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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the StartSearch operation.
    /// Starts an asynchronous search over the data in a workspace. The search runs in the
    /// background; the response returns immediately with a <c>searchId</c> and an initial
    /// status of <c>QUEUED</c>. Use <c>DescribeSearch</c> to poll for completion and <c>GetSearchResults</c>
    /// to retrieve the results once the search reaches <c>SUCCEEDED</c>. The request is idempotent
    /// on <c>clientToken</c>: repeating a call with the same token returns the original search
    /// instead of starting a new one.
    /// </summary>
    public partial class StartSearchRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private string _groupId;
        private string _queryStatement;
        private SearchFilters _searchFilters;
        private SearchType _searchType;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure the request is idempotent.
        /// Repeating a StartSearch call with the same <c>clientToken</c> returns the original
        /// search rather than starting a new one. If omitted, the SDK autogenerates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// An optional caller-supplied identifier used to group related searches together.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=36)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        /// The natural-language query describing the data to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=5000)]
        public string QueryStatement
        {
            get { return this._queryStatement; }
            set { this._queryStatement = value; }
        }

        // Check to see if QueryStatement property is set
        internal bool IsSetQueryStatement()
        {
            return this._queryStatement != null;
        }

        /// <summary>
        /// Gets and sets the property SearchFilters. 
        /// <para>
        /// Optional filters that restrict the search to a subset of the workspace's data.
        /// </para>
        /// </summary>
        public SearchFilters SearchFilters
        {
            get { return this._searchFilters; }
            set { this._searchFilters = value; }
        }

        // Check to see if SearchFilters property is set
        internal bool IsSetSearchFilters()
        {
            return this._searchFilters != null;
        }

        /// <summary>
        /// Gets and sets the property SearchType. 
        /// <para>
        /// The search strategy to use. Defaults to <c>QUICK</c> when omitted.
        /// </para>
        /// </summary>
        public SearchType SearchType
        {
            get { return this._searchType; }
            set { this._searchType = value; }
        }

        // Check to see if SearchType property is set
        internal bool IsSetSearchType()
        {
            return this._searchType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace whose data is searched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}