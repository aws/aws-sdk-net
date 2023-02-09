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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The current status of the retry policy executed on the job.
    /// </summary>
    public partial class RetryPolicyExecution
    {
        private int? _currentAttemptCount;

        /// <summary>
        /// Gets and sets the property CurrentAttemptCount. 
        /// <para>
        /// The current number of attempts made on the driver of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int CurrentAttemptCount
        {
            get { return this._currentAttemptCount.GetValueOrDefault(); }
            set { this._currentAttemptCount = value; }
        }

        // Check to see if CurrentAttemptCount property is set
        internal bool IsSetCurrentAttemptCount()
        {
            return this._currentAttemptCount.HasValue; 
        }

    }
}