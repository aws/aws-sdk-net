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
    /// The SageMaker endpoint configuration for benchmarking.
    /// </summary>
    public partial class AIBenchmarkEndpoint
    {
        private string _identifier;
        private List<AIBenchmarkInferenceComponent> _inferenceComponents = AWSConfigs.InitializeCollections ? new List<AIBenchmarkInferenceComponent>() : null;
        private string _targetContainerHostname;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the SageMaker endpoint to benchmark.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceComponents. 
        /// <para>
        /// The list of inference components to benchmark on the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AIBenchmarkInferenceComponent> InferenceComponents
        {
            get { return this._inferenceComponents; }
            set { this._inferenceComponents = value; }
        }

        // Check to see if InferenceComponents property is set
        internal bool IsSetInferenceComponents()
        {
            return this._inferenceComponents != null && (this._inferenceComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetContainerHostname. 
        /// <para>
        /// The hostname of the specific container to target within a multi-container endpoint.
        /// </para>
        /// </summary>
        public string TargetContainerHostname
        {
            get { return this._targetContainerHostname; }
            set { this._targetContainerHostname = value; }
        }

        // Check to see if TargetContainerHostname property is set
        internal bool IsSetTargetContainerHostname()
        {
            return this._targetContainerHostname != null;
        }

    }
}