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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an image file.
    /// </summary>
    public partial class ImageFile
    {
        private MemoryStream _encodedString;
        private ImageFileType _fileType;

        /// <summary>
        /// Gets and sets the property EncodedString. 
        /// <para>
        /// The image file contents, represented as a base64-encoded string. The file size must
        /// be less than 1 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream EncodedString
        {
            get { return this._encodedString; }
            set { this._encodedString = value; }
        }

        // Check to see if EncodedString property is set
        internal bool IsSetEncodedString()
        {
            return this._encodedString != null;
        }

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The file type of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageFileType FileType
        {
            get { return this._fileType; }
            set { this._fileType = value; }
        }

        // Check to see if FileType property is set
        internal bool IsSetFileType()
        {
            return this._fileType != null;
        }

    }
}