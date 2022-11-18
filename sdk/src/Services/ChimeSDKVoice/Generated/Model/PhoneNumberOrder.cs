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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PhoneNumberOrder
    {
        private DateTime? _createdTimestamp;
        private List<OrderedPhoneNumber> _orderedPhoneNumbers = new List<OrderedPhoneNumber>();
        private PhoneNumberOrderType _orderType;
        private string _phoneNumberOrderId;
        private PhoneNumberProductType _productType;
        private PhoneNumberOrderStatus _status;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp.
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderedPhoneNumbers.
        /// </summary>
        public List<OrderedPhoneNumber> OrderedPhoneNumbers
        {
            get { return this._orderedPhoneNumbers; }
            set { this._orderedPhoneNumbers = value; }
        }

        // Check to see if OrderedPhoneNumbers property is set
        internal bool IsSetOrderedPhoneNumbers()
        {
            return this._orderedPhoneNumbers != null && this._orderedPhoneNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrderType.
        /// </summary>
        public PhoneNumberOrderType OrderType
        {
            get { return this._orderType; }
            set { this._orderType = value; }
        }

        // Check to see if OrderType property is set
        internal bool IsSetOrderType()
        {
            return this._orderType != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberOrderId.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ProductType.
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

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public PhoneNumberOrderStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp.
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}