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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriptionRequest operation. Creates a
    /// subscription request in Amazon DataZone.
    /// </summary>
    public partial class CreateSubscriptionRequestRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetPermissions. 
        /// <para>
        /// The asset permissions of the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetPermission> AssetPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetPermission>() : null;

        /// <summary>
        /// Checks to see if the AssetPermissions property is set.
        /// </summary>
        internal bool IsSetAssetPermissions() => this.AssetPermissions != null && (this.AssetPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetScopes. 
        /// <para>
        /// The asset scopes of the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AcceptedAssetScope> AssetScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<AcceptedAssetScope>() : null;

        /// <summary>
        /// Checks to see if the AssetScopes property is set.
        /// </summary>
        internal bool IsSetAssetScopes() => this.AssetScopes != null && (this.AssetScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the subscription request is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property MetadataForms. 
        /// <para>
        /// The metadata form included in the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormInput> MetadataForms { get; set; } = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;

        /// <summary>
        /// Checks to see if the MetadataForms property is set.
        /// </summary>
        internal bool IsSetMetadataForms() => this.MetadataForms != null && (this.MetadataForms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestReason. 
        /// <para>
        /// The reason for the subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public string RequestReason { get; set; }

        /// <summary>
        /// Checks to see if the RequestReason property is set.
        /// </summary>
        internal bool IsSetRequestReason() => this.RequestReason != null;

        /// <summary>
        /// Gets and sets the property SubscribedListings. 
        /// <para>
        /// The published asset for which the subscription grant is to be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<SubscribedListingInput> SubscribedListings { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscribedListingInput>() : null;

        /// <summary>
        /// Checks to see if the SubscribedListings property is set.
        /// </summary>
        internal bool IsSetSubscribedListings() => this.SubscribedListings != null && (this.SubscribedListings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscribedPrincipals. 
        /// <para>
        /// The Amazon DataZone principals for whom the subscription request is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<SubscribedPrincipalInput> SubscribedPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscribedPrincipalInput>() : null;

        /// <summary>
        /// Checks to see if the SubscribedPrincipals property is set.
        /// </summary>
        internal bool IsSetSubscribedPrincipals() => this.SubscribedPrincipals != null && (this.SubscribedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
