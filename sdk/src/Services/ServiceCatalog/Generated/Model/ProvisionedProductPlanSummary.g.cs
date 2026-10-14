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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Summary information about a plan.
    /// </summary>
    public partial class ProvisionedProductPlanSummary
    {
        /// <summary>
        /// Gets and sets the property PlanId. 
        /// <para>
        /// The plan identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PlanId { get; set; }

        /// <summary>
        /// Checks to see if the PlanId property is set.
        /// </summary>
        internal bool IsSetPlanId() => this.PlanId != null;

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the plan.
        /// </para>
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// Checks to see if the PlanName property is set.
        /// </summary>
        internal bool IsSetPlanName() => this.PlanName != null;

        /// <summary>
        /// Gets and sets the property PlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        public ProvisionedProductPlanType PlanType { get; set; }

        /// <summary>
        /// Checks to see if the PlanType property is set.
        /// </summary>
        internal bool IsSetPlanType() => this.PlanType != null;

        /// <summary>
        /// Gets and sets the property ProvisionProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisionProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionProductId property is set.
        /// </summary>
        internal bool IsSetProvisionProductId() => this.ProvisionProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisionProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProvisionProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionProductName property is set.
        /// </summary>
        internal bool IsSetProvisionProductName() => this.ProvisionProductName != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisioningArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactId property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactId() => this.ProvisioningArtifactId != null;
    }
}
