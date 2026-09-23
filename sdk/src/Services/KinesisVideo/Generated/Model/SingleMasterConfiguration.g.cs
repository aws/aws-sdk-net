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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// A structure that contains the configuration for the <c>SINGLE_MASTER</c> channel type.
    /// </summary>
    public partial class SingleMasterConfiguration
    {
        /// <summary>
        /// Gets and sets the property MessageTtlSeconds. 
        /// <para>
        /// The period of time (in seconds) a signaling channel retains undelivered messages before
        /// they are discarded. Use to update this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 120)]
        public int? MessageTtlSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MessageTtlSeconds property is set.
        /// </summary>
        internal bool IsSetMessageTtlSeconds() => this.MessageTtlSeconds.HasValue;
    }
}
