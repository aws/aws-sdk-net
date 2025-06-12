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
    /// Container for the parameters to the CreateDetectorVersion operation.
    /// Creates a detector version. The detector version starts in a <c>DRAFT</c> status.
    /// </summary>
    public partial class CreateDetectorVersionRequest : AmazonFraudDetectorRequest
    {
        private string _description;
        private string _detectorId;
        private List<string> _externalModelEndpoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ModelVersion> _modelVersions = AWSConfigs.InitializeCollections ? new List<ModelVersion>() : null;
        private RuleExecutionMode _ruleExecutionMode;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the detector version.
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
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector under which you want to create a new version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property ExternalModelEndpoints. 
        /// <para>
        /// The Amazon Sagemaker model endpoints to include in the detector version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExternalModelEndpoints
        {
            get { return this._externalModelEndpoints; }
            set { this._externalModelEndpoints = value; }
        }

        // Check to see if ExternalModelEndpoints property is set
        internal bool IsSetExternalModelEndpoints()
        {
            return this._externalModelEndpoints != null && (this._externalModelEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelVersions. 
        /// <para>
        /// The model versions to include in the detector version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelVersion> ModelVersions
        {
            get { return this._modelVersions; }
            set { this._modelVersions = value; }
        }

        // Check to see if ModelVersions property is set
        internal bool IsSetModelVersions()
        {
            return this._modelVersions != null && (this._modelVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleExecutionMode. 
        /// <para>
        /// The rule execution mode for the rules included in the detector version.
        /// </para>
        ///  
        /// <para>
        /// You can define and edit the rule mode at the detector version level, when it is in
        /// draft status.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>FIRST_MATCHED</c>, Amazon Fraud Detector evaluates rules sequentially,
        /// first to last, stopping at the first matched rule. Amazon Fraud dectector then provides
        /// the outcomes for that single rule.
        /// </para>
        ///  
        /// <para>
        /// If you specifiy <c>ALL_MATCHED</c>, Amazon Fraud Detector evaluates all rules and
        /// returns the outcomes for all matched rules. 
        /// </para>
        ///  
        /// <para>
        /// The default behavior is <c>FIRST_MATCHED</c>.
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
        /// The rules to include in the detector version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
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