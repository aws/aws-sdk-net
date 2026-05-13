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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
    /// Conditions bag for a routing rule. All non-null fields must match (AND logic). At
    /// least one field must be set (enforced by CP).
    /// </summary>
    public partial class RuleCondition
    {
        private string _hostHeader;
        private string _hostHeaderWildcard;
        private string _pathExact;
        private string _pathPrefix;
        private QueryStringKeyValuePair _queryStringEquals;
        private string _queryStringExists;

        /// <summary>
        /// Gets and sets the property HostHeader. 
        /// <para>
        /// Exact host match — RFC 3986 unreserved characters
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string HostHeader
        {
            get { return this._hostHeader; }
            set { this._hostHeader = value; }
        }

        // Check to see if HostHeader property is set
        internal bool IsSetHostHeader()
        {
            return this._hostHeader != null;
        }

        /// <summary>
        /// Gets and sets the property HostHeaderWildcard. 
        /// <para>
        /// Wildcard host pattern (e.g., *.example.com) — RFC 3986 unreserved plus *
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string HostHeaderWildcard
        {
            get { return this._hostHeaderWildcard; }
            set { this._hostHeaderWildcard = value; }
        }

        // Check to see if HostHeaderWildcard property is set
        internal bool IsSetHostHeaderWildcard()
        {
            return this._hostHeaderWildcard != null;
        }

        /// <summary>
        /// Gets and sets the property PathExact. 
        /// <para>
        /// Exact path match — must start with /; RFC 3986 unreserved plus /
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PathExact
        {
            get { return this._pathExact; }
            set { this._pathExact = value; }
        }

        // Check to see if PathExact property is set
        internal bool IsSetPathExact()
        {
            return this._pathExact != null;
        }

        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        /// Path prefix matching — strict starts-with, no wildcard (preferred for new rules).
        /// Must start with /; RFC 3986 unreserved plus /
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PathPrefix
        {
            get { return this._pathPrefix; }
            set { this._pathPrefix = value; }
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this._pathPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStringEquals. 
        /// <para>
        /// Query string key=value pair match (single pair)
        /// </para>
        /// </summary>
        public QueryStringKeyValuePair QueryStringEquals
        {
            get { return this._queryStringEquals; }
            set { this._queryStringEquals = value; }
        }

        // Check to see if QueryStringEquals property is set
        internal bool IsSetQueryStringEquals()
        {
            return this._queryStringEquals != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStringExists. 
        /// <para>
        /// Query string key presence check (any value accepted) — RFC 3986 unreserved characters
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QueryStringExists
        {
            get { return this._queryStringExists; }
            set { this._queryStringExists = value; }
        }

        // Check to see if QueryStringExists property is set
        internal bool IsSetQueryStringExists()
        {
            return this._queryStringExists != null;
        }

    }
}