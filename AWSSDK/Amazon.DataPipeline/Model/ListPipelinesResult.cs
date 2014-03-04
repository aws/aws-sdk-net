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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the ListPipelines action.</para>
    /// </summary>
    public class ListPipelinesResult
    {
        
        private List<PipelineIdName> pipelineIdList = new List<PipelineIdName>();
        private string marker;
        private bool? hasMoreResults;

        /// <summary>
        /// A list of all the pipeline identifiers that your account has permission to access. If you require additional information about the
        /// pipelines, you can use these identifiers to call <a>DescribePipelines</a> and <a>GetPipelineDefinition</a>.
        ///  
        /// </summary>
        public List<PipelineIdName> PipelineIdList
        {
            get { return this.pipelineIdList; }
            set { this.pipelineIdList = value; }
        }
        /// <summary>
        /// Adds elements to the PipelineIdList collection
        /// </summary>
        /// <param name="pipelineIdList">The values to add to the PipelineIdList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPipelinesResult WithPipelineIdList(params PipelineIdName[] pipelineIdList)
        {
            foreach (PipelineIdName element in pipelineIdList)
            {
                this.pipelineIdList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PipelineIdList collection
        /// </summary>
        /// <param name="pipelineIdList">The values to add to the PipelineIdList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPipelinesResult WithPipelineIdList(IEnumerable<PipelineIdName> pipelineIdList)
        {
            foreach (PipelineIdName element in pipelineIdList)
            {
                this.pipelineIdList.Add(element);
            }

            return this;
        }

        // Check to see if PipelineIdList property is set
        internal bool IsSetPipelineIdList()
        {
            return this.pipelineIdList.Count > 0;
        }

        /// <summary>
        /// If not null, indicates the starting point for the set of pipeline identifiers that the next call to <a>ListPipelines</a> will retrieve. If
        /// null, there are no more pipeline identifiers.
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
        public ListPipelinesResult WithMarker(string marker)
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
        /// If <c>True</c>, there are more results that can be obtained by a subsequent call to <a>ListPipelines</a>.
        ///  
        /// </summary>
        public bool HasMoreResults
        {
            get { return this.hasMoreResults ?? default(bool); }
            set { this.hasMoreResults = value; }
        }

        /// <summary>
        /// Sets the HasMoreResults property
        /// </summary>
        /// <param name="hasMoreResults">The value to set for the HasMoreResults property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPipelinesResult WithHasMoreResults(bool hasMoreResults)
        {
            this.hasMoreResults = hasMoreResults;
            return this;
        }
            

        // Check to see if HasMoreResults property is set
        internal bool IsSetHasMoreResults()
        {
            return this.hasMoreResults.HasValue;
        }
    }
}
