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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing the details of a container that's part of a job attempt.
    /// </summary>
    public partial class AttemptContainerDetail
    {
        private string _containerInstanceArn;
        private int? _exitCode;
        private string _logStreamName;
        private List<NetworkInterface> _networkInterfaces = new List<NetworkInterface>();
        private string _reason;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon ECS container instance that hosts the
        /// job attempt.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn
        {
            get { return this._containerInstanceArn; }
            set { this._containerInstanceArn = value; }
        }

        // Check to see if ContainerInstanceArn property is set
        internal bool IsSetContainerInstanceArn()
        {
            return this._containerInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code for the job attempt. A non-zero exit code is considered a failure.
        /// </para>
        /// </summary>
        public int ExitCode
        {
            get { return this._exitCode.GetValueOrDefault(); }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the CloudWatch Logs log stream associated with the container. The log
        /// group for AWS Batch jobs is <code>/aws/batch/job</code>. Each container attempt receives
        /// a log stream name when they reach the <code>RUNNING</code> status.
        /// </para>
        /// </summary>
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces associated with the job attempt.
        /// </para>
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (255 max characters) human-readable string to provide additional details about
        /// a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon ECS task that's associated with the job
        /// attempt. Each container attempt receives a task ARN when they reach the <code>STARTING</code>
        /// status.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

    }
}