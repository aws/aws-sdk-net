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
    /// This is the response object from the DescribeProduct operation.
    /// </summary>
    public partial class DescribeProductResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Budgets. 
        /// <para>
        /// Information about the associated budgets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BudgetDetail> Budgets { get; set; } = AWSConfigs.InitializeCollections ? new List<BudgetDetail>() : null;

        /// <summary>
        /// Checks to see if the Budgets property is set.
        /// </summary>
        internal bool IsSetBudgets() => this.Budgets != null && (this.Budgets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchPaths. 
        /// <para>
        /// Information about the associated launch paths.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchPath> LaunchPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchPath>() : null;

        /// <summary>
        /// Checks to see if the LaunchPaths property is set.
        /// </summary>
        internal bool IsSetLaunchPaths() => this.LaunchPaths != null && (this.LaunchPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductViewSummary. 
        /// <para>
        /// Summary information about the product view.
        /// </para>
        /// </summary>
        public ProductViewSummary ProductViewSummary { get; set; }

        /// <summary>
        /// Checks to see if the ProductViewSummary property is set.
        /// </summary>
        internal bool IsSetProductViewSummary() => this.ProductViewSummary != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifacts. 
        /// <para>
        /// Information about the provisioning artifacts for the specified product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisioningArtifact> ProvisioningArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifact>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningArtifacts property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifacts() => this.ProvisioningArtifacts != null && (this.ProvisioningArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
