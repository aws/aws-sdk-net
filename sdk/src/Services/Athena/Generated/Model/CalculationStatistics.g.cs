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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains statistics for a notebook calculation.
    /// </summary>
    public partial class CalculationStatistics
    {
        /// <summary>
        /// Gets and sets the property DpuExecutionInMillis. 
        /// <para>
        /// The data processing unit execution time in milliseconds for the calculation.
        /// </para>
        /// </summary>
        public long? DpuExecutionInMillis { get; set; }

        /// <summary>
        /// Checks to see if the DpuExecutionInMillis property is set.
        /// </summary>
        internal bool IsSetDpuExecutionInMillis() => this.DpuExecutionInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;
    }
}
