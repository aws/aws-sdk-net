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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeMonitor operation.
    /// </summary>
    public partial class DescribeMonitorResponse : AmazonWebServiceResponse
    {
        private Baseline _baseline;
        private DateTime? _creationTime;
        private long? _estimatedEvaluationTimeRemainingInMinutes;
        private string _lastEvaluationState;
        private DateTime? _lastEvaluationTime;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _monitorArn;
        private string _monitorName;
        private string _resourceArn;
        private string _status;

        /// <summary>
        /// Gets and sets the property Baseline. 
        /// <para>
        /// Metrics you can use as a baseline for comparison purposes. Use these values you interpret
        /// monitoring results for an auto predictor.
        /// </para>
        /// </summary>
        public Baseline Baseline
        {
            get { return this._baseline; }
            set { this._baseline = value; }
        }

        // Check to see if Baseline property is set
        internal bool IsSetBaseline()
        {
            return this._baseline != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when the monitor resource was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EstimatedEvaluationTimeRemainingInMinutes. 
        /// <para>
        /// The estimated number of minutes remaining before the monitor resource finishes its
        /// current evaluation.
        /// </para>
        /// </summary>
        public long? EstimatedEvaluationTimeRemainingInMinutes
        {
            get { return this._estimatedEvaluationTimeRemainingInMinutes; }
            set { this._estimatedEvaluationTimeRemainingInMinutes = value; }
        }

        // Check to see if EstimatedEvaluationTimeRemainingInMinutes property is set
        internal bool IsSetEstimatedEvaluationTimeRemainingInMinutes()
        {
            return this._estimatedEvaluationTimeRemainingInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluationState. 
        /// <para>
        /// The state of the monitor's latest evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string LastEvaluationState
        {
            get { return this._lastEvaluationState; }
            set { this._lastEvaluationState = value; }
        }

        // Check to see if LastEvaluationState property is set
        internal bool IsSetLastEvaluationState()
        {
            return this._lastEvaluationState != null;
        }

        /// <summary>
        /// Gets and sets the property LastEvaluationTime. 
        /// <para>
        /// The timestamp of the latest evaluation completed by the monitor.
        /// </para>
        /// </summary>
        public DateTime? LastEvaluationTime
        {
            get { return this._lastEvaluationTime; }
            set { this._lastEvaluationTime = value; }
        }

        // Check to see if LastEvaluationTime property is set
        internal bool IsSetLastEvaluationTime()
        {
            return this._lastEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The timestamp of the latest modification to the monitor.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An error message, if any, for the monitor.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor resource described.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the auto predictor being monitored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the monitor resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}