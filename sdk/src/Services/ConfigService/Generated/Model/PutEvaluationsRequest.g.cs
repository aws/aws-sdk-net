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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutEvaluations operation. Used by an Lambda function
    /// to deliver evaluation results to Config. This operation is required in every Lambda
    /// function that is invoked by an Config rule.
    /// </summary>
    public partial class PutEvaluationsRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Evaluations. 
        /// <para>
        /// The assessments that the Lambda function performs. Each evaluation identifies an Amazon
        /// Web Services resource and indicates whether it complies with the Config rule that
        /// invokes the Lambda function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Evaluation> Evaluations { get; set; } = AWSConfigs.InitializeCollections ? new List<Evaluation>() : null;

        /// <summary>
        /// Checks to see if the Evaluations property is set.
        /// </summary>
        internal bool IsSetEvaluations() => this.Evaluations != null && (this.Evaluations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResultToken. 
        /// <para>
        /// An encrypted token that associates an evaluation with an Config rule. Identifies the
        /// rule and the event that triggered the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResultToken { get; set; }

        /// <summary>
        /// Checks to see if the ResultToken property is set.
        /// </summary>
        internal bool IsSetResultToken() => this.ResultToken != null;

        /// <summary>
        /// Gets and sets the property TestMode. 
        /// <para>
        /// Use this parameter to specify a test run for <c>PutEvaluations</c>. You can verify
        /// whether your Lambda function will deliver evaluation results to Config. No updates
        /// occur to your existing evaluations, and evaluation results are not sent to Config.
        /// </para>
        ///  <note> 
        /// <para>
        /// When <c>TestMode</c> is <c>true</c>, <c>PutEvaluations</c> doesn't require a valid
        /// value for the <c>ResultToken</c> parameter, but the value cannot be null.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? TestMode { get; set; }

        /// <summary>
        /// Checks to see if the TestMode property is set.
        /// </summary>
        internal bool IsSetTestMode() => this.TestMode.HasValue;
    }
}
