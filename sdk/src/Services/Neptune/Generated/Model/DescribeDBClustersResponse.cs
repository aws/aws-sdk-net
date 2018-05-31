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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>DescribeDBClusters</a> action.
    /// </summary>
    public partial class DescribeDBClustersResponse : AmazonWebServiceResponse
    {
        private List<DBCluster> _dbClusters = new List<DBCluster>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property DBClusters. 
        /// <para>
        /// Contains a list of DB clusters for the user.
        /// </para>
        /// </summary>
        public List<DBCluster> DBClusters
        {
            get { return this._dbClusters; }
            set { this._dbClusters = value; }
        }

        // Check to see if DBClusters property is set
        internal bool IsSetDBClusters()
        {
            return this._dbClusters != null && this._dbClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that can be used in a subsequent DescribeDBClusters request.
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