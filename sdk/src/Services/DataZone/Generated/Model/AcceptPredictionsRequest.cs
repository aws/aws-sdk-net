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
    /// Container for the parameters to the AcceptPredictions operation.
    /// Accepts automatically generated business-friendly metadata for your Amazon DataZone
    /// assets.
    /// </summary>
    public partial class AcceptPredictionsRequest : AmazonDataZoneRequest
    {
        private List<AcceptChoice> _acceptChoices = AWSConfigs.InitializeCollections ? new List<AcceptChoice>() : null;
        private AcceptRule _acceptRule;
        private string _clientToken;
        private string _domainIdentifier;
        private string _identifier;
        private string _revision;

        /// <summary>
        /// Gets and sets the property AcceptChoices. 
        /// <para>
        /// Specifies the prediction (aka, the automatically generated piece of metadata) and
        /// the target (for example, a column name) that can be accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AcceptChoice> AcceptChoices
        {
            get { return this._acceptChoices; }
            set { this._acceptChoices = value; }
        }

        // Check to see if AcceptChoices property is set
        internal bool IsSetAcceptChoices()
        {
            return this._acceptChoices != null && (this._acceptChoices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AcceptRule. 
        /// <para>
        /// Specifies the rule (or the conditions) under which a prediction can be accepted.
        /// </para>
        /// </summary>
        public AcceptRule AcceptRule
        {
            get { return this._acceptRule; }
            set { this._acceptRule = value; }
        }

        // Check to see if AcceptRule property is set
        internal bool IsSetAcceptRule()
        {
            return this._acceptRule != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The identifier of the Amazon DataZone domain.
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
        /// The identifier of the asset.
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

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision that is to be made to the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}