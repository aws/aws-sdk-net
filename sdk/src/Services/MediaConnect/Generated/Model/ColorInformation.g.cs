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
    /// The color signaling of the video stream.
    /// </summary>
    public partial class ColorInformation
    {
        /// <summary>
        /// Gets and sets the property Colorimetry. 
        /// <para>
        /// The color primaries that the video stream uses (for example, <c>BT709</c> or <c>BT2020</c>).
        /// </para>
        /// </summary>
        public VideoColorimetry Colorimetry { get; set; }

        /// <summary>
        /// Checks to see if the Colorimetry property is set.
        /// </summary>
        internal bool IsSetColorimetry() => this.Colorimetry != null;

        /// <summary>
        /// Gets and sets the property MatrixCoefficients. 
        /// <para>
        /// The YCbCr matrix coefficients that the video stream uses (for example, <c>BT709</c>
        /// or <c>BT2020_NCL</c>).
        /// </para>
        /// </summary>
        public VideoMatrixCoefficients MatrixCoefficients { get; set; }

        /// <summary>
        /// Checks to see if the MatrixCoefficients property is set.
        /// </summary>
        internal bool IsSetMatrixCoefficients() => this.MatrixCoefficients != null;

        /// <summary>
        /// Gets and sets the property TransferCharacteristics. 
        /// <para>
        /// The transfer characteristics that the video stream uses (for example, <c>BT601</c>,
        /// <c>BT709</c>, <c>BT2100_PQ</c>, or <c>BT2100_HLG</c>).
        /// </para>
        /// </summary>
        public VideoTransferCharacteristics TransferCharacteristics { get; set; }

        /// <summary>
        /// Checks to see if the TransferCharacteristics property is set.
        /// </summary>
        internal bool IsSetTransferCharacteristics() => this.TransferCharacteristics != null;
    }
}
