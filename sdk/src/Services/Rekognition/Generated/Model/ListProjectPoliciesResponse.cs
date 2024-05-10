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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the ListProjectPolicies operation.
    /// </summary>
    public partial class ListProjectPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProjectPolicy> _projectPolicies = AWSConfigs.InitializeCollections ? new List<ProjectPolicy>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition returns this token that you can use
        /// in the subsequent request to retrieve the next set of project policies.
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
        /// Gets and sets the property ProjectPolicies. 
        /// <para>
        /// A list of project policies attached to the project.
        /// </para>
        /// </summary>
        public List<ProjectPolicy> ProjectPolicies
        {
            get { return this._projectPolicies; }
            set { this._projectPolicies = value; }
        }

        // Check to see if ProjectPolicies property is set
        internal bool IsSetProjectPolicies()
        {
            return this._projectPolicies != null && (this._projectPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}