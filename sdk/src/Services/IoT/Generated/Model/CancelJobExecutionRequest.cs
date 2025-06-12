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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJobExecution operation.
    /// Cancels the execution of a job for a given thing.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelJobExecution</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CancelJobExecutionRequest : AmazonIoTRequest
    {
        private long? _expectedVersion;
        private bool? _force;
        private string _jobId;
        private Dictionary<string, string> _statusDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        public long? ExpectedVersion
        {
            get { return this._expectedVersion; }
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
        /// (Optional) If <c>true</c> the job execution will be canceled if it has status IN_PROGRESS
        /// or QUEUED, otherwise the job execution will be canceled only if it has status QUEUED.
        /// If you attempt to cancel a job execution that is IN_PROGRESS, and you do not set <c>force</c>
        /// to <c>true</c>, then an <c>InvalidStateTransitionException</c> will be thrown. The
        /// default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Canceling a job execution which is "IN_PROGRESS", will cause the device to be unable
        /// to update the job execution status. Use caution and ensure that the device is able
        /// to recover to a valid state.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
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
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing whose execution of the job will be canceled.
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