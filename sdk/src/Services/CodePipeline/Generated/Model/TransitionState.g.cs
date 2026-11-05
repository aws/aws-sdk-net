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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the state of transitions between one stage and another
    /// stage.
    /// </summary>
    public partial class TransitionState
    {
        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// The user-specified reason why the transition between two stages of a pipeline was
        /// disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Checks to see if the DisabledReason property is set.
        /// </summary>
        internal bool IsSetDisabledReason() => this.DisabledReason != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the transition between stages is enabled (true) or disabled (false).
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastChangedAt. 
        /// <para>
        /// The timestamp when the transition state was last changed.
        /// </para>
        /// </summary>
        public DateTime? LastChangedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastChangedAt property is set.
        /// </summary>
        internal bool IsSetLastChangedAt() => this.LastChangedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastChangedBy. 
        /// <para>
        /// The ID of the user who last changed the transition state.
        /// </para>
        /// </summary>
        public string LastChangedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastChangedBy property is set.
        /// </summary>
        internal bool IsSetLastChangedBy() => this.LastChangedBy != null;
    }
}
