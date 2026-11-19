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
    /// Determines when a function runs. Specify exactly one member.
    /// </summary>
    public partial class Trigger
    {
        /// <summary>
        /// Gets and sets the property FixedInterval. 
        /// <para>
        /// Run the function at a fixed interval of content. This is the only trigger for a function
        /// that references media.transcript. Can't be used with a function that references media.contextual.
        /// 
        /// </para>
        /// </summary>
        public FixedIntervalTrigger FixedInterval { get; set; }

        /// <summary>
        /// Checks to see if the FixedInterval property is set.
        /// </summary>
        internal bool IsSetFixedInterval() => this.FixedInterval != null;

        /// <summary>
        /// Gets and sets the property PerClip. 
        /// <para>
        /// Run the function once for each clip that an event clipping output detects. Requires
        /// clippingSettings. Can't be used with a function that references media.transcript or
        /// media.contextual. 
        /// </para>
        /// </summary>
        public ClipTrigger PerClip { get; set; }

        /// <summary>
        /// Checks to see if the PerClip property is set.
        /// </summary>
        internal bool IsSetPerClip() => this.PerClip != null;

        /// <summary>
        /// Gets and sets the property PerScene. 
        /// <para>
        /// Run the function once for each scene boundary that a contextual metadata output reports.
        /// Requires contextualMetadataSettings. Can't be used with a function that references
        /// media.transcript or media.clip. 
        /// </para>
        /// </summary>
        public SceneTrigger PerScene { get; set; }

        /// <summary>
        /// Checks to see if the PerScene property is set.
        /// </summary>
        internal bool IsSetPerScene() => this.PerScene != null;

        /// <summary>
        /// Gets and sets the property PerShot. 
        /// <para>
        /// Run the function once for each shot that Elemental Inference detects. Can't be used
        /// with a function that references media.transcript or media.clip. 
        /// </para>
        /// </summary>
        public ShotTrigger PerShot { get; set; }

        /// <summary>
        /// Checks to see if the PerShot property is set.
        /// </summary>
        internal bool IsSetPerShot() => this.PerShot != null;
    }
}
