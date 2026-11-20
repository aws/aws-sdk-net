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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A reference to an event actor that is associated with an API security event.
    /// </summary>
    public partial class EventActorReference
    {
        /// <summary>
        /// Gets and sets the property EventActorId. 
        /// <para>
        /// The unique identifier of the event actor. You provide this to <a>GetEventActor</a>
        /// to retrieve the details of the event actor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string EventActorId { get; set; }

        /// <summary>
        /// Checks to see if the EventActorId property is set.
        /// </summary>
        internal bool IsSetEventActorId() => this.EventActorId != null;

        /// <summary>
        /// Gets and sets the property EventActorValue. 
        /// <para>
        /// The observed identifier of the event actor. For example, a client IP address or an
        /// authentication fingerprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string EventActorValue { get; set; }

        /// <summary>
        /// Checks to see if the EventActorValue property is set.
        /// </summary>
        internal bool IsSetEventActorValue() => this.EventActorValue != null;
    }
}
