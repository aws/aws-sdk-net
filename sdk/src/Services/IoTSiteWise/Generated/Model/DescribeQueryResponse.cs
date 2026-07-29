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
    /// Contains the response for the DescribeQuery operation.
    /// </summary>
    public partial class DescribeQueryResponse : AmazonWebServiceResponse
    {
        private DateTime? _completedAt;
        private string _errorMessage;
        private string _queryId;
        private QueryStatistics _statistics;
        private QueryStatus _status;
        private DateTime? _submittedAt;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time when the query reached a terminal state, in Unix epoch time. This
        /// field is present when the query status is COMPLETED, FAILED, or CANCELED.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable error description. This field is present when the query status is
        /// FAILED.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique identifier for the query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The query execution statistics. This field is present when the query status is COMPLETED.
        /// </para>
        /// </summary>
        public QueryStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current query status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryStatus Status
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
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The date and time when the query was submitted, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmittedAt
        {
            get { return this._submittedAt; }
            set { this._submittedAt = value; }
        }

        // Check to see if SubmittedAt property is set
        internal bool IsSetSubmittedAt()
        {
            return this._submittedAt.HasValue; 
        }

    }
}