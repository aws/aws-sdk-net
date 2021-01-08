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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a flow log.
    /// </summary>
    public partial class FlowLog
    {
        private DateTime? _creationTime;
        private string _deliverLogsErrorMessage;
        private string _deliverLogsPermissionArn;
        private string _deliverLogsStatus;
        private string _flowLogId;
        private string _flowLogStatus;
        private string _logDestination;
        private LogDestinationType _logDestinationType;
        private string _logFormat;
        private string _logGroupName;
        private int? _maxAggregationInterval;
        private string _resourceId;
        private List<Tag> _tags = new List<Tag>();
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the flow log was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsErrorMessage. 
        /// <para>
        /// Information about the error that occurred. <code>Rate limited</code> indicates that
        /// CloudWatch Logs throttling has been applied for one or more network interfaces, or
        /// that you've reached the limit on the number of log groups that you can create. <code>Access
        /// error</code> indicates that the IAM role associated with the flow log does not have
        /// sufficient permissions to publish to CloudWatch Logs. <code>Unknown error</code> indicates
        /// an internal error.
        /// </para>
        /// </summary>
        public string DeliverLogsErrorMessage
        {
            get { return this._deliverLogsErrorMessage; }
            set { this._deliverLogsErrorMessage = value; }
        }

        // Check to see if DeliverLogsErrorMessage property is set
        internal bool IsSetDeliverLogsErrorMessage()
        {
            return this._deliverLogsErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsPermissionArn. 
        /// <para>
        /// The ARN of the IAM role that posts logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public string DeliverLogsPermissionArn
        {
            get { return this._deliverLogsPermissionArn; }
            set { this._deliverLogsPermissionArn = value; }
        }

        // Check to see if DeliverLogsPermissionArn property is set
        internal bool IsSetDeliverLogsPermissionArn()
        {
            return this._deliverLogsPermissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsStatus. 
        /// <para>
        /// The status of the logs delivery (<code>SUCCESS</code> | <code>FAILED</code>).
        /// </para>
        /// </summary>
        public string DeliverLogsStatus
        {
            get { return this._deliverLogsStatus; }
            set { this._deliverLogsStatus = value; }
        }

        // Check to see if DeliverLogsStatus property is set
        internal bool IsSetDeliverLogsStatus()
        {
            return this._deliverLogsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogId. 
        /// <para>
        /// The flow log ID.
        /// </para>
        /// </summary>
        public string FlowLogId
        {
            get { return this._flowLogId; }
            set { this._flowLogId = value; }
        }

        // Check to see if FlowLogId property is set
        internal bool IsSetFlowLogId()
        {
            return this._flowLogId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogStatus. 
        /// <para>
        /// The status of the flow log (<code>ACTIVE</code>).
        /// </para>
        /// </summary>
        public string FlowLogStatus
        {
            get { return this._flowLogStatus; }
            set { this._flowLogStatus = value; }
        }

        // Check to see if FlowLogStatus property is set
        internal bool IsSetFlowLogStatus()
        {
            return this._flowLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// Specifies the destination to which the flow log data is published. Flow log data can
        /// be published to an CloudWatch Logs log group or an Amazon S3 bucket. If the flow log
        /// publishes to CloudWatch Logs, this element indicates the Amazon Resource Name (ARN)
        /// of the CloudWatch Logs log group to which the data is published. If the flow log publishes
        /// to Amazon S3, this element indicates the ARN of the Amazon S3 bucket to which the
        /// data is published.
        /// </para>
        /// </summary>
        public string LogDestination
        {
            get { return this._logDestination; }
            set { this._logDestination = value; }
        }

        // Check to see if LogDestination property is set
        internal bool IsSetLogDestination()
        {
            return this._logDestination != null;
        }

        /// <summary>
        /// Gets and sets the property LogDestinationType. 
        /// <para>
        /// Specifies the type of destination to which the flow log data is published. Flow log
        /// data can be published to CloudWatch Logs or Amazon S3.
        /// </para>
        /// </summary>
        public LogDestinationType LogDestinationType
        {
            get { return this._logDestinationType; }
            set { this._logDestinationType = value; }
        }

        // Check to see if LogDestinationType property is set
        internal bool IsSetLogDestinationType()
        {
            return this._logDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        /// The format of the flow log record.
        /// </para>
        /// </summary>
        public string LogFormat
        {
            get { return this._logFormat; }
            set { this._logFormat = value; }
        }

        // Check to see if LogFormat property is set
        internal bool IsSetLogFormat()
        {
            return this._logFormat != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the flow log group.
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
        /// Gets and sets the property MaxAggregationInterval. 
        /// <para>
        /// The maximum interval of time, in seconds, during which a flow of packets is captured
        /// and aggregated into a flow log record.
        /// </para>
        ///  
        /// <para>
        /// When a network interface is attached to a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Nitro-based
        /// instance</a>, the aggregation interval is always 60 seconds (1 minute) or less, regardless
        /// of the specified value.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>60</code> | <code>600</code> 
        /// </para>
        /// </summary>
        public int MaxAggregationInterval
        {
            get { return this._maxAggregationInterval.GetValueOrDefault(); }
            set { this._maxAggregationInterval = value; }
        }

        // Check to see if MaxAggregationInterval property is set
        internal bool IsSetMaxAggregationInterval()
        {
            return this._maxAggregationInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource on which the flow log was created.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the flow log.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// The type of traffic captured for the flow log.
        /// </para>
        /// </summary>
        public TrafficType TrafficType
        {
            get { return this._trafficType; }
            set { this._trafficType = value; }
        }

        // Check to see if TrafficType property is set
        internal bool IsSetTrafficType()
        {
            return this._trafficType != null;
        }

    }
}