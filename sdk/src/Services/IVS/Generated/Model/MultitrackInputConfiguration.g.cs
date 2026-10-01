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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// A complex type that specifies multitrack input configuration.
    /// </summary>
    public partial class MultitrackInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether multitrack input is enabled. Can be set to <c>true</c> only if channel
        /// type is <c>STANDARD</c>. Setting <c>enabled</c> to <c>true</c> with any other channel
        /// type will cause an exception. If <c>true</c>, then <c>policy</c>, <c>maximumResolution</c>,
        /// and <c>containerFormat</c> are required, and <c>containerFormat</c> must be set to
        /// <c>FRAGMENTED_MP4</c>. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumResolution. 
        /// <para>
        /// Maximum resolution for multitrack input. Required if <c>enabled</c> is <c>true</c>.
        /// </para>
        /// </summary>
        public MultitrackMaximumResolution MaximumResolution { get; set; }

        /// <summary>
        /// Checks to see if the MaximumResolution property is set.
        /// </summary>
        internal bool IsSetMaximumResolution() => this.MaximumResolution != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Indicates whether multitrack input is allowed or required. Required if <c>enabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public MultitrackPolicy Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;
    }
}
