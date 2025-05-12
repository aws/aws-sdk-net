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
    /// Summarizes the monitoring schedule.
    /// </summary>
    public partial class MonitoringScheduleSummary
    {
        private DateTime? _creationTime;
        private string _endpointName;
        private DateTime? _lastModifiedTime;
        private string _monitoringJobDefinitionName;
        private string _monitoringScheduleArn;
        private string _monitoringScheduleName;
        private ScheduleStatus _monitoringScheduleStatus;
        private MonitoringType _monitoringType;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the monitoring schedule.
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
        /// The name of the endpoint using the monitoring schedule.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the monitoring schedule was modified.
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
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// The name of the monitoring job definition that the schedule is for.
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
        /// Gets and sets the property MonitoringScheduleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property MonitoringScheduleStatus. 
        /// <para>
        /// The status of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The type of the monitoring job definition that the schedule is for.
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