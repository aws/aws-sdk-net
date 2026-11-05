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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExportTasks operation. Returns information
    /// about a snapshot or cluster export to Amazon S3. This API operation supports pagination.
    /// </summary>
    public partial class DescribeExportTasksRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// The identifier of the snapshot or cluster export task to be described.
        /// </para>
        /// </summary>
        public string ExportTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExportTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetExportTaskIdentifier() => this.ExportTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters specify one or more snapshot or cluster exports to describe. The filters are
        /// specified as name-value pairs that define what to include in the output. Filter names
        /// and values are case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Supported filters include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>export-task-identifier</c> - An identifier for the snapshot or cluster export
        /// task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3-bucket</c> - The Amazon S3 bucket the data is exported to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-arn</c> - The Amazon Resource Name (ARN) of the snapshot or cluster exported
        /// to Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The status of the export task. Must be lowercase. Valid statuses
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>canceled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>canceling</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>complete</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>in_progress</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>starting</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeExportTasks</c> request.
        /// If you specify this parameter, the response includes only records beyond the marker,
        /// up to the value specified by the <c>MaxRecords</c> parameter.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified value, a pagination token called a marker is included in the response.
        /// You can use the marker in a later <c>DescribeExportTasks</c> request to retrieve the
        /// remaining results.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 100)]
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot or cluster exported to Amazon S3.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source for the export.
        /// </para>
        /// </summary>
        public ExportSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
