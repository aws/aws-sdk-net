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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The information for a notify configuration in an Amazon Web Services account.
    /// </summary>
    public partial class NotifyConfigurationInformation
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the notify configuration was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultTemplateId. 
        /// <para>
        /// The default template identifier associated with the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DefaultTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTemplateId property is set.
        /// </summary>
        internal bool IsSetDefaultTemplateId() => this.DefaultTemplateId != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// When set to true deletion protection is enabled. By default this is set to false.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name associated with the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EnabledChannels. 
        /// <para>
        /// An array of channels enabled for the notify configuration. Supported values include
        /// <c>SMS</c> and <c>VOICE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public List<string> EnabledChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledChannels property is set.
        /// </summary>
        internal bool IsSetEnabledChannels() => this.EnabledChannels != null && (this.EnabledChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnabledCountries. 
        /// <para>
        /// An array of two-character ISO country codes, in ISO 3166-1 alpha-2 format, that are
        /// enabled for the notify configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public List<string> EnabledCountries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledCountries property is set.
        /// </summary>
        internal bool IsSetEnabledCountries() => this.EnabledCountries != null && (this.EnabledCountries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotifyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string NotifyConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotifyConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotifyConfigurationArn() => this.NotifyConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property NotifyConfigurationId. 
        /// <para>
        /// The unique identifier for the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string NotifyConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the NotifyConfigurationId property is set.
        /// </summary>
        internal bool IsSetNotifyConfigurationId() => this.NotifyConfigurationId != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The identifier of the pool associated with the notify configuration.
        /// </para>
        /// </summary>
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// The reason the notify configuration was rejected, if applicable.
        /// </para>
        /// </summary>
        public string RejectionReason { get; set; }

        /// <summary>
        /// Checks to see if the RejectionReason property is set.
        /// </summary>
        internal bool IsSetRejectionReason() => this.RejectionReason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotifyConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotifyConfigurationTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property TierUpgradeStatus. 
        /// <para>
        /// The tier upgrade status of the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TierUpgradeStatus TierUpgradeStatus { get; set; }

        /// <summary>
        /// Checks to see if the TierUpgradeStatus property is set.
        /// </summary>
        internal bool IsSetTierUpgradeStatus() => this.TierUpgradeStatus != null;

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// The use case for the notify configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotifyConfigurationUseCase UseCase { get; set; }

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null;
    }
}
