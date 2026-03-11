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
    /// A union structure containing the response details specific to different types of verification
    /// processes, providing type-specific information and results.
    /// </summary>
    public partial class VerificationResponseDetails
    {
        private BusinessVerificationResponse _businessVerificationResponse;
        private RegistrantVerificationResponse _registrantVerificationResponse;

        /// <summary>
        /// Gets and sets the property BusinessVerificationResponse. 
        /// <para>
        /// The response details from a business verification process, including verification
        /// results and any additional business information discovered.
        /// </para>
        /// </summary>
        public BusinessVerificationResponse BusinessVerificationResponse
        {
            get { return this._businessVerificationResponse; }
            set { this._businessVerificationResponse = value; }
        }

        // Check to see if BusinessVerificationResponse property is set
        internal bool IsSetBusinessVerificationResponse()
        {
            return this._businessVerificationResponse != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrantVerificationResponse. 
        /// <para>
        /// The response details from a registrant verification process, including verification
        /// results and any additional steps required for identity confirmation.
        /// </para>
        /// </summary>
        public RegistrantVerificationResponse RegistrantVerificationResponse
        {
            get { return this._registrantVerificationResponse; }
            set { this._registrantVerificationResponse = value; }
        }

        // Check to see if RegistrantVerificationResponse property is set
        internal bool IsSetRegistrantVerificationResponse()
        {
            return this._registrantVerificationResponse != null;
        }

    }
}