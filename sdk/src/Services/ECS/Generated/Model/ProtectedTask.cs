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
    /// An object representing the protection status details for a task. You can set the protection
    /// status with the <a>UpdateTaskProtection</a> API and get the status of tasks with the
    /// <a>GetTaskProtection</a> API.
    /// </summary>
    public partial class ProtectedTask
    {
        private DateTime? _expirationDate;
        private bool? _protectionEnabled;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The epoch time when protection for the task will expire.
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProtectionEnabled. 
        /// <para>
        /// The protection status of the task. If scale-in protection is on for a task, the value
        /// is <code>true</code>. Otherwise, it is <code>false</code>.
        /// </para>
        /// </summary>
        public bool ProtectionEnabled
        {
            get { return this._protectionEnabled.GetValueOrDefault(); }
            set { this._protectionEnabled = value; }
        }

        // Check to see if ProtectionEnabled property is set
        internal bool IsSetProtectionEnabled()
        {
            return this._protectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The task ARN.
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