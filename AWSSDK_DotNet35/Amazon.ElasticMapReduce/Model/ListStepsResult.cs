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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>This output contains the list of steps.</para>
    /// </summary>
    public partial class ListStepsResult : AmazonWebServiceResponse
    {
        
        private List<StepSummary> steps = new List<StepSummary>();
        private string marker;


        /// <summary>
        /// The filtered list of steps for the cluster.
        ///  
        /// </summary>
        public List<StepSummary> Steps
        {
            get { return this.steps; }
            set { this.steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this.steps.Count > 0;
        }

        /// <summary>
        /// The pagination token is a random string indicating whether there are more results to fetch. Use the pagination token in later API calls to
        /// retrieve the next page of results. When the value is null, all results have been returned.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
