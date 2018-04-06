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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing a job timeout configuration.
    /// </summary>
    public partial class JobTimeout
    {
        private int? _attemptDurationSeconds;

        /// <summary>
        /// Gets and sets the property AttemptDurationSeconds. 
        /// <para>
        /// The time duration in seconds (measured from the job attempt's <code>startedAt</code>
        /// timestamp) after which AWS Batch terminates your jobs if they have not finished.
        /// </para>
        /// </summary>
        public int AttemptDurationSeconds
        {
            get { return this._attemptDurationSeconds.GetValueOrDefault(); }
            set { this._attemptDurationSeconds = value; }
        }

        // Check to see if AttemptDurationSeconds property is set
        internal bool IsSetAttemptDurationSeconds()
        {
            return this._attemptDurationSeconds.HasValue; 
        }

    }
}