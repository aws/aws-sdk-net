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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMaintenanceWindowExecutions operation.
    /// Lists the executions of a maintenance window. This includes information about when
    /// the maintenance window was scheduled to be active, and information about tasks registered
    /// and run with the maintenance window.
    /// </summary>
    public partial class DescribeMaintenanceWindowExecutionsRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<MaintenanceWindowFilter> _filters = new List<MaintenanceWindowFilter>();
        private int? _maxResults;
        private string _nextToken;
        private string _windowId;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Each entry in the array is a structure containing:
        /// </para>
        ///  
        /// <para>
        /// Key (string, between 1 and 128 characters)
        /// </para>
        ///  
        /// <para>
        /// Values (array of strings, each string is between 1 and 256 characters)
        /// </para>
        ///  
        /// <para>
        /// The supported Keys are ExecutedBefore and ExecutedAfter with the value being a date/time
        /// string such as 2016-11-04T05:00:00Z.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<MaintenanceWindowFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=100)]
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window whose executions should be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

    }
}