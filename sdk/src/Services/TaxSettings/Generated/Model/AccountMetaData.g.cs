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
    /// The meta data information associated with the account.
    /// </summary>
    public partial class AccountMetaData
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        ///  The Amazon Web Services accounts name. 
        /// </para>
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property Address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AddressRoleMap. 
        /// <para>
        ///  Address roles associated with the account containing country code information. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Jurisdiction> AddressRoleMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Jurisdiction>() : null;

        /// <summary>
        /// Checks to see if the AddressRoleMap property is set.
        /// </summary>
        internal bool IsSetAddressRoleMap() => this.AddressRoleMap != null && (this.AddressRoleMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddressType. 
        /// <para>
        ///  The type of address associated with the legal profile. 
        /// </para>
        /// </summary>
        public AddressRoleType AddressType { get; set; }

        /// <summary>
        /// Checks to see if the AddressType property is set.
        /// </summary>
        internal bool IsSetAddressType() => this.AddressType != null;

        /// <summary>
        /// Gets and sets the property Seller. 
        /// <para>
        ///  Seller information associated with the account. 
        /// </para>
        /// </summary>
        public string Seller { get; set; }

        /// <summary>
        /// Checks to see if the Seller property is set.
        /// </summary>
        internal bool IsSetSeller() => this.Seller != null;
    }
}
