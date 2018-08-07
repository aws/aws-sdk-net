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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFlowLogs operation.
    /// Creates one or more flow logs to capture information about IP traffic for a specific
    /// network interface, subnet, or VPC. 
    /// 
    ///  
    /// <para>
    /// Flow log data for a monitored network interface is recorded as flow log records, which
    /// are log events consisting of fields that describe the traffic flow. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/flow-logs.html#flow-log-records">Flow
    /// Log Records</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When publishing to CloudWatch Logs, flow log records are published to a log group,
    /// and each network interface has a unique log stream in the log group. When publishing
    /// to Amazon S3, flow log records for all of the monitored network interfaces are published
    /// to a single log file object that is stored in the specified bucket.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/flow-logs.html">VPC
    /// Flow Logs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFlowLogsRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _deliverLogsPermissionArn;
        private string _logDestination;
        private LogDestinationType _logDestinationType;
        private string _logGroupName;
        private List<string> _resourceIds = new List<string>();
        private FlowLogsResourceType _resourceType;
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeliverLogsPermissionArn. 
        /// <para>
        /// The ARN for the IAM role that's used to post flow logs to a log group.
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
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// Specifies the destination to which the flow log data is to be published. Flow log
        /// data can be published to an CloudWatch Logs log group or an Amazon S3 bucket. The
        /// value specified for this parameter depends on the value specified for LogDestinationType.
        /// </para>
        ///  
        /// <para>
        /// If LogDestinationType is not specified or <code>cloud-watch-logs</code>, specify the
        /// Amazon Resource Name (ARN) of the CloudWatch Logs log group.
        /// </para>
        ///  
        /// <para>
        /// If LogDestinationType is <code>s3</code>, specify the ARN of the Amazon S3 bucket.
        /// You can also specify a subfolder in the bucket. To specify a subfolder in the bucket,
        /// use the following ARN format: <code>bucket_ARN/subfolder_name/</code>. For example,
        /// to specify a subfolder named <code>my-logs</code> in a bucket named <code>my-bucket</code>,
        /// use the following ARN: <code>arn:aws:s3:::my-bucket/my-logs/</code>.
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
        /// Specifies the type of destination to which the flow log data is to be published. Flow
        /// log data can be published to CloudWatch Logs or Amazon S3. To publish flow log data
        /// to CloudWatch Logs, specify <code>cloud-watch-logs</code>. To publish flow log data
        /// to Amazon S3, specify <code>s3</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>cloud-watch-logs</code> 
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
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
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
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// One or more subnet, network interface, or VPC IDs.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum of 1000 resources
        /// </para>
        /// </summary>
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource on which to create the flow log.
        /// </para>
        /// </summary>
        public FlowLogsResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// The type of traffic to log.
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