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
    /// Container for the parameters to the AcceptSubscriptionRequest operation. Accepts a
    /// subscription request to a specific asset.
    /// </summary>
    public partial class AcceptSubscriptionRequestRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetPermissions. 
        /// <para>
        /// The asset permissions of the accept subscription request.
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
        /// The asset scopes of the accept subscription request.
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
        /// Gets and sets the property DecisionComment. 
        /// <para>
        /// A description that specifies the reason for accepting the specified subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string DecisionComment { get; set; }

        /// <summary>
        /// Checks to see if the DecisionComment property is set.
        /// </summary>
        internal bool IsSetDecisionComment() => this.DecisionComment != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The Amazon DataZone domain where the specified subscription request is being accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the subscription request that is to be accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
