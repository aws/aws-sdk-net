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
    /// This is the response object from the DescribeQuery operation.
    /// </summary>
    public partial class DescribeQueryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeliveryS3Uri. 
        /// <para>
        /// The URI for the S3 bucket where CloudTrail delivered query results, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeliveryS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryS3Uri property is set.
        /// </summary>
        internal bool IsSetDeliveryS3Uri() => this.DeliveryS3Uri != null;

        /// <summary>
        /// Gets and sets the property DeliveryStatus. 
        /// <para>
        /// The delivery status.
        /// </para>
        /// </summary>
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStatus property is set.
        /// </summary>
        internal bool IsSetDeliveryStatus() => this.DeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message returned if a query failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

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
        /// Gets and sets the property Prompt. 
        /// <para>
        ///  The prompt used for a generated query. For information about generated queries, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html">Create
        /// CloudTrail Lake queries from natural language prompts</a> in the <i>CloudTrail </i>
        /// user guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 500)]
        public string Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property QueryStatistics. 
        /// <para>
        /// Metadata about a query, including the number of events that were matched, the total
        /// number of events scanned, the query run time in milliseconds, and the query's creation
        /// time.
        /// </para>
        /// </summary>
        public QueryStatisticsForDescribeQuery QueryStatistics { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatistics property is set.
        /// </summary>
        internal bool IsSetQueryStatistics() => this.QueryStatistics != null;

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// The status of a query. Values for <c>QueryStatus</c> include <c>QUEUED</c>, <c>RUNNING</c>,
        /// <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>CANCELLED</c> 
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatus property is set.
        /// </summary>
        internal bool IsSetQueryStatus() => this.QueryStatus != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The SQL code of a query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;
    }
}
