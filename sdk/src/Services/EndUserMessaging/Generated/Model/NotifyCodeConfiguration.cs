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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Contains the settings of a notify code configuration, which is a reusable one-time
    /// passcode policy.
    /// </summary>
    public partial class NotifyCodeConfiguration
    {
        private ChannelParameters _channelParameters;
        private CodeConfigurationParameters _codeConfigurationParameters;
        private DateTime? _createdAt;
        private bool? _deletionProtectionEnabled;
        private string _notifyCodeConfigurationArn;
        private string _notifyCodeConfigurationId;
        private string _notifyCodeConfigurationName;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ChannelParameters. 
        /// <para>
        /// The channel-specific parameters used to render and deliver the one-time passcode.
        /// A configuration can carry parameters for every channel at once, and the send route
        /// selects the matching channel at send time.
        /// </para>
        /// </summary>
        public ChannelParameters ChannelParameters
        {
            get { return this._channelParameters; }
            set { this._channelParameters = value; }
        }

        // Check to see if ChannelParameters property is set
        internal bool IsSetChannelParameters()
        {
            return this._channelParameters != null;
        }

        /// <summary>
        /// Gets and sets the property CodeConfigurationParameters. 
        /// <para>
        /// The passcode policy parameters, including the code type, length, validity period,
        /// and maximum number of attempts.
        /// </para>
        /// </summary>
        public CodeConfigurationParameters CodeConfigurationParameters
        {
            get { return this._codeConfigurationParameters; }
            set { this._codeConfigurationParameters = value; }
        }

        // Check to see if CodeConfigurationParameters property is set
        internal bool IsSetCodeConfigurationParameters()
        {
            return this._codeConfigurationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the resource was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether deletion protection is enabled. When enabled, the resource cannot
        /// be deleted until deletion protection is turned off.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=256)]
        public string NotifyCodeConfigurationArn
        {
            get { return this._notifyCodeConfigurationArn; }
            set { this._notifyCodeConfigurationArn = value; }
        }

        // Check to see if NotifyCodeConfigurationArn property is set
        internal bool IsSetNotifyCodeConfigurationArn()
        {
            return this._notifyCodeConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationId. 
        /// <para>
        /// The unique identifier of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string NotifyCodeConfigurationId
        {
            get { return this._notifyCodeConfigurationId; }
            set { this._notifyCodeConfigurationId = value; }
        }

        // Check to see if NotifyCodeConfigurationId property is set
        internal bool IsSetNotifyCodeConfigurationId()
        {
            return this._notifyCodeConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationName. 
        /// <para>
        /// The name of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string NotifyCodeConfigurationName
        {
            get { return this._notifyCodeConfigurationName; }
            set { this._notifyCodeConfigurationName = value; }
        }

        // Check to see if NotifyCodeConfigurationName property is set
        internal bool IsSetNotifyCodeConfigurationName()
        {
            return this._notifyCodeConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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