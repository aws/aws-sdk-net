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
    /// Container for the parameters to the AcceptSubscriptionRequest operation.
    /// Accepts a subscription request to a specific asset.
    /// </summary>
    public partial class AcceptSubscriptionRequestRequest : AmazonDataZoneRequest
    {
        private List<AcceptedAssetScope> _assetScopes = AWSConfigs.InitializeCollections ? new List<AcceptedAssetScope>() : null;
        private string _decisionComment;
        private string _domainIdentifier;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property AssetScopes. 
        /// <para>
        /// The asset scopes of the accept subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AcceptedAssetScope> AssetScopes
        {
            get { return this._assetScopes; }
            set { this._assetScopes = value; }
        }

        // Check to see if AssetScopes property is set
        internal bool IsSetAssetScopes()
        {
            return this._assetScopes != null && (this._assetScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DecisionComment. 
        /// <para>
        /// A description that specifies the reason for accepting the specified subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string DecisionComment
        {
            get { return this._decisionComment; }
            set { this._decisionComment = value; }
        }

        // Check to see if DecisionComment property is set
        internal bool IsSetDecisionComment()
        {
            return this._decisionComment != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The Amazon DataZone domain where the specified subscription request is being accepted.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the subscription request that is to be accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}