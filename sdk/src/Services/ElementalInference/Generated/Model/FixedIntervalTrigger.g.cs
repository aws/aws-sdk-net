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
    /// The settings of the fixedInterval trigger, which runs the function once for every
    /// intervalSeconds of content. A function that references media.transcript must use this
    /// trigger. You can't use this trigger with a function that references media.contextual.
    /// 
    /// 
    ///  
    /// <para>
    /// If the function references media.transcript, specify subtitlingSettings. If the function
    /// references media.clip, specify clippingSettings. Each run then receives the events
    /// that the event clipping output reported during the interval, in media.clip.events.
    /// 
    /// </para>
    /// </summary>
    public partial class FixedIntervalTrigger
    {
        /// <summary>
        /// Gets and sets the property IntervalSeconds. 
        /// <para>
        /// The amount of content, in seconds, between runs of the function. Valid range: 1 to
        /// 60. For a function with eventBridgeDelivery set to ENABLED, the minimum is 4. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IntervalSeconds property is set.
        /// </summary>
        internal bool IsSetIntervalSeconds() => this.IntervalSeconds.HasValue;
    }
}
