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
    /// The configuration of the retry policy that the job runs on.
    /// </summary>
    public partial class RetryPolicyConfiguration
    {
        private int? _maxAttempts;

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The maximum number of attempts on the job's driver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxAttempts
        {
            get { return this._maxAttempts.GetValueOrDefault(); }
            set { this._maxAttempts = value; }
        }

        // Check to see if MaxAttempts property is set
        internal bool IsSetMaxAttempts()
        {
            return this._maxAttempts.HasValue; 
        }

    }
}