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
    /// Describes a Verified Access trust provider.
    /// </summary>
    public partial class VerifiedAccessTrustProvider
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access trust provider.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceOptions. 
        /// <para>
        /// The options for device-identity trust provider.
        /// </para>
        /// </summary>
        public DeviceOptions DeviceOptions { get; set; }

        /// <summary>
        /// Checks to see if the DeviceOptions property is set.
        /// </summary>
        internal bool IsSetDeviceOptions() => this.DeviceOptions != null;

        /// <summary>
        /// Gets and sets the property DeviceTrustProviderType. 
        /// <para>
        /// The type of device-based trust provider.
        /// </para>
        /// </summary>
        public DeviceTrustProviderType DeviceTrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTrustProviderType property is set.
        /// </summary>
        internal bool IsSetDeviceTrustProviderType() => this.DeviceTrustProviderType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property NativeApplicationOidcOptions. 
        /// <para>
        /// The OpenID Connect (OIDC) options.
        /// </para>
        /// </summary>
        public NativeApplicationOidcOptions NativeApplicationOidcOptions { get; set; }

        /// <summary>
        /// Checks to see if the NativeApplicationOidcOptions property is set.
        /// </summary>
        internal bool IsSetNativeApplicationOidcOptions() => this.NativeApplicationOidcOptions != null;

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The options for an OpenID Connect-compatible user-identity trust provider.
        /// </para>
        /// </summary>
        public OidcOptions OidcOptions { get; set; }

        /// <summary>
        /// Checks to see if the OidcOptions property is set.
        /// </summary>
        internal bool IsSetOidcOptions() => this.OidcOptions != null;

        /// <summary>
        /// Gets and sets the property PolicyReferenceName. 
        /// <para>
        /// The identifier to be used when working with policy rules.
        /// </para>
        /// </summary>
        public string PolicyReferenceName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyReferenceName property is set.
        /// </summary>
        internal bool IsSetPolicyReferenceName() => this.PolicyReferenceName != null;

        /// <summary>
        /// Gets and sets the property SseSpecification. 
        /// <para>
        /// The options in use for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationResponse SseSpecification { get; set; }

        /// <summary>
        /// Checks to see if the SseSpecification property is set.
        /// </summary>
        internal bool IsSetSseSpecification() => this.SseSpecification != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of Verified Access trust provider.
        /// </para>
        /// </summary>
        public TrustProviderType TrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the TrustProviderType property is set.
        /// </summary>
        internal bool IsSetTrustProviderType() => this.TrustProviderType != null;

        /// <summary>
        /// Gets and sets the property UserTrustProviderType. 
        /// <para>
        /// The type of user-based trust provider.
        /// </para>
        /// </summary>
        public UserTrustProviderType UserTrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the UserTrustProviderType property is set.
        /// </summary>
        internal bool IsSetUserTrustProviderType() => this.UserTrustProviderType != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access trust provider.
        /// </para>
        /// </summary>
        public string VerifiedAccessTrustProviderId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessTrustProviderId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessTrustProviderId() => this.VerifiedAccessTrustProviderId != null;
    }
}
