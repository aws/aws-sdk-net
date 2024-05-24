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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Ms Smooth Output Settings
    /// </summary>
    public partial class MsSmoothOutputSettings
    {
        private MsSmoothH265PackagingType _h265PackagingType;
        private string _nameModifier;

        /// <summary>
        /// Gets and sets the property H265PackagingType. Only applicable when this output is
        /// referencing an H.265 video description.Specifies whether MP4 segments should be packaged
        /// as HEV1 or HVC1.
        /// </summary>
        public MsSmoothH265PackagingType H265PackagingType
        {
            get { return this._h265PackagingType; }
            set { this._h265PackagingType = value; }
        }

        // Check to see if H265PackagingType property is set
        internal bool IsSetH265PackagingType()
        {
            return this._h265PackagingType != null;
        }

        /// <summary>
        /// Gets and sets the property NameModifier. String concatenated to the end of the destination
        /// filename.  Required for multiple outputs of the same type.
        /// </summary>
        public string NameModifier
        {
            get { return this._nameModifier; }
            set { this._nameModifier = value; }
        }

        // Check to see if NameModifier property is set
        internal bool IsSetNameModifier()
        {
            return this._nameModifier != null;
        }

    }
}