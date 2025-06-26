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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Configuration settings for proactively refreshing OAuth tokens before they expire.
    /// </summary>
    public partial class ProactiveRefreshTokenRenewal
    {
        private int? _daysBeforeRenewal;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property DaysBeforeRenewal. 
        /// <para>
        /// The days before token expiration when the system should attempt to renew the token,
        /// specified in days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30)]
        public int? DaysBeforeRenewal
        {
            get { return this._daysBeforeRenewal; }
            set { this._daysBeforeRenewal = value; }
        }

        // Check to see if DaysBeforeRenewal property is set
        internal bool IsSetDaysBeforeRenewal()
        {
            return this._daysBeforeRenewal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether proactive refresh token renewal is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}