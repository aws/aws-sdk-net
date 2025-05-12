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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The source information of a flow execution.
    /// </summary>
    public partial class DataIntegrationFlowExecutionSourceInfo
    {
        private DataIntegrationFlowDatasetSource _datasetSource;
        private DataIntegrationFlowS3Source _s3Source;
        private DataIntegrationFlowSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property DatasetSource. 
        /// <para>
        /// The source details of a flow execution with dataset source.
        /// </para>
        /// </summary>
        public DataIntegrationFlowDatasetSource DatasetSource
        {
            get { return this._datasetSource; }
            set { this._datasetSource = value; }
        }

        // Check to see if DatasetSource property is set
        internal bool IsSetDatasetSource()
        {
            return this._datasetSource != null;
        }

        /// <summary>
        /// Gets and sets the property S3Source. 
        /// <para>
        /// The source details of a flow execution with S3 source.
        /// </para>
        /// </summary>
        public DataIntegrationFlowS3Source S3Source
        {
            get { return this._s3Source; }
            set { this._s3Source = value; }
        }

        // Check to see if S3Source property is set
        internal bool IsSetS3Source()
        {
            return this._s3Source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The data integration flow execution source type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationFlowSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}