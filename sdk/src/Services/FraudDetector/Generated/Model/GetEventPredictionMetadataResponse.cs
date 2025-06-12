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
    /// This is the response object from the GetEventPredictionMetadata operation.
    /// </summary>
    public partial class GetEventPredictionMetadataResponse : AmazonWebServiceResponse
    {
        private string _detectorId;
        private string _detectorVersionId;
        private string _detectorVersionStatus;
        private string _entityId;
        private string _entityType;
        private List<EvaluatedExternalModel> _evaluatedExternalModels = AWSConfigs.InitializeCollections ? new List<EvaluatedExternalModel>() : null;
        private List<EvaluatedModelVersion> _evaluatedModelVersions = AWSConfigs.InitializeCollections ? new List<EvaluatedModelVersion>() : null;
        private string _eventId;
        private string _eventTimestamp;
        private string _eventTypeName;
        private List<EventVariableSummary> _eventVariables = AWSConfigs.InitializeCollections ? new List<EventVariableSummary>() : null;
        private List<string> _outcomes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _predictionTimestamp;
        private RuleExecutionMode _ruleExecutionMode;
        private List<EvaluatedRule> _rules = AWSConfigs.InitializeCollections ? new List<EvaluatedRule>() : null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        ///  The detector ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        ///  The detector version ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string DetectorVersionId
        {
            get { return this._detectorVersionId; }
            set { this._detectorVersionId = value; }
        }

        // Check to see if DetectorVersionId property is set
        internal bool IsSetDetectorVersionId()
        {
            return this._detectorVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorVersionStatus. 
        /// <para>
        ///  The status of the detector version. 
        /// </para>
        /// </summary>
        public string DetectorVersionStatus
        {
            get { return this._detectorVersionStatus; }
            set { this._detectorVersionStatus = value; }
        }

        // Check to see if DetectorVersionStatus property is set
        internal bool IsSetDetectorVersionStatus()
        {
            return this._detectorVersionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        ///  The entity ID. 
        /// </para>
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        ///  The entity type. 
        /// </para>
        /// </summary>
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatedExternalModels. 
        /// <para>
        ///  External (Amazon SageMaker) models that were evaluated for generating predictions.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatedExternalModel> EvaluatedExternalModels
        {
            get { return this._evaluatedExternalModels; }
            set { this._evaluatedExternalModels = value; }
        }

        // Check to see if EvaluatedExternalModels property is set
        internal bool IsSetEvaluatedExternalModels()
        {
            return this._evaluatedExternalModels != null && (this._evaluatedExternalModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluatedModelVersions. 
        /// <para>
        ///  Model versions that were evaluated for generating predictions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatedModelVersion> EvaluatedModelVersions
        {
            get { return this._evaluatedModelVersions; }
            set { this._evaluatedModelVersions = value; }
        }

        // Check to see if EvaluatedModelVersions property is set
        internal bool IsSetEvaluatedModelVersions()
        {
            return this._evaluatedModelVersions != null && (this._evaluatedModelVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The event ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        ///  The timestamp for when the prediction was generated for the associated event ID.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string EventTimestamp
        {
            get { return this._eventTimestamp; }
            set { this._eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this._eventTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        ///  The event type associated with the detector specified for this prediction. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property EventVariables. 
        /// <para>
        ///  A list of event variables that influenced the prediction scores. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventVariableSummary> EventVariables
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
        /// Gets and sets the property Outcomes. 
        /// <para>
        ///  The outcomes of the matched rule, based on the rule execution mode. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Outcomes
        {
            get { return this._outcomes; }
            set { this._outcomes = value; }
        }

        // Check to see if Outcomes property is set
        internal bool IsSetOutcomes()
        {
            return this._outcomes != null && (this._outcomes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PredictionTimestamp. 
        /// <para>
        /// The timestamp that defines when the prediction was generated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string PredictionTimestamp
        {
            get { return this._predictionTimestamp; }
            set { this._predictionTimestamp = value; }
        }

        // Check to see if PredictionTimestamp property is set
        internal bool IsSetPredictionTimestamp()
        {
            return this._predictionTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property RuleExecutionMode. 
        /// <para>
        ///  The execution mode of the rule used for evaluating variable values. 
        /// </para>
        /// </summary>
        public RuleExecutionMode RuleExecutionMode
        {
            get { return this._ruleExecutionMode; }
            set { this._ruleExecutionMode = value; }
        }

        // Check to see if RuleExecutionMode property is set
        internal bool IsSetRuleExecutionMode()
        {
            return this._ruleExecutionMode != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  List of rules associated with the detector version that were used for evaluating
        /// variable values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatedRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}