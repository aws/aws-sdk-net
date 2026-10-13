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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Incident Manager reaching out to a contact or escalation plan to engage contact during
    /// an incident.
    /// </summary>
    public partial class Engagement
    {
        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the escalation plan or contact that Incident Manager is engaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactArn { get; set; }

        /// <summary>
        /// Checks to see if the ContactArn property is set.
        /// </summary>
        internal bool IsSetContactArn() => this.ContactArn != null;

        /// <summary>
        /// Gets and sets the property EngagementArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string EngagementArn { get; set; }

        /// <summary>
        /// Checks to see if the EngagementArn property is set.
        /// </summary>
        internal bool IsSetEngagementArn() => this.EngagementArn != null;

        /// <summary>
        /// Gets and sets the property IncidentId. 
        /// <para>
        /// The ARN of the incident that's engaging the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string IncidentId { get; set; }

        /// <summary>
        /// Checks to see if the IncidentId property is set.
        /// </summary>
        internal bool IsSetIncidentId() => this.IncidentId != null;

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The user that started the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Sender { get; set; }

        /// <summary>
        /// Checks to see if the Sender property is set.
        /// </summary>
        internal bool IsSetSender() => this.Sender != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the engagement began.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The time that the engagement ended.
        /// </para>
        /// </summary>
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Checks to see if the StopTime property is set.
        /// </summary>
        internal bool IsSetStopTime() => this.StopTime.HasValue;
    }
}
