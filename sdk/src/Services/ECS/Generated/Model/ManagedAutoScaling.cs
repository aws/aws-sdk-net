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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The auto scaling configuration created by Amazon ECS for an Express service.
    /// </summary>
    public partial class ManagedAutoScaling
    {
        private List<ManagedApplicationAutoScalingPolicy> _applicationAutoScalingPolicies = AWSConfigs.InitializeCollections ? new List<ManagedApplicationAutoScalingPolicy>() : null;
        private ManagedScalableTarget _scalableTarget;

        /// <summary>
        /// Gets and sets the property ApplicationAutoScalingPolicies. 
        /// <para>
        /// The policy used for auto scaling.
        /// </para>
        /// </summary>
        public List<ManagedApplicationAutoScalingPolicy> ApplicationAutoScalingPolicies
        {
            get { return this._applicationAutoScalingPolicies; }
            set { this._applicationAutoScalingPolicies = value; }
        }

        // Check to see if ApplicationAutoScalingPolicies property is set
        internal bool IsSetApplicationAutoScalingPolicies()
        {
            return this._applicationAutoScalingPolicies != null && (this._applicationAutoScalingPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScalableTarget. 
        /// <para>
        /// Represents a scalable target.
        /// </para>
        /// </summary>
        public ManagedScalableTarget ScalableTarget
        {
            get { return this._scalableTarget; }
            set { this._scalableTarget = value; }
        }

        // Check to see if ScalableTarget property is set
        internal bool IsSetScalableTarget()
        {
            return this._scalableTarget != null;
        }

    }
}