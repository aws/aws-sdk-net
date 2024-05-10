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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Provides timing details for the job.
    /// </summary>
    public partial class JobTimers
    {
        private long? _elapsedTimeInActiveSeconds;

        /// <summary>
        /// Gets and sets the property ElapsedTimeInActiveSeconds. 
        /// <para>
        /// Indicates the elapsed time in seconds the job has been in the Active job state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ElapsedTimeInActiveSeconds
        {
            get { return this._elapsedTimeInActiveSeconds; }
            set { this._elapsedTimeInActiveSeconds = value; }
        }

        // Check to see if ElapsedTimeInActiveSeconds property is set
        internal bool IsSetElapsedTimeInActiveSeconds()
        {
            return this._elapsedTimeInActiveSeconds.HasValue; 
        }

    }
}