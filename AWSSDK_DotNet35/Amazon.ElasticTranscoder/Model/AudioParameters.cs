/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Parameters required for transcoding audio.
    /// </summary>
    public partial class AudioParameters
    {
        private string _audioPackingMode;
        private string _bitRate;
        private string _channels;
        private string _codec;
        private AudioCodecOptions _codecOptions;
        private string _sampleRate;

        /// <summary>
        /// Gets and sets the property AudioPackingMode. 
        /// <para>
        /// The method of organizing audio channels and tracks. Use <code>Audio:Channels</code>
        /// to specify the number of channels in your output, and <code>Audio:AudioPackingMode</code>
        /// to specify the number of tracks and their relation to the channels. If you do not
        /// specify an <code>Audio:AudioPackingMode</code>, Elastic Transcoder uses <code>SingleTrack</code>.
        /// </para>
        ///  
        /// <para>
        /// The following values are valid:
        /// </para>
        ///  
        /// <para>
        /// <code>SingleTrack</code>, <code>OneChannelPerTrack</code>, and <code>OneChannelPerTrackWithMosTo8Tracks</code>
        /// </para>
        ///  
        /// <para>
        /// When you specify <code>SingleTrack</code>, Elastic Transcoder creates a single track
        /// for your output. The track can have up to eight channels. Use <code>SingleTrack</code>
        /// for all non-<code>mxf</code> containers.
        /// </para>
        ///  
        /// <para>
        /// The outputs of <code>SingleTrack</code> for a specific channel value and inputs are
        /// as follows:
        /// </para>
        ///  <ul> <li> <code>0</code> <b> channels with any input:</b> Audio omitted from the
        /// output</li> <li> <code>1, 2, or auto </code> <b>channels with no audio input:</b>
        /// Audio omitted from the output</li> <li> <code>1 </code> <b>channel with any input
        /// with audio:</b> One track with one channel, downmixed if necessary</li> <li> <code>2
        /// </code> <b>channels with one track with one channel:</b> One track with two identical
        /// channels</li> <li> <code>2 or auto </code> <b>channels with two tracks with one channel
        /// each:</b> One track with two channels</li> <li> <code>2 or auto </code> <b>channels
        /// with one track with two channels:</b> One track with two channels</li> <li> <code>2
        /// </code> <b>channels with one track with multiple channels:</b> One track with two
        /// channels</li> <li> <code>auto </code> <b>channels with one track with one channel:</b>
        /// One track with one channel</li> <li> <code>auto </code> <b>channels with one track
        /// with multiple channels:</b> One track with multiple channels</li> </ul> 
        /// <para>
        /// When you specify <code>OneChannelPerTrack</code>, Elastic Transcoder creates a new
        /// track for every channel in your output. Your output can have up to eight single-channel
        /// tracks.
        /// </para>
        ///  
        /// <para>
        /// The outputs of <code>OneChannelPerTrack</code> for a specific channel value and inputs
        /// are as follows:
        /// </para>
        ///  <ul> <li> <code>0 </code> <b>channels with any input:</b> Audio omitted from the
        /// output</li> <li> <code>1, 2, or auto </code> <b>channels with no audio input:</b>
        /// Audio omitted from the output</li> <li> <code>1 </code> <b>channel with any input
        /// with audio:</b> One track with one channel, downmixed if necessary</li> <li> <code>2
        /// </code> <b>channels with one track with one channel:</b> Two tracks with one identical
        /// channel each</li> <li> <code>2 or auto </code> <b>channels with two tracks with one
        /// channel each:</b> Two tracks with one channel each</li> <li> <code>2 or auto </code>
        /// <b>channels with one track with two channels:</b> Two tracks with one channel each</li>
        /// <li> <code>2 </code> <b>channels with one track with multiple channels:</b> Two tracks
        /// with one channel each</li> <li> <code>auto </code> <b>channels with one track with
        /// one channel:</b> One track with one channel</li> <li> <code>auto </code> <b>channels
        /// with one track with multiple channels:</b> Up to eight tracks with one channel each</li>
        /// </ul> 
        /// <para>
        /// When you specify <code>OneChannelPerTrackWithMosTo8Tracks</code>, Elastic Transcoder
        /// creates eight single-channel tracks for your output. All tracks that do not contain
        /// audio data from an input channel are MOS, or Mit Out Sound, tracks.
        /// </para>
        ///  
        /// <para>
        /// The outputs of <code>OneChannelPerTrackWithMosTo8Tracks</code> for a specific channel
        /// value and inputs are as follows:
        /// </para>
        ///  <ul> <li> <code>0 </code> <b>channels with any input:</b> Audio omitted from the
        /// output</li> <li> <code>1, 2, or auto </code> <b>channels with no audio input:</b>
        /// Audio omitted from the output</li> <li> <code>1 </code> <b>channel with any input
        /// with audio:</b> One track with one channel, downmixed if necessary, plus six MOS tracks</li>
        /// <li> <code>2 </code> <b>channels with one track with one channel:</b> Two tracks with
        /// one identical channel each, plus six MOS tracks</li> <li> <code>2 or auto </code>
        /// <b>channels with two tracks with one channel each:</b> Two tracks with one channel
        /// each, plus six MOS tracks</li> <li> <code>2 or auto </code> <b>channels with one track
        /// with two channels:</b> Two tracks with one channel each, plus six MOS tracks</li>
        /// <li> <code>2 </code> <b>channels with one track with multiple channels:</b> Two tracks
        /// with one channel each, plus six MOS tracks</li> <li> <code>auto </code> <b>channels
        /// with one track with one channel:</b> One track with one channel, plus seven MOS tracks</li>
        /// <li> <code>auto </code> <b>channels with one track with multiple channels:</b> Up
        /// to eight tracks with one channel each, plus MOS tracks until there are eight tracks
        /// in all</li> </ul>
        /// </summary>
        public string AudioPackingMode
        {
            get { return this._audioPackingMode; }
            set { this._audioPackingMode = value; }
        }

        // Check to see if AudioPackingMode property is set
        internal bool IsSetAudioPackingMode()
        {
            return this._audioPackingMode != null;
        }

        /// <summary>
        /// Gets and sets the property BitRate. 
        /// <para>
        /// The bit rate of the audio stream in the output file, in kilobits/second. Enter an
        /// integer between 64 and 320, inclusive.
        /// </para>
        /// </summary>
        public string BitRate
        {
            get { return this._bitRate; }
            set { this._bitRate = value; }
        }

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this._bitRate != null;
        }

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The number of audio channels in the output file. The following values are valid:
        /// </para>
        ///  
        /// <para>
        /// <code>auto</code>, <code>0</code>, <code>1</code>, <code>2</code>
        /// </para>
        ///  
        /// <para>
        /// One channel carries the information played by a single speaker. For example, a stereo
        /// track with two channels sends one channel to the left speaker, and the other channel
        /// to the right speaker. The output channels are organized into tracks. If you want Elastic
        /// Transcoder to automatically detect the number of audio channels in the input file
        /// and use that value for the output file, select <code>auto</code>.
        /// </para>
        ///  
        /// <para>
        /// The output of a specific channel value and inputs are as follows:
        /// </para>
        ///  <ul> <li> <code>auto</code><b> channel specified, with any input:</b> Pass through
        /// up to eight input channels.</li> <li> <code>0</code><b> channels specified, with any
        /// input:</b> Audio omitted from the output.</li> <li> <code>1</code><b> channel specified,
        /// with at least one input channel:</b> Mono sound.</li> <li> <code>2</code><b> channels
        /// specified, with any input:</b> Two identical mono channels or stereo. For more information
        /// about tracks, see <code>Audio:AudioPackingMode.</code> </li> </ul> 
        /// <para>
        ///  For more information about how Elastic Transcoder organizes channels and tracks,
        /// see <code>Audio:AudioPackingMode</code>.
        /// </para>
        /// </summary>
        public string Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// The audio codec for the output file. Valid values include <code>aac</code>, <code>flac</code>,
        /// <code>mp2</code>, <code>mp3</code>, <code>pcm</code>, and <code>vorbis</code>.
        /// </para>
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
        /// Gets and sets the property CodecOptions. 
        /// <para>
        /// If you specified <code>AAC</code> for <code>Audio:Codec</code>, this is the <code>AAC</code>
        /// compression profile to use. Valid values include:
        /// </para>
        ///  
        /// <para>
        /// <code>auto</code>, <code>AAC-LC</code>, <code>HE-AAC</code>, <code>HE-AACv2</code>
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder chooses a profile based on the
        /// bit rate of the output file.
        /// </para>
        /// </summary>
        public AudioCodecOptions CodecOptions
        {
            get { return this._codecOptions; }
            set { this._codecOptions = value; }
        }

        // Check to see if CodecOptions property is set
        internal bool IsSetCodecOptions()
        {
            return this._codecOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The sample rate of the audio stream in the output file, in Hertz. Valid values include:
        /// </para>
        ///  
        /// <para>
        /// <code>auto</code>, <code>22050</code>, <code>32000</code>, <code>44100</code>, <code>48000</code>,
        /// <code>96000</code>
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder automatically detects the sample
        /// rate.
        /// </para>
        /// </summary>
        public string SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate != null;
        }

    }
}