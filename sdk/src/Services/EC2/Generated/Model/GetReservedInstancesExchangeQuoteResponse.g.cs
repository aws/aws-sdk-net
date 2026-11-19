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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetReservedInstancesExchangeQuote operation.
    /// </summary>
    public partial class GetReservedInstancesExchangeQuoteResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the transaction.
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property IsValidExchange. 
        /// <para>
        /// If <c>true</c>, the exchange is valid. If <c>false</c>, the exchange cannot be completed.
        /// </para>
        /// </summary>
        public bool? IsValidExchange { get; set; }

        /// <summary>
        /// Checks to see if the IsValidExchange property is set.
        /// </summary>
        internal bool IsSetIsValidExchange() => this.IsValidExchange.HasValue;

        /// <summary>
        /// Gets and sets the property OutputReservedInstancesWillExpireAt. 
        /// <para>
        /// The new end date of the reservation term.
        /// </para>
        /// </summary>
        public DateTime? OutputReservedInstancesWillExpireAt { get; set; }

        /// <summary>
        /// Checks to see if the OutputReservedInstancesWillExpireAt property is set.
        /// </summary>
        internal bool IsSetOutputReservedInstancesWillExpireAt() => this.OutputReservedInstancesWillExpireAt.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentDue. 
        /// <para>
        /// The total true upfront charge for the exchange.
        /// </para>
        /// </summary>
        public string PaymentDue { get; set; }

        /// <summary>
        /// Checks to see if the PaymentDue property is set.
        /// </summary>
        internal bool IsSetPaymentDue() => this.PaymentDue != null;

        /// <summary>
        /// Gets and sets the property ReservedInstanceValueRollup. 
        /// <para>
        /// The cost associated with the Reserved Instance.
        /// </para>
        /// </summary>
        public ReservationValue ReservedInstanceValueRollup { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstanceValueRollup property is set.
        /// </summary>
        internal bool IsSetReservedInstanceValueRollup() => this.ReservedInstanceValueRollup != null;

        /// <summary>
        /// Gets and sets the property ReservedInstanceValueSet. 
        /// <para>
        /// The configuration of your Convertible Reserved Instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservedInstanceReservationValue> ReservedInstanceValueSet { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservedInstanceReservationValue>() : null;

        /// <summary>
        /// Checks to see if the ReservedInstanceValueSet property is set.
        /// </summary>
        internal bool IsSetReservedInstanceValueSet() => this.ReservedInstanceValueSet != null && (this.ReservedInstanceValueSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetConfigurationValueRollup. 
        /// <para>
        /// The cost associated with the Reserved Instance.
        /// </para>
        /// </summary>
        public ReservationValue TargetConfigurationValueRollup { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfigurationValueRollup property is set.
        /// </summary>
        internal bool IsSetTargetConfigurationValueRollup() => this.TargetConfigurationValueRollup != null;

        /// <summary>
        /// Gets and sets the property TargetConfigurationValueSet. 
        /// <para>
        /// The values of the target Convertible Reserved Instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetReservationValue> TargetConfigurationValueSet { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetReservationValue>() : null;

        /// <summary>
        /// Checks to see if the TargetConfigurationValueSet property is set.
        /// </summary>
        internal bool IsSetTargetConfigurationValueSet() => this.TargetConfigurationValueSet != null && (this.TargetConfigurationValueSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationFailureReason. 
        /// <para>
        /// Describes the reason why the exchange cannot be completed.
        /// </para>
        /// </summary>
        public string ValidationFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the ValidationFailureReason property is set.
        /// </summary>
        internal bool IsSetValidationFailureReason() => this.ValidationFailureReason != null;
    }
}
