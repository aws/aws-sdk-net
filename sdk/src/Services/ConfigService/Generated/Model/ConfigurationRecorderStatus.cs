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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The current status of the configuration recorder.
    /// 
    ///  <note> 
    /// <para>
    /// For a detailed status of recording events over time, add your Config events to CloudWatch
    /// metrics and use CloudWatch metrics.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ConfigurationRecorderStatus
    {
        private string _lastErrorCode;
        private string _lastErrorMessage;
        private DateTime? _lastStartTime;
        private RecorderStatus _lastStatus;
        private DateTime? _lastStatusChangeTime;
        private DateTime? _lastStopTime;
        private string _name;
        private bool? _recording;

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The latest error code from when the recorder last failed.
        /// </para>
        /// </summary>
        public string LastErrorCode
        {
            get { return this._lastErrorCode; }
            set { this._lastErrorCode = value; }
        }

        // Check to see if LastErrorCode property is set
        internal bool IsSetLastErrorCode()
        {
            return this._lastErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The latest error message from when the recorder last failed.
        /// </para>
        /// </summary>
        public string LastErrorMessage
        {
            get { return this._lastErrorMessage; }
            set { this._lastErrorMessage = value; }
        }

        // Check to see if LastErrorMessage property is set
        internal bool IsSetLastErrorMessage()
        {
            return this._lastErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastStartTime. 
        /// <para>
        /// The time the recorder was last started.
        /// </para>
        /// </summary>
        public DateTime LastStartTime
        {
            get { return this._lastStartTime.GetValueOrDefault(); }
            set { this._lastStartTime = value; }
        }

        // Check to see if LastStartTime property is set
        internal bool IsSetLastStartTime()
        {
            return this._lastStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The status of the latest recording event processed by the recorder.
        /// </para>
        /// </summary>
        public RecorderStatus LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusChangeTime. 
        /// <para>
        /// The time of the latest change in status of an recording event processed by the recorder.
        /// </para>
        /// </summary>
        public DateTime LastStatusChangeTime
        {
            get { return this._lastStatusChangeTime.GetValueOrDefault(); }
            set { this._lastStatusChangeTime = value; }
        }

        // Check to see if LastStatusChangeTime property is set
        internal bool IsSetLastStatusChangeTime()
        {
            return this._lastStatusChangeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStopTime. 
        /// <para>
        /// The time the recorder was last stopped.
        /// </para>
        /// </summary>
        public DateTime LastStopTime
        {
            get { return this._lastStopTime.GetValueOrDefault(); }
            set { this._lastStopTime = value; }
        }

        // Check to see if LastStopTime property is set
        internal bool IsSetLastStopTime()
        {
            return this._lastStopTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration recorder.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Recording. 
        /// <para>
        /// Specifies whether or not the recorder is currently recording.
        /// </para>
        /// </summary>
        public bool Recording
        {
            get { return this._recording.GetValueOrDefault(); }
            set { this._recording = value; }
        }

        // Check to see if Recording property is set
        internal bool IsSetRecording()
        {
            return this._recording.HasValue; 
        }

    }
}