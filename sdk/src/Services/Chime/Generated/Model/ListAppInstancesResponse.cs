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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the ListAppInstances operation.
    /// </summary>
    public partial class ListAppInstancesResponse : AmazonWebServiceResponse
    {
        private List<AppInstanceSummary> _appInstances = new List<AppInstanceSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppInstances. 
        /// <para>
        /// The information for each <code>AppInstance</code>.
        /// </para>
        /// </summary>
        public List<AppInstanceSummary> AppInstances
        {
            get { return this._appInstances; }
            set { this._appInstances = value; }
        }

        // Check to see if AppInstances property is set
        internal bool IsSetAppInstances()
        {
            return this._appInstances != null && this._appInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token passed by previous API requests until the maximum number of <code>AppInstance</code>s
        /// is reached.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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