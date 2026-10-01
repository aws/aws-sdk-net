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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetMLModelTrainingJob operation.
    /// </summary>
    public partial class GetMLModelTrainingJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HpoJob. 
        /// <para>
        /// The HPO job.
        /// </para>
        /// </summary>
        public MlResourceDefinition HpoJob { get; set; }

        /// <summary>
        /// Checks to see if the HpoJob property is set.
        /// </summary>
        internal bool IsSetHpoJob() => this.HpoJob != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of this model-training job.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MlModels. 
        /// <para>
        /// A list of the configurations of the ML models being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MlConfigDefinition> MlModels { get; set; } = AWSConfigs.InitializeCollections ? new List<MlConfigDefinition>() : null;

        /// <summary>
        /// Checks to see if the MlModels property is set.
        /// </summary>
        internal bool IsSetMlModels() => this.MlModels != null && (this.MlModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelTransformJob. 
        /// <para>
        /// The model transform job.
        /// </para>
        /// </summary>
        public MlResourceDefinition ModelTransformJob { get; set; }

        /// <summary>
        /// Checks to see if the ModelTransformJob property is set.
        /// </summary>
        internal bool IsSetModelTransformJob() => this.ModelTransformJob != null;

        /// <summary>
        /// Gets and sets the property ProcessingJob. 
        /// <para>
        /// The data processing job.
        /// </para>
        /// </summary>
        public MlResourceDefinition ProcessingJob { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJob property is set.
        /// </summary>
        internal bool IsSetProcessingJob() => this.ProcessingJob != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model training job.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
