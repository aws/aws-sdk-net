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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Timestamp segment
    /// </summary>
    public partial class TimestampSegment
    {
        private long? _endTimeMillis;
        private long? _startTimeMillis;

        /// <summary>
        /// Gets and sets the property EndTimeMillis. 
        /// <para>
        /// End timestamp in milliseconds
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=300000)]
        public long? EndTimeMillis
        {
            get { return this._endTimeMillis; }
            set { this._endTimeMillis = value; }
        }

        // Check to see if EndTimeMillis property is set
        internal bool IsSetEndTimeMillis()
        {
            return this._endTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeMillis. 
        /// <para>
        /// Start timestamp in milliseconds
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? StartTimeMillis
        {
            get { return this._startTimeMillis; }
            set { this._startTimeMillis = value; }
        }

        // Check to see if StartTimeMillis property is set
        internal bool IsSetStartTimeMillis()
        {
            return this._startTimeMillis.HasValue; 
        }

    }
}