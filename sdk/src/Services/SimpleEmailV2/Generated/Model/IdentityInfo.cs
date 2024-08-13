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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about an email identity.
    /// </summary>
    public partial class IdentityInfo
    {
        private string _identityName;
        private IdentityType _identityType;
        private bool? _sendingEnabled;
        private VerificationStatus _verificationStatus;

        /// <summary>
        /// Gets and sets the property IdentityName. 
        /// <para>
        /// The address or domain of the identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string IdentityName
        {
            get { return this._identityName; }
            set { this._identityName = value; }
        }

        // Check to see if IdentityName property is set
        internal bool IsSetIdentityName()
        {
            return this._identityName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The email identity type. Note: the <c>MANAGED_DOMAIN</c> type is not supported for
        /// email identity types.
        /// </para>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property SendingEnabled. 
        /// <para>
        /// Indicates whether or not you can send email from the identity.
        /// </para>
        ///  
        /// <para>
        /// An <i>identity</i> is an email address or domain that you send email from. Before
        /// you can send email from an identity, you have to demostrate that you own the identity,
        /// and that you authorize Amazon SES to send email from that identity.
        /// </para>
        /// </summary>
        public bool? SendingEnabled
        {
            get { return this._sendingEnabled; }
            set { this._sendingEnabled = value; }
        }

        // Check to see if SendingEnabled property is set
        internal bool IsSetSendingEnabled()
        {
            return this._sendingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// The verification status of the identity. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – The verification process was initiated, but Amazon SES hasn't yet
        /// been able to verify the identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The verification process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The verification process failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_FAILURE</c> – A temporary issue is preventing Amazon SES from determining
        /// the verification status of the identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c> – The verification process hasn't been initiated for the identity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VerificationStatus VerificationStatus
        {
            get { return this._verificationStatus; }
            set { this._verificationStatus = value; }
        }

        // Check to see if VerificationStatus property is set
        internal bool IsSetVerificationStatus()
        {
            return this._verificationStatus != null;
        }

    }
}