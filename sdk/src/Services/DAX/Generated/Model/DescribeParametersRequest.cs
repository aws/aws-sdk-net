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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeParameters operation.
    /// Returns the detailed parameter list for a particular parameter group.
    /// </summary>
    public partial class DescribeParametersRequest : AmazonDAXRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _parameterGroupName;
        private string _source;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the specified <c>MaxResults</c> value, a token is included in the response so that
        /// the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// The value for <c>MaxResults</c> must be between 20 and 100.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by <c>MaxResults</c>.
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

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// How the parameter is defined. For example, <c>system</c> denotes a system-defined
        /// parameter.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}