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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object contains the metadata for one <c>LiveTailSessionUpdate</c> structure.
    /// It indicates whether that update includes only a sample of 500 log events out of a
    /// larger number of ingested log events, or if it contains all of the matching log events
    /// ingested during that second of time.
    /// </summary>
    public partial class LiveTailSessionMetadata
    {
        private bool? _sampled;

        /// <summary>
        /// Gets and sets the property Sampled. 
        /// <para>
        /// If this is <c>true</c>, then more than 500 log events matched the request for this
        /// update, and the <c>sessionResults</c> includes a sample of 500 of those events.
        /// </para>
        ///  
        /// <para>
        /// If this is <c>false</c>, then 500 or fewer log events matched the request for this
        /// update, so no sampling was necessary. In this case, the <c>sessionResults</c> array
        /// includes all log events that matched your request during this time.
        /// </para>
        /// </summary>
        public bool? Sampled
        {
            get { return this._sampled; }
            set { this._sampled = value; }
        }

        // Check to see if Sampled property is set
        internal bool IsSetSampled()
        {
            return this._sampled.HasValue; 
        }

    }
}