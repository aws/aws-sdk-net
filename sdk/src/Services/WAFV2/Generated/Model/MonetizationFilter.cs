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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A filter for narrowing monetization statistics and settlement record results. Specify
    /// a filter name and one or more values to match.
    /// 
    ///  
    /// <para>
    /// Filter behavior:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Multiple values within one filter: OR (match any)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Multiple filters: AND (all must match)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// No duplicate filter names allowed (rejected with error)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Duplicate values within a filter are silently deduplicated
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If no <c>CurrencyMode</c> filter is specified, defaults to <c>REAL</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MonetizationFilter
    {
        private string _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The filter name. Format: Key is a string, Value is a list of strings.
        /// </para>
        ///  
        /// <para>
        /// Enum-restricted (invalid values rejected):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CurrencyMode</c>: <c>REAL</c>, <c>TEST</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ChainName</c>: <c>BASE</c>, <c>SOLANA</c>, <c>BASE_SEPOLIA</c>, <c>SOLANA_DEVNET</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SettlementStatus</c>: <c>SETTLED</c>, <c>PENDING</c>, <c>FAILED</c>, <c>SERVICE_ERROR</c>,
        /// <c>SKIPPED_ORIGIN_ERROR</c>, <c>DUPLICATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HttpSourceName</c>: <c>CF</c>, <c>ALB</c>, <c>APIGW</c>, <c>APPRUNNER</c>, <c>COGNITO</c>,
        /// <c>VERIFIED_ACCESS</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// ARN-validated:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>WebACLArn</c>: valid WAFv2 web ACL ARN
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Free-text (any string up to 256 chars):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SourceName</c>: The name of the bot. Populated from Bot Control verified bot labels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceCategory</c>: The category classification of the bot. From Bot Control categorization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Intent</c>: The declared intent of the bot request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Organization</c>: The organization operating the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UriPathPrefix</c>: The URI path of the request that was monetized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RequestId</c>: The WAF request ID associated with the transaction. Matches the
        /// requestId in WAF logs. Pattern: <c>^[a-zA-Z0-9:._\-=+/]+$</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TransactionId</c>: The blockchain transaction identifier. Pattern: <c>^[a-zA-Z0-9:._\-=+/]+$</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TerminatingRuleName</c>: The name of the WAF rule that triggered the Monetize
        /// action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PayerAddress</c>: The blockchain wallet address of the paying client. Pattern:
        /// <c>^[a-zA-Z0-9:._\-=+/]+$</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HttpSourceId</c>: The identifier of the Amazon Web Services resource associated
        /// with the web ACL (for example, CloudFront distribution ID).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values to filter on. Specify as a list of strings. Results match any of the specified
        /// values (OR logic). Duplicate values are silently deduplicated. Maximum: 20 values
        /// per filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}