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
    /// Configuration for routing file type to desired modality
    /// </summary>
    public partial class ModalityRoutingConfiguration
    {
        private DesiredModality _jpeg;
        private DesiredModality _mov;
        private DesiredModality _mp4;
        private DesiredModality _png;

        /// <summary>
        /// Gets and sets the property Jpeg.
        /// </summary>
        public DesiredModality Jpeg
        {
            get { return this._jpeg; }
            set { this._jpeg = value; }
        }

        // Check to see if Jpeg property is set
        internal bool IsSetJpeg()
        {
            return this._jpeg != null;
        }

        /// <summary>
        /// Gets and sets the property Mov.
        /// </summary>
        public DesiredModality Mov
        {
            get { return this._mov; }
            set { this._mov = value; }
        }

        // Check to see if Mov property is set
        internal bool IsSetMov()
        {
            return this._mov != null;
        }

        /// <summary>
        /// Gets and sets the property Mp4.
        /// </summary>
        public DesiredModality Mp4
        {
            get { return this._mp4; }
            set { this._mp4 = value; }
        }

        // Check to see if Mp4 property is set
        internal bool IsSetMp4()
        {
            return this._mp4 != null;
        }

        /// <summary>
        /// Gets and sets the property Png.
        /// </summary>
        public DesiredModality Png
        {
            get { return this._png; }
            set { this._png = value; }
        }

        // Check to see if Png property is set
        internal bool IsSetPng()
        {
            return this._png != null;
        }

    }
}