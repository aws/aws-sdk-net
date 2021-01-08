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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The criteria to initiate the increase in rate of rollout for a job.
    /// </summary>
    public partial class AwsJobRateIncreaseCriteria
    {
        private int? _numberOfNotifiedThings;
        private int? _numberOfSucceededThings;

        /// <summary>
        /// Gets and sets the property NumberOfNotifiedThings. 
        /// <para>
        /// When this number of things have been notified, it will initiate an increase in the
        /// rollout rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int NumberOfNotifiedThings
        {
            get { return this._numberOfNotifiedThings.GetValueOrDefault(); }
            set { this._numberOfNotifiedThings = value; }
        }

        // Check to see if NumberOfNotifiedThings property is set
        internal bool IsSetNumberOfNotifiedThings()
        {
            return this._numberOfNotifiedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfSucceededThings. 
        /// <para>
        /// When this number of things have succeeded in their job execution, it will initiate
        /// an increase in the rollout rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int NumberOfSucceededThings
        {
            get { return this._numberOfSucceededThings.GetValueOrDefault(); }
            set { this._numberOfSucceededThings = value; }
        }

        // Check to see if NumberOfSucceededThings property is set
        internal bool IsSetNumberOfSucceededThings()
        {
            return this._numberOfSucceededThings.HasValue; 
        }

    }
}