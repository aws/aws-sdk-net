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
    /// The captions to be created, if any.
    /// </summary>
    public partial class InputCaptions
    {
        private List<CaptionSource> _captionSources = AWSConfigs.InitializeCollections ? new List<CaptionSource>() : null;
        private string _mergePolicy;

        /// <summary>
        /// Gets and sets the property CaptionSources. 
        /// <para>
        /// Source files for the input sidecar captions used during the transcoding process. To
        /// omit all sidecar captions, leave <c>CaptionSources</c> blank.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=20)]
        public List<CaptionSource> CaptionSources
        {
            get { return this._captionSources; }
            set { this._captionSources = value; }
        }

        // Check to see if CaptionSources property is set
        internal bool IsSetCaptionSources()
        {
            return this._captionSources != null && (this._captionSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MergePolicy. 
        /// <para>
        /// A policy that determines how Elastic Transcoder handles the existence of multiple
        /// captions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>MergeOverride:</b> Elastic Transcoder transcodes both embedded and sidecar captions
        /// into outputs. If captions for a language are embedded in the input file and also appear
        /// in a sidecar file, Elastic Transcoder uses the sidecar captions and ignores the embedded
        /// captions for that language.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MergeRetain:</b> Elastic Transcoder transcodes both embedded and sidecar captions
        /// into outputs. If captions for a language are embedded in the input file and also appear
        /// in a sidecar file, Elastic Transcoder uses the embedded captions and ignores the sidecar
        /// captions for that language. If <c>CaptionSources</c> is empty, Elastic Transcoder
        /// omits all sidecar captions from the output files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Override:</b> Elastic Transcoder transcodes only the sidecar captions that you
        /// specify in <c>CaptionSources</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>MergePolicy</c> cannot be null.
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