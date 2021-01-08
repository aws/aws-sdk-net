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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about worlds that failed.
    /// </summary>
    public partial class FailureSummary
    {
        private List<WorldFailure> _failures = new List<WorldFailure>();
        private int? _totalFailureCount;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// The worlds that failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<WorldFailure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && this._failures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalFailureCount. 
        /// <para>
        /// The total number of failures.
        /// </para>
        /// </summary>
        public int TotalFailureCount
        {
            get { return this._totalFailureCount.GetValueOrDefault(); }
            set { this._totalFailureCount = value; }
        }

        // Check to see if TotalFailureCount property is set
        internal bool IsSetTotalFailureCount()
        {
            return this._totalFailureCount.HasValue; 
        }

    }
}