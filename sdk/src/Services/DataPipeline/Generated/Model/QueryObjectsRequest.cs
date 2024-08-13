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
    /// Container for the parameters to the QueryObjects operation.
    /// Queries the specified pipeline for the names of objects that match the specified set
    /// of conditions.
    /// </summary>
    public partial class QueryObjectsRequest : AmazonDataPipelineRequest
    {
        private int? _limit;
        private string _marker;
        private string _pipelineId;
        private Query _query;
        private string _sphere;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of object names that <c>QueryObjects</c> will return in a single
        /// call. The default value is 100. 
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point for the results to be returned. For the first call, this value
        /// should be empty. As long as there are more results, continue to call <c>QueryObjects</c>
        /// with the marker value from the previous call to retrieve the next set of results.
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
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query that defines the objects to be returned. The <c>Query</c> object can contain
        /// a maximum of ten selectors. The conditions in the query are limited to top-level String
        /// fields in the object. These filters can be applied to components, instances, and attempts.
        /// </para>
        /// </summary>
        public Query Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property Sphere. 
        /// <para>
        /// Indicates whether the query applies to components or instances. The possible values
        /// are: <c>COMPONENT</c>, <c>INSTANCE</c>, and <c>ATTEMPT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Sphere
        {
            get { return this._sphere; }
            set { this._sphere = value; }
        }

        // Check to see if Sphere property is set
        internal bool IsSetSphere()
        {
            return this._sphere != null;
        }

    }
}