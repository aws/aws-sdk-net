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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The InputConfig for an EarthObservationJob response.
    /// </summary>
    public partial class InputConfigOutput
    {
        private EojDataSourceConfigInput _dataSourceConfig;
        private string _previousEarthObservationJobArn;
        private RasterDataCollectionQueryOutput _rasterDataCollectionQuery;

        /// <summary>
        /// Gets and sets the property DataSourceConfig. 
        /// <para>
        /// The location of the input data.
        /// </para>
        /// </summary>
        public EojDataSourceConfigInput DataSourceConfig
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
        /// Gets and sets the property PreviousEarthObservationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the previous Earth Observation job.
        /// </para>
        /// </summary>
        public string PreviousEarthObservationJobArn
        {
            get { return this._previousEarthObservationJobArn; }
            set { this._previousEarthObservationJobArn = value; }
        }

        // Check to see if PreviousEarthObservationJobArn property is set
        internal bool IsSetPreviousEarthObservationJobArn()
        {
            return this._previousEarthObservationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property RasterDataCollectionQuery.
        /// </summary>
        public RasterDataCollectionQueryOutput RasterDataCollectionQuery
        {
            get { return this._rasterDataCollectionQuery; }
            set { this._rasterDataCollectionQuery = value; }
        }

        // Check to see if RasterDataCollectionQuery property is set
        internal bool IsSetRasterDataCollectionQuery()
        {
            return this._rasterDataCollectionQuery != null;
        }

    }
}