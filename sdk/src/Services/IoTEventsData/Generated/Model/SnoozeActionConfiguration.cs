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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Contains the configuration information of a snooze action.
    /// </summary>
    public partial class SnoozeActionConfiguration
    {
        private string _note;
        private int? _snoozeDuration;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// The note that you can leave when you snooze the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property SnoozeDuration. 
        /// <para>
        /// The snooze time in seconds. The alarm automatically changes to the <c>NORMAL</c> state
        /// after this duration.
        /// </para>
        /// </summary>
        public int? SnoozeDuration
        {
            get { return this._snoozeDuration; }
            set { this._snoozeDuration = value; }
        }

        // Check to see if SnoozeDuration property is set
        internal bool IsSetSnoozeDuration()
        {
            return this._snoozeDuration.HasValue; 
        }

    }
}