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
    /// Use ad avail blanking settings to specify your output content during SCTE-35 triggered
    /// ad avails. You can blank your video or overlay it with an image. MediaConvert also
    /// removes any audio and embedded captions during the ad avail. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/ad-avail-blanking.html.
    /// </summary>
    public partial class AvailBlanking
    {
        private string _availBlankingImage;

        /// <summary>
        /// Gets and sets the property AvailBlankingImage. Blanking image to be used. Leave empty
        /// for solid black. Only bmp and png images are supported.
        /// </summary>
        [AWSProperty(Min=14)]
        public string AvailBlankingImage
        {
            get { return this._availBlankingImage; }
            set { this._availBlankingImage = value; }
        }

        // Check to see if AvailBlankingImage property is set
        internal bool IsSetAvailBlankingImage()
        {
            return this._availBlankingImage != null;
        }

    }
}