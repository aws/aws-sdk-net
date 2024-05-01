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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Information about the image frame (pixel data) identifier.
    /// </summary>
    public partial class ImageFrameInformation
    {
        private string _imageFrameId;

        /// <summary>
        /// Gets and sets the property ImageFrameId. 
        /// <para>
        /// The image frame (pixel data) identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageFrameId
        {
            get { return this._imageFrameId; }
            set { this._imageFrameId = value; }
        }

        // Check to see if ImageFrameId property is set
        internal bool IsSetImageFrameId()
        {
            return this._imageFrameId != null;
        }

    }
}