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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNotifyConfiguration operation.
    /// Updates an existing notify configuration. You can update the default template, pool
    /// association, enabled channels, enabled countries, and deletion protection settings.
    /// </summary>
    public partial class UpdateNotifyConfigurationRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _defaultTemplateId;
        private bool? _deletionProtectionEnabled;
        private List<string> _enabledChannels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _enabledCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _notifyConfigurationId;
        private string _poolId;

        /// <summary>
        /// Gets and sets the property DefaultTemplateId. 
        /// <para>
        /// The template ID to set as the default, or the special value UNSET_DEFAULT_TEMPLATE
        /// to clear the current default template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DefaultTemplateId
        {
            get { return this._defaultTemplateId; }
            set { this._defaultTemplateId = value; }
        }

        // Check to see if DefaultTemplateId property is set
        internal bool IsSetDefaultTemplateId()
        {
            return this._defaultTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// When set to true the notify configuration can't be deleted.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EnabledChannels. 
        /// <para>
        /// An array of channels to enable for the notify configuration. Supported values include
        /// <c>SMS</c> and <c>VOICE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> EnabledChannels
        {
            get { return this._enabledChannels; }
            set { this._enabledChannels = value; }
        }

        // Check to see if EnabledChannels property is set
        internal bool IsSetEnabledChannels()
        {
            return this._enabledChannels != null && (this._enabledChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnabledCountries. 
        /// <para>
        /// An array of two-character ISO country codes, in ISO 3166-1 alpha-2 format, that are
        /// enabled for the notify configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public List<string> EnabledCountries
        {
            get { return this._enabledCountries; }
            set { this._enabledCountries = value; }
        }

        // Check to see if EnabledCountries property is set
        internal bool IsSetEnabledCountries()
        {
            return this._enabledCountries != null && (this._enabledCountries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotifyConfigurationId. 
        /// <para>
        /// The identifier of the notify configuration to update. The NotifyConfigurationId can
        /// be found using the <a>DescribeNotifyConfigurations</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NotifyConfigurationId
        {
            get { return this._notifyConfigurationId; }
            set { this._notifyConfigurationId = value; }
        }

        // Check to see if NotifyConfigurationId property is set
        internal bool IsSetNotifyConfigurationId()
        {
            return this._notifyConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The pool ID or ARN to associate, or the special value UNSET_DEFAULT_POOL_FOR_NOTIFY
        /// to clear the current default pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

    }
}