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
    /// A source file for the input sidecar captions used during the transcoding         process.
    /// </summary>
    public partial class CaptionSource
    {
        private string _key;
        private string _label;
        private string _language;
        private string _timeOffset;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the sidecar caption file that you want Elastic Transcoder to include in
        /// the         output file.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label of the caption shown in the player when choosing         a language. We
        /// recommend that you put the caption language name here,          in the language of
        /// the captions.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A string that specifies the language of the caption. Specify this as one of:
        /// </para>
        ///       <ul>         <li>
        /// <para>
        /// 2-character ISO 639-1 code
        /// </para>
        /// </li>         <li>
        /// <para>
        /// 3-character ISO 639-2 code
        /// </para>
        /// </li>      </ul>      
        /// <para>
        /// For more information on ISO language codes and language names, see the List of ISO
        ///          639-1 codes.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property TimeOffset. 
        /// <para>
        /// For clip generation or captions that do not start at the same time         as the
        /// associated video file, the <code>TimeOffset</code> tells Elastic Transcoder how much
        /// of the video to encode         before including captions.
        /// </para>
        ///       
        /// <para>
        /// Specify the TimeOffset in the form [+-]SS.sss or [+-]HH:mm:SS.ss.
        /// </para>
        /// </summary>
        public string TimeOffset
        {
            get { return this._timeOffset; }
            set { this._timeOffset = value; }
        }

        // Check to see if TimeOffset property is set
        internal bool IsSetTimeOffset()
        {
            return this._timeOffset != null;
        }

    }
}