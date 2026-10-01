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
    /// Container for the parameters to the GetIntents operation. Returns intent information
    /// as follows: <ul> <li> <para> If you specify the <c>nameContains</c> field, returns
    /// the <c>$LATEST</c> version of all intents that contain the specified string. </para>
    /// </li> <li> <para> If you don't specify the <c>nameContains</c> field, returns information
    /// about the <c>$LATEST</c> version of all intents. </para> </li> </ul> <para> The operation
    /// requires permission for the <c>lex:GetIntents</c> action. </para>
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetIntentsRequest : AmazonLexModelBuildingServiceRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of intents to return in the response. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Substring to match in intent names. An intent will be returned if any part of its
        /// name matches the substring. For example, "xyz" matches both "xyzabc" and "abcxyz."
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of intents. If the response to this
        /// API call is truncated, Amazon Lex returns a pagination token in the response. To fetch
        /// the next page of intents, specify the pagination token in the next request. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
