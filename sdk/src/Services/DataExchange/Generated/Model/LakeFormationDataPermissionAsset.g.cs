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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The AWS Lake Formation data permission asset.
    /// </summary>
    public partial class LakeFormationDataPermissionAsset
    {
        /// <summary>
        /// Gets and sets the property LakeFormationDataPermissionDetails. 
        /// <para>
        /// Details about the AWS Lake Formation data permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LakeFormationDataPermissionDetails LakeFormationDataPermissionDetails { get; set; }

        /// <summary>
        /// Checks to see if the LakeFormationDataPermissionDetails property is set.
        /// </summary>
        internal bool IsSetLakeFormationDataPermissionDetails() => this.LakeFormationDataPermissionDetails != null;

        /// <summary>
        /// Gets and sets the property LakeFormationDataPermissionType. 
        /// <para>
        /// The data permission type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LakeFormationDataPermissionType LakeFormationDataPermissionType { get; set; }

        /// <summary>
        /// Checks to see if the LakeFormationDataPermissionType property is set.
        /// </summary>
        internal bool IsSetLakeFormationDataPermissionType() => this.LakeFormationDataPermissionType != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to the subscribers on the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role's ARN that allows AWS Data Exchange to assume the role and grant and
        /// revoke permissions to AWS Lake Formation data permissions.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
