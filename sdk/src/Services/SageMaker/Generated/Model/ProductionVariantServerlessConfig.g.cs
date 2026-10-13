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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the serverless configuration for an endpoint variant.
    /// </summary>
    public partial class ProductionVariantServerlessConfig
    {
        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of concurrent invocations your serverless endpoint can process.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySizeInMB. 
        /// <para>
        /// The memory size of your serverless endpoint. Valid values are in 1 GB increments:
        /// 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1024, Max = 6144)]
        public int? MemorySizeInMB { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInMB property is set.
        /// </summary>
        internal bool IsSetMemorySizeInMB() => this.MemorySizeInMB.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedConcurrency. 
        /// <para>
        /// The amount of provisioned concurrency to allocate for the serverless endpoint. Should
        /// be less than or equal to <c>MaxConcurrency</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is not supported for serverless endpoint recommendations for Inference
        /// Recommender jobs. For more information about creating an Inference Recommender job,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateInferenceRecommendationsJob.html">CreateInferenceRecommendationsJobs</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? ProvisionedConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedConcurrency property is set.
        /// </summary>
        internal bool IsSetProvisionedConcurrency() => this.ProvisionedConcurrency.HasValue;
    }
}
