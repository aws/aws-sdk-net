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
    /// Container for the parameters to the GetLicenseManagerReportGenerator operation.
    /// Gets information about the specified report generator.
    /// </summary>
    public partial class GetLicenseManagerReportGeneratorRequest : AmazonLicenseManagerRequest
    {
        private string _licenseManagerReportGeneratorArn;

        /// <summary>
        /// Gets and sets the property LicenseManagerReportGeneratorArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the report generator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseManagerReportGeneratorArn
        {
            get { return this._licenseManagerReportGeneratorArn; }
            set { this._licenseManagerReportGeneratorArn = value; }
        }

        // Check to see if LicenseManagerReportGeneratorArn property is set
        internal bool IsSetLicenseManagerReportGeneratorArn()
        {
            return this._licenseManagerReportGeneratorArn != null;
        }

    }
}