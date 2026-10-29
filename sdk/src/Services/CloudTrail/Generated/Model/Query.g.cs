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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A SQL string of criteria about events that you want to collect in an event data store.
    /// </summary>
    public partial class Query
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of a query.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of a query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// The status of the query. This can be <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatus property is set.
        /// </summary>
        internal bool IsSetQueryStatus() => this.QueryStatus != null;
    }
}
