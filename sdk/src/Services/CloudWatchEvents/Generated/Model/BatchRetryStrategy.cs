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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// The retry strategy to use for failed jobs, if the target is an AWS Batch job. If you
    /// specify a retry strategy here, it overrides the retry strategy defined in the job
    /// definition.
    /// </summary>
    public partial class BatchRetryStrategy
    {
        private int? _attempts;

        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// The number of times to attempt to retry, if the job fails. Valid values are 1–10.
        /// </para>
        /// </summary>
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