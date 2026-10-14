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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the DescribeInstance operation.
    /// </summary>
    public partial class DescribeInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the instance was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfigurationDetails. 
        /// <para>
        /// Contains the encryption configuration for your IAM Identity Center instance, including
        /// the encryption status, KMS key type, and KMS key ARN.
        /// </para>
        /// </summary>
        public EncryptionConfigurationDetails EncryptionConfigurationDetails { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfigurationDetails property is set.
        /// </summary>
        internal bool IsSetEncryptionConfigurationDetails() => this.EncryptionConfigurationDetails != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreArn. 
        /// <para>
        /// The ARN of the identity store that is connected to the instance of IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 62, Max = 93)]
        public string IdentityStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreArn property is set.
        /// </summary>
        internal bool IsSetIdentityStoreArn() => this.IdentityStoreArn != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The identifier of the identity store that is connected to the instance of IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance of IAM Identity Center under which the operation will run.
        /// For more information about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account for which the instance was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property PermissionSetsEnabled. 
        /// <para>
        /// Indicates whether permission sets are enabled for this Identity Center instance.
        /// </para>
        /// </summary>
        public bool? PermissionSetsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PermissionSetsEnabled property is set.
        /// </summary>
        internal bool IsSetPermissionSetsEnabled() => this.PermissionSetsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The primary Region where the IAM Identity Center instance was originally enabled.
        /// The primary Region cannot be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryRegion property is set.
        /// </summary>
        internal bool IsSetPrimaryRegion() => this.PrimaryRegion != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The list of Regions enabled in the IAM Identity Center instance, including Regions
        /// with ACTIVE, ADDING, or REMOVING status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionMetadata> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionMetadata>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the instance. 
        /// </para>
        /// </summary>
        public InstanceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Provides additional context about the current status of the IAM Identity Center instance.
        /// This field is particularly useful when an instance is in a non-ACTIVE state, such
        /// as CREATE_FAILED. When an instance fails to create or update, this field contains
        /// information about the cause, which may include issues with KMS key configuration,
        /// permission problems with the specified KMS key, or service-related errors. 
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
