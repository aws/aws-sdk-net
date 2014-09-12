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

/*
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
    /// Contains the output from the <a>ListPipelines</a> action.
    /// </summary>
    public partial class ListPipelinesResult : AmazonWebServiceResponse
    {
        private bool? _hasMoreResults;
        private string _marker;
        private List<PipelineIdName> _pipelineIdList = new List<PipelineIdName>();

        /// <summary>
        /// Gets and sets the property HasMoreResults. 
        /// <para>
        /// If <code>True</code>, there are more results that can be obtained by a subsequent
        /// call to <a>ListPipelines</a>.
        /// </para>
        /// </summary>
        public bool HasMoreResults
        {
            get { return this._hasMoreResults.GetValueOrDefault(); }
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
        /// If not null, indicates the starting point for the set of pipeline identifiers that
        /// the next call to <a>ListPipelines</a> will retrieve. If null, there are no more pipeline
        /// identifiers.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PipelineIdList. 
        /// <para>
        ///  A list of all the pipeline identifiers that your account has permission to access.
        /// If you require additional information about the pipelines, you can use these identifiers
        /// to call <a>DescribePipelines</a> and <a>GetPipelineDefinition</a>. 
        /// </para>
        /// </summary>
        public List<PipelineIdName> PipelineIdList
        {
            get { return this._pipelineIdList; }
            set { this._pipelineIdList = value; }
        }

        // Check to see if PipelineIdList property is set
        internal bool IsSetPipelineIdList()
        {
            return this._pipelineIdList != null && this._pipelineIdList.Count > 0; 
        }

    }
}