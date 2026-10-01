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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Summary information about a single query within a compliance inquiry.
    /// </summary>
    public partial class QuerySummary
    {
        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// Supporting citations for the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Citation> Citations { get; set; } = AWSConfigs.InitializeCollections ? new List<Citation>() : null;

        /// <summary>
        /// Checks to see if the Citations property is set.
        /// </summary>
        internal bool IsSetCitations() => this.Citations != null && (this.Citations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The actual query text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property QueryIdentifier. 
        /// <para>
        /// Sequential identifier of the query within the inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? QueryIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QueryIdentifier property is set.
        /// </summary>
        internal bool IsSetQueryIdentifier() => this.QueryIdentifier.HasValue;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// Generated response to the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property ReviewType. 
        /// <para>
        /// Type of review for the response.
        /// </para>
        /// </summary>
        public ReviewType ReviewType { get; set; }

        /// <summary>
        /// Checks to see if the ReviewType property is set.
        /// </summary>
        internal bool IsSetReviewType() => this.ReviewType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current processing status of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Descriptive status message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryStatusMessage StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedResponseVersions. 
        /// <para>
        /// Ordered list of response version history entries, oldest first.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponseVersion> UpdatedResponseVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResponseVersion>() : null;

        /// <summary>
        /// Checks to see if the UpdatedResponseVersions property is set.
        /// </summary>
        internal bool IsSetUpdatedResponseVersions() => this.UpdatedResponseVersions != null && (this.UpdatedResponseVersions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
