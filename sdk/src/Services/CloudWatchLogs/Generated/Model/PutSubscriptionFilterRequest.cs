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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutSubscriptionFilter operation.
    /// Creates or updates a subscription filter and associates it with the specified log
    /// group. With subscription filters, you can subscribe to a real-time stream of log events
    /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>
    /// and have them delivered to a specific destination. When log events are sent to the
    /// receiving service, they are Base64 encoded and compressed with the GZIP format.
    /// 
    ///  
    /// <para>
    /// The following destinations are supported for subscription filters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Amazon Kinesis data stream belonging to the same account as the subscription filter,
    /// for same-account delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A logical destination that belongs to a different account, for cross-account delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Amazon Kinesis Data Firehose delivery stream that belongs to the same account as
    /// the subscription filter, for same-account delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Lambda function that belongs to the same account as the subscription filter, for
    /// same-account delivery.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each log group can have up to two subscription filters associated with it. If you
    /// are updating an existing filter, you must specify the correct name in <code>filterName</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To perform a <code>PutSubscriptionFilter</code> operation, you must also have the
    /// <code>iam:PassRole</code> permission.
    /// </para>
    /// </summary>
    public partial class PutSubscriptionFilterRequest : AmazonCloudWatchLogsRequest
    {
        private string _destinationArn;
        private Distribution _distribution;
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the destination to deliver matching log events to. Currently, the supported
        /// destinations are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Kinesis stream belonging to the same account as the subscription filter,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination (specified using an ARN) belonging to a different account, for
        /// cross-account delivery.
        /// </para>
        ///  
        /// <para>
        /// If you're setting up a cross-account subscription, the destination must have an IAM
        /// policy associated with it. The IAM policy must allow the sender to send logs to the
        /// destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestinationPolicy.html">PutDestinationPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Kinesis Data Firehose delivery stream belonging to the same account as the subscription
        /// filter, for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Lambda function belonging to the same account as the subscription filter, for same-account
        /// delivery.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property Distribution. 
        /// <para>
        /// The method used to distribute log data to the destination. By default, log data is
        /// grouped by log stream, but the grouping can be set to random for a more even distribution.
        /// This property is only applicable when the destination is an Amazon Kinesis data stream.
        /// 
        /// </para>
        /// </summary>
        public Distribution Distribution
        {
            get { return this._distribution; }
            set { this._distribution = value; }
        }

        // Check to see if Distribution property is set
        internal bool IsSetDistribution()
        {
            return this._distribution != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// A name for the subscription filter. If you are updating an existing filter, you must
        /// specify the correct name in <code>filterName</code>. To find the name of the filter
        /// currently associated with a log group, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeSubscriptionFilters.html">DescribeSubscriptionFilters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// A filter pattern for subscribing to a filtered stream of log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// The ARN of an IAM role that grants CloudWatch Logs permissions to deliver ingested
        /// log events to the destination stream. You don't need to provide the ARN when you are
        /// working with a logical destination for cross-account delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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