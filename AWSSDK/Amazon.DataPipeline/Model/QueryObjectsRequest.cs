/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the QueryObjects operation.
    /// <para>Queries a pipeline for the names of objects that match a specified set of conditions.</para> <para>The objects returned by
    /// QueryObjects are paginated and then filtered by the value you set for query. This means the action may return an empty result set with a
    /// value set for marker. If <c>HasMoreResults</c> is set to <c>True</c> , you should continue to call QueryObjects, passing in the returned
    /// value for marker, until <c>HasMoreResults</c> returns <c>False</c> .</para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.QueryObjects"/>
    public class QueryObjectsRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private Query query;
        private string sphere;
        private string marker;
        private int? limit;

        /// <summary>
        /// Identifier of the pipeline to be queried for object names.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this.pipelineId; }
            set { this.pipelineId = value; }
        }

        /// <summary>
        /// Sets the PipelineId property
        /// </summary>
        /// <param name="pipelineId">The value to set for the PipelineId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsRequest WithPipelineId(string pipelineId)
        {
            this.pipelineId = pipelineId;
            return this;
        }
            

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this.pipelineId != null;
        }

        /// <summary>
        /// Query that defines the objects to be returned. The <a>Query</a> object can contain a maximum of ten selectors. The conditions in the query
        /// are limited to top-level String fields in the object. These filters can be applied to components, instances, and attempts.
        ///  
        /// </summary>
        public Query Query
        {
            get { return this.query; }
            set { this.query = value; }
        }

        /// <summary>
        /// Sets the Query property
        /// </summary>
        /// <param name="query">The value to set for the Query property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsRequest WithQuery(Query query)
        {
            this.query = query;
            return this;
        }
            

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this.query != null;
        }

        /// <summary>
        /// Specifies whether the query applies to components or instances. Allowable values: <c>COMPONENT</c>, <c>INSTANCE</c>, <c>ATTEMPT</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Sphere
        {
            get { return this.sphere; }
            set { this.sphere = value; }
        }

        /// <summary>
        /// Sets the Sphere property
        /// </summary>
        /// <param name="sphere">The value to set for the Sphere property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsRequest WithSphere(string sphere)
        {
            this.sphere = sphere;
            return this;
        }
            

        // Check to see if Sphere property is set
        internal bool IsSetSphere()
        {
            return this.sphere != null;
        }

        /// <summary>
        /// The starting point for the results to be returned. The first time you call <a>QueryObjects</a>, this value should be empty. As long as the
        /// action returns <c>HasMoreResults</c> as <c>True</c>, you can call <a>QueryObjects</a> again and pass the marker value from the response to
        /// retrieve the next set of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// Specifies the maximum number of object names that <a>QueryObjects</a> will return in a single call. The default value is 100.
        ///  
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }
    }
}
    
