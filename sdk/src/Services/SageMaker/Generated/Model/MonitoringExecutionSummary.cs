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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary of information about the last monitoring job to run.
    /// </summary>
    public partial class MonitoringExecutionSummary
    {
        private DateTime? _creationTime;
        private string _endpointName;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private ExecutionStatus _monitoringExecutionStatus;
        private string _monitoringJobDefinitionName;
        private string _monitoringScheduleName;
        private MonitoringType _monitoringType;
        private string _processingJobArn;
        private DateTime? _scheduledTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the monitoring job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
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
        /// The name of the endpoint used to run the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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
        /// Contains the reason a monitoring job failed, if it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// A timestamp that indicates the last time the monitoring job was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringExecutionStatus. 
        /// <para>
        /// The status of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus MonitoringExecutionStatus
        {
            get { return this._monitoringExecutionStatus; }
            set { this._monitoringExecutionStatus = value; }
        }

        // Check to see if MonitoringExecutionStatus property is set
        internal bool IsSetMonitoringExecutionStatus()
        {
            return this._monitoringExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// The name of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MonitoringJobDefinitionName
        {
            get { return this._monitoringJobDefinitionName; }
            set { this._monitoringJobDefinitionName = value; }
        }

        // Check to see if MonitoringJobDefinitionName property is set
        internal bool IsSetMonitoringJobDefinitionName()
        {
            return this._monitoringJobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property MonitoringType. 
        /// <para>
        /// The type of the monitoring job.
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

        /// <summary>
        /// Gets and sets the property ProcessingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ProcessingJobArn
        {
            get { return this._processingJobArn; }
            set { this._processingJobArn = value; }
        }

        // Check to see if ProcessingJobArn property is set
        internal bool IsSetProcessingJobArn()
        {
            return this._processingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The time the monitoring job was scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ScheduledTime
        {
            get { return this._scheduledTime; }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
        }

    }
}