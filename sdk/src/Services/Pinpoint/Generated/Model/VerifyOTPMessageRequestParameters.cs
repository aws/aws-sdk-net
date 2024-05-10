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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Verify OTP message request.
    /// </summary>
    public partial class VerifyOTPMessageRequestParameters
    {
        private string _destinationIdentity;
        private string _otp;
        private string _referenceId;

        /// <summary>
        /// Gets and sets the property DestinationIdentity. 
        /// <para>
        /// The destination identity to send OTP to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationIdentity
        {
            get { return this._destinationIdentity; }
            set { this._destinationIdentity = value; }
        }

        // Check to see if DestinationIdentity property is set
        internal bool IsSetDestinationIdentity()
        {
            return this._destinationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property Otp. 
        /// <para>
        /// The OTP the end user provided for verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Otp
        {
            get { return this._otp; }
            set { this._otp = value; }
        }

        // Check to see if Otp property is set
        internal bool IsSetOtp()
        {
            return this._otp != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// The reference identifier provided when the OTP was previously sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

    }
}