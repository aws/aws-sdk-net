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
    /// This is the response object from the AssociateWhatsAppBusinessAccount operation.
    /// </summary>
    public partial class AssociateWhatsAppBusinessAccountResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LinkedWhatsAppBusinessAccountId. 
        /// <para>
        /// The ID of the WhatsApp Business Account that was linked to your Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 115)]
        public string LinkedWhatsAppBusinessAccountId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedWhatsAppBusinessAccountId property is set.
        /// </summary>
        internal bool IsSetLinkedWhatsAppBusinessAccountId() => this.LinkedWhatsAppBusinessAccountId != null;

        /// <summary>
        /// Gets and sets the property SignupCallbackResult. 
        /// <para>
        /// Contains your WhatsApp registration status.
        /// </para>
        /// </summary>
        public WhatsAppSignupCallbackResult SignupCallbackResult { get; set; }

        /// <summary>
        /// Checks to see if the SignupCallbackResult property is set.
        /// </summary>
        internal bool IsSetSignupCallbackResult() => this.SignupCallbackResult != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code for the response.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;
    }
}
