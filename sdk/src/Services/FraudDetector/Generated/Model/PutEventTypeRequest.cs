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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
    /// Container for the parameters to the PutEventType operation.
    /// Creates or updates an event type. An event is a business activity that is evaluated
    /// for fraud risk. With Amazon Fraud Detector, you generate fraud predictions for events.
    /// An event type defines the structure for an event sent to Amazon Fraud Detector. This
    /// includes the variables sent as part of the event, the entity performing the event
    /// (such as a customer), and the labels that classify the event. Example event types
    /// include online payment transactions, account registrations, and authentications.
    /// </summary>
    public partial class PutEventTypeRequest : AmazonFraudDetectorRequest
    {
        private string _description;
        private List<string> _entityTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EventIngestion _eventIngestion;
        private EventOrchestration _eventOrchestration;
        private List<string> _eventVariables = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the event type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// The entity type for the event type. Example entity types: customer, merchant, account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> EntityTypes
        {
            get { return this._entityTypes; }
            set { this._entityTypes = value; }
        }

        // Check to see if EntityTypes property is set
        internal bool IsSetEntityTypes()
        {
            return this._entityTypes != null && (this._entityTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventIngestion. 
        /// <para>
        /// Specifies if ingestion is enabled or disabled.
        /// </para>
        /// </summary>
        public EventIngestion EventIngestion
        {
            get { return this._eventIngestion; }
            set { this._eventIngestion = value; }
        }

        // Check to see if EventIngestion property is set
        internal bool IsSetEventIngestion()
        {
            return this._eventIngestion != null;
        }

        /// <summary>
        /// Gets and sets the property EventOrchestration. 
        /// <para>
        /// Enables or disables event orchestration. If enabled, you can send event predictions
        /// to select AWS services for downstream processing of the events.
        /// </para>
        /// </summary>
        public EventOrchestration EventOrchestration
        {
            get { return this._eventOrchestration; }
            set { this._eventOrchestration = value; }
        }

        // Check to see if EventOrchestration property is set
        internal bool IsSetEventOrchestration()
        {
            return this._eventOrchestration != null;
        }

        /// <summary>
        /// Gets and sets the property EventVariables. 
        /// <para>
        /// The event type variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> EventVariables
        {
            get { return this._eventVariables; }
            set { this._eventVariables = value; }
        }

        // Check to see if EventVariables property is set
        internal bool IsSetEventVariables()
        {
            return this._eventVariables != null && (this._eventVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The event type labels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of key and value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}