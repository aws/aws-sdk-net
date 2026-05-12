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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// The <c>ChargeSummary</c> provides a detailed breakdown of charges that are associated
    /// with an agreement request. This is applicable only when a request is created for a
    /// <c>PurchaseAgreement</c>.
    /// 
    ///  <note> 
    /// <para>
    /// Tax and invoicing fields (such as <c>estimatedTaxes</c>, <c>amountAfterTax</c>, <c>newAgreementValueAfterTax</c>,
    /// and <c>invoicingEntity</c>) are returned on a best-effort basis and do not cause the
    /// request to fail if unavailable.
    /// </para>
    ///  
    /// <para>
    /// A <c>null</c> tax amount can have two meanings:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tax estimation was unavailable at the time of the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The charge timing is <c>BILLING_PERIOD</c>, so the charge amount is not determined
    /// at request time. In this case, the tax breakdown may still include the tax <c>rate</c>
    /// and <c>type</c>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ChargeSummary
    {
        private string _currencyCode;
        private EstimatedTaxes _estimatedTaxes;
        private List<ExpectedCharge> _expectedCharges = AWSConfigs.InitializeCollections ? new List<ExpectedCharge>() : null;
        private InvoicingEntity _invoicingEntity;
        private List<ItemizedCharge> _itemizedCharges = AWSConfigs.InitializeCollections ? new List<ItemizedCharge>() : null;
        private string _newAgreementValue;
        private string _newAgreementValueAfterTax;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The three-letter currency code for all charges (e.g., USD).
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedTaxes. 
        /// <para>
        /// Provides an aggregated view of estimated tax information for the agreement.
        /// </para>
        /// </summary>
        public EstimatedTaxes EstimatedTaxes
        {
            get { return this._estimatedTaxes; }
            set { this._estimatedTaxes = value; }
        }

        // Check to see if EstimatedTaxes property is set
        internal bool IsSetEstimatedTaxes()
        {
            return this._estimatedTaxes != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedCharges. 
        /// <para>
        /// A list of expected charges for the agreement request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpectedCharge> ExpectedCharges
        {
            get { return this._expectedCharges; }
            set { this._expectedCharges = value; }
        }

        // Check to see if ExpectedCharges property is set
        internal bool IsSetExpectedCharges()
        {
            return this._expectedCharges != null && (this._expectedCharges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InvoicingEntity. 
        /// <para>
        /// The entity responsible for issuing the invoice.
        /// </para>
        /// </summary>
        public InvoicingEntity InvoicingEntity
        {
            get { return this._invoicingEntity; }
            set { this._invoicingEntity = value; }
        }

        // Check to see if InvoicingEntity property is set
        internal bool IsSetInvoicingEntity()
        {
            return this._invoicingEntity != null;
        }

        /// <summary>
        /// Gets and sets the property ItemizedCharges. 
        /// <para>
        /// An itemized list of charges for the agreement request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ItemizedCharge> ItemizedCharges
        {
            get { return this._itemizedCharges; }
            set { this._itemizedCharges = value; }
        }

        // Check to see if ItemizedCharges property is set
        internal bool IsSetItemizedCharges()
        {
            return this._itemizedCharges != null && (this._itemizedCharges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NewAgreementValue. 
        /// <para>
        /// The total value of the agreement, which includes any amendments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NewAgreementValue
        {
            get { return this._newAgreementValue; }
            set { this._newAgreementValue = value; }
        }

        // Check to see if NewAgreementValue property is set
        internal bool IsSetNewAgreementValue()
        {
            return this._newAgreementValue != null;
        }

        /// <summary>
        /// Gets and sets the property NewAgreementValueAfterTax. 
        /// <para>
        /// Expected new agreement value after estimated taxes are applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NewAgreementValueAfterTax
        {
            get { return this._newAgreementValueAfterTax; }
            set { this._newAgreementValueAfterTax = value; }
        }

        // Check to see if NewAgreementValueAfterTax property is set
        internal bool IsSetNewAgreementValueAfterTax()
        {
            return this._newAgreementValueAfterTax != null;
        }

    }
}