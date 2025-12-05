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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
        private string _completionUrl;
        private DateTime? _completionUrlExpiresAt;

        /// <summary>
        /// Gets and sets the property CompletionUrl. 
        /// <para>
        /// A secure URL where the registrant can complete additional verification steps, such
        /// as document upload or identity confirmation through a third-party verification service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CompletionUrl
        {
            get { return this._completionUrl; }
            set { this._completionUrl = value; }
        }

        // Check to see if CompletionUrl property is set
        internal bool IsSetCompletionUrl()
        {
            return this._completionUrl != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionUrlExpiresAt. 
        /// <para>
        /// The timestamp when the completion URL expires and is no longer valid for accessing
        /// the verification workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CompletionUrlExpiresAt
        {
            get { return this._completionUrlExpiresAt.GetValueOrDefault(); }
            set { this._completionUrlExpiresAt = value; }
        }

        // Check to see if CompletionUrlExpiresAt property is set
        internal bool IsSetCompletionUrlExpiresAt()
        {
            return this._completionUrlExpiresAt.HasValue; 
        }

    }
}