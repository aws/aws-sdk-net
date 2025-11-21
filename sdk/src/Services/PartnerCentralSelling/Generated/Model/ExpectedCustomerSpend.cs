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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides an estimate of the revenue that the partner is expected to generate from
    /// the opportunity. This information helps partners assess the financial value of the
    /// project.
    /// </summary>
    public partial class ExpectedCustomerSpend
    {
        private string _amount;
        private ExpectedCustomerSpendCurrencyCodeEnum _currencyCode;
        private string _estimationUrl;
        private PaymentFrequency _frequency;
        private string _targetCompany;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// Represents the estimated monthly revenue that the partner expects to earn from the
        /// opportunity. This helps in forecasting financial returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Indicates the currency in which the revenue estimate is provided. This helps in understanding
        /// the financial impact across different markets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public ExpectedCustomerSpendCurrencyCodeEnum CurrencyCode
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
        /// Gets and sets the property EstimationUrl. 
        /// <para>
        /// A URL providing additional information or context about the spend estimation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=255)]
        public string EstimationUrl
        {
            get { return this._estimationUrl; }
            set { this._estimationUrl = value; }
        }

        // Check to see if EstimationUrl property is set
        internal bool IsSetEstimationUrl()
        {
            return this._estimationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Indicates how frequently the customer is expected to spend the projected amount. Only
        /// the value <c>Monthly</c> is allowed for the <c>Frequency</c> field, representing recurring
        /// monthly spend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCompany. 
        /// <para>
        /// Specifies the name of the partner company that is expected to generate revenue from
        /// the opportunity. This field helps track the partner’s involvement in the opportunity.
        /// This field only accepts the value <c>AWS</c>. If any other value is provided, the
        /// system will automatically set it to <c>AWS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string TargetCompany
        {
            get { return this._targetCompany; }
            set { this._targetCompany = value; }
        }

        // Check to see if TargetCompany property is set
        internal bool IsSetTargetCompany()
        {
            return this._targetCompany != null;
        }

    }
}