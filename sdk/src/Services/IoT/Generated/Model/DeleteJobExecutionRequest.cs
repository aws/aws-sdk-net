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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteJobExecution operation.
    /// Deletes a job execution.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteJobExecution</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteJobExecutionRequest : AmazonIoTRequest
    {
        private long? _executionNumber;
        private bool? _force;
        private string _jobId;
        private string _namespaceId;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// The ID of the job execution to be deleted. The <code>executionNumber</code> refers
        /// to the execution of a particular job on a particular device.
        /// </para>
        ///  
        /// <para>
        /// Note that once a job execution is deleted, the <code>executionNumber</code> may be
        /// reused by IoT, so be sure you get and use the correct value here.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ExecutionNumber
        {
            get { return this._executionNumber.GetValueOrDefault(); }
            set { this._executionNumber = value; }
        }

        // Check to see if ExecutionNumber property is set
        internal bool IsSetExecutionNumber()
        {
            return this._executionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// (Optional) When true, you can delete a job execution which is "IN_PROGRESS". Otherwise,
        /// you can only delete a job execution which is in a terminal state ("SUCCEEDED", "FAILED",
        /// "REJECTED", "REMOVED" or "CANCELED") or an exception will occur. The default is false.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleting a job execution which is "IN_PROGRESS", will cause the device to be unable
        /// to access job information or update the job execution status. Use caution and ensure
        /// that the device is able to recover to a valid state.
        /// </para>
        ///  </note>
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
        /// The ID of the job whose execution on a particular device will be deleted.
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
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The namespace used to indicate that a job is a customer-managed job.
        /// </para>
        ///  
        /// <para>
        /// When you specify a value for this parameter, Amazon Web Services IoT Core sends jobs
        /// notifications to MQTT topics that contain the value in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>namespaceId</code> feature is in public preview.
        /// </para>
        ///  </note>
        /// </summary>
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing whose job execution will be deleted.
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