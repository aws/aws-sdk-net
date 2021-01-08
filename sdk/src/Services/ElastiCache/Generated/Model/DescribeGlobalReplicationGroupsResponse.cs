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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// This is the response object from the DescribeGlobalReplicationGroups operation.
    /// </summary>
    public partial class DescribeGlobalReplicationGroupsResponse : AmazonWebServiceResponse
    {
        private List<GlobalReplicationGroup> _globalReplicationGroups = new List<GlobalReplicationGroup>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroups. 
        /// <para>
        /// Indicates the slot configuration and global identifier for each slice group.
        /// </para>
        /// </summary>
        public List<GlobalReplicationGroup> GlobalReplicationGroups
        {
            get { return this._globalReplicationGroups; }
            set { this._globalReplicationGroups = value; }
        }

        // Check to see if GlobalReplicationGroups property is set
        internal bool IsSetGlobalReplicationGroups()
        {
            return this._globalReplicationGroups != null && this._globalReplicationGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by MaxRecords. &gt;
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}