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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Summarized information about an offer.
    /// </summary>
    public partial class OfferSummary
    {
        private string _availabilityEndDate;
        private List<string> _buyerAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _productId;
        private string _releaseDate;
        private string _resaleAuthorizationId;
        private OfferStateString _state;
        private List<string> _targeting = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// The availability end date of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string AvailabilityEndDate
        {
            get { return this._availabilityEndDate; }
            set { this._availabilityEndDate = value; }
        }

        // Check to see if AvailabilityEndDate property is set
        internal bool IsSetAvailabilityEndDate()
        {
            return this._availabilityEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property BuyerAccounts. 
        /// <para>
        /// The buyer accounts in the offer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=26)]
        public List<string> BuyerAccounts
        {
            get { return this._buyerAccounts; }
            set { this._buyerAccounts = value; }
        }

        // Check to see if BuyerAccounts property is set
        internal bool IsSetBuyerAccounts()
        {
            return this._buyerAccounts != null && (this._buyerAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product ID of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The release date of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate != null;
        }

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationId. 
        /// <para>
        /// The ResaleAuthorizationId of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ResaleAuthorizationId
        {
            get { return this._resaleAuthorizationId; }
            set { this._resaleAuthorizationId = value; }
        }

        // Check to see if ResaleAuthorizationId property is set
        internal bool IsSetResaleAuthorizationId()
        {
            return this._resaleAuthorizationId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the offer.
        /// </para>
        /// </summary>
        public OfferStateString State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Targeting. 
        /// <para>
        /// The targeting in the offer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public List<string> Targeting
        {
            get { return this._targeting; }
            set { this._targeting = value; }
        }

        // Check to see if Targeting property is set
        internal bool IsSetTargeting()
        {
            return this._targeting != null && (this._targeting.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}