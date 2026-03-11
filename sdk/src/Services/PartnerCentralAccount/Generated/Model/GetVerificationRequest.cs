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
    /// Container for the parameters to the GetVerification operation.
    /// Retrieves the current status and details of a verification process for a partner account.
    /// This operation allows partners to check the progress and results of business or registrant
    /// verification processes.
    /// </summary>
    public partial class GetVerificationRequest : AmazonPartnerCentralAccountRequest
    {
        private VerificationType _verificationType;

        /// <summary>
        /// Gets and sets the property VerificationType. 
        /// <para>
        /// The type of verification to retrieve information for. Valid values include business
        /// verification for company registration details and registrant verification for individual
        /// identity confirmation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerificationType VerificationType
        {
            get { return this._verificationType; }
            set { this._verificationType = value; }
        }

        // Check to see if VerificationType property is set
        internal bool IsSetVerificationType()
        {
            return this._verificationType != null;
        }

    }
}