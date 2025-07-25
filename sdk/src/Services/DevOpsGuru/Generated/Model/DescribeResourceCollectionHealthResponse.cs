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
    /// This is the response object from the DescribeResourceCollectionHealth operation.
    /// </summary>
    public partial class DescribeResourceCollectionHealthResponse : AmazonWebServiceResponse
    {
        private List<CloudFormationHealth> _cloudFormation = AWSConfigs.InitializeCollections ? new List<CloudFormationHealth>() : null;
        private string _nextToken;
        private List<ServiceHealth> _service = AWSConfigs.InitializeCollections ? new List<ServiceHealth>() : null;
        private List<TagHealth> _tags = AWSConfigs.InitializeCollections ? new List<TagHealth>() : null;

        /// <summary>
        /// Gets and sets the property CloudFormation. 
        /// <para>
        ///  The returned <c>CloudFormationHealthOverview</c> object that contains an <c>InsightHealthOverview</c>
        /// object with the requested system health information. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudFormationHealth> CloudFormation
        {
            get { return this._cloudFormation; }
            set { this._cloudFormation = value; }
        }

        // Check to see if CloudFormation property is set
        internal bool IsSetCloudFormation()
        {
            return this._cloudFormation != null && (this._cloudFormation.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
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
        /// Gets and sets the property Service. 
        /// <para>
        /// An array of <c>ServiceHealth</c> objects that describes the health of the Amazon Web
        /// Services services associated with the resources in the collection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceHealth> Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null && (this._service.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Amazon Web Services tags that are used by resources in the resource collection.
        /// </para>
        ///  
        /// <para>
        /// Tags help you identify and organize your Amazon Web Services resources. Many Amazon
        /// Web Services services support tagging, so you can assign the same tag to resources
        /// from different services to indicate that the resources are related. For example, you
        /// can assign the same tag to an Amazon DynamoDB table resource that you assign to an
        /// Lambda function. For more information about using tags, see the <a href="https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/tagging-best-practices.html">Tagging
        /// best practices</a> whitepaper. 
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Web Services tag has two parts. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A tag <i>key</i> (for example, <c>CostCenter</c>, <c>Environment</c>, <c>Project</c>,
        /// or <c>Secret</c>). Tag <i>keys</i> are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An optional field known as a tag <i>value</i> (for example, <c>111122223333</c>, <c>Production</c>,
        /// or a team name). Omitting the tag <i>value</i> is the same as using an empty string.
        /// Like tag <i>keys</i>, tag <i>values</i> are case-sensitive.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Together these are known as <i>key</i>-<i>value</i> pairs.
        /// </para>
        ///  <important> 
        /// <para>
        /// The string used for a <i>key</i> in a tag that you use to define your resource coverage
        /// must begin with the prefix <c>Devops-guru-</c>. The tag <i>key</i> might be <c>DevOps-Guru-deployment-application</c>
        /// or <c>devops-guru-rds-application</c>. When you create a <i>key</i>, the case of characters
        /// in the <i>key</i> can be whatever you choose. After you create a <i>key</i>, it is
        /// case-sensitive. For example, DevOps Guru works with a <i>key</i> named <c>devops-guru-rds</c>
        /// and a <i>key</i> named <c>DevOps-Guru-RDS</c>, and these act as two different <i>keys</i>.
        /// Possible <i>key</i>/<i>value</i> pairs in your application might be <c>Devops-Guru-production-application/RDS</c>
        /// or <c>Devops-Guru-production-application/containers</c>.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagHealth> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}