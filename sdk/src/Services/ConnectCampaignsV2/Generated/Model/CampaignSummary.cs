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
    /// An Amazon Connect campaign summary.
    /// </summary>
    public partial class CampaignSummary
    {
        private string _arn;
        private List<string> _channelSubtypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectCampaignFlowArn;
        private string _connectInstanceId;
        private string _id;
        private string _name;
        private Schedule _schedule;

        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=500)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelSubtypes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ChannelSubtypes
        {
            get { return this._channelSubtypes; }
            set { this._channelSubtypes = value; }
        }

        // Check to see if ChannelSubtypes property is set
        internal bool IsSetChannelSubtypes()
        {
            return this._channelSubtypes != null && (this._channelSubtypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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

    }
}