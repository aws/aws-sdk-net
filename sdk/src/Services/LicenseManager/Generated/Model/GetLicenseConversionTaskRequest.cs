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
    /// Container for the parameters to the GetLicenseConversionTask operation.
    /// Gets information about the specified license type conversion task.
    /// </summary>
    public partial class GetLicenseConversionTaskRequest : AmazonLicenseManagerRequest
    {
        private string _licenseConversionTaskId;

        /// <summary>
        /// Gets and sets the property LicenseConversionTaskId. 
        /// <para>
        /// ID of the license type conversion task to retrieve information on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public string LicenseConversionTaskId
        {
            get { return this._licenseConversionTaskId; }
            set { this._licenseConversionTaskId = value; }
        }

        // Check to see if LicenseConversionTaskId property is set
        internal bool IsSetLicenseConversionTaskId()
        {
            return this._licenseConversionTaskId != null;
        }

    }
}