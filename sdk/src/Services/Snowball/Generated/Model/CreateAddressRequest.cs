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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAddress operation.
    /// Creates an address for a Snow device to be shipped to. In most regions, addresses
    /// are validated at the time of creation. The address you provide must be located within
    /// the serviceable area of your region. If the address is invalid or unsupported, then
    /// an exception is thrown. If providing an address as a JSON file through the <c>cli-input-json</c>
    /// option, include the full file path. For example, <c>--cli-input-json file://create-address.json</c>.
    /// </summary>
    public partial class CreateAddressRequest : AmazonSnowballRequest
    {
        private Address _address;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address that you want the Snow device shipped to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Address Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

    }
}