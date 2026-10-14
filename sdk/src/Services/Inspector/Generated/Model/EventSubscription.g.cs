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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used in the <a>Subscription</a> data type.
    /// </summary>
    public partial class EventSubscription
    {
        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event for which Amazon Simple Notification Service (SNS) notifications are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InspectorEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property SubscribedAt. 
        /// <para>
        /// The time at which <a>SubscribeToEvent</a> is called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubscribedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubscribedAt property is set.
        /// </summary>
        internal bool IsSetSubscribedAt() => this.SubscribedAt.HasValue;
    }
}
