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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Mastering display color volume metadata (SMPTE ST 2086). Describes the color volume
    /// of the display used to master the content. Chromaticity coordinates are in units of
    /// 0.00002. Luminance values are in units of 0.0001 cd/m².
    /// </summary>
    public partial class MasteringDisplayColorVolume
    {
        /// <summary>
        /// Gets and sets the property BluePrimaryX. Blue primary chromaticity x coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? BluePrimaryX { get; set; }

        /// <summary>
        /// Checks to see if the BluePrimaryX property is set.
        /// </summary>
        internal bool IsSetBluePrimaryX() => this.BluePrimaryX.HasValue;

        /// <summary>
        /// Gets and sets the property BluePrimaryY. Blue primary chromaticity y coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? BluePrimaryY { get; set; }

        /// <summary>
        /// Checks to see if the BluePrimaryY property is set.
        /// </summary>
        internal bool IsSetBluePrimaryY() => this.BluePrimaryY.HasValue;

        /// <summary>
        /// Gets and sets the property GreenPrimaryX. Green primary chromaticity x coordinate,
        /// in units of 0.00002.
        /// </summary>
        public int? GreenPrimaryX { get; set; }

        /// <summary>
        /// Checks to see if the GreenPrimaryX property is set.
        /// </summary>
        internal bool IsSetGreenPrimaryX() => this.GreenPrimaryX.HasValue;

        /// <summary>
        /// Gets and sets the property GreenPrimaryY. Green primary chromaticity y coordinate,
        /// in units of 0.00002.
        /// </summary>
        public int? GreenPrimaryY { get; set; }

        /// <summary>
        /// Checks to see if the GreenPrimaryY property is set.
        /// </summary>
        internal bool IsSetGreenPrimaryY() => this.GreenPrimaryY.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLuminance. Maximum display mastering luminance, in units
        /// of 0.0001 cd/m².
        /// </summary>
        public long? MaxLuminance { get; set; }

        /// <summary>
        /// Checks to see if the MaxLuminance property is set.
        /// </summary>
        internal bool IsSetMaxLuminance() => this.MaxLuminance.HasValue;

        /// <summary>
        /// Gets and sets the property MinLuminance. Minimum display mastering luminance, in units
        /// of 0.0001 cd/m².
        /// </summary>
        public long? MinLuminance { get; set; }

        /// <summary>
        /// Checks to see if the MinLuminance property is set.
        /// </summary>
        internal bool IsSetMinLuminance() => this.MinLuminance.HasValue;

        /// <summary>
        /// Gets and sets the property RedPrimaryX. Red primary chromaticity x coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? RedPrimaryX { get; set; }

        /// <summary>
        /// Checks to see if the RedPrimaryX property is set.
        /// </summary>
        internal bool IsSetRedPrimaryX() => this.RedPrimaryX.HasValue;

        /// <summary>
        /// Gets and sets the property RedPrimaryY. Red primary chromaticity y coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? RedPrimaryY { get; set; }

        /// <summary>
        /// Checks to see if the RedPrimaryY property is set.
        /// </summary>
        internal bool IsSetRedPrimaryY() => this.RedPrimaryY.HasValue;

        /// <summary>
        /// Gets and sets the property WhitePointX. White point chromaticity x coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? WhitePointX { get; set; }

        /// <summary>
        /// Checks to see if the WhitePointX property is set.
        /// </summary>
        internal bool IsSetWhitePointX() => this.WhitePointX.HasValue;

        /// <summary>
        /// Gets and sets the property WhitePointY. White point chromaticity y coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? WhitePointY { get; set; }

        /// <summary>
        /// Checks to see if the WhitePointY property is set.
        /// </summary>
        internal bool IsSetWhitePointY() => this.WhitePointY.HasValue;
    }
}
