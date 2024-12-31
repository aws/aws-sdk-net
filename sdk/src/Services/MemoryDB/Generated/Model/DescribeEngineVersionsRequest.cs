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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEngineVersions operation.
    /// Returns a list of the available Redis OSS engine versions.
    /// </summary>
    public partial class DescribeEngineVersionsRequest : AmazonMemoryDBRequest
    {
        private bool? _defaultOnly;
        private string _engine;
        private string _engineVersion;
        private int? _maxResults;
        private string _nextToken;
        private string _parameterGroupFamily;

        /// <summary>
        /// Gets and sets the property DefaultOnly. 
        /// <para>
        /// If true, specifies that only the default version of the specified engine or engine
        /// and major version combination is to be returned.
        /// </para>
        /// </summary>
        public bool? DefaultOnly
        {
            get { return this._defaultOnly; }
            set { this._defaultOnly = value; }
        }

        // Check to see if DefaultOnly property is set
        internal bool IsSetDefaultOnly()
        {
            return this._defaultOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine for which to list available versions.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The Redis OSS engine version
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxResults value, a token is included in the response so that the remaining
        /// results can be retrieved.
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
        /// An optional argument to pass in case the total number of records exceeds the value
        /// of MaxResults. If nextToken is returned, there are more results available. The value
        /// of nextToken is a unique pagination token for each page. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// 
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
        /// Gets and sets the property ParameterGroupFamily. 
        /// <para>
        /// The name of a specific parameter group family to return details for.
        /// </para>
        /// </summary>
        public string ParameterGroupFamily
        {
            get { return this._parameterGroupFamily; }
            set { this._parameterGroupFamily = value; }
        }

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this._parameterGroupFamily != null;
        }

    }
}