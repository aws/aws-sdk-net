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
    /// Container for the parameters to the CreateSubscriptionRequest operation.
    /// Creates a subscription request in Amazon DataZone.
    /// </summary>
    public partial class CreateSubscriptionRequestRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _domainIdentifier;
        private List<FormInput> _metadataForms = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;
        private string _requestReason;
        private List<SubscribedListingInput> _subscribedListings = AWSConfigs.InitializeCollections ? new List<SubscribedListingInput>() : null;
        private List<SubscribedPrincipalInput> _subscribedPrincipals = AWSConfigs.InitializeCollections ? new List<SubscribedPrincipalInput>() : null;

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
        /// The ID of the Amazon DataZone domain in which the subscription request is created.
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
        /// Gets and sets the property MetadataForms. 
        /// <para>
        /// The metadata form included in the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormInput> MetadataForms
        {
            get { return this._metadataForms; }
            set { this._metadataForms = value; }
        }

        // Check to see if MetadataForms property is set
        internal bool IsSetMetadataForms()
        {
            return this._metadataForms != null && (this._metadataForms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestReason. 
        /// <para>
        /// The reason for the subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string RequestReason
        {
            get { return this._requestReason; }
            set { this._requestReason = value; }
        }

        // Check to see if RequestReason property is set
        internal bool IsSetRequestReason()
        {
            return this._requestReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedListings. 
        /// <para>
        /// The published asset for which the subscription grant is to be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SubscribedListingInput> SubscribedListings
        {
            get { return this._subscribedListings; }
            set { this._subscribedListings = value; }
        }

        // Check to see if SubscribedListings property is set
        internal bool IsSetSubscribedListings()
        {
            return this._subscribedListings != null && (this._subscribedListings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscribedPrincipals. 
        /// <para>
        /// The Amazon DataZone principals for whom the subscription request is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SubscribedPrincipalInput> SubscribedPrincipals
        {
            get { return this._subscribedPrincipals; }
            set { this._subscribedPrincipals = value; }
        }

        // Check to see if SubscribedPrincipals property is set
        internal bool IsSetSubscribedPrincipals()
        {
            return this._subscribedPrincipals != null && (this._subscribedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}