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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the GetActivityTask operation.
    /// Used by workers to retrieve a task (with the specified activity ARN) which has been
    /// scheduled for execution by a running state machine. This initiates a long poll, where
    /// the service holds the HTTP connection open and responds as soon as a task becomes
    /// available (i.e. an execution of a task of this type is needed.) The maximum time the
    /// service holds on to the request before responding is 60 seconds. If no task is available
    /// within 60 seconds, the poll will return a <code>taskToken</code> with a null string.
    /// 
    ///  <important> 
    /// <para>
    /// Workers should set their client side socket timeout to at least 65 seconds (5 seconds
    /// higher than the maximum time the service may hold the poll request).
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetActivityTaskRequest : AmazonStepFunctionsRequest
    {
        private string _activityArn;
        private string _workerName;

        /// <summary>
        /// Gets and sets the property ActivityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the activity to retrieve tasks from (assigned when
        /// you create the task using <a>CreateActivity</a>.)
        /// </para>
        /// </summary>
        public string ActivityArn
        {
            get { return this._activityArn; }
            set { this._activityArn = value; }
        }

        // Check to see if ActivityArn property is set
        internal bool IsSetActivityArn()
        {
            return this._activityArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerName. 
        /// <para>
        /// You can provide an arbitrary name in order to identify the worker that the task is
        /// assigned to. This name will be used when it is logged in the execution history.
        /// </para>
        /// </summary>
        public string WorkerName
        {
            get { return this._workerName; }
            set { this._workerName = value; }
        }

        // Check to see if WorkerName property is set
        internal bool IsSetWorkerName()
        {
            return this._workerName != null;
        }

    }
}