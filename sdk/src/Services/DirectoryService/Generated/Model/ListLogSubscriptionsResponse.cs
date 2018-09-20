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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the ListLogSubscriptions operation.
    /// </summary>
    public partial class ListLogSubscriptionsResponse : AmazonWebServiceResponse
    {
        private List<LogSubscription> _logSubscriptions = new List<LogSubscription>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LogSubscriptions. 
        /// <para>
        /// A list of active <a>LogSubscription</a> objects for calling the AWS account.
        /// </para>
        /// </summary>
        public List<LogSubscription> LogSubscriptions
        {
            get { return this._logSubscriptions; }
            set { this._logSubscriptions = value; }
        }

        // Check to see if LogSubscriptions property is set
        internal bool IsSetLogSubscriptions()
        {
            return this._logSubscriptions != null && this._logSubscriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return.
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