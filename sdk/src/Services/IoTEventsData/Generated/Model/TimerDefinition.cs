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

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// The new setting of a timer.
    /// </summary>
    public partial class TimerDefinition
    {
        private string _name;
        private int? _seconds;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the timer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Seconds. 
        /// <para>
        /// The new setting of the timer (the number of seconds before the timer elapses).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Seconds
        {
            get { return this._seconds.GetValueOrDefault(); }
            set { this._seconds = value; }
        }

        // Check to see if Seconds property is set
        internal bool IsSetSeconds()
        {
            return this._seconds.HasValue; 
        }

    }
}