/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about the health of a target.
    /// </summary>
    public partial class TargetHealthDescription
    {
        private string _healthCheckPort;
        private TargetDescription _target;
        private TargetHealth _targetHealth;

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port to use to connect with the target.
        /// </para>
        /// </summary>
        public string HealthCheckPort
        {
            get { return this._healthCheckPort; }
            set { this._healthCheckPort = value; }
        }

        // Check to see if HealthCheckPort property is set
        internal bool IsSetHealthCheckPort()
        {
            return this._healthCheckPort != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The description of the target.
        /// </para>
        /// </summary>
        public TargetDescription Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TargetHealth. 
        /// <para>
        /// The health information for the target.
        /// </para>
        /// </summary>
        public TargetHealth TargetHealth
        {
            get { return this._targetHealth; }
            set { this._targetHealth = value; }
        }

        // Check to see if TargetHealth property is set
        internal bool IsSetTargetHealth()
        {
            return this._targetHealth != null;
        }

    }
}