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
    /// The frames that a function receives in media.frames on each run: which frames, how
    /// many, and at what size. Elemental Inference applies these settings only to a function
    /// that references media.frames. 
    /// 
    ///  
    /// <para>
    /// When you add or change the function output, Elemental Inference estimates the size
    /// of the frames and rejects settings whose frames won't fit in one model request. To
    /// send more frames in each request, specify a smaller frameSize. 
    /// </para>
    /// </summary>
    public partial class FrameSettings
    {
        /// <summary>
        /// Gets and sets the property FrameSampling. 
        /// <para>
        /// The method for choosing which frames to send.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FrameSamplingStrategy FrameSampling { get; set; }

        /// <summary>
        /// Checks to see if the FrameSampling property is set.
        /// </summary>
        internal bool IsSetFrameSampling() => this.FrameSampling != null;

        /// <summary>
        /// Gets and sets the property FrameSize. 
        /// <para>
        /// The size to resize each frame to. If you omit this structure, frames keep their source
        /// size. Smaller frames reduce the size of the model request. 
        /// </para>
        /// </summary>
        public FrameSize FrameSize { get; set; }

        /// <summary>
        /// Checks to see if the FrameSize property is set.
        /// </summary>
        internal bool IsSetFrameSize() => this.FrameSize != null;
    }
}
