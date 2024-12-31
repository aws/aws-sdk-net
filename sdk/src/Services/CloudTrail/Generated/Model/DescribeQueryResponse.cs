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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
        private string _deliveryS3Uri;
        private DeliveryStatus _deliveryStatus;
        private string _errorMessage;
        private string _eventDataStoreOwnerAccountId;
        private string _prompt;
        private string _queryId;
        private QueryStatisticsForDescribeQuery _queryStatistics;
        private QueryStatus _queryStatus;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property DeliveryS3Uri. 
        /// <para>
        /// The URI for the S3 bucket where CloudTrail delivered query results, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DeliveryS3Uri
        {
            get { return this._deliveryS3Uri; }
            set { this._deliveryS3Uri = value; }
        }

        // Check to see if DeliveryS3Uri property is set
        internal bool IsSetDeliveryS3Uri()
        {
            return this._deliveryS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStatus. 
        /// <para>
        /// The delivery status.
        /// </para>
        /// </summary>
        public DeliveryStatus DeliveryStatus
        {
            get { return this._deliveryStatus; }
            set { this._deliveryStatus = value; }
        }

        // Check to see if DeliveryStatus property is set
        internal bool IsSetDeliveryStatus()
        {
            return this._deliveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message returned if a query failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreOwnerAccountId. 
        /// <para>
        ///  The account ID of the event data store owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=16)]
        public string EventDataStoreOwnerAccountId
        {
            get { return this._eventDataStoreOwnerAccountId; }
            set { this._eventDataStoreOwnerAccountId = value; }
        }

        // Check to see if EventDataStoreOwnerAccountId property is set
        internal bool IsSetEventDataStoreOwnerAccountId()
        {
            return this._eventDataStoreOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        ///  The prompt used for a generated query. For information about generated queries, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html">Create
        /// CloudTrail Lake queries from natural language prompts</a> in the <i>CloudTrail </i>
        /// user guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=500)]
        public string Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatistics. 
        /// <para>
        /// Metadata about a query, including the number of events that were matched, the total
        /// number of events scanned, the query run time in milliseconds, and the query's creation
        /// time.
        /// </para>
        /// </summary>
        public QueryStatisticsForDescribeQuery QueryStatistics
        {
            get { return this._queryStatistics; }
            set { this._queryStatistics = value; }
        }

        // Check to see if QueryStatistics property is set
        internal bool IsSetQueryStatistics()
        {
            return this._queryStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// The status of a query. Values for <c>QueryStatus</c> include <c>QUEUED</c>, <c>RUNNING</c>,
        /// <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>CANCELLED</c> 
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus
        {
            get { return this._queryStatus; }
            set { this._queryStatus = value; }
        }

        // Check to see if QueryStatus property is set
        internal bool IsSetQueryStatus()
        {
            return this._queryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The SQL code of a query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}