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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about the start of an activity during an execution.
    /// </summary>
    public partial class ActivityStartedEventDetails
    {
        private string _workerName;

        /// <summary>
        /// Gets and sets the property WorkerName. 
        /// <para>
        /// The name of the worker that the task is assigned to. These names are provided by the
        /// workers when calling <a>GetActivityTask</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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