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
    /// Container for the parameters to the UpdateJob operation. Updates supported fields
    /// of the specified job. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateJob</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateJobRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Allows you to create criteria to abort a job.
        /// </para>
        /// </summary>
        public AbortConfig AbortConfig { get; set; }

        /// <summary>
        /// Checks to see if the AbortConfig property is set.
        /// </summary>
        internal bool IsSetAbortConfig() => this.AbortConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property JobExecutionsRetryConfig. 
        /// <para>
        /// Allows you to create the criteria to retry a job.
        /// </para>
        /// </summary>
        public JobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionsRetryConfig property is set.
        /// </summary>
        internal bool IsSetJobExecutionsRetryConfig() => this.JobExecutionsRetryConfig != null;

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig. 
        /// <para>
        /// Allows you to create a staged rollout of the job.
        /// </para>
        /// </summary>
        public JobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionsRolloutConfig property is set.
        /// </summary>
        internal bool IsSetJobExecutionsRolloutConfig() => this.JobExecutionsRolloutConfig != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job to be updated.
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
        /// Gets and sets the property PresignedUrlConfig. 
        /// <para>
        /// Configuration information for pre-signed S3 URLs.
        /// </para>
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrlConfig property is set.
        /// </summary>
        internal bool IsSetPresignedUrlConfig() => this.PresignedUrlConfig != null;

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. The
        /// timer is started when the job execution status is set to <c>IN_PROGRESS</c>. If the
        /// job execution status is not set to another terminal state before the time expires,
        /// it will be automatically set to <c>TIMED_OUT</c>. 
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;
    }
}
