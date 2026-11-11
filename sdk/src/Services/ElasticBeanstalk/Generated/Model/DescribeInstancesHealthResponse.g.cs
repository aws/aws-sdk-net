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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the DescribeInstancesHealth operation.
    /// </summary>
    public partial class DescribeInstancesHealthResponse : AmazonWebServiceResponse
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SingleInstanceHealth> InstanceHealthList { get; set; } = AWSConfigs.InitializeCollections ? new List<SingleInstanceHealth>() : null;

        /// <summary>
        /// Checks to see if the InstanceHealthList property is set.
        /// </summary>
        internal bool IsSetInstanceHealthList() => this.InstanceHealthList != null && (this.InstanceHealthList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token for the next page of results, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RefreshedAt. 
        /// <para>
        /// The date and time that the health information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? RefreshedAt { get; set; }

        /// <summary>
        /// Checks to see if the RefreshedAt property is set.
        /// </summary>
        internal bool IsSetRefreshedAt() => this.RefreshedAt.HasValue;
    }
}
