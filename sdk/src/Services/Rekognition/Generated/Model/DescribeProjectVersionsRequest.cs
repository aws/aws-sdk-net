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
    /// Container for the parameters to the DescribeProjectVersions operation.
    /// Lists and describes the versions of a model in an Amazon Rekognition Custom Labels
    /// project. You can specify up to 10 model versions in <code>ProjectVersionArns</code>.
    /// If you don't specify a value, descriptions for all model versions in the project are
    /// returned.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DescribeProjectVersions</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeProjectVersionsRequest : AmazonRekognitionRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _projectArn;
        private List<string> _versionNames = new List<string>();

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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project that contains the models you want to
        /// describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNames. 
        /// <para>
        /// A list of model version names that you want to describe. You can add up to 10 model
        /// version names to the list. If you don't specify a value, all model descriptions are
        /// returned. A version name is part of a model (ProjectVersion) ARN. For example, <code>my-model.2020-01-21T09.10.15</code>
        /// is the version name in the following ARN. <code>arn:aws:rekognition:us-east-1:123456789012:project/getting-started/version/<i>my-model.2020-01-21T09.10.15</i>/1234567890123</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> VersionNames
        {
            get { return this._versionNames; }
            set { this._versionNames = value; }
        }

        // Check to see if VersionNames property is set
        internal bool IsSetVersionNames()
        {
            return this._versionNames != null && this._versionNames.Count > 0; 
        }

    }
}