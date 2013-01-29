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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobsByPipeline operation.
    /// <para>To get a list of the jobs currently in a pipeline, send a GET request to the <c>/2012-09-25/jobsByPipeline/[pipelineId] </c>
    /// resource.</para> <para>Elastic Transcoder returns all of the jobs currently in the specified pipeline. The response body contains one
    /// element for each job that satisfies the search criteria.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByPipeline"/>
    public class ListJobsByPipelineRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private string ascending;
        private string pageToken;

        /// <summary>
        /// The ID of the pipeline for which you want to get job information.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
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
        public ListJobsByPipelineRequest WithPipelineId(string pipelineId)
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
        /// To list jobs in chronological order by the date and time that they were submitted, enter <c>true</c>. To list jobs in reverse chronological
        /// order, enter <c>false</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^true$)|(^false$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Ascending
        {
            get { return this.ascending; }
            set { this.ascending = value; }
        }

        /// <summary>
        /// Sets the Ascending property
        /// </summary>
        /// <param name="ascending">The value to set for the Ascending property </param>
        /// <returns>this instance</returns>
        public ListJobsByPipelineRequest WithAscending(string ascending)
        {
            this.ascending = ascending;
            return this;
        }
            

        // Check to see if Ascending property is set
        internal bool IsSetAscending()
        {
            return this.ascending != null;
        }

        /// <summary>
        /// When Elastic Transcoder returns more than one page of results, use <c>pageToken</c> in subsequent <c>GET</c> requests to get each successive
        /// page of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this.pageToken; }
            set { this.pageToken = value; }
        }

        /// <summary>
        /// Sets the PageToken property
        /// </summary>
        /// <param name="pageToken">The value to set for the PageToken property </param>
        /// <returns>this instance</returns>
        public ListJobsByPipelineRequest WithPageToken(string pageToken)
        {
            this.pageToken = pageToken;
            return this;
        }
            

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this.pageToken != null;
        }
    }
}
    
