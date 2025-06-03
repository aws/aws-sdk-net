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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents a MatchHeaders condition.
    /// </summary>
    public partial class RoutingRuleMatchHeaders
    {
        private List<RoutingRuleMatchHeaderValue> _anyOf = AWSConfigs.InitializeCollections ? new List<RoutingRuleMatchHeaderValue>() : null;

        /// <summary>
        /// Gets and sets the property AnyOf. 
        /// <para>
        /// The header name and header value glob to be matched. The matchHeaders condition is
        /// matched if any of the header name and header value globs are matched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RoutingRuleMatchHeaderValue> AnyOf
        {
            get { return this._anyOf; }
            set { this._anyOf = value; }
        }

        // Check to see if AnyOf property is set
        internal bool IsSetAnyOf()
        {
            return this._anyOf != null && (this._anyOf.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}