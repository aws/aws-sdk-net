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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The billable token usage for a training session, broken down by operation type.
    /// </summary>
    public partial class BillableTokenUsage
    {
        /// <summary>
        /// Gets and sets the property PrefillTokenCount. 
        /// <para>
        /// The number of prefill tokens consumed.
        /// </para>
        /// </summary>
        public long? PrefillTokenCount { get; set; }

        /// <summary>
        /// Checks to see if the PrefillTokenCount property is set.
        /// </summary>
        internal bool IsSetPrefillTokenCount() => this.PrefillTokenCount.HasValue;

        /// <summary>
        /// Gets and sets the property SampleTokenCount. 
        /// <para>
        /// The number of sample tokens consumed.
        /// </para>
        /// </summary>
        public long? SampleTokenCount { get; set; }

        /// <summary>
        /// Checks to see if the SampleTokenCount property is set.
        /// </summary>
        internal bool IsSetSampleTokenCount() => this.SampleTokenCount.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingTokenCount. 
        /// <para>
        /// The number of training tokens consumed.
        /// </para>
        /// </summary>
        public long? TrainingTokenCount { get; set; }

        /// <summary>
        /// Checks to see if the TrainingTokenCount property is set.
        /// </summary>
        internal bool IsSetTrainingTokenCount() => this.TrainingTokenCount.HasValue;
    }
}
