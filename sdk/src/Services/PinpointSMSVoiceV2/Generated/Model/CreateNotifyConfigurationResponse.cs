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
    /// This is the response object from the CreateNotifyConfiguration operation.
    /// </summary>
    public partial class CreateNotifyConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private string _defaultTemplateId;
        private bool? _deletionProtectionEnabled;
        private string _displayName;
        private List<string> _enabledChannels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _enabledCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _notifyConfigurationArn;
        private string _notifyConfigurationId;
        private string _poolId;
        private string _rejectionReason;
        private NotifyConfigurationStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private NotifyConfigurationTier _tier;
        private TierUpgradeStatus _tierUpgradeStatus;
        private NotifyConfigurationUseCase _useCase;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the notify configuration was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultTemplateId. 
        /// <para>
        /// The default template identifier associated with the notify configuration.
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
        /// When set to true deletion protection is enabled. By default this is set to false.
        /// 
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name associated with the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledChannels. 
        /// <para>
        /// An array of channels enabled for the notify configuration. Supported values include
        /// <c>SMS</c> and <c>VOICE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
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
        /// Gets and sets the property NotifyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NotifyConfigurationArn
        {
            get { return this._notifyConfigurationArn; }
            set { this._notifyConfigurationArn = value; }
        }

        // Check to see if NotifyConfigurationArn property is set
        internal bool IsSetNotifyConfigurationArn()
        {
            return this._notifyConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyConfigurationId. 
        /// <para>
        /// The unique identifier for the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// The identifier of the pool associated with the notify configuration.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// The reason the notify configuration was rejected, if applicable.
        /// </para>
        /// </summary>
        public string RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotifyConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) associated with the notify configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotifyConfigurationTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property TierUpgradeStatus. 
        /// <para>
        /// The tier upgrade status of the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TierUpgradeStatus TierUpgradeStatus
        {
            get { return this._tierUpgradeStatus; }
            set { this._tierUpgradeStatus = value; }
        }

        // Check to see if TierUpgradeStatus property is set
        internal bool IsSetTierUpgradeStatus()
        {
            return this._tierUpgradeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// The use case for the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotifyConfigurationUseCase UseCase
        {
            get { return this._useCase; }
            set { this._useCase = value; }
        }

        // Check to see if UseCase property is set
        internal bool IsSetUseCase()
        {
            return this._useCase != null;
        }

    }
}