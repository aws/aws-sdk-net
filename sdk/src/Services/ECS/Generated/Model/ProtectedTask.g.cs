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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object representing the protection status details for a task. You can set the protection
    /// status with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateTaskProtection.html">UpdateTaskProtection</a>
    /// API and get the status of tasks with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_GetTaskProtection.html">GetTaskProtection</a>
    /// API.
    /// </summary>
    public partial class ProtectedTask
    {
        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The epoch time when protection for the task will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ProtectionEnabled. 
        /// <para>
        /// The protection status of the task. If scale-in protection is on for a task, the value
        /// is <c>true</c>. Otherwise, it is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetProtectionEnabled() => this.ProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The task ARN.
        /// </para>
        /// </summary>
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;
    }
}
