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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingStatistics operation. Retrieves (queries)
    /// aggregated statistical data about findings.
    /// </summary>
    public partial class GetFindingStatisticsRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// The criteria to use to filter the query results.
        /// </para>
        /// </summary>
        public FindingCriteria FindingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FindingCriteria property is set.
        /// </summary>
        internal bool IsSetFindingCriteria() => this.FindingCriteria != null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The finding property to use to group the query results. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// classificationDetails.jobId - The unique identifier for the classification job that
        /// produced the finding.
        /// </para>
        /// </li> <li>
        /// <para>
        /// resourcesAffected.s3Bucket.name - The name of the S3 bucket that the finding applies
        /// to.
        /// </para>
        /// </li> <li>
        /// <para>
        /// severity.description - The severity level of the finding, such as High or Medium.
        /// </para>
        /// </li> <li>
        /// <para>
        /// type - The type of finding, such as Policy:IAMUser/S3BucketPublic and SensitiveData:S3Object/Personal.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public GroupBy GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The maximum number of items to include in each page of the response.
        /// </para>
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The criteria to use to sort the query results.
        /// </para>
        /// </summary>
        public FindingStatisticsSortCriteria SortCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SortCriteria property is set.
        /// </summary>
        internal bool IsSetSortCriteria() => this.SortCriteria != null;
    }
}
