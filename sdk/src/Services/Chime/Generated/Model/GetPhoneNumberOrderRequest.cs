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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the GetPhoneNumberOrder operation.
    /// Retrieves details for the specified phone number order, such as order creation timestamp,
    /// phone numbers in E.164 format, product type, and order status.
    /// </summary>
    public partial class GetPhoneNumberOrderRequest : AmazonChimeRequest
    {
        private string _phoneNumberOrderId;

        /// <summary>
        /// Gets and sets the property PhoneNumberOrderId. 
        /// <para>
        /// The ID for the phone number order.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PhoneNumberOrderId
        {
            get { return this._phoneNumberOrderId; }
            set { this._phoneNumberOrderId = value; }
        }

        // Check to see if PhoneNumberOrderId property is set
        internal bool IsSetPhoneNumberOrderId()
        {
            return this._phoneNumberOrderId != null;
        }

    }
}