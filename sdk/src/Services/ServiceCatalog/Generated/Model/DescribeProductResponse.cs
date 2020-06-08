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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeProduct operation.
    /// </summary>
    public partial class DescribeProductResponse : AmazonWebServiceResponse
    {
        private List<BudgetDetail> _budgets = new List<BudgetDetail>();
        private List<LaunchPath> _launchPaths = new List<LaunchPath>();
        private ProductViewSummary _productViewSummary;
        private List<ProvisioningArtifact> _provisioningArtifacts = new List<ProvisioningArtifact>();

        /// <summary>
        /// Gets and sets the property Budgets. 
        /// <para>
        /// Information about the associated budgets.
        /// </para>
        /// </summary>
        public List<BudgetDetail> Budgets
        {
            get { return this._budgets; }
            set { this._budgets = value; }
        }

        // Check to see if Budgets property is set
        internal bool IsSetBudgets()
        {
            return this._budgets != null && this._budgets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchPaths. 
        /// <para>
        /// Information about the associated launch paths.
        /// </para>
        /// </summary>
        public List<LaunchPath> LaunchPaths
        {
            get { return this._launchPaths; }
            set { this._launchPaths = value; }
        }

        // Check to see if LaunchPaths property is set
        internal bool IsSetLaunchPaths()
        {
            return this._launchPaths != null && this._launchPaths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductViewSummary. 
        /// <para>
        /// Summary information about the product view.
        /// </para>
        /// </summary>
        public ProductViewSummary ProductViewSummary
        {
            get { return this._productViewSummary; }
            set { this._productViewSummary = value; }
        }

        // Check to see if ProductViewSummary property is set
        internal bool IsSetProductViewSummary()
        {
            return this._productViewSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifacts. 
        /// <para>
        /// Information about the provisioning artifacts for the specified product.
        /// </para>
        /// </summary>
        public List<ProvisioningArtifact> ProvisioningArtifacts
        {
            get { return this._provisioningArtifacts; }
            set { this._provisioningArtifacts = value; }
        }

        // Check to see if ProvisioningArtifacts property is set
        internal bool IsSetProvisioningArtifacts()
        {
            return this._provisioningArtifacts != null && this._provisioningArtifacts.Count > 0; 
        }

    }
}