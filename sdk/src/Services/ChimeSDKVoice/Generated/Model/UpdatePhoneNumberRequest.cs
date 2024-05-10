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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePhoneNumber operation.
    /// Updates phone number details, such as product type, calling name, or phone number
    /// name for the specified phone number ID. You can update one phone number detail at
    /// a time. For example, you can update either the product type, calling name, or phone
    /// number name in one action.
    /// 
    ///  
    /// <para>
    /// For numbers outside the U.S., you must use the Amazon Chime SDK SIP Media Application
    /// Dial-In product type.
    /// </para>
    ///  
    /// <para>
    /// Updates to outbound calling names can take 72 hours to complete. Pending updates to
    /// outbound calling names must be complete before you can request another update.
    /// </para>
    /// </summary>
    public partial class UpdatePhoneNumberRequest : AmazonChimeSDKVoiceRequest
    {
        private string _callingName;
        private string _name;
        private string _phoneNumberId;
        private PhoneNumberProductType _productType;

        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The outbound calling name associated with the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the updated name assigned to one or more phone numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// The product type.
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