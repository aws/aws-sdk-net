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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Defines how a step parameter range should be divided into chunks.
    /// </summary>
    public partial class StepParameterChunks
    {
        /// <summary>
        /// Gets and sets the property DefaultTaskCount. 
        /// <para>
        /// The number of tasks to combine into a single chunk by default.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2147483647)]
        public int? DefaultTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTaskCount property is set.
        /// </summary>
        internal bool IsSetDefaultTaskCount() => this.DefaultTaskCount.HasValue;

        /// <summary>
        /// Gets and sets the property RangeConstraint. 
        /// <para>
        /// Specifies whether the chunked ranges must be contiguous or can have gaps between them.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RangeConstraint RangeConstraint { get; set; }

        /// <summary>
        /// Checks to see if the RangeConstraint property is set.
        /// </summary>
        internal bool IsSetRangeConstraint() => this.RangeConstraint != null;

        /// <summary>
        /// Gets and sets the property TargetRuntimeSeconds. 
        /// <para>
        /// The number of seconds to aim for when forming chunks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? TargetRuntimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TargetRuntimeSeconds property is set.
        /// </summary>
        internal bool IsSetTargetRuntimeSeconds() => this.TargetRuntimeSeconds.HasValue;
    }
}
