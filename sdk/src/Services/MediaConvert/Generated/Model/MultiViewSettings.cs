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
    /// Specify the enhancement layer input video file path for Multi View outputs. The base
    /// layer input is treated as the left eye and this Multi View input is treated as the
    /// right eye. Only one Multi View input is currently supported. MediaConvert encodes
    /// both views into a single MV-HEVC output codec. When you add MultiViewSettings to your
    /// job, you can only produce Multi View outputs. Adding any other codec output to the
    /// same job is not supported.
    /// </summary>
    public partial class MultiViewSettings
    {
        private MultiViewInput _input;

        /// <summary>
        /// Gets and sets the property Input. Input settings for MultiView Settings. You can include
        /// exactly one input as enhancement layer.
        /// </summary>
        public MultiViewInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}