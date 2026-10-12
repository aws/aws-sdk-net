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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private long? _prefillTokenCount;
        private long? _sampleTokenCount;
        private long? _trainingTokenCount;

        /// <summary>
        /// Gets and sets the property PrefillTokenCount. 
        /// <para>
        /// The number of prefill tokens consumed.
        /// </para>
        /// </summary>
        public long? PrefillTokenCount
        {
            get { return this._prefillTokenCount; }
            set { this._prefillTokenCount = value; }
        }

        // Check to see if PrefillTokenCount property is set
        internal bool IsSetPrefillTokenCount()
        {
            return this._prefillTokenCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleTokenCount. 
        /// <para>
        /// The number of sample tokens consumed.
        /// </para>
        /// </summary>
        public long? SampleTokenCount
        {
            get { return this._sampleTokenCount; }
            set { this._sampleTokenCount = value; }
        }

        // Check to see if SampleTokenCount property is set
        internal bool IsSetSampleTokenCount()
        {
            return this._sampleTokenCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingTokenCount. 
        /// <para>
        /// The number of training tokens consumed.
        /// </para>
        /// </summary>
        public long? TrainingTokenCount
        {
            get { return this._trainingTokenCount; }
            set { this._trainingTokenCount = value; }
        }

        // Check to see if TrainingTokenCount property is set
        internal bool IsSetTrainingTokenCount()
        {
            return this._trainingTokenCount.HasValue; 
        }

    }
}