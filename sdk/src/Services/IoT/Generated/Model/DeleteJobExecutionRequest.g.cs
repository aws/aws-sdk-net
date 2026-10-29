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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeleteJobExecution operation. Deletes a job execution.
    /// <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteJobExecution</a>
    /// action. </para>
    /// </summary>
    public partial class DeleteJobExecutionRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// The ID of the job execution to be deleted. The <c>executionNumber</c> refers to the
        /// execution of a particular job on a particular device.
        /// </para>
        ///  
        /// <para>
        /// Note that once a job execution is deleted, the <c>executionNumber</c> may be reused
        /// by IoT, so be sure you get and use the correct value here.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ExecutionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionNumber property is set.
        /// </summary>
        internal bool IsSetExecutionNumber() => this.ExecutionNumber.HasValue;

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
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job whose execution on a particular device will be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

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
        ///  <c>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>namespaceId</c> feature is only supported by IoT Greengrass at this time. For
        /// more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/setting-up.html">Setting
        /// up IoT Greengrass core devices.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceId property is set.
        /// </summary>
        internal bool IsSetNamespaceId() => this.NamespaceId != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing whose job execution will be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;
    }
}
