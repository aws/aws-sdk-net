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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// The response from the <c>CheckIfPhoneNumberIsOptedOut</c> action.
    /// </summary>
    public partial class CheckIfPhoneNumberIsOptedOutResponse : AmazonWebServiceResponse
    {
        private bool? _isOptedOut;

        /// <summary>
        /// Gets and sets the property IsOptedOut. 
        /// <para>
        /// Indicates whether the phone number is opted out:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> – The phone number is opted out, meaning you cannot publish SMS messages
        /// to it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> – The phone number is opted in, meaning you can publish SMS messages
        /// to it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? IsOptedOut
        {
            get { return this._isOptedOut; }
            set { this._isOptedOut = value; }
        }

        // Check to see if IsOptedOut property is set
        internal bool IsSetIsOptedOut()
        {
            return this._isOptedOut.HasValue; 
        }

    }
}