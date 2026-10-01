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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOrder operation. Creates an order for an
    /// Outpost.
    /// </summary>
    public partial class CreateOrderRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property LineItems. 
        /// <para>
        /// The line items that make up the order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<LineItemRequest> LineItems { get; set; } = AWSConfigs.InitializeCollections ? new List<LineItemRequest>() : null;

        /// <summary>
        /// Checks to see if the LineItems property is set.
        /// </summary>
        internal bool IsSetLineItems() => this.LineItems != null && (this.LineItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        ///  The ID or the Amazon Resource Name (ARN) of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment terms.
        /// </para>
        /// </summary>
        public PaymentTerm PaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the PaymentTerm property is set.
        /// </summary>
        internal bool IsSetPaymentTerm() => this.PaymentTerm != null;

        /// <summary>
        /// Gets and sets the property QuoteIdentifier. 
        /// <para>
        /// The ID of the quote to use for the order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string QuoteIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QuoteIdentifier property is set.
        /// </summary>
        internal bool IsSetQuoteIdentifier() => this.QuoteIdentifier != null;

        /// <summary>
        /// Gets and sets the property QuoteOptionIdentifier. 
        /// <para>
        /// The ID of the quote option to use for the order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 21)]
        public string QuoteOptionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QuoteOptionIdentifier property is set.
        /// </summary>
        internal bool IsSetQuoteOptionIdentifier() => this.QuoteOptionIdentifier != null;
    }
}
