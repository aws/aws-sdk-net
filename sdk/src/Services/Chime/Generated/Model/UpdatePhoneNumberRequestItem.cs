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
    /// The phone number ID, product type, or calling name fields to update, used with the
    /// <a>BatchUpdatePhoneNumber</a> and <a>UpdatePhoneNumber</a> actions.
    /// </summary>
    public partial class UpdatePhoneNumberRequestItem
    {
        private string _callingName;
        private string _phoneNumberId;
        private PhoneNumberProductType _productType;

        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The outbound calling name to update.
        /// </para>
        /// </summary>
        public string CallingName
        {
            get { return this._callingName; }
            set { this._callingName = value; }
        }

        // Check to see if CallingName property is set
        internal bool IsSetCallingName()
        {
            return this._callingName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The product type to update.
        /// </para>
        /// </summary>
        public PhoneNumberProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

    }
}