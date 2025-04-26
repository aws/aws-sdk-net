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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Override configuration
    /// </summary>
    public partial class OverrideConfiguration
    {
        private AudioOverrideConfiguration _audio;
        private DocumentOverrideConfiguration _document;
        private ImageOverrideConfiguration _image;
        private ModalityRoutingConfiguration _modalityRouting;
        private VideoOverrideConfiguration _video;

        /// <summary>
        /// Gets and sets the property Audio.
        /// </summary>
        public AudioOverrideConfiguration Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null;
        }

        /// <summary>
        /// Gets and sets the property Document.
        /// </summary>
        public DocumentOverrideConfiguration Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property Image.
        /// </summary>
        public ImageOverrideConfiguration Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ModalityRouting.
        /// </summary>
        public ModalityRoutingConfiguration ModalityRouting
        {
            get { return this._modalityRouting; }
            set { this._modalityRouting = value; }
        }

        // Check to see if ModalityRouting property is set
        internal bool IsSetModalityRouting()
        {
            return this._modalityRouting != null;
        }

        /// <summary>
        /// Gets and sets the property Video.
        /// </summary>
        public VideoOverrideConfiguration Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}