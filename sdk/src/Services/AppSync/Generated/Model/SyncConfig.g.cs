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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a Sync configuration for a resolver.
    /// 
    ///  
    /// <para>
    /// Specifies which Conflict Detection strategy and Resolution strategy to use when the
    /// resolver is invoked.
    /// </para>
    /// </summary>
    public partial class SyncConfig
    {
        /// <summary>
        /// Gets and sets the property ConflictDetection. 
        /// <para>
        /// The Conflict Detection strategy to use.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>VERSION</b>: Detect conflicts based on object versions for this resolver.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NONE</b>: Do not detect conflicts when invoking this resolver.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConflictDetectionType ConflictDetection { get; set; }

        /// <summary>
        /// Checks to see if the ConflictDetection property is set.
        /// </summary>
        internal bool IsSetConflictDetection() => this.ConflictDetection != null;

        /// <summary>
        /// Gets and sets the property ConflictHandler. 
        /// <para>
        /// The Conflict Resolution strategy to perform in the event of a conflict.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>OPTIMISTIC_CONCURRENCY</b>: Resolve conflicts by rejecting mutations when versions
        /// don't match the latest version at the server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AUTOMERGE</b>: Resolve conflicts with the Automerge conflict resolution strategy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>LAMBDA</b>: Resolve conflicts with an Lambda function supplied in the <c>LambdaConflictHandlerConfig</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConflictHandlerType ConflictHandler { get; set; }

        /// <summary>
        /// Checks to see if the ConflictHandler property is set.
        /// </summary>
        internal bool IsSetConflictHandler() => this.ConflictHandler != null;

        /// <summary>
        /// Gets and sets the property LambdaConflictHandlerConfig. 
        /// <para>
        /// The <c>LambdaConflictHandlerConfig</c> when configuring <c>LAMBDA</c> as the Conflict
        /// Handler.
        /// </para>
        /// </summary>
        public LambdaConflictHandlerConfig LambdaConflictHandlerConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaConflictHandlerConfig property is set.
        /// </summary>
        internal bool IsSetLambdaConflictHandlerConfig() => this.LambdaConflictHandlerConfig != null;
    }
}
