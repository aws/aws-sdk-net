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
    /// The event type details.
    /// </summary>
    public partial class EventType
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The entity type ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Timestamp of when the event type was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The event type description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// The event type entity types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> EntityTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntityTypes property is set.
        /// </summary>
        internal bool IsSetEntityTypes() => this.EntityTypes != null && (this.EntityTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventIngestion. 
        /// <para>
        /// If <c>Enabled</c>, Amazon Fraud Detector stores event data when you generate a prediction
        /// and uses that data to update calculated variables in near real-time. Amazon Fraud
        /// Detector uses this data, known as <c>INGESTED_EVENTS</c>, to train your model and
        /// improve fraud predictions.
        /// </para>
        /// </summary>
        public EventIngestion EventIngestion { get; set; }

        /// <summary>
        /// Checks to see if the EventIngestion property is set.
        /// </summary>
        internal bool IsSetEventIngestion() => this.EventIngestion != null;

        /// <summary>
        /// Gets and sets the property EventOrchestration. 
        /// <para>
        /// The event orchestration status. 
        /// </para>
        /// </summary>
        public EventOrchestration EventOrchestration { get; set; }

        /// <summary>
        /// Checks to see if the EventOrchestration property is set.
        /// </summary>
        internal bool IsSetEventOrchestration() => this.EventOrchestration != null;

        /// <summary>
        /// Gets and sets the property EventVariables. 
        /// <para>
        /// The event type event variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventVariables property is set.
        /// </summary>
        internal bool IsSetEventVariables() => this.EventVariables != null && (this.EventVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IngestedEventStatistics. 
        /// <para>
        /// Data about the stored events.
        /// </para>
        /// </summary>
        public IngestedEventStatistics IngestedEventStatistics { get; set; }

        /// <summary>
        /// Checks to see if the IngestedEventStatistics property is set.
        /// </summary>
        internal bool IsSetIngestedEventStatistics() => this.IngestedEventStatistics != null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The event type labels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the event type was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The event type name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
