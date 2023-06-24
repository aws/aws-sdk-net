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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceVersions operation.
    /// Lists all supported versions for Snow on-device services. Returns an array of <code>ServiceVersion</code>
    /// object containing the supported versions for a particular service.
    /// </summary>
    public partial class ListServiceVersionsRequest : AmazonSnowballRequest
    {
        private List<DependentService> _dependentServices = new List<DependentService>();
        private int? _maxResults;
        private string _nextToken;
        private ServiceName _serviceName;

        /// <summary>
        /// Gets and sets the property DependentServices. 
        /// <para>
        /// A list of names and versions of dependant services of the requested service.
        /// </para>
        /// </summary>
        public List<DependentService> DependentServices
        {
            get { return this._dependentServices; }
            set { this._dependentServices = value; }
        }

        // Check to see if DependentServices property is set
        internal bool IsSetDependentServices()
        {
            return this._dependentServices != null && this._dependentServices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of <code>ListServiceVersions</code> objects to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Because HTTP requests are stateless, this is the starting point for the next list
        /// of returned <code>ListServiceVersionsRequest</code> versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service for which you're requesting supported versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceName ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}