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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteScheduledQuery operation.
    /// You can use this API to run a scheduled query manually. 
    /// 
    ///  
    /// <para>
    /// If you enabled <c>QueryInsights</c>, this API also returns insights and metrics related
    /// to the query that you executed as part of an Amazon SNS notification. <c>QueryInsights</c>
    /// helps with performance tuning of your query. For more information about <c>QueryInsights</c>,
    /// see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/using-query-insights.html">Using
    /// query insights to optimize queries in Amazon Timestream</a>.
    /// </para>
    /// </summary>
    public partial class ExecuteScheduledQueryRequest : AmazonTimestreamQueryRequest
    {
        private string _clientToken;
        private DateTime? _invocationTime;
        private ScheduledQueryInsights _queryInsights;
        private string _scheduledQueryArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Not used. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=32, Max=128)]
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
        /// Gets and sets the property InvocationTime. 
        /// <para>
        /// The timestamp in UTC. Query will be run as if it was invoked at this timestamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? InvocationTime
        {
            get { return this._invocationTime; }
            set { this._invocationTime = value; }
        }

        // Check to see if InvocationTime property is set
        internal bool IsSetInvocationTime()
        {
            return this._invocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryInsights. 
        /// <para>
        /// Encapsulates settings for enabling <c>QueryInsights</c>.
        /// </para>
        ///  
        /// <para>
        /// Enabling <c>QueryInsights</c> returns insights and metrics as a part of the Amazon
        /// SNS notification for the query that you executed. You can use <c>QueryInsights</c>
        /// to tune your query performance and cost.
        /// </para>
        /// </summary>
        public ScheduledQueryInsights QueryInsights
        {
            get { return this._queryInsights; }
            set { this._queryInsights = value; }
        }

        // Check to see if QueryInsights property is set
        internal bool IsSetQueryInsights()
        {
            return this._queryInsights != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledQueryArn. 
        /// <para>
        /// ARN of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ScheduledQueryArn
        {
            get { return this._scheduledQueryArn; }
            set { this._scheduledQueryArn = value; }
        }

        // Check to see if ScheduledQueryArn property is set
        internal bool IsSetScheduledQueryArn()
        {
            return this._scheduledQueryArn != null;
        }

    }
}