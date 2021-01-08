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
    /// This is the response object from the GetLicenseUsage operation.
    /// </summary>
    public partial class GetLicenseUsageResponse : AmazonWebServiceResponse
    {
        private LicenseUsage _licenseUsage;

        /// <summary>
        /// Gets and sets the property LicenseUsage. 
        /// <para>
        /// License usage details.
        /// </para>
        /// </summary>
        public LicenseUsage LicenseUsage
        {
            get { return this._licenseUsage; }
            set { this._licenseUsage = value; }
        }

        // Check to see if LicenseUsage property is set
        internal bool IsSetLicenseUsage()
        {
            return this._licenseUsage != null;
        }

    }
}