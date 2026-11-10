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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateFlowLogs operation. Creates one or more
    /// flow logs to capture information about IP traffic for a specific network interface,
    /// subnet, or VPC. <para> Flow log data for a monitored network interface is recorded
    /// as flow log records, which are log events consisting of fields that describe the traffic
    /// flow. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-log-records.html">Flow
    /// log records</a> in the <i>Amazon VPC User Guide</i>. </para> <para> When publishing
    /// to CloudWatch Logs, flow log records are published to a log group, and each network
    /// interface has a unique log stream in the log group. When publishing to Amazon S3,
    /// flow log records for all of the monitored network interfaces are published to a single
    /// log file object that is stored in the specified bucket. </para> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-logs.html">VPC
    /// Flow Logs</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class CreateFlowLogsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeliverCrossAccountRole. 
        /// <para>
        /// The ARN of the IAM role that allows Amazon EC2 to publish flow logs across accounts.
        /// </para>
        /// </summary>
        public string DeliverCrossAccountRole { get; set; }

        /// <summary>
        /// Checks to see if the DeliverCrossAccountRole property is set.
        /// </summary>
        internal bool IsSetDeliverCrossAccountRole() => this.DeliverCrossAccountRole != null;

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
        public string DeliverLogsPermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the DeliverLogsPermissionArn property is set.
        /// </summary>
        internal bool IsSetDeliverLogsPermissionArn() => this.DeliverLogsPermissionArn != null;

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// The destination options.
        /// </para>
        /// </summary>
        public DestinationOptionsRequest DestinationOptions { get; set; }

        /// <summary>
        /// Checks to see if the DestinationOptions property is set.
        /// </summary>
        internal bool IsSetDestinationOptions() => this.DestinationOptions != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

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
        public string LogDestination { get; set; }

        /// <summary>
        /// Checks to see if the LogDestination property is set.
        /// </summary>
        internal bool IsSetLogDestination() => this.LogDestination != null;

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
        public LogDestinationType LogDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the LogDestinationType property is set.
        /// </summary>
        internal bool IsSetLogDestinationType() => this.LogDestinationType != null;

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
        public string LogFormat { get; set; }

        /// <summary>
        /// Checks to see if the LogFormat property is set.
        /// </summary>
        internal bool IsSetLogFormat() => this.LogFormat != null;

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
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

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
        public int? MaxAggregationInterval { get; set; }

        /// <summary>
        /// Checks to see if the MaxAggregationInterval property is set.
        /// </summary>
        internal bool IsSetMaxAggregationInterval() => this.MaxAggregationInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The IDs of the resources to monitor. For example, if the resource type is <c>VPC</c>,
        /// specify the IDs of the VPCs.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum of 25 for transit gateway resource types. Maximum of 300 for
        /// the other resource types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ResourceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceIds property is set.
        /// </summary>
        internal bool IsSetResourceIds() => this.ResourceIds != null && (this.ResourceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowLogsResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property TagFieldSpecifications. 
        /// <para>
        /// The tag configuration associated with the Flow Logs Amazon EC2 Tags feature fields
        /// in your custom log format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<TagFieldSpecificationRequest> TagFieldSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagFieldSpecificationRequest>() : null;

        /// <summary>
        /// Checks to see if the TagFieldSpecifications property is set.
        /// </summary>
        internal bool IsSetTagFieldSpecifications() => this.TagFieldSpecifications != null && (this.TagFieldSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the flow logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// The type of traffic to monitor (accepted traffic, rejected traffic, or all traffic).
        /// This parameter is not supported for transit gateway resource types. It is required
        /// for the other resource types.
        /// </para>
        /// </summary>
        public TrafficType TrafficType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficType property is set.
        /// </summary>
        internal bool IsSetTrafficType() => this.TrafficType != null;
    }
}
