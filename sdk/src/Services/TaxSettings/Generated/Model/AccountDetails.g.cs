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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// An object with your <c>accountId</c> and TRN information.
    /// </summary>
    public partial class AccountDetails
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// List of unique account identifiers. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountMetaData. 
        /// <para>
        ///  The meta data information associated with the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public AccountMetaData AccountMetaData { get; set; }

        /// <summary>
        /// Checks to see if the AccountMetaData property is set.
        /// </summary>
        internal bool IsSetAccountMetaData() => this.AccountMetaData != null;

        /// <summary>
        /// Gets and sets the property TaxInheritanceDetails. 
        /// <para>
        ///  Tax inheritance information associated with the account. 
        /// </para>
        /// </summary>
        public TaxInheritanceDetails TaxInheritanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaxInheritanceDetails property is set.
        /// </summary>
        internal bool IsSetTaxInheritanceDetails() => this.TaxInheritanceDetails != null;

        /// <summary>
        /// Gets and sets the property TaxRegistration. 
        /// <para>
        /// Your TRN information. Instead of having full legal address, here TRN information will
        /// have jurisdiction details (for example, country code and state/region/province if
        /// applicable). 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public TaxRegistrationWithJurisdiction TaxRegistration { get; set; }

        /// <summary>
        /// Checks to see if the TaxRegistration property is set.
        /// </summary>
        internal bool IsSetTaxRegistration() => this.TaxRegistration != null;
    }
}
