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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-log-records.html">Flow
    /// log records</a> in the <i>Amazon VPC User Guide</i>.
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
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-logs.html">VPC
    /// Flow Logs</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFlowLogsRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _deliverCrossAccountRole;
        private string _deliverLogsPermissionArn;
        private DestinationOptionsRequest _destinationOptions;
        private bool? _dryRun;
        private string _logDestination;
        private LogDestinationType _logDestinationType;
        private string _logFormat;
        private string _logGroupName;
        private int? _maxAggregationInterval;
        private List<string> _resourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FlowLogsResourceType _resourceType;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
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
        /// Gets and sets the property DeliverCrossAccountRole. 
        /// <para>
        /// The ARN of the IAM role that allows Amazon EC2 to publish flow logs across accounts.
        /// </para>
        /// </summary>
        public string DeliverCrossAccountRole
        {
            get { return this._deliverCrossAccountRole; }
            set { this._deliverCrossAccountRole = value; }
        }

        // Check to see if DeliverCrossAccountRole property is set
        internal bool IsSetDeliverCrossAccountRole()
        {
            return this._deliverCrossAccountRole != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsPermissionArn. 
        /// <para>
        /// The ARN of the IAM role that allows Amazon EC2 to publish flow logs to the log destination.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if the destination type is <c>cloud-watch-logs</c>, or
        /// if the destination type is <c>kinesis-data-firehose</c> and the delivery stream and
        /// the resources to monitor are in different accounts.
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
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// The destination options.
        /// </para>
        /// </summary>
        public DestinationOptionsRequest DestinationOptions
        {
            get { return this._destinationOptions; }
            set { this._destinationOptions = value; }
        }

        // Check to see if DestinationOptions property is set
        internal bool IsSetDestinationOptions()
        {
            return this._destinationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// The destination for the flow log data. The meaning of this parameter depends on the
        /// destination type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the destination type is <c>cloud-watch-logs</c>, specify the ARN of a CloudWatch
        /// Logs log group. For example:
        /// </para>
        ///  
        /// <para>
        /// arn:aws:logs:<i>region</i>:<i>account_id</i>:log-group:<i>my_group</i> 
        /// </para>
        ///  
        /// <para>
        /// Alternatively, use the <c>LogGroupName</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the destination type is <c>s3</c>, specify the ARN of an S3 bucket. For example:
        /// </para>
        ///  
        /// <para>
        /// arn:aws:s3:::<i>my_bucket</i>/<i>my_subfolder</i>/
        /// </para>
        ///  
        /// <para>
        /// The subfolder is optional. Note that you can't use <c>AWSLogs</c> as a subfolder name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the destination type is <c>kinesis-data-firehose</c>, specify the ARN of a Kinesis
        /// Data Firehose delivery stream. For example:
        /// </para>
        ///  
        /// <para>
        /// arn:aws:firehose:<i>region</i>:<i>account_id</i>:deliverystream:<i>my_stream</i> 
        /// </para>
        ///  </li> </ul>
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
        /// The type of destination for the flow log data.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>cloud-watch-logs</c> 
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
        /// The fields to include in the flow log record. List the fields in the order in which
        /// they should appear. If you omit this parameter, the flow log is created using the
        /// default format. If you specify this parameter, you must include at least one field.
        /// For more information about the available fields, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-log-records.html">Flow
        /// log records</a> in the <i>Amazon VPC User Guide</i> or <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-flow-logs.html#flow-log-records">Transit
        /// Gateway Flow Log records</a> in the <i>Amazon Web Services Transit Gateway Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Specify the fields using the <c>${field-id}</c> format, separated by spaces.
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
        /// The name of a new or existing CloudWatch Logs log group where Amazon EC2 publishes
        /// your flow logs.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only if the destination type is <c>cloud-watch-logs</c>.
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
        /// The maximum interval of time during which a flow of packets is captured and aggregated
        /// into a flow log record. The possible values are 60 seconds (1 minute) or 600 seconds
        /// (10 minutes). This parameter must be 60 seconds for transit gateway resource types.
        /// </para>
        ///  
        /// <para>
        /// When a network interface is attached to a <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">Nitro-based
        /// instance</a>, the aggregation interval is always 60 seconds or less, regardless of
        /// the value that you specify.
        /// </para>
        ///  
        /// <para>
        /// Default: 600
        /// </para>
        /// </summary>
        public int? MaxAggregationInterval
        {
            get { return this._maxAggregationInterval; }
            set { this._maxAggregationInterval = value; }
        }

        // Check to see if MaxAggregationInterval property is set
        internal bool IsSetMaxAggregationInterval()
        {
            return this._maxAggregationInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The IDs of the resources to monitor. For example, if the resource type is <c>VPC</c>,
        /// specify the IDs of the VPCs.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum of 25 for transit gateway resource types. Maximum of 1000 for
        /// the other resource types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && (this._resourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the flow logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// The type of traffic to monitor (accepted traffic, rejected traffic, or all traffic).
        /// This parameter is not supported for transit gateway resource types. It is required
        /// for the other resource types.
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