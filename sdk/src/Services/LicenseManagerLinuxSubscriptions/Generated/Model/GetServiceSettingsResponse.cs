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
    /// This is the response object from the GetServiceSettings operation.
    /// </summary>
    public partial class GetServiceSettingsResponse : AmazonWebServiceResponse
    {
        private List<string> _homeRegions = new List<string>();
        private LinuxSubscriptionsDiscovery _linuxSubscriptionsDiscovery;
        private LinuxSubscriptionsDiscoverySettings _linuxSubscriptionsDiscoverySettings;
        private Status _status;
        private Dictionary<string, string> _statusMessage = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property HomeRegions. 
        /// <para>
        /// The Region in which License Manager displays the aggregated data for Linux subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> HomeRegions
        {
            get { return this._homeRegions; }
            set { this._homeRegions = value; }
        }

        // Check to see if HomeRegions property is set
        internal bool IsSetHomeRegions()
        {
            return this._homeRegions != null && this._homeRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LinuxSubscriptionsDiscovery. 
        /// <para>
        /// Lists if discovery has been enabled for Linux subscriptions.
        /// </para>
        /// </summary>
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
        /// Lists the settings defined for Linux subscriptions discovery. The settings include
        /// if Organizations integration has been enabled, and which Regions data will be aggregated
        /// from.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of Linux subscriptions settings being applied.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message which details the Linux subscriptions service settings current status.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null && this._statusMessage.Count > 0; 
        }

    }
}