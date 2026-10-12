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
    /// Container for the parameters to the StartVerification operation. Initiates a new verification
    /// process for a partner account. This operation begins the verification workflow for
    /// either business registration or individual registrant identity verification as required
    /// by AWS Partner Central.
    /// </summary>
    public partial class StartVerificationRequest : AmazonPartnerCentralAccountRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This prevents duplicate verification processes from being started accidentally.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property VerificationDetails. 
        /// <para>
        /// The specific details required for the verification process, including business information
        /// for business verification or personal information for registrant verification.
        /// </para>
        /// </summary>
        public VerificationDetails VerificationDetails { get; set; }

        /// <summary>
        /// Checks to see if the VerificationDetails property is set.
        /// </summary>
        internal bool IsSetVerificationDetails() => this.VerificationDetails != null;
    }
}
