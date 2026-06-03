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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobSchemaVersions operation.
    /// Lists available configuration schema versions for a specified job category. Use the
    /// schema versions with <c>DescribeJobSchemaVersion</c> to retrieve the full schema document.
    /// 
    ///  
    /// <para>
    /// The following operations are related to <c>ListJobSchemaVersions</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DescribeJobSchemaVersion</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateJob</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListJobSchemaVersionsRequest : AmazonSageMakerRequest
    {
        private JobCategory _jobCategory;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobCategory. 
        /// <para>
        /// The category of job schemas to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobCategory JobCategory
        {
            get { return this._jobCategory; }
            set { this._jobCategory = value; }
        }

        // Check to see if JobCategory property is set
        internal bool IsSetJobCategory()
        {
            return this._jobCategory != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of schema versions to return in the response. The default value
        /// is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// If the previous response was truncated, this token retrieves the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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