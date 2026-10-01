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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Jpeg.
        /// </summary>
        public DesiredModality Jpeg { get; set; }

        /// <summary>
        /// Checks to see if the Jpeg property is set.
        /// </summary>
        internal bool IsSetJpeg() => this.Jpeg != null;

        /// <summary>
        /// Gets and sets the property Mov.
        /// </summary>
        public DesiredModality Mov { get; set; }

        /// <summary>
        /// Checks to see if the Mov property is set.
        /// </summary>
        internal bool IsSetMov() => this.Mov != null;

        /// <summary>
        /// Gets and sets the property Mp4.
        /// </summary>
        public DesiredModality Mp4 { get; set; }

        /// <summary>
        /// Checks to see if the Mp4 property is set.
        /// </summary>
        internal bool IsSetMp4() => this.Mp4 != null;

        /// <summary>
        /// Gets and sets the property Png.
        /// </summary>
        public DesiredModality Png { get; set; }

        /// <summary>
        /// Checks to see if the Png property is set.
        /// </summary>
        internal bool IsSetPng() => this.Png != null;
    }
}
