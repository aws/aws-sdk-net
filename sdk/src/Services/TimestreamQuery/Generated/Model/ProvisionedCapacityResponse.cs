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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// The response to a request to update the provisioned capacity settings for querying
    /// data.
    /// </summary>
    public partial class ProvisionedCapacityResponse
    {
        private int? _activeQueryTCU;
        private LastUpdate _lastUpdate;
        private AccountSettingsNotificationConfiguration _notificationConfiguration;

        /// <summary>
        /// Gets and sets the property ActiveQueryTCU. 
        /// <para>
        /// The number of Timestream Compute Units (TCUs) provisioned in the account. This field
        /// is only visible when the compute mode is <c>PROVISIONED</c>.
        /// </para>
        /// </summary>
        public int? ActiveQueryTCU
        {
            get { return this._activeQueryTCU; }
            set { this._activeQueryTCU = value; }
        }

        // Check to see if ActiveQueryTCU property is set
        internal bool IsSetActiveQueryTCU()
        {
            return this._activeQueryTCU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdate. 
        /// <para>
        /// Information about the last update to the provisioned capacity settings.
        /// </para>
        /// </summary>
        public LastUpdate LastUpdate
        {
            get { return this._lastUpdate; }
            set { this._lastUpdate = value; }
        }

        // Check to see if LastUpdate property is set
        internal bool IsSetLastUpdate()
        {
            return this._lastUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// An object that contains settings for notifications that are sent whenever the provisioned
        /// capacity settings are modified. This field is only visible when the compute mode is
        /// <c>PROVISIONED</c>.
        /// </para>
        /// </summary>
        public AccountSettingsNotificationConfiguration NotificationConfiguration
        {
            get { return this._notificationConfiguration; }
            set { this._notificationConfiguration = value; }
        }

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this._notificationConfiguration != null;
        }

    }
}