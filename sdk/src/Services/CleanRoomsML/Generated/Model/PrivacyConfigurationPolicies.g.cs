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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Information about the privacy configuration policies for a configured model algorithm
    /// association.
    /// </summary>
    public partial class PrivacyConfigurationPolicies
    {
        /// <summary>
        /// Gets and sets the property TrainedModelExports. 
        /// <para>
        /// Specifies who will receive the trained model export.
        /// </para>
        /// </summary>
        public TrainedModelExportsConfigurationPolicy TrainedModelExports { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelExports property is set.
        /// </summary>
        internal bool IsSetTrainedModelExports() => this.TrainedModelExports != null;

        /// <summary>
        /// Gets and sets the property TrainedModelInferenceJobs. 
        /// <para>
        /// Specifies who will receive the trained model inference jobs.
        /// </para>
        /// </summary>
        public TrainedModelInferenceJobsConfigurationPolicy TrainedModelInferenceJobs { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelInferenceJobs property is set.
        /// </summary>
        internal bool IsSetTrainedModelInferenceJobs() => this.TrainedModelInferenceJobs != null;

        /// <summary>
        /// Gets and sets the property TrainedModels. 
        /// <para>
        /// Specifies who will receive the trained models.
        /// </para>
        /// </summary>
        public TrainedModelsConfigurationPolicy TrainedModels { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModels property is set.
        /// </summary>
        internal bool IsSetTrainedModels() => this.TrainedModels != null;
    }
}
