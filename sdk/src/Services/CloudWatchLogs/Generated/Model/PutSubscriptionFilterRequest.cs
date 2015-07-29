/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutSubscriptionFilter operation.
    /// Creates or updates a subscription filter and associates it with the specified log
    /// group. Subscription filters allow you to subscribe to a real-time stream of log events
    /// ingested through <code class="code">PutLogEvents</code> requests and have them delivered
    /// to a specific destination. Currently, the supported destinations are: <ul> <li> A
    /// Amazon Kinesis stream belonging to the same account as the subscription filter, for
    /// same-account delivery. </li> <li> A logical destination (used via an ARN of <code>Destination</code>)
    /// belonging to a different account, for cross-account delivery. </li> </ul> 
    /// 
    ///  
    /// <para>
    ///  Currently there can only be one subscription filter associated with a log group.
    /// 
    /// </para>
    /// </summary>
    public partial class PutSubscriptionFilterRequest : AmazonCloudWatchLogsRequest
    {
        private string _destinationArn;
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the destination to deliver matching log events to. Currently, the supported
        /// destinations are: <ul> <li> A Amazon Kinesis stream belonging to the same account
        /// as the subscription filter, for same-account delivery. </li> <li> A logical destination
        /// (used via an ARN of <code>Destination</code>) belonging to a different account, for
        /// cross-account delivery. </li> </ul> 
        /// </para>
        /// </summary>
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// A name for the subscription filter.
        /// </para>
        /// </summary>
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// A valid CloudWatch Logs filter pattern for subscribing to a filtered stream of log
        /// events.
        /// </para>
        /// </summary>
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group to associate the subscription filter with.
        /// </para>
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that grants Amazon CloudWatch Logs permissions to deliver ingested
        /// log events to the destination stream. You don't need to provide the ARN when you are
        /// working with a logical destination (used via an ARN of <code>Destination</code>) for
        /// cross-account delivery.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}