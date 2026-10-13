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
    /// The cleanup outcomes for Amazon S3 output resources associated with upstream steps.
    /// </summary>
    public partial class CleanupStepMetadata
    {
        /// <summary>
        /// Gets and sets the property CleanedSteps. 
        /// <para>
        /// The names of upstream steps whose Amazon S3 output resources the Cleanup step deleted
        /// successfully.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> CleanedSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CleanedSteps property is set.
        /// </summary>
        internal bool IsSetCleanedSteps() => this.CleanedSteps != null && (this.CleanedSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedSteps. 
        /// <para>
        /// The upstream steps whose Amazon S3 output resources the Cleanup step could not delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<CleanupFailure> FailedSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<CleanupFailure>() : null;

        /// <summary>
        /// Checks to see if the FailedSteps property is set.
        /// </summary>
        internal bool IsSetFailedSteps() => this.FailedSteps != null && (this.FailedSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SkippedSteps. 
        /// <para>
        /// The names of upstream steps that the Cleanup step skipped. The Cleanup step skips
        /// a step when the output properties needed to locate its resources are unavailable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> SkippedSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SkippedSteps property is set.
        /// </summary>
        internal bool IsSetSkippedSteps() => this.SkippedSteps != null && (this.SkippedSteps.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
