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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeResourceCollectionHealth operation.
    /// Returns the number of open proactive insights, open reactive insights, and the Mean
    /// Time to Recover (MTTR) for all closed insights in resource collections in your account.
    /// You specify the type of Amazon Web Services resources collection. The two types of
    /// Amazon Web Services resource collections supported are Amazon Web Services CloudFormation
    /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
    /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
    /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
    /// specify up to 500 Amazon Web Services CloudFormation stacks.
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
        ///  An Amazon Web Services resource collection type. This type specifies how analyzed
        /// Amazon Web Services resources are defined. The two types of Amazon Web Services resource
        /// collections supported are Amazon Web Services CloudFormation stacks and Amazon Web
        /// Services resources that contain the same Amazon Web Services tag. DevOps Guru can
        /// be configured to analyze the Amazon Web Services resources that are defined in the
        /// stacks or that are tagged using the same tag <i>key</i>. You can specify up to 500
        /// Amazon Web Services CloudFormation stacks. 
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