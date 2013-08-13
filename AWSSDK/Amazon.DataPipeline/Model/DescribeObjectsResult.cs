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
    /// <para>If <c>True</c> , there are more results that can be returned in another call to DescribeObjects.</para>
    /// </summary>
    public class DescribeObjectsResult
    {
        
        private List<PipelineObject> pipelineObjects = new List<PipelineObject>();
        private string marker;
        private bool? hasMoreResults;

        /// <summary>
        /// An array of object definitions that are returned by the call to <a>DescribeObjects</a>.
        ///  
        /// </summary>
        public List<PipelineObject> PipelineObjects
        {
            get { return this.pipelineObjects; }
            set { this.pipelineObjects = value; }
        }
        /// <summary>
        /// Adds elements to the PipelineObjects collection
        /// </summary>
        /// <param name="pipelineObjects">The values to add to the PipelineObjects collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeObjectsResult WithPipelineObjects(params PipelineObject[] pipelineObjects)
        {
            foreach (PipelineObject element in pipelineObjects)
            {
                this.pipelineObjects.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PipelineObjects collection
        /// </summary>
        /// <param name="pipelineObjects">The values to add to the PipelineObjects collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeObjectsResult WithPipelineObjects(IEnumerable<PipelineObject> pipelineObjects)
        {
            foreach (PipelineObject element in pipelineObjects)
            {
                this.pipelineObjects.Add(element);
            }

            return this;
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this.pipelineObjects.Count > 0;
        }

        /// <summary>
        /// The starting point for the next page of results. To view the next page of results, call <a>DescribeObjects</a> again with this marker value.
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
        public DescribeObjectsResult WithMarker(string marker)
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
        /// If <c>True</c>, there are more pages of results to return.
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
        public DescribeObjectsResult WithHasMoreResults(bool hasMoreResults)
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
