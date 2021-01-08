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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the SelectResourceConfig operation.
    /// Accepts a structured query language (SQL) <code>SELECT</code> command, performs the
    /// corresponding search, and returns resource configurations matching the properties.
    /// 
    ///  
    /// <para>
    /// For more information about query components, see the <a href="https://docs.aws.amazon.com/config/latest/developerguide/query-components.html">
    /// <b>Query Components</b> </a> section in the AWS Config Developer Guide.
    /// </para>
    /// </summary>
    public partial class SelectResourceConfigRequest : AmazonConfigServiceRequest
    {
        private string _expression;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The SQL query <code>SELECT</code> command.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of query results returned on each page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned in a previous request that you use to request
        /// the next page of results in a paginated response. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}