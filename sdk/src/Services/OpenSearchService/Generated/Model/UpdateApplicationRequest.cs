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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// Update the OpenSearch Application.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonOpenSearchServiceRequest
    {
        private List<AppConfig> _appConfigs = AWSConfigs.InitializeCollections ? new List<AppConfig>() : null;
        private List<DataSource> _dataSources = AWSConfigs.InitializeCollections ? new List<DataSource>() : null;
        private string _id;

        /// <summary>
        /// Gets and sets the property AppConfigs. 
        /// <para>
        /// Configurations to be changed for the OpenSearch Application.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<AppConfig> AppConfigs
        {
            get { return this._appConfigs; }
            set { this._appConfigs = value; }
        }

        // Check to see if AppConfigs property is set
        internal bool IsSetAppConfigs()
        {
            return this._appConfigs != null && (this._appConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Data sources to be associated with the OpenSearch Application.
        /// </para>
        /// </summary>
        public List<DataSource> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && (this._dataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier of the OpenSearch Application to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}