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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings specific to caption sources that are specified by track number. Currently,
    /// this is only IMSC captions in an IMF package. If your caption source is IMSC 1.1 in
    /// a separate xml file, use FileSourceSettings instead of TrackSourceSettings.
    /// </summary>
    public partial class TrackSourceSettings
    {
        private int? _streamNumber;
        private int? _trackNumber;

        /// <summary>
        /// Gets and sets the property StreamNumber. Use this setting to select a single captions
        /// track from a source. Stream numbers include all tracks in the source file, regardless
        /// of type, and correspond to either the order of tracks in the file, or if applicable,
        /// the stream number metadata of the track. Although all tracks count toward these stream
        /// numbers, in this caption selector context, only the stream number of a track containing
        /// caption data may be used. To include more than one captions track in your job outputs,
        /// create multiple input captions selectors. Specify one stream per selector. If your
        /// source file contains a track which is not recognized by the service, then the corresponding
        /// stream number will still be reserved for future use. If more types of caption data
        /// get recognized in the future, these numberings will not shift.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int StreamNumber
        {
            get { return this._streamNumber.GetValueOrDefault(); }
            set { this._streamNumber = value; }
        }

        // Check to see if StreamNumber property is set
        internal bool IsSetStreamNumber()
        {
            return this._streamNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackNumber. Use this setting to select a single captions
        /// track from a source. Track numbers correspond to the order in the captions source
        /// file. For IMF sources, track numbering is based on the order that the captions appear
        /// in the CPL. For example, use 1 to select the captions asset that is listed first in
        /// the CPL. To include more than one captions track in your job outputs, create multiple
        /// input captions selectors. Specify one track per selector. If more types of caption
        /// data get recognized in the future, these numberings may shift, but the numberings
        /// used for streamNumber will not.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int TrackNumber
        {
            get { return this._trackNumber.GetValueOrDefault(); }
            set { this._trackNumber = value; }
        }

        // Check to see if TrackNumber property is set
        internal bool IsSetTrackNumber()
        {
            return this._trackNumber.HasValue; 
        }

    }
}