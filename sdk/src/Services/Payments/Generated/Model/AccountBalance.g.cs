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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// An amount of the balance that <c>GetAccountBalance</c> returns: the total for one
    /// merchant of record in one currency.
    /// </summary>
    public partial class AccountBalance
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The amount, in the currency that the records making up this balance were issued in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CurrencyAmount Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property MerchantOfRecord. 
        /// <para>
        /// The merchant of record that issued the invoices or credit memos that make up this
        /// amount.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MerchantOfRecord { get; set; }

        /// <summary>
        /// Checks to see if the MerchantOfRecord property is set.
        /// </summary>
        internal bool IsSetMerchantOfRecord() => this.MerchantOfRecord != null;
    }
}
