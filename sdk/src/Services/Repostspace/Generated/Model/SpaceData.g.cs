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
    /// A structure that contains some information about a private re:Post in the account.
    /// </summary>
    public partial class SpaceData
    {
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
        /// The description for the private re:Post. This is used only to help you identify this
        /// private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the private re:Post.
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
        /// The AWS generated subdomain of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RandomDomain { get; set; }

        /// <summary>
        /// Checks to see if the RandomDomain property is set.
        /// </summary>
        internal bool IsSetRandomDomain() => this.RandomDomain != null;

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
        /// The creation/deletion status of the private re:Post.
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
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of onboarded users to the private re:Post.
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
        /// This custom subdomain that you use to access your private re:Post. All custom subdomains
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
        /// This approval status of the custom subdomain.
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
