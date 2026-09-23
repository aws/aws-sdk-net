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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides processing statistics for a classification job.
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// Gets and sets the property ApproximateNumberOfObjectsToProcess. 
        /// <para>
        /// The approximate number of objects that the job has yet to process during its current
        /// run.
        /// </para>
        /// </summary>
        public double? ApproximateNumberOfObjectsToProcess { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateNumberOfObjectsToProcess property is set.
        /// </summary>
        internal bool IsSetApproximateNumberOfObjectsToProcess() => this.ApproximateNumberOfObjectsToProcess.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfRuns. 
        /// <para>
        /// The number of times that the job has run.
        /// </para>
        /// </summary>
        public double? NumberOfRuns { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRuns property is set.
        /// </summary>
        internal bool IsSetNumberOfRuns() => this.NumberOfRuns.HasValue;
    }
}
