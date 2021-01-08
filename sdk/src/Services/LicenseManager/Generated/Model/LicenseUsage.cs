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
    /// Describes the entitlement usage associated with a license.
    /// </summary>
    public partial class LicenseUsage
    {
        private List<EntitlementUsage> _entitlementUsages = new List<EntitlementUsage>();

        /// <summary>
        /// Gets and sets the property EntitlementUsages. 
        /// <para>
        /// License entitlement usages.
        /// </para>
        /// </summary>
        public List<EntitlementUsage> EntitlementUsages
        {
            get { return this._entitlementUsages; }
            set { this._entitlementUsages = value; }
        }

        // Check to see if EntitlementUsages property is set
        internal bool IsSetEntitlementUsages()
        {
            return this._entitlementUsages != null && this._entitlementUsages.Count > 0; 
        }

    }
}