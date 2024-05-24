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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
        /// The method of organizing audio channels and tracks. Use <c>Audio:Channels</c> to specify
        /// the number of channels in your output, and <c>Audio:AudioPackingMode</c> to specify
        /// the number of tracks and their relation to the channels. If you do not specify an
        /// <c>Audio:AudioPackingMode</c>, Elastic Transcoder uses <c>SingleTrack</c>.
        /// </para>
        ///  
        /// <para>
        /// The following values are valid:
        /// </para>
        ///  
        /// <para>
        ///  <c>SingleTrack</c>, <c>OneChannelPerTrack</c>, and <c>OneChannelPerTrackWithMosTo8Tracks</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>SingleTrack</c>, Elastic Transcoder creates a single track for
        /// your output. The track can have up to eight channels. Use <c>SingleTrack</c> for all
        /// non-<c>mxf</c> containers.
        /// </para>
        ///  
        /// <para>
        /// The outputs of <c>SingleTrack</c> for a specific channel value and inputs are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0</c> <b> channels with any input:</b> Audio omitted from the output
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1, 2, or auto </c> <b>channels with no audio input:</b> Audio omitted from the
        /// output
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1 </c> <b>channel with any input with audio:</b> One track with one channel, downmixed
        /// if necessary
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 </c> <b>channels with one track with one channel:</b> One track with two identical
        /// channels
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 or auto </c> <b>channels with two tracks with one channel each:</b> One track
        /// with two channels
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 or auto </c> <b>channels with one track with two channels:</b> One track with
        /// two channels
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 </c> <b>channels with one track with multiple channels:</b> One track with two
        /// channels
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>auto </c> <b>channels with one track with one channel:</b> One track with one
        /// channel
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>auto </c> <b>channels with one track with multiple channels:</b> One track with
        /// multiple channels
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <c>OneChannelPerTrack</c>, Elastic Transcoder creates a new track
        /// for every channel in your output. Your output can have up to eight single-channel
        /// tracks.
        /// </para>
        ///  
        /// <para>
        /// The outputs of <c>OneChannelPerTrack</c> for a specific channel value and inputs are
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0 </c> <b>channels with any input:</b> Audio omitted from the output
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1, 2, or auto </c> <b>channels with no audio input:</b> Audio omitted from the
        /// output
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1 </c> <b>channel with any input with audio:</b> One track with one channel, downmixed
        /// if necessary
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 </c> <b>channels with one track with one channel:</b> Two tracks with one identical
        /// channel each
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 or auto </c> <b>channels with two tracks with one channel each:</b> Two tracks
        /// with one channel each
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 or auto </c> <b>channels with one track with two channels:</b> Two tracks with
        /// one channel each
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 </c> <b>channels with one track with multiple channels:</b> Two tracks with
        /// one channel each
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>auto </c> <b>channels with one track with one channel:</b> One track with one
        /// channel
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>auto </c> <b>channels with one track with multiple channels:</b> Up to eight tracks
        /// with one channel each
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <c>OneChannelPerTrackWithMosTo8Tracks</c>, Elastic Transcoder creates
        /// eight single-channel tracks for your output. All tracks that do not contain audio
        /// data from an input channel are MOS, or Mit Out Sound, tracks.
        /// </para>
        ///  
        /// <para>
        /// The outputs of <c>OneChannelPerTrackWithMosTo8Tracks</c> for a specific channel value
        /// and inputs are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0 </c> <b>channels with any input:</b> Audio omitted from the output
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1, 2, or auto </c> <b>channels with no audio input:</b> Audio omitted from the
        /// output
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1 </c> <b>channel with any input with audio:</b> One track with one channel, downmixed
        /// if necessary, plus six MOS tracks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 </c> <b>channels with one track with one channel:</b> Two tracks with one identical
        /// channel each, plus six MOS tracks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 or auto </c> <b>channels with two tracks with one channel each:</b> Two tracks
        /// with one channel each, plus six MOS tracks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 or auto </c> <b>channels with one track with two channels:</b> Two tracks with
        /// one channel each, plus six MOS tracks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2 </c> <b>channels with one track with multiple channels:</b> Two tracks with
        /// one channel each, plus six MOS tracks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>auto </c> <b>channels with one track with one channel:</b> One track with one
        /// channel, plus seven MOS tracks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>auto </c> <b>channels with one track with multiple channels:</b> Up to eight tracks
        /// with one channel each, plus MOS tracks until there are eight tracks in all
        /// </para>
        ///  </li> </ul>
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
        ///  <c>auto</c>, <c>0</c>, <c>1</c>, <c>2</c> 
        /// </para>
        ///  
        /// <para>
        /// One channel carries the information played by a single speaker. For example, a stereo
        /// track with two channels sends one channel to the left speaker, and the other channel
        /// to the right speaker. The output channels are organized into tracks. If you want Elastic
        /// Transcoder to automatically detect the number of audio channels in the input file
        /// and use that value for the output file, select <c>auto</c>.
        /// </para>
        ///  
        /// <para>
        /// The output of a specific channel value and inputs are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto</c> <b> channel specified, with any input:</b> Pass through up to eight input
        /// channels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>0</c> <b> channels specified, with any input:</b> Audio omitted from the output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1</c> <b> channel specified, with at least one input channel:</b> Mono sound.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2</c> <b> channels specified, with any input:</b> Two identical mono channels
        /// or stereo. For more information about tracks, see <c>Audio:AudioPackingMode.</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about how Elastic Transcoder organizes channels and tracks,
        /// see <c>Audio:AudioPackingMode</c>.
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
        /// The audio codec for the output file. Valid values include <c>aac</c>, <c>flac</c>,
        /// <c>mp2</c>, <c>mp3</c>, <c>pcm</c>, and <c>vorbis</c>.
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
        /// If you specified <c>AAC</c> for <c>Audio:Codec</c>, this is the <c>AAC</c> compression
        /// profile to use. Valid values include:
        /// </para>
        ///  
        /// <para>
        ///  <c>auto</c>, <c>AAC-LC</c>, <c>HE-AAC</c>, <c>HE-AACv2</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>auto</c>, Elastic Transcoder chooses a profile based on the bit
        /// rate of the output file.
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
        ///  <c>auto</c>, <c>22050</c>, <c>32000</c>, <c>44100</c>, <c>48000</c>, <c>96000</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>auto</c>, Elastic Transcoder automatically detects the sample rate.
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