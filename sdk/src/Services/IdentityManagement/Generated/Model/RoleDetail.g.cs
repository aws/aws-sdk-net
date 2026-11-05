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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an IAM role, including all of the role's policies.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountAuthorizationDetails.html">GetAccountAuthorizationDetails</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class RoleDetail
    {
        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// A list of managed policies attached to the role. These policies are the role's access
        /// (permissions) policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachedPolicyType> AttachedManagedPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachedPolicyType>() : null;

        /// <summary>
        /// Checks to see if the AttachedManagedPolicies property is set.
        /// </summary>
        internal bool IsSetAttachedManagedPolicies() => this.AttachedManagedPolicies != null && (this.AttachedManagedPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the role was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceProfileList. 
        /// <para>
        /// A list of instance profiles that contain this role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceProfile> InstanceProfileList { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceProfile>() : null;

        /// <summary>
        /// Checks to see if the InstanceProfileList property is set.
        /// </summary>
        internal bool IsSetInstanceProfileList() => this.InstanceProfileList != null && (this.InstanceProfileList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the role. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property PermissionsBoundary. 
        /// <para>
        /// The ARN of the policy used to set the permissions boundary for the role.
        /// </para>
        ///  
        /// <para>
        /// For more information about permissions boundaries, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
        /// boundaries for IAM identities </a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public AttachedPermissionsBoundary PermissionsBoundary { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundary property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundary() => this.PermissionsBoundary != null;

        /// <summary>
        /// Gets and sets the property RoleId. 
        /// <para>
        /// The stable and unique string identifying the role. For more information about IDs,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 128)]
        public string RoleId { get; set; }

        /// <summary>
        /// Checks to see if the RoleId property is set.
        /// </summary>
        internal bool IsSetRoleId() => this.RoleId != null;

        /// <summary>
        /// Gets and sets the property RoleLastUsed. 
        /// <para>
        /// Contains information about the last time that an IAM role was used. This includes
        /// the date and time and the Region in which the role was last used. Activity is only
        /// reported for the trailing 400 days. This period can be shorter if your Region began
        /// supporting these features within the last year. The role might have been used more
        /// than 400 days ago. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// where data is tracked</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public RoleLastUsed RoleLastUsed { get; set; }

        /// <summary>
        /// Checks to see if the RoleLastUsed property is set.
        /// </summary>
        internal bool IsSetRoleLastUsed() => this.RoleLastUsed != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The friendly name that identifies the role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

        /// <summary>
        /// Gets and sets the property RolePolicyList. 
        /// <para>
        /// A list of inline policies embedded in the role. These policies are the role's access
        /// (permissions) policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyDetail> RolePolicyList { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyDetail>() : null;

        /// <summary>
        /// Checks to see if the RolePolicyList property is set.
        /// </summary>
        internal bool IsSetRolePolicyList() => this.RolePolicyList != null && (this.RolePolicyList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are attached to the role. For more information about tagging,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
