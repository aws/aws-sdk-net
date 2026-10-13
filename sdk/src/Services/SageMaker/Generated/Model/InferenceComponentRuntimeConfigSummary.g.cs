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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details about the runtime settings for the model that is deployed with the inference
    /// component.
    /// </summary>
    public partial class InferenceComponentRuntimeConfigSummary
    {
        /// <summary>
        /// Gets and sets the property CurrentCopyCount. 
        /// <para>
        /// The number of runtime copies of the model container that are currently deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentCopyCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentCopyCount property is set.
        /// </summary>
        internal bool IsSetCurrentCopyCount() => this.CurrentCopyCount.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredCopyCount. 
        /// <para>
        /// The number of runtime copies of the model container that you requested to deploy with
        /// the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DesiredCopyCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCopyCount property is set.
        /// </summary>
        internal bool IsSetDesiredCopyCount() => this.DesiredCopyCount.HasValue;

        /// <summary>
        /// Gets and sets the property PlacementStatus. 
        /// <para>
        /// The placement status of the inference component across instance types. Shows how the
        /// inference component copies are distributed across instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<InferenceComponentPlacementStatus> PlacementStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<InferenceComponentPlacementStatus>() : null;

        /// <summary>
        /// Checks to see if the PlacementStatus property is set.
        /// </summary>
        internal bool IsSetPlacementStatus() => this.PlacementStatus != null && (this.PlacementStatus.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
