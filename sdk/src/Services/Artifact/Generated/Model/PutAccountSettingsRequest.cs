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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountSettings operation.
    /// Put the account settings for Artifact.
    /// </summary>
    public partial class PutAccountSettingsRequest : AmazonArtifactRequest
    {
        private NotificationSubscriptionStatus _notificationSubscriptionStatus;

        /// <summary>
        /// Gets and sets the property NotificationSubscriptionStatus. 
        /// <para>
        /// Desired notification subscription status.
        /// </para>
        /// </summary>
        public NotificationSubscriptionStatus NotificationSubscriptionStatus
        {
            get { return this._notificationSubscriptionStatus; }
            set { this._notificationSubscriptionStatus = value; }
        }

        // Check to see if NotificationSubscriptionStatus property is set
        internal bool IsSetNotificationSubscriptionStatus()
        {
            return this._notificationSubscriptionStatus != null;
        }

    }
}