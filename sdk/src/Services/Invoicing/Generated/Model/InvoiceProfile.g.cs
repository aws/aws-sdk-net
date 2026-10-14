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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Contains high-level information about the invoice receiver.
    /// </summary>
    public partial class InvoiceProfile
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The account ID the invoice profile is generated for. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        ///  This specifies the issuing entity of the invoice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property ReceiverAddress. 
        /// <para>
        /// The address of the receiver that will be printed on the invoice. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ReceiverAddress ReceiverAddress { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverAddress property is set.
        /// </summary>
        internal bool IsSetReceiverAddress() => this.ReceiverAddress != null;

        /// <summary>
        /// Gets and sets the property ReceiverEmail. 
        /// <para>
        /// The email address for the invoice profile receiver. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverEmail property is set.
        /// </summary>
        internal bool IsSetReceiverEmail() => this.ReceiverEmail != null;

        /// <summary>
        /// Gets and sets the property ReceiverName. 
        /// <para>
        ///  The name of the person receiving the invoice profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverName property is set.
        /// </summary>
        internal bool IsSetReceiverName() => this.ReceiverName != null;

        /// <summary>
        /// Gets and sets the property TaxRegistrationNumber. 
        /// <para>
        ///  Your Tax Registration Number (TRN) information. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string TaxRegistrationNumber { get; set; }

        /// <summary>
        /// Checks to see if the TaxRegistrationNumber property is set.
        /// </summary>
        internal bool IsSetTaxRegistrationNumber() => this.TaxRegistrationNumber != null;
    }
}
