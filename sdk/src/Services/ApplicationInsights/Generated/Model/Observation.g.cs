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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes an anomaly or error with the application.
    /// </summary>
    public partial class Observation
    {
        /// <summary>
        /// Gets and sets the property CloudWatchEventDetailType. 
        /// <para>
        ///  The detail type of the CloudWatch Event-based observation, for example, <c>EC2 Instance
        /// State-change Notification</c>. 
        /// </para>
        /// </summary>
        public string CloudWatchEventDetailType { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchEventDetailType property is set.
        /// </summary>
        internal bool IsSetCloudWatchEventDetailType() => this.CloudWatchEventDetailType != null;

        /// <summary>
        /// Gets and sets the property CloudWatchEventId. 
        /// <para>
        ///  The ID of the CloudWatch Event-based observation related to the detected problem.
        /// 
        /// </para>
        /// </summary>
        public string CloudWatchEventId { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchEventId property is set.
        /// </summary>
        internal bool IsSetCloudWatchEventId() => this.CloudWatchEventId != null;

        /// <summary>
        /// Gets and sets the property CloudWatchEventSource. 
        /// <para>
        ///  The source of the CloudWatch Event. 
        /// </para>
        /// </summary>
        public CloudWatchEventSource CloudWatchEventSource { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchEventSource property is set.
        /// </summary>
        internal bool IsSetCloudWatchEventSource() => this.CloudWatchEventSource != null;

        /// <summary>
        /// Gets and sets the property CodeDeployApplication. 
        /// <para>
        ///  The CodeDeploy application to which the deployment belongs. 
        /// </para>
        /// </summary>
        public string CodeDeployApplication { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeployApplication property is set.
        /// </summary>
        internal bool IsSetCodeDeployApplication() => this.CodeDeployApplication != null;

        /// <summary>
        /// Gets and sets the property CodeDeployDeploymentGroup. 
        /// <para>
        ///  The deployment group to which the CodeDeploy deployment belongs. 
        /// </para>
        /// </summary>
        public string CodeDeployDeploymentGroup { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeployDeploymentGroup property is set.
        /// </summary>
        internal bool IsSetCodeDeployDeploymentGroup() => this.CodeDeployDeploymentGroup != null;

        /// <summary>
        /// Gets and sets the property CodeDeployDeploymentId. 
        /// <para>
        ///  The deployment ID of the CodeDeploy-based observation related to the detected problem.
        /// 
        /// </para>
        /// </summary>
        public string CodeDeployDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeployDeploymentId property is set.
        /// </summary>
        internal bool IsSetCodeDeployDeploymentId() => this.CodeDeployDeploymentId != null;

        /// <summary>
        /// Gets and sets the property CodeDeployInstanceGroupId. 
        /// <para>
        ///  The instance group to which the CodeDeploy instance belongs. 
        /// </para>
        /// </summary>
        public string CodeDeployInstanceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeployInstanceGroupId property is set.
        /// </summary>
        internal bool IsSetCodeDeployInstanceGroupId() => this.CodeDeployInstanceGroupId != null;

        /// <summary>
        /// Gets and sets the property CodeDeployState. 
        /// <para>
        ///  The status of the CodeDeploy deployment, for example <c>SUCCESS</c> or <c> FAILURE</c>.
        /// 
        /// </para>
        /// </summary>
        public string CodeDeployState { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeployState property is set.
        /// </summary>
        internal bool IsSetCodeDeployState() => this.CodeDeployState != null;

        /// <summary>
        /// Gets and sets the property EbsCause. 
        /// <para>
        ///  The cause of an EBS CloudWatch event. 
        /// </para>
        /// </summary>
        public string EbsCause { get; set; }

        /// <summary>
        /// Checks to see if the EbsCause property is set.
        /// </summary>
        internal bool IsSetEbsCause() => this.EbsCause != null;

        /// <summary>
        /// Gets and sets the property EbsEvent. 
        /// <para>
        ///  The type of EBS CloudWatch event, such as <c>createVolume</c>, <c>deleteVolume</c>
        /// or <c>attachVolume</c>. 
        /// </para>
        /// </summary>
        public string EbsEvent { get; set; }

        /// <summary>
        /// Checks to see if the EbsEvent property is set.
        /// </summary>
        internal bool IsSetEbsEvent() => this.EbsEvent != null;

        /// <summary>
        /// Gets and sets the property EbsRequestId. 
        /// <para>
        ///  The request ID of an EBS CloudWatch event. 
        /// </para>
        /// </summary>
        public string EbsRequestId { get; set; }

        /// <summary>
        /// Checks to see if the EbsRequestId property is set.
        /// </summary>
        internal bool IsSetEbsRequestId() => this.EbsRequestId != null;

        /// <summary>
        /// Gets and sets the property EbsResult. 
        /// <para>
        ///  The result of an EBS CloudWatch event, such as <c>failed</c> or <c>succeeded</c>.
        /// 
        /// </para>
        /// </summary>
        public string EbsResult { get; set; }

        /// <summary>
        /// Checks to see if the EbsResult property is set.
        /// </summary>
        internal bool IsSetEbsResult() => this.EbsResult != null;

        /// <summary>
        /// Gets and sets the property Ec2State. 
        /// <para>
        ///  The state of the instance, such as <c>STOPPING</c> or <c>TERMINATING</c>. 
        /// </para>
        /// </summary>
        public string Ec2State { get; set; }

        /// <summary>
        /// Checks to see if the Ec2State property is set.
        /// </summary>
        internal bool IsSetEc2State() => this.Ec2State != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the observation ended, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property HealthEventArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Health Event-based observation.
        /// </para>
        /// </summary>
        public string HealthEventArn { get; set; }

        /// <summary>
        /// Checks to see if the HealthEventArn property is set.
        /// </summary>
        internal bool IsSetHealthEventArn() => this.HealthEventArn != null;

        /// <summary>
        /// Gets and sets the property HealthEventDescription. 
        /// <para>
        ///  The description of the Health event provided by the service, such as Amazon EC2.
        /// 
        /// </para>
        /// </summary>
        public string HealthEventDescription { get; set; }

        /// <summary>
        /// Checks to see if the HealthEventDescription property is set.
        /// </summary>
        internal bool IsSetHealthEventDescription() => this.HealthEventDescription != null;

        /// <summary>
        /// Gets and sets the property HealthEventTypeCategory. 
        /// <para>
        ///  The category of the Health event, such as <c>issue</c>. 
        /// </para>
        /// </summary>
        public string HealthEventTypeCategory { get; set; }

        /// <summary>
        /// Checks to see if the HealthEventTypeCategory property is set.
        /// </summary>
        internal bool IsSetHealthEventTypeCategory() => this.HealthEventTypeCategory != null;

        /// <summary>
        /// Gets and sets the property HealthEventTypeCode. 
        /// <para>
        ///  The type of the Health event, for example, <c>AWS_EC2_POWER_CONNECTIVITY_ISSUE</c>.
        /// 
        /// </para>
        /// </summary>
        public string HealthEventTypeCode { get; set; }

        /// <summary>
        /// Checks to see if the HealthEventTypeCode property is set.
        /// </summary>
        internal bool IsSetHealthEventTypeCode() => this.HealthEventTypeCode != null;

        /// <summary>
        /// Gets and sets the property HealthService. 
        /// <para>
        ///  The service to which the Health Event belongs, such as EC2. 
        /// </para>
        /// </summary>
        public string HealthService { get; set; }

        /// <summary>
        /// Checks to see if the HealthService property is set.
        /// </summary>
        internal bool IsSetHealthService() => this.HealthService != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the observation type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 38, Max = 38)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LineTime. 
        /// <para>
        /// The timestamp in the CloudWatch Logs that specifies when the matched line occurred.
        /// </para>
        /// </summary>
        public DateTime? LineTime { get; set; }

        /// <summary>
        /// Checks to see if the LineTime property is set.
        /// </summary>
        internal bool IsSetLineTime() => this.LineTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogFilter. 
        /// <para>
        /// The log filter of the observation.
        /// </para>
        /// </summary>
        public LogFilter LogFilter { get; set; }

        /// <summary>
        /// Checks to see if the LogFilter property is set.
        /// </summary>
        internal bool IsSetLogFilter() => this.LogFilter != null;

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group name.
        /// </para>
        /// </summary>
        public string LogGroup { get; set; }

        /// <summary>
        /// Checks to see if the LogGroup property is set.
        /// </summary>
        internal bool IsSetLogGroup() => this.LogGroup != null;

        /// <summary>
        /// Gets and sets the property LogText. 
        /// <para>
        /// The log text of the observation.
        /// </para>
        /// </summary>
        public string LogText { get; set; }

        /// <summary>
        /// Checks to see if the LogText property is set.
        /// </summary>
        internal bool IsSetLogText() => this.LogText != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the observation metric.
        /// </para>
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// The namespace of the observation metric.
        /// </para>
        /// </summary>
        public string MetricNamespace { get; set; }

        /// <summary>
        /// Checks to see if the MetricNamespace property is set.
        /// </summary>
        internal bool IsSetMetricNamespace() => this.MetricNamespace != null;

        /// <summary>
        /// Gets and sets the property RdsEventCategories. 
        /// <para>
        ///  The category of an RDS event. 
        /// </para>
        /// </summary>
        public string RdsEventCategories { get; set; }

        /// <summary>
        /// Checks to see if the RdsEventCategories property is set.
        /// </summary>
        internal bool IsSetRdsEventCategories() => this.RdsEventCategories != null;

        /// <summary>
        /// Gets and sets the property RdsEventMessage. 
        /// <para>
        ///  The message of an RDS event. 
        /// </para>
        /// </summary>
        public string RdsEventMessage { get; set; }

        /// <summary>
        /// Checks to see if the RdsEventMessage property is set.
        /// </summary>
        internal bool IsSetRdsEventMessage() => this.RdsEventMessage != null;

        /// <summary>
        /// Gets and sets the property S3EventName. 
        /// <para>
        ///  The name of the S3 CloudWatch Event-based observation. 
        /// </para>
        /// </summary>
        public string S3EventName { get; set; }

        /// <summary>
        /// Checks to see if the S3EventName property is set.
        /// </summary>
        internal bool IsSetS3EventName() => this.S3EventName != null;

        /// <summary>
        /// Gets and sets the property SourceARN. 
        /// <para>
        /// The source resource ARN of the observation.
        /// </para>
        /// </summary>
        public string SourceARN { get; set; }

        /// <summary>
        /// Checks to see if the SourceARN property is set.
        /// </summary>
        internal bool IsSetSourceARN() => this.SourceARN != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the observation.
        /// </para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the observation was first detected, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatesArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the step function-based observation. 
        /// </para>
        /// </summary>
        public string StatesArn { get; set; }

        /// <summary>
        /// Checks to see if the StatesArn property is set.
        /// </summary>
        internal bool IsSetStatesArn() => this.StatesArn != null;

        /// <summary>
        /// Gets and sets the property StatesExecutionArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the step function execution-based observation.
        /// 
        /// </para>
        /// </summary>
        public string StatesExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the StatesExecutionArn property is set.
        /// </summary>
        internal bool IsSetStatesExecutionArn() => this.StatesExecutionArn != null;

        /// <summary>
        /// Gets and sets the property StatesInput. 
        /// <para>
        ///  The input to the step function-based observation. 
        /// </para>
        /// </summary>
        public string StatesInput { get; set; }

        /// <summary>
        /// Checks to see if the StatesInput property is set.
        /// </summary>
        internal bool IsSetStatesInput() => this.StatesInput != null;

        /// <summary>
        /// Gets and sets the property StatesStatus. 
        /// <para>
        ///  The status of the step function-related observation. 
        /// </para>
        /// </summary>
        public string StatesStatus { get; set; }

        /// <summary>
        /// Checks to see if the StatesStatus property is set.
        /// </summary>
        internal bool IsSetStatesStatus() => this.StatesStatus != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the source observation metric.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the source observation metric.
        /// </para>
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;

        /// <summary>
        /// Gets and sets the property XRayErrorPercent. 
        /// <para>
        ///  The X-Ray request error percentage for this node. 
        /// </para>
        /// </summary>
        public int? XRayErrorPercent { get; set; }

        /// <summary>
        /// Checks to see if the XRayErrorPercent property is set.
        /// </summary>
        internal bool IsSetXRayErrorPercent() => this.XRayErrorPercent.HasValue;

        /// <summary>
        /// Gets and sets the property XRayFaultPercent. 
        /// <para>
        ///  The X-Ray request fault percentage for this node. 
        /// </para>
        /// </summary>
        public int? XRayFaultPercent { get; set; }

        /// <summary>
        /// Checks to see if the XRayFaultPercent property is set.
        /// </summary>
        internal bool IsSetXRayFaultPercent() => this.XRayFaultPercent.HasValue;

        /// <summary>
        /// Gets and sets the property XRayNodeName. 
        /// <para>
        ///  The name of the X-Ray node. 
        /// </para>
        /// </summary>
        public string XRayNodeName { get; set; }

        /// <summary>
        /// Checks to see if the XRayNodeName property is set.
        /// </summary>
        internal bool IsSetXRayNodeName() => this.XRayNodeName != null;

        /// <summary>
        /// Gets and sets the property XRayNodeType. 
        /// <para>
        ///  The type of the X-Ray node. 
        /// </para>
        /// </summary>
        public string XRayNodeType { get; set; }

        /// <summary>
        /// Checks to see if the XRayNodeType property is set.
        /// </summary>
        internal bool IsSetXRayNodeType() => this.XRayNodeType != null;

        /// <summary>
        /// Gets and sets the property XRayRequestAverageLatency. 
        /// <para>
        ///  The X-Ray node request average latency for this node. 
        /// </para>
        /// </summary>
        public long? XRayRequestAverageLatency { get; set; }

        /// <summary>
        /// Checks to see if the XRayRequestAverageLatency property is set.
        /// </summary>
        internal bool IsSetXRayRequestAverageLatency() => this.XRayRequestAverageLatency.HasValue;

        /// <summary>
        /// Gets and sets the property XRayRequestCount. 
        /// <para>
        ///  The X-Ray request count for this node. 
        /// </para>
        /// </summary>
        public int? XRayRequestCount { get; set; }

        /// <summary>
        /// Checks to see if the XRayRequestCount property is set.
        /// </summary>
        internal bool IsSetXRayRequestCount() => this.XRayRequestCount.HasValue;

        /// <summary>
        /// Gets and sets the property XRayThrottlePercent. 
        /// <para>
        ///  The X-Ray request throttle percentage for this node. 
        /// </para>
        /// </summary>
        public int? XRayThrottlePercent { get; set; }

        /// <summary>
        /// Checks to see if the XRayThrottlePercent property is set.
        /// </summary>
        internal bool IsSetXRayThrottlePercent() => this.XRayThrottlePercent.HasValue;
    }
}
