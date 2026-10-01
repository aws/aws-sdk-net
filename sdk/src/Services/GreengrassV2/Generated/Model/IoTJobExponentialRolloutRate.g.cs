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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about an exponential rollout rate for a configuration deployment
    /// job.
    /// </summary>
    public partial class IoTJobExponentialRolloutRate
    {
        /// <summary>
        /// Gets and sets the property BaseRatePerMinute. 
        /// <para>
        /// The minimum number of devices that receive a pending job notification, per minute,
        /// when the job starts. This parameter defines the initial rollout rate of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public int? BaseRatePerMinute { get; set; }

        /// <summary>
        /// Checks to see if the BaseRatePerMinute property is set.
        /// </summary>
        internal bool IsSetBaseRatePerMinute() => this.BaseRatePerMinute.HasValue;

        /// <summary>
        /// Gets and sets the property IncrementFactor. 
        /// <para>
        /// The exponential factor to increase the rollout rate for the job.
        /// </para>
        ///  
        /// <para>
        /// This parameter supports up to one digit after the decimal (for example, you can specify
        /// <c>1.5</c>, but not <c>1.55</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public double? IncrementFactor { get; set; }

        /// <summary>
        /// Checks to see if the IncrementFactor property is set.
        /// </summary>
        internal bool IsSetIncrementFactor() => this.IncrementFactor.HasValue;

        /// <summary>
        /// Gets and sets the property RateIncreaseCriteria. 
        /// <para>
        /// The criteria to increase the rollout rate for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IoTJobRateIncreaseCriteria RateIncreaseCriteria { get; set; }

        /// <summary>
        /// Checks to see if the RateIncreaseCriteria property is set.
        /// </summary>
        internal bool IsSetRateIncreaseCriteria() => this.RateIncreaseCriteria != null;
    }
}
