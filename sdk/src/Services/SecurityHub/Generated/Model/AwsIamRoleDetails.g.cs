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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about an IAM role, including all of the role's policies.
    /// </summary>
    public partial class AwsIamRoleDetails
    {
        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocument. 
        /// <para>
        /// The trust policy that grants permission to assume the role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string AssumeRolePolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the AssumeRolePolicyDocument property is set.
        /// </summary>
        internal bool IsSetAssumeRolePolicyDocument() => this.AssumeRolePolicyDocument != null;

        /// <summary>
        /// Gets and sets the property AttachedManagedPolicies. 
        /// <para>
        /// The list of the managed policies that are attached to the role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamAttachedManagedPolicy> AttachedManagedPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsIamAttachedManagedPolicy>() : null;

        /// <summary>
        /// Checks to see if the AttachedManagedPolicies property is set.
        /// </summary>
        internal bool IsSetAttachedManagedPolicies() => this.AttachedManagedPolicies != null && (this.AttachedManagedPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the role was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileList. 
        /// <para>
        /// The list of instance profiles that contain this role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamInstanceProfile> InstanceProfileList { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsIamInstanceProfile>() : null;

        /// <summary>
        /// Checks to see if the InstanceProfileList property is set.
        /// </summary>
        internal bool IsSetInstanceProfileList() => this.InstanceProfileList != null && (this.InstanceProfileList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) that you want to set for the specified role.
        /// </para>
        /// </summary>
        public int? MaxSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxSessionDuration property is set.
        /// </summary>
        internal bool IsSetMaxSessionDuration() => this.MaxSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the role.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property PermissionsBoundary.
        /// </summary>
        public AwsIamPermissionsBoundary PermissionsBoundary { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundary property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundary() => this.PermissionsBoundary != null;

        /// <summary>
        /// Gets and sets the property RoleId. 
        /// <para>
        /// The stable and unique string identifying the role.
        /// </para>
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// Checks to see if the RoleId property is set.
        /// </summary>
        internal bool IsSetRoleId() => this.RoleId != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The friendly name that identifies the role.
        /// </para>
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

        /// <summary>
        /// Gets and sets the property RolePolicyList. 
        /// <para>
        /// The list of inline policies that are embedded in the role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamRolePolicy> RolePolicyList { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsIamRolePolicy>() : null;

        /// <summary>
        /// Checks to see if the RolePolicyList property is set.
        /// </summary>
        internal bool IsSetRolePolicyList() => this.RolePolicyList != null && (this.RolePolicyList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
