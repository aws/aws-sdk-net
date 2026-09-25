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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// The conditions for a routing rule. All specified fields must match for the rule to
    /// apply (AND logic). At least one condition field must be set.
    /// </summary>
    public partial class RuleCondition
    {
        /// <summary>
        /// Gets and sets the property HostHeader. 
        /// <para>
        /// The exact host header value to match.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string HostHeader { get; set; }

        /// <summary>
        /// Checks to see if the HostHeader property is set.
        /// </summary>
        internal bool IsSetHostHeader() => this.HostHeader != null;

        /// <summary>
        /// Gets and sets the property HostHeaderWildcard. 
        /// <para>
        /// A wildcard pattern for host header matching (for example, <c>*.example.com</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string HostHeaderWildcard { get; set; }

        /// <summary>
        /// Checks to see if the HostHeaderWildcard property is set.
        /// </summary>
        internal bool IsSetHostHeaderWildcard() => this.HostHeaderWildcard != null;

        /// <summary>
        /// Gets and sets the property PathExact. 
        /// <para>
        /// The exact path to match. Must start with <c>/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PathExact { get; set; }

        /// <summary>
        /// Checks to see if the PathExact property is set.
        /// </summary>
        internal bool IsSetPathExact() => this.PathExact != null;

        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        /// The path prefix to match. The request path must start with this value. Must start
        /// with <c>/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// Checks to see if the PathPrefix property is set.
        /// </summary>
        internal bool IsSetPathPrefix() => this.PathPrefix != null;

        /// <summary>
        /// Gets and sets the property QueryStringEquals. 
        /// <para>
        /// A query string key-value pair that must be present and match exactly.
        /// </para>
        /// </summary>
        public QueryStringKeyValuePair QueryStringEquals { get; set; }

        /// <summary>
        /// Checks to see if the QueryStringEquals property is set.
        /// </summary>
        internal bool IsSetQueryStringEquals() => this.QueryStringEquals != null;

        /// <summary>
        /// Gets and sets the property QueryStringExists. 
        /// <para>
        /// A query string key that must be present in the request (any value is accepted).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QueryStringExists { get; set; }

        /// <summary>
        /// Checks to see if the QueryStringExists property is set.
        /// </summary>
        internal bool IsSetQueryStringExists() => this.QueryStringExists != null;
    }
}
