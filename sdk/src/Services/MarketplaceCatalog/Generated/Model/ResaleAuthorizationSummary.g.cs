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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Summarized information about a Resale Authorization.
    /// </summary>
    public partial class ResaleAuthorizationSummary
    {
        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// The availability end date of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string AvailabilityEndDate { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityEndDate property is set.
        /// </summary>
        internal bool IsSetAvailabilityEndDate() => this.AvailabilityEndDate != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The created date of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property IssuerAccountId. 
        /// <para>
        /// The issuer account ID of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string IssuerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the IssuerAccountId property is set.
        /// </summary>
        internal bool IsSetIssuerAccountId() => this.IssuerAccountId != null;

        /// <summary>
        /// Gets and sets the property ManufacturerAccountId. 
        /// <para>
        /// The manufacturer account ID of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ManufacturerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ManufacturerAccountId property is set.
        /// </summary>
        internal bool IsSetManufacturerAccountId() => this.ManufacturerAccountId != null;

        /// <summary>
        /// Gets and sets the property ManufacturerLegalName. 
        /// <para>
        /// The manufacturer legal name of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ManufacturerLegalName { get; set; }

        /// <summary>
        /// Checks to see if the ManufacturerLegalName property is set.
        /// </summary>
        internal bool IsSetManufacturerLegalName() => this.ManufacturerLegalName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OfferExtendedStatus. 
        /// <para>
        /// The offer extended status of the ResaleAuthorization
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OfferExtendedStatus { get; set; }

        /// <summary>
        /// Checks to see if the OfferExtendedStatus property is set.
        /// </summary>
        internal bool IsSetOfferExtendedStatus() => this.OfferExtendedStatus != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product ID of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The product name of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ResellerAccountID. 
        /// <para>
        /// The reseller account ID of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ResellerAccountID { get; set; }

        /// <summary>
        /// Checks to see if the ResellerAccountID property is set.
        /// </summary>
        internal bool IsSetResellerAccountID() => this.ResellerAccountID != null;

        /// <summary>
        /// Gets and sets the property ResellerLegalName. 
        /// <para>
        /// The reseller legal name of the ResaleAuthorization
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResellerLegalName { get; set; }

        /// <summary>
        /// Checks to see if the ResellerLegalName property is set.
        /// </summary>
        internal bool IsSetResellerLegalName() => this.ResellerLegalName != null;

        /// <summary>
        /// Gets and sets the property ResellerRole. 
        /// <para>
        /// The reseller role of the ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationResellerRoleString ResellerRole { get; set; }

        /// <summary>
        /// Checks to see if the ResellerRole property is set.
        /// </summary>
        internal bool IsSetResellerRole() => this.ResellerRole != null;

        /// <summary>
        /// Gets and sets the property SourceAuthorization. 
        /// <para>
        /// The source authorization of the ResaleAuthorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SourceAuthorization { get; set; }

        /// <summary>
        /// Checks to see if the SourceAuthorization property is set.
        /// </summary>
        internal bool IsSetSourceAuthorization() => this.SourceAuthorization != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ResaleAuthorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationStatusString Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
