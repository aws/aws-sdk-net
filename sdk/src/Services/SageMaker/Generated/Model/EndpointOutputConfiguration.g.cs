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
    /// The endpoint configuration made by Inference Recommender during a recommendation job.
    /// </summary>
    public partial class EndpointOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint made during a recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// The number of instances recommended to launch initially.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? InitialInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InitialInstanceCount property is set.
        /// </summary>
        internal bool IsSetInitialInstanceCount() => this.InitialInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type recommended by Amazon SageMaker Inference Recommender.
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

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant (deployed model) made during a recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;
    }
}
