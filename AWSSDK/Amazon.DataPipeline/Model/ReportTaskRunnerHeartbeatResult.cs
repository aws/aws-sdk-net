/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the ReportTaskRunnerHeartbeat action.</para>
    /// </summary>
    public class ReportTaskRunnerHeartbeatResult
    {
        
        private bool? terminate;

        /// <summary>
        /// Indicates whether the calling task runner should terminate. If <c>True</c>, the task runner that called <a>ReportTaskRunnerHeartbeat</a>
        /// should terminate.
        ///  
        /// </summary>
        public bool Terminate
        {
            get { return this.terminate ?? default(bool); }
            set { this.terminate = value; }
        }

        /// <summary>
        /// Sets the Terminate property
        /// </summary>
        /// <param name="terminate">The value to set for the Terminate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReportTaskRunnerHeartbeatResult WithTerminate(bool terminate)
        {
            this.terminate = terminate;
            return this;
        }
            

        // Check to see if Terminate property is set
        internal bool IsSetTerminate()
        {
            return this.terminate.HasValue;
        }
    }
}
