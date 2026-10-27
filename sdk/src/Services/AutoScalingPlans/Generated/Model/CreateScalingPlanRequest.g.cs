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

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScalingPlan operation. Creates a scaling
    /// plan.
    /// </summary>
    public partial class CreateScalingPlanRequest : AmazonAutoScalingPlansRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationSource. 
        /// <para>
        /// A CloudFormation stack or set of tags. You can create one scaling plan per application
        /// source.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/plans/APIReference/API_ApplicationSource.html">ApplicationSource</a>
        /// in the <i>AWS Auto Scaling API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationSource ApplicationSource { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSource property is set.
        /// </summary>
        internal bool IsSetApplicationSource() => this.ApplicationSource != null;

        /// <summary>
        /// Gets and sets the property ScalingInstructions. 
        /// <para>
        /// The scaling instructions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/plans/APIReference/API_ScalingInstruction.html">ScalingInstruction</a>
        /// in the <i>AWS Auto Scaling API Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ScalingInstruction> ScalingInstructions { get; set; } = AWSConfigs.InitializeCollections ? new List<ScalingInstruction>() : null;

        /// <summary>
        /// Checks to see if the ScalingInstructions property is set.
        /// </summary>
        internal bool IsSetScalingInstructions() => this.ScalingInstructions != null && (this.ScalingInstructions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScalingPlanName. 
        /// <para>
        /// The name of the scaling plan. Names cannot contain vertical bars, colons, or forward
        /// slashes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ScalingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanName property is set.
        /// </summary>
        internal bool IsSetScalingPlanName() => this.ScalingPlanName != null;
    }
}
