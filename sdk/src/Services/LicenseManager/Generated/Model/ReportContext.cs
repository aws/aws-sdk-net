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
    /// Details of the license configuration that this generator reports on.
    /// </summary>
    public partial class ReportContext
    {
        private List<string> _licenseConfigurationArns = new List<string>();

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArns. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration that this generator reports
        /// on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> LicenseConfigurationArns
        {
            get { return this._licenseConfigurationArns; }
            set { this._licenseConfigurationArns = value; }
        }

        // Check to see if LicenseConfigurationArns property is set
        internal bool IsSetLicenseConfigurationArns()
        {
            return this._licenseConfigurationArns != null && this._licenseConfigurationArns.Count > 0; 
        }

    }
}