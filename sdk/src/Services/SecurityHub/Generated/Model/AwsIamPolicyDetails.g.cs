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
    /// Represents an IAM permissions policy.
    /// </summary>
    public partial class AwsIamPolicyDetails
    {
        /// <summary>
        /// Gets and sets the property AttachmentCount. 
        /// <para>
        /// The number of users, groups, and roles that the policy is attached to.
        /// </para>
        /// </summary>
        public int? AttachmentCount { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentCount property is set.
        /// </summary>
        internal bool IsSetAttachmentCount() => this.AttachmentCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// When the policy was created.
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
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The identifier of the default version of the policy.
        /// </para>
        /// </summary>
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersionId property is set.
        /// </summary>
        internal bool IsSetDefaultVersionId() => this.DefaultVersionId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the policy.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsAttachable. 
        /// <para>
        /// Whether the policy can be attached to a user, group, or role.
        /// </para>
        /// </summary>
        public bool? IsAttachable { get; set; }

        /// <summary>
        /// Checks to see if the IsAttachable property is set.
        /// </summary>
        internal bool IsSetIsAttachable() => this.IsAttachable.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the policy.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryUsageCount. 
        /// <para>
        /// The number of users and roles that use the policy to set the permissions boundary.
        /// </para>
        /// </summary>
        public int? PermissionsBoundaryUsageCount { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundaryUsageCount property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundaryUsageCount() => this.PermissionsBoundaryUsageCount.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier of the policy.
        /// </para>
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyVersionList. 
        /// <para>
        /// List of versions of the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamPolicyVersion> PolicyVersionList { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsIamPolicyVersion>() : null;

        /// <summary>
        /// Checks to see if the PolicyVersionList property is set.
        /// </summary>
        internal bool IsSetPolicyVersionList() => this.PolicyVersionList != null && (this.PolicyVersionList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// When the policy was most recently updated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string UpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDate property is set.
        /// </summary>
        internal bool IsSetUpdateDate() => this.UpdateDate != null;
    }
}
