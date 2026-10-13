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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the DescribeFeaturedResultsSet operation.
    /// </summary>
    public partial class DescribeFeaturedResultsSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix timestamp when the set of the featured results was created.
        /// </para>
        /// </summary>
        public long? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FeaturedDocumentsMissing. 
        /// <para>
        /// The list of document IDs that don't exist but you have specified as featured documents.
        /// Amazon Kendra cannot feature these documents if they don't exist in the index. You
        /// can check the status of a document and its ID or check for documents with status errors
        /// using the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchGetDocumentStatus.html">BatchGetDocumentStatus</a>
        /// API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FeaturedDocumentMissing> FeaturedDocumentsMissing { get; set; } = AWSConfigs.InitializeCollections ? new List<FeaturedDocumentMissing>() : null;

        /// <summary>
        /// Checks to see if the FeaturedDocumentsMissing property is set.
        /// </summary>
        internal bool IsSetFeaturedDocumentsMissing() => this.FeaturedDocumentsMissing != null && (this.FeaturedDocumentsMissing.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeaturedDocumentsWithMetadata. 
        /// <para>
        /// The list of document IDs for the documents you want to feature with their metadata
        /// information. For more information on the list of featured documents, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_FeaturedResultsSet.html">FeaturedResultsSet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FeaturedDocumentWithMetadata> FeaturedDocumentsWithMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<FeaturedDocumentWithMetadata>() : null;

        /// <summary>
        /// Checks to see if the FeaturedDocumentsWithMetadata property is set.
        /// </summary>
        internal bool IsSetFeaturedDocumentsWithMetadata() => this.FeaturedDocumentsWithMetadata != null && (this.FeaturedDocumentsWithMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetId. 
        /// <para>
        /// The identifier of the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string FeaturedResultsSetId { get; set; }

        /// <summary>
        /// Checks to see if the FeaturedResultsSetId property is set.
        /// </summary>
        internal bool IsSetFeaturedResultsSetId() => this.FeaturedResultsSetId != null;

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetName. 
        /// <para>
        /// The name for the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string FeaturedResultsSetName { get; set; }

        /// <summary>
        /// Checks to see if the FeaturedResultsSetName property is set.
        /// </summary>
        internal bool IsSetFeaturedResultsSetName() => this.FeaturedResultsSetName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp when the set of featured results was last updated.
        /// </para>
        /// </summary>
        public long? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property QueryTexts. 
        /// <para>
        /// The list of queries for featuring results. For more information on the list of queries,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_FeaturedResultsSet.html">FeaturedResultsSet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 49)]
        public List<string> QueryTexts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryTexts property is set.
        /// </summary>
        internal bool IsSetQueryTexts() => this.QueryTexts != null && (this.QueryTexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the set of featured results. When the value is <c>ACTIVE</c>,
        /// featured results are ready for use. You can still configure your settings before setting
        /// the status to <c>ACTIVE</c>. You can set the status to <c>ACTIVE</c> or <c>INACTIVE</c>
        /// using the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateFeaturedResultsSet.html">UpdateFeaturedResultsSet</a>
        /// API. The queries you specify for featured results must be unique per featured results
        /// set for each index, whether the status is <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        public FeaturedResultsSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
