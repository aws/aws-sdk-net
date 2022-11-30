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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A monitoring schedule for a model displayed in the Amazon SageMaker Model Dashboard.
    /// </summary>
    public partial class ModelDashboardMonitoringSchedule
    {
        private DateTime? _creationTime;
        private string _endpointName;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private MonitoringExecutionSummary _lastMonitoringExecutionSummary;
        private List<MonitoringAlertSummary> _monitoringAlertSummaries = new List<MonitoringAlertSummary>();
        private string _monitoringScheduleArn;
        private MonitoringScheduleConfig _monitoringScheduleConfig;
        private string _monitoringScheduleName;
        private ScheduleStatus _monitoringScheduleStatus;
        private MonitoringType _monitoringType;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the monitoring schedule was created.
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
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The endpoint which is monitored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a monitoring job failed, provides the reason.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that indicates when the monitoring schedule was last updated.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastMonitoringExecutionSummary.
        /// </summary>
        public MonitoringExecutionSummary LastMonitoringExecutionSummary
        {
            get { return this._lastMonitoringExecutionSummary; }
            set { this._lastMonitoringExecutionSummary = value; }
        }

        // Check to see if LastMonitoringExecutionSummary property is set
        internal bool IsSetLastMonitoringExecutionSummary()
        {
            return this._lastMonitoringExecutionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringAlertSummaries. 
        /// <para>
        /// A JSON array where each element is a summary for a monitoring alert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<MonitoringAlertSummary> MonitoringAlertSummaries
        {
            get { return this._monitoringAlertSummaries; }
            set { this._monitoringAlertSummaries = value; }
        }

        // Check to see if MonitoringAlertSummaries property is set
        internal bool IsSetMonitoringAlertSummaries()
        {
            return this._monitoringAlertSummaries != null && this._monitoringAlertSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MonitoringScheduleArn
        {
            get { return this._monitoringScheduleArn; }
            set { this._monitoringScheduleArn = value; }
        }

        // Check to see if MonitoringScheduleArn property is set
        internal bool IsSetMonitoringScheduleArn()
        {
            return this._monitoringScheduleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleConfig.
        /// </summary>
        public MonitoringScheduleConfig MonitoringScheduleConfig
        {
            get { return this._monitoringScheduleConfig; }
            set { this._monitoringScheduleConfig = value; }
        }

        // Check to see if MonitoringScheduleConfig property is set
        internal bool IsSetMonitoringScheduleConfig()
        {
            return this._monitoringScheduleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of a monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MonitoringScheduleName
        {
            get { return this._monitoringScheduleName; }
            set { this._monitoringScheduleName = value; }
        }

        // Check to see if MonitoringScheduleName property is set
        internal bool IsSetMonitoringScheduleName()
        {
            return this._monitoringScheduleName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleStatus. 
        /// <para>
        /// The status of the monitoring schedule.
        /// </para>
        /// </summary>
        public ScheduleStatus MonitoringScheduleStatus
        {
            get { return this._monitoringScheduleStatus; }
            set { this._monitoringScheduleStatus = value; }
        }

        // Check to see if MonitoringScheduleStatus property is set
        internal bool IsSetMonitoringScheduleStatus()
        {
            return this._monitoringScheduleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringType. 
        /// <para>
        /// The monitor type of a model monitor.
        /// </para>
        /// </summary>
        public MonitoringType MonitoringType
        {
            get { return this._monitoringType; }
            set { this._monitoringType = value; }
        }

        // Check to see if MonitoringType property is set
        internal bool IsSetMonitoringType()
        {
            return this._monitoringType != null;
        }

    }
}