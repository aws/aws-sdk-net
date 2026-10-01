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
    /// Container for the parameters to the GetBuiltinSlotTypes operation. Gets a list of
    /// built-in slot types that meet the specified criteria. <para> For a list of built-in
    /// slot types, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference">Slot
    /// Type Reference</a> in the <i>Alexa Skills Kit</i>. </para> <para> This operation requires
    /// permission for the <c>lex:GetBuiltInSlotTypes</c> action. </para>
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetBuiltinSlotTypesRequest : AmazonLexModelBuildingServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// A list of locales that the slot type supports.
        /// </para>
        /// </summary>
        public Locale Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of slot types to return in the response. The default is 10.
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
        /// A pagination token that fetches the next page of slot types. If the response to this
        /// API call is truncated, Amazon Lex returns a pagination token in the response. To fetch
        /// the next page of slot types, specify the pagination token in the next request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SignatureContains. 
        /// <para>
        /// Substring to match in built-in slot type signatures. A slot type will be returned
        /// if any part of its signature matches the substring. For example, "xyz" matches both
        /// "xyzabc" and "abcxyz."
        /// </para>
        /// </summary>
        public string SignatureContains { get; set; }

        /// <summary>
        /// Checks to see if the SignatureContains property is set.
        /// </summary>
        internal bool IsSetSignatureContains() => this.SignatureContains != null;
    }
}
