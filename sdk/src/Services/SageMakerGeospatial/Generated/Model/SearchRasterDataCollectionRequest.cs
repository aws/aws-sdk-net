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
    /// Container for the parameters to the SearchRasterDataCollection operation.
    /// Allows you run image query on a specific raster data collection to get a list of the
    /// satellite imagery matching the selected filters.
    /// </summary>
    public partial class SearchRasterDataCollectionRequest : AmazonSageMakerGeospatialRequest
    {
        private string _arn;
        private string _nextToken;
        private RasterDataCollectionQueryWithBandFilterInput _rasterDataCollectionQuery;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the raster data collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, you receive this token. Use it in your next
        /// request to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RasterDataCollectionQuery.
        /// </summary>
        [AWSProperty(Required=true)]
        public RasterDataCollectionQueryWithBandFilterInput RasterDataCollectionQuery
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