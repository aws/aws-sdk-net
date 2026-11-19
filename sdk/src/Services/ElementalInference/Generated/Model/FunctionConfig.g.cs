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
    /// The output configuration settings for a function. Use this structure to run a function
    /// on this feed. The name of the output is the name that you pass to GetMetadata to read
    /// the results. 
    /// 
    ///  
    /// <para>
    /// Include the settings that the function's media context and trigger require. Elemental
    /// Inference ignores settings that neither uses. It also rejects settings whose frames
    /// are estimated to exceed the size of a single model request. 
    /// </para>
    ///  
    /// <para>
    /// A feed that has an enabled function output must also have an enabled cropping, clipping,
    /// subtitling, or contextual metadata output. A feed that runs a function with a Bedrock
    /// target must specify an accessRoleArn. 
    /// </para>
    /// </summary>
    public partial class FunctionConfig
    {
        /// <summary>
        /// Gets and sets the property ClippingSettings. 
        /// <para>
        /// The event clipping output on this feed to read clips from. Required for a perClip
        /// trigger, and for a function that references media.clip. 
        /// </para>
        /// </summary>
        public ClippingSettings ClippingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ClippingSettings property is set.
        /// </summary>
        internal bool IsSetClippingSettings() => this.ClippingSettings != null;

        /// <summary>
        /// Gets and sets the property ContextualMetadataSettings. 
        /// <para>
        /// The contextual metadata output on this feed to read scenes and classifications from.
        /// Required for a perScene trigger, and for a function that references media.contextual
        /// on a perShot trigger. 
        /// </para>
        /// </summary>
        public ContextualMetadataSettings ContextualMetadataSettings { get; set; }

        /// <summary>
        /// Checks to see if the ContextualMetadataSettings property is set.
        /// </summary>
        internal bool IsSetContextualMetadataSettings() => this.ContextualMetadataSettings != null;

        /// <summary>
        /// Gets and sets the property FrameSettings. 
        /// <para>
        /// The frames to send on each run: how many, which ones, and at what size. Applies to
        /// a function that references media.frames. If you omit this structure, Elemental Inference
        /// sends the first frame of the window, at its source size. 
        /// </para>
        /// </summary>
        public FrameSettings FrameSettings { get; set; }

        /// <summary>
        /// Checks to see if the FrameSettings property is set.
        /// </summary>
        internal bool IsSetFrameSettings() => this.FrameSettings != null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The ARN of the function to run. The function must exist in the same account and the
        /// same Region as the feed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property SubtitlingSettings. 
        /// <para>
        /// The smart subtitles output on this feed to read the transcript from. Required for
        /// a function that references media.transcript. 
        /// </para>
        /// </summary>
        public SubtitlingSettings SubtitlingSettings { get; set; }

        /// <summary>
        /// Checks to see if the SubtitlingSettings property is set.
        /// </summary>
        internal bool IsSetSubtitlingSettings() => this.SubtitlingSettings != null;

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// Determines when the function runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Trigger Trigger { get; set; }

        /// <summary>
        /// Checks to see if the Trigger property is set.
        /// </summary>
        internal bool IsSetTrigger() => this.Trigger != null;
    }
}
