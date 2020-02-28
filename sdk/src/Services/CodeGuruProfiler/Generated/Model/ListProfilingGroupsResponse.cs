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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the listProfilingGroupsResponse.
    /// </summary>
    public partial class ListProfilingGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _profilingGroupNames = new List<string>();
        private List<ProfilingGroupDescription> _profilingGroups = new List<ProfilingGroupDescription>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListProfilingGroups</code>
        /// request. When the results of a <code>ListProfilingGroups</code> request exceed <code>maxResults</code>,
        /// this value can be used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ProfilingGroupNames. 
        /// <para>
        /// Information about profiling group names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ProfilingGroupNames
        {
            get { return this._profilingGroupNames; }
            set { this._profilingGroupNames = value; }
        }

        // Check to see if ProfilingGroupNames property is set
        internal bool IsSetProfilingGroupNames()
        {
            return this._profilingGroupNames != null && this._profilingGroupNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroups. 
        /// <para>
        /// Information about profiling groups.
        /// </para>
        /// </summary>
        public List<ProfilingGroupDescription> ProfilingGroups
        {
            get { return this._profilingGroups; }
            set { this._profilingGroups = value; }
        }

        // Check to see if ProfilingGroups property is set
        internal bool IsSetProfilingGroups()
        {
            return this._profilingGroups != null && this._profilingGroups.Count > 0; 
        }

    }
}