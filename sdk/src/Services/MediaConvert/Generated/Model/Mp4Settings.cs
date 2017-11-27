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
    /// Settings for MP4 Container
    /// </summary>
    public partial class Mp4Settings
    {
        private Mp4CslgAtom _cslgAtom;
        private Mp4FreeSpaceBox _freeSpaceBox;
        private Mp4MoovPlacement _moovPlacement;
        private string _mp4MajorBrand;

        /// <summary>
        /// Gets and sets the property CslgAtom.
        /// </summary>
        public Mp4CslgAtom CslgAtom
        {
            get { return this._cslgAtom; }
            set { this._cslgAtom = value; }
        }

        // Check to see if CslgAtom property is set
        internal bool IsSetCslgAtom()
        {
            return this._cslgAtom != null;
        }

        /// <summary>
        /// Gets and sets the property FreeSpaceBox.
        /// </summary>
        public Mp4FreeSpaceBox FreeSpaceBox
        {
            get { return this._freeSpaceBox; }
            set { this._freeSpaceBox = value; }
        }

        // Check to see if FreeSpaceBox property is set
        internal bool IsSetFreeSpaceBox()
        {
            return this._freeSpaceBox != null;
        }

        /// <summary>
        /// Gets and sets the property MoovPlacement.
        /// </summary>
        public Mp4MoovPlacement MoovPlacement
        {
            get { return this._moovPlacement; }
            set { this._moovPlacement = value; }
        }

        // Check to see if MoovPlacement property is set
        internal bool IsSetMoovPlacement()
        {
            return this._moovPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property Mp4MajorBrand. Overrides the "Major Brand" field in the
        /// output file. Usually not necessary to specify.
        /// </summary>
        public string Mp4MajorBrand
        {
            get { return this._mp4MajorBrand; }
            set { this._mp4MajorBrand = value; }
        }

        // Check to see if Mp4MajorBrand property is set
        internal bool IsSetMp4MajorBrand()
        {
            return this._mp4MajorBrand != null;
        }

    }
}