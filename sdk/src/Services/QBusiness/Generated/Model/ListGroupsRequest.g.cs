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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroups operation. Provides a list of groups
    /// that are mapped to users.
    /// </summary>
    public partial class ListGroupsRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application for getting a list of groups mapped to users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source for getting a list of groups mapped to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for getting a list of groups mapped to users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of returned groups that are mapped to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there is more data to retrieve),
        /// Amazon Q Business returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of groups that are mapped to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property UpdatedEarlierThan. 
        /// <para>
        /// The timestamp identifier used for the latest <c>PUT</c> or <c>DELETE</c> action for
        /// mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedEarlierThan { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedEarlierThan property is set.
        /// </summary>
        internal bool IsSetUpdatedEarlierThan() => this.UpdatedEarlierThan.HasValue;
    }
}
