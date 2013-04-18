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
    /// Container for the parameters to the DescribeObjects operation.
    /// <para> Returns the object definitions for a set of objects associated with the pipeline. Object definitions are composed of a set of fields
    /// that define the properties of the object. </para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.DescribeObjects"/>
    public class DescribeObjectsRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private List<string> objectIds = new List<string>();
        private bool? evaluateExpressions;
        private string marker;

        /// <summary>
        /// Identifier of the pipeline that contains the object definitions.
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
        public DescribeObjectsRequest WithPipelineId(string pipelineId)
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
        /// Identifiers of the pipeline objects that contain the definitions to be described. You can pass as many as 25 identifiers in a single call to
        /// DescribeObjects.
        ///  
        /// </summary>
        public List<string> ObjectIds
        {
            get { return this.objectIds; }
            set { this.objectIds = value; }
        }
        /// <summary>
        /// Adds elements to the ObjectIds collection
        /// </summary>
        /// <param name="objectIds">The values to add to the ObjectIds collection </param>
        /// <returns>this instance</returns>
        public DescribeObjectsRequest WithObjectIds(params string[] objectIds)
        {
            foreach (string element in objectIds)
            {
                this.objectIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ObjectIds collection
        /// </summary>
        /// <param name="objectIds">The values to add to the ObjectIds collection </param>
        /// <returns>this instance</returns>
        public DescribeObjectsRequest WithObjectIds(IEnumerable<string> objectIds)
        {
            foreach (string element in objectIds)
            {
                this.objectIds.Add(element);
            }

            return this;
        }

        // Check to see if ObjectIds property is set
        internal bool IsSetObjectIds()
        {
            return this.objectIds.Count > 0;
        }

        /// <summary>
        /// Indicates whether any expressions in the object should be evaluated when the object descriptions are returned.
        ///  
        /// </summary>
        public bool EvaluateExpressions
        {
            get { return this.evaluateExpressions ?? default(bool); }
            set { this.evaluateExpressions = value; }
        }

        /// <summary>
        /// Sets the EvaluateExpressions property
        /// </summary>
        /// <param name="evaluateExpressions">The value to set for the EvaluateExpressions property </param>
        /// <returns>this instance</returns>
        public DescribeObjectsRequest WithEvaluateExpressions(bool evaluateExpressions)
        {
            this.evaluateExpressions = evaluateExpressions;
            return this;
        }
            

        // Check to see if EvaluateExpressions property is set
        internal bool IsSetEvaluateExpressions()
        {
            return this.evaluateExpressions.HasValue;
        }

        /// <summary>
        /// The starting point for the results to be returned. The first time you call <a>DescribeObjects</a>, this value should be empty. As long as
        /// the action returns <c>HasMoreResults</c> as <c>True</c>, you can call <a>DescribeObjects</a> again and pass the marker value from the
        /// response to retrieve the next set of results.
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
        public DescribeObjectsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
    
