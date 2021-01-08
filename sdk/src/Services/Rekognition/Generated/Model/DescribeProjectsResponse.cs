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
    /// This is the response object from the DescribeProjects operation.
    /// </summary>
    public partial class DescribeProjectsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProjectDescription> _projectDescriptions = new List<ProjectDescription>();

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
        /// Gets and sets the property ProjectDescriptions. 
        /// <para>
        /// A list of project descriptions. The list is sorted by the date and time the projects
        /// are created.
        /// </para>
        /// </summary>
        public List<ProjectDescription> ProjectDescriptions
        {
            get { return this._projectDescriptions; }
            set { this._projectDescriptions = value; }
        }

        // Check to see if ProjectDescriptions property is set
        internal bool IsSetProjectDescriptions()
        {
            return this._projectDescriptions != null && this._projectDescriptions.Count > 0; 
        }

    }
}