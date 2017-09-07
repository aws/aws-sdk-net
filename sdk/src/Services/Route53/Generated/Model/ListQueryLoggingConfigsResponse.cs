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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the ListQueryLoggingConfigs operation.
    /// </summary>
    public partial class ListQueryLoggingConfigsResponse : AmazonWebServiceResponse
    {
        private List<QueryLoggingConfig> _queryLoggingConfigs = new List<QueryLoggingConfig>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property QueryLoggingConfigs. 
        /// <para>
        /// An array that contains one <a>QueryLoggingConfig</a> element for each configuration
        /// for DNS query logging that is associated with the current AWS account.
        /// </para>
        /// </summary>
        public List<QueryLoggingConfig> QueryLoggingConfigs
        {
            get { return this._queryLoggingConfigs; }
            set { this._queryLoggingConfigs = value; }
        }

        // Check to see if QueryLoggingConfigs property is set
        internal bool IsSetQueryLoggingConfigs()
        {
            return this._queryLoggingConfigs != null && this._queryLoggingConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a response includes the last of the query logging configurations that are associated
        /// with the current AWS account, <code>NextToken</code> doesn't appear in the response.
        /// </para>
        ///  
        /// <para>
        /// If a response doesn't include the last of the configurations, you can get more configurations
        /// by submitting another <a>ListQueryLoggingConfigs</a> request. Get the value of <code>NextToken</code>
        /// that Amazon Route 53 returned in the previous response and include it in <code>NextToken</code>
        /// in the next request.
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