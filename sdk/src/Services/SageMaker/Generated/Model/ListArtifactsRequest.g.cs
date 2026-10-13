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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListArtifacts operation. Lists the artifacts in
    /// your account and their properties.
    /// </summary>
    public partial class ListArtifactsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// A filter that returns only artifacts of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactType property is set.
        /// </summary>
        internal bool IsSetArtifactType() => this.ArtifactType != null;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// A filter that returns only artifacts created on or after the specified time.
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
        /// A filter that returns only artifacts created on or before the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of artifacts to return in the response. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous call to <c>ListArtifacts</c> didn't return the full set of artifacts,
        /// the call returns a token for getting the next set of artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The property used to sort results. The default value is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public SortArtifactsBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order. The default value is <c>Descending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property SourceUri. 
        /// <para>
        /// A filter that returns only artifacts with the specified source URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SourceUri { get; set; }

        /// <summary>
        /// Checks to see if the SourceUri property is set.
        /// </summary>
        internal bool IsSetSourceUri() => this.SourceUri != null;
    }
}
