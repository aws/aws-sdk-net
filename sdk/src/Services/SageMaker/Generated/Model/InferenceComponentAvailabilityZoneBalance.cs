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
    /// Configuration for balancing inference component copies across Availability Zones.
    /// </summary>
    public partial class InferenceComponentAvailabilityZoneBalance
    {
        private AvailabilityZoneBalanceEnforcementMode _enforcementMode;
        private int? _maxImbalance;

        /// <summary>
        /// Gets and sets the property EnforcementMode. 
        /// <para>
        /// Determines how strictly the Availability Zone balance constraint is enforced.
        /// </para>
        ///  <dl> <dt>PERMISSIVE</dt> <dd> 
        /// <para>
        /// The endpoint attempts to balance copies across Availability Zones but proceeds with
        /// scheduling even if balance can't be achieved due to available capacity or instance
        /// distribution across Availability Zones.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public AvailabilityZoneBalanceEnforcementMode EnforcementMode
        {
            get { return this._enforcementMode; }
            set { this._enforcementMode = value; }
        }

        // Check to see if EnforcementMode property is set
        internal bool IsSetEnforcementMode()
        {
            return this._enforcementMode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxImbalance. 
        /// <para>
        /// The maximum allowed difference in the number of inference component copies between
        /// any two Availability Zones. This parameter applies only when the endpoint has instances
        /// across two or more Availability Zones. A copy placement is allowed if it reduces imbalance
        /// or the resulting imbalance is within this value.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxImbalance
        {
            get { return this._maxImbalance; }
            set { this._maxImbalance = value; }
        }

        // Check to see if MaxImbalance property is set
        internal bool IsSetMaxImbalance()
        {
            return this._maxImbalance.HasValue; 
        }

    }
}