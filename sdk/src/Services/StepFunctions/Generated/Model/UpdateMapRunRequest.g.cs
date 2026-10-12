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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMapRun operation. Updates an in-progress
    /// Map Run's configuration to include changes to the settings that control maximum concurrency
    /// and Map Run failure.
    /// </summary>
    public partial class UpdateMapRunRequest : AmazonStepFunctionsRequest
    {
        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string MapRunArn { get; set; }

        /// <summary>
        /// Checks to see if the MapRunArn property is set.
        /// </summary>
        internal bool IsSetMapRunArn() => this.MapRunArn != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of child workflow executions that can be specified to run in parallel
        /// for the Map Run at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property ToleratedFailureCount. 
        /// <para>
        /// The maximum number of failed items before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ToleratedFailureCount { get; set; }

        /// <summary>
        /// Checks to see if the ToleratedFailureCount property is set.
        /// </summary>
        internal bool IsSetToleratedFailureCount() => this.ToleratedFailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property ToleratedFailurePercentage. 
        /// <para>
        /// The maximum percentage of failed items before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ToleratedFailurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ToleratedFailurePercentage property is set.
        /// </summary>
        internal bool IsSetToleratedFailurePercentage() => this.ToleratedFailurePercentage.HasValue;
    }
}
