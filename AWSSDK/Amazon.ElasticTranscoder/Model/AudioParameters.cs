/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioParameters
    {
        
        private string codec;
        private string sampleRate;
        private string bitRate;
        private string channels;

        /// <summary>
        /// The audio codec for the output file. This value must be <c>AAC</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^AAC$)|(^vorbis$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Codec
        {
            get { return this.codec; }
            set { this.codec = value; }
        }

        /// <summary>
        /// Sets the Codec property
        /// </summary>
        /// <param name="codec">The value to set for the Codec property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithCodec(string codec)
        {
            this.codec = codec;
            return this;
        }
            

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this.codec != null;
        }

        /// <summary>
        /// The sample rate of the audio stream in the output file, in Hertz. Valid values include: <c>auto</c>, <c>22050</c>, <c>32000</c>,
        /// <c>44100</c>, <c>48000</c>, <c>96000</c> If you specify <c>auto</c>, Elastic Transcoder automatically detects the sample rate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^22050$)|(^32000$)|(^44100$)|(^48000$)|(^96000$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SampleRate
        {
            get { return this.sampleRate; }
            set { this.sampleRate = value; }
        }

        /// <summary>
        /// Sets the SampleRate property
        /// </summary>
        /// <param name="sampleRate">The value to set for the SampleRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithSampleRate(string sampleRate)
        {
            this.sampleRate = sampleRate;
            return this;
        }
            

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this.sampleRate != null;
        }

        /// <summary>
        /// The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,3}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string BitRate
        {
            get { return this.bitRate; }
            set { this.bitRate = value; }
        }

        /// <summary>
        /// Sets the BitRate property
        /// </summary>
        /// <param name="bitRate">The value to set for the BitRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithBitRate(string bitRate)
        {
            this.bitRate = bitRate;
            return this;
        }
            

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this.bitRate != null;
        }

        /// <summary>
        /// The number of audio channels in the output file. Valid values include: <c>auto</c>, <c>0</c>, <c>1</c>, <c>2</c> If you specify <c>auto</c>,
        /// Elastic Transcoder automatically detects the number of channels in the input file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^0$)|(^1$)|(^2$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Channels
        {
            get { return this.channels; }
            set { this.channels = value; }
        }

        /// <summary>
        /// Sets the Channels property
        /// </summary>
        /// <param name="channels">The value to set for the Channels property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithChannels(string channels)
        {
            this.channels = channels;
            return this;
        }
            

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this.channels != null;
        }
    }
}
