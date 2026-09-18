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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Details about whether a model version is available or deprecated.
    /// </summary>
    public partial class FoundationModelLifecycle
    {
        /// <summary>
        /// Gets and sets the property EndOfLifeTime. 
        /// <para>
        /// Time when the model is no longer available for use
        /// </para>
        /// </summary>
        public DateTime? EndOfLifeTime { get; set; }

        /// <summary>
        /// Checks to see if the EndOfLifeTime property is set.
        /// </summary>
        internal bool IsSetEndOfLifeTime() => this.EndOfLifeTime.HasValue;

        /// <summary>
        /// Gets and sets the property LegacyTime. 
        /// <para>
        /// Time when the model enters legacy state. Models in legacy state can still be used,
        /// but users should plan to transition to an Active model before the end of life time
        /// </para>
        /// </summary>
        public DateTime? LegacyTime { get; set; }

        /// <summary>
        /// Checks to see if the LegacyTime property is set.
        /// </summary>
        internal bool IsSetLegacyTime() => this.LegacyTime.HasValue;

        /// <summary>
        /// Gets and sets the property PublicExtendedAccessTime. 
        /// <para>
        /// Public extended access portion of the legacy period, when users should expect higher
        /// pricing
        /// </para>
        /// </summary>
        public DateTime? PublicExtendedAccessTime { get; set; }

        /// <summary>
        /// Checks to see if the PublicExtendedAccessTime property is set.
        /// </summary>
        internal bool IsSetPublicExtendedAccessTime() => this.PublicExtendedAccessTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartOfLifeTime. 
        /// <para>
        /// Launch time when the model first becomes available
        /// </para>
        /// </summary>
        public DateTime? StartOfLifeTime { get; set; }

        /// <summary>
        /// Checks to see if the StartOfLifeTime property is set.
        /// </summary>
        internal bool IsSetStartOfLifeTime() => this.StartOfLifeTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether a model version is available (<c>ACTIVE</c>) or deprecated (<c>LEGACY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FoundationModelLifecycleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
