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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Details about the timing of a job.
    /// </summary>
    public partial class Timing
    {
        private long? _finishTimeMillis;
        private long? _startTimeMillis;
        private long? _submitTimeMillis;

        /// <summary>
        /// Gets and sets the property FinishTimeMillis. 
        /// <para>
        /// The time the job finished transcoding, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long? FinishTimeMillis
        {
            get { return this._finishTimeMillis; }
            set { this._finishTimeMillis = value; }
        }

        // Check to see if FinishTimeMillis property is set
        internal bool IsSetFinishTimeMillis()
        {
            return this._finishTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeMillis. 
        /// <para>
        /// The time the job began transcoding, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long? StartTimeMillis
        {
            get { return this._startTimeMillis; }
            set { this._startTimeMillis = value; }
        }

        // Check to see if StartTimeMillis property is set
        internal bool IsSetStartTimeMillis()
        {
            return this._startTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeMillis. 
        /// <para>
        /// The time the job was submitted to Elastic Transcoder, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long? SubmitTimeMillis
        {
            get { return this._submitTimeMillis; }
            set { this._submitTimeMillis = value; }
        }

        // Check to see if SubmitTimeMillis property is set
        internal bool IsSetSubmitTimeMillis()
        {
            return this._submitTimeMillis.HasValue; 
        }

    }
}