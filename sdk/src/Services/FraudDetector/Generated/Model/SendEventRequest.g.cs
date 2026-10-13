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
    /// Container for the parameters to the SendEvent operation. Stores events in Amazon Fraud
    /// Detector without generating fraud predictions for those events. For example, you can
    /// use <c>SendEvent</c> to upload a historical dataset, which you can then later use
    /// to train a model.
    /// </summary>
    public partial class SendEventRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property AssignedLabel. 
        /// <para>
        /// The label to associate with the event. Required if specifying <c>labelTimestamp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssignedLabel { get; set; }

        /// <summary>
        /// Checks to see if the AssignedLabel property is set.
        /// </summary>
        internal bool IsSetAssignedLabel() => this.AssignedLabel != null;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// An array of entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Entity> Entities { get; set; } = AWSConfigs.InitializeCollections ? new List<Entity>() : null;

        /// <summary>
        /// Checks to see if the Entities property is set.
        /// </summary>
        internal bool IsSetEntities() => this.Entities != null && (this.Entities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The event ID to upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The timestamp that defines when the event under evaluation occurred. The timestamp
        /// must be specified using ISO 8601 standard in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The event type name of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property EventVariables. 
        /// <para>
        /// Names of the event type's variables you defined in Amazon Fraud Detector to represent
        /// data elements and their corresponding values for the event you are sending for evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public Dictionary<string, string> EventVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EventVariables property is set.
        /// </summary>
        internal bool IsSetEventVariables() => this.EventVariables != null && (this.EventVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelTimestamp. 
        /// <para>
        /// The timestamp associated with the label. Required if specifying <c>assignedLabel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 30)]
        public string LabelTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LabelTimestamp property is set.
        /// </summary>
        internal bool IsSetLabelTimestamp() => this.LabelTimestamp != null;
    }
}
