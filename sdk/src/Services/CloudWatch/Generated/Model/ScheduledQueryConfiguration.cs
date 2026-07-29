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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The configuration of the CloudWatch Logs scheduled query that backs a log alarm.
    /// </summary>
    public partial class ScheduledQueryConfiguration
    {
        private string _aggregationExpression;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _queryARN;
        private string _queryString;
        private ScheduleConfiguration _scheduleConfiguration;
        private string _scheduledQueryRoleARN;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AggregationExpression. 
        /// <para>
        /// The expression that defines how to aggregate query results into one or more scalar
        /// values for alarm evaluation. For example, <c>count(*)</c> or <c>avg(latency) by host
        /// | sort desc</c>. Length constraints: minimum 1 character, maximum 2048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AggregationExpression
        {
            get { return this._aggregationExpression; }
            set { this._aggregationExpression = value; }
        }

        // Check to see if AggregationExpression property is set
        internal bool IsSetAggregationExpression()
        {
            return this._aggregationExpression != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// The log groups to query. Each entry can be a log group name or ARN. Use the ARN form
        /// when querying log groups in a different account (for example, when running cross-account
        /// queries from a monitoring account). The list must contain between 1 and 50 entries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> LogGroupIdentifiers
        {
            get { return this._logGroupIdentifiers; }
            set { this._logGroupIdentifiers = value; }
        }

        // Check to see if LogGroupIdentifiers property is set
        internal bool IsSetLogGroupIdentifiers()
        {
            return this._logGroupIdentifiers != null && (this._logGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs scheduled query that the alarm
        /// uses. This field is populated in <c>DescribeAlarms</c> responses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string QueryARN
        {
            get { return this._queryARN; }
            set { this._queryARN = value; }
        }

        // Check to see if QueryARN property is set
        internal bool IsSetQueryARN()
        {
            return this._queryARN != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The CloudWatch Logs query to execute on each scheduled run. Length constraints: maximum
        /// of 10,000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
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

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule and time-range offset configuration for the underlying scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledQueryRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that CloudWatch assumes when executing
        /// the scheduled query against the configured log groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ScheduledQueryRoleARN
        {
            get { return this._scheduledQueryRoleARN; }
            set { this._scheduledQueryRoleARN = value; }
        }

        // Check to see if ScheduledQueryRoleARN property is set
        internal bool IsSetScheduledQueryRoleARN()
        {
            return this._scheduledQueryRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the underlying scheduled query resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}