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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// <important> 
    /// <para>
    /// Serverless Inference is in preview release for Amazon SageMaker and is subject to
    /// change. We do not recommend using this feature in production environments.
    /// </para>
    ///  </important> 
    /// <para>
    /// Specifies the serverless configuration for an endpoint variant.
    /// </para>
    /// </summary>
    public partial class ProductionVariantServerlessConfig
    {
        private int? _maxConcurrency;
        private int? _memorySizeInMB;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of concurrent invocations your serverless endpoint can process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public int MaxConcurrency
        {
            get { return this._maxConcurrency.GetValueOrDefault(); }
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
        public int MemorySizeInMB
        {
            get { return this._memorySizeInMB.GetValueOrDefault(); }
            set { this._memorySizeInMB = value; }
        }

        // Check to see if MemorySizeInMB property is set
        internal bool IsSetMemorySizeInMB()
        {
            return this._memorySizeInMB.HasValue; 
        }

    }
}