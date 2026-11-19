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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The number of examples that have each field. An example can have more than one of
    /// these fields, so the counts can add up to more than <c>exampleCount</c>.
    /// </summary>
    public partial class ExampleCountByField
    {
        /// <summary>
        /// Gets and sets the property ActorProfile. 
        /// <para>
        ///  The number of examples that have <c>actor_profile</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ActorProfile { get; set; }

        /// <summary>
        /// Checks to see if the ActorProfile property is set.
        /// </summary>
        internal bool IsSetActorProfile() => this.ActorProfile.HasValue;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        ///  The number of examples that have <c>input</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input.HasValue;

        /// <summary>
        /// Gets and sets the property Turns. 
        /// <para>
        ///  The number of examples that have <c>turns</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Turns { get; set; }

        /// <summary>
        /// Checks to see if the Turns property is set.
        /// </summary>
        internal bool IsSetTurns() => this.Turns.HasValue;
    }
}
