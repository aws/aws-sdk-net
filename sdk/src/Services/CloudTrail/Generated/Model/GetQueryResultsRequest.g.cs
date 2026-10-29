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
    /// Container for the parameters to the GetQueryResults operation. <important> <para>
    /// CloudTrail Lake will no longer be open to new customers starting May 31, 2026. If
    /// you would like to use CloudTrail Lake, sign up prior to that date. Existing customers
    /// can continue to use the service as normal. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-service-availability-change.html">CloudTrail
    /// Lake availability change</a>. </para> </important> <para> Gets event data results
    /// of a query. You must specify the <c>QueryID</c> value returned by the <c>StartQuery</c>
    /// operation. </para>
    /// </summary>
    public partial class GetQueryResultsRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or ID suffix of the ARN) of the event data store against which the query
        /// was run.
        /// </para>
        /// </summary>
        [Obsolete("EventDataStore is no longer required by GetQueryResultsRequest")]
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStore { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStore property is set.
        /// </summary>
        internal bool IsSetEventDataStore() => this.EventDataStore != null;

        /// <summary>
        /// Gets and sets the property EventDataStoreOwnerAccountId. 
        /// <para>
        ///  The account ID of the event data store owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 16)]
        public string EventDataStoreOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetEventDataStoreOwnerAccountId() => this.EventDataStoreOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property MaxQueryResults. 
        /// <para>
        /// The maximum number of query results to display on a single page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxQueryResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxQueryResults property is set.
        /// </summary>
        internal bool IsSetMaxQueryResults() => this.MaxQueryResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use to get the next page of query results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the query for which you want to get results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;
    }
}
