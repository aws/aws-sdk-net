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
    /// This is the response object from the GetOutpostBillingInformation operation.
    /// </summary>
    public partial class GetOutpostBillingInformationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContractEndDate. 
        /// <para>
        /// The date the current contract term ends for the specified Outpost. You must start
        /// the renewal or decommission process at least 5 business days before the current term
        /// for your Amazon Web Services Outposts ends. Failing to complete these steps at least
        /// 5 business days before the current term ends might result in unanticipated charges.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string ContractEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ContractEndDate property is set.
        /// </summary>
        internal bool IsSetContractEndDate() => this.ContractEndDate != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment term.
        /// </para>
        /// </summary>
        public PaymentTerm PaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the PaymentTerm property is set.
        /// </summary>
        internal bool IsSetPaymentTerm() => this.PaymentTerm != null;

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// The subscription details for the specified Outpost.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subscription> Subscriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<Subscription>() : null;

        /// <summary>
        /// Checks to see if the Subscriptions property is set.
        /// </summary>
        internal bool IsSetSubscriptions() => this.Subscriptions != null && (this.Subscriptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
