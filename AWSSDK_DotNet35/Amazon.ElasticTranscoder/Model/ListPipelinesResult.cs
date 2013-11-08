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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>A list of the pipelines associated with the current AWS account.</para>
    /// </summary>
    public partial class ListPipelinesResult : AmazonWebServiceResponse
    {
        
        private List<Pipeline> pipelines = new List<Pipeline>();


        /// <summary>
        /// An array of <c>Pipeline</c> objects.
        ///  
        /// </summary>
        public List<Pipeline> Pipelines
        {
            get { return this.pipelines; }
            set { this.pipelines = value; }
        }

        // Check to see if Pipelines property is set
        internal bool IsSetPipelines()
        {
            return this.pipelines.Count > 0;
        }
    }
}
