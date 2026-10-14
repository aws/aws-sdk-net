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
    /// The production variant summary for a deployment when an endpoint is creating or updating
    /// with the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
    /// or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpoint.html">UpdateEndpoint</a>
    /// operations. Describes the <c>VariantStatus </c>, weight and capacity for a production
    /// variant associated with an endpoint.
    /// </summary>
    public partial class PendingProductionVariantSummary
    {
        /// <summary>
        /// Gets and sets the property AcceleratorType. 
        /// <para>
        /// This parameter is no longer supported. Elastic Inference (EI) is no longer available.
        /// </para>
        ///  
        /// <para>
        /// This parameter was used to specify the size of the EI instance to use for the production
        /// variant.
        /// </para>
        /// </summary>
        public ProductionVariantAcceleratorType AcceleratorType { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorType property is set.
        /// </summary>
        internal bool IsSetAcceleratorType() => this.AcceleratorType != null;

        /// <summary>
        /// Gets and sets the property CurrentInstanceCount. 
        /// <para>
        /// The number of instances associated with the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInstanceCount property is set.
        /// </summary>
        internal bool IsSetCurrentInstanceCount() => this.CurrentInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentServerlessConfig. 
        /// <para>
        /// The serverless configuration for the endpoint.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessConfig CurrentServerlessConfig { get; set; }

        /// <summary>
        /// Checks to see if the CurrentServerlessConfig property is set.
        /// </summary>
        internal bool IsSetCurrentServerlessConfig() => this.CurrentServerlessConfig != null;

        /// <summary>
        /// Gets and sets the property CurrentWeight. 
        /// <para>
        /// The weight associated with the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? CurrentWeight { get; set; }

        /// <summary>
        /// Checks to see if the CurrentWeight property is set.
        /// </summary>
        internal bool IsSetCurrentWeight() => this.CurrentWeight.HasValue;

        /// <summary>
        /// Gets and sets the property DeployedImages. 
        /// <para>
        /// An array of <c>DeployedImage</c> objects that specify the Amazon EC2 Container Registry
        /// paths of the inference images deployed on instances of this <c>ProductionVariant</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeployedImage> DeployedImages { get; set; } = AWSConfigs.InitializeCollections ? new List<DeployedImage>() : null;

        /// <summary>
        /// Checks to see if the DeployedImages property is set.
        /// </summary>
        internal bool IsSetDeployedImages() => this.DeployedImages != null && (this.DeployedImages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DesiredInstanceCount. 
        /// <para>
        /// The number of instances requested in this deployment, as specified in the endpoint
        /// configuration for the endpoint. The value is taken from the request to the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DesiredInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredInstanceCount property is set.
        /// </summary>
        internal bool IsSetDesiredInstanceCount() => this.DesiredInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredServerlessConfig. 
        /// <para>
        /// The serverless configuration requested for this deployment, as specified in the endpoint
        /// configuration for the endpoint.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessConfig DesiredServerlessConfig { get; set; }

        /// <summary>
        /// Checks to see if the DesiredServerlessConfig property is set.
        /// </summary>
        internal bool IsSetDesiredServerlessConfig() => this.DesiredServerlessConfig != null;

        /// <summary>
        /// Gets and sets the property DesiredWeight. 
        /// <para>
        /// The requested weight for the variant in this deployment, as specified in the endpoint
        /// configuration for the endpoint. The value is taken from the request to the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? DesiredWeight { get; set; }

        /// <summary>
        /// Checks to see if the DesiredWeight property is set.
        /// </summary>
        internal bool IsSetDesiredWeight() => this.DesiredWeight.HasValue;

        /// <summary>
        /// Gets and sets the property InstancePools. 
        /// <para>
        /// A list of instance pools for the production variant. Each pool indicates the instance
        /// type and the current number of instances of that type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<InstancePoolSummary> InstancePools { get; set; } = AWSConfigs.InitializeCollections ? new List<InstancePoolSummary>() : null;

        /// <summary>
        /// Checks to see if the InstancePools property is set.
        /// </summary>
        internal bool IsSetInstancePools() => this.InstancePools != null && (this.InstancePools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instances associated with the variant.
        /// </para>
        /// </summary>
        public ProductionVariantInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ManagedInstanceScaling. 
        /// <para>
        /// Settings that control the range in the number of instances that the endpoint provisions
        /// as it scales up or down to accommodate traffic. 
        /// </para>
        /// </summary>
        public ProductionVariantManagedInstanceScaling ManagedInstanceScaling { get; set; }

        /// <summary>
        /// Checks to see if the ManagedInstanceScaling property is set.
        /// </summary>
        internal bool IsSetManagedInstanceScaling() => this.ManagedInstanceScaling != null;

        /// <summary>
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// Settings that control how the endpoint routes incoming traffic to the instances that
        /// the endpoint hosts.
        /// </para>
        /// </summary>
        public ProductionVariantRoutingConfig RoutingConfig { get; set; }

        /// <summary>
        /// Checks to see if the RoutingConfig property is set.
        /// </summary>
        internal bool IsSetRoutingConfig() => this.RoutingConfig != null;

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;

        /// <summary>
        /// Gets and sets the property VariantStatus. 
        /// <para>
        /// The endpoint variant status which describes the current deployment stage status or
        /// operational status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<ProductionVariantStatus> VariantStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductionVariantStatus>() : null;

        /// <summary>
        /// Checks to see if the VariantStatus property is set.
        /// </summary>
        internal bool IsSetVariantStatus() => this.VariantStatus != null && (this.VariantStatus.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
