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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// The configuration is the <c>TargetSamplingRate</c>, which is the sampling rate of
    /// the data after post processing by Amazon Lookout for Equipment. For example, if you
    /// provide data that has been collected at a 1 second level and you want the system to
    /// resample the data at a 1 minute rate before training, the <c>TargetSamplingRate</c>
    /// is 1 minute.
    /// 
    ///  
    /// <para>
    /// When providing a value for the <c>TargetSamplingRate</c>, you must attach the prefix
    /// "PT" to the rate you want. The value for a 1 second rate is therefore <i>PT1S</i>,
    /// the value for a 15 minute rate is <i>PT15M</i>, and the value for a 1 hour rate is
    /// <i>PT1H</i> 
    /// </para>
    /// </summary>
    public partial class DataPreProcessingConfiguration
    {
        private TargetSamplingRate _targetSamplingRate;

        /// <summary>
        /// Gets and sets the property TargetSamplingRate. 
        /// <para>
        /// The sampling rate of the data after post processing by Amazon Lookout for Equipment.
        /// For example, if you provide data that has been collected at a 1 second level and you
        /// want the system to resample the data at a 1 minute rate before training, the <c>TargetSamplingRate</c>
        /// is 1 minute.
        /// </para>
        ///  
        /// <para>
        /// When providing a value for the <c>TargetSamplingRate</c>, you must attach the prefix
        /// "PT" to the rate you want. The value for a 1 second rate is therefore <i>PT1S</i>,
        /// the value for a 15 minute rate is <i>PT15M</i>, and the value for a 1 hour rate is
        /// <i>PT1H</i> 
        /// </para>
        /// </summary>
        public TargetSamplingRate TargetSamplingRate
        {
            get { return this._targetSamplingRate; }
            set { this._targetSamplingRate = value; }
        }

        // Check to see if TargetSamplingRate property is set
        internal bool IsSetTargetSamplingRate()
        {
            return this._targetSamplingRate != null;
        }

    }
}