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
    /// The endpoint configuration for the load test.
    /// </summary>
    public partial class EndpointInputConfiguration
    {
        private EnvironmentParameterRanges _environmentParameterRanges;
        private string _inferenceSpecificationName;
        private ProductionVariantInstanceType _instanceType;
        private ProductionVariantServerlessConfig _serverlessConfig;

        /// <summary>
        /// Gets and sets the property EnvironmentParameterRanges. 
        /// <para>
        ///  The parameter you want to benchmark against.
        /// </para>
        /// </summary>
        public EnvironmentParameterRanges EnvironmentParameterRanges
        {
            get { return this._environmentParameterRanges; }
            set { this._environmentParameterRanges = value; }
        }

        // Check to see if EnvironmentParameterRanges property is set
        internal bool IsSetEnvironmentParameterRanges()
        {
            return this._environmentParameterRanges != null;
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

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance types to use for the load test.
        /// </para>
        /// </summary>
        public ProductionVariantInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessConfig.
        /// </summary>
        public ProductionVariantServerlessConfig ServerlessConfig
        {
            get { return this._serverlessConfig; }
            set { this._serverlessConfig = value; }
        }

        // Check to see if ServerlessConfig property is set
        internal bool IsSetServerlessConfig()
        {
            return this._serverlessConfig != null;
        }

    }
}