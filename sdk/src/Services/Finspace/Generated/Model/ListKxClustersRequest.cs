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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the ListKxClusters operation.
    /// Returns a list of clusters.
    /// </summary>
    public partial class ListKxClustersRequest : AmazonFinspaceRequest
    {
        private KxClusterType _clusterType;
        private string _environmentId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// Specifies the type of KDB database that is being created. The following types are
        /// available: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HDB – A Historical Database. The data is only accessible with read-only permissions
        /// from one of the FinSpace managed kdb databases mounted to the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDB – A Realtime Database. This type of database captures all the data from a ticker
        /// plant and stores it in memory until the end of day, after which it writes all of its
        /// data to a disk and reloads the HDB. This cluster type requires local storage for temporary
        /// storage of data during the savedown process. If you specify this field in your request,
        /// you must provide the <c>savedownStorageConfiguration</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GATEWAY – A gateway cluster allows you to access data across processes in kdb systems.
        /// It allows you to create your own routing logic using the initialization scripts and
        /// custom code. This type of cluster does not require a writable local storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GP – A general purpose cluster allows you to quickly iterate on code during development
        /// by granting greater access to system commands and enabling a fast reload of custom
        /// code. This cluster type can optionally mount databases including cache and savedown
        /// storage. For this cluster type, the node count is fixed at 1. It does not support
        /// autoscaling and supports only <c>SINGLE</c> AZ mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tickerplant – A tickerplant cluster allows you to subscribe to feed handlers based
        /// on IAM permissions. It can publish to RDBs, other Tickerplants, and real-time subscribers
        /// (RTS). Tickerplants can persist messages to log, which is readable by any RDB environment.
        /// It supports only single-node that is only one kdb process.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// A token that indicates where a results page should begin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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