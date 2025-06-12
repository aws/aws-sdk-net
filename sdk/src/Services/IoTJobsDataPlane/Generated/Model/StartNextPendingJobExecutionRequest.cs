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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
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
namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the StartNextPendingJobExecution operation.
    /// Gets and starts the next pending (status IN_PROGRESS or QUEUED) job execution for
    /// a thing.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartNextPendingJobExecution</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class StartNextPendingJobExecutionRequest : AmazonIoTJobsDataPlaneRequest
    {
        private Dictionary<string, string> _statusDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _stepTimeoutInMinutes;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A collection of name/value pairs that describe the status of the job execution. If
        /// not specified, the statusDetails are unchanged.
        /// </para>
        ///  
        /// <para>
        /// The maximum length of the value in the name/value pair is 1,024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null && (this._statusDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StepTimeoutInMinutes. 
        /// <para>
        /// Specifies the amount of time this device has to finish execution of this job. If the
        /// job execution status is not set to a terminal state before this timer expires, or
        /// before the timer is reset (by calling <c>UpdateJobExecution</c>, setting the status
        /// to <c>IN_PROGRESS</c>, and specifying a new timeout value in field <c>stepTimeoutInMinutes</c>)
        /// the job execution status will be automatically set to <c>TIMED_OUT</c>. Note that
        /// setting the step timeout has no effect on the in progress timeout that may have been
        /// specified when the job was created (<c>CreateJob</c> using field <c>timeoutConfig</c>).
        /// </para>
        ///  
        /// <para>
        /// Valid values for this parameter range from 1 to 10080 (1 minute to 7 days).
        /// </para>
        /// </summary>
        public long? StepTimeoutInMinutes
        {
            get { return this._stepTimeoutInMinutes; }
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
        [AWSProperty(Required=true, Min=1, Max=128)]
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