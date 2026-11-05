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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Recommended instance types for inference with a SageMaker model.
    /// </summary>
    public partial class SageMakerModelRecommendation
    {
        /// <summary>
        /// Gets and sets the property RecommendedBatchTransformInstanceType. 
        /// <para>
        /// The recommended instance type for batch inference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecommendedBatchTransformInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedBatchTransformInstanceType property is set.
        /// </summary>
        internal bool IsSetRecommendedBatchTransformInstanceType() => this.RecommendedBatchTransformInstanceType != null;

        /// <summary>
        /// Gets and sets the property RecommendedRealtimeInferenceInstanceType. 
        /// <para>
        /// The recommended instance type for real-time inference.
        /// </para>
        /// </summary>
        public string RecommendedRealtimeInferenceInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedRealtimeInferenceInstanceType property is set.
        /// </summary>
        internal bool IsSetRecommendedRealtimeInferenceInstanceType() => this.RecommendedRealtimeInferenceInstanceType != null;
    }
}
