/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the verification attributes of a single identity.
    /// </summary>
    public partial class IdentityVerificationAttributes
    {
        private string _verificationStatus;
        private string _verificationToken;


        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// The verification status of the identity: "Pending", "Success", "Failed", or "TemporaryFailure".
        /// </para>
        /// </summary>
        public string VerificationStatus
        {
            get { return this._verificationStatus; }
            set { this._verificationStatus = value; }
        }


        /// <summary>
        /// Sets the VerificationStatus property
        /// </summary>
        /// <param name="verificationStatus">The value to set for the VerificationStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityVerificationAttributes WithVerificationStatus(string verificationStatus)
        {
            this._verificationStatus = verificationStatus;
            return this;
        }

        // Check to see if VerificationStatus property is set
        internal bool IsSetVerificationStatus()
        {
            return this._verificationStatus != null;
        }


        /// <summary>
        /// Gets and sets the property VerificationToken. 
        /// <para>
        /// The verification token for a domain identity. Null for email address identities.
        /// </para>
        /// </summary>
        public string VerificationToken
        {
            get { return this._verificationToken; }
            set { this._verificationToken = value; }
        }


        /// <summary>
        /// Sets the VerificationToken property
        /// </summary>
        /// <param name="verificationToken">The value to set for the VerificationToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityVerificationAttributes WithVerificationToken(string verificationToken)
        {
            this._verificationToken = verificationToken;
            return this;
        }

        // Check to see if VerificationToken property is set
        internal bool IsSetVerificationToken()
        {
            return this._verificationToken != null;
        }

    }
}