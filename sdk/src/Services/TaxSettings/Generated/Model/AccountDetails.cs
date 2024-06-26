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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
        private string _accountId;
        private AccountMetaData _accountMetaData;
        private TaxInheritanceDetails _taxInheritanceDetails;
        private TaxRegistrationWithJurisdiction _taxRegistration;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// List of unique account identifiers. 
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
        /// Gets and sets the property AccountMetaData. 
        /// <para>
        ///  The meta data information associated with the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public AccountMetaData AccountMetaData
        {
            get { return this._accountMetaData; }
            set { this._accountMetaData = value; }
        }

        // Check to see if AccountMetaData property is set
        internal bool IsSetAccountMetaData()
        {
            return this._accountMetaData != null;
        }

        /// <summary>
        /// Gets and sets the property TaxInheritanceDetails. 
        /// <para>
        ///  Tax inheritance information associated with the account. 
        /// </para>
        /// </summary>
        public TaxInheritanceDetails TaxInheritanceDetails
        {
            get { return this._taxInheritanceDetails; }
            set { this._taxInheritanceDetails = value; }
        }

        // Check to see if TaxInheritanceDetails property is set
        internal bool IsSetTaxInheritanceDetails()
        {
            return this._taxInheritanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TaxRegistration. 
        /// <para>
        /// Your TRN information. Instead of having full legal address, here TRN information will
        /// have jurisdiction details (for example, country code and state/region/province if
        /// applicable). 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TaxRegistrationWithJurisdiction TaxRegistration
        {
            get { return this._taxRegistration; }
            set { this._taxRegistration = value; }
        }

        // Check to see if TaxRegistration property is set
        internal bool IsSetTaxRegistration()
        {
            return this._taxRegistration != null;
        }

    }
}