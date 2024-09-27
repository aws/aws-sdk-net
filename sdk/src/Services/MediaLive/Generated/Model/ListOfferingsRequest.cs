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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the ListOfferings operation.
    /// List offerings available for purchase.
    /// </summary>
    public partial class ListOfferingsRequest : AmazonMediaLiveRequest
    {
        private string _channelClass;
        private string _channelConfiguration;
        private string _codec;
        private string _duration;
        private string _maximumBitrate;
        private string _maximumFramerate;
        private int? _maxResults;
        private string _nextToken;
        private string _resolution;
        private string _resourceType;
        private string _specialFeature;
        private string _videoQuality;

        /// <summary>
        /// Gets and sets the property ChannelClass. Filter by channel class, 'STANDARD' or 'SINGLE_PIPELINE'
        /// </summary>
        public string ChannelClass
        {
            get { return this._channelClass; }
            set { this._channelClass = value; }
        }

        // Check to see if ChannelClass property is set
        internal bool IsSetChannelClass()
        {
            return this._channelClass != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelConfiguration. Filter to offerings that match the
        /// configuration of an existing channel, e.g. '2345678' (a channel ID)
        /// </summary>
        public string ChannelConfiguration
        {
            get { return this._channelConfiguration; }
            set { this._channelConfiguration = value; }
        }

        // Check to see if ChannelConfiguration property is set
        internal bool IsSetChannelConfiguration()
        {
            return this._channelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. Filter by codec, 'AVC', 'HEVC', 'MPEG2', 'AUDIO',
        /// 'LINK', or 'AV1'
        /// </summary>
        public string Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. Filter by offering duration, e.g. '12'
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBitrate. Filter by bitrate, 'MAX_10_MBPS', 'MAX_20_MBPS',
        /// or 'MAX_50_MBPS'
        /// </summary>
        public string MaximumBitrate
        {
            get { return this._maximumBitrate; }
            set { this._maximumBitrate = value; }
        }

        // Check to see if MaximumBitrate property is set
        internal bool IsSetMaximumBitrate()
        {
            return this._maximumBitrate != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumFramerate. Filter by framerate, 'MAX_30_FPS' or
        /// 'MAX_60_FPS'
        /// </summary>
        public string MaximumFramerate
        {
            get { return this._maximumFramerate; }
            set { this._maximumFramerate = value; }
        }

        // Check to see if MaximumFramerate property is set
        internal bool IsSetMaximumFramerate()
        {
            return this._maximumFramerate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. Filter by resolution, 'SD', 'HD', 'FHD', or
        /// 'UHD'
        /// </summary>
        public string Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. Filter by resource type, 'INPUT', 'OUTPUT',
        /// 'MULTIPLEX', or 'CHANNEL'
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SpecialFeature. Filter by special feature, 'ADVANCED_AUDIO'
        /// or 'AUDIO_NORMALIZATION'
        /// </summary>
        public string SpecialFeature
        {
            get { return this._specialFeature; }
            set { this._specialFeature = value; }
        }

        // Check to see if SpecialFeature property is set
        internal bool IsSetSpecialFeature()
        {
            return this._specialFeature != null;
        }

        /// <summary>
        /// Gets and sets the property VideoQuality. Filter by video quality, 'STANDARD', 'ENHANCED',
        /// or 'PREMIUM'
        /// </summary>
        public string VideoQuality
        {
            get { return this._videoQuality; }
            set { this._videoQuality = value; }
        }

        // Check to see if VideoQuality property is set
        internal bool IsSetVideoQuality()
        {
            return this._videoQuality != null;
        }

    }
}