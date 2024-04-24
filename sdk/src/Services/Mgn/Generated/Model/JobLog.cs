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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Job log.
    /// </summary>
    public partial class JobLog
    {
        private JobLogEvent _event;
        private JobLogEventData _eventData;
        private string _logDateTime;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// Job log event.
        /// </para>
        /// </summary>
        public JobLogEvent Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property EventData. 
        /// <para>
        /// Job event data
        /// </para>
        /// </summary>
        public JobLogEventData EventData
        {
            get { return this._eventData; }
            set { this._eventData = value; }
        }

        // Check to see if EventData property is set
        internal bool IsSetEventData()
        {
            return this._eventData != null;
        }

        /// <summary>
        /// Gets and sets the property LogDateTime. 
        /// <para>
        /// Job log event date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string LogDateTime
        {
            get { return this._logDateTime; }
            set { this._logDateTime = value; }
        }

        // Check to see if LogDateTime property is set
        internal bool IsSetLogDateTime()
        {
            return this._logDateTime != null;
        }

    }
}