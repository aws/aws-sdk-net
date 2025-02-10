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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
        private string _cloudWatchEventDetailType;
        private string _cloudWatchEventId;
        private CloudWatchEventSource _cloudWatchEventSource;
        private string _codeDeployApplication;
        private string _codeDeployDeploymentGroup;
        private string _codeDeployDeploymentId;
        private string _codeDeployInstanceGroupId;
        private string _codeDeployState;
        private string _ebsCause;
        private string _ebsEvent;
        private string _ebsRequestId;
        private string _ebsResult;
        private string _ec2State;
        private DateTime? _endTime;
        private string _healthEventArn;
        private string _healthEventDescription;
        private string _healthEventTypeCategory;
        private string _healthEventTypeCode;
        private string _healthService;
        private string _id;
        private DateTime? _lineTime;
        private LogFilter _logFilter;
        private string _logGroup;
        private string _logText;
        private string _metricName;
        private string _metricNamespace;
        private string _rdsEventCategories;
        private string _rdsEventMessage;
        private string _s3EventName;
        private string _sourceARN;
        private string _sourceType;
        private DateTime? _startTime;
        private string _statesArn;
        private string _statesExecutionArn;
        private string _statesInput;
        private string _statesStatus;
        private string _unit;
        private double? _value;
        private int? _xRayErrorPercent;
        private int? _xRayFaultPercent;
        private string _xRayNodeName;
        private string _xRayNodeType;
        private long? _xRayRequestAverageLatency;
        private int? _xRayRequestCount;
        private int? _xRayThrottlePercent;

        /// <summary>
        /// Gets and sets the property CloudWatchEventDetailType. 
        /// <para>
        ///  The detail type of the CloudWatch Event-based observation, for example, <c>EC2 Instance
        /// State-change Notification</c>. 
        /// </para>
        /// </summary>
        public string CloudWatchEventDetailType
        {
            get { return this._cloudWatchEventDetailType; }
            set { this._cloudWatchEventDetailType = value; }
        }

        // Check to see if CloudWatchEventDetailType property is set
        internal bool IsSetCloudWatchEventDetailType()
        {
            return this._cloudWatchEventDetailType != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchEventId. 
        /// <para>
        ///  The ID of the CloudWatch Event-based observation related to the detected problem.
        /// 
        /// </para>
        /// </summary>
        public string CloudWatchEventId
        {
            get { return this._cloudWatchEventId; }
            set { this._cloudWatchEventId = value; }
        }

        // Check to see if CloudWatchEventId property is set
        internal bool IsSetCloudWatchEventId()
        {
            return this._cloudWatchEventId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchEventSource. 
        /// <para>
        ///  The source of the CloudWatch Event. 
        /// </para>
        /// </summary>
        public CloudWatchEventSource CloudWatchEventSource
        {
            get { return this._cloudWatchEventSource; }
            set { this._cloudWatchEventSource = value; }
        }

        // Check to see if CloudWatchEventSource property is set
        internal bool IsSetCloudWatchEventSource()
        {
            return this._cloudWatchEventSource != null;
        }

        /// <summary>
        /// Gets and sets the property CodeDeployApplication. 
        /// <para>
        ///  The CodeDeploy application to which the deployment belongs. 
        /// </para>
        /// </summary>
        public string CodeDeployApplication
        {
            get { return this._codeDeployApplication; }
            set { this._codeDeployApplication = value; }
        }

        // Check to see if CodeDeployApplication property is set
        internal bool IsSetCodeDeployApplication()
        {
            return this._codeDeployApplication != null;
        }

        /// <summary>
        /// Gets and sets the property CodeDeployDeploymentGroup. 
        /// <para>
        ///  The deployment group to which the CodeDeploy deployment belongs. 
        /// </para>
        /// </summary>
        public string CodeDeployDeploymentGroup
        {
            get { return this._codeDeployDeploymentGroup; }
            set { this._codeDeployDeploymentGroup = value; }
        }

        // Check to see if CodeDeployDeploymentGroup property is set
        internal bool IsSetCodeDeployDeploymentGroup()
        {
            return this._codeDeployDeploymentGroup != null;
        }

        /// <summary>
        /// Gets and sets the property CodeDeployDeploymentId. 
        /// <para>
        ///  The deployment ID of the CodeDeploy-based observation related to the detected problem.
        /// 
        /// </para>
        /// </summary>
        public string CodeDeployDeploymentId
        {
            get { return this._codeDeployDeploymentId; }
            set { this._codeDeployDeploymentId = value; }
        }

        // Check to see if CodeDeployDeploymentId property is set
        internal bool IsSetCodeDeployDeploymentId()
        {
            return this._codeDeployDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property CodeDeployInstanceGroupId. 
        /// <para>
        ///  The instance group to which the CodeDeploy instance belongs. 
        /// </para>
        /// </summary>
        public string CodeDeployInstanceGroupId
        {
            get { return this._codeDeployInstanceGroupId; }
            set { this._codeDeployInstanceGroupId = value; }
        }

        // Check to see if CodeDeployInstanceGroupId property is set
        internal bool IsSetCodeDeployInstanceGroupId()
        {
            return this._codeDeployInstanceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property CodeDeployState. 
        /// <para>
        ///  The status of the CodeDeploy deployment, for example <c>SUCCESS</c> or <c> FAILURE</c>.
        /// 
        /// </para>
        /// </summary>
        public string CodeDeployState
        {
            get { return this._codeDeployState; }
            set { this._codeDeployState = value; }
        }

        // Check to see if CodeDeployState property is set
        internal bool IsSetCodeDeployState()
        {
            return this._codeDeployState != null;
        }

        /// <summary>
        /// Gets and sets the property EbsCause. 
        /// <para>
        ///  The cause of an EBS CloudWatch event. 
        /// </para>
        /// </summary>
        public string EbsCause
        {
            get { return this._ebsCause; }
            set { this._ebsCause = value; }
        }

        // Check to see if EbsCause property is set
        internal bool IsSetEbsCause()
        {
            return this._ebsCause != null;
        }

        /// <summary>
        /// Gets and sets the property EbsEvent. 
        /// <para>
        ///  The type of EBS CloudWatch event, such as <c>createVolume</c>, <c>deleteVolume</c>
        /// or <c>attachVolume</c>. 
        /// </para>
        /// </summary>
        public string EbsEvent
        {
            get { return this._ebsEvent; }
            set { this._ebsEvent = value; }
        }

        // Check to see if EbsEvent property is set
        internal bool IsSetEbsEvent()
        {
            return this._ebsEvent != null;
        }

        /// <summary>
        /// Gets and sets the property EbsRequestId. 
        /// <para>
        ///  The request ID of an EBS CloudWatch event. 
        /// </para>
        /// </summary>
        public string EbsRequestId
        {
            get { return this._ebsRequestId; }
            set { this._ebsRequestId = value; }
        }

        // Check to see if EbsRequestId property is set
        internal bool IsSetEbsRequestId()
        {
            return this._ebsRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property EbsResult. 
        /// <para>
        ///  The result of an EBS CloudWatch event, such as <c>failed</c> or <c>succeeded</c>.
        /// 
        /// </para>
        /// </summary>
        public string EbsResult
        {
            get { return this._ebsResult; }
            set { this._ebsResult = value; }
        }

        // Check to see if EbsResult property is set
        internal bool IsSetEbsResult()
        {
            return this._ebsResult != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2State. 
        /// <para>
        ///  The state of the instance, such as <c>STOPPING</c> or <c>TERMINATING</c>. 
        /// </para>
        /// </summary>
        public string Ec2State
        {
            get { return this._ec2State; }
            set { this._ec2State = value; }
        }

        // Check to see if Ec2State property is set
        internal bool IsSetEc2State()
        {
            return this._ec2State != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the observation ended, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthEventArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Health Event-based observation.
        /// </para>
        /// </summary>
        public string HealthEventArn
        {
            get { return this._healthEventArn; }
            set { this._healthEventArn = value; }
        }

        // Check to see if HealthEventArn property is set
        internal bool IsSetHealthEventArn()
        {
            return this._healthEventArn != null;
        }

        /// <summary>
        /// Gets and sets the property HealthEventDescription. 
        /// <para>
        ///  The description of the Health event provided by the service, such as Amazon EC2.
        /// 
        /// </para>
        /// </summary>
        public string HealthEventDescription
        {
            get { return this._healthEventDescription; }
            set { this._healthEventDescription = value; }
        }

        // Check to see if HealthEventDescription property is set
        internal bool IsSetHealthEventDescription()
        {
            return this._healthEventDescription != null;
        }

        /// <summary>
        /// Gets and sets the property HealthEventTypeCategory. 
        /// <para>
        ///  The category of the Health event, such as <c>issue</c>. 
        /// </para>
        /// </summary>
        public string HealthEventTypeCategory
        {
            get { return this._healthEventTypeCategory; }
            set { this._healthEventTypeCategory = value; }
        }

        // Check to see if HealthEventTypeCategory property is set
        internal bool IsSetHealthEventTypeCategory()
        {
            return this._healthEventTypeCategory != null;
        }

        /// <summary>
        /// Gets and sets the property HealthEventTypeCode. 
        /// <para>
        ///  The type of the Health event, for example, <c>AWS_EC2_POWER_CONNECTIVITY_ISSUE</c>.
        /// 
        /// </para>
        /// </summary>
        public string HealthEventTypeCode
        {
            get { return this._healthEventTypeCode; }
            set { this._healthEventTypeCode = value; }
        }

        // Check to see if HealthEventTypeCode property is set
        internal bool IsSetHealthEventTypeCode()
        {
            return this._healthEventTypeCode != null;
        }

        /// <summary>
        /// Gets and sets the property HealthService. 
        /// <para>
        ///  The service to which the Health Event belongs, such as EC2. 
        /// </para>
        /// </summary>
        public string HealthService
        {
            get { return this._healthService; }
            set { this._healthService = value; }
        }

        // Check to see if HealthService property is set
        internal bool IsSetHealthService()
        {
            return this._healthService != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the observation type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=38, Max=38)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LineTime. 
        /// <para>
        /// The timestamp in the CloudWatch Logs that specifies when the matched line occurred.
        /// </para>
        /// </summary>
        public DateTime? LineTime
        {
            get { return this._lineTime; }
            set { this._lineTime = value; }
        }

        // Check to see if LineTime property is set
        internal bool IsSetLineTime()
        {
            return this._lineTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogFilter. 
        /// <para>
        /// The log filter of the observation.
        /// </para>
        /// </summary>
        public LogFilter LogFilter
        {
            get { return this._logFilter; }
            set { this._logFilter = value; }
        }

        // Check to see if LogFilter property is set
        internal bool IsSetLogFilter()
        {
            return this._logFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group name.
        /// </para>
        /// </summary>
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LogText. 
        /// <para>
        /// The log text of the observation.
        /// </para>
        /// </summary>
        public string LogText
        {
            get { return this._logText; }
            set { this._logText = value; }
        }

        // Check to see if LogText property is set
        internal bool IsSetLogText()
        {
            return this._logText != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the observation metric.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// The namespace of the observation metric.
        /// </para>
        /// </summary>
        public string MetricNamespace
        {
            get { return this._metricNamespace; }
            set { this._metricNamespace = value; }
        }

        // Check to see if MetricNamespace property is set
        internal bool IsSetMetricNamespace()
        {
            return this._metricNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property RdsEventCategories. 
        /// <para>
        ///  The category of an RDS event. 
        /// </para>
        /// </summary>
        public string RdsEventCategories
        {
            get { return this._rdsEventCategories; }
            set { this._rdsEventCategories = value; }
        }

        // Check to see if RdsEventCategories property is set
        internal bool IsSetRdsEventCategories()
        {
            return this._rdsEventCategories != null;
        }

        /// <summary>
        /// Gets and sets the property RdsEventMessage. 
        /// <para>
        ///  The message of an RDS event. 
        /// </para>
        /// </summary>
        public string RdsEventMessage
        {
            get { return this._rdsEventMessage; }
            set { this._rdsEventMessage = value; }
        }

        // Check to see if RdsEventMessage property is set
        internal bool IsSetRdsEventMessage()
        {
            return this._rdsEventMessage != null;
        }

        /// <summary>
        /// Gets and sets the property S3EventName. 
        /// <para>
        ///  The name of the S3 CloudWatch Event-based observation. 
        /// </para>
        /// </summary>
        public string S3EventName
        {
            get { return this._s3EventName; }
            set { this._s3EventName = value; }
        }

        // Check to see if S3EventName property is set
        internal bool IsSetS3EventName()
        {
            return this._s3EventName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceARN. 
        /// <para>
        /// The source resource ARN of the observation.
        /// </para>
        /// </summary>
        public string SourceARN
        {
            get { return this._sourceARN; }
            set { this._sourceARN = value; }
        }

        // Check to see if SourceARN property is set
        internal bool IsSetSourceARN()
        {
            return this._sourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the observation.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the observation was first detected, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatesArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the step function-based observation. 
        /// </para>
        /// </summary>
        public string StatesArn
        {
            get { return this._statesArn; }
            set { this._statesArn = value; }
        }

        // Check to see if StatesArn property is set
        internal bool IsSetStatesArn()
        {
            return this._statesArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatesExecutionArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the step function execution-based observation.
        /// 
        /// </para>
        /// </summary>
        public string StatesExecutionArn
        {
            get { return this._statesExecutionArn; }
            set { this._statesExecutionArn = value; }
        }

        // Check to see if StatesExecutionArn property is set
        internal bool IsSetStatesExecutionArn()
        {
            return this._statesExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatesInput. 
        /// <para>
        ///  The input to the step function-based observation. 
        /// </para>
        /// </summary>
        public string StatesInput
        {
            get { return this._statesInput; }
            set { this._statesInput = value; }
        }

        // Check to see if StatesInput property is set
        internal bool IsSetStatesInput()
        {
            return this._statesInput != null;
        }

        /// <summary>
        /// Gets and sets the property StatesStatus. 
        /// <para>
        ///  The status of the step function-related observation. 
        /// </para>
        /// </summary>
        public string StatesStatus
        {
            get { return this._statesStatus; }
            set { this._statesStatus = value; }
        }

        // Check to see if StatesStatus property is set
        internal bool IsSetStatesStatus()
        {
            return this._statesStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the source observation metric.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the source observation metric.
        /// </para>
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property XRayErrorPercent. 
        /// <para>
        ///  The X-Ray request error percentage for this node. 
        /// </para>
        /// </summary>
        public int? XRayErrorPercent
        {
            get { return this._xRayErrorPercent; }
            set { this._xRayErrorPercent = value; }
        }

        // Check to see if XRayErrorPercent property is set
        internal bool IsSetXRayErrorPercent()
        {
            return this._xRayErrorPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property XRayFaultPercent. 
        /// <para>
        ///  The X-Ray request fault percentage for this node. 
        /// </para>
        /// </summary>
        public int? XRayFaultPercent
        {
            get { return this._xRayFaultPercent; }
            set { this._xRayFaultPercent = value; }
        }

        // Check to see if XRayFaultPercent property is set
        internal bool IsSetXRayFaultPercent()
        {
            return this._xRayFaultPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property XRayNodeName. 
        /// <para>
        ///  The name of the X-Ray node. 
        /// </para>
        /// </summary>
        public string XRayNodeName
        {
            get { return this._xRayNodeName; }
            set { this._xRayNodeName = value; }
        }

        // Check to see if XRayNodeName property is set
        internal bool IsSetXRayNodeName()
        {
            return this._xRayNodeName != null;
        }

        /// <summary>
        /// Gets and sets the property XRayNodeType. 
        /// <para>
        ///  The type of the X-Ray node. 
        /// </para>
        /// </summary>
        public string XRayNodeType
        {
            get { return this._xRayNodeType; }
            set { this._xRayNodeType = value; }
        }

        // Check to see if XRayNodeType property is set
        internal bool IsSetXRayNodeType()
        {
            return this._xRayNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property XRayRequestAverageLatency. 
        /// <para>
        ///  The X-Ray node request average latency for this node. 
        /// </para>
        /// </summary>
        public long? XRayRequestAverageLatency
        {
            get { return this._xRayRequestAverageLatency; }
            set { this._xRayRequestAverageLatency = value; }
        }

        // Check to see if XRayRequestAverageLatency property is set
        internal bool IsSetXRayRequestAverageLatency()
        {
            return this._xRayRequestAverageLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property XRayRequestCount. 
        /// <para>
        ///  The X-Ray request count for this node. 
        /// </para>
        /// </summary>
        public int? XRayRequestCount
        {
            get { return this._xRayRequestCount; }
            set { this._xRayRequestCount = value; }
        }

        // Check to see if XRayRequestCount property is set
        internal bool IsSetXRayRequestCount()
        {
            return this._xRayRequestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property XRayThrottlePercent. 
        /// <para>
        ///  The X-Ray request throttle percentage for this node. 
        /// </para>
        /// </summary>
        public int? XRayThrottlePercent
        {
            get { return this._xRayThrottlePercent; }
            set { this._xRayThrottlePercent = value; }
        }

        // Check to see if XRayThrottlePercent property is set
        internal bool IsSetXRayThrottlePercent()
        {
            return this._xRayThrottlePercent.HasValue; 
        }

    }
}