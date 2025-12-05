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
    /// A union structure containing the specific details required for different types of
    /// verification processes supported by AWS Partner Central.
    /// </summary>
    public partial class VerificationDetails
    {
        private BusinessVerificationDetails _businessVerificationDetails;
        private RegistrantVerificationDetails _registrantVerificationDetails;

        /// <summary>
        /// Gets and sets the property BusinessVerificationDetails. 
        /// <para>
        /// The business verification details to be used when starting a business verification
        /// process.
        /// </para>
        /// </summary>
        public BusinessVerificationDetails BusinessVerificationDetails
        {
            get { return this._businessVerificationDetails; }
            set { this._businessVerificationDetails = value; }
        }

        // Check to see if BusinessVerificationDetails property is set
        internal bool IsSetBusinessVerificationDetails()
        {
            return this._businessVerificationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrantVerificationDetails. 
        /// <para>
        /// The registrant verification details to be used when starting an individual identity
        /// verification process.
        /// </para>
        /// </summary>
        public RegistrantVerificationDetails RegistrantVerificationDetails
        {
            get { return this._registrantVerificationDetails; }
            set { this._registrantVerificationDetails = value; }
        }

        // Check to see if RegistrantVerificationDetails property is set
        internal bool IsSetRegistrantVerificationDetails()
        {
            return this._registrantVerificationDetails != null;
        }

    }
}