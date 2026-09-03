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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Detects silent audio in the router input's source content and reports it through a
    /// CloudWatch metric, an EventBridge event, and a router input message.
    /// </summary>
    public partial class SilentAudioConfiguration
    {
        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether silent audio detection is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentQualityAnalysisState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property ThresholdSeconds. 
        /// <para>
        /// The number of consecutive seconds of silence that MediaConnect must detect before
        /// it reports an issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 60)]
        public int? ThresholdSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdSeconds property is set.
        /// </summary>
        internal bool IsSetThresholdSeconds() => this.ThresholdSeconds.HasValue;
    }
}
