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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Indicates whether a query returned partial results.
    /// </summary>
    public partial class PartialResults
    {
        private bool? _partialResultsDetected;

        /// <summary>
        /// Gets and sets the property PartialResultsDetected. 
        /// <para>
        /// True when the query returned partial results (some data could not be read).
        /// </para>
        /// </summary>
        public bool? PartialResultsDetected
        {
            get { return this._partialResultsDetected; }
            set { this._partialResultsDetected = value; }
        }

        // Check to see if PartialResultsDetected property is set
        internal bool IsSetPartialResultsDetected()
        {
            return this._partialResultsDetected.HasValue; 
        }

    }
}