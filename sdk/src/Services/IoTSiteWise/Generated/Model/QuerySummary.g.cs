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
    /// Contains summary information about a query.
    /// </summary>
    public partial class QuerySummary
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time when the query reached a terminal state, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique identifier for the query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current query status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The date and time when the query was submitted, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;
    }
}
