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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
        private TrainedModelExportsConfigurationPolicy _trainedModelExports;
        private TrainedModelInferenceJobsConfigurationPolicy _trainedModelInferenceJobs;
        private TrainedModelsConfigurationPolicy _trainedModels;

        /// <summary>
        /// Gets and sets the property TrainedModelExports. 
        /// <para>
        /// Specifies who will receive the trained model export.
        /// </para>
        /// </summary>
        public TrainedModelExportsConfigurationPolicy TrainedModelExports
        {
            get { return this._trainedModelExports; }
            set { this._trainedModelExports = value; }
        }

        // Check to see if TrainedModelExports property is set
        internal bool IsSetTrainedModelExports()
        {
            return this._trainedModelExports != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelInferenceJobs. 
        /// <para>
        /// Specifies who will receive the trained model inference jobs.
        /// </para>
        /// </summary>
        public TrainedModelInferenceJobsConfigurationPolicy TrainedModelInferenceJobs
        {
            get { return this._trainedModelInferenceJobs; }
            set { this._trainedModelInferenceJobs = value; }
        }

        // Check to see if TrainedModelInferenceJobs property is set
        internal bool IsSetTrainedModelInferenceJobs()
        {
            return this._trainedModelInferenceJobs != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModels. 
        /// <para>
        /// Specifies who will receive the trained models.
        /// </para>
        /// </summary>
        public TrainedModelsConfigurationPolicy TrainedModels
        {
            get { return this._trainedModels; }
            set { this._trainedModels = value; }
        }

        // Check to see if TrainedModels property is set
        internal bool IsSetTrainedModels()
        {
            return this._trainedModels != null;
        }

    }
}