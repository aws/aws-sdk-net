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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the ListExports operation.
    /// </summary>
    public partial class ListExportsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier assigned to the bot by Amazon Lex.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property ExportSummaries. 
        /// <para>
        /// Summary information for the exports that meet the filter criteria specified in the
        /// request. The length of the list is specified in the <c>maxResults</c> parameter. If
        /// there are more exports available, the <c>nextToken</c> field contains a token to get
        /// the next page of results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExportSummary> ExportSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ExportSummary>() : null;

        /// <summary>
        /// Checks to see if the ExportSummaries property is set.
        /// </summary>
        internal bool IsSetExportSummaries() => this.ExportSummaries != null && (this.ExportSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale specified in the request.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more results to return in a response to the
        /// <c>ListExports</c> operation. If the <c>nextToken</c> field is present, you send the
        /// contents as the <c>nextToken</c> parameter of a <c>ListExports</c> operation request
        /// to get the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
