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
    /// Settings for an optimization technique that you apply with a model optimization job.
    /// </summary>
    public partial class OptimizationConfig
    {
        private ModelCompilationConfig _modelCompilationConfig;
        private ModelQuantizationConfig _modelQuantizationConfig;
        private ModelShardingConfig _modelShardingConfig;

        /// <summary>
        /// Gets and sets the property ModelCompilationConfig. 
        /// <para>
        /// Settings for the model compilation technique that's applied by a model optimization
        /// job.
        /// </para>
        /// </summary>
        public ModelCompilationConfig ModelCompilationConfig
        {
            get { return this._modelCompilationConfig; }
            set { this._modelCompilationConfig = value; }
        }

        // Check to see if ModelCompilationConfig property is set
        internal bool IsSetModelCompilationConfig()
        {
            return this._modelCompilationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelQuantizationConfig. 
        /// <para>
        /// Settings for the model quantization technique that's applied by a model optimization
        /// job.
        /// </para>
        /// </summary>
        public ModelQuantizationConfig ModelQuantizationConfig
        {
            get { return this._modelQuantizationConfig; }
            set { this._modelQuantizationConfig = value; }
        }

        // Check to see if ModelQuantizationConfig property is set
        internal bool IsSetModelQuantizationConfig()
        {
            return this._modelQuantizationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelShardingConfig. 
        /// <para>
        /// Settings for the model sharding technique that's applied by a model optimization job.
        /// </para>
        /// </summary>
        public ModelShardingConfig ModelShardingConfig
        {
            get { return this._modelShardingConfig; }
            set { this._modelShardingConfig = value; }
        }

        // Check to see if ModelShardingConfig property is set
        internal bool IsSetModelShardingConfig()
        {
            return this._modelShardingConfig != null;
        }

    }
}