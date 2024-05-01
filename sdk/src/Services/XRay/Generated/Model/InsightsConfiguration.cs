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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// The structure containing configurations related to insights.
    /// </summary>
    public partial class InsightsConfiguration
    {
        private bool? _insightsEnabled;
        private bool? _notificationsEnabled;

        /// <summary>
        /// Gets and sets the property InsightsEnabled. 
        /// <para>
        /// Set the InsightsEnabled value to true to enable insights or false to disable insights.
        /// </para>
        /// </summary>
        public bool? InsightsEnabled
        {
            get { return this._insightsEnabled; }
            set { this._insightsEnabled = value; }
        }

        // Check to see if InsightsEnabled property is set
        internal bool IsSetInsightsEnabled()
        {
            return this._insightsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationsEnabled. 
        /// <para>
        /// Set the NotificationsEnabled value to true to enable insights notifications. Notifications
        /// can only be enabled on a group with InsightsEnabled set to true.
        /// </para>
        /// </summary>
        public bool? NotificationsEnabled
        {
            get { return this._notificationsEnabled; }
            set { this._notificationsEnabled = value; }
        }

        // Check to see if NotificationsEnabled property is set
        internal bool IsSetNotificationsEnabled()
        {
            return this._notificationsEnabled.HasValue; 
        }

    }
}