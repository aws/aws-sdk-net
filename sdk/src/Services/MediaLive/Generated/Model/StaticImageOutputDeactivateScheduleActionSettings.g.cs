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
    public partial class StaticImageOutputDeactivateScheduleActionSettings
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

        /// <summary>
        /// Gets and sets the property OutputNames. The name(s) of the output(s) the deactivation
        /// should apply to.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> OutputNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputNames property is set.
        /// </summary>
        internal bool IsSetOutputNames() => this.OutputNames != null && (this.OutputNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
