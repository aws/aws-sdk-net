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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListInferenceExecutions operation.
    /// </summary>
    public partial class ListInferenceExecutionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property InferenceExecutionSummaries. 
        /// <para>
        /// Provides an array of information about the individual inference executions returned
        /// from the <c>ListInferenceExecutions</c> operation, including model used, inference
        /// scheduler, data configuration, and so on. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't supply the <c>InferenceSchedulerName</c> request parameter, or if you
        /// supply the name of an inference scheduler that doesn't exist, <c>ListInferenceExecutions</c>
        /// returns an empty array in <c>InferenceExecutionSummaries</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InferenceExecutionSummary> InferenceExecutionSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<InferenceExecutionSummary>() : null;

        /// <summary>
        /// Checks to see if the InferenceExecutionSummaries property is set.
        /// </summary>
        internal bool IsSetInferenceExecutionSummaries() => this.InferenceExecutionSummaries != null && (this.InferenceExecutionSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of inference
        /// executions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
