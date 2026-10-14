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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Contains the response information from a registrant verification process, including
    /// any verification-specific data and next steps for the individual verification workflow.
    /// </summary>
    public partial class RegistrantVerificationResponse
    {
        /// <summary>
        /// Gets and sets the property CompletionUrl. 
        /// <para>
        /// A secure URL where the registrant can complete additional verification steps, such
        /// as document upload or identity confirmation through a third-party verification service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CompletionUrl { get; set; }

        /// <summary>
        /// Checks to see if the CompletionUrl property is set.
        /// </summary>
        internal bool IsSetCompletionUrl() => this.CompletionUrl != null;

        /// <summary>
        /// Gets and sets the property CompletionUrlExpiresAt. 
        /// <para>
        /// The timestamp when the completion URL expires and is no longer valid for accessing
        /// the verification workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CompletionUrlExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletionUrlExpiresAt property is set.
        /// </summary>
        internal bool IsSetCompletionUrlExpiresAt() => this.CompletionUrlExpiresAt.HasValue;
    }
}
