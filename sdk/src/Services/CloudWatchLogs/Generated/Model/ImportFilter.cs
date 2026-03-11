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
    /// The filter criteria used for import tasks
    /// </summary>
    public partial class ImportFilter
    {
        private long? _endEventTime;
        private long? _startEventTime;

        /// <summary>
        /// Gets and sets the property EndEventTime. 
        /// <para>
        /// The end of the time range for events to import, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? EndEventTime
        {
            get { return this._endEventTime; }
            set { this._endEventTime = value; }
        }

        // Check to see if EndEventTime property is set
        internal bool IsSetEndEventTime()
        {
            return this._endEventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartEventTime. 
        /// <para>
        /// The start of the time range for events to import, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? StartEventTime
        {
            get { return this._startEventTime; }
            set { this._startEventTime = value; }
        }

        // Check to see if StartEventTime property is set
        internal bool IsSetStartEventTime()
        {
            return this._startEventTime.HasValue; 
        }

    }
}