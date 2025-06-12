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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the CreateSubscriptionGrant operation.
    /// Creates a subsscription grant in Amazon DataZone.
    /// </summary>
    public partial class CreateSubscriptionGrantRequest : AmazonDataZoneRequest
    {
        private List<AssetTargetNameMap> _assetTargetNames = AWSConfigs.InitializeCollections ? new List<AssetTargetNameMap>() : null;
        private string _clientToken;
        private string _domainIdentifier;
        private string _environmentIdentifier;
        private GrantedEntityInput _grantedEntity;
        private string _subscriptionTargetIdentifier;

        /// <summary>
        /// Gets and sets the property AssetTargetNames. 
        /// <para>
        /// The names of the assets for which the subscription grant is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetTargetNameMap> AssetTargetNames
        {
            get { return this._assetTargetNames; }
            set { this._assetTargetNames = value; }
        }

        // Check to see if AssetTargetNames property is set
        internal bool IsSetAssetTargetNames()
        {
            return this._assetTargetNames != null && (this._assetTargetNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment in which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GrantedEntity. 
        /// <para>
        /// The entity to which the subscription is to be granted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GrantedEntityInput GrantedEntity
        {
            get { return this._grantedEntity; }
            set { this._grantedEntity = value; }
        }

        // Check to see if GrantedEntity property is set
        internal bool IsSetGrantedEntity()
        {
            return this._grantedEntity != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionTargetIdentifier. 
        /// <para>
        /// The ID of the subscription target for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string SubscriptionTargetIdentifier
        {
            get { return this._subscriptionTargetIdentifier; }
            set { this._subscriptionTargetIdentifier = value; }
        }

        // Check to see if SubscriptionTargetIdentifier property is set
        internal bool IsSetSubscriptionTargetIdentifier()
        {
            return this._subscriptionTargetIdentifier != null;
        }

    }
}