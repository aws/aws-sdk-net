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
    /// The timeout configuration for service jobs.
    /// </summary>
    public partial class ServiceJobTimeout
    {
        private int? _attemptDurationSeconds;

        /// <summary>
        /// Gets and sets the property AttemptDurationSeconds. 
        /// <para>
        /// The maximum duration in seconds that a service job attempt can run. After this time
        /// is reached, Batch terminates the service job attempt.
        /// </para>
        /// </summary>
        public int? AttemptDurationSeconds
        {
            get { return this._attemptDurationSeconds; }
            set { this._attemptDurationSeconds = value; }
        }

        // Check to see if AttemptDurationSeconds property is set
        internal bool IsSetAttemptDurationSeconds()
        {
            return this._attemptDurationSeconds.HasValue; 
        }

    }
}