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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCustomerAccount operation. Use <c>UpdateCustomerAccount</c>
    /// to replace the customer information on an existing customer account. AWS matches the
    /// account again with the updated information. <para> To prevent concurrent changes from
    /// overwriting each other, specify the <c>LastModifiedDate</c> value that you last read
    /// for the account. If the account changed since then, the request fails with a <c>ConflictException</c>.
    /// </para>
    /// </summary>
    public partial class UpdateCustomerAccountRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Specifies the complete, updated details of the customer. These details replace the
        /// existing details on the customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomerAccountData Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog for the request. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c>: Production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sandbox</c>: Testing environments.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Specifies the ARN or the identifier of the customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Specifies the <c>LastModifiedDate</c> of the customer account as you last read it.
        /// If it doesn't match the current value, the request fails with a <c>ConflictException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PartnerAccountIdentifier. 
        /// <para>
        /// Specifies your own identifier for the customer account, such as the account ID in
        /// your CRM system. Use it to correlate the customer account with your records.
        /// </para>
        /// </summary>
        public string PartnerAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerAccountIdentifier() => this.PartnerAccountIdentifier != null;
    }
}
