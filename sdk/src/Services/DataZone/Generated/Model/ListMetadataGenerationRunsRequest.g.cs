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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetadataGenerationRuns operation. Lists all
    /// metadata generation runs. <para> Metadata generation runs represent automated processes
    /// that leverage AI/ML capabilities to create or enhance asset metadata at scale. This
    /// feature helps organizations maintain comprehensive and consistent metadata across
    /// large numbers of assets without manual intervention. It can automatically generate
    /// business descriptions, tags, and other metadata elements, significantly reducing the
    /// time and effort required for metadata management while improving consistency and completeness.
    /// </para> <para> Prerequisites: </para> <ul> <li> <para> Valid domain identifier. </para>
    /// </li> <li> <para> User must have access to metadata generation runs in the domain.
    /// </para> </li> </ul>
    /// </summary>
    public partial class ListMetadataGenerationRunsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain where you want to list metadata generation runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of metadata generation runs to return in a single call to ListMetadataGenerationRuns.
        /// When the number of metadata generation runs to be listed is greater than the value
        /// of MaxResults, the response contains a NextToken value that you can use in a subsequent
        /// call to ListMetadataGenerationRuns to list the next set of revisions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of metadata generation runs is greater than the default value for
        /// the MaxResults parameter, or if you explicitly specify a value for MaxResults that
        /// is less than the number of metadata generation runs, the response includes a pagination
        /// token named NextToken. You can specify this NextToken value in a subsequent call to
        /// ListMetadataGenerationRuns to list the next set of revisions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the metadata generation runs.
        /// </para>
        /// </summary>
        public MetadataGenerationRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The target ID for which you want to list metadata generation runs.
        /// </para>
        /// </summary>
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metadata generation runs.
        /// </para>
        /// </summary>
        public MetadataGenerationRunType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
