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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a query string condition.
    /// 
    ///  
    /// <para>
    /// The query string component of a URI starts after the first '?' character and is terminated
    /// by either a '#' character or the end of the URI. A typical query string contains key/value
    /// pairs separated by '&amp;' characters. The allowed characters are specified by RFC
    /// 3986. Any character can be percentage encoded.
    /// </para>
    /// </summary>
    public partial class QueryStringConditionConfig
    {
        private List<QueryStringKeyValuePair> _values = AWSConfigs.InitializeCollections ? new List<QueryStringKeyValuePair>() : null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The key/value pairs or values to find in the query string. The maximum size of each
        /// string is 128 characters. The comparison is case insensitive. The following wildcard
        /// characters are supported: * (matches 0 or more characters) and ? (matches exactly
        /// 1 character). To search for a literal '*' or '?' character in a query string, you
        /// must escape these characters in <c>Values</c> using a '\' character.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple key/value pairs or values, the condition is satisfied if one
        /// of them is found in the query string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryStringKeyValuePair> Values
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