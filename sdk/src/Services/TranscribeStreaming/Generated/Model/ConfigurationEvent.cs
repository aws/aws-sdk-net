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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Allows you to set audio channel definitions and post-call analytics settings.
    /// </summary>
    public partial class ConfigurationEvent
        : IEventStreamEvent
    {
        private List<ChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<ChannelDefinition>() : null;
        private PostCallAnalyticsSettings _postCallAnalyticsSettings;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Indicates which speaker is on which audio channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<ChannelDefinition> ChannelDefinitions
        {
            get { return this._channelDefinitions; }
            set { this._channelDefinitions = value; }
        }

        // Check to see if ChannelDefinitions property is set
        internal bool IsSetChannelDefinitions()
        {
            return this._channelDefinitions != null && (this._channelDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PostCallAnalyticsSettings. 
        /// <para>
        /// Provides additional optional settings for your Call Analytics post-call request, including
        /// encryption and output locations for your redacted transcript.
        /// </para>
        ///  
        /// <para>
        ///  <c>PostCallAnalyticsSettings</c> provides you with the same insights as a Call Analytics
        /// post-call transcription. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-post-call.html">Post-call
        /// analytics</a> for more information on this feature.
        /// </para>
        /// </summary>
        public PostCallAnalyticsSettings PostCallAnalyticsSettings
        {
            get { return this._postCallAnalyticsSettings; }
            set { this._postCallAnalyticsSettings = value; }
        }

        // Check to see if PostCallAnalyticsSettings property is set
        internal bool IsSetPostCallAnalyticsSettings()
        {
            return this._postCallAnalyticsSettings != null;
        }

    }
}