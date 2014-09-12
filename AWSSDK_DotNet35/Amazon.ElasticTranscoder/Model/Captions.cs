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
    /// The captions to be created, if any.
    /// </summary>
    public partial class Captions
    {
        private List<CaptionFormat> _captionFormats = new List<CaptionFormat>();
        private List<CaptionSource> _captionSources = new List<CaptionSource>();
        private string _mergePolicy;

        /// <summary>
        /// Gets and sets the property CaptionFormats. 
        /// <para>
        /// The array of file formats for the output captions. If you leave this value blank,
        ///         Elastic Transcoder returns an error.
        /// </para>
        /// </summary>
        public List<CaptionFormat> CaptionFormats
        {
            get { return this._captionFormats; }
            set { this._captionFormats = value; }
        }

        // Check to see if CaptionFormats property is set
        internal bool IsSetCaptionFormats()
        {
            return this._captionFormats != null && this._captionFormats.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptionSources. 
        /// <para>
        /// Source files for the input sidecar captions used during the transcoding         process.
        /// To omit all sidecar captions, leave <code>CaptionSources</code> blank.
        /// </para>
        /// </summary>
        public List<CaptionSource> CaptionSources
        {
            get { return this._captionSources; }
            set { this._captionSources = value; }
        }

        // Check to see if CaptionSources property is set
        internal bool IsSetCaptionSources()
        {
            return this._captionSources != null && this._captionSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MergePolicy. 
        /// <para>
        /// A policy that determines how Elastic Transcoder handles the existence of multiple
        /// captions.
        /// </para>
        ///       <ul>         <li>
        /// <para>
        /// <b>MergeOverride:</b> Elastic Transcoder transcodes both embedded            and sidecar
        /// captions into outputs. If captions for a language are embedded in the input      
        ///      file and also appear in a sidecar file, Elastic Transcoder uses the sidecar captions
        /// and ignores the            embedded captions for that language.
        /// </para>
        /// </li>         <li>
        /// <para>
        /// <b>MergeRetain:</b>  Elastic Transcoder transcodes both embedded            and sidecar
        /// captions into outputs. If captions for a language are embedded in the input      
        ///      file and also appear in a sidecar file, Elastic Transcoder uses the embedded
        /// captions and ignores the            sidecar captions for that language. If <code>CaptionSources</code>
        /// is empty,            Elastic Transcoder omits all sidecar captions from the output
        /// files.
        /// </para>
        /// </li>         <li>
        /// <para>
        /// <b>Override:</b> Elastic Transcoder transcodes only the            sidecar captions
        /// that you specify in <code>CaptionSources</code>.
        /// </para>
        /// </li>      </ul>      
        /// <para>
        /// <code>MergePolicy</code> cannot be null.
        /// </para>
        /// </summary>
        public string MergePolicy
        {
            get { return this._mergePolicy; }
            set { this._mergePolicy = value; }
        }

        // Check to see if MergePolicy property is set
        internal bool IsSetMergePolicy()
        {
            return this._mergePolicy != null;
        }

    }
}