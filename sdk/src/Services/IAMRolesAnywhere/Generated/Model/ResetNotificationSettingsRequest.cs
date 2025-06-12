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
    /// Container for the parameters to the ResetNotificationSettings operation.
    /// Resets the <i>custom notification setting</i> to IAM Roles Anywhere default setting.
    /// 
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:ResetNotificationSettings</c>. 
    /// </para>
    /// </summary>
    public partial class ResetNotificationSettingsRequest : AmazonIAMRolesAnywhereRequest
    {
        private List<NotificationSettingKey> _notificationSettingKeys = AWSConfigs.InitializeCollections ? new List<NotificationSettingKey>() : null;
        private string _trustAnchorId;

        /// <summary>
        /// Gets and sets the property NotificationSettingKeys. 
        /// <para>
        /// A list of notification setting keys to reset. A notification setting key includes
        /// the event and the channel. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<NotificationSettingKey> NotificationSettingKeys
        {
            get { return this._notificationSettingKeys; }
            set { this._notificationSettingKeys = value; }
        }

        // Check to see if NotificationSettingKeys property is set
        internal bool IsSetNotificationSettingKeys()
        {
            return this._notificationSettingKeys != null && (this._notificationSettingKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
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