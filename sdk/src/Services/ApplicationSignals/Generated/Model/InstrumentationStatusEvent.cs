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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A status event for an instrumentation configuration returned by <c>GetInstrumentationConfigurationStatus</c>.
    /// Events include the timestamp and, for errors, an error cause.
    /// </summary>
    public partial class InstrumentationStatusEvent
    {
        private InstrumentationErrorCause _errorCause;
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property ErrorCause. 
        /// <para>
        /// The error cause when the status is <c>ERROR</c>.
        /// </para>
        /// </summary>
        public InstrumentationErrorCause ErrorCause
        {
            get { return this._errorCause; }
            set { this._errorCause = value; }
        }

        // Check to see if ErrorCause property is set
        internal bool IsSetErrorCause()
        {
            return this._errorCause != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time when the status was reported, rounded to the nearest minute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}