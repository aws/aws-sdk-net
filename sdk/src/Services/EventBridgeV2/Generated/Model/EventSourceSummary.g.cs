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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Summary of an EventSource, as returned by ListEventSources.
    /// </summary>
    public partial class EventSourceSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. The time the EventSource was created.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventBusArn.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property EventSourceAccountId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string EventSourceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceAccountId property is set.
        /// </summary>
        internal bool IsSetEventSourceAccountId() => this.EventSourceAccountId != null;

        /// <summary>
        /// Gets and sets the property EventSourceArn.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. The time the EventSource was last modified.
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Revoked. True when the bus owner has withdrawn this EventSource.
        /// Present only when true, so a bus owner listing EventSources sees at a glance which
        /// ones they revoked. See DescribeEventSourceResponse$Revoked.
        /// </summary>
        public bool? Revoked { get; set; }

        /// <summary>
        /// Checks to see if the Revoked property is set.
        /// </summary>
        internal bool IsSetRevoked() => this.Revoked.HasValue;

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public EventSourceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public EventSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
