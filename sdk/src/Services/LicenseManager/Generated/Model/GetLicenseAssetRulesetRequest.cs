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
    /// Container for the parameters to the GetLicenseAssetRuleset operation.
    /// Gets a license asset ruleset.
    /// </summary>
    public partial class GetLicenseAssetRulesetRequest : AmazonLicenseManagerRequest
    {
        private string _licenseAssetRulesetArn;

        /// <summary>
        /// Gets and sets the property LicenseAssetRulesetArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license asset ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string LicenseAssetRulesetArn
        {
            get { return this._licenseAssetRulesetArn; }
            set { this._licenseAssetRulesetArn = value; }
        }

        // Check to see if LicenseAssetRulesetArn property is set
        internal bool IsSetLicenseAssetRulesetArn()
        {
            return this._licenseAssetRulesetArn != null;
        }

    }
}