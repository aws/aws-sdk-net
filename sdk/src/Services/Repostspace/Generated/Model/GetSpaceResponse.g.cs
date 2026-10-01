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

namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// This is the response object from the GetSpace operation.
    /// </summary>
    public partial class GetSpaceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The Identity Center identifier for the Application Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationStatus. 
        /// <para>
        /// The configuration status of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationStatus ConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetConfigurationStatus() => this.ConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property ContentSize. 
        /// <para>
        /// The content size of the private re:Post.
        /// </para>
        /// </summary>
        public long? ContentSize { get; set; }

        /// <summary>
        /// Checks to see if the ContentSize property is set.
        /// </summary>
        internal bool IsSetContentSize() => this.ContentSize.HasValue;

        /// <summary>
        /// Gets and sets the property CreateDateTime. 
        /// <para>
        /// The date when the private re:Post was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateDateTime property is set.
        /// </summary>
        internal bool IsSetCreateDateTime() => this.CreateDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to the private re:Post to convert unanswered
        /// questions into AWS support tickets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomerRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerRoleArn property is set.
        /// </summary>
        internal bool IsSetCustomerRoleArn() => this.CustomerRoleArn != null;

        /// <summary>
        /// Gets and sets the property DeleteDateTime. 
        /// <para>
        /// The date when the private re:Post was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteDateTime { get; set; }

        /// <summary>
        /// Checks to see if the DeleteDateTime property is set.
        /// </summary>
        internal bool IsSetDeleteDateTime() => this.DeleteDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GroupAdmins. 
        /// <para>
        /// The list of groups that are administrators of the private re:Post.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property has been depracted and will be replaced by the roles property.")]
        public List<string> GroupAdmins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GroupAdmins property is set.
        /// </summary>
        internal bool IsSetGroupAdmins() => this.GroupAdmins != null && (this.GroupAdmins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdentityStoreId.
        /// </summary>
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 30)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RandomDomain. 
        /// <para>
        /// The AWS generated subdomain of the private re:Post
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RandomDomain { get; set; }

        /// <summary>
        /// Checks to see if the RandomDomain property is set.
        /// </summary>
        internal bool IsSetRandomDomain() => this.RandomDomain != null;

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// A map of accessor identifiers and their roles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Roles { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Roles property is set.
        /// </summary>
        internal bool IsSetRoles() => this.Roles != null && (this.Roles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The creation or deletion status of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageLimit. 
        /// <para>
        /// The storage limit of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StorageLimit { get; set; }

        /// <summary>
        /// Checks to see if the StorageLimit property is set.
        /// </summary>
        internal bool IsSetStorageLimit() => this.StorageLimit.HasValue;

        /// <summary>
        /// Gets and sets the property SupportedEmailDomains.
        /// </summary>
        public SupportedEmailDomainsStatus SupportedEmailDomains { get; set; }

        /// <summary>
        /// Checks to see if the SupportedEmailDomains property is set.
        /// </summary>
        internal bool IsSetSupportedEmailDomains() => this.SupportedEmailDomains != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The pricing tier of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TierLevel Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property UserAdmins. 
        /// <para>
        /// The list of users that are administrators of the private re:Post.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property has been depracted and will be replaced by the roles property.")]
        public List<string> UserAdmins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserAdmins property is set.
        /// </summary>
        internal bool IsSetUserAdmins() => this.UserAdmins != null && (this.UserAdmins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users that have onboarded to the private re:Post.
        /// </para>
        /// </summary>
        public int? UserCount { get; set; }

        /// <summary>
        /// Checks to see if the UserCount property is set.
        /// </summary>
        internal bool IsSetUserCount() => this.UserCount.HasValue;

        /// <summary>
        /// Gets and sets the property UserKMSKey. 
        /// <para>
        /// The custom AWS KMS key ARN that’s used for the AWS KMS encryption.
        /// </para>
        /// </summary>
        public string UserKMSKey { get; set; }

        /// <summary>
        /// Checks to see if the UserKMSKey property is set.
        /// </summary>
        internal bool IsSetUserKMSKey() => this.UserKMSKey != null;

        /// <summary>
        /// Gets and sets the property VanityDomain. 
        /// <para>
        /// The custom subdomain that you use to access your private re:Post. All custom subdomains
        /// must be approved by AWS before use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VanityDomain { get; set; }

        /// <summary>
        /// Checks to see if the VanityDomain property is set.
        /// </summary>
        internal bool IsSetVanityDomain() => this.VanityDomain != null;

        /// <summary>
        /// Gets and sets the property VanityDomainStatus. 
        /// <para>
        /// The approval status of the custom subdomain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VanityDomainStatus VanityDomainStatus { get; set; }

        /// <summary>
        /// Checks to see if the VanityDomainStatus property is set.
        /// </summary>
        internal bool IsSetVanityDomainStatus() => this.VanityDomainStatus != null;
    }
}
