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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Contains an aggregate summary of log groups grouped by data source characteristics,
    /// including the count of log groups and their grouping identifiers.
    /// </summary>
    public partial class AggregateLogGroupSummary
    {
        private List<GroupingIdentifier> _groupingIdentifiers = AWSConfigs.InitializeCollections ? new List<GroupingIdentifier>() : null;
        private int? _logGroupCount;

        /// <summary>
        /// Gets and sets the property GroupingIdentifiers. 
        /// <para>
        /// An array of key-value pairs that identify the data source characteristics used to
        /// group the log groups.
        /// </para>
        ///  
        /// <para>
        /// The size and content of this array depends on the <c>groupBy</c> parameter specified
        /// in the request.
        /// </para>
        /// </summary>
        public List<GroupingIdentifier> GroupingIdentifiers
        {
            get { return this._groupingIdentifiers; }
            set { this._groupingIdentifiers = value; }
        }

        // Check to see if GroupingIdentifiers property is set
        internal bool IsSetGroupingIdentifiers()
        {
            return this._groupingIdentifiers != null && (this._groupingIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogGroupCount. 
        /// <para>
        /// The number of log groups in this aggregate summary group.
        /// </para>
        /// </summary>
        public int LogGroupCount
        {
            get { return this._logGroupCount.GetValueOrDefault(); }
            set { this._logGroupCount = value; }
        }

        // Check to see if LogGroupCount property is set
        internal bool IsSetLogGroupCount()
        {
            return this._logGroupCount.HasValue; 
        }

    }
}