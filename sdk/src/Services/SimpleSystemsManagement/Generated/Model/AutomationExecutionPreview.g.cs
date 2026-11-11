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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the results of the execution preview.
    /// </summary>
    public partial class AutomationExecutionPreview
    {
        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Information about the Amazon Web Services Regions targeted by the execution preview.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StepPreviews. 
        /// <para>
        /// Information about the type of impact a runbook step would have on a resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Mutating</c>: The runbook step would make changes to the targets through actions
        /// that create, modify, or delete resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Non_Mutating</c>: The runbook step would retrieve data about resources but not
        /// make changes to them. This category generally includes <c>Describe*</c>, <c>List*</c>,
        /// <c>Get*</c>, and similar read-only API actions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Undetermined</c>: An undetermined step invokes executions performed by another
        /// orchestration service like Lambda, Step Functions, or Amazon Web Services Systems
        /// Manager Run Command. An undetermined step might also call a third-party API. Systems
        /// Manager Automation doesn't know the outcome of the orchestration processes or third-party
        /// API executions, so the results of the steps are undetermined.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> StepPreviews { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the StepPreviews property is set.
        /// </summary>
        internal bool IsSetStepPreviews() => this.StepPreviews != null && (this.StepPreviews.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetPreviews. 
        /// <para>
        /// Information that provides a preview of what the impact of running the specified Automation
        /// runbook would be.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TargetPreview> TargetPreviews { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetPreview>() : null;

        /// <summary>
        /// Checks to see if the TargetPreviews property is set.
        /// </summary>
        internal bool IsSetTargetPreviews() => this.TargetPreviews != null && (this.TargetPreviews.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalAccounts. 
        /// <para>
        /// Information about the Amazon Web Services accounts that were included in the execution
        /// preview.
        /// </para>
        /// </summary>
        public int? TotalAccounts { get; set; }

        /// <summary>
        /// Checks to see if the TotalAccounts property is set.
        /// </summary>
        internal bool IsSetTotalAccounts() => this.TotalAccounts.HasValue;
    }
}
