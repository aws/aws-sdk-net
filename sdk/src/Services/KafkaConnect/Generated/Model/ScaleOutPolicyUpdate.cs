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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// An update to the connector's scale-out policy.
    /// </summary>
    public partial class ScaleOutPolicyUpdate
    {
        private int? _cpuUtilizationPercentage;

        /// <summary>
        /// Gets and sets the property CpuUtilizationPercentage. 
        /// <para>
        /// The target CPU utilization percentage threshold at which you want connector scale
        /// out to be triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public int? CpuUtilizationPercentage
        {
            get { return this._cpuUtilizationPercentage; }
            set { this._cpuUtilizationPercentage = value; }
        }

        // Check to see if CpuUtilizationPercentage property is set
        internal bool IsSetCpuUtilizationPercentage()
        {
            return this._cpuUtilizationPercentage.HasValue; 
        }

    }
}