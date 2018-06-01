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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJobExecution operation.
    /// Cancels the execution of a job for a given thing.
    /// </summary>
    public partial class CancelJobExecutionRequest : AmazonIoTRequest
    {
        private long? _expectedVersion;
        private bool? _force;
        private string _jobId;
        private Dictionary<string, string> _statusDetails = new Dictionary<string, string>();
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// (Optional) The expected current version of the job execution. Each time you update
        /// the job execution, its version is incremented. If the version of the job execution
        /// stored in Jobs does not match, the update is rejected with a VersionMismatch error,
        /// and an ErrorResponse that contains the current job execution status data is returned.
        /// (This makes it unnecessary to perform a separate DescribeJobExecution request in order
        /// to obtain the job execution status data.)
        /// </para>
        /// </summary>
        public long ExpectedVersion
        {
            get { return this._expectedVersion.GetValueOrDefault(); }
            set { this._expectedVersion = value; }
        }

        // Check to see if ExpectedVersion property is set
        internal bool IsSetExpectedVersion()
        {
            return this._expectedVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// (Optional) If <code>true</code> the job execution will be canceled if it has status
        /// IN_PROGRESS or QUEUED, otherwise the job execution will be canceled only if it has
        /// status QUEUED. If you attempt to cancel a job execution that is IN_PROGRESS, and you
        /// do not set <code>force</code> to <code>true</code>, then an <code>InvalidStateTransitionException</code>
        /// will be thrown. The default is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// Canceling a job execution which is "IN_PROGRESS", will cause the device to be unable
        /// to update the job execution status. Use caution and ensure that the device is able
        /// to recover to a valid state.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job to be canceled.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A collection of name/value pairs that describe the status of the job execution. If
        /// not specified, the statusDetails are unchanged. You can specify at most 10 name/value
        /// pairs.
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
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing whose execution of the job will be canceled.
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