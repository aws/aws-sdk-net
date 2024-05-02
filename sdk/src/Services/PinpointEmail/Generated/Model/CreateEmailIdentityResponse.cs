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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// If the email identity is a domain, this object contains tokens that you can use to
    /// create a set of CNAME records. To sucessfully verify your domain, you have to add
    /// these records to the DNS configuration for your domain.
    /// 
    ///  
    /// <para>
    /// If the email identity is an email address, this object is empty. 
    /// </para>
    /// </summary>
    public partial class CreateEmailIdentityResponse : AmazonWebServiceResponse
    {
        private DkimAttributes _dkimAttributes;
        private IdentityType _identityType;
        private bool? _verifiedForSendingStatus;

        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// An object that contains information about the DKIM attributes for the identity. This
        /// object includes the tokens that you use to create the CNAME records that are required
        /// to complete the DKIM verification process.
        /// </para>
        /// </summary>
        public DkimAttributes DkimAttributes
        {
            get { return this._dkimAttributes; }
            set { this._dkimAttributes = value; }
        }

        // Check to see if DkimAttributes property is set
        internal bool IsSetDkimAttributes()
        {
            return this._dkimAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The email identity type.
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
        /// Gets and sets the property VerifiedForSendingStatus. 
        /// <para>
        /// Specifies whether or not the identity is verified. In Amazon Pinpoint, you can only
        /// send email from verified email addresses or domains. For more information about verifying
        /// identities, see the <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-email-manage-verify.html">Amazon
        /// Pinpoint User Guide</a>.
        /// </para>
        /// </summary>
        public bool? VerifiedForSendingStatus
        {
            get { return this._verifiedForSendingStatus; }
            set { this._verifiedForSendingStatus = value; }
        }

        // Check to see if VerifiedForSendingStatus property is set
        internal bool IsSetVerifiedForSendingStatus()
        {
            return this._verifiedForSendingStatus.HasValue; 
        }

    }
}