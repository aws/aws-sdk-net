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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCapacityProvider operation.
    /// Creates a capacity provider that manages compute resources for Lambda functions
    /// </summary>
    public partial class CreateCapacityProviderRequest : AmazonLambdaRequest
    {
        private string _capacityProviderName;
        private CapacityProviderScalingConfig _capacityProviderScalingConfig;
        private InstanceRequirements _instanceRequirements;
        private string _kmsKeyArn;
        private CapacityProviderPermissionsConfig _permissionsConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CapacityProviderVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The name of the capacity provider. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string CapacityProviderName
        {
            get { return this._capacityProviderName; }
            set { this._capacityProviderName = value; }
        }

        // Check to see if CapacityProviderName property is set
        internal bool IsSetCapacityProviderName()
        {
            return this._capacityProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderScalingConfig. 
        /// <para>
        /// The scaling configuration that defines how the capacity provider scales compute instances,
        /// including maximum vCPU count and scaling policies.
        /// </para>
        /// </summary>
        public CapacityProviderScalingConfig CapacityProviderScalingConfig
        {
            get { return this._capacityProviderScalingConfig; }
            set { this._capacityProviderScalingConfig = value; }
        }

        // Check to see if CapacityProviderScalingConfig property is set
        internal bool IsSetCapacityProviderScalingConfig()
        {
            return this._capacityProviderScalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance requirements that specify the compute instance characteristics, including
        /// architectures and allowed or excluded instance types.
        /// </para>
        /// </summary>
        public InstanceRequirements InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key used to encrypt data associated with the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsConfig. 
        /// <para>
        /// The permissions configuration that specifies the IAM role ARN used by the capacity
        /// provider to manage compute resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityProviderPermissionsConfig PermissionsConfig
        {
            get { return this._permissionsConfig; }
            set { this._permissionsConfig = value; }
        }

        // Check to see if PermissionsConfig property is set
        internal bool IsSetPermissionsConfig()
        {
            return this._permissionsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the capacity provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the capacity provider, including subnet IDs and security
        /// group IDs where compute instances will be launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityProviderVpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}