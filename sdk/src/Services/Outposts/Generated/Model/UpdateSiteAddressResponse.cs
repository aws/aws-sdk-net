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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the UpdateSiteAddress operation.
    /// </summary>
    public partial class UpdateSiteAddressResponse : AmazonWebServiceResponse
    {
        private Address _address;
        private AddressType _addressType;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        ///  Information about an address. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property AddressType. 
        /// <para>
        ///  The type of the address. 
        /// </para>
        /// </summary>
        public AddressType AddressType
        {
            get { return this._addressType; }
            set { this._addressType = value; }
        }

        // Check to see if AddressType property is set
        internal bool IsSetAddressType()
        {
            return this._addressType != null;
        }

    }
}