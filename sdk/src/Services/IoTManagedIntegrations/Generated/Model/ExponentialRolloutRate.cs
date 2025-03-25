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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing exponential rate of rollout for an over-the-air (OTA) task.
    /// </summary>
    public partial class ExponentialRolloutRate
    {
        private int? _baseRatePerMinute;
        private double? _incrementFactor;
        private RolloutRateIncreaseCriteria _rateIncreaseCriteria;

        /// <summary>
        /// Gets and sets the property BaseRatePerMinute. 
        /// <para>
        /// The base rate per minute for the rollout of an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? BaseRatePerMinute
        {
            get { return this._baseRatePerMinute; }
            set { this._baseRatePerMinute = value; }
        }

        // Check to see if BaseRatePerMinute property is set
        internal bool IsSetBaseRatePerMinute()
        {
            return this._baseRatePerMinute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncrementFactor. 
        /// <para>
        /// The incremental factor for increasing the rollout rate of an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public double? IncrementFactor
        {
            get { return this._incrementFactor; }
            set { this._incrementFactor = value; }
        }

        // Check to see if IncrementFactor property is set
        internal bool IsSetIncrementFactor()
        {
            return this._incrementFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateIncreaseCriteria. 
        /// <para>
        /// The criteria for increasing the rollout rate of an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public RolloutRateIncreaseCriteria RateIncreaseCriteria
        {
            get { return this._rateIncreaseCriteria; }
            set { this._rateIncreaseCriteria = value; }
        }

        // Check to see if RateIncreaseCriteria property is set
        internal bool IsSetRateIncreaseCriteria()
        {
            return this._rateIncreaseCriteria != null;
        }

    }
}