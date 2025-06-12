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
    /// The state of the trust anchor after a read or write operation.
    /// </summary>
    public partial class TrustAnchorDetail
    {
        private DateTime? _createdAt;
        private bool? _enabled;
        private string _name;
        private List<NotificationSettingDetail> _notificationSettings = AWSConfigs.InitializeCollections ? new List<NotificationSettingDetail>() : null;
        private Source _source;
        private string _trustAnchorArn;
        private string _trustAnchorId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the trust anchor was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the trust anchor is enabled.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        [AWSProperty(Min=0, Max=50)]
        public List<NotificationSettingDetail> NotificationSettings
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The trust anchor type and its related certificate data.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property TrustAnchorArn. 
        /// <para>
        /// The ARN of the trust anchor.
        /// </para>
        /// </summary>
        public string TrustAnchorArn
        {
            get { return this._trustAnchorArn; }
            set { this._trustAnchorArn = value; }
        }

        // Check to see if TrustAnchorArn property is set
        internal bool IsSetTrustAnchorArn()
        {
            return this._trustAnchorArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrustAnchorId. 
        /// <para>
        /// The unique identifier of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the trust anchor was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}