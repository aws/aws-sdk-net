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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
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
namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// An Amazon Connect campaign.
    /// </summary>
    public partial class Campaign
    {
        private string _arn;
        private string _connectInstanceId;
        private DialerConfig _dialerConfig;
        private string _id;
        private string _name;
        private OutboundCallConfig _outboundCallConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property DialerConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public DialerConfig DialerConfig
        {
            get { return this._dialerConfig; }
            set { this._dialerConfig = value; }
        }

        // Check to see if DialerConfig property is set
        internal bool IsSetDialerConfig()
        {
            return this._dialerConfig != null;
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
        /// Gets and sets the property OutboundCallConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutboundCallConfig OutboundCallConfig
        {
            get { return this._outboundCallConfig; }
            set { this._outboundCallConfig = value; }
        }

        // Check to see if OutboundCallConfig property is set
        internal bool IsSetOutboundCallConfig()
        {
            return this._outboundCallConfig != null;
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