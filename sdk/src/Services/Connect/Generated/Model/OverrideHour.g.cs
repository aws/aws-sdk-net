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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about hours of operation override
    /// </summary>
    public partial class OverrideHour
    {
        /// <summary>
        /// Gets and sets the property End.
        /// </summary>
        public OverrideTimeSlice End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;

        /// <summary>
        /// Gets and sets the property OperationalStatus. 
        /// <para>
        /// Indicates whether the status is open or closed during the override period. This status
        /// determines how the override modifies the base hours of operation schedule.
        /// </para>
        /// </summary>
        public OperationalStatus OperationalStatus { get; set; }

        /// <summary>
        /// Checks to see if the OperationalStatus property is set.
        /// </summary>
        internal bool IsSetOperationalStatus() => this.OperationalStatus != null;

        /// <summary>
        /// Gets and sets the property OverrideName. 
        /// <para>
        /// Unique identifier name for the override.
        /// </para>
        /// </summary>
        public string OverrideName { get; set; }

        /// <summary>
        /// Checks to see if the OverrideName property is set.
        /// </summary>
        internal bool IsSetOverrideName() => this.OverrideName != null;

        /// <summary>
        /// Gets and sets the property Start.
        /// </summary>
        public OverrideTimeSlice Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start != null;
    }
}
