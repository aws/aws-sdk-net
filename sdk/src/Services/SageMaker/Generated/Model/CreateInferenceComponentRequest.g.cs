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
    /// Container for the parameters to the CreateInferenceComponent operation. Creates an
    /// inference component, which is a SageMaker AI hosting object that you can use to deploy
    /// a model to an endpoint. In the inference component settings, you specify the model,
    /// the endpoint, and how the model utilizes the resources that the endpoint hosts. You
    /// can optimize resource utilization by tailoring how the required CPU cores, accelerators,
    /// and memory are allocated. You can deploy multiple inference components to an endpoint,
    /// where each inference component contains one model and the resource utilization needs
    /// for that individual model. After you deploy an inference component, you can directly
    /// invoke the associated model when you use the InvokeEndpoint API action.
    /// </summary>
    public partial class CreateInferenceComponentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an existing endpoint where you host the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// A unique name to assign to the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string InferenceComponentName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceComponentName property is set.
        /// </summary>
        internal bool IsSetInferenceComponentName() => this.InferenceComponentName != null;

        /// <summary>
        /// Gets and sets the property RuntimeConfig. 
        /// <para>
        /// Runtime settings for a model that is deployed with an inference component.
        /// </para>
        /// </summary>
        public InferenceComponentRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeConfig property is set.
        /// </summary>
        internal bool IsSetRuntimeConfig() => this.RuntimeConfig != null;

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// Details about the resources to deploy with this inference component, including the
        /// model, container, and compute resources.
        /// </para>
        /// </summary>
        public InferenceComponentSpecification Specification { get; set; }

        /// <summary>
        /// Checks to see if the Specification property is set.
        /// </summary>
        internal bool IsSetSpecification() => this.Specification != null;

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// A list of specification objects for the inference component, one per instance type.
        /// Use this parameter when you want to deploy a different model or resource configuration
        /// for the inference component on each instance type. You can use either this parameter
        /// or the singular <c>Specification</c> parameter, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<InferenceComponentSpecification> Specifications { get; set; } = AWSConfigs.InitializeCollections ? new List<InferenceComponentSpecification>() : null;

        /// <summary>
        /// Checks to see if the Specifications property is set.
        /// </summary>
        internal bool IsSetSpecifications() => this.Specifications != null && (this.Specifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs associated with the model. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of an existing production variant where you host the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;
    }
}
