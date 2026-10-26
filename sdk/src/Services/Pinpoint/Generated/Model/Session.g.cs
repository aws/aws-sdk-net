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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about a session.
    /// </summary>
    public partial class Session
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the session, in milliseconds.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the session began.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp != null;

        /// <summary>
        /// Gets and sets the property StopTimestamp. 
        /// <para>
        /// The date and time when the session ended.
        /// </para>
        /// </summary>
        public string StopTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StopTimestamp property is set.
        /// </summary>
        internal bool IsSetStopTimestamp() => this.StopTimestamp != null;
    }
}
