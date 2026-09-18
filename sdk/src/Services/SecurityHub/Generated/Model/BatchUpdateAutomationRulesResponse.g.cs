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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateAutomationRules operation.
    /// </summary>
    public partial class BatchUpdateAutomationRulesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ProcessedAutomationRules. 
        /// <para>
        ///  A list of properly processed rule ARNs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> ProcessedAutomationRules { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProcessedAutomationRules property is set.
        /// </summary>
        internal bool IsSetProcessedAutomationRules() => this.ProcessedAutomationRules != null && (this.ProcessedAutomationRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnprocessedAutomationRules. 
        /// <para>
        ///  A list of objects containing <c>RuleArn</c>, <c>ErrorCode</c>, and <c>ErrorMessage</c>.
        /// This parameter tells you which automation rules the request didn't update and why.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedAutomationRule> UnprocessedAutomationRules { get; set; } = AWSConfigs.InitializeCollections ? new List<UnprocessedAutomationRule>() : null;

        /// <summary>
        /// Checks to see if the UnprocessedAutomationRules property is set.
        /// </summary>
        internal bool IsSetUnprocessedAutomationRules() => this.UnprocessedAutomationRules != null && (this.UnprocessedAutomationRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
