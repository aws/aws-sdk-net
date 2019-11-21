/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a Sync configuration for a resolver.
    /// 
    ///  
    /// <para>
    /// Contains information on which Conflict Detection as well as Resolution strategy should
    /// be performed when the resolver is invoked.
    /// </para>
    /// </summary>
    public partial class SyncConfig
    {
        private ConflictDetectionType _conflictDetection;
        private ConflictHandlerType _conflictHandler;
        private LambdaConflictHandlerConfig _lambdaConflictHandlerConfig;

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
        ///  <b>NONE</b>: Do not detect conflicts when executing this resolver.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConflictDetectionType ConflictDetection
        {
            get { return this._conflictDetection; }
            set { this._conflictDetection = value; }
        }

        // Check to see if ConflictDetection property is set
        internal bool IsSetConflictDetection()
        {
            return this._conflictDetection != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictHandler. 
        /// <para>
        /// The Conflict Resolution strategy to perform in the event of a conflict.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>OPTIMISTIC_CONCURRENCY</b>: Resolve conflicts by rejecting mutations when versions
        /// do not match the latest version at the server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AUTOMERGE</b>: Resolve conflicts with the Automerge conflict resolution strategy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>LAMBDA</b>: Resolve conflicts with a Lambda function supplied in the LambdaConflictHandlerConfig.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConflictHandlerType ConflictHandler
        {
            get { return this._conflictHandler; }
            set { this._conflictHandler = value; }
        }

        // Check to see if ConflictHandler property is set
        internal bool IsSetConflictHandler()
        {
            return this._conflictHandler != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaConflictHandlerConfig. 
        /// <para>
        /// The <code>LambdaConflictHandlerConfig</code> when configuring LAMBDA as the Conflict
        /// Handler.
        /// </para>
        /// </summary>
        public LambdaConflictHandlerConfig LambdaConflictHandlerConfig
        {
            get { return this._lambdaConflictHandlerConfig; }
            set { this._lambdaConflictHandlerConfig = value; }
        }

        // Check to see if LambdaConflictHandlerConfig property is set
        internal bool IsSetLambdaConflictHandlerConfig()
        {
            return this._lambdaConflictHandlerConfig != null;
        }

    }
}