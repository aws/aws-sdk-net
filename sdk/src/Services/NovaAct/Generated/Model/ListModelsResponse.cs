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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// This is the response object from the ListModels operation.
    /// </summary>
    public partial class ListModelsResponse : AmazonWebServiceResponse
    {
        private CompatibilityInformation _compatibilityInformation;
        private List<ModelAlias> _modelAliases = AWSConfigs.InitializeCollections ? new List<ModelAlias>() : null;
        private List<ModelSummary> _modelSummaries = AWSConfigs.InitializeCollections ? new List<ModelSummary>() : null;

        /// <summary>
        /// Gets and sets the property CompatibilityInformation. 
        /// <para>
        /// Information about client compatibility and supported models.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompatibilityInformation CompatibilityInformation
        {
            get { return this._compatibilityInformation; }
            set { this._compatibilityInformation = value; }
        }

        // Check to see if CompatibilityInformation property is set
        internal bool IsSetCompatibilityInformation()
        {
            return this._compatibilityInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ModelAliases. 
        /// <para>
        /// A list of model aliases that provide stable references to model versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ModelAlias> ModelAliases
        {
            get { return this._modelAliases; }
            set { this._modelAliases = value; }
        }

        // Check to see if ModelAliases property is set
        internal bool IsSetModelAliases()
        {
            return this._modelAliases != null && (this._modelAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelSummaries. 
        /// <para>
        /// A list of available AI models with their status and compatibility information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ModelSummary> ModelSummaries
        {
            get { return this._modelSummaries; }
            set { this._modelSummaries = value; }
        }

        // Check to see if ModelSummaries property is set
        internal bool IsSetModelSummaries()
        {
            return this._modelSummaries != null && (this._modelSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}