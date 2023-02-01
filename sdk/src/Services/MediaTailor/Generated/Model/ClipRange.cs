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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Clip range configuration for the VOD source associated with the program.
    /// </summary>
    public partial class ClipRange
    {
        private long? _endOffsetMillis;

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The end offset of the clip range, in milliseconds, starting from the beginning of
        /// the VOD source associated with the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long EndOffsetMillis
        {
            get { return this._endOffsetMillis.GetValueOrDefault(); }
            set { this._endOffsetMillis = value; }
        }

        // Check to see if EndOffsetMillis property is set
        internal bool IsSetEndOffsetMillis()
        {
            return this._endOffsetMillis.HasValue; 
        }

    }
}