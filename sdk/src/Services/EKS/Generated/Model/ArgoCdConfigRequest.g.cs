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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Configuration settings for an Argo CD capability. This includes the Kubernetes namespace,
    /// IAM Identity CenterIAM; Identity Center integration, RBAC role mappings, and network
    /// access configuration.
    /// </summary>
    public partial class ArgoCdConfigRequest
    {
        /// <summary>
        /// Gets and sets the property AwsIdc. 
        /// <para>
        /// Configuration for IAM Identity CenterIAM; Identity Center integration. When configured,
        /// users can authenticate to Argo CD using their IAM Identity CenterIAM; Identity Center
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ArgoCdAwsIdcConfigRequest AwsIdc { get; set; }

        /// <summary>
        /// Checks to see if the AwsIdc property is set.
        /// </summary>
        internal bool IsSetAwsIdc() => this.AwsIdc != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Kubernetes namespace where Argo CD resources will be created. If not specified,
        /// the default namespace is used.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NetworkAccess. 
        /// <para>
        /// Configuration for network access to the Argo CD capability's managed API server endpoint.
        /// By default, the Argo CD server is accessible via a public endpoint. You can optionally
        /// specify one or more VPC endpoint IDs to enable private connectivity from your VPCs.
        /// When VPC endpoints are configured, public access is blocked and the Argo CD server
        /// is only accessible through the specified VPC endpoints.
        /// </para>
        /// </summary>
        public ArgoCdNetworkAccessConfigRequest NetworkAccess { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccess property is set.
        /// </summary>
        internal bool IsSetNetworkAccess() => this.NetworkAccess != null;

        /// <summary>
        /// Gets and sets the property RbacRoleMappings. 
        /// <para>
        /// A list of role mappings that define which IAM Identity CenterIAM; Identity Center
        /// users or groups have which Argo CD roles. Each mapping associates an Argo CD role
        /// (<c>ADMIN</c>, <c>EDITOR</c>, or <c>VIEWER</c>) with one or more IAM Identity CenterIAM;
        /// Identity Center identities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArgoCdRoleMapping> RbacRoleMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<ArgoCdRoleMapping>() : null;

        /// <summary>
        /// Checks to see if the RbacRoleMappings property is set.
        /// </summary>
        internal bool IsSetRbacRoleMappings() => this.RbacRoleMappings != null && (this.RbacRoleMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
