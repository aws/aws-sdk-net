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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If the test failed, the reason why it failed.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

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
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestWindowEnd. 
        /// <para>
        /// The time at which the test ended.
        /// </para>
        /// </summary>
        public DateTime? TestWindowEnd { get; set; }

        /// <summary>
        /// Checks to see if the TestWindowEnd property is set.
        /// </summary>
        internal bool IsSetTestWindowEnd() => this.TestWindowEnd.HasValue;

        /// <summary>
        /// Gets and sets the property TestWindowStart. 
        /// <para>
        /// The time at which the test began.
        /// </para>
        /// </summary>
        public DateTime? TestWindowStart { get; set; }

        /// <summary>
        /// Checks to see if the TestWindowStart property is set.
        /// </summary>
        internal bool IsSetTestWindowStart() => this.TestWindowStart.HasValue;
    }
}
