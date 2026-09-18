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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object containing details about a specific event.
    /// </summary>
    public partial class InsightsEvent
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Details about bounce or complaint events.
        /// </para>
        /// </summary>
        public EventDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the event.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SEND</c> - The send request was successful and SES will attempt to deliver the
        /// message to the recipient’s mail server. (If account-level or global suppression is
        /// being used, SES will still count it as a send, but delivery is suppressed.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY</c> - SES successfully delivered the email to the recipient's mail server.
        /// Excludes deliveries to the mailbox simulator, and those from emails addressed to more
        /// than one recipient. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOUNCE</c> - Feedback received for delivery failures. Additional details about
        /// the bounce are provided in the <c>Details</c> object. Excludes bounces from the mailbox
        /// simulator, and those from emails addressed to more than one recipient. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLAINT</c> - Complaint received for the email. Additional details about the
        /// complaint are provided in the <c>Details</c> object. This excludes complaints from
        /// the mailbox simulator, those originating from your account-level suppression list
        /// (if enabled), and those from emails addressed to more than one recipient. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPEN</c> - Open event for emails including open trackers. Excludes opens for emails
        /// addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLICK</c> - Click event for emails including wrapped links. Excludes clicks for
        /// emails addressed to more than one recipient.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EventType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
