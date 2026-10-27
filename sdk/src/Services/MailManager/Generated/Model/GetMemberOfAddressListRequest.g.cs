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
    /// Container for the parameters to the GetMemberOfAddressList operation. Fetch attributes
    /// of a member in an address list.
    /// </summary>
    public partial class GetMemberOfAddressListRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address to be retrieved from the address list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 3, Max = 320)]
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The unique identifier of the address list to retrieve the address from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AddressListId { get; set; }

        /// <summary>
        /// Checks to see if the AddressListId property is set.
        /// </summary>
        internal bool IsSetAddressListId() => this.AddressListId != null;
    }
}
