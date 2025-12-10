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
    /// A capacity provider manages compute resources for Lambda functions.
    /// </summary>
    public partial class CapacityProvider
    {
        private string _capacityProviderArn;
        private CapacityProviderScalingConfig _capacityProviderScalingConfig;
        private InstanceRequirements _instanceRequirements;
        private string _kmsKeyArn;
        private string _lastModified;
        private CapacityProviderPermissionsConfig _permissionsConfig;
        private CapacityProviderState _state;
        private CapacityProviderVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string CapacityProviderArn
        {
            get { return this._capacityProviderArn; }
            set { this._capacityProviderArn = value; }
        }

        // Check to see if CapacityProviderArn property is set
        internal bool IsSetCapacityProviderArn()
        {
            return this._capacityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderScalingConfig. 
        /// <para>
        /// The scaling configuration for the capacity provider.
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
        /// The instance requirements for compute resources managed by the capacity provider.
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
        /// The ARN of the KMS key used to encrypt the capacity provider's resources.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time when the capacity provider was last modified.
        /// </para>
        /// </summary>
        public string LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsConfig. 
        /// <para>
        /// The permissions configuration for the capacity provider.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityProviderState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the capacity provider.
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