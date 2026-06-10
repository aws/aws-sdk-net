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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Summary information about a quote.
    /// </summary>
    public partial class QuoteSummary
    {
        private string _accountId;
        private string _countryCode;
        private DateTime? _createdDate;
        private string _description;
        private DateTime? _expirationDate;
        private string _outpostArn;
        private string _quoteId;
        private List<QuoteOption> _quoteOptions = AWSConfigs.InitializeCollections ? new List<QuoteOption>() : null;
        private QuoteStatus _quoteStatus;
        private List<QuoteCapacity> _requestedCapacities = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;
        private List<QuoteConstraint> _requestedConstraints = AWSConfigs.InitializeCollections ? new List<QuoteConstraint>() : null;
        private List<string> _requestedPaymentOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _requestedPaymentTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _statusMessage;
        private string _submittedOrderId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account that owns the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the Outpost site location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the quote was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date the quote expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost associated with the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteId. 
        /// <para>
        /// The ID of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string QuoteId
        {
            get { return this._quoteId; }
            set { this._quoteId = value; }
        }

        // Check to see if QuoteId property is set
        internal bool IsSetQuoteId()
        {
            return this._quoteId != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteOptions. 
        /// <para>
        /// The configuration and pricing options for the quote.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<QuoteOption> QuoteOptions
        {
            get { return this._quoteOptions; }
            set { this._quoteOptions = value; }
        }

        // Check to see if QuoteOptions property is set
        internal bool IsSetQuoteOptions()
        {
            return this._quoteOptions != null && (this._quoteOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuoteStatus. 
        /// <para>
        /// The status of the quote.
        /// </para>
        /// </summary>
        public QuoteStatus QuoteStatus
        {
            get { return this._quoteStatus; }
            set { this._quoteStatus = value; }
        }

        // Check to see if QuoteStatus property is set
        internal bool IsSetQuoteStatus()
        {
            return this._quoteStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedCapacities. 
        /// <para>
        /// The capacity requirements specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<QuoteCapacity> RequestedCapacities
        {
            get { return this._requestedCapacities; }
            set { this._requestedCapacities = value; }
        }

        // Check to see if RequestedCapacities property is set
        internal bool IsSetRequestedCapacities()
        {
            return this._requestedCapacities != null && (this._requestedCapacities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestedConstraints. 
        /// <para>
        /// The physical constraints specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<QuoteConstraint> RequestedConstraints
        {
            get { return this._requestedConstraints; }
            set { this._requestedConstraints = value; }
        }

        // Check to see if RequestedConstraints property is set
        internal bool IsSetRequestedConstraints()
        {
            return this._requestedConstraints != null && (this._requestedConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestedPaymentOptions. 
        /// <para>
        /// The payment options specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> RequestedPaymentOptions
        {
            get { return this._requestedPaymentOptions; }
            set { this._requestedPaymentOptions = value; }
        }

        // Check to see if RequestedPaymentOptions property is set
        internal bool IsSetRequestedPaymentOptions()
        {
            return this._requestedPaymentOptions != null && (this._requestedPaymentOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestedPaymentTerms. 
        /// <para>
        /// The payment terms specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> RequestedPaymentTerms
        {
            get { return this._requestedPaymentTerms; }
            set { this._requestedPaymentTerms = value; }
        }

        // Check to see if RequestedPaymentTerms property is set
        internal bool IsSetRequestedPaymentTerms()
        {
            return this._requestedPaymentTerms != null && (this._requestedPaymentTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the status of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedOrderId. 
        /// <para>
        /// The ID of the order submitted for the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string SubmittedOrderId
        {
            get { return this._submittedOrderId; }
            set { this._submittedOrderId = value; }
        }

        // Check to see if SubmittedOrderId property is set
        internal bool IsSetSubmittedOrderId()
        {
            return this._submittedOrderId != null;
        }

    }
}