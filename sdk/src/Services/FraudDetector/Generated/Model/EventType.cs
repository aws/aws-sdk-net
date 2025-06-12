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
    /// The event type details.
    /// </summary>
    public partial class EventType
    {
        private string _arn;
        private string _createdTime;
        private string _description;
        private List<string> _entityTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EventIngestion _eventIngestion;
        private EventOrchestration _eventOrchestration;
        private List<string> _eventVariables = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IngestedEventStatistics _ingestedEventStatistics;
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _lastUpdatedTime;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The entity type ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Timestamp of when the event type was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The event type description.
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
        /// The event type entity types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// If <c>Enabled</c>, Amazon Fraud Detector stores event data when you generate a prediction
        /// and uses that data to update calculated variables in near real-time. Amazon Fraud
        /// Detector uses this data, known as <c>INGESTED_EVENTS</c>, to train your model and
        /// improve fraud predictions.
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
        /// The event orchestration status. 
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
        /// The event type event variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property IngestedEventStatistics. 
        /// <para>
        /// Data about the stored events.
        /// </para>
        /// </summary>
        public IngestedEventStatistics IngestedEventStatistics
        {
            get { return this._ingestedEventStatistics; }
            set { this._ingestedEventStatistics = value; }
        }

        // Check to see if IngestedEventStatistics property is set
        internal bool IsSetIngestedEventStatistics()
        {
            return this._ingestedEventStatistics != null;
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the event type was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The event type name.
        /// </para>
        /// </summary>
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

    }
}