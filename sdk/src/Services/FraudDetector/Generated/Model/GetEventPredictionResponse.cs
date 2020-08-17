/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// This is the response object from the GetEventPrediction operation.
    /// </summary>
    public partial class GetEventPredictionResponse : AmazonWebServiceResponse
    {
        private List<ModelScores> _modelScores = new List<ModelScores>();
        private List<RuleResult> _ruleResults = new List<RuleResult>();

        /// <summary>
        /// Gets and sets the property ModelScores. 
        /// <para>
        /// The model scores. Amazon Fraud Detector generates model scores between 0 and 1000,
        /// where 0 is low fraud risk and 1000 is high fraud risk. Model scores are directly related
        /// to the false positive rate (FPR). For example, a score of 600 corresponds to an estimated
        /// 10% false positive rate whereas a score of 900 corresponds to an estimated 2% false
        /// positive rate.
        /// </para>
        /// </summary>
        public List<ModelScores> ModelScores
        {
            get { return this._modelScores; }
            set { this._modelScores = value; }
        }

        // Check to see if ModelScores property is set
        internal bool IsSetModelScores()
        {
            return this._modelScores != null && this._modelScores.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// The results.
        /// </para>
        /// </summary>
        public List<RuleResult> RuleResults
        {
            get { return this._ruleResults; }
            set { this._ruleResults = value; }
        }

        // Check to see if RuleResults property is set
        internal bool IsSetRuleResults()
        {
            return this._ruleResults != null && this._ruleResults.Count > 0; 
        }

    }
}