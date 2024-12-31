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
    /// A request to update the provisioned capacity settings for querying data.
    /// </summary>
    public partial class ProvisionedCapacityRequest
    {
        private AccountSettingsNotificationConfiguration _notificationConfiguration;
        private int? _targetQueryTCU;

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Configuration settings for notifications related to the provisioned capacity update.
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

        /// <summary>
        /// Gets and sets the property TargetQueryTCU. 
        /// <para>
        /// The target compute capacity for querying data, specified in Timestream Compute Units
        /// (TCUs).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TargetQueryTCU
        {
            get { return this._targetQueryTCU; }
            set { this._targetQueryTCU = value; }
        }

        // Check to see if TargetQueryTCU property is set
        internal bool IsSetTargetQueryTCU()
        {
            return this._targetQueryTCU.HasValue; 
        }

    }
}