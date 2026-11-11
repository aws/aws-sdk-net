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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation. List the tags for
    /// Config resource.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of tags returned on each page. The limit maximum is 50. You cannot
        /// specify a number greater than 50. If you specify 0, Config uses the default. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the resource for which to list the
        /// tags. The following resources are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConfigurationRecorder</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfigRule</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OrganizationConfigRule</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConformancePack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OrganizationConformancePack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfigurationAggregator</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AggregationAuthorization</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StoredQuery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Connector</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
