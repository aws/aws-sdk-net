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
    /// This is the response object from the GetMLModelTransformJob operation.
    /// </summary>
    public partial class GetMLModelTransformJobResponse : AmazonWebServiceResponse
    {
        private MlResourceDefinition _baseProcessingJob;
        private string _id;
        private List<MlConfigDefinition> _models = AWSConfigs.InitializeCollections ? new List<MlConfigDefinition>() : null;
        private MlResourceDefinition _remoteModelTransformJob;
        private string _status;

        /// <summary>
        /// Gets and sets the property BaseProcessingJob. 
        /// <para>
        /// The base data processing job.
        /// </para>
        /// </summary>
        public MlResourceDefinition BaseProcessingJob
        {
            get { return this._baseProcessingJob; }
            set { this._baseProcessingJob = value; }
        }

        // Check to see if BaseProcessingJob property is set
        internal bool IsSetBaseProcessingJob()
        {
            return this._baseProcessingJob != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the model-transform job to be retrieved.
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
        /// Gets and sets the property Models. 
        /// <para>
        /// A list of the configuration information for the models being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MlConfigDefinition> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoteModelTransformJob. 
        /// <para>
        /// The remote model transform job.
        /// </para>
        /// </summary>
        public MlResourceDefinition RemoteModelTransformJob
        {
            get { return this._remoteModelTransformJob; }
            set { this._remoteModelTransformJob = value; }
        }

        // Check to see if RemoteModelTransformJob property is set
        internal bool IsSetRemoteModelTransformJob()
        {
            return this._remoteModelTransformJob != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model-transform job.
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