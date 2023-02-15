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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about a request to return a network resource.
    /// </summary>
    public partial class ReturnInformation
    {
        private string _replacementOrderArn;
        private string _returnReason;
        private Address _shippingAddress;
        private string _shippingLabel;

        /// <summary>
        /// Gets and sets the property ReplacementOrderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replacement order.
        /// </para>
        /// </summary>
        public string ReplacementOrderArn
        {
            get { return this._replacementOrderArn; }
            set { this._replacementOrderArn = value; }
        }

        // Check to see if ReplacementOrderArn property is set
        internal bool IsSetReplacementOrderArn()
        {
            return this._replacementOrderArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnReason. 
        /// <para>
        /// The reason for the return. If the return request did not include a reason for the
        /// return, this value is null.
        /// </para>
        /// </summary>
        public string ReturnReason
        {
            get { return this._returnReason; }
            set { this._returnReason = value; }
        }

        // Check to see if ReturnReason property is set
        internal bool IsSetReturnReason()
        {
            return this._returnReason != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// The shipping address.
        /// </para>
        /// </summary>
        public Address ShippingAddress
        {
            get { return this._shippingAddress; }
            set { this._shippingAddress = value; }
        }

        // Check to see if ShippingAddress property is set
        internal bool IsSetShippingAddress()
        {
            return this._shippingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingLabel. 
        /// <para>
        /// The URL of the shipping label. The shipping label is available for download only if
        /// the status of the network resource is <code>PENDING_RETURN</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
        /// a radio unit</a>.
        /// </para>
        /// </summary>
        public string ShippingLabel
        {
            get { return this._shippingLabel; }
            set { this._shippingLabel = value; }
        }

        // Check to see if ShippingLabel property is set
        internal bool IsSetShippingLabel()
        {
            return this._shippingLabel != null;
        }

    }
}