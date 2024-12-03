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
    /// Provides configuration information for the trained model inference job.
    /// </summary>
    public partial class TrainedModelInferenceJobsConfigurationPolicy
    {
        private List<LogsConfigurationPolicy> _containerLogs = AWSConfigs.InitializeCollections ? new List<LogsConfigurationPolicy>() : null;
        private TrainedModelInferenceMaxOutputSize _maxOutputSize;

        /// <summary>
        /// Gets and sets the property ContainerLogs. 
        /// <para>
        /// The logs container for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<LogsConfigurationPolicy> ContainerLogs
        {
            get { return this._containerLogs; }
            set { this._containerLogs = value; }
        }

        // Check to see if ContainerLogs property is set
        internal bool IsSetContainerLogs()
        {
            return this._containerLogs != null && (this._containerLogs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxOutputSize. 
        /// <para>
        /// The maximum allowed size of the output of the trained model inference job.
        /// </para>
        /// </summary>
        public TrainedModelInferenceMaxOutputSize MaxOutputSize
        {
            get { return this._maxOutputSize; }
            set { this._maxOutputSize = value; }
        }

        // Check to see if MaxOutputSize property is set
        internal bool IsSetMaxOutputSize()
        {
            return this._maxOutputSize != null;
        }

    }
}