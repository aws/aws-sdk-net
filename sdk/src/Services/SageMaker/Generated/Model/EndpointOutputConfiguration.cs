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
    /// The endpoint configuration made by Inference Recommender during a recommendation job.
    /// </summary>
    public partial class EndpointOutputConfiguration
    {
        private string _endpointName;
        private int? _initialInstanceCount;
        private ProductionVariantInstanceType _instanceType;
        private ProductionVariantServerlessConfig _serverlessConfig;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint made during a recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// The number of instances recommended to launch initially.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? InitialInstanceCount
        {
            get { return this._initialInstanceCount; }
            set { this._initialInstanceCount = value; }
        }

        // Check to see if InitialInstanceCount property is set
        internal bool IsSetInitialInstanceCount()
        {
            return this._initialInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type recommended by Amazon SageMaker Inference Recommender.
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

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant (deployed model) made during a recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VariantName
        {
            get { return this._variantName; }
            set { this._variantName = value; }
        }

        // Check to see if VariantName property is set
        internal bool IsSetVariantName()
        {
            return this._variantName != null;
        }

    }
}