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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The audio message. There is a 1 MB limit on the audio file input and the only supported
    /// format is MP3. To convert your MP3 audio files to an Alexa-friendly, 
    /// 
    ///  
    /// <para>
    /// required codec version (MPEG version 2) and bit rate (48 kbps), you might use converter
    /// software. One option for this is a command-line tool, FFmpeg. For more information,
    /// see <a href="https://www.ffmpeg.org/">FFmpeg</a>. The following command converts the
    /// provided &lt;input-file&gt; to an MP3 file that is played in the announcement:
    /// </para>
    ///  
    /// <para>
    ///  <code>ffmpeg -i &lt;input-file&gt; -ac 2 -codec:a libmp3lame -b:a 48k -ar 16000 &lt;output-file.mp3&gt;</code>
    /// 
    /// </para>
    /// </summary>
    public partial class Audio
    {
        private Locale _locale;
        private string _location;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the audio message. Currently, en-US is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the audio file. Currently, S3 URLs are supported. Only S3 locations
        /// comprised of safe characters are valid. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html#Safe%20Characters">Safe
        /// Characters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1200)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}