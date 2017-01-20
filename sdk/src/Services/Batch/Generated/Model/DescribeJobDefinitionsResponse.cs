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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the DescribeJobDefinitions operation.
    /// </summary>
    public partial class DescribeJobDefinitionsResponse : AmazonWebServiceResponse
    {
        private List<JobDefinition> _jobDefinitions = new List<JobDefinition>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobDefinitions. 
        /// <para>
        /// The list of job definitions. 
        /// </para>
        /// </summary>
        public List<JobDefinition> JobDefinitions
        {
            get { return this._jobDefinitions; }
            set { this._jobDefinitions = value; }
        }

        // Check to see if JobDefinitions property is set
        internal bool IsSetJobDefinitions()
        {
            return this._jobDefinitions != null && this._jobDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>DescribeJobDefinitions</code>
        /// request. When the results of a <code>DescribeJobDefinitions</code> request exceed
        /// <code>maxResults</code>, this value can be used to retrieve the next page of results.
        /// This value is <code>null</code> when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}