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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the UpdateTaskProtection operation.
    /// </summary>
    public partial class UpdateTaskProtectionResponse : AmazonWebServiceResponse
    {
        private List<Failure> _failures = new List<Failure>();
        private List<ProtectedTask> _protectedTasks = new List<ProtectedTask>();

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Any failures associated with the call.
        /// </para>
        /// </summary>
        public List<Failure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && this._failures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProtectedTasks. 
        /// <para>
        /// A list of tasks with the following information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>taskArn</code>: The task ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>protectionEnabled</code>: The protection status of the task. If scale-in protection
        /// is turned on for a task, the value is <code>true</code>. Otherwise, it is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>expirationDate</code>: The epoch time when protection for the task will expire.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<ProtectedTask> ProtectedTasks
        {
            get { return this._protectedTasks; }
            set { this._protectedTasks = value; }
        }

        // Check to see if ProtectedTasks property is set
        internal bool IsSetProtectedTasks()
        {
            return this._protectedTasks != null && this._protectedTasks.Count > 0; 
        }

    }
}