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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the GetLifecyclePolicyPreview operation.
    /// </summary>
    public partial class GetLifecyclePolicyPreviewResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LifecyclePolicyText. 
        /// <para>
        /// The JSON lifecycle policy text.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 30720)]
        public string LifecyclePolicyText { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicyText property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicyText() => this.LifecyclePolicyText != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>GetLifecyclePolicyPreview</c>
        /// request. When the results of a <c>GetLifecyclePolicyPreview</c> request exceed <c>maxResults</c>,
        /// this value can be used to retrieve the next page of results. This value is <c>null</c>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PreviewResults. 
        /// <para>
        /// The results of the lifecycle policy preview request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecyclePolicyPreviewResult> PreviewResults { get; set; } = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyPreviewResult>() : null;

        /// <summary>
        /// Checks to see if the PreviewResults property is set.
        /// </summary>
        internal bool IsSetPreviewResults() => this.PreviewResults != null && (this.PreviewResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the lifecycle policy preview request.
        /// </para>
        /// </summary>
        public LifecyclePolicyPreviewStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The list of images that is returned as a result of the action.
        /// </para>
        /// </summary>
        public LifecyclePolicyPreviewSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;
    }
}
