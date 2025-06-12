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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the listProfilingGroupsResponse.
    /// </summary>
    public partial class ListProfilingGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _profilingGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ProfilingGroupDescription> _profilingGroups = AWSConfigs.InitializeCollections ? new List<ProfilingGroupDescription>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>ListProfilingGroups</c> request.
        /// When the results of a <c>ListProfilingGroups</c> request exceed <c>maxResults</c>,
        /// this value can be used to retrieve the next page of results. This value is <c>null</c>
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
        ///  A returned list of profiling group names. A list of the names is returned only if
        /// <c>includeDescription</c> is <c>false</c>, otherwise a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> objects is returned. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._profilingGroupNames != null && (this._profilingGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroups. 
        /// <para>
        ///  A returned list <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> objects. A list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> objects is returned only if <c>includeDescription</c>
        /// is <c>true</c>, otherwise a list of profiling group names is returned. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfilingGroupDescription> ProfilingGroups
        {
            get { return this._profilingGroups; }
            set { this._profilingGroups = value; }
        }

        // Check to see if ProfilingGroups property is set
        internal bool IsSetProfilingGroups()
        {
            return this._profilingGroups != null && (this._profilingGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}