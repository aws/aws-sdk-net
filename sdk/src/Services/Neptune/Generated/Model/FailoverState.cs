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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the state of scheduled or in-process operations on a global cluster (Neptune
    /// global database). This data type is empty unless a switchover or failover operation
    /// is scheduled or is in progress on the Neptune global database.
    /// </summary>
    public partial class FailoverState
    {
        private string _fromDbClusterArn;
        private bool? _isDataLossAllowed;
        private FailoverStatus _status;
        private string _toDbClusterArn;

        /// <summary>
        /// Gets and sets the property FromDbClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Neptune DB cluster that is currently being demoted,
        /// and which is associated with this state.
        /// </para>
        /// </summary>
        public string FromDbClusterArn
        {
            get { return this._fromDbClusterArn; }
            set { this._fromDbClusterArn = value; }
        }

        // Check to see if FromDbClusterArn property is set
        internal bool IsSetFromDbClusterArn()
        {
            return this._fromDbClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property IsDataLossAllowed. 
        /// <para>
        /// Indicates whether the operation is a global switchover or a global failover. If data
        /// loss is allowed, then the operation is a global failover. Otherwise, it's a switchover.
        /// </para>
        /// </summary>
        public bool? IsDataLossAllowed
        {
            get { return this._isDataLossAllowed; }
            set { this._isDataLossAllowed = value; }
        }

        // Check to see if IsDataLossAllowed property is set
        internal bool IsSetIsDataLossAllowed()
        {
            return this._isDataLossAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the global cluster. Possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// pending &#x96; The service received a request to switch over or fail over the global
        /// cluster. The global cluster's primary DB cluster and the specified secondary DB cluster
        /// are being verified before the operation starts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// failing-over &#x96; Neptune is promoting the chosen secondary Neptune DB cluster to
        /// become the new primary DB cluster to fail over the global cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// cancelling &#x96; The request to switch over or fail over the global cluster was cancelled
        /// and the primary Neptune DB cluster and the selected secondary Neptune DB cluster are
        /// returning to their previous states.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// switching-over &#x96; This status covers the range of Neptune internal operations
        /// that take place during the switchover process, such as demoting the primary Neptune
        /// DB cluster, promoting the secondary Neptune DB cluster, and synchronizing replicas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FailoverStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ToDbClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Neptune DB cluster that is currently being promoted,
        /// and which is associated with this state.
        /// </para>
        /// </summary>
        public string ToDbClusterArn
        {
            get { return this._toDbClusterArn; }
            set { this._toDbClusterArn = value; }
        }

        // Check to see if ToDbClusterArn property is set
        internal bool IsSetToDbClusterArn()
        {
            return this._toDbClusterArn != null;
        }

    }
}