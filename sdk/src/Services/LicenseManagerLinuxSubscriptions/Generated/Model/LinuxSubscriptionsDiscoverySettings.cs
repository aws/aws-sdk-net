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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Lists the settings defined for discovering Linux subscriptions.
    /// </summary>
    public partial class LinuxSubscriptionsDiscoverySettings
    {
        private OrganizationIntegration _organizationIntegration;
        private List<string> _sourceRegions = new List<string>();

        /// <summary>
        /// Gets and sets the property OrganizationIntegration. 
        /// <para>
        /// Details if you have enabled resource discovery across your accounts in Organizations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationIntegration OrganizationIntegration
        {
            get { return this._organizationIntegration; }
            set { this._organizationIntegration = value; }
        }

        // Check to see if OrganizationIntegration property is set
        internal bool IsSetOrganizationIntegration()
        {
            return this._organizationIntegration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegions. 
        /// <para>
        /// The Regions in which to discover data for Linux subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> SourceRegions
        {
            get { return this._sourceRegions; }
            set { this._sourceRegions = value; }
        }

        // Check to see if SourceRegions property is set
        internal bool IsSetSourceRegions()
        {
            return this._sourceRegions != null && this._sourceRegions.Count > 0; 
        }

    }
}