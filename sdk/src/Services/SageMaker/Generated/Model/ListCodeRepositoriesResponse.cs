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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListCodeRepositories operation.
    /// </summary>
    public partial class ListCodeRepositoriesResponse : AmazonWebServiceResponse
    {
        private List<CodeRepositorySummary> _codeRepositorySummaryList = new List<CodeRepositorySummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CodeRepositorySummaryList. 
        /// <para>
        /// Gets a list of summaries of the git repositories. Each summary specifies the following
        /// values for the repository: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creation time
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Last modified time
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configuration information, including the URL location of the repository and the ARN
        /// of the AWS Secrets Manager secret that contains the credentials used to access the
        /// repository.
        /// </para>
        ///  </li> <li>  </li> </ul>
        /// </summary>
        public List<CodeRepositorySummary> CodeRepositorySummaryList
        {
            get { return this._codeRepositorySummaryList; }
            set { this._codeRepositorySummaryList = value; }
        }

        // Check to see if CodeRepositorySummaryList property is set
        internal bool IsSetCodeRepositorySummaryList()
        {
            return this._codeRepositorySummaryList != null && this._codeRepositorySummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of a <code>ListCodeRepositoriesOutput</code> request was truncated,
        /// the response includes a <code>NextToken</code>. To get the next set of git repositories,
        /// use the token in the next request.
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