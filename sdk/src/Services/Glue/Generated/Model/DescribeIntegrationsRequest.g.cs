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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeIntegrations operation. The API is used
    /// to retrieve a list of integrations.
    /// </summary>
    public partial class DescribeIntegrationsRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of key and values, to filter down the results. Supported keys are "Status",
        /// "IntegrationName", and "SourceArn". IntegrationName is limited to only one value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegrationFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegrationFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegrationIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IntegrationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationIdentifier property is set.
        /// </summary>
        internal bool IsSetIntegrationIdentifier() => this.IntegrationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The total number of items to return in the output.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;
    }
}
