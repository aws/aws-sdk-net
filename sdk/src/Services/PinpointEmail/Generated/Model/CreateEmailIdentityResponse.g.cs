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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the CreateEmailIdentity operation.
    /// </summary>
    public partial class CreateEmailIdentityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// An object that contains information about the DKIM attributes for the identity. This
        /// object includes the tokens that you use to create the CNAME records that are required
        /// to complete the DKIM verification process.
        /// </para>
        /// </summary>
        public DkimAttributes DkimAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DkimAttributes property is set.
        /// </summary>
        internal bool IsSetDkimAttributes() => this.DkimAttributes != null;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The email identity type.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property VerifiedForSendingStatus. 
        /// <para>
        /// Specifies whether or not the identity is verified. In Amazon Pinpoint, you can only
        /// send email from verified email addresses or domains. For more information about verifying
        /// identities, see the <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-email-manage-verify.html">Amazon
        /// Pinpoint User Guide</a>.
        /// </para>
        /// </summary>
        public bool? VerifiedForSendingStatus { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedForSendingStatus property is set.
        /// </summary>
        internal bool IsSetVerifiedForSendingStatus() => this.VerifiedForSendingStatus.HasValue;
    }
}
