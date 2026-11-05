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

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The historical records for a budget action.
    /// </summary>
    public partial class ActionHistory
    {
        /// <summary>
        /// Gets and sets the property ActionHistoryDetails. 
        /// <para>
        /// The description of the details for the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionHistoryDetails ActionHistoryDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActionHistoryDetails property is set.
        /// </summary>
        internal bool IsSetActionHistoryDetails() => this.ActionHistoryDetails != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// This distinguishes between whether the events are triggered by the user or are generated
        /// by the system. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of action at the time of the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Timestamp.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
