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
    /// This is the response object from the GetDetectorVersion operation.
    /// </summary>
    public partial class GetDetectorVersionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _createdTime;
        private string _description;
        private string _detectorId;
        private string _detectorVersionId;
        private List<string> _externalModelEndpoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _lastUpdatedTime;
        private List<ModelVersion> _modelVersions = AWSConfigs.InitializeCollections ? new List<ModelVersion>() : null;
        private RuleExecutionMode _ruleExecutionMode;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;
        private DetectorVersionStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The detector version ARN.
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
        /// The timestamp when the detector version was created. 
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
        /// The detector version description.
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
        /// The detector ID.
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
        /// The detector version ID.
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
        /// Gets and sets the property ExternalModelEndpoints. 
        /// <para>
        /// The Amazon SageMaker model endpoints included in the detector version.
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the detector version was last updated. 
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
        /// Gets and sets the property ModelVersions. 
        /// <para>
        /// The model versions included in the detector version. 
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
        /// The execution mode of the rule in the dectector
        /// </para>
        ///  
        /// <para>
        ///  <c>FIRST_MATCHED</c> indicates that Amazon Fraud Detector evaluates rules sequentially,
        /// first to last, stopping at the first matched rule. Amazon Fraud dectector then provides
        /// the outcomes for that single rule.
        /// </para>
        ///  
        /// <para>
        ///  <c>ALL_MATCHED</c> indicates that Amazon Fraud Detector evaluates all rules and returns
        /// the outcomes for all matched rules. You can define and edit the rule mode at the detector
        /// version level, when it is in draft status.
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
        /// The rules included in the detector version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the detector version.
        /// </para>
        /// </summary>
        public DetectorVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}