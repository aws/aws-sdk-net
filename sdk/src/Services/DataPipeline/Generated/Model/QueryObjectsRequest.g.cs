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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the QueryObjects operation. Queries the specified
    /// pipeline for the names of objects that match the specified set of conditions.
    /// </summary>
    public partial class QueryObjectsRequest : AmazonDataPipelineRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of object names that <c>QueryObjects</c> will return in a single
        /// call. The default value is 100. 
        /// </para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point for the results to be returned. For the first call, this value
        /// should be empty. As long as there are more results, continue to call <c>QueryObjects</c>
        /// with the marker value from the previous call to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string PipelineId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineId property is set.
        /// </summary>
        internal bool IsSetPipelineId() => this.PipelineId != null;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query that defines the objects to be returned. The <c>Query</c> object can contain
        /// a maximum of ten selectors. The conditions in the query are limited to top-level String
        /// fields in the object. These filters can be applied to components, instances, and attempts.
        /// </para>
        /// </summary>
        public Query Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property Sphere. 
        /// <para>
        /// Indicates whether the query applies to components or instances. The possible values
        /// are: <c>COMPONENT</c>, <c>INSTANCE</c>, and <c>ATTEMPT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Sphere { get; set; }

        /// <summary>
        /// Checks to see if the Sphere property is set.
        /// </summary>
        internal bool IsSetSphere() => this.Sphere != null;
    }
}
