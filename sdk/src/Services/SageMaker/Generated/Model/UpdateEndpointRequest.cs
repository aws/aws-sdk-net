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
    /// Container for the parameters to the UpdateEndpoint operation.
    /// Deploys the <c>EndpointConfig</c> specified in the request to a new fleet of instances.
    /// SageMaker shifts endpoint traffic to the new instances with the updated endpoint configuration
    /// and then deletes the old instances using the previous <c>EndpointConfig</c> (there
    /// is no availability loss). For more information about how to control the update and
    /// traffic shifting process, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/deployment-guardrails.html">
    /// Update models in production</a>.
    /// 
    ///  
    /// <para>
    /// When SageMaker receives the request, it sets the endpoint status to <c>Updating</c>.
    /// After updating the endpoint, it sets the status to <c>InService</c>. To check the
    /// status of an endpoint, use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html">DescribeEndpoint</a>
    /// API. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You must not delete an <c>EndpointConfig</c> in use by an endpoint that is live or
    /// while the <c>UpdateEndpoint</c> or <c>CreateEndpoint</c> operations are being performed
    /// on the endpoint. To update an endpoint, you must create a new <c>EndpointConfig</c>.
    /// </para>
    ///  
    /// <para>
    /// If you delete the <c>EndpointConfig</c> of an endpoint that is active or being created
    /// or updated you may lose visibility into the instance type the endpoint is using. The
    /// endpoint must be deleted in order to stop incurring charges.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateEndpointRequest : AmazonSageMakerRequest
    {
        private DeploymentConfig _deploymentConfig;
        private string _endpointConfigName;
        private string _endpointName;
        private List<VariantProperty> _excludeRetainedVariantProperties = AWSConfigs.InitializeCollections ? new List<VariantProperty>() : null;
        private bool? _retainAllVariantProperties;
        private bool? _retainDeploymentConfig;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration for an endpoint, which contains the desired deployment
        /// strategy and rollback configurations.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the new endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string EndpointConfigName
        {
            get { return this._endpointConfigName; }
            set { this._endpointConfigName = value; }
        }

        // Check to see if EndpointConfigName property is set
        internal bool IsSetEndpointConfigName()
        {
            return this._endpointConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint whose configuration you want to update.
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
        /// Gets and sets the property ExcludeRetainedVariantProperties. 
        /// <para>
        /// When you are updating endpoint resources with <c>RetainAllVariantProperties</c>, whose
        /// value is set to <c>true</c>, <c>ExcludeRetainedVariantProperties</c> specifies the
        /// list of type <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VariantProperty.html">VariantProperty</a>
        /// to override with the values provided by <c>EndpointConfig</c>. If you don't specify
        /// a value for <c>ExcludeRetainedVariantProperties</c>, no variant properties are overridden.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<VariantProperty> ExcludeRetainedVariantProperties
        {
            get { return this._excludeRetainedVariantProperties; }
            set { this._excludeRetainedVariantProperties = value; }
        }

        // Check to see if ExcludeRetainedVariantProperties property is set
        internal bool IsSetExcludeRetainedVariantProperties()
        {
            return this._excludeRetainedVariantProperties != null && (this._excludeRetainedVariantProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetainAllVariantProperties. 
        /// <para>
        /// When updating endpoint resources, enables or disables the retention of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VariantProperty.html">variant
        /// properties</a>, such as the instance count or the variant weight. To retain the variant
        /// properties of an endpoint when updating it, set <c>RetainAllVariantProperties</c>
        /// to <c>true</c>. To use the variant properties specified in a new <c>EndpointConfig</c>
        /// call when updating an endpoint, set <c>RetainAllVariantProperties</c> to <c>false</c>.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? RetainAllVariantProperties
        {
            get { return this._retainAllVariantProperties; }
            set { this._retainAllVariantProperties = value; }
        }

        // Check to see if RetainAllVariantProperties property is set
        internal bool IsSetRetainAllVariantProperties()
        {
            return this._retainAllVariantProperties.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetainDeploymentConfig. 
        /// <para>
        /// Specifies whether to reuse the last deployment configuration. The default value is
        /// false (the configuration is not reused).
        /// </para>
        /// </summary>
        public bool? RetainDeploymentConfig
        {
            get { return this._retainDeploymentConfig; }
            set { this._retainDeploymentConfig = value; }
        }

        // Check to see if RetainDeploymentConfig property is set
        internal bool IsSetRetainDeploymentConfig()
        {
            return this._retainDeploymentConfig.HasValue; 
        }

    }
}