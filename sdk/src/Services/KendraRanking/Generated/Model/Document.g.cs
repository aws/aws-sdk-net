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

namespace Amazon.KendraRanking.Model
{
    /// <summary>
    /// Information about a document from a search service such as OpenSearch (self managed).
    /// Amazon Kendra Intelligent Ranking uses this information to rank and score on.
    /// </summary>
    public partial class Document
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body text of the search service's document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The optional group identifier of the document from the search service. Documents with
        /// the same group identifier are grouped together and processed as one document within
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the document from the search service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OriginalScore. 
        /// <para>
        /// The original document score or rank from the search service. Amazon Kendra Intelligent
        /// Ranking gives the document a new score or rank based on its intelligent search algorithms.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -100000, Max = 100000)]
        public float? OriginalScore { get; set; }

        /// <summary>
        /// Checks to see if the OriginalScore property is set.
        /// </summary>
        internal bool IsSetOriginalScore() => this.OriginalScore.HasValue;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the search service's document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property TokenizedBody. 
        /// <para>
        /// The body text of the search service's document represented as a list of tokens or
        /// words. You must choose to provide <c>Body</c> or <c>TokenizedBody</c>. You cannot
        /// provide both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> TokenizedBody { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenizedBody property is set.
        /// </summary>
        internal bool IsSetTokenizedBody() => this.TokenizedBody != null && (this.TokenizedBody.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenizedTitle. 
        /// <para>
        /// The title of the search service's document represented as a list of tokens or words.
        /// You must choose to provide <c>Title</c> or <c>TokenizedTitle</c>. You cannot provide
        /// both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> TokenizedTitle { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenizedTitle property is set.
        /// </summary>
        internal bool IsSetTokenizedTitle() => this.TokenizedTitle != null && (this.TokenizedTitle.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
