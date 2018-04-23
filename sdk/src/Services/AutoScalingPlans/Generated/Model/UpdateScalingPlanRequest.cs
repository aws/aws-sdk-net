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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScalingPlan operation.
    /// Updates the scaling plan for the specified scaling plan.
    /// 
    ///  
    /// <para>
    /// You cannot update a scaling plan if it is in the process of being created, updated,
    /// or deleted.
    /// </para>
    /// </summary>
    public partial class UpdateScalingPlanRequest : AmazonAutoScalingPlansRequest
    {
        private ApplicationSource _applicationSource;
        private List<ScalingInstruction> _scalingInstructions = new List<ScalingInstruction>();
        private string _scalingPlanName;
        private long? _scalingPlanVersion;

        /// <summary>
        /// Gets and sets the property ApplicationSource. 
        /// <para>
        /// A CloudFormation stack or set of tags.
        /// </para>
        /// </summary>
        public ApplicationSource ApplicationSource
        {
            get { return this._applicationSource; }
            set { this._applicationSource = value; }
        }

        // Check to see if ApplicationSource property is set
        internal bool IsSetApplicationSource()
        {
            return this._applicationSource != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingInstructions. 
        /// <para>
        /// The scaling instructions.
        /// </para>
        /// </summary>
        public List<ScalingInstruction> ScalingInstructions
        {
            get { return this._scalingInstructions; }
            set { this._scalingInstructions = value; }
        }

        // Check to see if ScalingInstructions property is set
        internal bool IsSetScalingInstructions()
        {
            return this._scalingInstructions != null && this._scalingInstructions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanName. 
        /// <para>
        /// The name of the scaling plan.
        /// </para>
        /// </summary>
        public string ScalingPlanName
        {
            get { return this._scalingPlanName; }
            set { this._scalingPlanName = value; }
        }

        // Check to see if ScalingPlanName property is set
        internal bool IsSetScalingPlanName()
        {
            return this._scalingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long ScalingPlanVersion
        {
            get { return this._scalingPlanVersion.GetValueOrDefault(); }
            set { this._scalingPlanVersion = value; }
        }

        // Check to see if ScalingPlanVersion property is set
        internal bool IsSetScalingPlanVersion()
        {
            return this._scalingPlanVersion.HasValue; 
        }

    }
}