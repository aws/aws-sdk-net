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
    /// The details of a bank account that is debited over Automated Clearing House (ACH).
    /// </summary>
    public partial class UsAchBankAccount
    {
        /// <summary>
        /// Gets and sets the property AccountHolderName. 
        /// <para>
        /// The name on the account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Checks to see if the AccountHolderName property is set.
        /// </summary>
        internal bool IsSetAccountHolderName() => this.AccountHolderName != null;

        /// <summary>
        /// Gets and sets the property AccountNumberTail. 
        /// <para>
        /// The last one to four characters of the account number. This member is absent until
        /// your bank provides the account details, for example before you complete authentication
        /// with your bank.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4)]
        public string AccountNumberTail { get; set; }

        /// <summary>
        /// Checks to see if the AccountNumberTail property is set.
        /// </summary>
        internal bool IsSetAccountNumberTail() => this.AccountNumberTail != null;

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// Whether the account is a checking account or a savings account.
        /// </para>
        /// </summary>
        public BankAccountType AccountType { get; set; }

        /// <summary>
        /// Checks to see if the AccountType property is set.
        /// </summary>
        internal bool IsSetAccountType() => this.AccountType != null;

        /// <summary>
        /// Gets and sets the property BankName. 
        /// <para>
        /// The bank holding the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BankName { get; set; }

        /// <summary>
        /// Checks to see if the BankName property is set.
        /// </summary>
        internal bool IsSetBankName() => this.BankName != null;
    }
}
