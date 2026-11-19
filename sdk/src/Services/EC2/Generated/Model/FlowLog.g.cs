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
    /// Describes a flow log.
    /// </summary>
    public partial class FlowLog
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the flow log was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeliverCrossAccountRole. 
        /// <para>
        /// The ARN of the IAM role that allows the service to publish flow logs across accounts.
        /// </para>
        /// </summary>
        public string DeliverCrossAccountRole { get; set; }

        /// <summary>
        /// Checks to see if the DeliverCrossAccountRole property is set.
        /// </summary>
        internal bool IsSetDeliverCrossAccountRole() => this.DeliverCrossAccountRole != null;

        /// <summary>
        /// Gets and sets the property DeliverLogsErrorMessage. 
        /// <para>
        /// Information about the error that occurred. <c>Rate limited</c> indicates that CloudWatch
        /// Logs throttling has been applied for one or more network interfaces, or that you've
        /// reached the limit on the number of log groups that you can create. <c>Access error</c>
        /// indicates that the IAM role associated with the flow log does not have sufficient
        /// permissions to publish to CloudWatch Logs. <c>Unknown error</c> indicates an internal
        /// error.
        /// </para>
        /// </summary>
        public string DeliverLogsErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeliverLogsErrorMessage property is set.
        /// </summary>
        internal bool IsSetDeliverLogsErrorMessage() => this.DeliverLogsErrorMessage != null;

        /// <summary>
        /// Gets and sets the property DeliverLogsPermissionArn. 
        /// <para>
        /// The ARN of the IAM role allows the service to publish logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public string DeliverLogsPermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the DeliverLogsPermissionArn property is set.
        /// </summary>
        internal bool IsSetDeliverLogsPermissionArn() => this.DeliverLogsPermissionArn != null;

        /// <summary>
        /// Gets and sets the property DeliverLogsStatus. 
        /// <para>
        /// The status of the logs delivery (<c>SUCCESS</c> | <c>FAILED</c>).
        /// </para>
        /// </summary>
        public string DeliverLogsStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliverLogsStatus property is set.
        /// </summary>
        internal bool IsSetDeliverLogsStatus() => this.DeliverLogsStatus != null;

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// The destination options.
        /// </para>
        /// </summary>
        public DestinationOptionsResponse DestinationOptions { get; set; }

        /// <summary>
        /// Checks to see if the DestinationOptions property is set.
        /// </summary>
        internal bool IsSetDestinationOptions() => this.DestinationOptions != null;

        /// <summary>
        /// Gets and sets the property FlowLogId. 
        /// <para>
        /// The ID of the flow log.
        /// </para>
        /// </summary>
        public string FlowLogId { get; set; }

        /// <summary>
        /// Checks to see if the FlowLogId property is set.
        /// </summary>
        internal bool IsSetFlowLogId() => this.FlowLogId != null;

        /// <summary>
        /// Gets and sets the property FlowLogStatus. 
        /// <para>
        /// The status of the flow log (<c>ACTIVE</c>).
        /// </para>
        /// </summary>
        public string FlowLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowLogStatus property is set.
        /// </summary>
        internal bool IsSetFlowLogStatus() => this.FlowLogStatus != null;

        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination for the flow log data.
        /// </para>
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
        /// </summary>
        public LogDestinationType LogDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the LogDestinationType property is set.
        /// </summary>
        internal bool IsSetLogDestinationType() => this.LogDestinationType != null;

        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        /// The format of the flow log record.
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
        /// The name of the flow log group.
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
        /// The maximum interval of time, in seconds, during which a flow of packets is captured
        /// and aggregated into a flow log record.
        /// </para>
        ///  
        /// <para>
        /// When a network interface is attached to a <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">Nitro-based
        /// instance</a>, the aggregation interval is always 60 seconds (1 minute) or less, regardless
        /// of the specified value.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>60</c> | <c>600</c> 
        /// </para>
        /// </summary>
        public int? MaxAggregationInterval { get; set; }

        /// <summary>
        /// Checks to see if the MaxAggregationInterval property is set.
        /// </summary>
        internal bool IsSetMaxAggregationInterval() => this.MaxAggregationInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource being monitored.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

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
        public List<TagFieldSpecificationResponse> TagFieldSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagFieldSpecificationResponse>() : null;

        /// <summary>
        /// Checks to see if the TagFieldSpecifications property is set.
        /// </summary>
        internal bool IsSetTagFieldSpecifications() => this.TagFieldSpecifications != null && (this.TagFieldSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the flow log.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// The type of traffic captured for the flow log.
        /// </para>
        /// </summary>
        public TrafficType TrafficType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficType property is set.
        /// </summary>
        internal bool IsSetTrafficType() => this.TrafficType != null;
    }
}
