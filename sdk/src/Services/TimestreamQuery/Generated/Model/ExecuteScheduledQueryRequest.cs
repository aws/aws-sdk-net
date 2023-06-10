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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteScheduledQuery operation.
    /// You can use this API to run a scheduled query manually.
    /// </summary>
    public partial class ExecuteScheduledQueryRequest : AmazonTimestreamQueryRequest
    {
        private string _clientToken;
        private DateTime? _invocationTime;
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
        public DateTime InvocationTime
        {
            get { return this._invocationTime.GetValueOrDefault(); }
            set { this._invocationTime = value; }
        }

        // Check to see if InvocationTime property is set
        internal bool IsSetInvocationTime()
        {
            return this._invocationTime.HasValue; 
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