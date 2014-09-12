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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output from the <a>ReportTaskRunnerHeartbeat</a> action.
    /// </summary>
    public partial class ReportTaskRunnerHeartbeatResult : AmazonWebServiceResponse
    {
        private bool? _terminate;

        /// <summary>
        /// Gets and sets the property Terminate. 
        /// <para>
        /// Indicates whether the calling task runner should terminate. If <code>True</code>,
        /// the task runner that called <a>ReportTaskRunnerHeartbeat</a> should terminate. 
        /// </para>
        /// </summary>
        public bool Terminate
        {
            get { return this._terminate.GetValueOrDefault(); }
            set { this._terminate = value; }
        }

        // Check to see if Terminate property is set
        internal bool IsSetTerminate()
        {
            return this._terminate.HasValue; 
        }

    }
}