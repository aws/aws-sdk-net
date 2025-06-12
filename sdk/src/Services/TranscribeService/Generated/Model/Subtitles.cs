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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Generate subtitles for your media file with your transcription request.
    /// 
    ///  
    /// <para>
    /// You can choose a start index of 0 or 1, and you can specify either WebVTT or SubRip
    /// (or both) as your output format.
    /// </para>
    ///  
    /// <para>
    /// Note that your subtitle files are placed in the same location as your transcription
    /// output.
    /// </para>
    /// </summary>
    public partial class Subtitles
    {
        private List<string> _formats = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _outputStartIndex;

        /// <summary>
        /// Gets and sets the property Formats. 
        /// <para>
        /// Specify the output format for your subtitle file; if you select both WebVTT (<c>vtt</c>)
        /// and SubRip (<c>srt</c>) formats, two output files are generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Formats
        {
            get { return this._formats; }
            set { this._formats = value; }
        }

        // Check to see if Formats property is set
        internal bool IsSetFormats()
        {
            return this._formats != null && (this._formats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputStartIndex. 
        /// <para>
        /// Specify the starting value that is assigned to the first subtitle segment.
        /// </para>
        ///  
        /// <para>
        /// The default start index for Amazon Transcribe is <c>0</c>, which differs from the
        /// more widely used standard of <c>1</c>. If you're uncertain which value to use, we
        /// recommend choosing <c>1</c>, as this may improve compatibility with other services.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int? OutputStartIndex
        {
            get { return this._outputStartIndex; }
            set { this._outputStartIndex = value; }
        }

        // Check to see if OutputStartIndex property is set
        internal bool IsSetOutputStartIndex()
        {
            return this._outputStartIndex.HasValue; 
        }

    }
}