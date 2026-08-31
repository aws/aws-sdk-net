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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A set of parameters that define the media stream.
    /// </summary>
    public partial class Fmtp
    {
        /// <summary>
        /// Gets and sets the property ChannelOrder. 
        /// <para>
        ///  The format of the audio channel. 
        /// </para>
        /// </summary>
        public string ChannelOrder { get; set; }

        /// <summary>
        /// Checks to see if the ChannelOrder property is set.
        /// </summary>
        internal bool IsSetChannelOrder() => this.ChannelOrder != null;

        /// <summary>
        /// Gets and sets the property Colorimetry. 
        /// <para>
        /// The format used for the representation of color. 
        /// </para>
        /// </summary>
        public Colorimetry Colorimetry { get; set; }

        /// <summary>
        /// Checks to see if the Colorimetry property is set.
        /// </summary>
        internal bool IsSetColorimetry() => this.Colorimetry != null;

        /// <summary>
        /// Gets and sets the property ExactFramerate. 
        /// <para>
        /// The frame rate for the video stream, in frames/second. For example: 60000/1001. 
        /// </para>
        /// </summary>
        public string ExactFramerate { get; set; }

        /// <summary>
        /// Checks to see if the ExactFramerate property is set.
        /// </summary>
        internal bool IsSetExactFramerate() => this.ExactFramerate != null;

        /// <summary>
        /// Gets and sets the property Par. 
        /// <para>
        /// The pixel aspect ratio (PAR) of the video. 
        /// </para>
        /// </summary>
        public string Par { get; set; }

        /// <summary>
        /// Checks to see if the Par property is set.
        /// </summary>
        internal bool IsSetPar() => this.Par != null;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The encoding range of the video. 
        /// </para>
        /// </summary>
        public Range Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The type of compression that was used to smooth the video’s appearance. 
        /// </para>
        /// </summary>
        public ScanMode ScanMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null;

        /// <summary>
        /// Gets and sets the property Tcs. 
        /// <para>
        /// The transfer characteristic system (TCS) that is used in the video. 
        /// </para>
        /// </summary>
        public Tcs Tcs { get; set; }

        /// <summary>
        /// Checks to see if the Tcs property is set.
        /// </summary>
        internal bool IsSetTcs() => this.Tcs != null;
    }
}
