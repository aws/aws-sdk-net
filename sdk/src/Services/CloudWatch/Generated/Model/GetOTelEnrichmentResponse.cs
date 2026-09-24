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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the GetOTelEnrichment operation.
    /// </summary>
    public partial class GetOTelEnrichmentResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private List<OTelEnrichmentMetricSelector> _excludeFilters = AWSConfigs.InitializeCollections ? new List<OTelEnrichmentMetricSelector>() : null;
        private List<OTelEnrichmentMetricSelector> _includeFilters = AWSConfigs.InitializeCollections ? new List<OTelEnrichmentMetricSelector>() : null;
        private OTelEnrichmentStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that enrichment started for the account. This parameter is omitted
        /// when enrichment is stopped.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeFilters. 
        /// <para>
        /// The metric namespaces, and the metric names, that are left unenriched. This parameter
        /// is omitted when enrichment is stopped, and when enrichment is running with no exclude
        /// filters, which means that nothing is excluded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<OTelEnrichmentMetricSelector> ExcludeFilters
        {
            get { return this._excludeFilters; }
            set { this._excludeFilters = value; }
        }

        // Check to see if ExcludeFilters property is set
        internal bool IsSetExcludeFilters()
        {
            return this._excludeFilters != null && (this._excludeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeFilters. 
        /// <para>
        /// The metric namespaces, and the metric names, that are enriched. This parameter is
        /// omitted when enrichment is stopped, and when enrichment is running with no include
        /// filters, which means that every supported namespace is in scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<OTelEnrichmentMetricSelector> IncludeFilters
        {
            get { return this._includeFilters; }
            set { this._includeFilters = value; }
        }

        // Check to see if IncludeFilters property is set
        internal bool IsSetIncludeFilters()
        {
            return this._includeFilters != null && (this._includeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of OTel enrichment for the account. Valid values are <c>Running</c> (enrichment
        /// is enabled) and <c>Stopped</c> (enrichment is disabled).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OTelEnrichmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the enrichment configuration for the account was last stored.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}