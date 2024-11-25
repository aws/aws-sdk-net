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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The information about the number of requested, pending, and running tasks for a service
    /// revision.
    /// </summary>
    public partial class ServiceRevisionSummary
    {
        private string _arn;
        private int? _pendingTaskCount;
        private int? _requestedTaskCount;
        private int? _runningTaskCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the service revision.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property PendingTaskCount. 
        /// <para>
        /// The number of pending tasks for the service revision.
        /// </para>
        /// </summary>
        public int? PendingTaskCount
        {
            get { return this._pendingTaskCount; }
            set { this._pendingTaskCount = value; }
        }

        // Check to see if PendingTaskCount property is set
        internal bool IsSetPendingTaskCount()
        {
            return this._pendingTaskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestedTaskCount. 
        /// <para>
        /// The number of requested tasks for the service revision.
        /// </para>
        /// </summary>
        public int? RequestedTaskCount
        {
            get { return this._requestedTaskCount; }
            set { this._requestedTaskCount = value; }
        }

        // Check to see if RequestedTaskCount property is set
        internal bool IsSetRequestedTaskCount()
        {
            return this._requestedTaskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningTaskCount. 
        /// <para>
        /// The number of running tasks for the service revision.
        /// </para>
        /// </summary>
        public int? RunningTaskCount
        {
            get { return this._runningTaskCount; }
            set { this._runningTaskCount = value; }
        }

        // Check to see if RunningTaskCount property is set
        internal bool IsSetRunningTaskCount()
        {
            return this._runningTaskCount.HasValue; 
        }

    }
}