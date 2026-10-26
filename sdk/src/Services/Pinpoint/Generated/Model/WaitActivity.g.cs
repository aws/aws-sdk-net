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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a wait activity in a journey. This type of activity waits
    /// for a certain amount of time or until a specific date and time before moving participants
    /// to the next activity in a journey.
    /// </summary>
    public partial class WaitActivity
    {
        /// <summary>
        /// Gets and sets the property NextActivity. 
        /// <para>
        /// The unique identifier for the next activity to perform, after performing the wait
        /// activity.
        /// </para>
        /// </summary>
        public string NextActivity { get; set; }

        /// <summary>
        /// Checks to see if the NextActivity property is set.
        /// </summary>
        internal bool IsSetNextActivity() => this.NextActivity != null;

        /// <summary>
        /// Gets and sets the property WaitTime. 
        /// <para>
        /// The amount of time to wait or the date and time when the activity moves participants
        /// to the next activity in the journey.
        /// </para>
        /// </summary>
        public WaitTime WaitTime { get; set; }

        /// <summary>
        /// Checks to see if the WaitTime property is set.
        /// </summary>
        internal bool IsSetWaitTime() => this.WaitTime != null;
    }
}
