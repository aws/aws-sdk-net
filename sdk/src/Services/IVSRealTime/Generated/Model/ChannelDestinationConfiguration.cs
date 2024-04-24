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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Object specifying a channel as a destination.
    /// </summary>
    public partial class ChannelDestinationConfiguration
    {
        private string _channelArn;
        private string _encoderConfigurationArn;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// ARN of the channel to use for broadcasting. The channel and stage resources must be
        /// in the same AWS account and region. The channel must be offline (not broadcasting).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncoderConfigurationArn. 
        /// <para>
        /// ARN of the <a>EncoderConfiguration</a> resource. The encoder configuration and stage
        /// resources must be in the same AWS account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EncoderConfigurationArn
        {
            get { return this._encoderConfigurationArn; }
            set { this._encoderConfigurationArn = value; }
        }

        // Check to see if EncoderConfigurationArn property is set
        internal bool IsSetEncoderConfigurationArn()
        {
            return this._encoderConfigurationArn != null;
        }

    }
}