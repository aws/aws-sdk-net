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
    /// Container for the parameters to the CreateSubscriptionGrant operation. Creates a subsscription
    /// grant in Amazon DataZone.
    /// </summary>
    public partial class CreateSubscriptionGrantRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetTargetNames. 
        /// <para>
        /// The names of the assets for which the subscription grant is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetTargetNameMap> AssetTargetNames { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetTargetNameMap>() : null;

        /// <summary>
        /// Checks to see if the AssetTargetNames property is set.
        /// </summary>
        internal bool IsSetAssetTargetNames() => this.AssetTargetNames != null && (this.AssetTargetNames.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The ID of the Amazon DataZone domain in which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment in which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property GrantedEntity. 
        /// <para>
        /// The entity to which the subscription is to be granted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GrantedEntityInput GrantedEntity { get; set; }

        /// <summary>
        /// Checks to see if the GrantedEntity property is set.
        /// </summary>
        internal bool IsSetGrantedEntity() => this.GrantedEntity != null;

        /// <summary>
        /// Gets and sets the property SubscriptionTargetIdentifier. 
        /// <para>
        /// The ID of the subscription target for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string SubscriptionTargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionTargetIdentifier property is set.
        /// </summary>
        internal bool IsSetSubscriptionTargetIdentifier() => this.SubscriptionTargetIdentifier != null;
    }
}
