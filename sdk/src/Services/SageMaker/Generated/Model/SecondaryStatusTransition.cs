/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies a secondary status the job has transitioned into. It includes a start timestamp
    /// and later an end timestamp. The end timestamp is added either after the job transitions
    /// to a different secondary status or after the job has ended.
    /// </summary>
    public partial class SecondaryStatusTransition
    {
        private DateTime? _endTime;
        private DateTime? _startTime;
        private SecondaryStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that shows when the secondary status has ended and the job has transitioned
        /// into another secondary status. The <code>EndTime</code> timestamp is also set after
        /// the training job has ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that shows when the training job has entered this secondary status.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides granular information about the system state. For more information, see <code>SecondaryStatus</code>
        /// under the <a>DescribeTrainingJob</a> response elements.
        /// </para>
        /// </summary>
        public SecondaryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Shows a brief description and other information about the secondary status. For example,
        /// the <code>LaunchingMLInstances</code> secondary status could show a status message
        /// of "Insufficent capacity error while launching instances".
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}