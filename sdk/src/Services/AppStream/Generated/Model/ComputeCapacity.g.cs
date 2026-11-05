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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the capacity for a fleet.
    /// </summary>
    public partial class ComputeCapacity
    {
        /// <summary>
        /// Gets and sets the property DesiredInstances. 
        /// <para>
        /// The desired number of streaming instances.
        /// </para>
        /// </summary>
        public int? DesiredInstances { get; set; }

        /// <summary>
        /// Checks to see if the DesiredInstances property is set.
        /// </summary>
        internal bool IsSetDesiredInstances() => this.DesiredInstances.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredSessions. 
        /// <para>
        /// The desired number of user sessions for a multi-session fleet. This is not allowed
        /// for single-session fleets.
        /// </para>
        ///  
        /// <para>
        /// When you create a fleet, you must set either the DesiredSessions or DesiredInstances
        /// attribute, based on the type of fleet you create. You can’t define both attributes
        /// or leave both attributes blank.
        /// </para>
        /// </summary>
        public int? DesiredSessions { get; set; }

        /// <summary>
        /// Checks to see if the DesiredSessions property is set.
        /// </summary>
        internal bool IsSetDesiredSessions() => this.DesiredSessions.HasValue;
    }
}
