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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The retry strategy that's associated with a job. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/job_retries.html">
    /// Automated job retries</a> in the <i>Batch User Guide</i>.
    /// </summary>
    public partial class BatchRetryStrategy
    {
        private int? _attempts;

        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// The number of times to move a job to the <code>RUNNABLE</code> status. If the value
        /// of <code>attempts</code> is greater than one, the job is retried on failure the same
        /// number of attempts as the value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int Attempts
        {
            get { return this._attempts.GetValueOrDefault(); }
            set { this._attempts = value; }
        }

        // Check to see if Attempts property is set
        internal bool IsSetAttempts()
        {
            return this._attempts.HasValue; 
        }

    }
}