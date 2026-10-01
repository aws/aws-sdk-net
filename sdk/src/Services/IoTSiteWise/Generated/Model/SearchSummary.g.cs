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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A summary of a single search as returned by ListSearches.
    /// </summary>
    public partial class SearchSummary
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The group identifier associated with the search, if one was supplied on the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 36)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        /// The natural-language query that was submitted for the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 5000)]
        public string QueryStatement { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatement property is set.
        /// </summary>
        internal bool IsSetQueryStatement() => this.QueryStatement != null;

        /// <summary>
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The unique identifier of the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 23, Max = 36)]
        public string SearchId { get; set; }

        /// <summary>
        /// Checks to see if the SearchId property is set.
        /// </summary>
        internal bool IsSetSearchId() => this.SearchId != null;

        /// <summary>
        /// Gets and sets the property SearchType. 
        /// <para>
        /// The search strategy used for the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchType SearchType { get; set; }

        /// <summary>
        /// Checks to see if the SearchType property is set.
        /// </summary>
        internal bool IsSetSearchType() => this.SearchType != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time at which the search was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current status. Populated when the search has
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search runs against.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
