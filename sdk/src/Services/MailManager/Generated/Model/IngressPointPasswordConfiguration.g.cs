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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The password configuration of the ingress endpoint resource.
    /// </summary>
    public partial class IngressPointPasswordConfiguration
    {
        /// <summary>
        /// Gets and sets the property PreviousSmtpPasswordExpiryTimestamp. 
        /// <para>
        /// The previous password expiry timestamp of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public DateTime? PreviousSmtpPasswordExpiryTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PreviousSmtpPasswordExpiryTimestamp property is set.
        /// </summary>
        internal bool IsSetPreviousSmtpPasswordExpiryTimestamp() => this.PreviousSmtpPasswordExpiryTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property PreviousSmtpPasswordVersion. 
        /// <para>
        /// The previous password version of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public string PreviousSmtpPasswordVersion { get; set; }

        /// <summary>
        /// Checks to see if the PreviousSmtpPasswordVersion property is set.
        /// </summary>
        internal bool IsSetPreviousSmtpPasswordVersion() => this.PreviousSmtpPasswordVersion != null;

        /// <summary>
        /// Gets and sets the property SmtpPasswordVersion. 
        /// <para>
        /// The current password expiry timestamp of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public string SmtpPasswordVersion { get; set; }

        /// <summary>
        /// Checks to see if the SmtpPasswordVersion property is set.
        /// </summary>
        internal bool IsSetSmtpPasswordVersion() => this.SmtpPasswordVersion != null;
    }
}
