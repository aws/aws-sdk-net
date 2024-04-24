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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about anomaly detection and mitigation.
    /// </summary>
    public partial class AnomalyDetection
    {
        private MitigationInEffectEnum _mitigationInEffect;
        private AnomalyResultEnum _result;

        /// <summary>
        /// Gets and sets the property MitigationInEffect. 
        /// <para>
        /// Indicates whether anomaly mitigation is in progress.
        /// </para>
        /// </summary>
        public MitigationInEffectEnum MitigationInEffect
        {
            get { return this._mitigationInEffect; }
            set { this._mitigationInEffect = value; }
        }

        // Check to see if MitigationInEffect property is set
        internal bool IsSetMitigationInEffect()
        {
            return this._mitigationInEffect != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The latest anomaly detection result.
        /// </para>
        /// </summary>
        public AnomalyResultEnum Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

    }
}