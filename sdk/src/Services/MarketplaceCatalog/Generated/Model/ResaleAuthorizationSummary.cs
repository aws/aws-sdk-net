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
    /// Summarized information about a Resale Authorization.
    /// </summary>
    public partial class ResaleAuthorizationSummary
    {
        private string _availabilityEndDate;
        private string _createdDate;
        private string _manufacturerAccountId;
        private string _manufacturerLegalName;
        private string _name;
        private string _offerExtendedStatus;
        private string _productId;
        private string _productName;
        private string _resellerAccountID;
        private string _resellerLegalName;
        private ResaleAuthorizationStatusString _status;

        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// The availability end date of the ResaleAuthorization.
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The created date of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property ManufacturerAccountId. 
        /// <para>
        /// The manufacturer account ID of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ManufacturerAccountId
        {
            get { return this._manufacturerAccountId; }
            set { this._manufacturerAccountId = value; }
        }

        // Check to see if ManufacturerAccountId property is set
        internal bool IsSetManufacturerAccountId()
        {
            return this._manufacturerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ManufacturerLegalName. 
        /// <para>
        /// The manufacturer legal name of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ManufacturerLegalName
        {
            get { return this._manufacturerLegalName; }
            set { this._manufacturerLegalName = value; }
        }

        // Check to see if ManufacturerLegalName property is set
        internal bool IsSetManufacturerLegalName()
        {
            return this._manufacturerLegalName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property OfferExtendedStatus. 
        /// <para>
        /// The offer extended status of the ResaleAuthorization
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OfferExtendedStatus
        {
            get { return this._offerExtendedStatus; }
            set { this._offerExtendedStatus = value; }
        }

        // Check to see if OfferExtendedStatus property is set
        internal bool IsSetOfferExtendedStatus()
        {
            return this._offerExtendedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product ID of the ResaleAuthorization.
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
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The product name of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property ResellerAccountID. 
        /// <para>
        /// The reseller account ID of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ResellerAccountID
        {
            get { return this._resellerAccountID; }
            set { this._resellerAccountID = value; }
        }

        // Check to see if ResellerAccountID property is set
        internal bool IsSetResellerAccountID()
        {
            return this._resellerAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property ResellerLegalName. 
        /// <para>
        /// The reseller legal name of the ResaleAuthorization
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ResellerLegalName
        {
            get { return this._resellerLegalName; }
            set { this._resellerLegalName = value; }
        }

        // Check to see if ResellerLegalName property is set
        internal bool IsSetResellerLegalName()
        {
            return this._resellerLegalName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationStatusString Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}