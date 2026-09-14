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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains one typed output. It is used in the CreateOutput, GetOutput, and Update Output
    /// structures.
    /// </summary>
    public partial class OutputConfig
    {
        /// <summary>
        /// Gets and sets the property Clipping. 
        /// <para>
        /// The output config type that applies to the clipping feature.
        /// </para>
        /// </summary>
        public ClippingConfig Clipping { get; set; }

        /// <summary>
        /// Checks to see if the Clipping property is set.
        /// </summary>
        internal bool IsSetClipping() => this.Clipping != null;

        /// <summary>
        /// Gets and sets the property ContextualMetadata. 
        /// <para>
        /// The output config type that applies to the contextual metadata feature.
        /// </para>
        /// </summary>
        public ContextualMetadataConfig ContextualMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ContextualMetadata property is set.
        /// </summary>
        internal bool IsSetContextualMetadata() => this.ContextualMetadata != null;

        /// <summary>
        /// Gets and sets the property Cropping. 
        /// <para>
        /// The output config type that applies to the cropping feature.
        /// </para>
        /// </summary>
        public CroppingConfig Cropping { get; set; }

        /// <summary>
        /// Checks to see if the Cropping property is set.
        /// </summary>
        internal bool IsSetCropping() => this.Cropping != null;

        /// <summary>
        /// Gets and sets the property Subtitling. 
        /// <para>
        /// The output config type that applies to the smart subtitling feature.
        /// </para>
        /// </summary>
        public SubtitlingConfig Subtitling { get; set; }

        /// <summary>
        /// Checks to see if the Subtitling property is set.
        /// </summary>
        internal bool IsSetSubtitling() => this.Subtitling != null;
    }
}
