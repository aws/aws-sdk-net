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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the ExtendLicenseConsumption operation.
    /// </summary>
    public partial class ExtendLicenseConsumptionResponse : AmazonWebServiceResponse
    {
        private string _expiration;
        private string _licenseConsumptionToken;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Date and time at which the license consumption expires.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConsumptionToken. 
        /// <para>
        /// License consumption token.
        /// </para>
        /// </summary>
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