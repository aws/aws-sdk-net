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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
    /// Container for the parameters to the ReportTaskRunnerHeartbeat operation.
    /// Task runners call <c>ReportTaskRunnerHeartbeat</c> every 15 minutes to indicate that
    /// they are operational. If the AWS Data Pipeline Task Runner is launched on a resource
    /// managed by AWS Data Pipeline, the web service can use this call to detect when the
    /// task runner application has failed and restart a new instance.
    /// </summary>
    public partial class ReportTaskRunnerHeartbeatRequest : AmazonDataPipelineRequest
    {
        private string _hostname;
        private string _taskrunnerId;
        private string _workerGroup;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The public DNS name of the task runner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property TaskrunnerId. 
        /// <para>
        /// The ID of the task runner. This value should be unique across your AWS account. In
        /// the case of AWS Data Pipeline Task Runner launched on a resource managed by AWS Data
        /// Pipeline, the web service provides a unique identifier when it launches the application.
        /// If you have written a custom task runner, you should assign a unique identifier for
        /// the task runner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TaskrunnerId
        {
            get { return this._taskrunnerId; }
            set { this._taskrunnerId = value; }
        }

        // Check to see if TaskrunnerId property is set
        internal bool IsSetTaskrunnerId()
        {
            return this._taskrunnerId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerGroup. 
        /// <para>
        /// The type of task the task runner is configured to accept and process. The worker group
        /// is set as a field on objects in the pipeline when they are created. You can only specify
        /// a single value for <c>workerGroup</c>. There are no wildcard values permitted in <c>workerGroup</c>;
        /// the string must be an exact, case-sensitive, match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string WorkerGroup
        {
            get { return this._workerGroup; }
            set { this._workerGroup = value; }
        }

        // Check to see if WorkerGroup property is set
        internal bool IsSetWorkerGroup()
        {
            return this._workerGroup != null;
        }

    }
}