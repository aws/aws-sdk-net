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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Detailed health information about the Amazon EC2 instances in an AWS Elastic Beanstalk
    /// environment.
    /// </summary>
    public partial class DescribeInstancesHealthResponse : AmazonWebServiceResponse
    {
        private List<SingleInstanceHealth> _instanceHealthList = AWSConfigs.InitializeCollections ? new List<SingleInstanceHealth>() : null;
        private string _nextToken;
        private DateTime? _refreshedAt;

        /// <summary>
        /// Gets and sets the property InstanceHealthList. 
        /// <para>
        /// Detailed health information about each instance.
        /// </para>
        ///  
        /// <para>
        /// The output differs slightly between Linux and Windows environments. There is a difference
        /// in the members that are supported under the <c>&lt;CPUUtilization&gt;</c> type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SingleInstanceHealth> InstanceHealthList
        {
            get { return this._instanceHealthList; }
            set { this._instanceHealthList = value; }
        }

        // Check to see if InstanceHealthList property is set
        internal bool IsSetInstanceHealthList()
        {
            return this._instanceHealthList != null && (this._instanceHealthList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token for the next page of results, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property RefreshedAt. 
        /// <para>
        /// The date and time that the health information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? RefreshedAt
        {
            get { return this._refreshedAt; }
            set { this._refreshedAt = value; }
        }

        // Check to see if RefreshedAt property is set
        internal bool IsSetRefreshedAt()
        {
            return this._refreshedAt.HasValue; 
        }

    }
}