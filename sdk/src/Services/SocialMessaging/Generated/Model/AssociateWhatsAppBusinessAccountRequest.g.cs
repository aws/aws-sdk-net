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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateWhatsAppBusinessAccount operation. This
    /// is only used through the Amazon Web Services console during sign-up to associate your
    /// WhatsApp Business Account to your Amazon Web Services account.
    /// </summary>
    public partial class AssociateWhatsAppBusinessAccountRequest : AmazonSocialMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property SetupFinalization. 
        /// <para>
        /// A JSON object that contains the phone numbers and WhatsApp Business Account to link
        /// to your account.
        /// </para>
        /// </summary>
        public WhatsAppSetupFinalization SetupFinalization { get; set; }

        /// <summary>
        /// Checks to see if the SetupFinalization property is set.
        /// </summary>
        internal bool IsSetSetupFinalization() => this.SetupFinalization != null;

        /// <summary>
        /// Gets and sets the property SignupCallback. 
        /// <para>
        /// Contains the callback access token.
        /// </para>
        /// </summary>
        public WhatsAppSignupCallback SignupCallback { get; set; }

        /// <summary>
        /// Checks to see if the SignupCallback property is set.
        /// </summary>
        internal bool IsSetSignupCallback() => this.SignupCallback != null;
    }
}
