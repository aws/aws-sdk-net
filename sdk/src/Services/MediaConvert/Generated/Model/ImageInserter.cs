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
    /// Use the image inserter feature to include a graphic overlay on your video. Enable
    /// or disable this feature for each input or output individually. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/graphic-overlay.html. This
    /// setting is disabled by default.
    /// </summary>
    public partial class ImageInserter
    {
        private List<InsertableImage> _insertableImages = AWSConfigs.InitializeCollections ? new List<InsertableImage>() : null;
        private int? _sdrReferenceWhiteLevel;

        /// <summary>
        /// Gets and sets the property InsertableImages. Specify the images that you want to overlay
        /// on your video. The images must be PNG or TGA files.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsertableImage> InsertableImages
        {
            get { return this._insertableImages; }
            set { this._insertableImages = value; }
        }

        // Check to see if InsertableImages property is set
        internal bool IsSetInsertableImages()
        {
            return this._insertableImages != null && (this._insertableImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SdrReferenceWhiteLevel. Specify the reference white level,
        /// in nits, for all of your image inserter images. Use to correct brightness levels within
        /// HDR10 outputs. For 1,000 nit peak brightness displays, we recommend that you set SDR
        /// reference white level to 203 (according to ITU-R BT.2408). Leave blank to use the
        /// default value of 100, or specify an integer from 100 to 1000.
        /// </summary>
        [AWSProperty(Min=100, Max=1000)]
        public int? SdrReferenceWhiteLevel
        {
            get { return this._sdrReferenceWhiteLevel; }
            set { this._sdrReferenceWhiteLevel = value; }
        }

        // Check to see if SdrReferenceWhiteLevel property is set
        internal bool IsSetSdrReferenceWhiteLevel()
        {
            return this._sdrReferenceWhiteLevel.HasValue; 
        }

    }
}