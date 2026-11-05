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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a request to create or edit the <c>StopInstanceOnIdle</c> add-on.
    /// 
    ///  <important> 
    /// <para>
    /// This add-on only applies to Lightsail for Research resources.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StopInstanceOnIdleRequest
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The amount of idle time in minutes after which your virtual computer will automatically
        /// stop.
        /// </para>
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the duration.
        /// </para>
        /// </summary>
        public string Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold != null;
    }
}
