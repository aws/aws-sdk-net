/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetParametersByPath operation.
    /// Retrieve parameters in a specific hierarchy. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-working.html">Working
    /// with Systems Manager Parameters</a>.
    /// </summary>
    public partial class GetParametersByPathRequest : AmazonSimpleSystemsManagementRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<ParameterStringFilter> _parameterFilters = new List<ParameterStringFilter>();
        private string _path;
        private bool? _recursive;
        private bool? _withDecryption;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// A token to start the list. Use this token to get the next set of results. 
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
        /// Gets and sets the property ParameterFilters. 
        /// <para>
        /// Filters to limit the request results.
        /// </para>
        /// </summary>
        public List<ParameterStringFilter> ParameterFilters
        {
            get { return this._parameterFilters; }
            set { this._parameterFilters = value; }
        }

        // Check to see if ParameterFilters property is set
        internal bool IsSetParameterFilters()
        {
            return this._parameterFilters != null && this._parameterFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The hierarchy for the parameter. Hierarchies start with a forward slash (/) and end
        /// with the parameter name. A hierarchy can have a maximum of five levels. Examples:
        /// /Environment/Test/DBString003
        /// </para>
        ///  
        /// <para>
        /// /Finance/Prod/IAD/OS/WinServ2016/license15
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// Retrieve all parameters within a hierarchy.
        /// </para>
        /// </summary>
        public bool Recursive
        {
            get { return this._recursive.GetValueOrDefault(); }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithDecryption. 
        /// <para>
        /// Retrieve all parameters in a hierarchy with their value decrypted.
        /// </para>
        /// </summary>
        public bool WithDecryption
        {
            get { return this._withDecryption.GetValueOrDefault(); }
            set { this._withDecryption = value; }
        }

        // Check to see if WithDecryption property is set
        internal bool IsSetWithDecryption()
        {
            return this._withDecryption.HasValue; 
        }

    }
}