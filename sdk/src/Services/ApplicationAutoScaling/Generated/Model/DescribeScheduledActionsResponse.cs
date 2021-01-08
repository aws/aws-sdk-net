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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// This is the response object from the DescribeScheduledActions operation.
    /// </summary>
    public partial class DescribeScheduledActionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScheduledAction> _scheduledActions = new List<ScheduledAction>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required to get the next set of results. This value is <code>null</code>
        /// if there are no more results to return.
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
        /// Gets and sets the property ScheduledActions. 
        /// <para>
        /// Information about the scheduled actions.
        /// </para>
        /// </summary>
        public List<ScheduledAction> ScheduledActions
        {
            get { return this._scheduledActions; }
            set { this._scheduledActions = value; }
        }

        // Check to see if ScheduledActions property is set
        internal bool IsSetScheduledActions()
        {
            return this._scheduledActions != null && this._scheduledActions.Count > 0; 
        }

    }
}