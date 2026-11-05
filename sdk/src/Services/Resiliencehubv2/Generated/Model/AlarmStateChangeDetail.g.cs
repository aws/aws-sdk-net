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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Details about a CloudWatch alarm state change observed during a test run.
    /// </summary>
    public partial class AlarmStateChangeDetail
    {
        /// <summary>
        /// Gets and sets the property PreviousState. 
        /// <para>
        /// The state the alarm transitioned from. Absent on the initial event, which records
        /// the alarm's state when collection began.
        /// </para>
        /// </summary>
        public AlarmState PreviousState { get; set; }

        /// <summary>
        /// Checks to see if the PreviousState property is set.
        /// </summary>
        internal bool IsSetPreviousState() => this.PreviousState != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A human-readable explanation of the state change, as reported by CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1023)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state the alarm transitioned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AlarmState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
