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
    /// The endpoint configuration for the load test.
    /// </summary>
    public partial class EndpointInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property EnvironmentParameterRanges. 
        /// <para>
        ///  The parameter you want to benchmark against.
        /// </para>
        /// </summary>
        public EnvironmentParameterRanges EnvironmentParameterRanges { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentParameterRanges property is set.
        /// </summary>
        internal bool IsSetEnvironmentParameterRanges() => this.EnvironmentParameterRanges != null;

        /// <summary>
        /// Gets and sets the property InferenceSpecificationName. 
        /// <para>
        /// The inference specification name in the model package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string InferenceSpecificationName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSpecificationName property is set.
        /// </summary>
        internal bool IsSetInferenceSpecificationName() => this.InferenceSpecificationName != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance types to use for the load test.
        /// </para>
        /// </summary>
        public ProductionVariantInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ServerlessConfig.
        /// </summary>
        public ProductionVariantServerlessConfig ServerlessConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessConfig property is set.
        /// </summary>
        internal bool IsSetServerlessConfig() => this.ServerlessConfig != null;
    }
}
