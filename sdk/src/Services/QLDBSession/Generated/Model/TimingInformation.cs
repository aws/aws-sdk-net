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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Contains server-side performance information for a command. Amazon QLDB captures timing
    /// information between the times when it receives the request and when it sends the corresponding
    /// response.
    /// </summary>
    public partial class TimingInformation
    {
        private long? _processingTimeMilliseconds;

        /// <summary>
        /// Gets and sets the property ProcessingTimeMilliseconds. 
        /// <para>
        /// The amount of time that was taken for the command to finish processing, measured in
        /// milliseconds.
        /// </para>
        /// </summary>
        public long ProcessingTimeMilliseconds
        {
            get { return this._processingTimeMilliseconds.GetValueOrDefault(); }
            set { this._processingTimeMilliseconds = value; }
        }

        // Check to see if ProcessingTimeMilliseconds property is set
        internal bool IsSetProcessingTimeMilliseconds()
        {
            return this._processingTimeMilliseconds.HasValue; 
        }

    }
}