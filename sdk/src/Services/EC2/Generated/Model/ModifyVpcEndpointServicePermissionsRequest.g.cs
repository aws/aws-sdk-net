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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpcEndpointServicePermissions operation.
    /// Modifies the permissions for your VPC endpoint service. You can add or remove permissions
    /// for service consumers (Amazon Web Services accounts, users, and IAM roles) to connect
    /// to your endpoint service. Principal ARNs with path components aren't supported. <para>
    /// If you grant permissions to all principals, the service is public. Any users who know
    /// the name of a public service can send a request to attach an endpoint. If the service
    /// does not require manual approval, attachments are automatically approved. </para>
    /// <para> By default, principals that you grant permissions to can create VPC endpoints
    /// that connect to your endpoint service. For Gateway Load Balancer endpoint services,
    /// you can instead grant permissions so that principals can create transit gateway attachments
    /// that connect to your endpoint service. To do so, specify <c>transit-gateway-attachment</c>
    /// for <c>PermissionType</c>. The two permission types are independent. A principal can
    /// have either or both. </para>
    /// </summary>
    public partial class ModifyVpcEndpointServicePermissionsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddAllowedPrincipals. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the principals. Permissions are granted to the
        /// principals in this list. To grant permissions to all principals, specify an asterisk
        /// (*).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddAllowedPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddAllowedPrincipals property is set.
        /// </summary>
        internal bool IsSetAddAllowedPrincipals() => this.AddAllowedPrincipals != null && (this.AddAllowedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// The type of permission to add or remove. The permission type applies to all principals
        /// in <c>AddAllowedPrincipals</c> and <c>RemoveAllowedPrincipals</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>vpc-endpoint</c> - Principals can create VPC endpoints that connect to the endpoint
        /// service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-attachment</c> - Principals can create transit gateway attachments
        /// that connect to the endpoint service. This permission type is supported only for Gateway
        /// Load Balancer endpoint services. You can grant it only to Amazon Web Services accounts
        /// (<c>arn:aws:iam::account-id:root</c>). You can't grant it to users, IAM roles, organizations,
        /// organizational units, or all principals (*).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>vpc-endpoint</c> 
        /// </para>
        /// </summary>
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property RemoveAllowedPrincipals. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the principals. Permissions are revoked for principals
        /// in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveAllowedPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveAllowedPrincipals property is set.
        /// </summary>
        internal bool IsSetRemoveAllowedPrincipals() => this.RemoveAllowedPrincipals != null && (this.RemoveAllowedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;
    }
}
