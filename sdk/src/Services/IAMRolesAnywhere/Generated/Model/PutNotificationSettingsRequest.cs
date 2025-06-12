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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the PutNotificationSettings operation.
    /// Attaches a list of <i>notification settings</i> to a trust anchor.
    /// 
    ///  
    /// <para>
    /// A notification setting includes information such as event name, threshold, status
    /// of the notification setting, and the channel to notify.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:PutNotificationSettings</c>. 
    /// </para>
    /// </summary>
    public partial class PutNotificationSettingsRequest : AmazonIAMRolesAnywhereRequest
    {
        private List<NotificationSetting> _notificationSettings = AWSConfigs.InitializeCollections ? new List<NotificationSetting>() : null;
        private string _trustAnchorId;

        /// <summary>
        /// Gets and sets the property NotificationSettings. 
        /// <para>
        /// A list of notification settings to be associated to the trust anchor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<NotificationSetting> NotificationSettings
        {
            get { return this._notificationSettings; }
            set { this._notificationSettings = value; }
        }

        // Check to see if NotificationSettings property is set
        internal bool IsSetNotificationSettings()
        {
            return this._notificationSettings != null && (this._notificationSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrustAnchorId. 
        /// <para>
        /// The unique identifier of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TrustAnchorId
        {
            get { return this._trustAnchorId; }
            set { this._trustAnchorId = value; }
        }

        // Check to see if TrustAnchorId property is set
        internal bool IsSetTrustAnchorId()
        {
            return this._trustAnchorId != null;
        }

    }
}