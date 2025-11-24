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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The control plane scaling tier configuration. For more information, see EKS Provisioned
    /// Control Plane in the Amazon EKS User Guide.
    /// </summary>
    public partial class ControlPlaneScalingConfig
    {
        private ProvisionedControlPlaneTier _tier;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The control plane scaling tier configuration. Available options are <c>standard</c>,
        /// <c>tier-xl</c>, <c>tier-2xl</c>, or <c>tier-4xl</c>. For more information, see EKS
        /// Provisioned Control Plane in the Amazon EKS User Guide.
        /// </para>
        /// </summary>
        public ProvisionedControlPlaneTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}