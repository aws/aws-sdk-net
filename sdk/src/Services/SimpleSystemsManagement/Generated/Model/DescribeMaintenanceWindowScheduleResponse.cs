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
    /// This is the response object from the DescribeMaintenanceWindowSchedule operation.
    /// </summary>
    public partial class DescribeMaintenanceWindowScheduleResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScheduledWindowExecution> _scheduledWindowExecutions = new List<ScheduledWindowExecution>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You use this token in the next call.)
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
        /// Gets and sets the property ScheduledWindowExecutions. 
        /// <para>
        /// Information about Maintenance Window executions scheduled for the specified time range.
        /// </para>
        /// </summary>
        public List<ScheduledWindowExecution> ScheduledWindowExecutions
        {
            get { return this._scheduledWindowExecutions; }
            set { this._scheduledWindowExecutions = value; }
        }

        // Check to see if ScheduledWindowExecutions property is set
        internal bool IsSetScheduledWindowExecutions()
        {
            return this._scheduledWindowExecutions != null && this._scheduledWindowExecutions.Count > 0; 
        }

    }
}