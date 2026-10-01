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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// This is the response object from the GetInternetEvent operation.
    /// </summary>
    public partial class GetInternetEventResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientLocation. 
        /// <para>
        /// The impacted location, such as a city, where clients access Amazon Web Services application
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientLocation ClientLocation { get; set; }

        /// <summary>
        /// Checks to see if the ClientLocation property is set.
        /// </summary>
        internal bool IsSetClientLocation() => this.ClientLocation != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time when the internet event ended. If the event hasn't ended yet, this value
        /// is empty.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the internet event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EventArn { get; set; }

        /// <summary>
        /// Checks to see if the EventArn property is set.
        /// </summary>
        internal bool IsSetEventArn() => this.EventArn != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The internally-generated identifier of an internet event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The status of the internet event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InternetEventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of network impairment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InternetEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when the internet event started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;
    }
}
