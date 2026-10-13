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
    /// This is the response object from the GetDetectorVersion operation.
    /// </summary>
    public partial class GetDetectorVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The detector version ARN.
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
        /// The timestamp when the detector version was created. 
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
        /// The detector version description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID.
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
        /// The detector version ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string DetectorVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorVersionId property is set.
        /// </summary>
        internal bool IsSetDetectorVersionId() => this.DetectorVersionId != null;

        /// <summary>
        /// Gets and sets the property ExternalModelEndpoints. 
        /// <para>
        /// The Amazon SageMaker model endpoints included in the detector version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExternalModelEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExternalModelEndpoints property is set.
        /// </summary>
        internal bool IsSetExternalModelEndpoints() => this.ExternalModelEndpoints != null && (this.ExternalModelEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the detector version was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property ModelVersions. 
        /// <para>
        /// The model versions included in the detector version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelVersion> ModelVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelVersion>() : null;

        /// <summary>
        /// Checks to see if the ModelVersions property is set.
        /// </summary>
        internal bool IsSetModelVersions() => this.ModelVersions != null && (this.ModelVersions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public RuleExecutionMode RuleExecutionMode { get; set; }

        /// <summary>
        /// Checks to see if the RuleExecutionMode property is set.
        /// </summary>
        internal bool IsSetRuleExecutionMode() => this.RuleExecutionMode != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The rules included in the detector version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Rule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the detector version.
        /// </para>
        /// </summary>
        public DetectorVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
