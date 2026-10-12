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
    /// The information for a system-managed notify template in an Amazon Web Services account.
    /// </summary>
    public partial class NotifyTemplateInformation
    {
        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The channels for the template. Supported values are <c>SMS</c> and <c>VOICE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public List<string> Channels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels != null && (this.Channels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the notify template was created, in <a href="https://www.epochconverter.com/">UNIX
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
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the template.
        /// </para>
        /// </summary>
        public NotifyTemplateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SupportedCountries. 
        /// <para>
        /// An array of supported country codes for the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public List<string> SupportedCountries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedCountries property is set.
        /// </summary>
        internal bool IsSetSupportedCountries() => this.SupportedCountries != null && (this.SupportedCountries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedVoiceIds. 
        /// <para>
        /// An array of supported voice IDs for voice templates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<string> SupportedVoiceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedVoiceIds property is set.
        /// </summary>
        internal bool IsSetSupportedVoiceIds() => this.SupportedVoiceIds != null && (this.SupportedVoiceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The unique identifier for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotifyTemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;

        /// <summary>
        /// Gets and sets the property TierAccess. 
        /// <para>
        /// The tier access level for the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> TierAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TierAccess property is set.
        /// </summary>
        internal bool IsSetTierAccess() => this.TierAccess != null && (this.TierAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// An array of template variable metadata for the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, TemplateVariableMetadata> Variables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TemplateVariableMetadata>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
