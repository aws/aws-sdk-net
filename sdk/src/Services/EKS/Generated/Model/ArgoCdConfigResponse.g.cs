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
    /// The response object containing Argo CD configuration details, including the server
    /// URL that you use to access the Argo CD web interface and API.
    /// </summary>
    public partial class ArgoCdConfigResponse
    {
        /// <summary>
        /// Gets and sets the property AwsIdc. 
        /// <para>
        /// The IAM Identity CenterIAM; Identity Center integration configuration.
        /// </para>
        /// </summary>
        public ArgoCdAwsIdcConfigResponse AwsIdc { get; set; }

        /// <summary>
        /// Checks to see if the AwsIdc property is set.
        /// </summary>
        internal bool IsSetAwsIdc() => this.AwsIdc != null;

        /// <summary>
        /// Gets and sets the property EndpointPrefix. 
        /// <para>
        /// The prefix that was configured for the hostname of the Argo CD server endpoint when
        /// the capability was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string EndpointPrefix { get; set; }

        /// <summary>
        /// Checks to see if the EndpointPrefix property is set.
        /// </summary>
        internal bool IsSetEndpointPrefix() => this.EndpointPrefix != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Kubernetes namespace where Argo CD resources are monitored by your Argo CD Capability.
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
        /// The network access configuration for the Argo CD capability's managed API server endpoint.
        /// If VPC endpoint IDs are specified, public access is blocked and the Argo CD server
        /// is only accessible through the specified VPC endpoints.
        /// </para>
        /// </summary>
        public ArgoCdNetworkAccessConfigResponse NetworkAccess { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccess property is set.
        /// </summary>
        internal bool IsSetNetworkAccess() => this.NetworkAccess != null;

        /// <summary>
        /// Gets and sets the property RbacRoleMappings. 
        /// <para>
        /// The list of role mappings that define which IAM Identity CenterIAM; Identity Center
        /// users or groups have which Argo CD roles.
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

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The URL of the Argo CD server. Use this URL to access the Argo CD web interface and
        /// API.
        /// </para>
        /// </summary>
        public string ServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServerUrl property is set.
        /// </summary>
        internal bool IsSetServerUrl() => this.ServerUrl != null;
    }
}
