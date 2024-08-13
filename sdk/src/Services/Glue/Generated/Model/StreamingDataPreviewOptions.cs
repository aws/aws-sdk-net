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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies options related to data preview for viewing a sample of your data.
    /// </summary>
    public partial class StreamingDataPreviewOptions
    {
        private long? _pollingTime;
        private long? _recordPollingLimit;

        /// <summary>
        /// Gets and sets the property PollingTime. 
        /// <para>
        /// The polling time in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10)]
        public long? PollingTime
        {
            get { return this._pollingTime; }
            set { this._pollingTime = value; }
        }

        // Check to see if PollingTime property is set
        internal bool IsSetPollingTime()
        {
            return this._pollingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordPollingLimit. 
        /// <para>
        /// The limit to the number of records polled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? RecordPollingLimit
        {
            get { return this._recordPollingLimit; }
            set { this._recordPollingLimit = value; }
        }

        // Check to see if RecordPollingLimit property is set
        internal bool IsSetRecordPollingLimit()
        {
            return this._recordPollingLimit.HasValue; 
        }

    }
}