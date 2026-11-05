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
    /// Settings for the action to deactivate the image in a specific layer.
    /// </summary>
    public partial class StaticImageDeactivateScheduleActionSettings
    {
        /// <summary>
        /// Gets and sets the property FadeOut. The time in milliseconds for the image to fade
        /// out. Default is 0 (no fade-out).
        /// </summary>
        public int? FadeOut { get; set; }

        /// <summary>
        /// Checks to see if the FadeOut property is set.
        /// </summary>
        internal bool IsSetFadeOut() => this.FadeOut.HasValue;

        /// <summary>
        /// Gets and sets the property Layer. The image overlay layer to deactivate, 0 to 7. Default
        /// is 0.
        /// </summary>
        public int? Layer { get; set; }

        /// <summary>
        /// Checks to see if the Layer property is set.
        /// </summary>
        internal bool IsSetLayer() => this.Layer.HasValue;
    }
}
