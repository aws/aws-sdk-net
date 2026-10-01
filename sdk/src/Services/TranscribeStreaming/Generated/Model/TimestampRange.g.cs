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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains the timestamp range (start time through end time) of a matched category.
    /// </summary>
    public partial class TimestampRange
    {
        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the start of
        /// the category match.
        /// </para>
        /// </summary>
        public long? BeginOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffsetMillis property is set.
        /// </summary>
        internal bool IsSetBeginOffsetMillis() => this.BeginOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the end of the
        /// category match.
        /// </para>
        /// </summary>
        public long? EndOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the EndOffsetMillis property is set.
        /// </summary>
        internal bool IsSetEndOffsetMillis() => this.EndOffsetMillis.HasValue;
    }
}
