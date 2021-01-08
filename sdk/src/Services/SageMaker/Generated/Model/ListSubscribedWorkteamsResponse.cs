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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListSubscribedWorkteams operation.
    /// </summary>
    public partial class ListSubscribedWorkteamsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SubscribedWorkteam> _subscribedWorkteams = new List<SubscribedWorkteam>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon SageMaker returns this token. To retrieve the
        /// next set of work teams, use it in the subsequent request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property SubscribedWorkteams. 
        /// <para>
        /// An array of <code>Workteam</code> objects, each describing a work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SubscribedWorkteam> SubscribedWorkteams
        {
            get { return this._subscribedWorkteams; }
            set { this._subscribedWorkteams = value; }
        }

        // Check to see if SubscribedWorkteams property is set
        internal bool IsSetSubscribedWorkteams()
        {
            return this._subscribedWorkteams != null && this._subscribedWorkteams.Count > 0; 
        }

    }
}