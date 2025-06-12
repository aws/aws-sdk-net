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
    /// Container for the parameters to the CreateInferenceComponent operation.
    /// Creates an inference component, which is a SageMaker AI hosting object that you can
    /// use to deploy a model to an endpoint. In the inference component settings, you specify
    /// the model, the endpoint, and how the model utilizes the resources that the endpoint
    /// hosts. You can optimize resource utilization by tailoring how the required CPU cores,
    /// accelerators, and memory are allocated. You can deploy multiple inference components
    /// to an endpoint, where each inference component contains one model and the resource
    /// utilization needs for that individual model. After you deploy an inference component,
    /// you can directly invoke the associated model when you use the InvokeEndpoint API action.
    /// </summary>
    public partial class CreateInferenceComponentRequest : AmazonSageMakerRequest
    {
        private string _endpointName;
        private string _inferenceComponentName;
        private InferenceComponentRuntimeConfig _runtimeConfig;
        private InferenceComponentSpecification _specification;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an existing endpoint where you host the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// A unique name to assign to the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string InferenceComponentName
        {
            get { return this._inferenceComponentName; }
            set { this._inferenceComponentName = value; }
        }

        // Check to see if InferenceComponentName property is set
        internal bool IsSetInferenceComponentName()
        {
            return this._inferenceComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeConfig. 
        /// <para>
        /// Runtime settings for a model that is deployed with an inference component.
        /// </para>
        /// </summary>
        public InferenceComponentRuntimeConfig RuntimeConfig
        {
            get { return this._runtimeConfig; }
            set { this._runtimeConfig = value; }
        }

        // Check to see if RuntimeConfig property is set
        internal bool IsSetRuntimeConfig()
        {
            return this._runtimeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// Details about the resources to deploy with this inference component, including the
        /// model, container, and compute resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceComponentSpecification Specification
        {
            get { return this._specification; }
            set { this._specification = value; }
        }

        // Check to see if Specification property is set
        internal bool IsSetSpecification()
        {
            return this._specification != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs associated with the model. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of an existing production variant where you host the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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