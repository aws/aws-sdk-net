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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The retry policy to use for a job run.
    /// </summary>
    public partial class RetryPolicy
    {
        private int? _maxAttempts;
        private int? _maxFailedAttemptsPerHour;

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// Maximum number of attempts for the job run. This parameter is only applicable for
        /// <c>BATCH</c> mode.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxAttempts
        {
            get { return this._maxAttempts; }
            set { this._maxAttempts = value; }
        }

        // Check to see if MaxAttempts property is set
        internal bool IsSetMaxAttempts()
        {
            return this._maxAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFailedAttemptsPerHour. 
        /// <para>
        /// Maximum number of failed attempts per hour. This [arameter is only applicable for
        /// <c>STREAMING</c> mode.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxFailedAttemptsPerHour
        {
            get { return this._maxFailedAttemptsPerHour; }
            set { this._maxFailedAttemptsPerHour = value; }
        }

        // Check to see if MaxFailedAttemptsPerHour property is set
        internal bool IsSetMaxFailedAttemptsPerHour()
        {
            return this._maxFailedAttemptsPerHour.HasValue; 
        }

    }
}