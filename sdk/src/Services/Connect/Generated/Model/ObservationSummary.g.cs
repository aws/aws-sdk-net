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
    /// Contains summary statistics about a test case execution.
    /// </summary>
    public partial class ObservationSummary
    {
        /// <summary>
        /// Gets and sets the property ObservationsFailed. 
        /// <para>
        /// The number of observations that failed during execution.
        /// </para>
        /// </summary>
        public int? ObservationsFailed { get; set; }

        /// <summary>
        /// Checks to see if the ObservationsFailed property is set.
        /// </summary>
        internal bool IsSetObservationsFailed() => this.ObservationsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property ObservationsPassed. 
        /// <para>
        /// The number of observations that passed during execution.
        /// </para>
        /// </summary>
        public int? ObservationsPassed { get; set; }

        /// <summary>
        /// Checks to see if the ObservationsPassed property is set.
        /// </summary>
        internal bool IsSetObservationsPassed() => this.ObservationsPassed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalObservations. 
        /// <para>
        /// The total number of observations in the test case.
        /// </para>
        /// </summary>
        public int? TotalObservations { get; set; }

        /// <summary>
        /// Checks to see if the TotalObservations property is set.
        /// </summary>
        internal bool IsSetTotalObservations() => this.TotalObservations.HasValue;
    }
}
