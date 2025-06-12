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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
    /// Container for the parameters to the CreateCampaign operation.
    /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
    /// </summary>
    public partial class CreateCampaignRequest : AmazonConnectCampaignsV2Request
    {
        private ChannelSubtypeConfig _channelSubtypeConfig;
        private CommunicationLimitsConfig _communicationLimitsOverride;
        private CommunicationTimeConfig _communicationTimeConfig;
        private string _connectCampaignFlowArn;
        private string _connectInstanceId;
        private string _name;
        private Schedule _schedule;
        private Source _source;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ChannelSubtypeConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelSubtypeConfig ChannelSubtypeConfig
        {
            get { return this._channelSubtypeConfig; }
            set { this._channelSubtypeConfig = value; }
        }

        // Check to see if ChannelSubtypeConfig property is set
        internal bool IsSetChannelSubtypeConfig()
        {
            return this._channelSubtypeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CommunicationLimitsOverride.
        /// </summary>
        public CommunicationLimitsConfig CommunicationLimitsOverride
        {
            get { return this._communicationLimitsOverride; }
            set { this._communicationLimitsOverride = value; }
        }

        // Check to see if CommunicationLimitsOverride property is set
        internal bool IsSetCommunicationLimitsOverride()
        {
            return this._communicationLimitsOverride != null;
        }

        /// <summary>
        /// Gets and sets the property CommunicationTimeConfig.
        /// </summary>
        public CommunicationTimeConfig CommunicationTimeConfig
        {
            get { return this._communicationTimeConfig; }
            set { this._communicationTimeConfig = value; }
        }

        // Check to see if CommunicationTimeConfig property is set
        internal bool IsSetCommunicationTimeConfig()
        {
            return this._communicationTimeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectCampaignFlowArn.
        /// </summary>
        [AWSProperty(Min=20, Max=500)]
        public string ConnectCampaignFlowArn
        {
            get { return this._connectCampaignFlowArn; }
            set { this._connectCampaignFlowArn = value; }
        }

        // Check to see if ConnectCampaignFlowArn property is set
        internal bool IsSetConnectCampaignFlowArn()
        {
            return this._connectCampaignFlowArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectInstanceId.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ConnectInstanceId
        {
            get { return this._connectInstanceId; }
            set { this._connectInstanceId = value; }
        }

        // Check to see if ConnectInstanceId property is set
        internal bool IsSetConnectInstanceId()
        {
            return this._connectInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
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
        /// Gets and sets the property Schedule.
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Source.
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
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}