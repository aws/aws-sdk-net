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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for Avail Blanking
    /// </summary>
    public partial class AvailBlanking
    {
        private string _availBlankingImage;

        /// <summary>
        /// Gets and sets the property AvailBlankingImage. Blanking image to be used. Leave empty
        /// for solid black. Only bmp and png images are supported.
        /// </summary>
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