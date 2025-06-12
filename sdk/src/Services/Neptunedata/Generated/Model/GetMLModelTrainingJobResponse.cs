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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
        private MlResourceDefinition _hpoJob;
        private string _id;
        private List<MlConfigDefinition> _mlModels = AWSConfigs.InitializeCollections ? new List<MlConfigDefinition>() : null;
        private MlResourceDefinition _modelTransformJob;
        private MlResourceDefinition _processingJob;
        private string _status;

        /// <summary>
        /// Gets and sets the property HpoJob. 
        /// <para>
        /// The HPO job.
        /// </para>
        /// </summary>
        public MlResourceDefinition HpoJob
        {
            get { return this._hpoJob; }
            set { this._hpoJob = value; }
        }

        // Check to see if HpoJob property is set
        internal bool IsSetHpoJob()
        {
            return this._hpoJob != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of this model-training job.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MlModels. 
        /// <para>
        /// A list of the configurations of the ML models being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MlConfigDefinition> MlModels
        {
            get { return this._mlModels; }
            set { this._mlModels = value; }
        }

        // Check to see if MlModels property is set
        internal bool IsSetMlModels()
        {
            return this._mlModels != null && (this._mlModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelTransformJob. 
        /// <para>
        /// The model transform job.
        /// </para>
        /// </summary>
        public MlResourceDefinition ModelTransformJob
        {
            get { return this._modelTransformJob; }
            set { this._modelTransformJob = value; }
        }

        // Check to see if ModelTransformJob property is set
        internal bool IsSetModelTransformJob()
        {
            return this._modelTransformJob != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingJob. 
        /// <para>
        /// The data processing job.
        /// </para>
        /// </summary>
        public MlResourceDefinition ProcessingJob
        {
            get { return this._processingJob; }
            set { this._processingJob = value; }
        }

        // Check to see if ProcessingJob property is set
        internal bool IsSetProcessingJob()
        {
            return this._processingJob != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model training job.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}