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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the PollForTask operation. Task runners call <c>PollForTask</c>
    /// to receive a task to perform from AWS Data Pipeline. The task runner specifies which
    /// tasks it can perform by setting a value for the <c>workerGroup</c> parameter. The
    /// task returned can come from any of the pipelines that match the <c>workerGroup</c>
    /// value passed in by the task runner and that was launched using the IAM user credentials
    /// specified by the task runner. <para> If tasks are ready in the work queue, <c>PollForTask</c>
    /// returns a response immediately. If no tasks are available in the queue, <c>PollForTask</c>
    /// uses long-polling and holds on to a poll connection for up to a 90 seconds, during
    /// which time the first newly scheduled task is handed to the task runner. To accomodate
    /// this, set the socket timeout in your task runner to 90 seconds. The task runner should
    /// not call <c>PollForTask</c> again on the same <c>workerGroup</c> until it receives
    /// a response, and this can take up to 90 seconds. </para>
    /// </summary>
    public partial class PollForTaskRequest : AmazonDataPipelineRequest
    {
        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The public DNS name of the calling task runner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property InstanceIdentity. 
        /// <para>
        /// Identity information for the EC2 instance that is hosting the task runner. You can
        /// get this value from the instance using <c>http://169.254.169.254/latest/meta-data/instance-id</c>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html">Instance
        /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide.</i> Passing in this
        /// value proves that your task runner is running on an EC2 instance, and ensures the
        /// proper AWS Data Pipeline service charges are applied to your pipeline.
        /// </para>
        /// </summary>
        public InstanceIdentity InstanceIdentity { get; set; }

        /// <summary>
        /// Checks to see if the InstanceIdentity property is set.
        /// </summary>
        internal bool IsSetInstanceIdentity() => this.InstanceIdentity != null;

        /// <summary>
        /// Gets and sets the property WorkerGroup. 
        /// <para>
        /// The type of task the task runner is configured to accept and process. The worker group
        /// is set as a field on objects in the pipeline when they are created. You can only specify
        /// a single value for <c>workerGroup</c> in the call to <c>PollForTask</c>. There are
        /// no wildcard values permitted in <c>workerGroup</c>; the string must be an exact, case-sensitive,
        /// match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string WorkerGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkerGroup property is set.
        /// </summary>
        internal bool IsSetWorkerGroup() => this.WorkerGroup != null;
    }
}
