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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output of DescribeObjects.
    /// </summary>
    public partial class DescribeObjectsResponse : AmazonWebServiceResponse
    {
        private bool? _hasMoreResults;
        private string _marker;
        private List<PipelineObject> _pipelineObjects = AWSConfigs.InitializeCollections ? new List<PipelineObject>() : null;

        /// <summary>
        /// Gets and sets the property HasMoreResults. 
        /// <para>
        /// Indicates whether there are more results to return.
        /// </para>
        /// </summary>
        public bool? HasMoreResults
        {
            get { return this._hasMoreResults; }
            set { this._hasMoreResults = value; }
        }

        // Check to see if HasMoreResults property is set
        internal bool IsSetHasMoreResults()
        {
            return this._hasMoreResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point for the next page of results. To view the next page of results,
        /// call <c>DescribeObjects</c> again with this marker value. If the value is null, there
        /// are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineObjects. 
        /// <para>
        /// An array of object definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PipelineObject> PipelineObjects
        {
            get { return this._pipelineObjects; }
            set { this._pipelineObjects = value; }
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this._pipelineObjects != null && (this._pipelineObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}