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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the GetCredits operation.
    /// Returns the list of Amazon Web Services account credits for the specified account.
    /// Each credit includes its identifier, type, monetary amounts, applicable products,
    /// expiration, sharing configuration, and current enabled status.
    /// 
    ///  
    /// <para>
    /// When the caller is the management account of a consolidated billing family and <c>payerAccountFlag</c>
    /// is <c>true</c>, the response aggregates credits across the entire family. Otherwise,
    /// the response includes only credits owned by the account specified in <c>accountId</c>.
    /// </para>
    /// </summary>
    public partial class GetCreditsRequest : AmazonBillingRequest
    {
        private string _accountId;
        private DateTime? _endDate;
        private bool? _payerAccountFlag;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID. Must be a 12-digit numeric string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date for the credit period as Unix epoch seconds. Must not be a future date
        /// and must be on or after <c>startDate</c>. Defaults to the current date when omitted.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PayerAccountFlag. 
        /// <para>
        /// When <c>true</c> and the caller is the management account, the response aggregates
        /// credits across the entire consolidated billing family. When <c>false</c> or omitted,
        /// returns only credits for the specified <c>accountId</c>.
        /// </para>
        /// </summary>
        public bool? PayerAccountFlag
        {
            get { return this._payerAccountFlag; }
            set { this._payerAccountFlag = value; }
        }

        // Check to see if PayerAccountFlag property is set
        internal bool IsSetPayerAccountFlag()
        {
            return this._payerAccountFlag.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date for the credit period as Unix epoch seconds. Must be a past date that
        /// is not more than one year before the current date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}