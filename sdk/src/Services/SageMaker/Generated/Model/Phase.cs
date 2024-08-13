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
    /// Defines the traffic pattern.
    /// </summary>
    public partial class Phase
    {
        private int? _durationInSeconds;
        private int? _initialNumberOfUsers;
        private int? _spawnRate;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// Specifies how long a traffic phase should be. For custom load tests, the value should
        /// be between 120 and 3600. This value should not exceed <c>JobDurationInSeconds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitialNumberOfUsers. 
        /// <para>
        /// Specifies how many concurrent users to start with. The value should be between 1 and
        /// 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? InitialNumberOfUsers
        {
            get { return this._initialNumberOfUsers; }
            set { this._initialNumberOfUsers = value; }
        }

        // Check to see if InitialNumberOfUsers property is set
        internal bool IsSetInitialNumberOfUsers()
        {
            return this._initialNumberOfUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpawnRate. 
        /// <para>
        /// Specified how many new users to spawn in a minute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? SpawnRate
        {
            get { return this._spawnRate; }
            set { this._spawnRate = value; }
        }

        // Check to see if SpawnRate property is set
        internal bool IsSetSpawnRate()
        {
            return this._spawnRate.HasValue; 
        }

    }
}