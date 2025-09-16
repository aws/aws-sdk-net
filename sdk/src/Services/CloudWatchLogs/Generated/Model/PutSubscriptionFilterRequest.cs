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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// A logical destination created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>
    /// that belongs to a different account, for cross-account delivery. We currently support
    /// Kinesis Data Streams and Firehose as logical destinations.
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
    /// are updating an existing filter, you must specify the correct name in <c>filterName</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Using regular expressions in filter patterns is supported. For these filters, there
    /// is a quotas of quota of two regular expression patterns within a single filter pattern.
    /// There is also a quota of five regular expression patterns per log group. For more
    /// information about using regular expressions in filter patterns, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">
    /// Filter pattern syntax for metric filters, subscription filters, filter log events,
    /// and Live Tail</a>.
    /// </para>
    ///  
    /// <para>
    /// To perform a <c>PutSubscriptionFilter</c> operation for any destination except a Lambda
    /// function, you must also have the <c>iam:PassRole</c> permission.
    /// </para>
    /// </summary>
    public partial class PutSubscriptionFilterRequest : AmazonCloudWatchLogsRequest
    {
        private bool? _applyOnTransformedLogs;
        private string _destinationArn;
        private Distribution _distribution;
        private List<string> _emitSystemFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _fieldSelectionCriteria;
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// This parameter is valid only for log groups that have an active log transformer. For
        /// more information about log transformers, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// </para>
        ///  
        /// <para>
        /// If the log group uses either a log-group level or account-level transformer, and you
        /// specify <c>true</c>, the subscription filter will be applied on the transformed version
        /// of the log events instead of the original ingested log events.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs
        {
            get { return this._applyOnTransformedLogs; }
            set { this._applyOnTransformedLogs = value; }
        }

        // Check to see if ApplyOnTransformedLogs property is set
        internal bool IsSetApplyOnTransformedLogs()
        {
            return this._applyOnTransformedLogs.HasValue; 
        }

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
        /// Gets and sets the property EmitSystemFields. 
        /// <para>
        /// A list of system fields to include in the log events sent to the subscription destination.
        /// Valid values are <c>@aws.account</c> and <c>@aws.region</c>. These fields provide
        /// source information for centralized log data in the forwarded payload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EmitSystemFields
        {
            get { return this._emitSystemFields; }
            set { this._emitSystemFields = value; }
        }

        // Check to see if EmitSystemFields property is set
        internal bool IsSetEmitSystemFields()
        {
            return this._emitSystemFields != null && (this._emitSystemFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldSelectionCriteria. 
        /// <para>
        /// A filter expression that specifies which log events should be processed by this subscription
        /// filter based on system fields such as source account and source region. Uses selection
        /// criteria syntax with operators like <c>=</c>, <c>!=</c>, <c>AND</c>, <c>OR</c>, <c>IN</c>,
        /// <c>NOT IN</c>. Example: <c>@aws.region NOT IN ["cn-north-1"]</c> or <c>@aws.account
        /// = "123456789012" AND @aws.region = "us-east-1"</c>. Maximum length: 2000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string FieldSelectionCriteria
        {
            get { return this._fieldSelectionCriteria; }
            set { this._fieldSelectionCriteria = value; }
        }

        // Check to see if FieldSelectionCriteria property is set
        internal bool IsSetFieldSelectionCriteria()
        {
            return this._fieldSelectionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// A name for the subscription filter. If you are updating an existing filter, you must
        /// specify the correct name in <c>filterName</c>. To find the name of the filter currently
        /// associated with a log group, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeSubscriptionFilters.html">DescribeSubscriptionFilters</a>.
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