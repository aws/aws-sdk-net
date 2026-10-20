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
    /// This is the response object from the GetTaskProtection operation.
    /// </summary>
    public partial class GetTaskProtectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Any failures associated with the call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Failure> Failures { get; set; } = AWSConfigs.InitializeCollections ? new List<Failure>() : null;

        /// <summary>
        /// Checks to see if the Failures property is set.
        /// </summary>
        internal bool IsSetFailures() => this.Failures != null && (this.Failures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProtectedTasks. 
        /// <para>
        /// A list of tasks with the following information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>taskArn</c>: The task ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>protectionEnabled</c>: The protection status of the task. If scale-in protection
        /// is turned on for a task, the value is <c>true</c>. Otherwise, it is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expirationDate</c>: The epoch time when protection for the task will expire.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProtectedTask> ProtectedTasks { get; set; } = AWSConfigs.InitializeCollections ? new List<ProtectedTask>() : null;

        /// <summary>
        /// Checks to see if the ProtectedTasks property is set.
        /// </summary>
        internal bool IsSetProtectedTasks() => this.ProtectedTasks != null && (this.ProtectedTasks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
