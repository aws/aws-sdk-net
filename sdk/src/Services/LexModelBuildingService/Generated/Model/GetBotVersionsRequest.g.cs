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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetBotVersions operation. Gets information about
    /// all of the versions of a bot. <para> The <c>GetBotVersions</c> operation returns a
    /// <c>BotMetadata</c> object for each version of a bot. For example, if a bot has three
    /// numbered versions, the <c>GetBotVersions</c> operation returns four <c>BotMetadata</c>
    /// objects in the response, one for each numbered version and one for the <c>$LATEST</c>
    /// version. </para> <para> The <c>GetBotVersions</c> operation always returns at least
    /// one version, the <c>$LATEST</c> version. </para> <para> This operation requires permissions
    /// for the <c>lex:GetBotVersions</c> action. </para>
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetBotVersionsRequest : AmazonLexModelBuildingServiceRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of bot versions to return in the response. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot for which versions should be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for fetching the next page of bot versions. If the response to
        /// this call is truncated, Amazon Lex returns a pagination token in the response. To
        /// fetch the next page of versions, specify the pagination token in the next request.
        /// 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
