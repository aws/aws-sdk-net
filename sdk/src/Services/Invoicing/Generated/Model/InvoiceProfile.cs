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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Contains high-level information about the invoice receiver.
    /// </summary>
    public partial class InvoiceProfile
    {
        private string _accountId;
        private string _issuer;
        private ReceiverAddress _receiverAddress;
        private string _receiverEmail;
        private string _receiverName;
        private string _taxRegistrationNumber;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The account ID the invoice profile is generated for. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Issuer. 
        /// <para>
        ///  This specifies the issuing entity of the invoice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverAddress. 
        /// <para>
        /// The address of the receiver that will be printed on the invoice. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ReceiverAddress ReceiverAddress
        {
            get { return this._receiverAddress; }
            set { this._receiverAddress = value; }
        }

        // Check to see if ReceiverAddress property is set
        internal bool IsSetReceiverAddress()
        {
            return this._receiverAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverEmail. 
        /// <para>
        /// The email address for the invoice profile receiver. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string ReceiverEmail
        {
            get { return this._receiverEmail; }
            set { this._receiverEmail = value; }
        }

        // Check to see if ReceiverEmail property is set
        internal bool IsSetReceiverEmail()
        {
            return this._receiverEmail != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverName. 
        /// <para>
        ///  The name of the person receiving the invoice profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ReceiverName
        {
            get { return this._receiverName; }
            set { this._receiverName = value; }
        }

        // Check to see if ReceiverName property is set
        internal bool IsSetReceiverName()
        {
            return this._receiverName != null;
        }

        /// <summary>
        /// Gets and sets the property TaxRegistrationNumber. 
        /// <para>
        ///  Your Tax Registration Number (TRN) information. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string TaxRegistrationNumber
        {
            get { return this._taxRegistrationNumber; }
            set { this._taxRegistrationNumber = value; }
        }

        // Check to see if TaxRegistrationNumber property is set
        internal bool IsSetTaxRegistrationNumber()
        {
            return this._taxRegistrationNumber != null;
        }

    }
}