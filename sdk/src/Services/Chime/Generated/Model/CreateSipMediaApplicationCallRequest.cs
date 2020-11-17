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
    /// Container for the parameters to the CreateSipMediaApplicationCall operation.
    /// Creates an outbound call to a phone number from the phone number specified in the
    /// request, and it invokes the endpoint of the specified <code>sipMediaApplicationId</code>.
    /// </summary>
    public partial class CreateSipMediaApplicationCallRequest : AmazonChimeRequest
    {
        private string _fromPhoneNumber;
        private string _sipMediaApplicationId;
        private string _toPhoneNumber;

        /// <summary>
        /// Gets and sets the property FromPhoneNumber. 
        /// <para>
        /// The phone number that a user calls from.
        /// </para>
        /// </summary>
        public string FromPhoneNumber
        {
            get { return this._fromPhoneNumber; }
            set { this._fromPhoneNumber = value; }
        }

        // Check to see if FromPhoneNumber property is set
        internal bool IsSetFromPhoneNumber()
        {
            return this._fromPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The ID of the SIP media application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SipMediaApplicationId
        {
            get { return this._sipMediaApplicationId; }
            set { this._sipMediaApplicationId = value; }
        }

        // Check to see if SipMediaApplicationId property is set
        internal bool IsSetSipMediaApplicationId()
        {
            return this._sipMediaApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ToPhoneNumber. 
        /// <para>
        /// The phone number that the user dials in order to connect to a meeting
        /// </para>
        /// </summary>
        public string ToPhoneNumber
        {
            get { return this._toPhoneNumber; }
            set { this._toPhoneNumber = value; }
        }

        // Check to see if ToPhoneNumber property is set
        internal bool IsSetToPhoneNumber()
        {
            return this._toPhoneNumber != null;
        }

    }
}