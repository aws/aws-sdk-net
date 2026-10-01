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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the ListIndexedRecoveryPoints operation. This operation
    /// returns a list of recovery points that have an associated index, belonging to the
    /// specified account. <para> Optional parameters you can include are: MaxResults; NextToken;
    /// SourceResourceArns; CreatedBefore; CreatedAfter; and ResourceType. </para>
    /// </summary>
    public partial class ListIndexedRecoveryPointsRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Returns only indexed recovery points that were created after the specified date.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Returns only indexed recovery points that were created before the specified date.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// Include this parameter to filter the returned list by the indicated statuses.
        /// </para>
        ///  
        /// <para>
        /// Accepted values: <c>PENDING</c> | <c>ACTIVE</c> | <c>FAILED</c> | <c>DELETING</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A recovery point with an index that has the status of <c>ACTIVE</c> can be included
        /// in a search.
        /// </para>
        /// </summary>
        public IndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of resource list items to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned recovery points.
        /// </para>
        ///  
        /// <para>
        /// For example, if a request is made to return <c>MaxResults</c> number of indexed recovery
        /// points, <c>NextToken</c> allows you to return more items in your list starting at
        /// the location pointed to by the next token.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Returns a list of indexed recovery points for the specified resource type(s).
        /// </para>
        ///  
        /// <para>
        /// Accepted values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EBS</c> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> for Amazon Simple Storage Service (Amazon S3)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// A string of the Amazon Resource Name (ARN) that uniquely identifies the source resource.
        /// </para>
        /// </summary>
        public string SourceResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceArn property is set.
        /// </summary>
        internal bool IsSetSourceResourceArn() => this.SourceResourceArn != null;
    }
}
