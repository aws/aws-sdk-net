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
    /// Represents a scaling plan.
    /// </summary>
    public partial class ScalingPlan
    {
        /// <summary>
        /// Gets and sets the property ApplicationSource. 
        /// <para>
        /// A CloudFormation stack or a set of tags. You can create one scaling plan per application
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationSource ApplicationSource { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSource property is set.
        /// </summary>
        internal bool IsSetApplicationSource() => this.ApplicationSource != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The Unix time stamp when the scaling plan was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingInstructions. 
        /// <para>
        /// The scaling instructions.
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
        /// The name of the scaling plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ScalingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanName property is set.
        /// </summary>
        internal bool IsSetScalingPlanName() => this.ScalingPlanName != null;

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number of the scaling plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ScalingPlanVersion { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanVersion property is set.
        /// </summary>
        internal bool IsSetScalingPlanVersion() => this.ScalingPlanVersion.HasValue;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status of the scaling plan.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c> - The scaling plan is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ActiveWithProblems</c> - The scaling plan is active, but the scaling configuration
        /// for one or more resources could not be applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreationInProgress</c> - The scaling plan is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreationFailed</c> - The scaling plan could not be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeletionInProgress</c> - The scaling plan is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeletionFailed</c> - The scaling plan could not be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdateInProgress</c> - The scaling plan is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdateFailed</c> - The scaling plan could not be updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalingPlanStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A simple message about the current status of the scaling plan.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusStartTime. 
        /// <para>
        /// The Unix time stamp when the scaling plan entered the current status.
        /// </para>
        /// </summary>
        public DateTime? StatusStartTime { get; set; }

        /// <summary>
        /// Checks to see if the StatusStartTime property is set.
        /// </summary>
        internal bool IsSetStatusStartTime() => this.StatusStartTime.HasValue;
    }
}
