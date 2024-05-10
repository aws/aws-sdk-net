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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
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
namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The input structure for the InputConfig in a VectorEnrichmentJob.
    /// </summary>
    public partial class VectorEnrichmentJobInputConfig
    {
        private VectorEnrichmentJobDataSourceConfigInput _dataSourceConfig;
        private VectorEnrichmentJobDocumentType _documentType;

        /// <summary>
        /// Gets and sets the property DataSourceConfig. 
        /// <para>
        /// The input structure for the data source that represents the storage type of the input
        /// data objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorEnrichmentJobDataSourceConfigInput DataSourceConfig
        {
            get { return this._dataSourceConfig; }
            set { this._dataSourceConfig = value; }
        }

        // Check to see if DataSourceConfig property is set
        internal bool IsSetDataSourceConfig()
        {
            return this._dataSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The input structure that defines the data source file type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorEnrichmentJobDocumentType DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null;
        }

    }
}