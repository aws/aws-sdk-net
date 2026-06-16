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
    /// Container for the parameters to the UpdateQuote operation.
    /// Updates the specified quote. You can modify the requested capacities, constraints,
    /// payment options, payment terms, or Outpost association.
    /// </summary>
    public partial class UpdateQuoteRequest : AmazonOutpostsRequest
    {
        private string _countryCode;
        private string _description;
        private string _outpostIdentifier;
        private string _quoteIdentifier;
        private List<QuoteCapacity> _requestedCapacities = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;
        private List<QuoteConstraint> _requestedConstraints = AWSConfigs.InitializeCollections ? new List<QuoteConstraint>() : null;
        private List<string> _requestedPaymentOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _requestedPaymentTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the quote.
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
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outpost to associate with the quote. Specify an empty string
        /// to remove the Outpost association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteIdentifier. 
        /// <para>
        /// The ID or ARN of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string QuoteIdentifier
        {
            get { return this._quoteIdentifier; }
            set { this._quoteIdentifier = value; }
        }

        // Check to see if QuoteIdentifier property is set
        internal bool IsSetQuoteIdentifier()
        {
            return this._quoteIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedCapacities. 
        /// <para>
        /// The updated capacity requirements for the quote.
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
        /// The updated physical constraints for the quote.
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
        /// The updated payment options to include in the quote pricing.
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
        /// The updated payment terms to include in the quote pricing.
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

    }
}