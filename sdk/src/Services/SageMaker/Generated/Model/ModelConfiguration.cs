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
    /// Defines the model configuration. Includes the specification name and environment parameters.
    /// </summary>
    public partial class ModelConfiguration
    {
        private string _compilationJobName;
        private List<EnvironmentParameter> _environmentParameters = AWSConfigs.InitializeCollections ? new List<EnvironmentParameter>() : null;
        private string _inferenceSpecificationName;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the compilation job used to create the recommended model artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CompilationJobName
        {
            get { return this._compilationJobName; }
            set { this._compilationJobName = value; }
        }

        // Check to see if CompilationJobName property is set
        internal bool IsSetCompilationJobName()
        {
            return this._compilationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentParameters. 
        /// <para>
        /// Defines the environment parameters that includes key, value types, and values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EnvironmentParameter> EnvironmentParameters
        {
            get { return this._environmentParameters; }
            set { this._environmentParameters = value; }
        }

        // Check to see if EnvironmentParameters property is set
        internal bool IsSetEnvironmentParameters()
        {
            return this._environmentParameters != null && (this._environmentParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferenceSpecificationName. 
        /// <para>
        /// The inference specification name in the model package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string InferenceSpecificationName
        {
            get { return this._inferenceSpecificationName; }
            set { this._inferenceSpecificationName = value; }
        }

        // Check to see if InferenceSpecificationName property is set
        internal bool IsSetInferenceSpecificationName()
        {
            return this._inferenceSpecificationName != null;
        }

    }
}