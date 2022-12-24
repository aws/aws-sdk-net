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
    /// Container for the parameters to the UpdateServiceSettings operation.
    /// Updates the service settings for Linux subscriptions.
    /// </summary>
    public partial class UpdateServiceSettingsRequest : AmazonLicenseManagerLinuxSubscriptionsRequest
    {
        private bool? _allowUpdate;
        private LinuxSubscriptionsDiscovery _linuxSubscriptionsDiscovery;
        private LinuxSubscriptionsDiscoverySettings _linuxSubscriptionsDiscoverySettings;

        /// <summary>
        /// Gets and sets the property AllowUpdate. 
        /// <para>
        /// Describes if updates are allowed to the service settings for Linux subscriptions.
        /// If you allow updates, you can aggregate Linux subscription data in more than one home
        /// Region.
        /// </para>
        /// </summary>
        public bool AllowUpdate
        {
            get { return this._allowUpdate.GetValueOrDefault(); }
            set { this._allowUpdate = value; }
        }

        // Check to see if AllowUpdate property is set
        internal bool IsSetAllowUpdate()
        {
            return this._allowUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinuxSubscriptionsDiscovery. 
        /// <para>
        /// Describes if the discovery of Linux subscriptions is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LinuxSubscriptionsDiscovery LinuxSubscriptionsDiscovery
        {
            get { return this._linuxSubscriptionsDiscovery; }
            set { this._linuxSubscriptionsDiscovery = value; }
        }

        // Check to see if LinuxSubscriptionsDiscovery property is set
        internal bool IsSetLinuxSubscriptionsDiscovery()
        {
            return this._linuxSubscriptionsDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property LinuxSubscriptionsDiscoverySettings. 
        /// <para>
        /// The settings defined for Linux subscriptions discovery. The settings include if Organizations
        /// integration has been enabled, and which Regions data will be aggregated from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LinuxSubscriptionsDiscoverySettings LinuxSubscriptionsDiscoverySettings
        {
            get { return this._linuxSubscriptionsDiscoverySettings; }
            set { this._linuxSubscriptionsDiscoverySettings = value; }
        }

        // Check to see if LinuxSubscriptionsDiscoverySettings property is set
        internal bool IsSetLinuxSubscriptionsDiscoverySettings()
        {
            return this._linuxSubscriptionsDiscoverySettings != null;
        }

    }
}