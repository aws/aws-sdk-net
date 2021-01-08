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

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// Contains data about the state of a job execution.
    /// </summary>
    public partial class JobExecutionState
    {
        private JobExecutionStatus _status;
        private Dictionary<string, string> _statusDetails = new Dictionary<string, string>();
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job execution. Can be one of: "QUEUED", "IN_PROGRESS", "FAILED",
        /// "SUCCESS", "CANCELED", "REJECTED", or "REMOVED".
        /// </para>
        /// </summary>
        public JobExecutionStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A collection of name/value pairs that describe the status of the job execution.
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
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version of the job execution. Job execution versions are incremented each time
        /// they are updated by a device.
        /// </para>
        /// </summary>
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}