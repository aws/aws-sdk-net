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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information required to reset the timer. The timer is reset to the previously evaluated
    /// result of the duration. The duration expression isn't reevaluated when you reset the
    /// timer.
    /// </summary>
    public partial class ResetTimerAction
    {
        private string _timerName;

        /// <summary>
        /// Gets and sets the property TimerName. 
        /// <para>
        /// The name of the timer to reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TimerName
        {
            get { return this._timerName; }
            set { this._timerName = value; }
        }

        // Check to see if TimerName property is set
        internal bool IsSetTimerName()
        {
            return this._timerName != null;
        }

    }
}