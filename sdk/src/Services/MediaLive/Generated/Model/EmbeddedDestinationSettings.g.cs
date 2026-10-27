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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Embedded Destination Settings
    /// </summary>
    public partial class EmbeddedDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property Position. Specifies the position of the output captions.
        /// Applies only when styleControl is set to manual.
        /// </summary>
        public EmbeddedCaptionPositionSettings Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property StyleControl. Controls the source of position and style
        /// information for the output captions. - "passthrough": Carry the caption position and
        /// style from the source captions. When the source captions are embedded, SCTE-20, or
        /// ancillary, the position and style are preserved exactly. When the source captions
        /// are another format, the position and any supported style are carried over. - "manual":
        /// Applies the specified styling and positioning. All other styling and positioning is
        /// given default values.
        /// </summary>
        public EmbeddedDestinationStyleControl StyleControl { get; set; }

        /// <summary>
        /// Checks to see if the StyleControl property is set.
        /// </summary>
        internal bool IsSetStyleControl() => this.StyleControl != null;
    }
}
