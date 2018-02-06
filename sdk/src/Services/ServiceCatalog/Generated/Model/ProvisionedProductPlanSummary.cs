/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Summary information about a plan.
    /// </summary>
    public partial class ProvisionedProductPlanSummary
    {
        private string _planId;
        private string _planName;
        private ProvisionedProductPlanType _planType;
        private string _provisioningArtifactId;
        private string _provisionProductId;
        private string _provisionProductName;

        /// <summary>
        /// Gets and sets the property PlanId. 
        /// <para>
        /// The plan identifier.
        /// </para>
        /// </summary>
        public string PlanId
        {
            get { return this._planId; }
            set { this._planId = value; }
        }

        // Check to see if PlanId property is set
        internal bool IsSetPlanId()
        {
            return this._planId != null;
        }

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the plan.
        /// </para>
        /// </summary>
        public string PlanName
        {
            get { return this._planName; }
            set { this._planName = value; }
        }

        // Check to see if PlanName property is set
        internal bool IsSetPlanName()
        {
            return this._planName != null;
        }

        /// <summary>
        /// Gets and sets the property PlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        public ProvisionedProductPlanType PlanType
        {
            get { return this._planType; }
            set { this._planType = value; }
        }

        // Check to see if PlanType property is set
        internal bool IsSetPlanType()
        {
            return this._planType != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        public string ProvisionProductId
        {
            get { return this._provisionProductId; }
            set { this._provisionProductId = value; }
        }

        // Check to see if ProvisionProductId property is set
        internal bool IsSetProvisionProductId()
        {
            return this._provisionProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        public string ProvisionProductName
        {
            get { return this._provisionProductName; }
            set { this._provisionProductName = value; }
        }

        // Check to see if ProvisionProductName property is set
        internal bool IsSetProvisionProductName()
        {
            return this._provisionProductName != null;
        }

    }
}