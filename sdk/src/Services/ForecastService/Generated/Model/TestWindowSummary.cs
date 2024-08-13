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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The status, start time, and end time of a backtest, as well as a failure reason if
    /// applicable.
    /// </summary>
    public partial class TestWindowSummary
    {
        private string _message;
        private string _status;
        private DateTime? _testWindowEnd;
        private DateTime? _testWindowStart;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If the test failed, the reason why it failed.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the test. Possible status values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TestWindowEnd. 
        /// <para>
        /// The time at which the test ended.
        /// </para>
        /// </summary>
        public DateTime? TestWindowEnd
        {
            get { return this._testWindowEnd; }
            set { this._testWindowEnd = value; }
        }

        // Check to see if TestWindowEnd property is set
        internal bool IsSetTestWindowEnd()
        {
            return this._testWindowEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestWindowStart. 
        /// <para>
        /// The time at which the test began.
        /// </para>
        /// </summary>
        public DateTime? TestWindowStart
        {
            get { return this._testWindowStart; }
            set { this._testWindowStart = value; }
        }

        // Check to see if TestWindowStart property is set
        internal bool IsSetTestWindowStart()
        {
            return this._testWindowStart.HasValue; 
        }

    }
}