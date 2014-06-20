/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
    /// 
    ///         
    /// <para>
    /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
    ///            response body contains one element for each job that satisfies the search
    /// criteria.
    /// </para>
    /// </summary>
    public partial class ListJobsByPipelineRequest : AmazonWebServiceRequest
    {
        private string _ascending;
        private string _pageToken;
        private string _pipelineId;


        /// <summary>
        /// Gets and sets the property Ascending. 
        /// <para>
        ///  To list jobs in chronological order by the date and time that they were submitted,
        /// enter                <code>true</code>. To list jobs in reverse chronological order,
        /// enter                <code>false</code>. 
        /// </para>
        /// </summary>
        public string Ascending
        {
            get { return this._ascending; }
            set { this._ascending = value; }
        }


        /// <summary>
        /// Sets the Ascending property
        /// </summary>
        /// <param name="ascending">The value to set for the Ascending property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsByPipelineRequest WithAscending(string ascending)
        {
            this._ascending = ascending;
            return this;
        }

        // Check to see if Ascending property is set
        internal bool IsSetAscending()
        {
            return this._ascending != null;
        }


        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        ///  When Elastic Transcoder returns more than one page of results, use <code>pageToken</code>
        /// in            subsequent <code>GET</code> requests to get each successive page of
        /// results. 
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }


        /// <summary>
        /// Sets the PageToken property
        /// </summary>
        /// <param name="pageToken">The value to set for the PageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsByPipelineRequest WithPageToken(string pageToken)
        {
            this._pageToken = pageToken;
            return this;
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }


        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        ///  The ID of the pipeline for which you want to get job information. 
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }


        /// <summary>
        /// Sets the PipelineId property
        /// </summary>
        /// <param name="pipelineId">The value to set for the PipelineId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsByPipelineRequest WithPipelineId(string pipelineId)
        {
            this._pipelineId = pipelineId;
            return this;
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

    }
}