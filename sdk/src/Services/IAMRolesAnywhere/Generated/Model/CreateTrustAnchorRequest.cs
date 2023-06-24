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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrustAnchor operation.
    /// Creates a trust anchor to establish trust between IAM Roles Anywhere and your certificate
    /// authority (CA). You can define a trust anchor as a reference to an Private Certificate
    /// Authority (Private CA) or by uploading a CA certificate. Your Amazon Web Services
    /// workloads can authenticate with the trust anchor using certificates issued by the
    /// CA in exchange for temporary Amazon Web Services credentials.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>rolesanywhere:CreateTrustAnchor</code>. 
    /// </para>
    /// </summary>
    public partial class CreateTrustAnchorRequest : AmazonIAMRolesAnywhereRequest
    {
        private bool? _enabled;
        private string _name;
        private List<NotificationSetting> _notificationSettings = new List<NotificationSetting>();
        private Source _source;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the trust anchor is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<NotificationSetting> NotificationSettings
        {
            get { return this._notificationSettings; }
            set { this._notificationSettings = value; }
        }

        // Check to see if NotificationSettings property is set
        internal bool IsSetNotificationSettings()
        {
            return this._notificationSettings != null && this._notificationSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The trust anchor type and its related certificate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}