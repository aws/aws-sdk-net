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
    /// Output of the DescribeSearch operation.
    /// </summary>
    public partial class DescribeSearchResponse : AmazonWebServiceResponse
    {
        private string _groupId;
        private string _queryStatement;
        private string _searchId;
        private SearchType _searchType;
        private DateTime? _startedAt;
        private SearchStatus _status;
        private string _statusReason;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The group identifier associated with the search, if one was supplied on the request.
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
        /// The natural-language query that was submitted for the search.
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
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The unique identifier of the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=23, Max=36)]
        public string SearchId
        {
            get { return this._searchId; }
            set { this._searchId = value; }
        }

        // Check to see if SearchId property is set
        internal bool IsSetSearchId()
        {
            return this._searchId != null;
        }

        /// <summary>
        /// Gets and sets the property SearchType. 
        /// <para>
        /// The search strategy used for the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time at which the search was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current status. Populated when the search has
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search runs against.
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