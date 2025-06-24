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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies the infrastructure update policy for the Amazon EC2 compute environment.
    /// For more information about infrastructure updates, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
    /// compute environments</a> in the <i>Batch User Guide</i>.
    /// </summary>
    public partial class UpdatePolicy
    {
        private long? _jobExecutionTimeoutMinutes;
        private bool? _terminateJobsOnUpdate;

        /// <summary>
        /// Gets and sets the property JobExecutionTimeoutMinutes. 
        /// <para>
        /// Specifies the job timeout (in minutes) when the compute environment infrastructure
        /// is updated. The default value is 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=360)]
        public long? JobExecutionTimeoutMinutes
        {
            get { return this._jobExecutionTimeoutMinutes; }
            set { this._jobExecutionTimeoutMinutes = value; }
        }

        // Check to see if JobExecutionTimeoutMinutes property is set
        internal bool IsSetJobExecutionTimeoutMinutes()
        {
            return this._jobExecutionTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminateJobsOnUpdate. 
        /// <para>
        /// Specifies whether jobs are automatically terminated when the compute environment infrastructure
        /// is updated. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? TerminateJobsOnUpdate
        {
            get { return this._terminateJobsOnUpdate; }
            set { this._terminateJobsOnUpdate = value; }
        }

        // Check to see if TerminateJobsOnUpdate property is set
        internal bool IsSetTerminateJobsOnUpdate()
        {
            return this._terminateJobsOnUpdate.HasValue; 
        }

    }
}