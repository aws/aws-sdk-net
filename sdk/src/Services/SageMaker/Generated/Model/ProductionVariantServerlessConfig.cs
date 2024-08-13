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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private int? _maxConcurrency;
        private int? _memorySizeInMB;
        private int? _provisionedConcurrency;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of concurrent invocations your serverless endpoint can process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public int? MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInMB. 
        /// <para>
        /// The memory size of your serverless endpoint. Valid values are in 1 GB increments:
        /// 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1024, Max=6144)]
        public int? MemorySizeInMB
        {
            get { return this._memorySizeInMB; }
            set { this._memorySizeInMB = value; }
        }

        // Check to see if MemorySizeInMB property is set
        internal bool IsSetMemorySizeInMB()
        {
            return this._memorySizeInMB.HasValue; 
        }

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
        [AWSProperty(Min=1, Max=200)]
        public int? ProvisionedConcurrency
        {
            get { return this._provisionedConcurrency; }
            set { this._provisionedConcurrency = value; }
        }

        // Check to see if ProvisionedConcurrency property is set
        internal bool IsSetProvisionedConcurrency()
        {
            return this._provisionedConcurrency.HasValue; 
        }

    }
}