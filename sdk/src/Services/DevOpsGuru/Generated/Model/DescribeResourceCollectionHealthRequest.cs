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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeResourceCollectionHealth operation.
    /// Returns the number of open proactive insights, open reactive insights, and the Mean
    /// Time to Recover (MTTR) for all closed insights in resource collections in your account.
    /// You specify the type of AWS resources collection. The one type of AWS resource collection
    /// supported is AWS CloudFormation stacks. DevOps Guru can be configured to analyze only
    /// the AWS resources that are defined in the stacks.
    /// </summary>
    public partial class DescribeResourceCollectionHealthRequest : AmazonDevOpsGuruRequest
    {
        private string _nextToken;
        private ResourceCollectionType _resourceCollectionType;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property ResourceCollectionType. 
        /// <para>
        ///  An AWS resource collection type. This type specifies how analyzed AWS resources are
        /// defined. The one type of AWS resource collection supported is AWS CloudFormation stacks.
        /// DevOps Guru can be configured to analyze only the AWS resources that are defined in
        /// the stacks. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceCollectionType ResourceCollectionType
        {
            get { return this._resourceCollectionType; }
            set { this._resourceCollectionType = value; }
        }

        // Check to see if ResourceCollectionType property is set
        internal bool IsSetResourceCollectionType()
        {
            return this._resourceCollectionType != null;
        }

    }
}