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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private int? _observationsFailed;
        private int? _observationsPassed;
        private int? _totalObservations;

        /// <summary>
        /// Gets and sets the property ObservationsFailed. 
        /// <para>
        /// The number of observations that failed during execution.
        /// </para>
        /// </summary>
        public int ObservationsFailed
        {
            get { return this._observationsFailed.GetValueOrDefault(); }
            set { this._observationsFailed = value; }
        }

        // Check to see if ObservationsFailed property is set
        internal bool IsSetObservationsFailed()
        {
            return this._observationsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObservationsPassed. 
        /// <para>
        /// The number of observations that passed during execution.
        /// </para>
        /// </summary>
        public int ObservationsPassed
        {
            get { return this._observationsPassed.GetValueOrDefault(); }
            set { this._observationsPassed = value; }
        }

        // Check to see if ObservationsPassed property is set
        internal bool IsSetObservationsPassed()
        {
            return this._observationsPassed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalObservations. 
        /// <para>
        /// The total number of observations in the test case.
        /// </para>
        /// </summary>
        public int TotalObservations
        {
            get { return this._totalObservations.GetValueOrDefault(); }
            set { this._totalObservations = value; }
        }

        // Check to see if TotalObservations property is set
        internal bool IsSetTotalObservations()
        {
            return this._totalObservations.HasValue; 
        }

    }
}