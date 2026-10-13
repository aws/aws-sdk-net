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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventLabel operation. Updates the specified
    /// event with a new label.
    /// </summary>
    public partial class UpdateEventLabelRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property AssignedLabel. 
        /// <para>
        /// The new label to assign to the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AssignedLabel { get; set; }

        /// <summary>
        /// Checks to see if the AssignedLabel property is set.
        /// </summary>
        internal bool IsSetAssignedLabel() => this.AssignedLabel != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the event associated with the label to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The event type of the event associated with the label to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property LabelTimestamp. 
        /// <para>
        /// The timestamp associated with the label. The timestamp must be specified using ISO
        /// 8601 standard in UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string LabelTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LabelTimestamp property is set.
        /// </summary>
        internal bool IsSetLabelTimestamp() => this.LabelTimestamp != null;
    }
}
