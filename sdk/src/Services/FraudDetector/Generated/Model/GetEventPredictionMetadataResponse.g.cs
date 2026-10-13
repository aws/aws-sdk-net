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
    /// This is the response object from the GetEventPredictionMetadata operation.
    /// </summary>
    public partial class GetEventPredictionMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        ///  The detector ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        ///  The detector version ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string DetectorVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorVersionId property is set.
        /// </summary>
        internal bool IsSetDetectorVersionId() => this.DetectorVersionId != null;

        /// <summary>
        /// Gets and sets the property DetectorVersionStatus. 
        /// <para>
        ///  The status of the detector version. 
        /// </para>
        /// </summary>
        public string DetectorVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the DetectorVersionStatus property is set.
        /// </summary>
        internal bool IsSetDetectorVersionStatus() => this.DetectorVersionStatus != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        ///  The entity ID. 
        /// </para>
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        ///  The entity type. 
        /// </para>
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property EvaluatedExternalModels. 
        /// <para>
        ///  External (Amazon SageMaker) models that were evaluated for generating predictions.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatedExternalModel> EvaluatedExternalModels { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatedExternalModel>() : null;

        /// <summary>
        /// Checks to see if the EvaluatedExternalModels property is set.
        /// </summary>
        internal bool IsSetEvaluatedExternalModels() => this.EvaluatedExternalModels != null && (this.EvaluatedExternalModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluatedModelVersions. 
        /// <para>
        ///  Model versions that were evaluated for generating predictions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatedModelVersion> EvaluatedModelVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatedModelVersion>() : null;

        /// <summary>
        /// Checks to see if the EvaluatedModelVersions property is set.
        /// </summary>
        internal bool IsSetEvaluatedModelVersions() => this.EvaluatedModelVersions != null && (this.EvaluatedModelVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The event ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        ///  The timestamp for when the prediction was generated for the associated event ID.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        ///  The event type associated with the detector specified for this prediction. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property EventVariables. 
        /// <para>
        ///  A list of event variables that influenced the prediction scores. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventVariableSummary> EventVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<EventVariableSummary>() : null;

        /// <summary>
        /// Checks to see if the EventVariables property is set.
        /// </summary>
        internal bool IsSetEventVariables() => this.EventVariables != null && (this.EventVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Outcomes. 
        /// <para>
        ///  The outcomes of the matched rule, based on the rule execution mode. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Outcomes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Outcomes property is set.
        /// </summary>
        internal bool IsSetOutcomes() => this.Outcomes != null && (this.Outcomes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PredictionTimestamp. 
        /// <para>
        /// The timestamp that defines when the prediction was generated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string PredictionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PredictionTimestamp property is set.
        /// </summary>
        internal bool IsSetPredictionTimestamp() => this.PredictionTimestamp != null;

        /// <summary>
        /// Gets and sets the property RuleExecutionMode. 
        /// <para>
        ///  The execution mode of the rule used for evaluating variable values. 
        /// </para>
        /// </summary>
        public RuleExecutionMode RuleExecutionMode { get; set; }

        /// <summary>
        /// Checks to see if the RuleExecutionMode property is set.
        /// </summary>
        internal bool IsSetRuleExecutionMode() => this.RuleExecutionMode != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  List of rules associated with the detector version that were used for evaluating
        /// variable values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatedRule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatedRule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
