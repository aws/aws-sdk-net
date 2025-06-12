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
    /// The production variant summary for a deployment when an endpoint is creating or updating
    /// with the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
    /// or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpoint.html">UpdateEndpoint</a>
    /// operations. Describes the <c>VariantStatus </c>, weight and capacity for a production
    /// variant associated with an endpoint.
    /// </summary>
    public partial class PendingProductionVariantSummary
    {
        private ProductionVariantAcceleratorType _acceleratorType;
        private int? _currentInstanceCount;
        private ProductionVariantServerlessConfig _currentServerlessConfig;
        private float? _currentWeight;
        private List<DeployedImage> _deployedImages = AWSConfigs.InitializeCollections ? new List<DeployedImage>() : null;
        private int? _desiredInstanceCount;
        private ProductionVariantServerlessConfig _desiredServerlessConfig;
        private float? _desiredWeight;
        private ProductionVariantInstanceType _instanceType;
        private ProductionVariantManagedInstanceScaling _managedInstanceScaling;
        private ProductionVariantRoutingConfig _routingConfig;
        private string _variantName;
        private List<ProductionVariantStatus> _variantStatus = AWSConfigs.InitializeCollections ? new List<ProductionVariantStatus>() : null;

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
        public ProductionVariantAcceleratorType AcceleratorType
        {
            get { return this._acceleratorType; }
            set { this._acceleratorType = value; }
        }

        // Check to see if AcceleratorType property is set
        internal bool IsSetAcceleratorType()
        {
            return this._acceleratorType != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentInstanceCount. 
        /// <para>
        /// The number of instances associated with the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentInstanceCount
        {
            get { return this._currentInstanceCount; }
            set { this._currentInstanceCount = value; }
        }

        // Check to see if CurrentInstanceCount property is set
        internal bool IsSetCurrentInstanceCount()
        {
            return this._currentInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentServerlessConfig. 
        /// <para>
        /// The serverless configuration for the endpoint.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessConfig CurrentServerlessConfig
        {
            get { return this._currentServerlessConfig; }
            set { this._currentServerlessConfig = value; }
        }

        // Check to see if CurrentServerlessConfig property is set
        internal bool IsSetCurrentServerlessConfig()
        {
            return this._currentServerlessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentWeight. 
        /// <para>
        /// The weight associated with the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float? CurrentWeight
        {
            get { return this._currentWeight; }
            set { this._currentWeight = value; }
        }

        // Check to see if CurrentWeight property is set
        internal bool IsSetCurrentWeight()
        {
            return this._currentWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeployedImages. 
        /// <para>
        /// An array of <c>DeployedImage</c> objects that specify the Amazon EC2 Container Registry
        /// paths of the inference images deployed on instances of this <c>ProductionVariant</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeployedImage> DeployedImages
        {
            get { return this._deployedImages; }
            set { this._deployedImages = value; }
        }

        // Check to see if DeployedImages property is set
        internal bool IsSetDeployedImages()
        {
            return this._deployedImages != null && (this._deployedImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DesiredInstanceCount. 
        /// <para>
        /// The number of instances requested in this deployment, as specified in the endpoint
        /// configuration for the endpoint. The value is taken from the request to the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DesiredInstanceCount
        {
            get { return this._desiredInstanceCount; }
            set { this._desiredInstanceCount = value; }
        }

        // Check to see if DesiredInstanceCount property is set
        internal bool IsSetDesiredInstanceCount()
        {
            return this._desiredInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredServerlessConfig. 
        /// <para>
        /// The serverless configuration requested for this deployment, as specified in the endpoint
        /// configuration for the endpoint.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessConfig DesiredServerlessConfig
        {
            get { return this._desiredServerlessConfig; }
            set { this._desiredServerlessConfig = value; }
        }

        // Check to see if DesiredServerlessConfig property is set
        internal bool IsSetDesiredServerlessConfig()
        {
            return this._desiredServerlessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredWeight. 
        /// <para>
        /// The requested weight for the variant in this deployment, as specified in the endpoint
        /// configuration for the endpoint. The value is taken from the request to the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float? DesiredWeight
        {
            get { return this._desiredWeight; }
            set { this._desiredWeight = value; }
        }

        // Check to see if DesiredWeight property is set
        internal bool IsSetDesiredWeight()
        {
            return this._desiredWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instances associated with the variant.
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
        /// Gets and sets the property ManagedInstanceScaling. 
        /// <para>
        /// Settings that control the range in the number of instances that the endpoint provisions
        /// as it scales up or down to accommodate traffic. 
        /// </para>
        /// </summary>
        public ProductionVariantManagedInstanceScaling ManagedInstanceScaling
        {
            get { return this._managedInstanceScaling; }
            set { this._managedInstanceScaling = value; }
        }

        // Check to see if ManagedInstanceScaling property is set
        internal bool IsSetManagedInstanceScaling()
        {
            return this._managedInstanceScaling != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// Settings that control how the endpoint routes incoming traffic to the instances that
        /// the endpoint hosts.
        /// </para>
        /// </summary>
        public ProductionVariantRoutingConfig RoutingConfig
        {
            get { return this._routingConfig; }
            set { this._routingConfig = value; }
        }

        // Check to see if RoutingConfig property is set
        internal bool IsSetRoutingConfig()
        {
            return this._routingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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

        /// <summary>
        /// Gets and sets the property VariantStatus. 
        /// <para>
        /// The endpoint variant status which describes the current deployment stage status or
        /// operational status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<ProductionVariantStatus> VariantStatus
        {
            get { return this._variantStatus; }
            set { this._variantStatus = value; }
        }

        // Check to see if VariantStatus property is set
        internal bool IsSetVariantStatus()
        {
            return this._variantStatus != null && (this._variantStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}