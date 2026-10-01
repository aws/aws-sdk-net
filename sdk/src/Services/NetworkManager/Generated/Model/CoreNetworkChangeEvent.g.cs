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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network change event. This can be a change to a segment, attachment,
    /// route, etc.
    /// </summary>
    public partial class CoreNetworkChangeEvent
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken for the change event.
        /// </para>
        /// </summary>
        public ChangeAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The timestamp for an event change in status.
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifierPath. 
        /// <para>
        /// Uniquely identifies the path for a change within the changeset. For example, the <c>IdentifierPath</c>
        /// for a core network segment change might be <c>"CORE_NETWORK_SEGMENT/us-east-1/devsegment"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IdentifierPath { get; set; }

        /// <summary>
        /// Checks to see if the IdentifierPath property is set.
        /// </summary>
        internal bool IsSetIdentifierPath() => this.IdentifierPath != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the core network change event.
        /// </para>
        /// </summary>
        public ChangeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Describes the type of change event. 
        /// </para>
        /// </summary>
        public ChangeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Details of the change event.
        /// </para>
        /// </summary>
        public CoreNetworkChangeEventValues Values { get; set; }

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null;
    }
}
