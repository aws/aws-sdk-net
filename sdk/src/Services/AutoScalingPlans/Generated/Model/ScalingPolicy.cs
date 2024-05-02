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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
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
namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Represents a scaling policy.
    /// </summary>
    public partial class ScalingPolicy
    {
        private string _policyName;
        private PolicyType _policyType;
        private TargetTrackingConfiguration _targetTrackingConfiguration;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTrackingConfiguration. 
        /// <para>
        /// The target tracking scaling policy. Includes support for predefined or customized
        /// metrics.
        /// </para>
        /// </summary>
        public TargetTrackingConfiguration TargetTrackingConfiguration
        {
            get { return this._targetTrackingConfiguration; }
            set { this._targetTrackingConfiguration = value; }
        }

        // Check to see if TargetTrackingConfiguration property is set
        internal bool IsSetTargetTrackingConfiguration()
        {
            return this._targetTrackingConfiguration != null;
        }

    }
}