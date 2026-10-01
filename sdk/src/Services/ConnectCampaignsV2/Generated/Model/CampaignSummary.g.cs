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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// An Amazon Connect campaign summary.
    /// </summary>
    public partial class CampaignSummary
    {
        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 500)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChannelSubtypes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ChannelSubtypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChannelSubtypes property is set.
        /// </summary>
        internal bool IsSetChannelSubtypes() => this.ChannelSubtypes != null && (this.ChannelSubtypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectCampaignFlowArn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 500)]
        public string ConnectCampaignFlowArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectCampaignFlowArn property is set.
        /// </summary>
        internal bool IsSetConnectCampaignFlowArn() => this.ConnectCampaignFlowArn != null;

        /// <summary>
        /// Gets and sets the property ConnectInstanceId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConnectInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectInstanceId property is set.
        /// </summary>
        internal bool IsSetConnectInstanceId() => this.ConnectInstanceId != null;

        /// <summary>
        /// Gets and sets the property EntryLimitsConfig.
        /// </summary>
        public EntryLimitsConfig EntryLimitsConfig { get; set; }

        /// <summary>
        /// Checks to see if the EntryLimitsConfig property is set.
        /// </summary>
        internal bool IsSetEntryLimitsConfig() => this.EntryLimitsConfig != null;

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schedule.
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public ExternalCampaignType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
