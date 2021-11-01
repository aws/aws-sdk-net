/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProjects operation.
    /// Gets information about your Amazon Rekognition Custom Labels projects. 
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DescribeProjects</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeProjectsRequest : AmazonRekognitionRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _projectNames = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per paginated call. The largest value you
        /// can specify is 100. If you specify a value greater than 100, a ValidationException
        /// error occurs. The default value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there is more results to retrieve),
        /// Amazon Rekognition Custom Labels returns a pagination token in the response. You can
        /// use this pagination token to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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

        /// <summary>
        /// Gets and sets the property ProjectNames. 
        /// <para>
        /// A list of the projects that you want Amazon Rekognition Custom Labels to describe.
        /// If you don't specify a value, the response includes descriptions for all the projects
        /// in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ProjectNames
        {
            get { return this._projectNames; }
            set { this._projectNames = value; }
        }

        // Check to see if ProjectNames property is set
        internal bool IsSetProjectNames()
        {
            return this._projectNames != null && this._projectNames.Count > 0; 
        }

    }
}