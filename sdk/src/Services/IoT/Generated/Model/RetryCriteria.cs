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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The criteria that determines how many retries are allowed for each failure type for
    /// a job.
    /// </summary>
    public partial class RetryCriteria
    {
        private RetryableFailureType _failureType;
        private int? _numberOfRetries;

        /// <summary>
        /// Gets and sets the property FailureType. 
        /// <para>
        /// The type of job execution failures that can initiate a job retry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetryableFailureType FailureType
        {
            get { return this._failureType; }
            set { this._failureType = value; }
        }

        // Check to see if FailureType property is set
        internal bool IsSetFailureType()
        {
            return this._failureType != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfRetries. 
        /// <para>
        /// The number of retries allowed for a failure type for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public int? NumberOfRetries
        {
            get { return this._numberOfRetries; }
            set { this._numberOfRetries = value; }
        }

        // Check to see if NumberOfRetries property is set
        internal bool IsSetNumberOfRetries()
        {
            return this._numberOfRetries.HasValue; 
        }

    }
}