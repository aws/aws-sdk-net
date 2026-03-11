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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains information about a canary run.
    /// </summary>
    public partial class CanaryRunConfigOutput
    {
        private bool? _activeTracing;
        private int? _ephemeralStorage;
        private int? _memoryInMB;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property ActiveTracing. 
        /// <para>
        /// Displays whether this canary run used active X-Ray tracing. 
        /// </para>
        /// </summary>
        public bool? ActiveTracing
        {
            get { return this._activeTracing; }
            set { this._activeTracing = value; }
        }

        // Check to see if ActiveTracing property is set
        internal bool IsSetActiveTracing()
        {
            return this._activeTracing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// Specifies the amount of ephemeral storage (in MB) to allocate for the canary run during
        /// execution. This temporary storage is used for storing canary run artifacts (which
        /// are uploaded to an Amazon S3 bucket at the end of the run), and any canary browser
        /// operations. This temporary storage is cleared after the run is completed. Default
        /// storage value is 1024 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=10240)]
        public int? EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryInMB. 
        /// <para>
        /// The maximum amount of memory available to the canary while it is running, in MB. This
        /// value must be a multiple of 64.
        /// </para>
        /// </summary>
        [AWSProperty(Min=960, Max=3008)]
        public int? MemoryInMB
        {
            get { return this._memoryInMB; }
            set { this._memoryInMB = value; }
        }

        // Check to see if MemoryInMB property is set
        internal bool IsSetMemoryInMB()
        {
            return this._memoryInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// How long the canary is allowed to run before it must stop.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=840)]
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}