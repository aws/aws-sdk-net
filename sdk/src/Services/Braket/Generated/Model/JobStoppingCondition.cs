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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Specifies limits for how long an Amazon Braket hybrid job can run.
    /// </summary>
    public partial class JobStoppingCondition
    {
        private int? _maxRuntimeInSeconds;

        /// <summary>
        /// Gets and sets the property MaxRuntimeInSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that an Amazon Braket hybrid job can run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=432000)]
        public int? MaxRuntimeInSeconds
        {
            get { return this._maxRuntimeInSeconds; }
            set { this._maxRuntimeInSeconds = value; }
        }

        // Check to see if MaxRuntimeInSeconds property is set
        internal bool IsSetMaxRuntimeInSeconds()
        {
            return this._maxRuntimeInSeconds.HasValue; 
        }

    }
}