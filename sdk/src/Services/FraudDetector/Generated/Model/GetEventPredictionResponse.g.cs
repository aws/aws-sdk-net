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
    /// This is the response object from the GetEventPrediction operation.
    /// </summary>
    public partial class GetEventPredictionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExternalModelOutputs. 
        /// <para>
        /// The model scores for Amazon SageMaker models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExternalModelOutputs> ExternalModelOutputs { get; set; } = AWSConfigs.InitializeCollections ? new List<ExternalModelOutputs>() : null;

        /// <summary>
        /// Checks to see if the ExternalModelOutputs property is set.
        /// </summary>
        internal bool IsSetExternalModelOutputs() => this.ExternalModelOutputs != null && (this.ExternalModelOutputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelScores. 
        /// <para>
        /// The model scores. Amazon Fraud Detector generates model scores between 0 and 1000,
        /// where 0 is low fraud risk and 1000 is high fraud risk. Model scores are directly related
        /// to the false positive rate (FPR). For example, a score of 600 corresponds to an estimated
        /// 10% false positive rate whereas a score of 900 corresponds to an estimated 2% false
        /// positive rate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelScores> ModelScores { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelScores>() : null;

        /// <summary>
        /// Checks to see if the ModelScores property is set.
        /// </summary>
        internal bool IsSetModelScores() => this.ModelScores != null && (this.ModelScores.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// The results from the rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleResult> RuleResults { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleResult>() : null;

        /// <summary>
        /// Checks to see if the RuleResults property is set.
        /// </summary>
        internal bool IsSetRuleResults() => this.RuleResults != null && (this.RuleResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
