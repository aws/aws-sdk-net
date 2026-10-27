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
    /// An event on the timeline of a resilience policy.
    /// </summary>
    public partial class PolicyEvent
    {
        /// <summary>
        /// Gets and sets the property Actor.
        /// </summary>
        [AWSProperty(Required = true)]
        public EventActor Actor { get; set; }

        /// <summary>
        /// Checks to see if the Actor property is set.
        /// </summary>
        internal bool IsSetActor() => this.Actor != null;

        /// <summary>
        /// Gets and sets the property EventDetails. 
        /// <para>
        /// The details of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyEventDetails EventDetails { get; set; }

        /// <summary>
        /// Checks to see if the EventDetails property is set.
        /// </summary>
        internal bool IsSetEventDetails() => this.EventDetails != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The identifier of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
