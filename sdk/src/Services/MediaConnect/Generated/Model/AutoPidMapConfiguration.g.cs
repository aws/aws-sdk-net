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
    /// The configuration settings for automatic Packet ID (PID) assignment. These settings
    /// apply to any PID mapping rule that uses the <c>auto</c> action, including the default
    /// action.
    /// </summary>
    public partial class AutoPidMapConfiguration
    {
        /// <summary>
        /// Gets and sets the property PidsPerProgram. 
        /// <para>
        /// The number of PIDs in the range for automatic PID assignment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8158)]
        public int? PidsPerProgram { get; set; }

        /// <summary>
        /// Checks to see if the PidsPerProgram property is set.
        /// </summary>
        internal bool IsSetPidsPerProgram() => this.PidsPerProgram.HasValue;

        /// <summary>
        /// Gets and sets the property StartPid. 
        /// <para>
        /// The first PID in the range for automatic PID assignment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 8190)]
        public int? StartPid { get; set; }

        /// <summary>
        /// Checks to see if the StartPid property is set.
        /// </summary>
        internal bool IsSetStartPid() => this.StartPid.HasValue;
    }
}
