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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the StartNextPendingJobExecution operation.
    /// Gets and starts the next pending (status IN_PROGRESS or QUEUED) job execution for
    /// a thing.
    /// </summary>
    public partial class StartNextPendingJobExecutionRequest : AmazonIoTJobsDataPlaneRequest
    {
        private Dictionary<string, string> _statusDetails = new Dictionary<string, string>();
        private long? _stepTimeoutInMinutes;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A collection of name/value pairs that describe the status of the job execution. If
        /// not specified, the statusDetails are unchanged.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null && this._statusDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StepTimeoutInMinutes. 
        /// <para>
        /// Specifies the amount of time this device has to finish execution of this job. If the
        /// job execution status is not set to a terminal state before this timer expires, or
        /// before the timer is reset (by calling <code>UpdateJobExecution</code>, setting the
        /// status to <code>IN_PROGRESS</code> and specifying a new timeout value in field <code>stepTimeoutInMinutes</code>)
        /// the job execution status will be automatically set to <code>TIMED_OUT</code>. Note
        /// that setting this timeout has no effect on that job execution timeout which may have
        /// been specified when the job was created (<code>CreateJob</code> using field <code>timeoutConfig</code>).
        /// </para>
        /// </summary>
        public long StepTimeoutInMinutes
        {
            get { return this._stepTimeoutInMinutes.GetValueOrDefault(); }
            set { this._stepTimeoutInMinutes = value; }
        }

        // Check to see if StepTimeoutInMinutes property is set
        internal bool IsSetStepTimeoutInMinutes()
        {
            return this._stepTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing associated with the device.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}