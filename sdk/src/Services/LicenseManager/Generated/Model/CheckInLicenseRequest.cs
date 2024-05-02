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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CheckInLicense operation.
    /// Checks in the specified license. Check in a license when it is no longer in use.
    /// </summary>
    public partial class CheckInLicenseRequest : AmazonLicenseManagerRequest
    {
        private string _beneficiary;
        private string _licenseConsumptionToken;

        /// <summary>
        /// Gets and sets the property Beneficiary. 
        /// <para>
        /// License beneficiary.
        /// </para>
        /// </summary>
        public string Beneficiary
        {
            get { return this._beneficiary; }
            set { this._beneficiary = value; }
        }

        // Check to see if Beneficiary property is set
        internal bool IsSetBeneficiary()
        {
            return this._beneficiary != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConsumptionToken. 
        /// <para>
        /// License consumption token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseConsumptionToken
        {
            get { return this._licenseConsumptionToken; }
            set { this._licenseConsumptionToken = value; }
        }

        // Check to see if LicenseConsumptionToken property is set
        internal bool IsSetLicenseConsumptionToken()
        {
            return this._licenseConsumptionToken != null;
        }

    }
}