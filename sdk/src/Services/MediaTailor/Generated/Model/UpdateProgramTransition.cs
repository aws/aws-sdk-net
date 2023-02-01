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
    /// Program transition configuration.
    /// </summary>
    public partial class UpdateProgramTransition
    {
        private long? _durationMillis;
        private long? _scheduledStartTimeMillis;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the live program in seconds.
        /// </para>
        /// </summary>
        public long DurationMillis
        {
            get { return this._durationMillis.GetValueOrDefault(); }
            set { this._durationMillis = value; }
        }

        // Check to see if DurationMillis property is set
        internal bool IsSetDurationMillis()
        {
            return this._durationMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledStartTimeMillis. 
        /// <para>
        /// The date and time that the program is scheduled to start, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long ScheduledStartTimeMillis
        {
            get { return this._scheduledStartTimeMillis.GetValueOrDefault(); }
            set { this._scheduledStartTimeMillis = value; }
        }

        // Check to see if ScheduledStartTimeMillis property is set
        internal bool IsSetScheduledStartTimeMillis()
        {
            return this._scheduledStartTimeMillis.HasValue; 
        }

    }
}