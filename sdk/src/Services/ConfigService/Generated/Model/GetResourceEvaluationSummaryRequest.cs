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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
    /// Container for the parameters to the GetResourceEvaluationSummary operation.
    /// Returns a summary of resource evaluation for the specified resource evaluation ID
    /// from the proactive rules that were run. The results indicate which evaluation context
    /// was used to evaluate the rules, which resource details were evaluated, the evaluation
    /// mode that was run, and whether the resource details comply with the configuration
    /// of the proactive rules. 
    /// 
    ///  <note> 
    /// <para>
    /// To see additional information about the evaluation result, such as which rule flagged
    /// a resource as NON_COMPLIANT, use the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_GetComplianceDetailsByResource.html">GetComplianceDetailsByResource</a>
    /// API. For more information, see the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_GetResourceEvaluationSummary.html#API_GetResourceEvaluationSummary_Examples">Examples</a>
    /// section.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetResourceEvaluationSummaryRequest : AmazonConfigServiceRequest
    {
        private string _resourceEvaluationId;

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// The unique <c>ResourceEvaluationId</c> of Amazon Web Services resource execution for
        /// which you want to retrieve the evaluation summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceEvaluationId
        {
            get { return this._resourceEvaluationId; }
            set { this._resourceEvaluationId = value; }
        }

        // Check to see if ResourceEvaluationId property is set
        internal bool IsSetResourceEvaluationId()
        {
            return this._resourceEvaluationId != null;
        }

    }
}