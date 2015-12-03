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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutEvaluations operation.
    /// Used by an AWS Lambda function to deliver evaluation results to AWS Config. This action
    /// is required in every AWS Lambda function that is invoked by an AWS Config rule.
    /// </summary>
    public partial class PutEvaluationsRequest : AmazonConfigServiceRequest
    {
        private List<Evaluation> _evaluations = new List<Evaluation>();
        private string _resultToken;

        /// <summary>
        /// Gets and sets the property Evaluations. 
        /// <para>
        /// The assessments that the AWS Lambda function performs. Each evaluation identifies
        /// an AWS resource and indicates whether it complies with the AWS Config rule that invokes
        /// the AWS Lambda function.
        /// </para>
        /// </summary>
        public List<Evaluation> Evaluations
        {
            get { return this._evaluations; }
            set { this._evaluations = value; }
        }

        // Check to see if Evaluations property is set
        internal bool IsSetEvaluations()
        {
            return this._evaluations != null && this._evaluations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResultToken. 
        /// <para>
        /// An encrypted token that associates an evaluation with an AWS Config rule. Identifies
        /// the rule and the event that triggered the evaluation
        /// </para>
        /// </summary>
        public string ResultToken
        {
            get { return this._resultToken; }
            set { this._resultToken = value; }
        }

        // Check to see if ResultToken property is set
        internal bool IsSetResultToken()
        {
            return this._resultToken != null;
        }

    }
}