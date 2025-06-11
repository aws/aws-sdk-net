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
    /// Represents a routing rule condition.
    /// </summary>
    public partial class RoutingRuleCondition
    {
        private RoutingRuleMatchBasePaths _matchBasePaths;
        private RoutingRuleMatchHeaders _matchHeaders;

        /// <summary>
        /// Gets and sets the property MatchBasePaths. 
        /// <para>
        /// The base path to be matched.
        /// </para>
        /// </summary>
        public RoutingRuleMatchBasePaths MatchBasePaths
        {
            get { return this._matchBasePaths; }
            set { this._matchBasePaths = value; }
        }

        // Check to see if MatchBasePaths property is set
        internal bool IsSetMatchBasePaths()
        {
            return this._matchBasePaths != null;
        }

        /// <summary>
        /// Gets and sets the property MatchHeaders. 
        /// <para>
        /// The headers to be matched.
        /// </para>
        /// </summary>
        public RoutingRuleMatchHeaders MatchHeaders
        {
            get { return this._matchHeaders; }
            set { this._matchHeaders = value; }
        }

        // Check to see if MatchHeaders property is set
        internal bool IsSetMatchHeaders()
        {
            return this._matchHeaders != null;
        }

    }
}