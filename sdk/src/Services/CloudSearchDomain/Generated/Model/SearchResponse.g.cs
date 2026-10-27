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

namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// This is the response object from the Search operation.
    /// </summary>
    public partial class SearchResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Facets. 
        /// <para>
        /// The requested facet information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, BucketInfo> Facets { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, BucketInfo>() : null;

        /// <summary>
        /// Checks to see if the Facets property is set.
        /// </summary>
        internal bool IsSetFacets() => this.Facets != null && (this.Facets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Hits. 
        /// <para>
        /// The documents that match the search criteria.
        /// </para>
        /// </summary>
        public Hits Hits { get; set; }

        /// <summary>
        /// Checks to see if the Hits property is set.
        /// </summary>
        internal bool IsSetHits() => this.Hits != null;

        /// <summary>
        /// Gets and sets the property Stats. 
        /// <para>
        /// The requested field statistics information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FieldStats> Stats { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FieldStats>() : null;

        /// <summary>
        /// Checks to see if the Stats property is set.
        /// </summary>
        internal bool IsSetStats() => this.Stats != null && (this.Stats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status information returned for the search request.
        /// </para>
        /// </summary>
        public SearchStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
