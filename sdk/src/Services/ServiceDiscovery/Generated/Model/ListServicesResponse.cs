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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// This is the response object from the ListServices operation.
    /// </summary>
    public partial class ListServicesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServiceSummary> _services = new List<ServiceSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If more than <code>MaxResults</code> operations match the specified criteria, the
        /// value of <code>NextToken</code> is the first service in the next group of services
        /// that were created by the current AWS account. To get the next group, specify the value
        /// of <code>NextToken</code> from the previous response in the next request.
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
        /// Gets and sets the property Services. 
        /// <para>
        /// An array that contains one <code>ServiceSummary</code> object for each service that
        /// matches the specified filter criteria.
        /// </para>
        /// </summary>
        public List<ServiceSummary> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && this._services.Count > 0; 
        }

    }
}