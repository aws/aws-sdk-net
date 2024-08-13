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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a failed world.
    /// </summary>
    public partial class WorldFailure
    {
        private WorldGenerationJobErrorCode _failureCode;
        private int? _failureCount;
        private string _sampleFailureReason;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code of the world export job if it failed:
        /// </para>
        ///  <dl> <dt>InternalServiceError</dt> <dd> 
        /// <para>
        /// Internal service error.
        /// </para>
        ///  </dd> <dt>LimitExceeded</dt> <dd> 
        /// <para>
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed. 
        /// </para>
        ///  </dd> <dt>ResourceNotFound</dt> <dd> 
        /// <para>
        /// The specified resource could not be found. 
        /// </para>
        ///  </dd> <dt>RequestThrottled</dt> <dd> 
        /// <para>
        /// The request was throttled.
        /// </para>
        ///  </dd> <dt>InvalidInput</dt> <dd> 
        /// <para>
        /// An input parameter in the request is not valid.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public WorldGenerationJobErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of failed worlds.
        /// </para>
        /// </summary>
        public int? FailureCount
        {
            get { return this._failureCount; }
            set { this._failureCount = value; }
        }

        // Check to see if FailureCount property is set
        internal bool IsSetFailureCount()
        {
            return this._failureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleFailureReason. 
        /// <para>
        /// The sample reason why the world failed. World errors are aggregated. A sample is used
        /// as the <c>sampleFailureReason</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SampleFailureReason
        {
            get { return this._sampleFailureReason; }
            set { this._sampleFailureReason = value; }
        }

        // Check to see if SampleFailureReason property is set
        internal bool IsSetSampleFailureReason()
        {
            return this._sampleFailureReason != null;
        }

    }
}