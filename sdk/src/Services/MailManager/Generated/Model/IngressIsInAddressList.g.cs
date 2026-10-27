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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The address lists and the address list attribute value that is evaluated in a policy
    /// statement's conditional expression to either deny or block the incoming email.
    /// </summary>
    public partial class IngressIsInAddressList
    {
        /// <summary>
        /// Gets and sets the property AddressLists. 
        /// <para>
        /// The address lists that will be used for evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> AddressLists { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddressLists property is set.
        /// </summary>
        internal bool IsSetAddressLists() => this.AddressLists != null && (this.AddressLists.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The email attribute that needs to be evaluated against the address list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngressAddressListEmailAttribute Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;
    }
}
