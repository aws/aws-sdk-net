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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMetadataModelConversions operation. Returns
    /// a paginated list of metadata model conversion requests for a migration project, initiated
    /// by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartMetadataModelConversion.html">StartMetadataModelConversion</a>.
    /// <para> To cancel a queued or in-progress request, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CancelMetadataModelConversion.html">CancelMetadataModelConversion</a>.
    /// </para> <para> <b>Required permissions:</b> <c>dms:ListMetadataModelConversions</c>.
    /// For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>. </para>
    /// </summary>
    public partial class DescribeMetadataModelConversionsRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to the metadata model conversion requests.
        /// </para>
        ///  
        /// <para>
        /// The following filter names are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>request-id</c> – The request identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> – The request status. Valid values: <c>RECEIVED</c>, <c>IN_PROGRESS</c>,
        /// <c>SUCCESS</c>, <c>FAILED</c>, <c>CANCELING</c>, <c>CANCELED</c>.
        /// </para>
        ///  </li> </ul>
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
        /// Specifies the unique pagination token that makes it possible to display the next page
        /// of results. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>Marker</c> is returned by a previous response, there are more results available.
        /// The value of <c>Marker</c> is a unique pagination token for each page. To retrieve
        /// the next page, make the call again using the returned token and keeping all other
        /// arguments unchanged.
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
        /// the specified <c>MaxRecords</c> value, DMS includes a pagination token in the response
        /// so that you can retrieve the remaining results.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationProjectIdentifier. 
        /// <para>
        /// The migration project name or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string MigrationProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MigrationProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetMigrationProjectIdentifier() => this.MigrationProjectIdentifier != null;
    }
}
