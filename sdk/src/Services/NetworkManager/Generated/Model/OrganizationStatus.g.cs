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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// The status of an Amazon Web Services Organization and the accounts within that organization.
    /// </summary>
    public partial class OrganizationStatus
    {
        /// <summary>
        /// Gets and sets the property AccountStatusList. 
        /// <para>
        /// The current service-linked role (SLR) deployment status for an Amazon Web Services
        /// Organization's accounts. This will be either <c>SUCCEEDED</c> or <c>IN_PROGRESS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountStatus> AccountStatusList { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountStatus>() : null;

        /// <summary>
        /// Checks to see if the AccountStatusList property is set.
        /// </summary>
        internal bool IsSetAccountStatusList() => this.AccountStatusList != null && (this.AccountStatusList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationAwsServiceAccessStatus. 
        /// <para>
        /// The status of the organization's AWS service access. This will be <c>ENABLED</c> or
        /// <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string OrganizationAwsServiceAccessStatus { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationAwsServiceAccessStatus property is set.
        /// </summary>
        internal bool IsSetOrganizationAwsServiceAccessStatus() => this.OrganizationAwsServiceAccessStatus != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of an Amazon Web Services Organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property SLRDeploymentStatus. 
        /// <para>
        /// The status of the SLR deployment for the account. This will be either <c>SUCCEEDED</c>
        /// or <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string SLRDeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the SLRDeploymentStatus property is set.
        /// </summary>
        internal bool IsSetSLRDeploymentStatus() => this.SLRDeploymentStatus != null;
    }
}
